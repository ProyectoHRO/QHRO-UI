
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
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSlideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panelTop.Controls.Add(this.pictureBoxMinimized);
            this.panelTop.Controls.Add(this.pictureBoxMaximized);
            this.panelTop.Controls.Add(this.pictureBoxNormal);
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1500, 62);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // pictureBoxMinimized
            // 
            this.pictureBoxMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimized.Image = global::UI.Properties.Resources.minimazar;
            this.pictureBoxMinimized.Location = new System.Drawing.Point(1368, 15);
            this.pictureBoxMinimized.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxMinimized.Name = "pictureBoxMinimized";
            this.pictureBoxMinimized.Size = new System.Drawing.Size(33, 31);
            this.pictureBoxMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimized.TabIndex = 1;
            this.pictureBoxMinimized.TabStop = false;
            this.pictureBoxMinimized.Click += new System.EventHandler(this.pictureBoxMinimized_Click);
            // 
            // pictureBoxMaximized
            // 
            this.pictureBoxMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaximized.Image = global::UI.Properties.Resources.maxi;
            this.pictureBoxMaximized.Location = new System.Drawing.Point(1409, 15);
            this.pictureBoxMaximized.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxMaximized.Name = "pictureBoxMaximized";
            this.pictureBoxMaximized.Size = new System.Drawing.Size(33, 31);
            this.pictureBoxMaximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaximized.TabIndex = 2;
            this.pictureBoxMaximized.TabStop = false;
            this.pictureBoxMaximized.Click += new System.EventHandler(this.pictureBoxMaximized_Click);
            // 
            // pictureBoxNormal
            // 
            this.pictureBoxNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNormal.Image = global::UI.Properties.Resources.res;
            this.pictureBoxNormal.Location = new System.Drawing.Point(1409, 15);
            this.pictureBoxNormal.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxNormal.Name = "pictureBoxNormal";
            this.pictureBoxNormal.Size = new System.Drawing.Size(33, 31);
            this.pictureBoxNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNormal.TabIndex = 3;
            this.pictureBoxNormal.TabStop = false;
            this.pictureBoxNormal.Click += new System.EventHandler(this.pictureBoxNormal_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::UI.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(1451, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
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
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
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
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 62);
            this.panelSlideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(333, 838);
            this.panelSlideMenu.TabIndex = 1;
            // 
            // iconButtonServices
            // 
            this.iconButtonServices.FlatAppearance.BorderSize = 0;
            this.iconButtonServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonServices.ForeColor = System.Drawing.Color.White;
            this.iconButtonServices.IconChar = FontAwesome.Sharp.IconChar.Medkit;
            this.iconButtonServices.IconColor = System.Drawing.Color.White;
            this.iconButtonServices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonServices.IconSize = 38;
            this.iconButtonServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonServices.Location = new System.Drawing.Point(4, 540);
            this.iconButtonServices.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonServices.Name = "iconButtonServices";
            this.iconButtonServices.Size = new System.Drawing.Size(329, 55);
            this.iconButtonServices.TabIndex = 12;
            this.iconButtonServices.Text = "Servicios";
            this.iconButtonServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonServices.UseVisualStyleBackColor = true;
            this.iconButtonServices.Click += new System.EventHandler(this.iconButtonServices_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel6.Location = new System.Drawing.Point(0, 540);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 55);
            this.panel6.TabIndex = 11;
            // 
            // iconButtonOperatingRooms
            // 
            this.iconButtonOperatingRooms.FlatAppearance.BorderSize = 0;
            this.iconButtonOperatingRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOperatingRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonOperatingRooms.ForeColor = System.Drawing.Color.White;
            this.iconButtonOperatingRooms.IconChar = FontAwesome.Sharp.IconChar.Hospital;
            this.iconButtonOperatingRooms.IconColor = System.Drawing.Color.White;
            this.iconButtonOperatingRooms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOperatingRooms.IconSize = 38;
            this.iconButtonOperatingRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOperatingRooms.Location = new System.Drawing.Point(4, 466);
            this.iconButtonOperatingRooms.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonOperatingRooms.Name = "iconButtonOperatingRooms";
            this.iconButtonOperatingRooms.Size = new System.Drawing.Size(329, 55);
            this.iconButtonOperatingRooms.TabIndex = 10;
            this.iconButtonOperatingRooms.Text = "Quirofanos";
            this.iconButtonOperatingRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOperatingRooms.UseVisualStyleBackColor = true;
            this.iconButtonOperatingRooms.Click += new System.EventHandler(this.iconButtonOperatingRooms_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel5.Location = new System.Drawing.Point(0, 466);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 55);
            this.panel5.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(81, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // iconButtonPatient
            // 
            this.iconButtonPatient.FlatAppearance.BorderSize = 0;
            this.iconButtonPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonPatient.ForeColor = System.Drawing.Color.White;
            this.iconButtonPatient.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.iconButtonPatient.IconColor = System.Drawing.Color.White;
            this.iconButtonPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPatient.IconSize = 38;
            this.iconButtonPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPatient.Location = new System.Drawing.Point(4, 391);
            this.iconButtonPatient.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonPatient.Name = "iconButtonPatient";
            this.iconButtonPatient.Size = new System.Drawing.Size(329, 55);
            this.iconButtonPatient.TabIndex = 7;
            this.iconButtonPatient.Text = "Pacientes";
            this.iconButtonPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPatient.UseVisualStyleBackColor = true;
            this.iconButtonPatient.Click += new System.EventHandler(this.iconButtonPatient_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel4.Location = new System.Drawing.Point(0, 391);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 55);
            this.panel4.TabIndex = 6;
            // 
            // iconButtonAssistant
            // 
            this.iconButtonAssistant.FlatAppearance.BorderSize = 0;
            this.iconButtonAssistant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAssistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAssistant.ForeColor = System.Drawing.Color.White;
            this.iconButtonAssistant.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.iconButtonAssistant.IconColor = System.Drawing.Color.White;
            this.iconButtonAssistant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAssistant.IconSize = 38;
            this.iconButtonAssistant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAssistant.Location = new System.Drawing.Point(4, 318);
            this.iconButtonAssistant.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonAssistant.Name = "iconButtonAssistant";
            this.iconButtonAssistant.Size = new System.Drawing.Size(329, 55);
            this.iconButtonAssistant.TabIndex = 5;
            this.iconButtonAssistant.Text = "Ayudante";
            this.iconButtonAssistant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAssistant.UseVisualStyleBackColor = true;
            this.iconButtonAssistant.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(0, 318);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 55);
            this.panel3.TabIndex = 4;
            // 
            // iconButtonAnesthetist
            // 
            this.iconButtonAnesthetist.FlatAppearance.BorderSize = 0;
            this.iconButtonAnesthetist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAnesthetist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAnesthetist.ForeColor = System.Drawing.Color.White;
            this.iconButtonAnesthetist.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.iconButtonAnesthetist.IconColor = System.Drawing.Color.White;
            this.iconButtonAnesthetist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAnesthetist.IconSize = 38;
            this.iconButtonAnesthetist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAnesthetist.Location = new System.Drawing.Point(4, 242);
            this.iconButtonAnesthetist.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonAnesthetist.Name = "iconButtonAnesthetist";
            this.iconButtonAnesthetist.Size = new System.Drawing.Size(329, 55);
            this.iconButtonAnesthetist.TabIndex = 3;
            this.iconButtonAnesthetist.Text = "Anestesistas";
            this.iconButtonAnesthetist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAnesthetist.UseVisualStyleBackColor = true;
            this.iconButtonAnesthetist.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel2.Location = new System.Drawing.Point(0, 242);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 55);
            this.panel2.TabIndex = 2;
            // 
            // iconButtonDoctors
            // 
            this.iconButtonDoctors.FlatAppearance.BorderSize = 0;
            this.iconButtonDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDoctors.ForeColor = System.Drawing.Color.White;
            this.iconButtonDoctors.IconChar = FontAwesome.Sharp.IconChar.Stethoscope;
            this.iconButtonDoctors.IconColor = System.Drawing.Color.White;
            this.iconButtonDoctors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDoctors.IconSize = 38;
            this.iconButtonDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDoctors.Location = new System.Drawing.Point(4, 166);
            this.iconButtonDoctors.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonDoctors.Name = "iconButtonDoctors";
            this.iconButtonDoctors.Size = new System.Drawing.Size(329, 55);
            this.iconButtonDoctors.TabIndex = 1;
            this.iconButtonDoctors.Text = "Doctores";
            this.iconButtonDoctors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDoctors.UseVisualStyleBackColor = true;
            this.iconButtonDoctors.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(0, 166);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 55);
            this.panel1.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(333, 62);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1167, 838);
            this.panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSlideMenu);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}