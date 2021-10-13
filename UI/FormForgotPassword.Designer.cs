
namespace UI
{
    partial class FormForgotPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxMinimized = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.iconButtonSend = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButtonBack = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBoxMinimized);
            this.panel1.Controls.Add(this.pictureClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 50);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "RECUPERAR CONTRASEÑA";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // pictureBoxMinimized
            // 
            this.pictureBoxMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimized.Image = global::UI.Properties.Resources.minimazar;
            this.pictureBoxMinimized.Location = new System.Drawing.Point(347, 12);
            this.pictureBoxMinimized.Name = "pictureBoxMinimized";
            this.pictureBoxMinimized.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimized.TabIndex = 4;
            this.pictureBoxMinimized.TabStop = false;
            this.pictureBoxMinimized.Click += new System.EventHandler(this.pictureBoxMinimized_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Image = global::UI.Properties.Resources.cerrar;
            this.pictureClose.Location = new System.Drawing.Point(378, 12);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(25, 25);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 3;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 50;
            this.iconPictureBox1.Location = new System.Drawing.Point(30, 229);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox1.TabIndex = 25;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(85, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 1);
            this.panel3.TabIndex = 24;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(85, 253);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(255, 19);
            this.textBoxEmail.TabIndex = 26;
            this.textBoxEmail.Text = "CORREO";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // iconButtonSend
            // 
            this.iconButtonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSend.FlatAppearance.BorderSize = 0;
            this.iconButtonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSend.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSend.ForeColor = System.Drawing.Color.White;
            this.iconButtonSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconButtonSend.IconColor = System.Drawing.Color.White;
            this.iconButtonSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSend.Location = new System.Drawing.Point(85, 342);
            this.iconButtonSend.Name = "iconButtonSend";
            this.iconButtonSend.Size = new System.Drawing.Size(239, 63);
            this.iconButtonSend.TabIndex = 23;
            this.iconButtonSend.Text = "Enviar";
            this.iconButtonSend.UseVisualStyleBackColor = false;
            this.iconButtonSend.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 705);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 15);
            this.panel2.TabIndex = 27;
            // 
            // iconButtonBack
            // 
            this.iconButtonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonBack.FlatAppearance.BorderSize = 0;
            this.iconButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBack.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBack.ForeColor = System.Drawing.Color.White;
            this.iconButtonBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.iconButtonBack.IconColor = System.Drawing.Color.White;
            this.iconButtonBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBack.Location = new System.Drawing.Point(85, 418);
            this.iconButtonBack.Name = "iconButtonBack";
            this.iconButtonBack.Size = new System.Drawing.Size(239, 63);
            this.iconButtonBack.TabIndex = 28;
            this.iconButtonBack.Text = "Volver";
            this.iconButtonBack.UseVisualStyleBackColor = false;
            this.iconButtonBack.Click += new System.EventHandler(this.iconButtonBack_Click);
            // 
            // FormForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(415, 720);
            this.Controls.Add(this.iconButtonBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.iconButtonSend);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForgotPassword";
            this.Load += new System.EventHandler(this.FormForgotPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxMinimized;
        private System.Windows.Forms.PictureBox pictureClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private FontAwesome.Sharp.IconButton iconButtonSend;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonBack;
    }
}