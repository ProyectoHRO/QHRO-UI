
namespace UI
{
    partial class Form1
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxNormal = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximized = new System.Windows.Forms.PictureBox();
            this.labelUserLog = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.pictureBoxMinimized = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonAbout = new FontAwesome.Sharp.IconButton();
            this.panelReportsMenu = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.iconButtonSurgerys = new FontAwesome.Sharp.IconButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.iconButtonReports = new FontAwesome.Sharp.IconButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSlideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelReportsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panelTop.Controls.Add(this.pictureBoxNormal);
            this.panelTop.Controls.Add(this.pictureBoxMaximized);
            this.panelTop.Controls.Add(this.labelUserLog);
            this.panelTop.Controls.Add(this.labelUser);
            this.panelTop.Controls.Add(this.pictureBoxMinimized);
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1536, 50);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // pictureBoxNormal
            // 
            this.pictureBoxNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNormal.Image = global::UI.Properties.Resources.res;
            this.pictureBoxNormal.Location = new System.Drawing.Point(1468, 11);
            this.pictureBoxNormal.Name = "pictureBoxNormal";
            this.pictureBoxNormal.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNormal.TabIndex = 3;
            this.pictureBoxNormal.TabStop = false;
            this.pictureBoxNormal.Click += new System.EventHandler(this.pictureBoxNormal_Click);
            // 
            // pictureBoxMaximized
            // 
            this.pictureBoxMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMaximized.Image = global::UI.Properties.Resources.maxi;
            this.pictureBoxMaximized.Location = new System.Drawing.Point(1468, 12);
            this.pictureBoxMaximized.Name = "pictureBoxMaximized";
            this.pictureBoxMaximized.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMaximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaximized.TabIndex = 2;
            this.pictureBoxMaximized.TabStop = false;
            this.pictureBoxMaximized.Click += new System.EventHandler(this.pictureBoxMaximized_Click);
            // 
            // labelUserLog
            // 
            this.labelUserLog.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUserLog.AutoSize = true;
            this.labelUserLog.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserLog.ForeColor = System.Drawing.Color.White;
            this.labelUserLog.Location = new System.Drawing.Point(593, 11);
            this.labelUserLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserLog.Name = "labelUserLog";
            this.labelUserLog.Size = new System.Drawing.Size(100, 25);
            this.labelUserLog.TabIndex = 6;
            this.labelUserLog.Text = "UserLog";
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(489, 11);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(100, 25);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "Usuario:";
            // 
            // pictureBoxMinimized
            // 
            this.pictureBoxMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimized.Image = global::UI.Properties.Resources.minimazar;
            this.pictureBoxMinimized.Location = new System.Drawing.Point(1437, 12);
            this.pictureBoxMinimized.Name = "pictureBoxMinimized";
            this.pictureBoxMinimized.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimized.TabIndex = 1;
            this.pictureBoxMinimized.TabStop = false;
            this.pictureBoxMinimized.Click += new System.EventHandler(this.pictureBoxMinimized_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::UI.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(1499, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quirófanos, Hospital Regional de Occidente";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.panelSlideMenu.Controls.Add(this.label2);
            this.panelSlideMenu.Controls.Add(this.iconPictureBox1);
            this.panelSlideMenu.Controls.Add(this.iconButtonAbout);
            this.panelSlideMenu.Controls.Add(this.panelReportsMenu);
            this.panelSlideMenu.Controls.Add(this.iconButtonReports);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 50);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(250, 910);
            this.panelSlideMenu.TabIndex = 1;
            this.panelSlideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlideMenu_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(116, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 37);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mi perfil";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 89;
            this.iconPictureBox1.Location = new System.Drawing.Point(4, 6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(96, 89);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // iconButtonAbout
            // 
            this.iconButtonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonAbout.FlatAppearance.BorderSize = 0;
            this.iconButtonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAbout.ForeColor = System.Drawing.Color.White;
            this.iconButtonAbout.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.iconButtonAbout.IconColor = System.Drawing.Color.White;
            this.iconButtonAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAbout.IconSize = 25;
            this.iconButtonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAbout.Location = new System.Drawing.Point(0, 880);
            this.iconButtonAbout.Name = "iconButtonAbout";
            this.iconButtonAbout.Size = new System.Drawing.Size(251, 30);
            this.iconButtonAbout.TabIndex = 25;
            this.iconButtonAbout.Text = "Acerca de";
            this.iconButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAbout.UseVisualStyleBackColor = true;
            this.iconButtonAbout.Click += new System.EventHandler(this.iconButtonAbout_Click);
            // 
            // panelReportsMenu
            // 
            this.panelReportsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(93)))), ((int)(((byte)(118)))));
            this.panelReportsMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelReportsMenu.Controls.Add(this.iconButton3);
            this.panelReportsMenu.Controls.Add(this.panel10);
            this.panelReportsMenu.Controls.Add(this.iconButtonSurgerys);
            this.panelReportsMenu.Controls.Add(this.panel11);
            this.panelReportsMenu.Location = new System.Drawing.Point(30, 141);
            this.panelReportsMenu.Name = "panelReportsMenu";
            this.panelReportsMenu.Size = new System.Drawing.Size(221, 105);
            this.panelReportsMenu.TabIndex = 19;
            this.panelReportsMenu.Visible = false;
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 38;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(3, 54);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(216, 45);
            this.iconButton3.TabIndex = 24;
            this.iconButton3.Text = "Reporte diario";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click_1);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel10.Location = new System.Drawing.Point(0, 54);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 45);
            this.panel10.TabIndex = 23;
            // 
            // iconButtonSurgerys
            // 
            this.iconButtonSurgerys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSurgerys.FlatAppearance.BorderSize = 0;
            this.iconButtonSurgerys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSurgerys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSurgerys.ForeColor = System.Drawing.Color.White;
            this.iconButtonSurgerys.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSurgerys.IconColor = System.Drawing.Color.White;
            this.iconButtonSurgerys.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSurgerys.IconSize = 38;
            this.iconButtonSurgerys.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSurgerys.Location = new System.Drawing.Point(3, 3);
            this.iconButtonSurgerys.Name = "iconButtonSurgerys";
            this.iconButtonSurgerys.Size = new System.Drawing.Size(216, 45);
            this.iconButtonSurgerys.TabIndex = 20;
            this.iconButtonSurgerys.Text = "Intervenciones";
            this.iconButtonSurgerys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSurgerys.UseVisualStyleBackColor = true;
            this.iconButtonSurgerys.Click += new System.EventHandler(this.iconButtonSurgerys_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel11.Location = new System.Drawing.Point(0, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 45);
            this.panel11.TabIndex = 19;
            // 
            // iconButtonReports
            // 
            this.iconButtonReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonReports.Enabled = false;
            this.iconButtonReports.FlatAppearance.BorderSize = 0;
            this.iconButtonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonReports.ForeColor = System.Drawing.Color.White;
            this.iconButtonReports.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButtonReports.IconColor = System.Drawing.Color.White;
            this.iconButtonReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonReports.IconSize = 38;
            this.iconButtonReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReports.Location = new System.Drawing.Point(0, 101);
            this.iconButtonReports.Name = "iconButtonReports";
            this.iconButtonReports.Size = new System.Drawing.Size(251, 45);
            this.iconButtonReports.TabIndex = 18;
            this.iconButtonReports.Text = "Reportes";
            this.iconButtonReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonReports.UseVisualStyleBackColor = true;
            this.iconButtonReports.Visible = false;
            this.iconButtonReports.Click += new System.EventHandler(this.iconButtonReports_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1286, 910);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 960);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSlideMenu);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSlideMenu.ResumeLayout(false);
            this.panelSlideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelReportsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxMinimized;
        private System.Windows.Forms.PictureBox pictureBoxMaximized;
        private System.Windows.Forms.PictureBox pictureBoxNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelReportsMenu;
        private FontAwesome.Sharp.IconButton iconButtonSurgerys;
        private System.Windows.Forms.Panel panel11;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelUserLog;
        private System.Windows.Forms.Label labelUser;
        private FontAwesome.Sharp.IconButton iconButtonAbout;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButtonReports;
    }
}