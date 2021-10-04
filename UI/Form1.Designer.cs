
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
            this.pictureBoxMinimized = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximized = new System.Windows.Forms.PictureBox();
            this.pictureBoxNormal = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.panelReportsMenu = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.iconButtonSurgerys = new FontAwesome.Sharp.IconButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.iconButtonReports = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.iconButtonServices = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconButtonOperatingRooms = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButtonPatient = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButtonAssistant = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButtonAnesthetist = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButtonDoctors = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUserLog = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSlideMenu.SuspendLayout();
            this.panelReportsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panelTop.Controls.Add(this.labelUserLog);
            this.panelTop.Controls.Add(this.labelUser);
            this.panelTop.Controls.Add(this.pictureBoxMinimized);
            this.panelTop.Controls.Add(this.pictureBoxMaximized);
            this.panelTop.Controls.Add(this.pictureBoxNormal);
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1256, 50);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // pictureBoxMinimized
            // 
            this.pictureBoxMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimized.Image = global::UI.Properties.Resources.minimazar;
            this.pictureBoxMinimized.Location = new System.Drawing.Point(1157, 12);
            this.pictureBoxMinimized.Name = "pictureBoxMinimized";
            this.pictureBoxMinimized.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimized.TabIndex = 1;
            this.pictureBoxMinimized.TabStop = false;
            this.pictureBoxMinimized.Click += new System.EventHandler(this.pictureBoxMinimized_Click);
            // 
            // pictureBoxMaximized
            // 
            this.pictureBoxMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMaximized.Image = global::UI.Properties.Resources.maxi;
            this.pictureBoxMaximized.Location = new System.Drawing.Point(1188, 12);
            this.pictureBoxMaximized.Name = "pictureBoxMaximized";
            this.pictureBoxMaximized.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMaximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaximized.TabIndex = 2;
            this.pictureBoxMaximized.TabStop = false;
            this.pictureBoxMaximized.Click += new System.EventHandler(this.pictureBoxMaximized_Click);
            // 
            // pictureBoxNormal
            // 
            this.pictureBoxNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNormal.Image = global::UI.Properties.Resources.res;
            this.pictureBoxNormal.Location = new System.Drawing.Point(1188, 12);
            this.pictureBoxNormal.Name = "pictureBoxNormal";
            this.pictureBoxNormal.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNormal.TabIndex = 3;
            this.pictureBoxNormal.TabStop = false;
            this.pictureBoxNormal.Click += new System.EventHandler(this.pictureBoxNormal_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::UI.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(1219, 12);
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
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.panelSlideMenu.Controls.Add(this.panelReportsMenu);
            this.panelSlideMenu.Controls.Add(this.iconButtonReports);
            this.panelSlideMenu.Controls.Add(this.panel9);
            this.panelSlideMenu.Controls.Add(this.iconButton2);
            this.panelSlideMenu.Controls.Add(this.panel8);
            this.panelSlideMenu.Controls.Add(this.iconButton1);
            this.panelSlideMenu.Controls.Add(this.panel7);
            this.panelSlideMenu.Controls.Add(this.iconButtonServices);
            this.panelSlideMenu.Controls.Add(this.panel6);
            this.panelSlideMenu.Controls.Add(this.iconButtonOperatingRooms);
            this.panelSlideMenu.Controls.Add(this.panel5);
            this.panelSlideMenu.Controls.Add(this.pictureBox1);
            this.panelSlideMenu.Controls.Add(this.iconButtonPatient);
            this.panelSlideMenu.Controls.Add(this.panel4);
            this.panelSlideMenu.Controls.Add(this.iconButtonAssistant);
            this.panelSlideMenu.Controls.Add(this.panel3);
            this.panelSlideMenu.Controls.Add(this.iconButtonAnesthetist);
            this.panelSlideMenu.Controls.Add(this.panel2);
            this.panelSlideMenu.Controls.Add(this.iconButtonDoctors);
            this.panelSlideMenu.Controls.Add(this.panel1);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 50);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(250, 752);
            this.panelSlideMenu.TabIndex = 1;
            // 
            // panelReportsMenu
            // 
            this.panelReportsMenu.Controls.Add(this.iconButton3);
            this.panelReportsMenu.Controls.Add(this.panel10);
            this.panelReportsMenu.Controls.Add(this.iconButton5);
            this.panelReportsMenu.Controls.Add(this.panel12);
            this.panelReportsMenu.Controls.Add(this.iconButtonSurgerys);
            this.panelReportsMenu.Controls.Add(this.panel11);
            this.panelReportsMenu.Location = new System.Drawing.Point(47, 599);
            this.panelReportsMenu.Name = "panelReportsMenu";
            this.panelReportsMenu.Size = new System.Drawing.Size(204, 170);
            this.panelReportsMenu.TabIndex = 19;
            this.panelReportsMenu.Visible = false;
            // 
            // iconButton5
            // 
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 38;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(3, 54);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(201, 45);
            this.iconButton5.TabIndex = 22;
            this.iconButton5.Text = "Quirófanos";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel12.Location = new System.Drawing.Point(0, 54);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 45);
            this.panel12.TabIndex = 21;
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
            this.iconButtonSurgerys.Size = new System.Drawing.Size(201, 45);
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
            this.iconButtonReports.FlatAppearance.BorderSize = 0;
            this.iconButtonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonReports.ForeColor = System.Drawing.Color.White;
            this.iconButtonReports.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButtonReports.IconColor = System.Drawing.Color.White;
            this.iconButtonReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonReports.IconSize = 38;
            this.iconButtonReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReports.Location = new System.Drawing.Point(3, 548);
            this.iconButtonReports.Name = "iconButtonReports";
            this.iconButtonReports.Size = new System.Drawing.Size(247, 45);
            this.iconButtonReports.TabIndex = 18;
            this.iconButtonReports.Text = "Reportes";
            this.iconButtonReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonReports.UseVisualStyleBackColor = true;
            this.iconButtonReports.Click += new System.EventHandler(this.iconButtonReports_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel9.Location = new System.Drawing.Point(0, 548);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(3, 45);
            this.panel9.TabIndex = 17;
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 38;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(3, 497);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(247, 45);
            this.iconButton2.TabIndex = 16;
            this.iconButton2.Text = "Asignar cirugías";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel8.Location = new System.Drawing.Point(0, 497);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 45);
            this.panel8.TabIndex = 15;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 38;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 446);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(247, 45);
            this.iconButton1.TabIndex = 14;
            this.iconButton1.Text = "Solicitar cirugía";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel7.Location = new System.Drawing.Point(0, 446);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 45);
            this.panel7.TabIndex = 13;
            // 
            // iconButtonServices
            // 
            this.iconButtonServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonServices.FlatAppearance.BorderSize = 0;
            this.iconButtonServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonServices.ForeColor = System.Drawing.Color.White;
            this.iconButtonServices.IconChar = FontAwesome.Sharp.IconChar.Medkit;
            this.iconButtonServices.IconColor = System.Drawing.Color.White;
            this.iconButtonServices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonServices.IconSize = 38;
            this.iconButtonServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonServices.Location = new System.Drawing.Point(3, 395);
            this.iconButtonServices.Name = "iconButtonServices";
            this.iconButtonServices.Size = new System.Drawing.Size(247, 45);
            this.iconButtonServices.TabIndex = 12;
            this.iconButtonServices.Text = "Servicios";
            this.iconButtonServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonServices.UseVisualStyleBackColor = true;
            this.iconButtonServices.Click += new System.EventHandler(this.iconButtonServices_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel6.Location = new System.Drawing.Point(0, 395);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 45);
            this.panel6.TabIndex = 11;
            // 
            // iconButtonOperatingRooms
            // 
            this.iconButtonOperatingRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonOperatingRooms.FlatAppearance.BorderSize = 0;
            this.iconButtonOperatingRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOperatingRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonOperatingRooms.ForeColor = System.Drawing.Color.White;
            this.iconButtonOperatingRooms.IconChar = FontAwesome.Sharp.IconChar.Hospital;
            this.iconButtonOperatingRooms.IconColor = System.Drawing.Color.White;
            this.iconButtonOperatingRooms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOperatingRooms.IconSize = 38;
            this.iconButtonOperatingRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOperatingRooms.Location = new System.Drawing.Point(3, 344);
            this.iconButtonOperatingRooms.Name = "iconButtonOperatingRooms";
            this.iconButtonOperatingRooms.Size = new System.Drawing.Size(247, 45);
            this.iconButtonOperatingRooms.TabIndex = 10;
            this.iconButtonOperatingRooms.Text = "Quirófanos";
            this.iconButtonOperatingRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOperatingRooms.UseVisualStyleBackColor = true;
            this.iconButtonOperatingRooms.Click += new System.EventHandler(this.iconButtonOperatingRooms_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel5.Location = new System.Drawing.Point(0, 344);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 45);
            this.panel5.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(61, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // iconButtonPatient
            // 
            this.iconButtonPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonPatient.FlatAppearance.BorderSize = 0;
            this.iconButtonPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonPatient.ForeColor = System.Drawing.Color.White;
            this.iconButtonPatient.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.iconButtonPatient.IconColor = System.Drawing.Color.White;
            this.iconButtonPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPatient.IconSize = 38;
            this.iconButtonPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPatient.Location = new System.Drawing.Point(3, 293);
            this.iconButtonPatient.Name = "iconButtonPatient";
            this.iconButtonPatient.Size = new System.Drawing.Size(247, 45);
            this.iconButtonPatient.TabIndex = 7;
            this.iconButtonPatient.Text = "Pacientes";
            this.iconButtonPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPatient.UseVisualStyleBackColor = true;
            this.iconButtonPatient.Click += new System.EventHandler(this.iconButtonPatient_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel4.Location = new System.Drawing.Point(0, 293);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 45);
            this.panel4.TabIndex = 6;
            // 
            // iconButtonAssistant
            // 
            this.iconButtonAssistant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonAssistant.FlatAppearance.BorderSize = 0;
            this.iconButtonAssistant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAssistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAssistant.ForeColor = System.Drawing.Color.White;
            this.iconButtonAssistant.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.iconButtonAssistant.IconColor = System.Drawing.Color.White;
            this.iconButtonAssistant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAssistant.IconSize = 38;
            this.iconButtonAssistant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAssistant.Location = new System.Drawing.Point(3, 242);
            this.iconButtonAssistant.Name = "iconButtonAssistant";
            this.iconButtonAssistant.Size = new System.Drawing.Size(247, 45);
            this.iconButtonAssistant.TabIndex = 5;
            this.iconButtonAssistant.Text = "Ayudante";
            this.iconButtonAssistant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAssistant.UseVisualStyleBackColor = true;
            this.iconButtonAssistant.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(0, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 45);
            this.panel3.TabIndex = 4;
            // 
            // iconButtonAnesthetist
            // 
            this.iconButtonAnesthetist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonAnesthetist.FlatAppearance.BorderSize = 0;
            this.iconButtonAnesthetist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAnesthetist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAnesthetist.ForeColor = System.Drawing.Color.White;
            this.iconButtonAnesthetist.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.iconButtonAnesthetist.IconColor = System.Drawing.Color.White;
            this.iconButtonAnesthetist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAnesthetist.IconSize = 38;
            this.iconButtonAnesthetist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAnesthetist.Location = new System.Drawing.Point(3, 191);
            this.iconButtonAnesthetist.Name = "iconButtonAnesthetist";
            this.iconButtonAnesthetist.Size = new System.Drawing.Size(247, 45);
            this.iconButtonAnesthetist.TabIndex = 3;
            this.iconButtonAnesthetist.Text = "Anestesistas";
            this.iconButtonAnesthetist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAnesthetist.UseVisualStyleBackColor = true;
            this.iconButtonAnesthetist.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel2.Location = new System.Drawing.Point(0, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 45);
            this.panel2.TabIndex = 2;
            // 
            // iconButtonDoctors
            // 
            this.iconButtonDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonDoctors.FlatAppearance.BorderSize = 0;
            this.iconButtonDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDoctors.ForeColor = System.Drawing.Color.White;
            this.iconButtonDoctors.IconChar = FontAwesome.Sharp.IconChar.Stethoscope;
            this.iconButtonDoctors.IconColor = System.Drawing.Color.White;
            this.iconButtonDoctors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDoctors.IconSize = 38;
            this.iconButtonDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDoctors.Location = new System.Drawing.Point(3, 140);
            this.iconButtonDoctors.Name = "iconButtonDoctors";
            this.iconButtonDoctors.Size = new System.Drawing.Size(247, 45);
            this.iconButtonDoctors.TabIndex = 1;
            this.iconButtonDoctors.Text = "Doctores";
            this.iconButtonDoctors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDoctors.UseVisualStyleBackColor = true;
            this.iconButtonDoctors.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 45);
            this.panel1.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1006, 752);
            this.panelContainer.TabIndex = 2;
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
            this.iconButton3.Location = new System.Drawing.Point(3, 105);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(201, 45);
            this.iconButton3.TabIndex = 24;
            this.iconButton3.Text = "Reportes";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel10.Location = new System.Drawing.Point(0, 105);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 45);
            this.panel10.TabIndex = 23;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(893, 9);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(68, 25);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "User:";
            // 
            // labelUserLog
            // 
            this.labelUserLog.AutoSize = true;
            this.labelUserLog.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserLog.ForeColor = System.Drawing.Color.White;
            this.labelUserLog.Location = new System.Drawing.Point(965, 11);
            this.labelUserLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserLog.Name = "labelUserLog";
            this.labelUserLog.Size = new System.Drawing.Size(100, 25);
            this.labelUserLog.TabIndex = 6;
            this.labelUserLog.Text = "UserLog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 802);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSlideMenu);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSlideMenu.ResumeLayout(false);
            this.panelReportsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonPatient;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButtonAssistant;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButtonAnesthetist;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonDoctors;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxMinimized;
        private System.Windows.Forms.PictureBox pictureBoxMaximized;
        private System.Windows.Forms.PictureBox pictureBoxNormal;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonOperatingRooms;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButtonServices;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton iconButtonReports;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panelReportsMenu;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Panel panel12;
        private FontAwesome.Sharp.IconButton iconButtonSurgerys;
        private System.Windows.Forms.Panel panel11;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelUserLog;
        private System.Windows.Forms.Label labelUser;
    }
}