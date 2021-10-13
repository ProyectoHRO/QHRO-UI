
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
            this.comboBoxAnesthetist = new System.Windows.Forms.ComboBox();
            this.textBoxAnesthethist = new System.Windows.Forms.TextBox();
            this.tabPageAssistant = new System.Windows.Forms.TabPage();
            this.reportViewerAssistant = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxAssistant = new System.Windows.Forms.ComboBox();
            this.textBoxAssistant = new System.Windows.Forms.TextBox();
            this.tabPagePacient = new System.Windows.Forms.TabPage();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.textBoxPacient = new System.Windows.Forms.TextBox();
            this.reportViewerPacientDiagnosis = new Microsoft.Reporting.WinForms.ReportViewer();
            this.iconButtonSearchAnesthetist = new FontAwesome.Sharp.IconButton();
            this.iconButtonAssistant = new FontAwesome.Sharp.IconButton();
            this.iconButtonPatient = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageDoctor.SuspendLayout();
            this.tabPageAnesthetist.SuspendLayout();
            this.tabPageAssistant.SuspendLayout();
            this.tabPagePacient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageDoctor);
            this.tabControl1.Controls.Add(this.tabPageAnesthetist);
            this.tabControl1.Controls.Add(this.tabPageAssistant);
            this.tabControl1.Controls.Add(this.tabPagePacient);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1246, 884);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDoctor
            // 
            this.tabPageDoctor.Controls.Add(this.label1);
            this.tabPageDoctor.Controls.Add(this.reportViewerDoctor);
            this.tabPageDoctor.Controls.Add(this.iconButtonSearchDoctor);
            this.tabPageDoctor.Controls.Add(this.comboBoxFilterDoctor);
            this.tabPageDoctor.Controls.Add(this.textBoxSearchDoctor);
            this.tabPageDoctor.Location = new System.Drawing.Point(4, 29);
            this.tabPageDoctor.Name = "tabPageDoctor";
            this.tabPageDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoctor.Size = new System.Drawing.Size(1238, 851);
            this.tabPageDoctor.TabIndex = 0;
            this.tabPageDoctor.Text = "Buscar Doctor";
            this.tabPageDoctor.UseVisualStyleBackColor = true;
            // 
            // reportViewerDoctor
            // 
            this.reportViewerDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerDoctor.Location = new System.Drawing.Point(6, 74);
            this.reportViewerDoctor.Name = "reportViewerDoctor";
            this.reportViewerDoctor.ServerReport.BearerToken = null;
            this.reportViewerDoctor.Size = new System.Drawing.Size(1226, 771);
            this.reportViewerDoctor.TabIndex = 3;
            // 
            // iconButtonSearchDoctor
            // 
            this.iconButtonSearchDoctor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSearchDoctor.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButtonSearchDoctor.IconColor = System.Drawing.Color.Black;
            this.iconButtonSearchDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearchDoctor.IconSize = 32;
            this.iconButtonSearchDoctor.Location = new System.Drawing.Point(787, 23);
            this.iconButtonSearchDoctor.Name = "iconButtonSearchDoctor";
            this.iconButtonSearchDoctor.Size = new System.Drawing.Size(134, 43);
            this.iconButtonSearchDoctor.TabIndex = 2;
            this.iconButtonSearchDoctor.Text = "Generar";
            this.iconButtonSearchDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSearchDoctor.UseVisualStyleBackColor = true;
            this.iconButtonSearchDoctor.Click += new System.EventHandler(this.iconButtonSearchDoctor_Click);
            // 
            // comboBoxFilterDoctor
            // 
            this.comboBoxFilterDoctor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxFilterDoctor.FormattingEnabled = true;
            this.comboBoxFilterDoctor.Items.AddRange(new object[] {
            "DPI",
            "Nombre"});
            this.comboBoxFilterDoctor.Location = new System.Drawing.Point(647, 31);
            this.comboBoxFilterDoctor.Name = "comboBoxFilterDoctor";
            this.comboBoxFilterDoctor.Size = new System.Drawing.Size(121, 28);
            this.comboBoxFilterDoctor.TabIndex = 1;
            // 
            // textBoxSearchDoctor
            // 
            this.textBoxSearchDoctor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSearchDoctor.Location = new System.Drawing.Point(366, 33);
            this.textBoxSearchDoctor.Name = "textBoxSearchDoctor";
            this.textBoxSearchDoctor.Size = new System.Drawing.Size(275, 26);
            this.textBoxSearchDoctor.TabIndex = 0;
            // 
            // tabPageAnesthetist
            // 
            this.tabPageAnesthetist.Controls.Add(this.label2);
            this.tabPageAnesthetist.Controls.Add(this.iconButtonSearchAnesthetist);
            this.tabPageAnesthetist.Controls.Add(this.reportViewerAnesthetist);
            this.tabPageAnesthetist.Controls.Add(this.comboBoxAnesthetist);
            this.tabPageAnesthetist.Controls.Add(this.textBoxAnesthethist);
            this.tabPageAnesthetist.Location = new System.Drawing.Point(4, 29);
            this.tabPageAnesthetist.Name = "tabPageAnesthetist";
            this.tabPageAnesthetist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnesthetist.Size = new System.Drawing.Size(1238, 851);
            this.tabPageAnesthetist.TabIndex = 1;
            this.tabPageAnesthetist.Text = "Buscar Anestesista";
            this.tabPageAnesthetist.UseVisualStyleBackColor = true;
            // 
            // reportViewerAnesthetist
            // 
            this.reportViewerAnesthetist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerAnesthetist.Location = new System.Drawing.Point(6, 74);
            this.reportViewerAnesthetist.Name = "reportViewerAnesthetist";
            this.reportViewerAnesthetist.ServerReport.BearerToken = null;
            this.reportViewerAnesthetist.Size = new System.Drawing.Size(1226, 771);
            this.reportViewerAnesthetist.TabIndex = 7;
            // 
            // comboBoxAnesthetist
            // 
            this.comboBoxAnesthetist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxAnesthetist.FormattingEnabled = true;
            this.comboBoxAnesthetist.Items.AddRange(new object[] {
            "DPI",
            "Nombre"});
            this.comboBoxAnesthetist.Location = new System.Drawing.Point(647, 31);
            this.comboBoxAnesthetist.Name = "comboBoxAnesthetist";
            this.comboBoxAnesthetist.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAnesthetist.TabIndex = 5;
            // 
            // textBoxAnesthethist
            // 
            this.textBoxAnesthethist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAnesthethist.Location = new System.Drawing.Point(366, 33);
            this.textBoxAnesthethist.Name = "textBoxAnesthethist";
            this.textBoxAnesthethist.Size = new System.Drawing.Size(275, 26);
            this.textBoxAnesthethist.TabIndex = 4;
            // 
            // tabPageAssistant
            // 
            this.tabPageAssistant.Controls.Add(this.label3);
            this.tabPageAssistant.Controls.Add(this.iconButtonAssistant);
            this.tabPageAssistant.Controls.Add(this.reportViewerAssistant);
            this.tabPageAssistant.Controls.Add(this.comboBoxAssistant);
            this.tabPageAssistant.Controls.Add(this.textBoxAssistant);
            this.tabPageAssistant.Location = new System.Drawing.Point(4, 29);
            this.tabPageAssistant.Name = "tabPageAssistant";
            this.tabPageAssistant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAssistant.Size = new System.Drawing.Size(1238, 851);
            this.tabPageAssistant.TabIndex = 2;
            this.tabPageAssistant.Text = "Buscar Asistente";
            this.tabPageAssistant.UseVisualStyleBackColor = true;
            // 
            // reportViewerAssistant
            // 
            this.reportViewerAssistant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerAssistant.Location = new System.Drawing.Point(6, 74);
            this.reportViewerAssistant.Name = "reportViewerAssistant";
            this.reportViewerAssistant.ServerReport.BearerToken = null;
            this.reportViewerAssistant.Size = new System.Drawing.Size(1226, 771);
            this.reportViewerAssistant.TabIndex = 7;
            // 
            // comboBoxAssistant
            // 
            this.comboBoxAssistant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxAssistant.FormattingEnabled = true;
            this.comboBoxAssistant.Items.AddRange(new object[] {
            "DPI",
            "Nombre"});
            this.comboBoxAssistant.Location = new System.Drawing.Point(647, 31);
            this.comboBoxAssistant.Name = "comboBoxAssistant";
            this.comboBoxAssistant.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAssistant.TabIndex = 5;
            // 
            // textBoxAssistant
            // 
            this.textBoxAssistant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAssistant.Location = new System.Drawing.Point(366, 33);
            this.textBoxAssistant.Name = "textBoxAssistant";
            this.textBoxAssistant.Size = new System.Drawing.Size(275, 26);
            this.textBoxAssistant.TabIndex = 4;
            // 
            // tabPagePacient
            // 
            this.tabPagePacient.Controls.Add(this.label4);
            this.tabPagePacient.Controls.Add(this.iconButtonPatient);
            this.tabPagePacient.Controls.Add(this.comboBoxPatient);
            this.tabPagePacient.Controls.Add(this.textBoxPacient);
            this.tabPagePacient.Controls.Add(this.reportViewerPacientDiagnosis);
            this.tabPagePacient.Location = new System.Drawing.Point(4, 29);
            this.tabPagePacient.Name = "tabPagePacient";
            this.tabPagePacient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePacient.Size = new System.Drawing.Size(1238, 851);
            this.tabPagePacient.TabIndex = 3;
            this.tabPagePacient.Text = "Buscar Paciente";
            this.tabPagePacient.UseVisualStyleBackColor = true;
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Items.AddRange(new object[] {
            "No. Historia",
            "Nombre"});
            this.comboBoxPatient.Location = new System.Drawing.Point(647, 31);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPatient.TabIndex = 21;
            // 
            // textBoxPacient
            // 
            this.textBoxPacient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPacient.Location = new System.Drawing.Point(366, 33);
            this.textBoxPacient.Name = "textBoxPacient";
            this.textBoxPacient.Size = new System.Drawing.Size(275, 26);
            this.textBoxPacient.TabIndex = 20;
            // 
            // reportViewerPacientDiagnosis
            // 
            this.reportViewerPacientDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerPacientDiagnosis.Location = new System.Drawing.Point(6, 74);
            this.reportViewerPacientDiagnosis.Name = "reportViewerPacientDiagnosis";
            this.reportViewerPacientDiagnosis.ServerReport.BearerToken = null;
            this.reportViewerPacientDiagnosis.Size = new System.Drawing.Size(1226, 771);
            this.reportViewerPacientDiagnosis.TabIndex = 19;
            this.reportViewerPacientDiagnosis.Load += new System.EventHandler(this.reportViewerPacientDiagnosis_Load);
            // 
            // iconButtonSearchAnesthetist
            // 
            this.iconButtonSearchAnesthetist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSearchAnesthetist.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButtonSearchAnesthetist.IconColor = System.Drawing.Color.Black;
            this.iconButtonSearchAnesthetist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearchAnesthetist.IconSize = 32;
            this.iconButtonSearchAnesthetist.Location = new System.Drawing.Point(787, 23);
            this.iconButtonSearchAnesthetist.Name = "iconButtonSearchAnesthetist";
            this.iconButtonSearchAnesthetist.Size = new System.Drawing.Size(134, 43);
            this.iconButtonSearchAnesthetist.TabIndex = 8;
            this.iconButtonSearchAnesthetist.Text = "Generar";
            this.iconButtonSearchAnesthetist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSearchAnesthetist.UseVisualStyleBackColor = true;
            this.iconButtonSearchAnesthetist.Click += new System.EventHandler(this.iconButtonSearchAnesthetist_Click);
            // 
            // iconButtonAssistant
            // 
            this.iconButtonAssistant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonAssistant.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButtonAssistant.IconColor = System.Drawing.Color.Black;
            this.iconButtonAssistant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAssistant.IconSize = 32;
            this.iconButtonAssistant.Location = new System.Drawing.Point(787, 23);
            this.iconButtonAssistant.Name = "iconButtonAssistant";
            this.iconButtonAssistant.Size = new System.Drawing.Size(134, 43);
            this.iconButtonAssistant.TabIndex = 9;
            this.iconButtonAssistant.Text = "Generar";
            this.iconButtonAssistant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAssistant.UseVisualStyleBackColor = true;
            this.iconButtonAssistant.Click += new System.EventHandler(this.iconButtonAssistant_Click);
            // 
            // iconButtonPatient
            // 
            this.iconButtonPatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonPatient.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButtonPatient.IconColor = System.Drawing.Color.Black;
            this.iconButtonPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPatient.IconSize = 32;
            this.iconButtonPatient.Location = new System.Drawing.Point(787, 23);
            this.iconButtonPatient.Name = "iconButtonPatient";
            this.iconButtonPatient.Size = new System.Drawing.Size(134, 43);
            this.iconButtonPatient.TabIndex = 23;
            this.iconButtonPatient.Text = "Generar";
            this.iconButtonPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPatient.UseVisualStyleBackColor = true;
            this.iconButtonPatient.Click += new System.EventHandler(this.iconButtonPatient_Click_2);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Buscar:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Buscar:";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 947);
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
        private System.Windows.Forms.ComboBox comboBoxAnesthetist;
        private System.Windows.Forms.TextBox textBoxAnesthethist;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAssistant;
        private System.Windows.Forms.ComboBox comboBoxAssistant;
        private System.Windows.Forms.TextBox textBoxAssistant;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.TextBox textBoxPacient;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPacientDiagnosis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButtonSearchAnesthetist;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButtonAssistant;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButtonPatient;
    }
}