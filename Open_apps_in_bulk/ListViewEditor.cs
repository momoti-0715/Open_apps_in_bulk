using System;
using System.Drawing;
using System.Windows.Forms;

public static class ListViewEditor
{
    public static void EnableInPlaceEdit(this ListView listView)
    {
        listView.View = View.Details;
        listView.FullRowSelect = true;
        listView.MultiSelect = false;
        listView.LabelEdit = false;

        TextBox editTextBox = new TextBox
        {
            Visible = false,
            BorderStyle = BorderStyle.FixedSingle
        };

        var state = new EditState();

        // --- ★追加：画面外のクリックを検知するフィルター ---
        var mouseFilter = new ClickMessageFilter(editTextBox, () =>
        {
            if (editTextBox.Visible && state.EditingItem != null && state.EditingSubItemIndex >= 0)
            {
                state.EditingItem.SubItems[state.EditingSubItemIndex].Text = editTextBox.Text;
                editTextBox.Visible = false;
                state.Reset();
            }
        });

        // フォームがロードされた時の処理
        listView.HandleCreated += (s, e) =>
        {
            Form mainForm = listView.FindForm();
            if (mainForm != null)
            {
                mainForm.Controls.Add(editTextBox);

                // フォームが開いている間、マウス監視を開始
                Application.AddMessageFilter(mouseFilter);

                // フォームが閉じるときに監視を解除
                mainForm.FormClosed += (sender, args) =>
                {
                    Application.RemoveMessageFilter(mouseFilter);
                };
            }
        };

        listView.MouseDoubleClick += (sender, e) =>
        {
            ListViewItem item = listView.GetItemAt(e.X, e.Y);
            if (item == null) return;

            ListViewHitTestInfo hitInfo = listView.HitTest(e.X, e.Y);
            int subItemIndex = item.SubItems.IndexOf(hitInfo.SubItem);

            if (subItemIndex >= 0)
            {
                state.EditingItem = item;
                state.EditingSubItemIndex = subItemIndex;

                Rectangle bounds;
                if (subItemIndex == 0)
                {
                    bounds = item.Bounds;
                    bounds.Width = listView.Columns[0].Width; // インデックス0を明示
                }
                else
                {
                    bounds = hitInfo.SubItem.Bounds;
                }

                Form mainForm = listView.FindForm();
                if (mainForm == null) return;

                Point formPt = mainForm.PointToClient(listView.PointToScreen(bounds.Location));

                int textBoxWidth = bounds.Width;
                Point lvRightBottom = mainForm.PointToClient(listView.PointToScreen(new Point(listView.Width, listView.Height)));
                int listViewRightEdge = lvRightBottom.X;

                if (formPt.X + textBoxWidth > listViewRightEdge)
                {
                    textBoxWidth = listViewRightEdge - formPt.X - 4;
                }
                if (textBoxWidth < 10) textBoxWidth = 10;

                editTextBox.SetBounds(formPt.X, formPt.Y, textBoxWidth, bounds.Height);
                editTextBox.Text = hitInfo.SubItem.Text;
                editTextBox.Visible = true;
                editTextBox.Focus();
                editTextBox.SelectAll();
                editTextBox.BringToFront();
            }
        };

        void saveAndCloseEdit()
        {
            if (editTextBox.Visible && state.EditingItem != null && state.EditingSubItemIndex >= 0)
            {
                state.EditingItem.SubItems[state.EditingSubItemIndex].Text = editTextBox.Text;
                editTextBox.Visible = false;
                state.Reset();
            }
        }

        editTextBox.Leave += (sender, e) => saveAndCloseEdit();

        editTextBox.KeyDown += (sender, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveAndCloseEdit();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                editTextBox.Visible = false;
                state.Reset();
                e.SuppressKeyPress = true;
            }
        };
    }

    private class EditState
    {
        public ListViewItem EditingItem { get; set; }
        public int EditingSubItemIndex { get; set; } = -1;
        public void Reset() { EditingItem = null; EditingSubItemIndex = -1; }
    }

    // --- ★追加：アプリ全体の左クリックを監視するインターフェース実装 ---
    private class ClickMessageFilter : IMessageFilter
    {
        private readonly TextBox _targetTextBox;
        private readonly Action _onOutsideClick;
        private const int WM_LBUTTONDOWN = 0x0201; // 左マウスボタンが押されたとき

        public ClickMessageFilter(TextBox targetTextBox, Action onOutsideClick)
        {
            _targetTextBox = targetTextBox;
            _onOutsideClick = onOutsideClick;
        }

        public bool PreFilterMessage(ref Message m)
        {
            // 左クリックが押されたとき、かつTextBoxが表示されているときのみ判定
            if (m.Msg == WM_LBUTTONDOWN && _targetTextBox.Visible)
            {
                // クリックされた座標が TextBox の中かどうかを判定
                Point cursorPt = _targetTextBox.PointToClient(Cursor.Position);
                if (!_targetTextBox.ClientRectangle.Contains(cursorPt))
                {
                    // TextBoxの外をクリックした場合は同期的に編集を終了
                    _onOutsideClick?.Invoke();
                }
            }
            return false; // 他のコントロールの標準クリックイベントも邪魔しないようにfalseを返す
        }
    }
}