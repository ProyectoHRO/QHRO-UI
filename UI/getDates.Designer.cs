
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
            this.iconButtonDates = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // dateTimePickerFirstDate
            // 
            this.dateTimePickerFirstDate.Location = new System.Drawing.Point(68, 77);
            this.dateTimePickerFirstDate.Name = "dateTimePickerFirstDate";
            this.dateTimePickerFirstDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFirstDate.TabIndex = 0;
            // 
            // dateTimePickerSecondDate
            // 
            this.dateTimePickerSecondDate.Location = new System.Drawing.Point(68, 128);
            this.dateTimePickerSecondDate.Name = "dateTimePickerSecondDate";
            this.dateTimePickerSecondDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSecondDate.TabIndex = 1;
            // 
            // iconButtonDates
            // 
            this.iconButtonDates.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonDates.IconColor = System.Drawing.Color.Black;
            this.iconButtonDates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDates.Location = new System.Drawing.Point(377, 119);
            this.iconButtonDates.Name = "iconButtonDates";
            this.iconButtonDates.Size = new System.Drawing.Size(75, 23);
            this.iconButtonDates.TabIndex = 2;
            this.iconButtonDates.Text = "iconButton1";
            this.iconButtonDates.UseVisualStyleBackColor = true;
            this.iconButtonDates.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // getDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButtonDates);
            this.Controls.Add(this.dateTimePickerSecondDate);
            this.Controls.Add(this.dateTimePickerFirstDate);
            this.Name = "getDates";
            this.Text = "getDates";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFirstDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerSecondDate;
        private FontAwesome.Sharp.IconButton iconButtonDates;
    }
}