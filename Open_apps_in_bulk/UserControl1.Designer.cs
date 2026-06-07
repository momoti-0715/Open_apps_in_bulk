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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCmdDel = new System.Windows.Forms.Button();
            this.buttonCmdEdit = new System.Windows.Forms.Button();
            this.buttonCmdNew = new System.Windows.Forms.Button();
            this.listViewCmd = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonAppRef = new System.Windows.Forms.Button();
            this.buttonAppDel = new System.Windows.Forms.Button();
            this.buttonAppEdit = new System.Windows.Forms.Button();
            this.buttonAppNew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonWebDel = new System.Windows.Forms.Button();
            this.buttonWebEdit = new System.Windows.Forms.Button();
            this.buttonWebNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCmdDel);
            this.groupBox1.Controls.Add(this.buttonCmdEdit);
            this.groupBox1.Controls.Add(this.buttonCmdNew);
            this.groupBox1.Controls.Add(this.listViewCmd);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(20, 662);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 275);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "コマンド";
            // 
            // buttonCmdDel
            // 
            this.buttonCmdDel.Location = new System.Drawing.Point(841, 230);
            this.buttonCmdDel.Name = "buttonCmdDel";
            this.buttonCmdDel.Size = new System.Drawing.Size(115, 29);
            this.buttonCmdDel.TabIndex = 5;
            this.buttonCmdDel.Text = "削除";
            this.buttonCmdDel.UseVisualStyleBackColor = true;
            // 
            // buttonCmdEdit
            // 
            this.buttonCmdEdit.Location = new System.Drawing.Point(720, 230);
            this.buttonCmdEdit.Name = "buttonCmdEdit";
            this.buttonCmdEdit.Size = new System.Drawing.Size(115, 29);
            this.buttonCmdEdit.TabIndex = 4;
            this.buttonCmdEdit.Text = "編集";
            this.buttonCmdEdit.UseVisualStyleBackColor = true;
            // 
            // buttonCmdNew
            // 
            this.buttonCmdNew.Location = new System.Drawing.Point(599, 230);
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
            this.listViewCmd.Size = new System.Drawing.Size(915, 180);
            this.listViewCmd.TabIndex = 0;
            this.listViewCmd.UseCompatibleStateImageBehavior = false;
            this.listViewCmd.View = System.Windows.Forms.View.Details;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.buttonAppRef);
            this.groupBox4.Controls.Add(this.buttonAppDel);
            this.groupBox4.Controls.Add(this.buttonAppEdit);
            this.groupBox4.Controls.Add(this.buttonAppNew);
            this.groupBox4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox4.Location = new System.Drawing.Point(20, 368);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(972, 275);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "アプリケーション";
            // 
            // buttonAppRef
            // 
            this.buttonAppRef.Location = new System.Drawing.Point(720, 230);
            this.buttonAppRef.Name = "buttonAppRef";
            this.buttonAppRef.Size = new System.Drawing.Size(115, 29);
            this.buttonAppRef.TabIndex = 6;
            this.buttonAppRef.Text = "参照";
            this.buttonAppRef.UseVisualStyleBackColor = true;
            // 
            // buttonAppDel
            // 
            this.buttonAppDel.Location = new System.Drawing.Point(841, 230);
            this.buttonAppDel.Name = "buttonAppDel";
            this.buttonAppDel.Size = new System.Drawing.Size(115, 29);
            this.buttonAppDel.TabIndex = 5;
            this.buttonAppDel.Text = "削除";
            this.buttonAppDel.UseVisualStyleBackColor = true;
            // 
            // buttonAppEdit
            // 
            this.buttonAppEdit.Location = new System.Drawing.Point(599, 230);
            this.buttonAppEdit.Name = "buttonAppEdit";
            this.buttonAppEdit.Size = new System.Drawing.Size(115, 29);
            this.buttonAppEdit.TabIndex = 4;
            this.buttonAppEdit.Text = "編集";
            this.buttonAppEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAppNew
            // 
            this.buttonAppNew.Location = new System.Drawing.Point(478, 230);
            this.buttonAppNew.Name = "buttonAppNew";
            this.buttonAppNew.Size = new System.Drawing.Size(115, 29);
            this.buttonAppNew.TabIndex = 3;
            this.buttonAppNew.Text = "新規";
            this.buttonAppNew.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.buttonWebDel);
            this.groupBox2.Controls.Add(this.buttonWebEdit);
            this.groupBox2.Controls.Add(this.buttonWebNew);
            this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(20, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 278);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ウェブサイト";
            // 
            // buttonWebDel
            // 
            this.buttonWebDel.Location = new System.Drawing.Point(841, 230);
            this.buttonWebDel.Name = "buttonWebDel";
            this.buttonWebDel.Size = new System.Drawing.Size(115, 29);
            this.buttonWebDel.TabIndex = 5;
            this.buttonWebDel.Text = "削除";
            this.buttonWebDel.UseVisualStyleBackColor = true;
            // 
            // buttonWebEdit
            // 
            this.buttonWebEdit.Location = new System.Drawing.Point(720, 230);
            this.buttonWebEdit.Name = "buttonWebEdit";
            this.buttonWebEdit.Size = new System.Drawing.Size(115, 29);
            this.buttonWebEdit.TabIndex = 4;
            this.buttonWebEdit.Text = "編集";
            this.buttonWebEdit.UseVisualStyleBackColor = true;
            // 
            // buttonWebNew
            // 
            this.buttonWebNew.Location = new System.Drawing.Point(599, 230);
            this.buttonWebNew.Name = "buttonWebNew";
            this.buttonWebNew.Size = new System.Drawing.Size(115, 29);
            this.buttonWebNew.TabIndex = 3;
            this.buttonWebNew.Text = "新規";
            this.buttonWebNew.UseVisualStyleBackColor = true;
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
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(25, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(915, 184);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(25, 34);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(915, 184);
            this.listBox2.TabIndex = 8;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.textBoxSName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1019, 944);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCmdDel;
        private System.Windows.Forms.Button buttonCmdEdit;
        private System.Windows.Forms.Button buttonCmdNew;
        private System.Windows.Forms.ListView listViewCmd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonAppRef;
        private System.Windows.Forms.Button buttonAppDel;
        private System.Windows.Forms.Button buttonAppEdit;
        private System.Windows.Forms.Button buttonAppNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonWebDel;
        private System.Windows.Forms.Button buttonWebEdit;
        private System.Windows.Forms.Button buttonWebNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}
