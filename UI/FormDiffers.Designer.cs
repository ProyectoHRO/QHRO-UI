
namespace UI
{
    partial class FormDiffers
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelDiff = new System.Windows.Forms.Label();
            this.textBoxDetail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.iconButtonContinue = new FontAwesome.Sharp.IconButton();
            this.iconButtonCancel = new FontAwesome.Sharp.IconButton();
            this.NewDate = new System.Windows.Forms.Label();
            this.dateTimePickerNewDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOperatingRooms = new System.Windows.Forms.ComboBox();
            this.labelNumberRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // labelDiff
            // 
            this.labelDiff.AutoSize = true;
            this.labelDiff.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiff.Location = new System.Drawing.Point(207, 138);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(49, 20);
            this.labelDiff.TabIndex = 1;
            this.labelDiff.Text = "Motivo";
            this.labelDiff.Visible = false;
            // 
            // textBoxDetail
            // 
            this.textBoxDetail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetail.Location = new System.Drawing.Point(274, 138);
            this.textBoxDetail.Multiline = true;
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.Size = new System.Drawing.Size(403, 150);
            this.textBoxDetail.TabIndex = 2;
            this.textBoxDetail.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Paciente";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(274, 106);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(403, 26);
            this.textBoxName.TabIndex = 4;
            // 
            // iconButtonContinue
            // 
            this.iconButtonContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonContinue.BackColor = System.Drawing.Color.White;
            this.iconButtonContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonContinue.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonContinue.ForeColor = System.Drawing.Color.Black;
            this.iconButtonContinue.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.iconButtonContinue.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonContinue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonContinue.IconSize = 30;
            this.iconButtonContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonContinue.Location = new System.Drawing.Point(1060, 373);
            this.iconButtonContinue.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonContinue.Name = "iconButtonContinue";
            this.iconButtonContinue.Size = new System.Drawing.Size(119, 40);
            this.iconButtonContinue.TabIndex = 35;
            this.iconButtonContinue.Text = "Continuar";
            this.iconButtonContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonContinue.UseVisualStyleBackColor = false;
            this.iconButtonContinue.Click += new System.EventHandler(this.iconButtonContinue_Click);
            // 
            // iconButtonCancel
            // 
            this.iconButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonCancel.BackColor = System.Drawing.Color.White;
            this.iconButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.iconButtonCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.iconButtonCancel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCancel.IconSize = 30;
            this.iconButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCancel.Location = new System.Drawing.Point(11, 373);
            this.iconButtonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonCancel.Name = "iconButtonCancel";
            this.iconButtonCancel.Size = new System.Drawing.Size(119, 40);
            this.iconButtonCancel.TabIndex = 36;
            this.iconButtonCancel.Text = "Cancelar";
            this.iconButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCancel.UseVisualStyleBackColor = false;
            this.iconButtonCancel.Click += new System.EventHandler(this.iconButtonCancel_Click);
            // 
            // NewDate
            // 
            this.NewDate.AutoSize = true;
            this.NewDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDate.Location = new System.Drawing.Point(185, 300);
            this.NewDate.Name = "NewDate";
            this.NewDate.Size = new System.Drawing.Size(83, 20);
            this.NewDate.TabIndex = 37;
            this.NewDate.Text = "Nueva fecha";
            this.NewDate.Visible = false;
            // 
            // dateTimePickerNewDate
            // 
            this.dateTimePickerNewDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNewDate.Location = new System.Drawing.Point(274, 300);
            this.dateTimePickerNewDate.Name = "dateTimePickerNewDate";
            this.dateTimePickerNewDate.Size = new System.Drawing.Size(403, 26);
            this.dateTimePickerNewDate.TabIndex = 38;
            this.dateTimePickerNewDate.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(274, 332);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(403, 26);
            this.dateTimePicker1.TabIndex = 40;
            this.dateTimePicker1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nueva hora";
            this.label4.Visible = false;
            // 
            // comboBoxOperatingRooms
            // 
            this.comboBoxOperatingRooms.FormattingEnabled = true;
            this.comboBoxOperatingRooms.Location = new System.Drawing.Point(873, 186);
            this.comboBoxOperatingRooms.Name = "comboBoxOperatingRooms";
            this.comboBoxOperatingRooms.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOperatingRooms.TabIndex = 41;
            this.comboBoxOperatingRooms.Visible = false;
            // 
            // labelNumberRoom
            // 
            this.labelNumberRoom.AutoSize = true;
            this.labelNumberRoom.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberRoom.Location = new System.Drawing.Point(732, 184);
            this.labelNumberRoom.Name = "labelNumberRoom";
            this.labelNumberRoom.Size = new System.Drawing.Size(135, 20);
            this.labelNumberRoom.TabIndex = 42;
            this.labelNumberRoom.Text = "Numero de quirofano";
            // 
            // FormDiffers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 424);
            this.Controls.Add(this.labelNumberRoom);
            this.Controls.Add(this.comboBoxOperatingRooms);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerNewDate);
            this.Controls.Add(this.NewDate);
            this.Controls.Add(this.iconButtonCancel);
            this.Controls.Add(this.iconButtonContinue);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDetail);
            this.Controls.Add(this.labelDiff);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiffers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDiffers";
            this.Load += new System.EventHandler(this.FormDiffers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDiff;
        private System.Windows.Forms.TextBox textBoxDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private FontAwesome.Sharp.IconButton iconButtonContinue;
        private FontAwesome.Sharp.IconButton iconButtonCancel;
        private System.Windows.Forms.Label NewDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOperatingRooms;
        private System.Windows.Forms.Label labelNumberRoom;
    }
}