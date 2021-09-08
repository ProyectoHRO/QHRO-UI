
namespace UI
{
    partial class Patient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconButtonList = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.iconButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.iconButtonNew = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxpatientData = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelthirdName = new System.Windows.Forms.Label();
            this.labelsecondSurname = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.labelhistoryNumber = new System.Windows.Forms.Label();
            this.textBoxhistoryNumber = new System.Windows.Forms.TextBox();
            this.textBoxsecondSurname = new System.Windows.Forms.TextBox();
            this.textBoxfirstName = new System.Windows.Forms.TextBox();
            this.textBoxsecondName = new System.Windows.Forms.TextBox();
            this.textBoxthirdName = new System.Windows.Forms.TextBox();
            this.textBoxfirstSurname = new System.Windows.Forms.TextBox();
            this.labelsecondName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.labelfirstName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.labelfirstSurname = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxpatientData.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButtonList
            // 
            this.iconButtonList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonList.BackColor = System.Drawing.Color.White;
            this.iconButtonList.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonList.ForeColor = System.Drawing.Color.Black;
            this.iconButtonList.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButtonList.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonList.IconSize = 30;
            this.iconButtonList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonList.Location = new System.Drawing.Point(984, 236);
            this.iconButtonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonList.Name = "iconButtonList";
            this.iconButtonList.Size = new System.Drawing.Size(159, 49);
            this.iconButtonList.TabIndex = 28;
            this.iconButtonList.Text = "Listar";
            this.iconButtonList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonList.UseVisualStyleBackColor = false;
            this.iconButtonList.Click += new System.EventHandler(this.iconButtonList_Click_1);
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonSave.BackColor = System.Drawing.Color.White;
            this.iconButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSave.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButtonSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSave.IconSize = 30;
            this.iconButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.Location = new System.Drawing.Point(984, 175);
            this.iconButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(159, 47);
            this.iconButtonSave.TabIndex = 27;
            this.iconButtonSave.Text = "Guardar";
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click_1);
            // 
            // iconButtonUpdate
            // 
            this.iconButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonUpdate.BackColor = System.Drawing.Color.White;
            this.iconButtonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUpdate.ForeColor = System.Drawing.Color.Black;
            this.iconButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.iconButtonUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUpdate.IconSize = 30;
            this.iconButtonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUpdate.Location = new System.Drawing.Point(984, 113);
            this.iconButtonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonUpdate.Name = "iconButtonUpdate";
            this.iconButtonUpdate.Size = new System.Drawing.Size(159, 49);
            this.iconButtonUpdate.TabIndex = 26;
            this.iconButtonUpdate.Text = "Actualizar";
            this.iconButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdate.UseVisualStyleBackColor = false;
            this.iconButtonUpdate.Click += new System.EventHandler(this.iconButtonUpdate_Click_1);
            // 
            // iconButtonNew
            // 
            this.iconButtonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonNew.BackColor = System.Drawing.Color.White;
            this.iconButtonNew.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonNew.ForeColor = System.Drawing.Color.Black;
            this.iconButtonNew.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonNew.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNew.IconSize = 30;
            this.iconButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNew.Location = new System.Drawing.Point(984, 50);
            this.iconButtonNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonNew.Name = "iconButtonNew";
            this.iconButtonNew.Size = new System.Drawing.Size(159, 49);
            this.iconButtonNew.TabIndex = 25;
            this.iconButtonNew.Text = "Nuevo";
            this.iconButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNew.UseVisualStyleBackColor = false;
            this.iconButtonNew.Click += new System.EventHandler(this.iconButtonNew_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 432);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 388);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick_1);
            // 
            // groupBoxpatientData
            // 
            this.groupBoxpatientData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxpatientData.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxpatientData.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxpatientData.Controls.Add(this.labelID);
            this.groupBoxpatientData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxpatientData.Location = new System.Drawing.Point(41, 27);
            this.groupBoxpatientData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxpatientData.Name = "groupBoxpatientData";
            this.groupBoxpatientData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxpatientData.Size = new System.Drawing.Size(911, 400);
            this.groupBoxpatientData.TabIndex = 23;
            this.groupBoxpatientData.TabStop = false;
            this.groupBoxpatientData.Text = "Datos del paciente";
            this.groupBoxpatientData.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.5618F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.4382F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDiagnosis, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 286);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(593, 101);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Location = new System.Drawing.Point(37, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 39);
            this.panel4.TabIndex = 29;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(3, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 24);
            this.label21.TabIndex = 23;
            this.label21.Text = "*";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(17, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(114, 25);
            this.label24.TabIndex = 10;
            this.label24.Text = "Diagnostico";
            // 
            // textBoxDiagnosis
            // 
            this.textBoxDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiagnosis.Location = new System.Drawing.Point(184, 3);
            this.textBoxDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDiagnosis.MaxLength = 150;
            this.textBoxDiagnosis.Multiline = true;
            this.textBoxDiagnosis.Name = "textBoxDiagnosis";
            this.textBoxDiagnosis.Size = new System.Drawing.Size(406, 95);
            this.textBoxDiagnosis.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.18349F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75841F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.65443F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.09786F));
            this.tableLayoutPanel1.Controls.Add(this.labelthirdName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelsecondSurname, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAge, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAge, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxhistoryNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxsecondSurname, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxfirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxsecondName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxthirdName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxfirstSurname, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelsecondName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelGender, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxGender, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelStatus, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxStatus, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 42);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 238);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // labelthirdName
            // 
            this.labelthirdName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelthirdName.AutoSize = true;
            this.labelthirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelthirdName.Location = new System.Drawing.Point(33, 152);
            this.labelthirdName.Name = "labelthirdName";
            this.labelthirdName.Size = new System.Drawing.Size(140, 25);
            this.labelthirdName.TabIndex = 3;
            this.labelthirdName.Text = "Tercer nombre";
            // 
            // labelsecondSurname
            // 
            this.labelsecondSurname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelsecondSurname.AutoSize = true;
            this.labelsecondSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsecondSurname.Location = new System.Drawing.Point(473, 0);
            this.labelsecondSurname.Name = "labelsecondSurname";
            this.labelsecondSurname.Size = new System.Drawing.Size(97, 47);
            this.labelsecondSurname.TabIndex = 5;
            this.labelsecondSurname.Text = "Segundo apellido";
            // 
            // labelAge
            // 
            this.labelAge.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(512, 58);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(58, 25);
            this.labelAge.TabIndex = 16;
            this.labelAge.Text = "Edad";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(576, 55);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.MaxLength = 3;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(293, 30);
            this.textBoxAge.TabIndex = 6;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.labelhistoryNumber);
            this.panel1.Location = new System.Drawing.Point(36, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 39);
            this.panel1.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(12, 4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 24);
            this.label22.TabIndex = 23;
            this.label22.Text = "*";
            // 
            // labelhistoryNumber
            // 
            this.labelhistoryNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelhistoryNumber.AutoSize = true;
            this.labelhistoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhistoryNumber.Location = new System.Drawing.Point(39, 7);
            this.labelhistoryNumber.Name = "labelhistoryNumber";
            this.labelhistoryNumber.Size = new System.Drawing.Size(104, 25);
            this.labelhistoryNumber.TabIndex = 10;
            this.labelhistoryNumber.Text = "No historia";
            // 
            // textBoxhistoryNumber
            // 
            this.textBoxhistoryNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxhistoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxhistoryNumber.Location = new System.Drawing.Point(179, 8);
            this.textBoxhistoryNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxhistoryNumber.MaxLength = 20;
            this.textBoxhistoryNumber.Name = "textBoxhistoryNumber";
            this.textBoxhistoryNumber.Size = new System.Drawing.Size(228, 30);
            this.textBoxhistoryNumber.TabIndex = 0;
            // 
            // textBoxsecondSurname
            // 
            this.textBoxsecondSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxsecondSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsecondSurname.Location = new System.Drawing.Point(576, 8);
            this.textBoxsecondSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxsecondSurname.MaxLength = 20;
            this.textBoxsecondSurname.Name = "textBoxsecondSurname";
            this.textBoxsecondSurname.Size = new System.Drawing.Size(293, 30);
            this.textBoxsecondSurname.TabIndex = 5;
            this.textBoxsecondSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxsecondSurname_KeyPress);
            // 
            // textBoxfirstName
            // 
            this.textBoxfirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfirstName.Location = new System.Drawing.Point(179, 55);
            this.textBoxfirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxfirstName.MaxLength = 20;
            this.textBoxfirstName.Name = "textBoxfirstName";
            this.textBoxfirstName.Size = new System.Drawing.Size(228, 30);
            this.textBoxfirstName.TabIndex = 1;
            this.textBoxfirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxfirstName_KeyPress);
            // 
            // textBoxsecondName
            // 
            this.textBoxsecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxsecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsecondName.Location = new System.Drawing.Point(179, 102);
            this.textBoxsecondName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxsecondName.MaxLength = 20;
            this.textBoxsecondName.Name = "textBoxsecondName";
            this.textBoxsecondName.Size = new System.Drawing.Size(228, 30);
            this.textBoxsecondName.TabIndex = 2;
            this.textBoxsecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxsecondName_KeyPress);
            // 
            // textBoxthirdName
            // 
            this.textBoxthirdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxthirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxthirdName.Location = new System.Drawing.Point(179, 149);
            this.textBoxthirdName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxthirdName.MaxLength = 20;
            this.textBoxthirdName.Name = "textBoxthirdName";
            this.textBoxthirdName.Size = new System.Drawing.Size(228, 30);
            this.textBoxthirdName.TabIndex = 3;
            this.textBoxthirdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxthirdName_KeyPress);
            // 
            // textBoxfirstSurname
            // 
            this.textBoxfirstSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxfirstSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfirstSurname.Location = new System.Drawing.Point(179, 198);
            this.textBoxfirstSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxfirstSurname.MaxLength = 20;
            this.textBoxfirstSurname.Name = "textBoxfirstSurname";
            this.textBoxfirstSurname.Size = new System.Drawing.Size(228, 30);
            this.textBoxfirstSurname.TabIndex = 4;
            this.textBoxfirstSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxfirstSurname_KeyPress);
            // 
            // labelsecondName
            // 
            this.labelsecondName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelsecondName.AutoSize = true;
            this.labelsecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsecondName.Location = new System.Drawing.Point(10, 105);
            this.labelsecondName.Name = "labelsecondName";
            this.labelsecondName.Size = new System.Drawing.Size(163, 25);
            this.labelsecondName.TabIndex = 2;
            this.labelsecondName.Text = "Segundo nombre";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.labelfirstName);
            this.panel2.Location = new System.Drawing.Point(3, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 39);
            this.panel2.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(4, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 24);
            this.label14.TabIndex = 24;
            this.label14.Text = "*";
            // 
            // labelfirstName
            // 
            this.labelfirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelfirstName.AutoSize = true;
            this.labelfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfirstName.Location = new System.Drawing.Point(36, 9);
            this.labelfirstName.Name = "labelfirstName";
            this.labelfirstName.Size = new System.Drawing.Size(139, 25);
            this.labelfirstName.TabIndex = 1;
            this.labelfirstName.Text = "Primer nombre";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.labelfirstSurname);
            this.panel3.Location = new System.Drawing.Point(3, 193);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 39);
            this.panel3.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(5, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "*";
            // 
            // labelfirstSurname
            // 
            this.labelfirstSurname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelfirstSurname.AutoSize = true;
            this.labelfirstSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfirstSurname.Location = new System.Drawing.Point(20, 7);
            this.labelfirstSurname.Name = "labelfirstSurname";
            this.labelfirstSurname.Size = new System.Drawing.Size(140, 25);
            this.labelfirstSurname.TabIndex = 4;
            this.labelfirstSurname.Text = "Primer apellido";
            // 
            // labelGender
            // 
            this.labelGender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(493, 105);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(77, 25);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "Género";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBoxGender.Location = new System.Drawing.Point(576, 101);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(293, 33);
            this.comboBoxGender.TabIndex = 11;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(497, 152);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(73, 25);
            this.labelStatus.TabIndex = 19;
            this.labelStatus.Text = "Estado";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBoxStatus.Location = new System.Drawing.Point(576, 148);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(293, 33);
            this.comboBoxStatus.TabIndex = 20;
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(827, 286);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(75, 25);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "label10";
            this.labelID.Visible = false;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 838);
            this.Controls.Add(this.iconButtonList);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.iconButtonUpdate);
            this.Controls.Add(this.iconButtonNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxpatientData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.Resize += new System.EventHandler(this.Patient_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxpatientData.ResumeLayout(false);
            this.groupBoxpatientData.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonList;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton iconButtonUpdate;
        private FontAwesome.Sharp.IconButton iconButtonNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxpatientData;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelthirdName;
        private System.Windows.Forms.Label labelsecondSurname;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBoxDiagnosis;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelhistoryNumber;
        private System.Windows.Forms.TextBox textBoxhistoryNumber;
        private System.Windows.Forms.TextBox textBoxsecondSurname;
        private System.Windows.Forms.TextBox textBoxfirstName;
        private System.Windows.Forms.TextBox textBoxsecondName;
        private System.Windows.Forms.TextBox textBoxthirdName;
        private System.Windows.Forms.TextBox textBoxfirstSurname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelsecondName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelfirstName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelfirstSurname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}