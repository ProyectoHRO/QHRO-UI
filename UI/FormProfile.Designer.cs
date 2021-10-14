
namespace UI
{
    partial class FormProfile
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
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxnewPassword = new System.Windows.Forms.TextBox();
            this.textBoxnewPasswordConfirm = new System.Windows.Forms.TextBox();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelEditPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(341, 88);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(188, 22);
            this.textBoxUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(341, 152);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(188, 22);
            this.textBoxEmail.TabIndex = 5;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(325, 329);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(215, 41);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Actualizar Datos";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(796, 93);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(57, 17);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "Usuario";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(807, 157);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(46, 17);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "label2";
            this.labelId.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxnewPassword
            // 
            this.textBoxnewPassword.Location = new System.Drawing.Point(341, 225);
            this.textBoxnewPassword.Name = "textBoxnewPassword";
            this.textBoxnewPassword.Size = new System.Drawing.Size(188, 22);
            this.textBoxnewPassword.TabIndex = 9;
            // 
            // textBoxnewPasswordConfirm
            // 
            this.textBoxnewPasswordConfirm.Location = new System.Drawing.Point(341, 276);
            this.textBoxnewPasswordConfirm.Name = "textBoxnewPasswordConfirm";
            this.textBoxnewPasswordConfirm.Size = new System.Drawing.Size(188, 22);
            this.textBoxnewPasswordConfirm.TabIndex = 10;
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.Location = new System.Drawing.Point(578, 93);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(45, 17);
            this.labelEdit.TabIndex = 12;
            this.labelEdit.Text = "Editar";
            this.labelEdit.Click += new System.EventHandler(this.labelEdit_Click);
            // 
            // labelEditPassword
            // 
            this.labelEditPassword.AutoSize = true;
            this.labelEditPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditPassword.Location = new System.Drawing.Point(589, 225);
            this.labelEditPassword.Name = "labelEditPassword";
            this.labelEditPassword.Size = new System.Drawing.Size(137, 17);
            this.labelEditPassword.TabIndex = 13;
            this.labelEditPassword.Text = "Cambiar Contraseña";
            this.labelEditPassword.Click += new System.EventHandler(this.labelEditPassword_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 1119);
            this.Controls.Add(this.labelEditPassword);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.textBoxnewPasswordConfirm);
            this.Controls.Add(this.textBoxnewPassword);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label labelId;
        public System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxnewPassword;
        private System.Windows.Forms.TextBox textBoxnewPasswordConfirm;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelEditPassword;
    }
}