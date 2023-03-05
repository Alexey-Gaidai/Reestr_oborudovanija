namespace ReestrClient
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.materialLabelSignUp = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonLogIn = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialTextBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTextBoxLogin = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabelSignUp
            // 
            this.materialLabelSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabelSignUp.AutoSize = true;
            this.materialLabelSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelSignUp.Depth = 0;
            this.materialLabelSignUp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelSignUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialLabelSignUp.Location = new System.Drawing.Point(125, 172);
            this.materialLabelSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSignUp.Name = "materialLabelSignUp";
            this.materialLabelSignUp.Size = new System.Drawing.Size(75, 19);
            this.materialLabelSignUp.TabIndex = 15;
            this.materialLabelSignUp.Text = "First time?";
            // 
            // materialButtonLogIn
            // 
            this.materialButtonLogIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonLogIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonLogIn.Depth = 0;
            this.materialButtonLogIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButtonLogIn.HighEmphasis = true;
            this.materialButtonLogIn.Icon = null;
            this.materialButtonLogIn.Location = new System.Drawing.Point(3, 193);
            this.materialButtonLogIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonLogIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonLogIn.Name = "materialButtonLogIn";
            this.materialButtonLogIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonLogIn.Size = new System.Drawing.Size(310, 36);
            this.materialButtonLogIn.TabIndex = 14;
            this.materialButtonLogIn.Text = "LogIn";
            this.materialButtonLogIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonLogIn.UseAccentColor = false;
            this.materialButtonLogIn.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
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
            this.materialTextBoxPassword.Location = new System.Drawing.Point(58, 121);
            this.materialTextBoxPassword.MaxLength = 32767;
            this.materialTextBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxPassword.Name = "materialTextBoxPassword";
            this.materialTextBoxPassword.PasswordChar = '*';
            this.materialTextBoxPassword.PrefixSuffixText = null;
            this.materialTextBoxPassword.ReadOnly = false;
            this.materialTextBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxPassword.SelectedText = "";
            this.materialTextBoxPassword.SelectionLength = 0;
            this.materialTextBoxPassword.SelectionStart = 0;
            this.materialTextBoxPassword.ShortcutsEnabled = true;
            this.materialTextBoxPassword.Size = new System.Drawing.Size(255, 48);
            this.materialTextBoxPassword.TabIndex = 12;
            this.materialTextBoxPassword.TabStop = false;
            this.materialTextBoxPassword.Text = "12345";
            this.materialTextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxPassword.TrailingIcon = null;
            this.materialTextBoxPassword.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
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
            this.materialTextBoxLogin.Location = new System.Drawing.Point(58, 67);
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
            this.materialTextBoxLogin.Size = new System.Drawing.Size(255, 48);
            this.materialTextBoxLogin.TabIndex = 10;
            this.materialTextBoxLogin.TabStop = false;
            this.materialTextBoxLogin.Text = "admin@gmail.com";
            this.materialTextBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLogin.TrailingIcon = null;
            this.materialTextBoxLogin.UseSystemPasswordChar = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 232);
            this.Controls.Add(this.materialLabelSignUp);
            this.Controls.Add(this.materialButtonLogIn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.materialTextBoxPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialTextBoxLogin);
            this.Name = "FormLogin";
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabelSignUp;
        private MaterialSkin.Controls.MaterialButton materialButtonLogIn;
        private PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxPassword;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxLogin;
    }
}