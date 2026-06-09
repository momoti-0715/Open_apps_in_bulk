namespace Open_apps_in_bulk
{
    partial class RegisterForm
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
            this.buttonCansel = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWarning = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.userControl11 = new Open_apps_in_bulk.UserControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCansel
            // 
            this.buttonCansel.Location = new System.Drawing.Point(901, 10);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(130, 41);
            this.buttonCansel.TabIndex = 3;
            this.buttonCansel.Text = "キャンセル";
            this.buttonCansel.UseVisualStyleBackColor = true;
            this.buttonCansel.Click += new System.EventHandler(this.ButtonCansel_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(762, 10);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(130, 41);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "作成";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Controls.Add(this.labelWarning);
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Controls.Add(this.buttonCansel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 702);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 62);
            this.panel1.TabIndex = 13;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(26, 21);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(13, 17);
            this.labelWarning.TabIndex = 19;
            this.labelWarning.Text = " ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.checkBox.Location = new System.Drawing.Point(555, 21);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(178, 21);
            this.checkBox.TabIndex = 20;
            this.checkBox.Text = "デスクトップに作成する";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // userControl11
            // 
            this.userControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl11.AutoScroll = true;
            this.userControl11.Location = new System.Drawing.Point(3, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1031, 696);
            this.userControl11.TabIndex = 14;
            this.userControl11.TextBoxBrowserPass_InputText = "";
            this.userControl11.TextBoxSName_InputText = "";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 764);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "新規登録";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private UserControl1 userControl11;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.CheckBox checkBox;
    }
}