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
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.groupBoxCmd = new System.Windows.Forms.GroupBox();
            this.buttonCmdDel = new System.Windows.Forms.Button();
            this.buttonCmdEdit = new System.Windows.Forms.Button();
            this.buttonCmdNew = new System.Windows.Forms.Button();
            this.listViewCmd = new System.Windows.Forms.ListView();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.buttonAppRef = new System.Windows.Forms.Button();
            this.buttonAppDel = new System.Windows.Forms.Button();
            this.buttonAppEdit = new System.Windows.Forms.Button();
            this.buttonAppNew = new System.Windows.Forms.Button();
            this.groupBoxWeb = new System.Windows.Forms.GroupBox();
            this.buttonWebDel = new System.Windows.Forms.Button();
            this.buttonWebEdit = new System.Windows.Forms.Button();
            this.buttonWebNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxTask = new System.Windows.Forms.ListBox();
            this.listBoxWeb = new System.Windows.Forms.ListBox();
            this.textBoxBrowserPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.textBoxSName.TabIndex = 13;
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
            this.buttonCmdDel.TabIndex = 5;
            this.buttonCmdDel.Text = "削除";
            this.buttonCmdDel.UseVisualStyleBackColor = true;
            // 
            // buttonCmdEdit
            // 
            this.buttonCmdEdit.Location = new System.Drawing.Point(720, 302);
            this.buttonCmdEdit.Name = "buttonCmdEdit";
            this.buttonCmdEdit.Size = new System.Drawing.Size(115, 29);
            this.buttonCmdEdit.TabIndex = 4;
            this.buttonCmdEdit.Text = "編集";
            this.buttonCmdEdit.UseVisualStyleBackColor = true;
            // 
            // buttonCmdNew
            // 
            this.buttonCmdNew.Location = new System.Drawing.Point(599, 302);
            this.buttonCmdNew.Name = "buttonCmdNew";
            this.buttonCmdNew.Size = new System.Drawing.Size(115, 29);
            this.buttonCmdNew.TabIndex = 3;
            this.buttonCmdNew.Text = "新規";
            this.buttonCmdNew.UseVisualStyleBackColor = true;
            // 
            // listViewCmd
            // 
            this.listViewCmd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewCmd.HideSelection = false;
            this.listViewCmd.Location = new System.Drawing.Point(25, 34);
            this.listViewCmd.Name = "listViewCmd";
            this.listViewCmd.Size = new System.Drawing.Size(915, 256);
            this.listViewCmd.TabIndex = 0;
            this.listViewCmd.UseCompatibleStateImageBehavior = false;
            this.listViewCmd.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.listBoxTask);
            this.groupBoxTask.Controls.Add(this.buttonAppRef);
            this.groupBoxTask.Controls.Add(this.buttonAppDel);
            this.groupBoxTask.Controls.Add(this.buttonAppEdit);
            this.groupBoxTask.Controls.Add(this.buttonAppNew);
            this.groupBoxTask.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxTask.Location = new System.Drawing.Point(20, 454);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(972, 342);
            this.groupBoxTask.TabIndex = 16;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "アプリケーション";
            // 
            // buttonAppRef
            // 
            this.buttonAppRef.Location = new System.Drawing.Point(720, 304);
            this.buttonAppRef.Name = "buttonAppRef";
            this.buttonAppRef.Size = new System.Drawing.Size(115, 29);
            this.buttonAppRef.TabIndex = 6;
            this.buttonAppRef.Text = "参照";
            this.buttonAppRef.UseVisualStyleBackColor = true;
            // 
            // buttonAppDel
            // 
            this.buttonAppDel.Location = new System.Drawing.Point(841, 304);
            this.buttonAppDel.Name = "buttonAppDel";
            this.buttonAppDel.Size = new System.Drawing.Size(115, 29);
            this.buttonAppDel.TabIndex = 5;
            this.buttonAppDel.Text = "削除";
            this.buttonAppDel.UseVisualStyleBackColor = true;
            // 
            // buttonAppEdit
            // 
            this.buttonAppEdit.Location = new System.Drawing.Point(599, 304);
            this.buttonAppEdit.Name = "buttonAppEdit";
            this.buttonAppEdit.Size = new System.Drawing.Size(115, 29);
            this.buttonAppEdit.TabIndex = 4;
            this.buttonAppEdit.Text = "編集";
            this.buttonAppEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAppNew
            // 
            this.buttonAppNew.Location = new System.Drawing.Point(478, 304);
            this.buttonAppNew.Name = "buttonAppNew";
            this.buttonAppNew.Size = new System.Drawing.Size(115, 29);
            this.buttonAppNew.TabIndex = 3;
            this.buttonAppNew.Text = "新規";
            this.buttonAppNew.UseVisualStyleBackColor = true;
            // 
            // groupBoxWeb
            // 
            this.groupBoxWeb.Controls.Add(this.button1);
            this.groupBoxWeb.Controls.Add(this.textBoxBrowserPass);
            this.groupBoxWeb.Controls.Add(this.label2);
            this.groupBoxWeb.Controls.Add(this.listBoxWeb);
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
            // buttonWebDel
            // 
            this.buttonWebDel.Location = new System.Drawing.Point(841, 340);
            this.buttonWebDel.Name = "buttonWebDel";
            this.buttonWebDel.Size = new System.Drawing.Size(115, 29);
            this.buttonWebDel.TabIndex = 5;
            this.buttonWebDel.Text = "削除";
            this.buttonWebDel.UseVisualStyleBackColor = true;
            // 
            // buttonWebEdit
            // 
            this.buttonWebEdit.Location = new System.Drawing.Point(720, 340);
            this.buttonWebEdit.Name = "buttonWebEdit";
            this.buttonWebEdit.Size = new System.Drawing.Size(115, 29);
            this.buttonWebEdit.TabIndex = 4;
            this.buttonWebEdit.Text = "編集";
            this.buttonWebEdit.UseVisualStyleBackColor = true;
            // 
            // buttonWebNew
            // 
            this.buttonWebNew.Location = new System.Drawing.Point(599, 340);
            this.buttonWebNew.Name = "buttonWebNew";
            this.buttonWebNew.Size = new System.Drawing.Size(115, 29);
            this.buttonWebNew.TabIndex = 3;
            this.buttonWebNew.Text = "新規";
            this.buttonWebNew.UseVisualStyleBackColor = true;
            this.buttonWebNew.Click += new System.EventHandler(this.buttonWebNew_Click);
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "カレントディレクトリ";
            this.columnHeader1.Width = 345;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "コマンド";
            this.columnHeader2.Width = 565;
            // 
            // listBoxTask
            // 
            this.listBoxTask.FormattingEnabled = true;
            this.listBoxTask.ItemHeight = 18;
            this.listBoxTask.Location = new System.Drawing.Point(25, 34);
            this.listBoxTask.Name = "listBoxTask";
            this.listBoxTask.Size = new System.Drawing.Size(915, 256);
            this.listBoxTask.TabIndex = 7;
            // 
            // listBoxWeb
            // 
            this.listBoxWeb.FormattingEnabled = true;
            this.listBoxWeb.ItemHeight = 18;
            this.listBoxWeb.Location = new System.Drawing.Point(25, 69);
            this.listBoxWeb.Name = "listBoxWeb";
            this.listBoxWeb.Size = new System.Drawing.Size(915, 256);
            this.listBoxWeb.TabIndex = 8;
            // 
            // textBoxBrowserPass
            // 
            this.textBoxBrowserPass.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxBrowserPass.Location = new System.Drawing.Point(128, 34);
            this.textBoxBrowserPass.Name = "textBoxBrowserPass";
            this.textBoxBrowserPass.Size = new System.Drawing.Size(697, 26);
            this.textBoxBrowserPass.TabIndex = 15;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "参照";
            this.button1.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button buttonAppRef;
        private System.Windows.Forms.Button buttonAppDel;
        private System.Windows.Forms.Button buttonAppEdit;
        private System.Windows.Forms.Button buttonAppNew;
        private System.Windows.Forms.GroupBox groupBoxWeb;
        private System.Windows.Forms.Button buttonWebDel;
        private System.Windows.Forms.Button buttonWebEdit;
        private System.Windows.Forms.Button buttonWebNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListBox listBoxTask;
        private System.Windows.Forms.ListBox listBoxWeb;
        private System.Windows.Forms.TextBox textBoxBrowserPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
