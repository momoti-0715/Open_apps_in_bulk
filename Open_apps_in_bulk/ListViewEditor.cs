// created by Gemini

using System;
using System.Collections.Generic;
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

        if (listView.Tag is ListViewRowEditController) return;

        // ListView専用の行編集コントローラーを生成
        var controller = new ListViewRowEditController(listView);
        listView.Tag = controller;
    }

    // ボタン等から呼び出す用の外部メソッド（行全体の編集）
    public static void BeginEditSelectedRow(this ListView listView)
    {
        if (listView.Tag is ListViewRowEditController controller)
        {
            controller.BeginEdit();
        }
    }

    // クラスの内部（インナークラス）として定義
    private class ListViewRowEditController
    {
        private readonly ListView _listView;
        private readonly List<TextBox> _textBoxes = new List<TextBox>();
        private ListViewItem _editingItem;

        public ListViewRowEditController(ListView listView)
        {
            _listView = listView;

            // ダブルクリック時のイベント
            _listView.MouseDoubleClick += (sender, e) =>
            {
                ListViewItem item = _listView.GetItemAt(e.X, e.Y);
                if (item == null) return;

                ListViewHitTestInfo hitInfo = _listView.HitTest(e.X, e.Y);
                int subItemIndex = item.SubItems.IndexOf(hitInfo.SubItem);

                // 0列目、1列目、2列目のいずれかであれば編集を許可する
                bool isAllowedColumn = (subItemIndex == 0 || subItemIndex == 1 || subItemIndex == 2);

                if (!isAllowedColumn) return;

                // 許可された列のみ、ピンポイントでそのセルだけ編集を開始
                StartRowEdit(item, specificColumnIndex: subItemIndex);
            };

            // 選択行が変わったら（外れたら）編集を終了して保存
            _listView.SelectedIndexChanged += (sender, e) =>
            {
                if (_editingItem != null && (!_editingItem.Selected || _listView.SelectedItems.Count == 0))
                {
                    SaveAndCloseEdit();
                }
            };

            // ListView自体がスクロールされた時や、サイズが変わった時も位置を追従、または閉じる
            _listView.SizeChanged += (sender, e) => SaveAndCloseEdit();
        }

        public void BeginEdit()
        {
            if (_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("編集する行を選択してください。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // ★修正箇所1: [0] を追加して、最初の選択行オブジェクトを確実に渡す
            StartRowEdit(_listView.SelectedItems[0], specificColumnIndex: -1);
        }

        // 編集を開始するコアロジック（特定の列のみ、または全列に対応）
        private void StartRowEdit(ListViewItem item, int specificColumnIndex = -1)
        {
            if (_editingItem == item) return;
            if (_editingItem != null) SaveAndCloseEdit();

            _editingItem = item;
            Form mainForm = _listView.FindForm();
            if (mainForm == null) return;

            int columnCount = _listView.Columns.Count;

            for (int i = 0; i < columnCount; i++)
            {
                if (specificColumnIndex != -1 && i != specificColumnIndex)
                {
                    _textBoxes.Add(null);
                    continue;
                }

                TextBox txt = new TextBox
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Text = item.SubItems[i].Text
                };

                // セルの位置とサイズ（横幅）を計算
                Rectangle bounds;
                if (i == 0)
                {
                    bounds = item.Bounds;
                    // ★修正箇所2: [0] を追加して、1列目のヘッダー幅を正しく取得
                    bounds.Width = _listView.Columns[0].Width;
                }
                else
                {
                    bounds = item.SubItems[i].Bounds;
                }

                Point formPt = mainForm.PointToClient(_listView.PointToScreen(bounds.Location));

                int textBoxWidth = bounds.Width;
                Point lvRightBottom = mainForm.PointToClient(_listView.PointToScreen(new Point(_listView.Width, _listView.Height)));
                int listViewRightEdge = lvRightBottom.X;

                if (formPt.X >= listViewRightEdge)
                {
                    _textBoxes.Add(null);
                    continue;
                }
                if (formPt.X + textBoxWidth > listViewRightEdge)
                {
                    textBoxWidth = listViewRightEdge - formPt.X - 4;
                }

                txt.SetBounds(formPt.X, formPt.Y, textBoxWidth, bounds.Height);

                txt.KeyDown += (s, ex) =>
                {
                    if (ex.KeyCode == Keys.Enter)
                    {
                        SaveAndCloseEdit();
                        ex.SuppressKeyPress = true;
                    }
                    else if (ex.KeyCode == Keys.Escape)
                    {
                        ClearTextBoxes();
                        _editingItem = null;
                        ex.SuppressKeyPress = true;
                    }
                };

                txt.Leave += (s, ex) =>
                {
                    mainForm.BeginInvoke(new Action(() =>
                    {
                        if (_editingItem != null && !IsAnyTextBoxFocused())
                        {
                            SaveAndCloseEdit();
                        }
                    }));
                };

                mainForm.Controls.Add(txt);
                txt.BringToFront();
                _textBoxes.Add(txt);
            }

            foreach (var txt in _textBoxes)
            {
                if (txt != null)
                {
                    txt.Focus();
                    txt.SelectAll();
                    break;
                }
            }
        }

        private void SaveAndCloseEdit()
        {
            if (_editingItem == null || _textBoxes.Count == 0) return;

            for (int i = 0; i < _textBoxes.Count; i++)
            {
                if (_textBoxes[i] != null && i < _editingItem.SubItems.Count)
                {
                    _editingItem.SubItems[i].Text = _textBoxes[i].Text;
                }
            }

            ClearTextBoxes();
            _editingItem = null;
            _listView.Focus();
        }

        private void ClearTextBoxes()
        {
            foreach (var txt in _textBoxes)
            {
                if (txt == null) continue;
                txt.Parent?.Controls.Remove(txt);
                txt.Dispose();
            }
            _textBoxes.Clear();
        }

        private bool IsAnyTextBoxFocused()
        {
            foreach (var txt in _textBoxes)
            {
                if (txt != null && txt.Focused) return true;
            }
            return false;
        }
    }
}
