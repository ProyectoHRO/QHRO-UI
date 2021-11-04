
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
            this.iconButtonSurgeriesServicesBdates = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.reportViewerSurgeriesServiceBdates = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
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
            this.iconButtonSurgeriesServicesBdates.Location = new System.Drawing.Point(642, 25);
            this.iconButtonSurgeriesServicesBdates.Name = "iconButtonSurgeriesServicesBdates";
            this.iconButtonSurgeriesServicesBdates.Size = new System.Drawing.Size(191, 49);
            this.iconButtonSurgeriesServicesBdates.TabIndex = 9;
            this.iconButtonSurgeriesServicesBdates.Text = "Establecer fechas";
            this.iconButtonSurgeriesServicesBdates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSurgeriesServicesBdates.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Anestesia:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxServiceName.Location = new System.Drawing.Point(429, 36);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(207, 26);
            this.textBoxServiceName.TabIndex = 7;
            // 
            // reportViewerSurgeriesServiceBdates
            // 
            this.reportViewerSurgeriesServiceBdates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerSurgeriesServiceBdates.Location = new System.Drawing.Point(12, 80);
            this.reportViewerSurgeriesServiceBdates.Name = "reportViewerSurgeriesServiceBdates";
            this.reportViewerSurgeriesServiceBdates.ServerReport.BearerToken = null;
            this.reportViewerSurgeriesServiceBdates.Size = new System.Drawing.Size(1262, 842);
            this.reportViewerSurgeriesServiceBdates.TabIndex = 6;
            // 
            // FormAnesthesiaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1286, 947);
            this.Controls.Add(this.iconButtonSurgeriesServicesBdates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxServiceName);
            this.Controls.Add(this.reportViewerSurgeriesServiceBdates);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAnesthesiaReport";
            this.Text = "FormAnesthesiaReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonSurgeriesServicesBdates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSurgeriesServiceBdates;
    }
}