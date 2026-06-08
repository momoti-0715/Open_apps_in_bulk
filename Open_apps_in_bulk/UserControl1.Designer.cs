namespace Open_apps_in_bulk
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.groupBoxCmd = new System.Windows.Forms.GroupBox();
            this.buttonCmdDel = new System.Windows.Forms.Button();
            this.buttonCmdEdit = new System.Windows.Forms.Button();
            this.buttonCmdNew = new System.Windows.Forms.Button();
            this.listViewCmd = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.listViewTask = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonTaskRef = new System.Windows.Forms.Button();
            this.buttonTaskDel = new System.Windows.Forms.Button();
            this.buttonTaskEdit = new System.Windows.Forms.Button();
            this.buttonTaskNew = new System.Windows.Forms.Button();
            this.groupBoxWeb = new System.Windows.Forms.GroupBox();
            this.listViewWeb = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBrowserPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWebDel = new System.Windows.Forms.Button();
            this.buttonWebEdit = new System.Windows.Forms.Button();
            this.buttonWebNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCmd.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSName
            // 
            this.textBoxSName.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSName.Location = new System.Drawing.Point(171, 14);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(330, 26);
            this.textBoxSName.TabIndex = 1;
            // 
            // groupBoxCmd
            // 
            this.groupBoxCmd.Controls.Add(this.buttonCmdDel);
            this.groupBoxCmd.Controls.Add(this.buttonCmdEdit);
            this.groupBoxCmd.Controls.Add(this.buttonCmdNew);
            this.groupBoxCmd.Controls.Add(this.listViewCmd);
            this.groupBoxCmd.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxCmd.Location = new System.Drawing.Point(20, 810);
            this.groupBoxCmd.Name = "groupBoxCmd";
            this.groupBoxCmd.Size = new System.Drawing.Size(972, 342);
            this.groupBoxCmd.TabIndex = 15;
            this.groupBoxCmd.TabStop = false;
            this.groupBoxCmd.Text = "コマンド";
            // 
            // buttonCmdDel
            // 
            this.buttonCmdDel.Location = new System.Drawing.Point(841, 302);
            this.buttonCmdDel.Name = "buttonCmdDel";
            this.buttonCmdDel.Size = new System.Drawing.Size(115, 29);
            this.buttonCmdDel.TabIndex = 16;
            this.buttonCmdDel.Text = "削除";
            this.buttonCmdDel.UseVisualStyleBackColor = true;
            this.buttonCmdDel.Click += new System.EventHandler(this.ButtonCmdDel_Click);
            // 
            // buttonCmdEdit
            // 
            this.buttonCmdEdit.Location = new System.Drawing.Point(720, 302);
            this.buttonCmdEdit.Name = "buttonCmdEdit";
            this.buttonCmdEdit.Size = new System.Drawing.Size(115, 29);
            this.buttonCmdEdit.TabIndex = 15;
            this.buttonCmdEdit.Text = "編集";
            this.buttonCmdEdit.UseVisualStyleBackColor = true;
            this.buttonCmdEdit.Click += new System.EventHandler(this.ButtonCmdEdit_Click);
            // 
            // buttonCmdNew
            // 
            this.buttonCmdNew.Location = new System.Drawing.Point(599, 302);
            this.buttonCmdNew.Name = "buttonCmdNew";
            this.buttonCmdNew.Size = new System.Drawing.Size(115, 29);
            this.buttonCmdNew.TabIndex = 14;
            this.buttonCmdNew.Text = "新規";
            this.buttonCmdNew.UseVisualStyleBackColor = true;
            this.buttonCmdNew.Click += new System.EventHandler(this.ButtonCmdNew_Click);
            // 
            // listViewCmd
            // 
            this.listViewCmd.BackColor = System.Drawing.SystemColors.Window;
            this.listViewCmd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewCmd.FullRowSelect = true;
            this.listViewCmd.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listViewCmd.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewCmd.HideSelection = false;
            this.listViewCmd.LabelEdit = true;
            this.listViewCmd.Location = new System.Drawing.Point(25, 34);
            this.listViewCmd.MultiSelect = false;
            this.listViewCmd.Name = "listViewCmd";
            this.listViewCmd.ShowGroups = false;
            this.listViewCmd.Size = new System.Drawing.Size(915, 256);
            this.listViewCmd.TabIndex = 13;
            this.listViewCmd.UseCompatibleStateImageBehavior = false;
            this.listViewCmd.View = System.Windows.Forms.View.Details;
            this.listViewCmd.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_ItemSelectionChanged);
            this.listViewCmd.SelectedIndexChanged += new System.EventHandler(this.ButtonWebNew_Click);
            this.listViewCmd.Leave += new System.EventHandler(this.ListView_Leave);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "カレントディレクトリ　　　　　";
            this.columnHeader1.Width = 201;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "コマンド";
            this.columnHeader2.Width = 640;
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.listViewTask);
            this.groupBoxTask.Controls.Add(this.buttonTaskRef);
            this.groupBoxTask.Controls.Add(this.buttonTaskDel);
            this.groupBoxTask.Controls.Add(this.buttonTaskEdit);
            this.groupBoxTask.Controls.Add(this.buttonTaskNew);
            this.groupBoxTask.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxTask.Location = new System.Drawing.Point(20, 454);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(972, 342);
            this.groupBoxTask.TabIndex = 16;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "アプリケーション";
            // 
            // listViewTask
            // 
            this.listViewTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listViewTask.FullRowSelect = true;
            this.listViewTask.GridLines = true;
            this.listViewTask.HideSelection = false;
            this.listViewTask.LabelEdit = true;
            this.listViewTask.Location = new System.Drawing.Point(25, 34);
            this.listViewTask.Name = "listViewTask";
            this.listViewTask.Size = new System.Drawing.Size(915, 256);
            this.listViewTask.TabIndex = 8;
            this.listViewTask.UseCompatibleStateImageBehavior = false;
            this.listViewTask.View = System.Windows.Forms.View.Details;
            this.listViewTask.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_ItemSelectionChanged);
            this.listViewTask.Leave += new System.EventHandler(this.ListView_Leave);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PATH";
            this.columnHeader4.Width = 900;
            // 
            // buttonTaskRef
            // 
            this.buttonTaskRef.Location = new System.Drawing.Point(599, 304);
            this.buttonTaskRef.Name = "buttonTaskRef";
            this.buttonTaskRef.Size = new System.Drawing.Size(115, 29);
            this.buttonTaskRef.TabIndex = 11;
            this.buttonTaskRef.Text = "参照";
            this.buttonTaskRef.UseVisualStyleBackColor = true;
            this.buttonTaskRef.Click += new System.EventHandler(this.ButtonTaskRef_Click);
            // 
            // buttonTaskDel
            // 
            this.buttonTaskDel.Location = new System.Drawing.Point(841, 304);
            this.buttonTaskDel.Name = "buttonTaskDel";
            this.buttonTaskDel.Size = new System.Drawing.Size(115, 29);
            this.buttonTaskDel.TabIndex = 12;
            this.buttonTaskDel.Text = "削除";
            this.buttonTaskDel.UseVisualStyleBackColor = true;
            this.buttonTaskDel.Click += new System.EventHandler(this.ButtonTaskDel_Click);
            // 
            // buttonTaskEdit
            // 
            this.buttonTaskEdit.Location = new System.Drawing.Point(720, 304);
            this.buttonTaskEdit.Name = "buttonTaskEdit";
            this.buttonTaskEdit.Size = new System.Drawing.Size(115, 29);
            this.buttonTaskEdit.TabIndex = 10;
            this.buttonTaskEdit.Text = "編集";
            this.buttonTaskEdit.UseVisualStyleBackColor = true;
            this.buttonTaskEdit.Click += new System.EventHandler(this.ButtonTaskEdit_Click);
            // 
            // buttonTaskNew
            // 
            this.buttonTaskNew.Location = new System.Drawing.Point(478, 304);
            this.buttonTaskNew.Name = "buttonTaskNew";
            this.buttonTaskNew.Size = new System.Drawing.Size(115, 29);
            this.buttonTaskNew.TabIndex = 9;
            this.buttonTaskNew.Text = "新規";
            this.buttonTaskNew.UseVisualStyleBackColor = true;
            this.buttonTaskNew.Click += new System.EventHandler(this.ButtonAppNew_Click);
            // 
            // groupBoxWeb
            // 
            this.groupBoxWeb.Controls.Add(this.listViewWeb);
            this.groupBoxWeb.Controls.Add(this.button1);
            this.groupBoxWeb.Controls.Add(this.textBoxBrowserPass);
            this.groupBoxWeb.Controls.Add(this.label2);
            this.groupBoxWeb.Controls.Add(this.buttonWebDel);
            this.groupBoxWeb.Controls.Add(this.buttonWebEdit);
            this.groupBoxWeb.Controls.Add(this.buttonWebNew);
            this.groupBoxWeb.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxWeb.Location = new System.Drawing.Point(20, 60);
            this.groupBoxWeb.Name = "groupBoxWeb";
            this.groupBoxWeb.Size = new System.Drawing.Size(972, 379);
            this.groupBoxWeb.TabIndex = 17;
            this.groupBoxWeb.TabStop = false;
            this.groupBoxWeb.Text = "ウェブサイト";
            // 
            // listViewWeb
            // 
            this.listViewWeb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listViewWeb.FullRowSelect = true;
            this.listViewWeb.GridLines = true;
            this.listViewWeb.HideSelection = false;
            this.listViewWeb.LabelEdit = true;
            this.listViewWeb.Location = new System.Drawing.Point(25, 69);
            this.listViewWeb.Name = "listViewWeb";
            this.listViewWeb.Size = new System.Drawing.Size(915, 256);
            this.listViewWeb.TabIndex = 4;
            this.listViewWeb.UseCompatibleStateImageBehavior = false;
            this.listViewWeb.View = System.Windows.Forms.View.Details;
            this.listViewWeb.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_ItemSelectionChanged);
            this.listViewWeb.Leave += new System.EventHandler(this.ListView_Leave);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "URL";
            this.columnHeader3.Width = 900;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "参照";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxBrowserPass
            // 
            this.textBoxBrowserPass.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxBrowserPass.Location = new System.Drawing.Point(128, 34);
            this.textBoxBrowserPass.Name = "textBoxBrowserPass";
            this.textBoxBrowserPass.Size = new System.Drawing.Size(697, 26);
            this.textBoxBrowserPass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "ブラウザパス";
            // 
            // buttonWebDel
            // 
            this.buttonWebDel.Location = new System.Drawing.Point(841, 340);
            this.buttonWebDel.Name = "buttonWebDel";
            this.buttonWebDel.Size = new System.Drawing.Size(115, 29);
            this.buttonWebDel.TabIndex = 7;
            this.buttonWebDel.Text = "削除";
            this.buttonWebDel.UseVisualStyleBackColor = true;
            this.buttonWebDel.Click += new System.EventHandler(this.ButtonWebDel_Click);
            // 
            // buttonWebEdit
            // 
            this.buttonWebEdit.Location = new System.Drawing.Point(720, 340);
            this.buttonWebEdit.Name = "buttonWebEdit";
            this.buttonWebEdit.Size = new System.Drawing.Size(115, 29);
            this.buttonWebEdit.TabIndex = 6;
            this.buttonWebEdit.Text = "編集";
            this.buttonWebEdit.UseVisualStyleBackColor = true;
            this.buttonWebEdit.Click += new System.EventHandler(this.ButtonWebEdit_Click);
            // 
            // buttonWebNew
            // 
            this.buttonWebNew.Location = new System.Drawing.Point(599, 340);
            this.buttonWebNew.Name = "buttonWebNew";
            this.buttonWebNew.Size = new System.Drawing.Size(115, 29);
            this.buttonWebNew.TabIndex = 5;
            this.buttonWebNew.Text = "新規";
            this.buttonWebNew.UseVisualStyleBackColor = true;
            this.buttonWebNew.Click += new System.EventHandler(this.ButtonWebNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "ショートカット名";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.textBoxSName);
            this.Controls.Add(this.groupBoxCmd);
            this.Controls.Add(this.groupBoxTask);
            this.Controls.Add(this.groupBoxWeb);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1019, 1175);
            this.groupBoxCmd.ResumeLayout(false);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxWeb.ResumeLayout(false);
            this.groupBoxWeb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.GroupBox groupBoxCmd;
        private System.Windows.Forms.Button buttonCmdDel;
        private System.Windows.Forms.Button buttonCmdEdit;
        private System.Windows.Forms.Button buttonCmdNew;
        private System.Windows.Forms.ListView listViewCmd;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.Button buttonTaskRef;
        private System.Windows.Forms.Button buttonTaskDel;
        private System.Windows.Forms.Button buttonTaskEdit;
        private System.Windows.Forms.Button buttonTaskNew;
        private System.Windows.Forms.GroupBox groupBoxWeb;
        private System.Windows.Forms.Button buttonWebDel;
        private System.Windows.Forms.Button buttonWebEdit;
        private System.Windows.Forms.Button buttonWebNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxBrowserPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewTask;
        private System.Windows.Forms.ListView listViewWeb;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
