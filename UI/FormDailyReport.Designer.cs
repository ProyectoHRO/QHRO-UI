
namespace UI
{
    partial class FormDailyReport
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewerDailies = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePickerReport = new System.Windows.Forms.DateTimePicker();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 923);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewerDailies);
            this.tabPage1.Controls.Add(this.dateTimePickerReport);
            this.tabPage1.Controls.Add(this.iconButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1254, 897);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operaciones Realizadas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1254, 897);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diferidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewerDailies
            // 
            this.reportViewerDailies.Location = new System.Drawing.Point(6, 55);
            this.reportViewerDailies.Name = "reportViewerDailies";
            this.reportViewerDailies.ServerReport.BearerToken = null;
            this.reportViewerDailies.Size = new System.Drawing.Size(1252, 856);
            this.reportViewerDailies.TabIndex = 6;
            // 
            // dateTimePickerReport
            // 
            this.dateTimePickerReport.Location = new System.Drawing.Point(371, 19);
            this.dateTimePickerReport.Name = "dateTimePickerReport";
            this.dateTimePickerReport.Size = new System.Drawing.Size(265, 20);
            this.dateTimePickerReport.TabIndex = 5;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(687, 19);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // FormDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 947);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDailyReport";
            this.Text = "FormDailyReport";
            this.Load += new System.EventHandler(this.FormDailyReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDailies;
        private System.Windows.Forms.DateTimePicker dateTimePickerReport;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}