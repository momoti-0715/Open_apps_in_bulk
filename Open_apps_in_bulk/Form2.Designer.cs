namespace Open_apps_in_bulk
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewCmd = new System.Windows.Forms.ListView();
            this.buttonCmdNew = new System.Windows.Forms.Button();
            this.buttonCmdEdit = new System.Windows.Forms.Button();
            this.buttonCmdDel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonAppDel = new System.Windows.Forms.Button();
            this.buttonAppEdit = new System.Windows.Forms.Button();
            this.buttonAppNew = new System.Windows.Forms.Button();
            this.listViewApp = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonWebDel = new System.Windows.Forms.Button();
            this.buttonWebEdit = new System.Windows.Forms.Button();
            this.buttonWebNew = new System.Windows.Forms.Button();
            this.listViewWeb = new System.Windows.Forms.ListView();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ショートカット名";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCmdDel);
            this.groupBox1.Controls.Add(this.buttonCmdEdit);
            this.groupBox1.Controls.Add(this.buttonCmdNew);
            this.groupBox1.Controls.Add(this.listViewCmd);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(17, 669);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 275);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "コマンド";
            // 
            // listViewCmd
            // 
            this.listViewCmd.HideSelection = false;
            this.listViewCmd.Location = new System.Drawing.Point(25, 34);
            this.listViewCmd.Name = "listViewCmd";
            this.listViewCmd.Size = new System.Drawing.Size(915, 180);
            this.listViewCmd.TabIndex = 0;
            this.listViewCmd.UseCompatibleStateImageBehavior = false;
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
            // buttonCmdEdit
            // 
            this.buttonCmdEdit.Location = new System.Drawing.Point(720, 230);
            this.buttonCmdEdit.Name = "buttonCmdEdit";
            this.buttonCmdEdit.Size = new System.Drawing.Size(115, 29);
            this.buttonCmdEdit.TabIndex = 4;
            this.buttonCmdEdit.Text = "編集";
            this.buttonCmdEdit.UseVisualStyleBackColor = true;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonAppDel);
            this.groupBox4.Controls.Add(this.buttonAppEdit);
            this.groupBox4.Controls.Add(this.buttonAppNew);
            this.groupBox4.Controls.Add(this.listViewApp);
            this.groupBox4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox4.Location = new System.Drawing.Point(17, 375);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(972, 275);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "アプリケーション";
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
            this.buttonAppEdit.Location = new System.Drawing.Point(720, 230);
            this.buttonAppEdit.Name = "buttonAppEdit";
            this.buttonAppEdit.Size = new System.Drawing.Size(115, 29);
            this.buttonAppEdit.TabIndex = 4;
            this.buttonAppEdit.Text = "編集";
            this.buttonAppEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAppNew
            // 
            this.buttonAppNew.Location = new System.Drawing.Point(599, 230);
            this.buttonAppNew.Name = "buttonAppNew";
            this.buttonAppNew.Size = new System.Drawing.Size(115, 29);
            this.buttonAppNew.TabIndex = 3;
            this.buttonAppNew.Text = "新規";
            this.buttonAppNew.UseVisualStyleBackColor = true;
            // 
            // listViewApp
            // 
            this.listViewApp.HideSelection = false;
            this.listViewApp.Location = new System.Drawing.Point(25, 34);
            this.listViewApp.Name = "listViewApp";
            this.listViewApp.Size = new System.Drawing.Size(915, 180);
            this.listViewApp.TabIndex = 0;
            this.listViewApp.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonWebDel);
            this.groupBox2.Controls.Add(this.buttonWebEdit);
            this.groupBox2.Controls.Add(this.buttonWebNew);
            this.groupBox2.Controls.Add(this.listViewWeb);
            this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(17, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 278);
            this.groupBox2.TabIndex = 12;
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
            // listViewWeb
            // 
            this.listViewWeb.HideSelection = false;
            this.listViewWeb.Location = new System.Drawing.Point(25, 34);
            this.listViewWeb.Name = "listViewWeb";
            this.listViewWeb.Size = new System.Drawing.Size(915, 180);
            this.listViewWeb.TabIndex = 0;
            this.listViewWeb.UseCompatibleStateImageBehavior = false;
            // 
            // buttonCansel
            // 
            this.buttonCansel.Location = new System.Drawing.Point(901, 10);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(130, 41);
            this.buttonCansel.TabIndex = 3;
            this.buttonCansel.Text = "キャンセル";
            this.buttonCansel.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(762, 10);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(130, 41);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "作成";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Controls.Add(this.buttonCansel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 754);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 62);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.textBoxSName);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 736);
            this.panel2.TabIndex = 6;
            // 
            // textBoxSName
            // 
            this.textBoxSName.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSName.Location = new System.Drawing.Point(168, 21);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(330, 26);
            this.textBoxSName.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 816);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCmdDel;
        private System.Windows.Forms.Button buttonCmdEdit;
        private System.Windows.Forms.Button buttonCmdNew;
        private System.Windows.Forms.ListView listViewCmd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonAppDel;
        private System.Windows.Forms.Button buttonAppEdit;
        private System.Windows.Forms.Button buttonAppNew;
        private System.Windows.Forms.ListView listViewApp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonWebDel;
        private System.Windows.Forms.Button buttonWebEdit;
        private System.Windows.Forms.Button buttonWebNew;
        private System.Windows.Forms.ListView listViewWeb;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSName;
    }
}