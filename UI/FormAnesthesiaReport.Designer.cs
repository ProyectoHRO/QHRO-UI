
namespace UI
{
    partial class FormAnesthesiaReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.iconButtonDiff = new FontAwesome.Sharp.IconButton();
            this.reportViewerDiff = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePickerDiff = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(686, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Anestesias";
            // 
            // iconButtonDiff
            // 
            this.iconButtonDiff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonDiff.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonDiff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonDiff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDiff.ForeColor = System.Drawing.Color.Black;
            this.iconButtonDiff.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButtonDiff.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonDiff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDiff.IconSize = 32;
            this.iconButtonDiff.Location = new System.Drawing.Point(690, 84);
            this.iconButtonDiff.Name = "iconButtonDiff";
            this.iconButtonDiff.Size = new System.Drawing.Size(134, 43);
            this.iconButtonDiff.TabIndex = 29;
            this.iconButtonDiff.Text = "Generar";
            this.iconButtonDiff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDiff.UseVisualStyleBackColor = true;
            // 
            // reportViewerDiff
            // 
            this.reportViewerDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerDiff.Location = new System.Drawing.Point(22, 136);
            this.reportViewerDiff.Name = "reportViewerDiff";
            this.reportViewerDiff.ServerReport.BearerToken = null;
            this.reportViewerDiff.Size = new System.Drawing.Size(1242, 771);
            this.reportViewerDiff.TabIndex = 28;
            // 
            // dateTimePickerDiff
            // 
            this.dateTimePickerDiff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerDiff.Location = new System.Drawing.Point(403, 90);
            this.dateTimePickerDiff.Name = "dateTimePickerDiff";
            this.dateTimePickerDiff.Size = new System.Drawing.Size(265, 26);
            this.dateTimePickerDiff.TabIndex = 27;
            // 
            // FormAnesthesiaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1286, 947);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconButtonDiff);
            this.Controls.Add(this.reportViewerDiff);
            this.Controls.Add(this.dateTimePickerDiff);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAnesthesiaReport";
            this.Text = "FormAnesthesiaReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButtonDiff;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDiff;
        private System.Windows.Forms.DateTimePicker dateTimePickerDiff;
    }
}