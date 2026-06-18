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
            this.dataGridViewCmd = new System.Windows.Forms.DataGridView();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Close = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonCmdDel = new System.Windows.Forms.Button();
            this.buttonCmdNew = new System.Windows.Forms.Button();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.dataGridViewTask = new System.Windows.Forms.DataGridView();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTaskRef = new System.Windows.Forms.Button();
            this.buttonTaskDel = new System.Windows.Forms.Button();
            this.buttonTaskNew = new System.Windows.Forms.Button();
            this.groupBoxWeb = new System.Windows.Forms.GroupBox();
            this.dataGridViewWeb = new System.Windows.Forms.DataGridView();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBrowserPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWebDel = new System.Windows.Forms.Button();
            this.buttonWebNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCmd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmd)).BeginInit();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).BeginInit();
            this.groupBoxWeb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeb)).BeginInit();
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
            this.groupBoxCmd.Controls.Add(this.dataGridViewCmd);
            this.groupBoxCmd.Controls.Add(this.buttonCmdDel);
            this.groupBoxCmd.Controls.Add(this.buttonCmdNew);
            this.groupBoxCmd.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxCmd.Location = new System.Drawing.Point(20, 810);
            this.groupBoxCmd.Name = "groupBoxCmd";
            this.groupBoxCmd.Size = new System.Drawing.Size(972, 342);
            this.groupBoxCmd.TabIndex = 15;
            this.groupBoxCmd.TabStop = false;
            this.groupBoxCmd.Text = "コマンド";
            // 
            // dataGridViewCmd
            // 
            this.dataGridViewCmd.AllowUserToAddRows = false;
            this.dataGridViewCmd.AllowUserToDeleteRows = false;
            this.dataGridViewCmd.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path,
            this.Command,
            this.Close});
            this.dataGridViewCmd.Location = new System.Drawing.Point(26, 34);
            this.dataGridViewCmd.MultiSelect = false;
            this.dataGridViewCmd.Name = "dataGridViewCmd";
            this.dataGridViewCmd.RowHeadersVisible = false;
            this.dataGridViewCmd.RowHeadersWidth = 51;
            this.dataGridViewCmd.RowTemplate.Height = 24;
            this.dataGridViewCmd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCmd.Size = new System.Drawing.Size(914, 256);
            this.dataGridViewCmd.TabIndex = 17;
            this.dataGridViewCmd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewCmd_MouseDown);
            // 
            // Path
            // 
            this.Path.FillWeight = 250F;
            this.Path.HeaderText = "カレントディレクトリ";
            this.Path.MinimumWidth = 6;
            this.Path.Name = "Path";
            this.Path.Width = 250;
            // 
            // Command
            // 
            this.Command.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Command.FillWeight = 84.46524F;
            this.Command.HeaderText = "コマンド";
            this.Command.MinimumWidth = 6;
            this.Command.Name = "Command";
            // 
            // Close
            // 
            this.Close.FillWeight = 70F;
            this.Close.HeaderText = "Close";
            this.Close.MinimumWidth = 70;
            this.Close.Name = "Close";
            this.Close.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Close.Width = 70;
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
            // buttonCmdNew
            // 
            this.buttonCmdNew.Location = new System.Drawing.Point(720, 302);
            this.buttonCmdNew.Name = "buttonCmdNew";
            this.buttonCmdNew.Size = new System.Drawing.Size(115, 29);
            this.buttonCmdNew.TabIndex = 14;
            this.buttonCmdNew.Text = "新規";
            this.buttonCmdNew.UseVisualStyleBackColor = true;
            this.buttonCmdNew.Click += new System.EventHandler(this.ButtonCmdNew_Click);
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.dataGridViewTask);
            this.groupBoxTask.Controls.Add(this.buttonTaskRef);
            this.groupBoxTask.Controls.Add(this.buttonTaskDel);
            this.groupBoxTask.Controls.Add(this.buttonTaskNew);
            this.groupBoxTask.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxTask.Location = new System.Drawing.Point(20, 454);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(972, 342);
            this.groupBoxTask.TabIndex = 16;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "アプリケーション";
            // 
            // dataGridViewTask
            // 
            this.dataGridViewTask.AllowUserToAddRows = false;
            this.dataGridViewTask.AllowUserToDeleteRows = false;
            this.dataGridViewTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTask.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pass});
            this.dataGridViewTask.Location = new System.Drawing.Point(26, 36);
            this.dataGridViewTask.MultiSelect = false;
            this.dataGridViewTask.Name = "dataGridViewTask";
            this.dataGridViewTask.RowHeadersVisible = false;
            this.dataGridViewTask.RowHeadersWidth = 51;
            this.dataGridViewTask.RowTemplate.Height = 24;
            this.dataGridViewTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTask.Size = new System.Drawing.Size(914, 256);
            this.dataGridViewTask.TabIndex = 18;
            this.dataGridViewTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewTask_MouseDown);
            // 
            // Pass
            // 
            this.Pass.FillWeight = 250F;
            this.Pass.HeaderText = "PASS";
            this.Pass.MinimumWidth = 6;
            this.Pass.Name = "Pass";
            // 
            // buttonTaskRef
            // 
            this.buttonTaskRef.Location = new System.Drawing.Point(720, 304);
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
            // buttonTaskNew
            // 
            this.buttonTaskNew.Location = new System.Drawing.Point(599, 304);
            this.buttonTaskNew.Name = "buttonTaskNew";
            this.buttonTaskNew.Size = new System.Drawing.Size(115, 29);
            this.buttonTaskNew.TabIndex = 9;
            this.buttonTaskNew.Text = "新規";
            this.buttonTaskNew.UseVisualStyleBackColor = true;
            this.buttonTaskNew.Click += new System.EventHandler(this.ButtonTaskNew_Click);
            // 
            // groupBoxWeb
            // 
            this.groupBoxWeb.Controls.Add(this.dataGridViewWeb);
            this.groupBoxWeb.Controls.Add(this.button1);
            this.groupBoxWeb.Controls.Add(this.textBoxBrowserPass);
            this.groupBoxWeb.Controls.Add(this.label2);
            this.groupBoxWeb.Controls.Add(this.buttonWebDel);
            this.groupBoxWeb.Controls.Add(this.buttonWebNew);
            this.groupBoxWeb.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxWeb.Location = new System.Drawing.Point(20, 60);
            this.groupBoxWeb.Name = "groupBoxWeb";
            this.groupBoxWeb.Size = new System.Drawing.Size(972, 379);
            this.groupBoxWeb.TabIndex = 17;
            this.groupBoxWeb.TabStop = false;
            this.groupBoxWeb.Text = "ウェブサイト";
            // 
            // dataGridViewWeb
            // 
            this.dataGridViewWeb.AllowUserToAddRows = false;
            this.dataGridViewWeb.AllowUserToDeleteRows = false;
            this.dataGridViewWeb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWeb.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewWeb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.URL});
            this.dataGridViewWeb.Location = new System.Drawing.Point(26, 73);
            this.dataGridViewWeb.MultiSelect = false;
            this.dataGridViewWeb.Name = "dataGridViewWeb";
            this.dataGridViewWeb.RowHeadersVisible = false;
            this.dataGridViewWeb.RowHeadersWidth = 51;
            this.dataGridViewWeb.RowTemplate.Height = 24;
            this.dataGridViewWeb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWeb.Size = new System.Drawing.Size(914, 256);
            this.dataGridViewWeb.TabIndex = 18;
            this.dataGridViewWeb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewWeb_MouseDown);
            // 
            // URL
            // 
            this.URL.FillWeight = 250F;
            this.URL.HeaderText = "URL";
            this.URL.MinimumWidth = 6;
            this.URL.Name = "URL";
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
            // buttonWebNew
            // 
            this.buttonWebNew.Location = new System.Drawing.Point(720, 340);
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
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmd)).EndInit();
            this.groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).EndInit();
            this.groupBoxWeb.ResumeLayout(false);
            this.groupBoxWeb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.GroupBox groupBoxCmd;
        private System.Windows.Forms.Button buttonCmdDel;
        private System.Windows.Forms.Button buttonCmdNew;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.Button buttonTaskRef;
        private System.Windows.Forms.Button buttonTaskDel;
        private System.Windows.Forms.Button buttonTaskNew;
        private System.Windows.Forms.GroupBox groupBoxWeb;
        private System.Windows.Forms.Button buttonWebDel;
        private System.Windows.Forms.Button buttonWebNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBrowserPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridViewCmd;
        public System.Windows.Forms.DataGridView dataGridViewTask;
        public System.Windows.Forms.DataGridView dataGridViewWeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Command;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
    }
}
