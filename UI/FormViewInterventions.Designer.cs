
namespace UI
{
    partial class FormViewInterventions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iconButtonSurgeriesBdates = new FontAwesome.Sharp.IconButton();
            this.reportViewerSurgeriesBdates = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iconButtonSurgeriesServicesBdates = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.reportViewerSurgeriesServiceBdates = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButtonSurgeriesQBdates = new FontAwesome.Sharp.IconButton();
            this.comboBoxOperatingRooms = new System.Windows.Forms.ComboBox();
            this.reportViewerSurgeriesQBdates = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSurgeriesByPatient = new System.Windows.Forms.TextBox();
            this.iconButtonSurgeriesByPatient = new FontAwesome.Sharp.IconButton();
            this.reportViewerSurgeriesByPatient = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.iconButtonSurgeriesAnesthesiaBdates = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAnesthesiaName = new System.Windows.Forms.TextBox();
            this.reportViewerAnesthesiaByDates = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1290, 948);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.iconButtonSurgeriesBdates);
            this.tabPage1.Controls.Add(this.reportViewerSurgeriesBdates);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1282, 915);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Intervenciones entre dos fechas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // iconButtonSurgeriesBdates
            // 
            this.iconButtonSurgeriesBdates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSurgeriesBdates.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonSurgeriesBdates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonSurgeriesBdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSurgeriesBdates.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSurgeriesBdates.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconButtonSurgeriesBdates.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonSurgeriesBdates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSurgeriesBdates.IconSize = 32;
            this.iconButtonSurgeriesBdates.Location = new System.Drawing.Point(514, 11);
            this.iconButtonSurgeriesBdates.Name = "iconButtonSurgeriesBdates";
            this.iconButtonSurgeriesBdates.Size = new System.Drawing.Size(191, 49);
            this.iconButtonSurgeriesBdates.TabIndex = 1;
            this.iconButtonSurgeriesBdates.Text = "Establecer fechas";
            this.iconButtonSurgeriesBdates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSurgeriesBdates.UseVisualStyleBackColor = true;
            this.iconButtonSurgeriesBdates.Click += new System.EventHandler(this.iconButtonSurgeriesBdates_Click);
            // 
            // reportViewerSurgeriesBdates
            // 
            this.reportViewerSurgeriesBdates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerSurgeriesBdates.Location = new System.Drawing.Point(10, 63);
            this.reportViewerSurgeriesBdates.Name = "reportViewerSurgeriesBdates";
            this.reportViewerSurgeriesBdates.ServerReport.BearerToken = null;
            this.reportViewerSurgeriesBdates.Size = new System.Drawing.Size(1262, 842);
            this.reportViewerSurgeriesBdates.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.iconButtonSurgeriesServicesBdates);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxServiceName);
            this.tabPage2.Controls.Add(this.reportViewerSurgeriesServiceBdates);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1282, 915);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Intervenciones por servicio entre dos fechas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // iconButtonSurgeriesServicesBdates
            // 
            this.iconButtonSurgeriesServicesBdates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSurgeriesServicesBdates.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonSurgeriesServicesBdates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonSurgeriesServicesBdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSurgeriesServicesBdates.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSurgeriesServicesBdates.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconButtonSurgeriesServicesBdates.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonSurgeriesServicesBdates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSurgeriesServicesBdates.IconSize = 32;
            this.iconButtonSurgeriesServicesBdates.Location = new System.Drawing.Point(640, 8);
            this.iconButtonSurgeriesServicesBdates.Name = "iconButtonSurgeriesServicesBdates";
            this.iconButtonSurgeriesServicesBdates.Size = new System.Drawing.Size(191, 49);
            this.iconButtonSurgeriesServicesBdates.TabIndex = 5;
            this.iconButtonSurgeriesServicesBdates.Text = "Establecer fechas";
            this.iconButtonSurgeriesServicesBdates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSurgeriesServicesBdates.UseVisualStyleBackColor = true;
            this.iconButtonSurgeriesServicesBdates.Click += new System.EventHandler(this.iconButtonSurgeriesServicesBdates_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Servicio:";
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxServiceName.Location = new System.Drawing.Point(427, 19);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(207, 26);
            this.textBoxServiceName.TabIndex = 3;
            // 
            // reportViewerSurgeriesServiceBdates
            // 
            this.reportViewerSurgeriesServiceBdates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerSurgeriesServiceBdates.Location = new System.Drawing.Point(10, 63);
            this.reportViewerSurgeriesServiceBdates.Name = "reportViewerSurgeriesServiceBdates";
            this.reportViewerSurgeriesServiceBdates.ServerReport.BearerToken = null;
            this.reportViewerSurgeriesServiceBdates.Size = new System.Drawing.Size(1262, 842);
            this.reportViewerSurgeriesServiceBdates.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.iconButtonSurgeriesQBdates);
            this.tabPage3.Controls.Add(this.comboBoxOperatingRooms);
            this.tabPage3.Controls.Add(this.reportViewerSurgeriesQBdates);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1282, 915);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Intervenciones por quirófano entre dos fechas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quirofano:";
            // 
            // iconButtonSurgeriesQBdates
            // 
            this.iconButtonSurgeriesQBdates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSurgeriesQBdates.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonSurgeriesQBdates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonSurgeriesQBdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSurgeriesQBdates.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSurgeriesQBdates.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconButtonSurgeriesQBdates.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonSurgeriesQBdates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSurgeriesQBdates.IconSize = 32;
            this.iconButtonSurgeriesQBdates.Location = new System.Drawing.Point(571, 8);
            this.iconButtonSurgeriesQBdates.Name = "iconButtonSurgeriesQBdates";
            this.iconButtonSurgeriesQBdates.Size = new System.Drawing.Size(191, 49);
            this.iconButtonSurgeriesQBdates.TabIndex = 6;
            this.iconButtonSurgeriesQBdates.Text = "Establecer fechas";
            this.iconButtonSurgeriesQBdates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSurgeriesQBdates.UseVisualStyleBackColor = true;
            this.iconButtonSurgeriesQBdates.Click += new System.EventHandler(this.iconButtonSurgeriesQBdates_Click);
            // 
            // comboBoxOperatingRooms
            // 
            this.comboBoxOperatingRooms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxOperatingRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperatingRooms.FormattingEnabled = true;
            this.comboBoxOperatingRooms.Location = new System.Drawing.Point(458, 17);
            this.comboBoxOperatingRooms.Name = "comboBoxOperatingRooms";
            this.comboBoxOperatingRooms.Size = new System.Drawing.Size(107, 28);
            this.comboBoxOperatingRooms.TabIndex = 3;
            // 
            // reportViewerSurgeriesQBdates
            // 
            this.reportViewerSurgeriesQBdates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerSurgeriesQBdates.Location = new System.Drawing.Point(10, 63);
            this.reportViewerSurgeriesQBdates.Name = "reportViewerSurgeriesQBdates";
            this.reportViewerSurgeriesQBdates.ServerReport.BearerToken = null;
            this.reportViewerSurgeriesQBdates.Size = new System.Drawing.Size(1262, 842);
            this.reportViewerSurgeriesQBdates.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.textBoxSurgeriesByPatient);
            this.tabPage4.Controls.Add(this.iconButtonSurgeriesByPatient);
            this.tabPage4.Controls.Add(this.reportViewerSurgeriesByPatient);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1282, 915);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Intervenciones por paciente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "No. Historia:";
            // 
            // textBoxSurgeriesByPatient
            // 
            this.textBoxSurgeriesByPatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSurgeriesByPatient.Location = new System.Drawing.Point(436, 22);
            this.textBoxSurgeriesByPatient.Name = "textBoxSurgeriesByPatient";
            this.textBoxSurgeriesByPatient.Size = new System.Drawing.Size(207, 26);
            this.textBoxSurgeriesByPatient.TabIndex = 6;
            // 
            // iconButtonSurgeriesByPatient
            // 
            this.iconButtonSurgeriesByPatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSurgeriesByPatient.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonSurgeriesByPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonSurgeriesByPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSurgeriesByPatient.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSurgeriesByPatient.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButtonSurgeriesByPatient.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonSurgeriesByPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSurgeriesByPatient.IconSize = 32;
            this.iconButtonSurgeriesByPatient.Location = new System.Drawing.Point(649, 12);
            this.iconButtonSurgeriesByPatient.Name = "iconButtonSurgeriesByPatient";
            this.iconButtonSurgeriesByPatient.Size = new System.Drawing.Size(186, 47);
            this.iconButtonSurgeriesByPatient.TabIndex = 5;
            this.iconButtonSurgeriesByPatient.Text = "Generar";
            this.iconButtonSurgeriesByPatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSurgeriesByPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSurgeriesByPatient.UseVisualStyleBackColor = true;
            this.iconButtonSurgeriesByPatient.Click += new System.EventHandler(this.iconButtonSurgeriesByPatient_Click);
            // 
            // reportViewerSurgeriesByPatient
            // 
            this.reportViewerSurgeriesByPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerSurgeriesByPatient.Location = new System.Drawing.Point(10, 63);
            this.reportViewerSurgeriesByPatient.Name = "reportViewerSurgeriesByPatient";
            this.reportViewerSurgeriesByPatient.ServerReport.BearerToken = null;
            this.reportViewerSurgeriesByPatient.Size = new System.Drawing.Size(1262, 842);
            this.reportViewerSurgeriesByPatient.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.iconButtonSurgeriesAnesthesiaBdates);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.textBoxAnesthesiaName);
            this.tabPage5.Controls.Add(this.reportViewerAnesthesiaByDates);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1282, 915);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Intervenciones por anestesia entre dos fechas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // iconButtonSurgeriesAnesthesiaBdates
            // 
            this.iconButtonSurgeriesAnesthesiaBdates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSurgeriesAnesthesiaBdates.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonSurgeriesAnesthesiaBdates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonSurgeriesAnesthesiaBdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSurgeriesAnesthesiaBdates.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSurgeriesAnesthesiaBdates.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconButtonSurgeriesAnesthesiaBdates.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonSurgeriesAnesthesiaBdates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSurgeriesAnesthesiaBdates.IconSize = 32;
            this.iconButtonSurgeriesAnesthesiaBdates.Location = new System.Drawing.Point(640, 9);
            this.iconButtonSurgeriesAnesthesiaBdates.Name = "iconButtonSurgeriesAnesthesiaBdates";
            this.iconButtonSurgeriesAnesthesiaBdates.Size = new System.Drawing.Size(191, 49);
            this.iconButtonSurgeriesAnesthesiaBdates.TabIndex = 13;
            this.iconButtonSurgeriesAnesthesiaBdates.Text = "Establecer fechas";
            this.iconButtonSurgeriesAnesthesiaBdates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSurgeriesAnesthesiaBdates.UseVisualStyleBackColor = true;
            this.iconButtonSurgeriesAnesthesiaBdates.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Anestesia:";
            // 
            // textBoxAnesthesiaName
            // 
            this.textBoxAnesthesiaName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAnesthesiaName.Location = new System.Drawing.Point(427, 20);
            this.textBoxAnesthesiaName.Name = "textBoxAnesthesiaName";
            this.textBoxAnesthesiaName.Size = new System.Drawing.Size(207, 26);
            this.textBoxAnesthesiaName.TabIndex = 11;
            // 
            // reportViewerAnesthesiaByDates
            // 
            this.reportViewerAnesthesiaByDates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerAnesthesiaByDates.Location = new System.Drawing.Point(10, 64);
            this.reportViewerAnesthesiaByDates.Name = "reportViewerAnesthesiaByDates";
            this.reportViewerAnesthesiaByDates.ServerReport.BearerToken = null;
            this.reportViewerAnesthesiaByDates.Size = new System.Drawing.Size(1262, 842);
            this.reportViewerAnesthesiaByDates.TabIndex = 10;
            // 
            // FormViewInterventions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 947);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewInterventions";
            this.Text = "FormViewInterventions";
            this.Load += new System.EventHandler(this.FormViewInterventions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSurgeriesBdates;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private FontAwesome.Sharp.IconButton iconButtonSurgeriesBdates;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSurgeriesServiceBdates;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSurgeriesQBdates;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.ComboBox comboBoxOperatingRooms;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxSurgeriesByPatient;
        private FontAwesome.Sharp.IconButton iconButtonSurgeriesByPatient;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSurgeriesByPatient;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonSurgeriesServicesBdates;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButtonSurgeriesQBdates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private FontAwesome.Sharp.IconButton iconButtonSurgeriesAnesthesiaBdates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAnesthesiaName;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAnesthesiaByDates;
    }
}