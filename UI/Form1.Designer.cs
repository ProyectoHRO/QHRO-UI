
namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.patient = new FontAwesome.Sharp.IconButton();
            this.assistant = new FontAwesome.Sharp.IconButton();
            this.anesthetist = new FontAwesome.Sharp.IconButton();
            this.Doctors = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelSlideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1104, 30);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.panelSlideMenu.Controls.Add(this.panel4);
            this.panelSlideMenu.Controls.Add(this.panel3);
            this.panelSlideMenu.Controls.Add(this.panel2);
            this.panelSlideMenu.Controls.Add(this.panel1);
            this.panelSlideMenu.Controls.Add(this.patient);
            this.panelSlideMenu.Controls.Add(this.assistant);
            this.panelSlideMenu.Controls.Add(this.anesthetist);
            this.panelSlideMenu.Controls.Add(this.Doctors);
            this.panelSlideMenu.Controls.Add(this.panelLogo);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 30);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(230, 503);
            this.panelSlideMenu.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel4.Location = new System.Drawing.Point(0, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 41);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 41);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel2.Location = new System.Drawing.Point(0, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 41);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 41);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // patient
            // 
            this.patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.patient.FlatAppearance.BorderSize = 0;
            this.patient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.ForeColor = System.Drawing.Color.White;
            this.patient.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.patient.IconColor = System.Drawing.Color.White;
            this.patient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.patient.IconSize = 38;
            this.patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patient.Location = new System.Drawing.Point(3, 247);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(227, 41);
            this.patient.TabIndex = 4;
            this.patient.Text = "Pacientes";
            this.patient.UseVisualStyleBackColor = false;
            this.patient.Click += new System.EventHandler(this.patient_Click);
            // 
            // assistant
            // 
            this.assistant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.assistant.FlatAppearance.BorderSize = 0;
            this.assistant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.assistant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assistant.ForeColor = System.Drawing.Color.White;
            this.assistant.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.assistant.IconColor = System.Drawing.Color.White;
            this.assistant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.assistant.IconSize = 38;
            this.assistant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assistant.Location = new System.Drawing.Point(3, 200);
            this.assistant.Name = "assistant";
            this.assistant.Size = new System.Drawing.Size(227, 41);
            this.assistant.TabIndex = 3;
            this.assistant.Text = "Ayudantes";
            this.assistant.UseVisualStyleBackColor = false;
            this.assistant.Click += new System.EventHandler(this.assistant_Click);
            // 
            // anesthetist
            // 
            this.anesthetist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.anesthetist.FlatAppearance.BorderSize = 0;
            this.anesthetist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.anesthetist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anesthetist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anesthetist.ForeColor = System.Drawing.Color.White;
            this.anesthetist.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.anesthetist.IconColor = System.Drawing.Color.White;
            this.anesthetist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.anesthetist.IconSize = 38;
            this.anesthetist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anesthetist.Location = new System.Drawing.Point(3, 153);
            this.anesthetist.Name = "anesthetist";
            this.anesthetist.Size = new System.Drawing.Size(227, 41);
            this.anesthetist.TabIndex = 2;
            this.anesthetist.Text = "Anestesista";
            this.anesthetist.UseVisualStyleBackColor = false;
            this.anesthetist.Click += new System.EventHandler(this.anesthetist_Click);
            // 
            // Doctors
            // 
            this.Doctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.Doctors.FlatAppearance.BorderSize = 0;
            this.Doctors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.Doctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Doctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctors.ForeColor = System.Drawing.Color.White;
            this.Doctors.IconChar = FontAwesome.Sharp.IconChar.Stethoscope;
            this.Doctors.IconColor = System.Drawing.Color.White;
            this.Doctors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Doctors.IconSize = 38;
            this.Doctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Doctors.Location = new System.Drawing.Point(3, 106);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(227, 41);
            this.Doctors.TabIndex = 1;
            this.Doctors.Text = "Doctores";
            this.Doctors.UseVisualStyleBackColor = false;
            this.Doctors.Click += new System.EventHandler(this.Doctors_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(60, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(230, 30);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(874, 503);
            this.panelContainer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 533);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSlideMenu);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSlideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSlideMenu;
        private FontAwesome.Sharp.IconButton Doctors;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton patient;
        private FontAwesome.Sharp.IconButton assistant;
        private FontAwesome.Sharp.IconButton anesthetist;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

