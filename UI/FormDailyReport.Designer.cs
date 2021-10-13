
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.reportViewerDailies = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePickerReport = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iconButtonDiff = new FontAwesome.Sharp.IconButton();
            this.reportViewerDiff = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePickerDiff = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 923);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.iconButton1);
            this.tabPage1.Controls.Add(this.reportViewerDailies);
            this.tabPage1.Controls.Add(this.dateTimePickerReport);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1254, 890);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operaciones Realizadas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(674, 32);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(134, 43);
            this.iconButton1.TabIndex = 24;
            this.iconButton1.Text = "Generar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // reportViewerDailies
            // 
            this.reportViewerDailies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerDailies.Location = new System.Drawing.Point(6, 113);
            this.reportViewerDailies.Name = "reportViewerDailies";
            this.reportViewerDailies.ServerReport.BearerToken = null;
            this.reportViewerDailies.Size = new System.Drawing.Size(1242, 771);
            this.reportViewerDailies.TabIndex = 6;
            // 
            // dateTimePickerReport
            // 
            this.dateTimePickerReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerReport.Location = new System.Drawing.Point(387, 38);
            this.dateTimePickerReport.Name = "dateTimePickerReport";
            this.dateTimePickerReport.Size = new System.Drawing.Size(265, 26);
            this.dateTimePickerReport.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.iconButtonDiff);
            this.tabPage2.Controls.Add(this.reportViewerDiff);
            this.tabPage2.Controls.Add(this.dateTimePickerDiff);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1254, 890);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diferidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // iconButtonDiff
            // 
            this.iconButtonDiff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonDiff.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButtonDiff.IconColor = System.Drawing.Color.Black;
            this.iconButtonDiff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDiff.IconSize = 32;
            this.iconButtonDiff.Location = new System.Drawing.Point(674, 32);
            this.iconButtonDiff.Name = "iconButtonDiff";
            this.iconButtonDiff.Size = new System.Drawing.Size(134, 43);
            this.iconButtonDiff.TabIndex = 25;
            this.iconButtonDiff.Text = "Generar";
            this.iconButtonDiff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDiff.UseVisualStyleBackColor = true;
            this.iconButtonDiff.Click += new System.EventHandler(this.iconButtonDiff_Click);
            // 
            // reportViewerDiff
            // 
            this.reportViewerDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerDiff.Location = new System.Drawing.Point(6, 113);
            this.reportViewerDiff.Name = "reportViewerDiff";
            this.reportViewerDiff.ServerReport.BearerToken = null;
            this.reportViewerDiff.Size = new System.Drawing.Size(1242, 771);
            this.reportViewerDiff.TabIndex = 9;
            // 
            // dateTimePickerDiff
            // 
            this.dateTimePickerDiff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerDiff.Location = new System.Drawing.Point(387, 38);
            this.dateTimePickerDiff.Name = "dateTimePickerDiff";
            this.dateTimePickerDiff.Size = new System.Drawing.Size(265, 26);
            this.dateTimePickerDiff.TabIndex = 8;
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
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDailies;
        private System.Windows.Forms.DateTimePicker dateTimePickerReport;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDiff;
        private System.Windows.Forms.DateTimePicker dateTimePickerDiff;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButtonDiff;
    }
}