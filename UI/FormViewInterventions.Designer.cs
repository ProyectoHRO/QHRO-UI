
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
            this.reportViewerSurgeriesBdates = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewerSurgeriesServiceBdates = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewerSurgeriesQBdates = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iconButtonSurgeriesBdates = new FontAwesome.Sharp.IconButton();
            this.iconButtonSurgeriesServicesBdates = new FontAwesome.Sharp.IconButton();
            this.iconButtonSurgeriesQBdates = new FontAwesome.Sharp.IconButton();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.comboBoxOperatingRooms = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxSurgeriesByPatient = new System.Windows.Forms.TextBox();
            this.iconButtonSurgeriesByPatient = new FontAwesome.Sharp.IconButton();
            this.reportViewerSurgeriesByPatient = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1282, 922);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Intervenciones entre dos fechas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewerSurgeriesBdates
            // 
            this.reportViewerSurgeriesBdates.Location = new System.Drawing.Point(3, 48);
            this.reportViewerSurgeriesBdates.Name = "reportViewerSurgeriesBdates";
            this.reportViewerSurgeriesBdates.ServerReport.BearerToken = null;
            this.reportViewerSurgeriesBdates.Size = new System.Drawing.Size(1276, 864);
            this.reportViewerSurgeriesBdates.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxServiceName);
            this.tabPage2.Controls.Add(this.iconButtonSurgeriesServicesBdates);
            this.tabPage2.Controls.Add(this.reportViewerSurgeriesServiceBdates);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1282, 922);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Intervenciones por servicio entre dos fechas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewerSurgeriesServiceBdates
            // 
            this.reportViewerSurgeriesServiceBdates.Location = new System.Drawing.Point(0, 48);
            this.reportViewerSurgeriesServiceBdates.Name = "reportViewerSurgeriesServiceBdates";
            this.reportViewerSurgeriesServiceBdates.ServerReport.BearerToken = null;
            this.reportViewerSurgeriesServiceBdates.Size = new System.Drawing.Size(1276, 864);
            this.reportViewerSurgeriesServiceBdates.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxOperatingRooms);
            this.tabPage3.Controls.Add(this.iconButtonSurgeriesQBdates);
            this.tabPage3.Controls.Add(this.reportViewerSurgeriesQBdates);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1282, 922);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Intervenciones por quirófano entre dos fechas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewerSurgeriesQBdates
            // 
            this.reportViewerSurgeriesQBdates.Location = new System.Drawing.Point(10, 52);
            this.reportViewerSurgeriesQBdates.Name = "reportViewerSurgeriesQBdates";
            this.reportViewerSurgeriesQBdates.ServerReport.BearerToken = null;
            this.reportViewerSurgeriesQBdates.Size = new System.Drawing.Size(1276, 864);
            this.reportViewerSurgeriesQBdates.TabIndex = 1;
            // 
            // iconButtonSurgeriesBdates
            // 
            this.iconButtonSurgeriesBdates.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSurgeriesBdates.IconColor = System.Drawing.Color.Black;
            this.iconButtonSurgeriesBdates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSurgeriesBdates.Location = new System.Drawing.Point(479, 6);
            this.iconButtonSurgeriesBdates.Name = "iconButtonSurgeriesBdates";
            this.iconButtonSurgeriesBdates.Size = new System.Drawing.Size(179, 36);
            this.iconButtonSurgeriesBdates.TabIndex = 1;
            this.iconButtonSurgeriesBdates.Text = "iconButton2";
            this.iconButtonSurgeriesBdates.UseVisualStyleBackColor = true;
            this.iconButtonSurgeriesBdates.Click += new System.EventHandler(this.iconButtonSurgeriesBdates_Click);
            // 
            // iconButtonSurgeriesServicesBdates
            // 
            this.iconButtonSurgeriesServicesBdates.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSurgeriesServicesBdates.IconColor = System.Drawing.Color.Black;
            this.iconButtonSurgeriesServicesBdates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSurgeriesServicesBdates.Location = new System.Drawing.Point(428, 6);
            this.iconButtonSurgeriesServicesBdates.Name = "iconButtonSurgeriesServicesBdates";
            this.iconButtonSurgeriesServicesBdates.Size = new System.Drawing.Size(186, 36);
            this.iconButtonSurgeriesServicesBdates.TabIndex = 2;
            this.iconButtonSurgeriesServicesBdates.Text = "iconButton2";
            this.iconButtonSurgeriesServicesBdates.UseVisualStyleBackColor = true;
            this.iconButtonSurgeriesServicesBdates.Click += new System.EventHandler(this.iconButtonSurgeriesServicesBdates_Click);
            // 
            // iconButtonSurgeriesQBdates
            // 
            this.iconButtonSurgeriesQBdates.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSurgeriesQBdates.IconColor = System.Drawing.Color.Black;
            this.iconButtonSurgeriesQBdates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSurgeriesQBdates.Location = new System.Drawing.Point(656, 6);
            this.iconButtonSurgeriesQBdates.Name = "iconButtonSurgeriesQBdates";
            this.iconButtonSurgeriesQBdates.Size = new System.Drawing.Size(196, 40);
            this.iconButtonSurgeriesQBdates.TabIndex = 2;
            this.iconButtonSurgeriesQBdates.Text = "iconButton1";
            this.iconButtonSurgeriesQBdates.UseVisualStyleBackColor = true;
            this.iconButtonSurgeriesQBdates.Click += new System.EventHandler(this.iconButtonSurgeriesQBdates_Click);
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(215, 15);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(207, 20);
            this.textBoxServiceName.TabIndex = 3;
            // 
            // comboBoxOperatingRooms
            // 
            this.comboBoxOperatingRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperatingRooms.FormattingEnabled = true;
            this.comboBoxOperatingRooms.Location = new System.Drawing.Point(344, 17);
            this.comboBoxOperatingRooms.Name = "comboBoxOperatingRooms";
            this.comboBoxOperatingRooms.Size = new System.Drawing.Size(221, 21);
            this.comboBoxOperatingRooms.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxSurgeriesByPatient);
            this.tabPage4.Controls.Add(this.iconButtonSurgeriesByPatient);
            this.tabPage4.Controls.Add(this.reportViewerSurgeriesByPatient);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1282, 922);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Intervenciones por paciente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxSurgeriesByPatient
            // 
            this.textBoxSurgeriesByPatient.Location = new System.Drawing.Point(241, 17);
            this.textBoxSurgeriesByPatient.Name = "textBoxSurgeriesByPatient";
            this.textBoxSurgeriesByPatient.Size = new System.Drawing.Size(207, 20);
            this.textBoxSurgeriesByPatient.TabIndex = 6;
            // 
            // iconButtonSurgeriesByPatient
            // 
            this.iconButtonSurgeriesByPatient.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSurgeriesByPatient.IconColor = System.Drawing.Color.Black;
            this.iconButtonSurgeriesByPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSurgeriesByPatient.Location = new System.Drawing.Point(479, 8);
            this.iconButtonSurgeriesByPatient.Name = "iconButtonSurgeriesByPatient";
            this.iconButtonSurgeriesByPatient.Size = new System.Drawing.Size(186, 36);
            this.iconButtonSurgeriesByPatient.TabIndex = 5;
            this.iconButtonSurgeriesByPatient.Text = "iconButton2";
            this.iconButtonSurgeriesByPatient.UseVisualStyleBackColor = true;
            this.iconButtonSurgeriesByPatient.Click += new System.EventHandler(this.iconButtonSurgeriesByPatient_Click);
            // 
            // reportViewerSurgeriesByPatient
            // 
            this.reportViewerSurgeriesByPatient.Location = new System.Drawing.Point(3, 50);
            this.reportViewerSurgeriesByPatient.Name = "reportViewerSurgeriesByPatient";
            this.reportViewerSurgeriesByPatient.ServerReport.BearerToken = null;
            this.reportViewerSurgeriesByPatient.Size = new System.Drawing.Size(1276, 864);
            this.reportViewerSurgeriesByPatient.TabIndex = 4;
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
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSurgeriesBdates;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private FontAwesome.Sharp.IconButton iconButtonSurgeriesBdates;
        private FontAwesome.Sharp.IconButton iconButtonSurgeriesServicesBdates;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSurgeriesServiceBdates;
        private FontAwesome.Sharp.IconButton iconButtonSurgeriesQBdates;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSurgeriesQBdates;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.ComboBox comboBoxOperatingRooms;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxSurgeriesByPatient;
        private FontAwesome.Sharp.IconButton iconButtonSurgeriesByPatient;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSurgeriesByPatient;
    }
}