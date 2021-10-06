
namespace UI
{
    partial class FormSearch
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
            this.tabPageDoctor = new System.Windows.Forms.TabPage();
            this.reportViewerDoctor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iconButtonSearchDoctor = new FontAwesome.Sharp.IconButton();
            this.comboBoxFilterDoctor = new System.Windows.Forms.ComboBox();
            this.textBoxSearchDoctor = new System.Windows.Forms.TextBox();
            this.tabPageAnesthetist = new System.Windows.Forms.TabPage();
            this.reportViewerAnesthetist = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iconButtonSearchAnesthetist = new FontAwesome.Sharp.IconButton();
            this.comboBoxAnesthetist = new System.Windows.Forms.ComboBox();
            this.textBoxAnesthethist = new System.Windows.Forms.TextBox();
            this.tabPageAssistant = new System.Windows.Forms.TabPage();
            this.reportViewerAssistant = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iconButtonAssistant = new FontAwesome.Sharp.IconButton();
            this.comboBoxAssistant = new System.Windows.Forms.ComboBox();
            this.textBoxAssistant = new System.Windows.Forms.TextBox();
            this.tabPagePacient = new System.Windows.Forms.TabPage();
            this.iconButtonPatient = new FontAwesome.Sharp.IconButton();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.textBoxPacient = new System.Windows.Forms.TextBox();
            this.reportViewerPacientDiagnosis = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPageDoctor.SuspendLayout();
            this.tabPageAnesthetist.SuspendLayout();
            this.tabPageAssistant.SuspendLayout();
            this.tabPagePacient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDoctor);
            this.tabControl1.Controls.Add(this.tabPageAnesthetist);
            this.tabControl1.Controls.Add(this.tabPageAssistant);
            this.tabControl1.Controls.Add(this.tabPagePacient);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1246, 884);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDoctor
            // 
            this.tabPageDoctor.Controls.Add(this.reportViewerDoctor);
            this.tabPageDoctor.Controls.Add(this.iconButtonSearchDoctor);
            this.tabPageDoctor.Controls.Add(this.comboBoxFilterDoctor);
            this.tabPageDoctor.Controls.Add(this.textBoxSearchDoctor);
            this.tabPageDoctor.Location = new System.Drawing.Point(4, 22);
            this.tabPageDoctor.Name = "tabPageDoctor";
            this.tabPageDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoctor.Size = new System.Drawing.Size(1238, 858);
            this.tabPageDoctor.TabIndex = 0;
            this.tabPageDoctor.Text = "Buscar Doctor";
            this.tabPageDoctor.UseVisualStyleBackColor = true;
            // 
            // reportViewerDoctor
            // 
            this.reportViewerDoctor.Location = new System.Drawing.Point(27, 74);
            this.reportViewerDoctor.Name = "reportViewerDoctor";
            this.reportViewerDoctor.ServerReport.BearerToken = null;
            this.reportViewerDoctor.Size = new System.Drawing.Size(1190, 778);
            this.reportViewerDoctor.TabIndex = 3;
            // 
            // iconButtonSearchDoctor
            // 
            this.iconButtonSearchDoctor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSearchDoctor.IconColor = System.Drawing.Color.Black;
            this.iconButtonSearchDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearchDoctor.Location = new System.Drawing.Point(680, 26);
            this.iconButtonSearchDoctor.Name = "iconButtonSearchDoctor";
            this.iconButtonSearchDoctor.Size = new System.Drawing.Size(109, 32);
            this.iconButtonSearchDoctor.TabIndex = 2;
            this.iconButtonSearchDoctor.Text = "iconButton1";
            this.iconButtonSearchDoctor.UseVisualStyleBackColor = true;
            this.iconButtonSearchDoctor.Click += new System.EventHandler(this.iconButtonSearchDoctor_Click);
            // 
            // comboBoxFilterDoctor
            // 
            this.comboBoxFilterDoctor.FormattingEnabled = true;
            this.comboBoxFilterDoctor.Items.AddRange(new object[] {
            "DPI",
            "Nombre"});
            this.comboBoxFilterDoctor.Location = new System.Drawing.Point(539, 32);
            this.comboBoxFilterDoctor.Name = "comboBoxFilterDoctor";
            this.comboBoxFilterDoctor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterDoctor.TabIndex = 1;
            // 
            // textBoxSearchDoctor
            // 
            this.textBoxSearchDoctor.Location = new System.Drawing.Point(249, 33);
            this.textBoxSearchDoctor.Name = "textBoxSearchDoctor";
            this.textBoxSearchDoctor.Size = new System.Drawing.Size(275, 20);
            this.textBoxSearchDoctor.TabIndex = 0;
            // 
            // tabPageAnesthetist
            // 
            this.tabPageAnesthetist.Controls.Add(this.reportViewerAnesthetist);
            this.tabPageAnesthetist.Controls.Add(this.iconButtonSearchAnesthetist);
            this.tabPageAnesthetist.Controls.Add(this.comboBoxAnesthetist);
            this.tabPageAnesthetist.Controls.Add(this.textBoxAnesthethist);
            this.tabPageAnesthetist.Location = new System.Drawing.Point(4, 22);
            this.tabPageAnesthetist.Name = "tabPageAnesthetist";
            this.tabPageAnesthetist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnesthetist.Size = new System.Drawing.Size(1238, 858);
            this.tabPageAnesthetist.TabIndex = 1;
            this.tabPageAnesthetist.Text = "Buscar Anestesista";
            this.tabPageAnesthetist.UseVisualStyleBackColor = true;
            // 
            // reportViewerAnesthetist
            // 
            this.reportViewerAnesthetist.Location = new System.Drawing.Point(24, 64);
            this.reportViewerAnesthetist.Name = "reportViewerAnesthetist";
            this.reportViewerAnesthetist.ServerReport.BearerToken = null;
            this.reportViewerAnesthetist.Size = new System.Drawing.Size(1190, 778);
            this.reportViewerAnesthetist.TabIndex = 7;
            // 
            // iconButtonSearchAnesthetist
            // 
            this.iconButtonSearchAnesthetist.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSearchAnesthetist.IconColor = System.Drawing.Color.Black;
            this.iconButtonSearchAnesthetist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearchAnesthetist.Location = new System.Drawing.Point(677, 16);
            this.iconButtonSearchAnesthetist.Name = "iconButtonSearchAnesthetist";
            this.iconButtonSearchAnesthetist.Size = new System.Drawing.Size(109, 32);
            this.iconButtonSearchAnesthetist.TabIndex = 6;
            this.iconButtonSearchAnesthetist.Text = "iconButton2";
            this.iconButtonSearchAnesthetist.UseVisualStyleBackColor = true;
            this.iconButtonSearchAnesthetist.Click += new System.EventHandler(this.iconButtonSearchAnesthetist_Click);
            // 
            // comboBoxAnesthetist
            // 
            this.comboBoxAnesthetist.FormattingEnabled = true;
            this.comboBoxAnesthetist.Items.AddRange(new object[] {
            "DPI",
            "Nombre"});
            this.comboBoxAnesthetist.Location = new System.Drawing.Point(536, 22);
            this.comboBoxAnesthetist.Name = "comboBoxAnesthetist";
            this.comboBoxAnesthetist.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAnesthetist.TabIndex = 5;
            // 
            // textBoxAnesthethist
            // 
            this.textBoxAnesthethist.Location = new System.Drawing.Point(246, 23);
            this.textBoxAnesthethist.Name = "textBoxAnesthethist";
            this.textBoxAnesthethist.Size = new System.Drawing.Size(275, 20);
            this.textBoxAnesthethist.TabIndex = 4;
            // 
            // tabPageAssistant
            // 
            this.tabPageAssistant.Controls.Add(this.reportViewerAssistant);
            this.tabPageAssistant.Controls.Add(this.iconButtonAssistant);
            this.tabPageAssistant.Controls.Add(this.comboBoxAssistant);
            this.tabPageAssistant.Controls.Add(this.textBoxAssistant);
            this.tabPageAssistant.Location = new System.Drawing.Point(4, 22);
            this.tabPageAssistant.Name = "tabPageAssistant";
            this.tabPageAssistant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAssistant.Size = new System.Drawing.Size(1238, 858);
            this.tabPageAssistant.TabIndex = 2;
            this.tabPageAssistant.Text = "Buscar Asistente";
            this.tabPageAssistant.UseVisualStyleBackColor = true;
            // 
            // reportViewerAssistant
            // 
            this.reportViewerAssistant.Location = new System.Drawing.Point(24, 64);
            this.reportViewerAssistant.Name = "reportViewerAssistant";
            this.reportViewerAssistant.ServerReport.BearerToken = null;
            this.reportViewerAssistant.Size = new System.Drawing.Size(1190, 778);
            this.reportViewerAssistant.TabIndex = 7;
            // 
            // iconButtonAssistant
            // 
            this.iconButtonAssistant.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAssistant.IconColor = System.Drawing.Color.Black;
            this.iconButtonAssistant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAssistant.Location = new System.Drawing.Point(677, 16);
            this.iconButtonAssistant.Name = "iconButtonAssistant";
            this.iconButtonAssistant.Size = new System.Drawing.Size(109, 32);
            this.iconButtonAssistant.TabIndex = 6;
            this.iconButtonAssistant.Text = "iconButton3";
            this.iconButtonAssistant.UseVisualStyleBackColor = true;
            this.iconButtonAssistant.Click += new System.EventHandler(this.iconButtonAssistant_Click);
            // 
            // comboBoxAssistant
            // 
            this.comboBoxAssistant.FormattingEnabled = true;
            this.comboBoxAssistant.Items.AddRange(new object[] {
            "DPI",
            "Nombre"});
            this.comboBoxAssistant.Location = new System.Drawing.Point(536, 22);
            this.comboBoxAssistant.Name = "comboBoxAssistant";
            this.comboBoxAssistant.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAssistant.TabIndex = 5;
            // 
            // textBoxAssistant
            // 
            this.textBoxAssistant.Location = new System.Drawing.Point(246, 23);
            this.textBoxAssistant.Name = "textBoxAssistant";
            this.textBoxAssistant.Size = new System.Drawing.Size(275, 20);
            this.textBoxAssistant.TabIndex = 4;
            // 
            // tabPagePacient
            // 
            this.tabPagePacient.Controls.Add(this.iconButtonPatient);
            this.tabPagePacient.Controls.Add(this.comboBoxPatient);
            this.tabPagePacient.Controls.Add(this.textBoxPacient);
            this.tabPagePacient.Controls.Add(this.reportViewerPacientDiagnosis);
            this.tabPagePacient.Location = new System.Drawing.Point(4, 22);
            this.tabPagePacient.Name = "tabPagePacient";
            this.tabPagePacient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePacient.Size = new System.Drawing.Size(1238, 858);
            this.tabPagePacient.TabIndex = 3;
            this.tabPagePacient.Text = "Buscar Paciente";
            this.tabPagePacient.UseVisualStyleBackColor = true;
            // 
            // iconButtonPatient
            // 
            this.iconButtonPatient.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonPatient.IconColor = System.Drawing.Color.Black;
            this.iconButtonPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPatient.Location = new System.Drawing.Point(712, 46);
            this.iconButtonPatient.Name = "iconButtonPatient";
            this.iconButtonPatient.Size = new System.Drawing.Size(109, 32);
            this.iconButtonPatient.TabIndex = 22;
            this.iconButtonPatient.Text = "iconButton4";
            this.iconButtonPatient.UseVisualStyleBackColor = true;
            this.iconButtonPatient.Click += new System.EventHandler(this.iconButtonPatient_Click_2);
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Items.AddRange(new object[] {
            "No. Historia",
            "Nombre"});
            this.comboBoxPatient.Location = new System.Drawing.Point(571, 52);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPatient.TabIndex = 21;
            // 
            // textBoxPacient
            // 
            this.textBoxPacient.Location = new System.Drawing.Point(281, 53);
            this.textBoxPacient.Name = "textBoxPacient";
            this.textBoxPacient.Size = new System.Drawing.Size(275, 20);
            this.textBoxPacient.TabIndex = 20;
            // 
            // reportViewerPacientDiagnosis
            // 
            this.reportViewerPacientDiagnosis.Location = new System.Drawing.Point(23, 79);
            this.reportViewerPacientDiagnosis.Name = "reportViewerPacientDiagnosis";
            this.reportViewerPacientDiagnosis.ServerReport.BearerToken = null;
            this.reportViewerPacientDiagnosis.Size = new System.Drawing.Size(1192, 671);
            this.reportViewerPacientDiagnosis.TabIndex = 19;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 908);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDoctor.ResumeLayout(false);
            this.tabPageDoctor.PerformLayout();
            this.tabPageAnesthetist.ResumeLayout(false);
            this.tabPageAnesthetist.PerformLayout();
            this.tabPageAssistant.ResumeLayout(false);
            this.tabPageAssistant.PerformLayout();
            this.tabPagePacient.ResumeLayout(false);
            this.tabPagePacient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDoctor;
        private System.Windows.Forms.TabPage tabPageAnesthetist;
        private System.Windows.Forms.TabPage tabPageAssistant;
        private System.Windows.Forms.TabPage tabPagePacient;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDoctor;
        private FontAwesome.Sharp.IconButton iconButtonSearchDoctor;
        private System.Windows.Forms.ComboBox comboBoxFilterDoctor;
        private System.Windows.Forms.TextBox textBoxSearchDoctor;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAnesthetist;
        private FontAwesome.Sharp.IconButton iconButtonSearchAnesthetist;
        private System.Windows.Forms.ComboBox comboBoxAnesthetist;
        private System.Windows.Forms.TextBox textBoxAnesthethist;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAssistant;
        private FontAwesome.Sharp.IconButton iconButtonAssistant;
        private System.Windows.Forms.ComboBox comboBoxAssistant;
        private System.Windows.Forms.TextBox textBoxAssistant;
        private FontAwesome.Sharp.IconButton iconButtonPatient;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.TextBox textBoxPacient;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPacientDiagnosis;
    }
}