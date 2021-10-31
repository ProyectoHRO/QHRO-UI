﻿
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
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.iconButtonAbout = new FontAwesome.Sharp.IconButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panelReportsMenu = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.iconButtonSurgerys = new FontAwesome.Sharp.IconButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.iconButtonReports = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSlideMenu.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
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
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(2048, 62);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // pictureBoxNormal
            // 
            this.pictureBoxNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNormal.Image = global::UI.Properties.Resources.res;
            this.pictureBoxNormal.Location = new System.Drawing.Point(1957, 15);
            this.pictureBoxNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxNormal.Name = "pictureBoxNormal";
            this.pictureBoxNormal.Size = new System.Drawing.Size(33, 31);
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
            this.pictureBoxMaximized.Location = new System.Drawing.Point(1957, 15);
            this.pictureBoxMaximized.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxMaximized.Name = "pictureBoxMaximized";
            this.pictureBoxMaximized.Size = new System.Drawing.Size(33, 31);
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
            this.labelUserLog.Location = new System.Drawing.Point(791, 14);
            this.labelUserLog.Name = "labelUserLog";
            this.labelUserLog.Size = new System.Drawing.Size(129, 32);
            this.labelUserLog.TabIndex = 6;
            this.labelUserLog.Text = "UserLog";
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(652, 14);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(129, 32);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "Usuario:";
            // 
            // pictureBoxMinimized
            // 
            this.pictureBoxMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimized.Image = global::UI.Properties.Resources.minimazar;
            this.pictureBoxMinimized.Location = new System.Drawing.Point(1916, 15);
            this.pictureBoxMinimized.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxMinimized.Name = "pictureBoxMinimized";
            this.pictureBoxMinimized.Size = new System.Drawing.Size(33, 31);
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
            this.pictureBox2.Location = new System.Drawing.Point(1999, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
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
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quirófanos, Hospital Regional de Occidente";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.panelSlideMenu.Controls.Add(this.panel12);
            this.panelSlideMenu.Controls.Add(this.label2);
            this.panelSlideMenu.Controls.Add(this.iconPictureBox1);
            this.panelSlideMenu.Controls.Add(this.panel20);
            this.panelSlideMenu.Controls.Add(this.panel17);
            this.panelSlideMenu.Controls.Add(this.panel16);
            this.panelSlideMenu.Controls.Add(this.iconButtonAbout);
            this.panelSlideMenu.Controls.Add(this.panel15);
            this.panelSlideMenu.Controls.Add(this.panel14);
            this.panelSlideMenu.Controls.Add(this.panel13);
            this.panelSlideMenu.Controls.Add(this.panelReportsMenu);
            this.panelSlideMenu.Controls.Add(this.iconButtonReports);
            this.panelSlideMenu.Controls.Add(this.panel8);
            this.panelSlideMenu.Controls.Add(this.panel7);
            this.panelSlideMenu.Controls.Add(this.panel6);
            this.panelSlideMenu.Controls.Add(this.panel5);
            this.panelSlideMenu.Controls.Add(this.panel4);
            this.panelSlideMenu.Controls.Add(this.panel3);
            this.panelSlideMenu.Controls.Add(this.panel2);
            this.panelSlideMenu.Controls.Add(this.panel1);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 62);
            this.panelSlideMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(333, 1038);
            this.panelSlideMenu.TabIndex = 1;
            this.panelSlideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlideMenu_Paint);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel12.Controls.Add(this.panel24);
            this.panel12.Controls.Add(this.panel26);
            this.panel12.Location = new System.Drawing.Point(0, 926);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(4, 55);
            this.panel12.TabIndex = 31;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel24.Controls.Add(this.panel25);
            this.panel24.Location = new System.Drawing.Point(19, 0);
            this.panel24.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(4, 55);
            this.panel24.TabIndex = 30;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel25.Location = new System.Drawing.Point(12, 38);
            this.panel25.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(4, 55);
            this.panel25.TabIndex = 29;
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel26.Location = new System.Drawing.Point(12, 38);
            this.panel26.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(4, 55);
            this.panel26.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 46);
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
            this.iconPictureBox1.IconSize = 110;
            this.iconPictureBox1.Location = new System.Drawing.Point(5, 7);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(128, 110);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel20.Controls.Add(this.panel21);
            this.panel20.Controls.Add(this.panel23);
            this.panel20.Location = new System.Drawing.Point(0, 863);
            this.panel20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(4, 55);
            this.panel20.TabIndex = 29;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Location = new System.Drawing.Point(19, 0);
            this.panel21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(4, 55);
            this.panel21.TabIndex = 30;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel22.Location = new System.Drawing.Point(12, 38);
            this.panel22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(4, 55);
            this.panel22.TabIndex = 29;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel23.Location = new System.Drawing.Point(12, 38);
            this.panel23.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(4, 55);
            this.panel23.TabIndex = 29;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Controls.Add(this.panel9);
            this.panel17.Location = new System.Drawing.Point(0, 801);
            this.panel17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(4, 55);
            this.panel17.TabIndex = 28;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Location = new System.Drawing.Point(19, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(4, 55);
            this.panel18.TabIndex = 30;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel19.Location = new System.Drawing.Point(12, 38);
            this.panel19.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(4, 55);
            this.panel19.TabIndex = 29;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel9.Location = new System.Drawing.Point(12, 38);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(4, 55);
            this.panel9.TabIndex = 29;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel16.Location = new System.Drawing.Point(0, 740);
            this.panel16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(4, 55);
            this.panel16.TabIndex = 26;
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
            this.iconButtonAbout.Location = new System.Drawing.Point(5, 1001);
            this.iconButtonAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonAbout.Name = "iconButtonAbout";
            this.iconButtonAbout.Size = new System.Drawing.Size(329, 37);
            this.iconButtonAbout.TabIndex = 25;
            this.iconButtonAbout.Text = "Acerca de";
            this.iconButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAbout.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel15.Location = new System.Drawing.Point(0, 1001);
            this.panel15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(4, 37);
            this.panel15.TabIndex = 24;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel14.Location = new System.Drawing.Point(0, 677);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(4, 55);
            this.panel14.TabIndex = 22;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel13.Location = new System.Drawing.Point(0, 617);
            this.panel13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(4, 55);
            this.panel13.TabIndex = 20;
            // 
            // panelReportsMenu
            // 
            this.panelReportsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(93)))), ((int)(((byte)(118)))));
            this.panelReportsMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelReportsMenu.Controls.Add(this.iconButton3);
            this.panelReportsMenu.Controls.Add(this.panel10);
            this.panelReportsMenu.Controls.Add(this.iconButtonSurgerys);
            this.panelReportsMenu.Controls.Add(this.panel11);
            this.panelReportsMenu.Location = new System.Drawing.Point(40, 174);
            this.panelReportsMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelReportsMenu.Name = "panelReportsMenu";
            this.panelReportsMenu.Size = new System.Drawing.Size(293, 128);
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
            this.iconButton3.Location = new System.Drawing.Point(4, 66);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(288, 55);
            this.iconButton3.TabIndex = 24;
            this.iconButton3.Text = "Reporte diario";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click_1);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel10.Location = new System.Drawing.Point(0, 66);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(13, 55);
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
            this.iconButtonSurgerys.Location = new System.Drawing.Point(4, 4);
            this.iconButtonSurgerys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonSurgerys.Name = "iconButtonSurgerys";
            this.iconButtonSurgerys.Size = new System.Drawing.Size(288, 55);
            this.iconButtonSurgerys.TabIndex = 20;
            this.iconButtonSurgerys.Text = "Intervenciones";
            this.iconButtonSurgerys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSurgerys.UseVisualStyleBackColor = true;
            this.iconButtonSurgerys.Click += new System.EventHandler(this.iconButtonSurgerys_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel11.Location = new System.Drawing.Point(0, 4);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(13, 55);
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
            this.iconButtonReports.Location = new System.Drawing.Point(5, 124);
            this.iconButtonReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonReports.Name = "iconButtonReports";
            this.iconButtonReports.Size = new System.Drawing.Size(329, 55);
            this.iconButtonReports.TabIndex = 18;
            this.iconButtonReports.Text = "Reportes";
            this.iconButtonReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonReports.UseVisualStyleBackColor = true;
            this.iconButtonReports.Visible = false;
            this.iconButtonReports.Click += new System.EventHandler(this.iconButtonReports_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel8.Location = new System.Drawing.Point(0, 555);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(4, 55);
            this.panel8.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel7.Location = new System.Drawing.Point(0, 494);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(4, 55);
            this.panel7.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel6.Location = new System.Drawing.Point(0, 432);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 55);
            this.panel6.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel5.Location = new System.Drawing.Point(0, 370);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 55);
            this.panel5.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel4.Location = new System.Drawing.Point(0, 309);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 55);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(0, 247);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 55);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel2.Location = new System.Drawing.Point(0, 186);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 55);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(0, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 55);
            this.panel1.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(333, 62);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1715, 1038);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2048, 1100);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSlideMenu);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel12.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel20.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panelReportsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxMinimized;
        private System.Windows.Forms.PictureBox pictureBoxMaximized;
        private System.Windows.Forms.PictureBox pictureBoxNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton iconButtonReports;
        private System.Windows.Forms.Panel panelReportsMenu;
        private FontAwesome.Sharp.IconButton iconButtonSurgerys;
        private System.Windows.Forms.Panel panel11;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelUserLog;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private FontAwesome.Sharp.IconButton iconButtonAbout;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel26;
    }
}