using System;
using System.Drawing;
using System.Windows.Forms;

public static class ListViewEditor
{
    // ListViewにインプレース編集機能を付与する拡張メソッド
    public static void EnableInPlaceEdit(this ListView listView)
    {
        // 必須の設定を強制適用
        listView.View = View.Details;
        listView.FullRowSelect = true;
        listView.MultiSelect = false;
        listView.LabelEdit = false;

        // 編集用 TextBox の動的生成
        TextBox editTextBox = new TextBox
        {
            Visible = false,
            BorderStyle = BorderStyle.FixedSingle
        };

        // 編集状態を保持するクラス
        var state = new EditState();

        // フォームがロードされた時、またはListViewが配置されている親コントロールにTextBoxを追加
        listView.HandleCreated += (s, e) =>
        {
            listView.FindForm()?.Controls.Add(editTextBox);
        };

        // ダブルクリックイベント
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
                    bounds.Width = listView.Columns[0].Width; // 1列目の幅
                }
                else
                {
                    bounds = hitInfo.SubItem.Bounds;
                }

                // TextBoxの位置をListView基準からForm基準の座標に変換して配置
                Point formPt = listView.FindForm().PointToClient(listView.PointToScreen(bounds.Location));
                editTextBox.SetBounds(formPt.X, formPt.Y, bounds.Width, bounds.Height);

                editTextBox.Text = hitInfo.SubItem.Text;
                editTextBox.Visible = true;
                editTextBox.Focus();
                editTextBox.SelectAll();
                editTextBox.BringToFront();
            }
        };

        // 確定処理のラムダ式
        Action saveAndCloseEdit = () =>
        {
            if (editTextBox.Visible && state.EditingItem != null && state.EditingSubItemIndex >= 0)
            {
                state.EditingItem.SubItems[state.EditingSubItemIndex].Text = editTextBox.Text;
                editTextBox.Visible = false;
                state.Reset();
            }
        };

        // フォーカスアウトで確定
        editTextBox.Leave += (sender, e) => saveAndCloseEdit();

        // キー入力制御
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

    // 内部用の状態管理クラス
    private class EditState
    {
        public ListViewItem EditingItem { get; set; }
        public int EditingSubItemIndex { get; set; } = -1;
        public void Reset() { EditingItem = null; EditingSubItemIndex = -1; }
    }
}
