
namespace UI
{
    partial class assignSurgery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxpatientData = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.labelhistoryNumber = new System.Windows.Forms.Label();
            this.labelsecondName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.labelfirstName = new System.Windows.Forms.Label();
            this.dateTimeSurgeryDate = new System.Windows.Forms.DateTimePicker();
            this.labelID = new System.Windows.Forms.Label();
            this.comboBoxSurgeryType = new System.Windows.Forms.ComboBox();
            this.comboBoxAnesthesiaType = new System.Windows.Forms.ComboBox();
            this.listViewAssistants = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxIds = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDoctorName = new System.Windows.Forms.TextBox();
            this.labelIdDoctor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAnestethistName = new System.Windows.Forms.TextBox();
            this.labelIdAnesthetist = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxOperatingRooms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.iconButtonConfirm = new FontAwesome.Sharp.IconButton();
            this.iconButtonDeleteAll = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddAssistant = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddAnesthetist = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddDoctor = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxpatientData.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(10, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(970, 159);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBoxpatientData
            // 
            this.groupBoxpatientData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxpatientData.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxpatientData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxpatientData.Location = new System.Drawing.Point(10, 180);
            this.groupBoxpatientData.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxpatientData.Name = "groupBoxpatientData";
            this.groupBoxpatientData.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxpatientData.Size = new System.Drawing.Size(518, 226);
            this.groupBoxpatientData.TabIndex = 26;
            this.groupBoxpatientData.TabStop = false;
            this.groupBoxpatientData.Text = "Datos del paciente";
            this.groupBoxpatientData.Enter += new System.EventHandler(this.groupBoxpatientData_Enter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.18349F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75841F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.65443F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelsecondName, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dateTimeSurgeryDate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelID, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxSurgeryType, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxAnesthesiaType, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 24);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(500, 193);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.labelhistoryNumber);
            this.panel1.Location = new System.Drawing.Point(2, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 32);
            this.panel1.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(20, 3);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 19);
            this.label22.TabIndex = 23;
            this.label22.Text = "*";
            // 
            // labelhistoryNumber
            // 
            this.labelhistoryNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelhistoryNumber.AutoSize = true;
            this.labelhistoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhistoryNumber.Location = new System.Drawing.Point(32, 6);
            this.labelhistoryNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelhistoryNumber.Name = "labelhistoryNumber";
            this.labelhistoryNumber.Size = new System.Drawing.Size(107, 20);
            this.labelhistoryNumber.TabIndex = 10;
            this.labelhistoryNumber.Text = "Fecha Cirugia";
            // 
            // labelsecondName
            // 
            this.labelsecondName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelsecondName.AutoSize = true;
            this.labelsecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsecondName.Location = new System.Drawing.Point(17, 150);
            this.labelsecondName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelsecondName.Name = "labelsecondName";
            this.labelsecondName.Size = new System.Drawing.Size(134, 20);
            this.labelsecondName.TabIndex = 2;
            this.labelsecondName.Text = "Tipo de anestesia";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.labelfirstName);
            this.panel2.Location = new System.Drawing.Point(2, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 32);
            this.panel2.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(20, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "*";
            // 
            // labelfirstName
            // 
            this.labelfirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelfirstName.AutoSize = true;
            this.labelfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfirstName.Location = new System.Drawing.Point(33, 7);
            this.labelfirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfirstName.Name = "labelfirstName";
            this.labelfirstName.Size = new System.Drawing.Size(111, 20);
            this.labelfirstName.TabIndex = 1;
            this.labelfirstName.Text = "Tipo de cirugia";
            // 
            // dateTimeSurgeryDate
            // 
            this.dateTimeSurgeryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSurgeryDate.Location = new System.Drawing.Point(156, 3);
            this.dateTimeSurgeryDate.Name = "dateTimeSurgeryDate";
            this.dateTimeSurgeryDate.Size = new System.Drawing.Size(197, 26);
            this.dateTimeSurgeryDate.TabIndex = 24;
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(358, 0);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(140, 20);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "label10";
            // 
            // comboBoxSurgeryType
            // 
            this.comboBoxSurgeryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSurgeryType.FormattingEnabled = true;
            this.comboBoxSurgeryType.Items.AddRange(new object[] {
            "Selectiva",
            "Emergencia"});
            this.comboBoxSurgeryType.Location = new System.Drawing.Point(156, 67);
            this.comboBoxSurgeryType.Name = "comboBoxSurgeryType";
            this.comboBoxSurgeryType.Size = new System.Drawing.Size(197, 28);
            this.comboBoxSurgeryType.TabIndex = 25;
            // 
            // comboBoxAnesthesiaType
            // 
            this.comboBoxAnesthesiaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnesthesiaType.FormattingEnabled = true;
            this.comboBoxAnesthesiaType.Items.AddRange(new object[] {
            "General",
            "Epidural"});
            this.comboBoxAnesthesiaType.Location = new System.Drawing.Point(156, 131);
            this.comboBoxAnesthesiaType.Name = "comboBoxAnesthesiaType";
            this.comboBoxAnesthesiaType.Size = new System.Drawing.Size(197, 28);
            this.comboBoxAnesthesiaType.TabIndex = 26;
            // 
            // listViewAssistants
            // 
            this.listViewAssistants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.type});
            this.listViewAssistants.HideSelection = false;
            this.listViewAssistants.Location = new System.Drawing.Point(112, 61);
            this.listViewAssistants.Name = "listViewAssistants";
            this.listViewAssistants.Size = new System.Drawing.Size(341, 194);
            this.listViewAssistants.TabIndex = 27;
            this.listViewAssistants.UseCompatibleStateImageBehavior = false;
            this.listViewAssistants.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Nombre";
            this.name.Width = 200;
            // 
            // type
            // 
            this.type.Text = "Tipo de Ayudante";
            this.type.Width = 200;
            // 
            // listBoxIds
            // 
            this.listBoxIds.FormattingEnabled = true;
            this.listBoxIds.Location = new System.Drawing.Point(48, 61);
            this.listBoxIds.Name = "listBoxIds";
            this.listBoxIds.Size = new System.Drawing.Size(47, 199);
            this.listBoxIds.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconButtonAddDoctor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxDoctorName);
            this.groupBox1.Controls.Add(this.labelIdDoctor);
            this.groupBox1.Location = new System.Drawing.Point(8, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 162);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Asignado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doctor Asignado:";
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.Location = new System.Drawing.Point(196, 77);
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.Size = new System.Drawing.Size(188, 20);
            this.textBoxDoctorName.TabIndex = 4;
            // 
            // labelIdDoctor
            // 
            this.labelIdDoctor.AutoSize = true;
            this.labelIdDoctor.Location = new System.Drawing.Point(32, 37);
            this.labelIdDoctor.Name = "labelIdDoctor";
            this.labelIdDoctor.Size = new System.Drawing.Size(65, 13);
            this.labelIdDoctor.TabIndex = 3;
            this.labelIdDoctor.Text = "LabelDoctor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.iconButtonAddAnesthetist);
            this.groupBox2.Location = new System.Drawing.Point(533, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 207);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anestesista Asignado";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.textBoxAnestethistName);
            this.groupBox5.Controls.Add(this.labelIdAnesthetist);
            this.groupBox5.Location = new System.Drawing.Point(6, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(441, 135);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anestesista Asignado:";
            // 
            // textBoxAnestethistName
            // 
            this.textBoxAnestethistName.Location = new System.Drawing.Point(187, 63);
            this.textBoxAnestethistName.Name = "textBoxAnestethistName";
            this.textBoxAnestethistName.Size = new System.Drawing.Size(188, 20);
            this.textBoxAnestethistName.TabIndex = 1;
            // 
            // labelIdAnesthetist
            // 
            this.labelIdAnesthetist.AutoSize = true;
            this.labelIdAnesthetist.Location = new System.Drawing.Point(23, 23);
            this.labelIdAnesthetist.Name = "labelIdAnesthetist";
            this.labelIdAnesthetist.Size = new System.Drawing.Size(85, 13);
            this.labelIdAnesthetist.TabIndex = 0;
            this.labelIdAnesthetist.Text = "LabelAnesthetist";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxOperatingRooms);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(8, 579);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 124);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quirofano asignado";
            // 
            // comboBoxOperatingRooms
            // 
            this.comboBoxOperatingRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperatingRooms.FormattingEnabled = true;
            this.comboBoxOperatingRooms.Items.AddRange(new object[] {
            "General",
            "Epidural"});
            this.comboBoxOperatingRooms.Location = new System.Drawing.Point(169, 63);
            this.comboBoxOperatingRooms.Name = "comboBoxOperatingRooms";
            this.comboBoxOperatingRooms.Size = new System.Drawing.Size(271, 21);
            this.comboBoxOperatingRooms.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione quirofano";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.iconButtonDeleteAll);
            this.groupBox4.Controls.Add(this.iconButtonAddAssistant);
            this.groupBox4.Controls.Add(this.listBoxIds);
            this.groupBox4.Controls.Add(this.listViewAssistants);
            this.groupBox4.Location = new System.Drawing.Point(527, 403);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(477, 300);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ayudantes Asignados";
            // 
            // iconButtonConfirm
            // 
            this.iconButtonConfirm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonConfirm.IconColor = System.Drawing.Color.Black;
            this.iconButtonConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonConfirm.Location = new System.Drawing.Point(855, 707);
            this.iconButtonConfirm.Name = "iconButtonConfirm";
            this.iconButtonConfirm.Size = new System.Drawing.Size(126, 33);
            this.iconButtonConfirm.TabIndex = 29;
            this.iconButtonConfirm.Text = "Confirmar Cirugia";
            this.iconButtonConfirm.UseVisualStyleBackColor = true;
            this.iconButtonConfirm.Click += new System.EventHandler(this.iconButtonConfirm_Click);
            // 
            // iconButtonDeleteAll
            // 
            this.iconButtonDeleteAll.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonDeleteAll.IconColor = System.Drawing.Color.Black;
            this.iconButtonDeleteAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDeleteAll.Location = new System.Drawing.Point(328, 261);
            this.iconButtonDeleteAll.Name = "iconButtonDeleteAll";
            this.iconButtonDeleteAll.Size = new System.Drawing.Size(126, 33);
            this.iconButtonDeleteAll.TabIndex = 32;
            this.iconButtonDeleteAll.Text = "Eliminar";
            this.iconButtonDeleteAll.UseVisualStyleBackColor = true;
            // 
            // iconButtonAddAssistant
            // 
            this.iconButtonAddAssistant.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAddAssistant.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddAssistant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddAssistant.Location = new System.Drawing.Point(113, 19);
            this.iconButtonAddAssistant.Name = "iconButtonAddAssistant";
            this.iconButtonAddAssistant.Size = new System.Drawing.Size(126, 33);
            this.iconButtonAddAssistant.TabIndex = 2;
            this.iconButtonAddAssistant.Text = "Agregar";
            this.iconButtonAddAssistant.UseVisualStyleBackColor = true;
            this.iconButtonAddAssistant.Click += new System.EventHandler(this.iconButtonAddAssistant_Click);
            // 
            // iconButtonAddAnesthetist
            // 
            this.iconButtonAddAnesthetist.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAddAnesthetist.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddAnesthetist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddAnesthetist.Location = new System.Drawing.Point(138, 27);
            this.iconButtonAddAnesthetist.Name = "iconButtonAddAnesthetist";
            this.iconButtonAddAnesthetist.Size = new System.Drawing.Size(126, 33);
            this.iconButtonAddAnesthetist.TabIndex = 0;
            this.iconButtonAddAnesthetist.Text = "Agregar";
            this.iconButtonAddAnesthetist.UseVisualStyleBackColor = true;
            this.iconButtonAddAnesthetist.Click += new System.EventHandler(this.iconButtonAddAnesthetist_Click);
            // 
            // iconButtonAddDoctor
            // 
            this.iconButtonAddDoctor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAddDoctor.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddDoctor.Location = new System.Drawing.Point(196, 19);
            this.iconButtonAddDoctor.Name = "iconButtonAddDoctor";
            this.iconButtonAddDoctor.Size = new System.Drawing.Size(126, 33);
            this.iconButtonAddDoctor.TabIndex = 6;
            this.iconButtonAddDoctor.Text = "Agregar";
            this.iconButtonAddDoctor.UseVisualStyleBackColor = true;
            this.iconButtonAddDoctor.Click += new System.EventHandler(this.iconButtonAddDoctor_Click);
            // 
            // assignSurgery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 752);
            this.Controls.Add(this.iconButtonConfirm);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxpatientData);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "assignSurgery";
            this.Text = "assignSurgery";
            this.Load += new System.EventHandler(this.assignSurgery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxpatientData.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxpatientData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelhistoryNumber;
        private System.Windows.Forms.Label labelsecondName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelfirstName;
        private System.Windows.Forms.DateTimePicker dateTimeSurgeryDate;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox comboBoxSurgeryType;
        private System.Windows.Forms.ComboBox comboBoxAnesthesiaType;
        private System.Windows.Forms.ListView listViewAssistants;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ListBox listBoxIds;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButtonAddDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDoctorName;
        private System.Windows.Forms.Label labelIdDoctor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAnestethistName;
        private System.Windows.Forms.Label labelIdAnesthetist;
        private FontAwesome.Sharp.IconButton iconButtonAddAnesthetist;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxOperatingRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton iconButtonDeleteAll;
        private FontAwesome.Sharp.IconButton iconButtonAddAssistant;
        private FontAwesome.Sharp.IconButton iconButtonConfirm;
    }
}