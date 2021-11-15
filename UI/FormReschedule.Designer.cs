
namespace UI
{
    partial class FormReschedule
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerNewDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxHour = new System.Windows.Forms.ComboBox();
            this.comboBoxMin = new System.Windows.Forms.ComboBox();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOperatingRooms = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconButtonCancel = new FontAwesome.Sharp.IconButton();
            this.iconButtonContinue = new FontAwesome.Sharp.IconButton();
            this.labelchangeHour = new System.Windows.Forms.Label();
            this.labelchangeRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reprogramar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            this.label1.UseWaitCursor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(514, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(403, 26);
            this.textBoxName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paciente";
            // 
            // dateTimePickerNewDate
            // 
            this.dateTimePickerNewDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNewDate.Location = new System.Drawing.Point(514, 118);
            this.dateTimePickerNewDate.Name = "dateTimePickerNewDate";
            this.dateTimePickerNewDate.Size = new System.Drawing.Size(403, 26);
            this.dateTimePickerNewDate.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nueva fecha";
            // 
            // comboBoxHour
            // 
            this.comboBoxHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHour.Enabled = false;
            this.comboBoxHour.FormattingEnabled = true;
            this.comboBoxHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxHour.Location = new System.Drawing.Point(514, 181);
            this.comboBoxHour.Name = "comboBoxHour";
            this.comboBoxHour.Size = new System.Drawing.Size(50, 21);
            this.comboBoxHour.TabIndex = 43;
            // 
            // comboBoxMin
            // 
            this.comboBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMin.Enabled = false;
            this.comboBoxMin.FormattingEnabled = true;
            this.comboBoxMin.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxMin.Location = new System.Drawing.Point(570, 181);
            this.comboBoxMin.Name = "comboBoxMin";
            this.comboBoxMin.Size = new System.Drawing.Size(45, 21);
            this.comboBoxMin.TabIndex = 44;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.Enabled = false;
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "A.M",
            "P.M"});
            this.comboBoxTime.Location = new System.Drawing.Point(621, 181);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(50, 21);
            this.comboBoxTime.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nueva hora";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxOperatingRooms
            // 
            this.comboBoxOperatingRooms.Enabled = false;
            this.comboBoxOperatingRooms.FormattingEnabled = true;
            this.comboBoxOperatingRooms.Location = new System.Drawing.Point(514, 246);
            this.comboBoxOperatingRooms.Name = "comboBoxOperatingRooms";
            this.comboBoxOperatingRooms.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOperatingRooms.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Numero de quirofano";
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
            this.iconButtonCancel.Location = new System.Drawing.Point(61, 321);
            this.iconButtonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonCancel.Name = "iconButtonCancel";
            this.iconButtonCancel.Size = new System.Drawing.Size(119, 40);
            this.iconButtonCancel.TabIndex = 48;
            this.iconButtonCancel.Text = "Cancelar";
            this.iconButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCancel.UseVisualStyleBackColor = false;
            this.iconButtonCancel.Click += new System.EventHandler(this.iconButtonCancel_Click);
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
            this.iconButtonContinue.Location = new System.Drawing.Point(1009, 321);
            this.iconButtonContinue.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonContinue.Name = "iconButtonContinue";
            this.iconButtonContinue.Size = new System.Drawing.Size(119, 40);
            this.iconButtonContinue.TabIndex = 47;
            this.iconButtonContinue.Text = "Continuar";
            this.iconButtonContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonContinue.UseVisualStyleBackColor = false;
            this.iconButtonContinue.Click += new System.EventHandler(this.iconButtonContinue_Click);
            // 
            // labelchangeHour
            // 
            this.labelchangeHour.AutoSize = true;
            this.labelchangeHour.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelchangeHour.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelchangeHour.Location = new System.Drawing.Point(712, 179);
            this.labelchangeHour.Name = "labelchangeHour";
            this.labelchangeHour.Size = new System.Drawing.Size(88, 20);
            this.labelchangeHour.TabIndex = 49;
            this.labelchangeHour.Text = "Cambiar hora";
            this.labelchangeHour.Click += new System.EventHandler(this.labelchangeHour_Click);
            // 
            // labelchangeRoom
            // 
            this.labelchangeRoom.AutoSize = true;
            this.labelchangeRoom.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelchangeRoom.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelchangeRoom.Location = new System.Drawing.Point(712, 247);
            this.labelchangeRoom.Name = "labelchangeRoom";
            this.labelchangeRoom.Size = new System.Drawing.Size(117, 20);
            this.labelchangeRoom.TabIndex = 50;
            this.labelchangeRoom.Text = "Cambiar quirófano";
            this.labelchangeRoom.Click += new System.EventHandler(this.labelchangeRoom_Click);
            // 
            // FormReschedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 385);
            this.Controls.Add(this.labelchangeRoom);
            this.Controls.Add(this.labelchangeHour);
            this.Controls.Add(this.iconButtonCancel);
            this.Controls.Add(this.iconButtonContinue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxOperatingRooms);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerNewDate);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReschedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReschedule";
            this.Load += new System.EventHandler(this.FormReschedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxHour;
        private System.Windows.Forms.ComboBox comboBoxMin;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOperatingRooms;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButtonContinue;
        private FontAwesome.Sharp.IconButton iconButtonCancel;
        private System.Windows.Forms.Label labelchangeHour;
        private System.Windows.Forms.Label labelchangeRoom;
    }
}