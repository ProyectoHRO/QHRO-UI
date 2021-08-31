
namespace UI
{
    partial class Assistant
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textSecondName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textThirdName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textFirstLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textSecondLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.buttonList = new FontAwesome.Sharp.IconButton();
            this.buttonUpdate = new FontAwesome.Sharp.IconButton();
            this.buttonSave = new FontAwesome.Sharp.IconButton();
            this.buttonNew = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textCui = new System.Windows.Forms.TextBox();
            this.comboTypeAssistant = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.comboTypeAssistant);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textCui);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textSecondLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textFirstLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textThirdName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textSecondName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textFirstName);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(37, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 212);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primer Nombre";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(9, 46);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(159, 20);
            this.textFirstName.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 434);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1145, 363);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segundo Nombre";
            // 
            // textSecondName
            // 
            this.textSecondName.Location = new System.Drawing.Point(188, 46);
            this.textSecondName.Name = "textSecondName";
            this.textSecondName.Size = new System.Drawing.Size(159, 20);
            this.textSecondName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tercer Nombre";
            // 
            // textThirdName
            // 
            this.textThirdName.Location = new System.Drawing.Point(365, 46);
            this.textThirdName.Name = "textThirdName";
            this.textThirdName.Size = new System.Drawing.Size(159, 20);
            this.textThirdName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Primer Apellido";
            // 
            // textFirstLastName
            // 
            this.textFirstLastName.Location = new System.Drawing.Point(539, 46);
            this.textFirstLastName.Name = "textFirstLastName";
            this.textFirstLastName.Size = new System.Drawing.Size(159, 20);
            this.textFirstLastName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Segundo Apellido";
            // 
            // textSecondLastName
            // 
            this.textSecondLastName.Location = new System.Drawing.Point(713, 46);
            this.textSecondLastName.Name = "textSecondLastName";
            this.textSecondLastName.Size = new System.Drawing.Size(159, 20);
            this.textSecondLastName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Correo";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(9, 97);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(159, 20);
            this.textEmail.TabIndex = 10;
            // 
            // buttonList
            // 
            this.buttonList.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonList.IconColor = System.Drawing.Color.Black;
            this.buttonList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonList.Location = new System.Drawing.Point(849, 313);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(135, 71);
            this.buttonList.TabIndex = 9;
            this.buttonList.Text = "Listar";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonUpdate.IconColor = System.Drawing.Color.Black;
            this.buttonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonUpdate.Location = new System.Drawing.Point(639, 313);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(135, 71);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Editar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonSave.IconColor = System.Drawing.Color.Black;
            this.buttonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSave.Location = new System.Drawing.Point(437, 313);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(135, 71);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonNew.IconColor = System.Drawing.Color.Black;
            this.buttonNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonNew.Location = new System.Drawing.Point(249, 313);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(135, 71);
            this.buttonNew.TabIndex = 12;
            this.buttonNew.Text = "Nuevo";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefono";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(188, 97);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(159, 20);
            this.textPhone.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(538, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tipo Asistente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cui";
            // 
            // textCui
            // 
            this.textCui.Location = new System.Drawing.Point(365, 97);
            this.textCui.Name = "textCui";
            this.textCui.Size = new System.Drawing.Size(159, 20);
            this.textCui.TabIndex = 15;
            // 
            // comboTypeAssistant
            // 
            this.comboTypeAssistant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypeAssistant.FormattingEnabled = true;
            this.comboTypeAssistant.Location = new System.Drawing.Point(541, 97);
            this.comboTypeAssistant.Name = "comboTypeAssistant";
            this.comboTypeAssistant.Size = new System.Drawing.Size(157, 21);
            this.comboTypeAssistant.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboStatus);
            this.groupBox2.Location = new System.Drawing.Point(869, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            this.groupBox2.Visible = false;
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.comboStatus.Location = new System.Drawing.Point(23, 45);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(157, 21);
            this.comboStatus.TabIndex = 19;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(9, 193);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 13);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "label10";
            this.labelID.Visible = false;
            // 
            // Assistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 809);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Assistant";
            this.Text = "Assistant";
            this.Load += new System.EventHandler(this.Assistant_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSecondLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFirstLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textThirdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSecondName;
        private FontAwesome.Sharp.IconButton buttonList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.ComboBox comboTypeAssistant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textCui;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPhone;
        private FontAwesome.Sharp.IconButton buttonUpdate;
        private FontAwesome.Sharp.IconButton buttonSave;
        private FontAwesome.Sharp.IconButton buttonNew;
        private System.Windows.Forms.Label labelID;
    }
}