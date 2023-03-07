namespace ReestrClient
{
    partial class FormNewUser
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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxLogin = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabelPasswordDifference = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelPasswordEquals = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonSignUp = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxRepeatPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxLastname = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxName = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 216);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(45, 19);
            this.materialLabel3.TabIndex = 47;
            this.materialLabel3.Text = "Login:";
            // 
            // materialTextBoxLogin
            // 
            this.materialTextBoxLogin.AnimateReadOnly = false;
            this.materialTextBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLogin.Depth = 0;
            this.materialTextBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxLogin.HideSelection = true;
            this.materialTextBoxLogin.LeadingIcon = null;
            this.materialTextBoxLogin.Location = new System.Drawing.Point(6, 238);
            this.materialTextBoxLogin.MaxLength = 32767;
            this.materialTextBoxLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLogin.Name = "materialTextBoxLogin";
            this.materialTextBoxLogin.PasswordChar = '\0';
            this.materialTextBoxLogin.PrefixSuffixText = null;
            this.materialTextBoxLogin.ReadOnly = false;
            this.materialTextBoxLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxLogin.SelectedText = "";
            this.materialTextBoxLogin.SelectionLength = 0;
            this.materialTextBoxLogin.SelectionStart = 0;
            this.materialTextBoxLogin.ShortcutsEnabled = true;
            this.materialTextBoxLogin.Size = new System.Drawing.Size(298, 48);
            this.materialTextBoxLogin.TabIndex = 46;
            this.materialTextBoxLogin.TabStop = false;
            this.materialTextBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLogin.TrailingIcon = null;
            this.materialTextBoxLogin.UseSystemPasswordChar = false;
            // 
            // materialLabelPasswordDifference
            // 
            this.materialLabelPasswordDifference.AutoSize = true;
            this.materialLabelPasswordDifference.BackColor = System.Drawing.Color.Transparent;
            this.materialLabelPasswordDifference.Depth = 0;
            this.materialLabelPasswordDifference.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelPasswordDifference.ForeColor = System.Drawing.Color.Red;
            this.materialLabelPasswordDifference.Location = new System.Drawing.Point(274, 362);
            this.materialLabelPasswordDifference.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPasswordDifference.Name = "materialLabelPasswordDifference";
            this.materialLabelPasswordDifference.Size = new System.Drawing.Size(1, 0);
            this.materialLabelPasswordDifference.TabIndex = 45;
            // 
            // materialLabelPasswordEquals
            // 
            this.materialLabelPasswordEquals.AutoSize = true;
            this.materialLabelPasswordEquals.Depth = 0;
            this.materialLabelPasswordEquals.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelPasswordEquals.Location = new System.Drawing.Point(274, 362);
            this.materialLabelPasswordEquals.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPasswordEquals.Name = "materialLabelPasswordEquals";
            this.materialLabelPasswordEquals.Size = new System.Drawing.Size(1, 0);
            this.materialLabelPasswordEquals.TabIndex = 44;
            // 
            // materialButtonSignUp
            // 
            this.materialButtonSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSignUp.Depth = 0;
            this.materialButtonSignUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButtonSignUp.HighEmphasis = true;
            this.materialButtonSignUp.Icon = null;
            this.materialButtonSignUp.Location = new System.Drawing.Point(3, 440);
            this.materialButtonSignUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSignUp.Name = "materialButtonSignUp";
            this.materialButtonSignUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSignUp.Size = new System.Drawing.Size(300, 36);
            this.materialButtonSignUp.TabIndex = 43;
            this.materialButtonSignUp.Text = "SignUp";
            this.materialButtonSignUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSignUp.UseAccentColor = false;
            this.materialButtonSignUp.UseVisualStyleBackColor = true;
            this.materialButtonSignUp.Click += new System.EventHandler(this.materialButtonSignUp_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(3, 362);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(128, 19);
            this.materialLabel6.TabIndex = 42;
            this.materialLabel6.Text = "Repeat Password:";
            // 
            // materialTextBoxRepeatPassword
            // 
            this.materialTextBoxRepeatPassword.AnimateReadOnly = false;
            this.materialTextBoxRepeatPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxRepeatPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxRepeatPassword.Depth = 0;
            this.materialTextBoxRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxRepeatPassword.HideSelection = true;
            this.materialTextBoxRepeatPassword.LeadingIcon = null;
            this.materialTextBoxRepeatPassword.Location = new System.Drawing.Point(3, 384);
            this.materialTextBoxRepeatPassword.MaxLength = 32767;
            this.materialTextBoxRepeatPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxRepeatPassword.Name = "materialTextBoxRepeatPassword";
            this.materialTextBoxRepeatPassword.PasswordChar = '\0';
            this.materialTextBoxRepeatPassword.PrefixSuffixText = null;
            this.materialTextBoxRepeatPassword.ReadOnly = false;
            this.materialTextBoxRepeatPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxRepeatPassword.SelectedText = "";
            this.materialTextBoxRepeatPassword.SelectionLength = 0;
            this.materialTextBoxRepeatPassword.SelectionStart = 0;
            this.materialTextBoxRepeatPassword.ShortcutsEnabled = true;
            this.materialTextBoxRepeatPassword.Size = new System.Drawing.Size(301, 48);
            this.materialTextBoxRepeatPassword.TabIndex = 41;
            this.materialTextBoxRepeatPassword.TabStop = false;
            this.materialTextBoxRepeatPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxRepeatPassword.TrailingIcon = null;
            this.materialTextBoxRepeatPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(3, 289);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(75, 19);
            this.materialLabel7.TabIndex = 40;
            this.materialLabel7.Text = "Password:";
            // 
            // materialTextBoxPassword
            // 
            this.materialTextBoxPassword.AnimateReadOnly = false;
            this.materialTextBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxPassword.Depth = 0;
            this.materialTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxPassword.HideSelection = true;
            this.materialTextBoxPassword.LeadingIcon = null;
            this.materialTextBoxPassword.Location = new System.Drawing.Point(3, 311);
            this.materialTextBoxPassword.MaxLength = 32767;
            this.materialTextBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxPassword.Name = "materialTextBoxPassword";
            this.materialTextBoxPassword.PasswordChar = '\0';
            this.materialTextBoxPassword.PrefixSuffixText = null;
            this.materialTextBoxPassword.ReadOnly = false;
            this.materialTextBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxPassword.SelectedText = "";
            this.materialTextBoxPassword.SelectionLength = 0;
            this.materialTextBoxPassword.SelectionStart = 0;
            this.materialTextBoxPassword.ShortcutsEnabled = true;
            this.materialTextBoxPassword.Size = new System.Drawing.Size(301, 48);
            this.materialTextBoxPassword.TabIndex = 39;
            this.materialTextBoxPassword.TabStop = false;
            this.materialTextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxPassword.TrailingIcon = null;
            this.materialTextBoxPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 143);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 38;
            this.materialLabel2.Text = "Lastname:";
            // 
            // materialTextBoxLastname
            // 
            this.materialTextBoxLastname.AnimateReadOnly = false;
            this.materialTextBoxLastname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxLastname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLastname.Depth = 0;
            this.materialTextBoxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxLastname.HideSelection = true;
            this.materialTextBoxLastname.LeadingIcon = null;
            this.materialTextBoxLastname.Location = new System.Drawing.Point(6, 165);
            this.materialTextBoxLastname.MaxLength = 32767;
            this.materialTextBoxLastname.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLastname.Name = "materialTextBoxLastname";
            this.materialTextBoxLastname.PasswordChar = '\0';
            this.materialTextBoxLastname.PrefixSuffixText = null;
            this.materialTextBoxLastname.ReadOnly = false;
            this.materialTextBoxLastname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxLastname.SelectedText = "";
            this.materialTextBoxLastname.SelectionLength = 0;
            this.materialTextBoxLastname.SelectionStart = 0;
            this.materialTextBoxLastname.ShortcutsEnabled = true;
            this.materialTextBoxLastname.Size = new System.Drawing.Size(298, 48);
            this.materialTextBoxLastname.TabIndex = 37;
            this.materialTextBoxLastname.TabStop = false;
            this.materialTextBoxLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLastname.TrailingIcon = null;
            this.materialTextBoxLastname.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 70);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 36;
            this.materialLabel1.Text = "Name:";
            // 
            // materialTextBoxName
            // 
            this.materialTextBoxName.AnimateReadOnly = false;
            this.materialTextBoxName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxName.Depth = 0;
            this.materialTextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxName.HideSelection = true;
            this.materialTextBoxName.LeadingIcon = null;
            this.materialTextBoxName.Location = new System.Drawing.Point(6, 92);
            this.materialTextBoxName.MaxLength = 32767;
            this.materialTextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxName.Name = "materialTextBoxName";
            this.materialTextBoxName.PasswordChar = '\0';
            this.materialTextBoxName.PrefixSuffixText = null;
            this.materialTextBoxName.ReadOnly = false;
            this.materialTextBoxName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxName.SelectedText = "";
            this.materialTextBoxName.SelectionLength = 0;
            this.materialTextBoxName.SelectionStart = 0;
            this.materialTextBoxName.ShortcutsEnabled = true;
            this.materialTextBoxName.Size = new System.Drawing.Size(298, 48);
            this.materialTextBoxName.TabIndex = 35;
            this.materialTextBoxName.TabStop = false;
            this.materialTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxName.TrailingIcon = null;
            this.materialTextBoxName.UseSystemPasswordChar = false;
            // 
            // FormNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 479);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialTextBoxLogin);
            this.Controls.Add(this.materialLabelPasswordDifference);
            this.Controls.Add(this.materialLabelPasswordEquals);
            this.Controls.Add(this.materialButtonSignUp);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialTextBoxRepeatPassword);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialTextBoxPassword);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialTextBoxLastname);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTextBoxName);
            this.MaximizeBox = false;
            this.Name = "FormNewUser";
            this.Sizable = false;
            this.Text = "Добавить пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabelPasswordDifference;
        private MaterialSkin.Controls.MaterialLabel materialLabelPasswordEquals;
        private MaterialSkin.Controls.MaterialButton materialButtonSignUp;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxRepeatPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxLastname;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxName;
    }
}