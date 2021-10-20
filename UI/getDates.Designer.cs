
namespace UI
{
    partial class getDates
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
            this.dateTimePickerFirstDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSecondDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonDates = new FontAwesome.Sharp.IconButton();
            this.labelService = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerFirstDate
            // 
            this.dateTimePickerFirstDate.Location = new System.Drawing.Point(85, 108);
            this.dateTimePickerFirstDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFirstDate.Name = "dateTimePickerFirstDate";
            this.dateTimePickerFirstDate.Size = new System.Drawing.Size(265, 26);
            this.dateTimePickerFirstDate.TabIndex = 0;
            // 
            // dateTimePickerSecondDate
            // 
            this.dateTimePickerSecondDate.Location = new System.Drawing.Point(405, 108);
            this.dateTimePickerSecondDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerSecondDate.Name = "dateTimePickerSecondDate";
            this.dateTimePickerSecondDate.Size = new System.Drawing.Size(265, 26);
            this.dateTimePickerSecondDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "A:";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(11, 229);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(119, 40);
            this.iconButton1.TabIndex = 36;
            this.iconButton1.Text = "Cancelar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // iconButtonDates
            // 
            this.iconButtonDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDates.BackColor = System.Drawing.Color.White;
            this.iconButtonDates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonDates.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonDates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDates.ForeColor = System.Drawing.Color.Black;
            this.iconButtonDates.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButtonDates.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonDates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDates.IconSize = 30;
            this.iconButtonDates.Location = new System.Drawing.Point(296, 162);
            this.iconButtonDates.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonDates.Name = "iconButtonDates";
            this.iconButtonDates.Size = new System.Drawing.Size(157, 57);
            this.iconButtonDates.TabIndex = 37;
            this.iconButtonDates.Text = "Generar";
            this.iconButtonDates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDates.UseVisualStyleBackColor = false;
            this.iconButtonDates.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelService.Location = new System.Drawing.Point(304, 25);
            this.labelService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(115, 31);
            this.labelService.TabIndex = 38;
            this.labelService.Text = "services";
            // 
            // getDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 280);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.iconButtonDates);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerSecondDate);
            this.Controls.Add(this.dateTimePickerFirstDate);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "getDates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "getDates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFirstDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerSecondDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButtonDates;
        private System.Windows.Forms.Label labelService;
    }
}