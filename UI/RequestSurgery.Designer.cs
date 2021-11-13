
namespace UI
{
    partial class RequestSurgery
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iconButtonSearchNames = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBoxpatientData = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
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
            this.labelID = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconButtonRequest = new FontAwesome.Sharp.IconButton();
            this.iconButtonCreateAndRequest = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.groupBoxpatientData.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.27596F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.72404F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanel1.Controls.Add(this.iconButtonSearchNames, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconPictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSearch, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(229, 172);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 36);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // iconButtonSearchNames
            // 
            this.iconButtonSearchNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonSearchNames.BackColor = System.Drawing.Color.White;
            this.iconButtonSearchNames.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonSearchNames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonSearchNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearchNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSearchNames.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSearchNames.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSearchNames.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonSearchNames.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearchNames.IconSize = 30;
            this.iconButtonSearchNames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSearchNames.Location = new System.Drawing.Point(612, 2);
            this.iconButtonSearchNames.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonSearchNames.Name = "iconButtonSearchNames";
            this.iconButtonSearchNames.Size = new System.Drawing.Size(218, 32);
            this.iconButtonSearchNames.TabIndex = 30;
            this.iconButtonSearchNames.Text = "Buscar";
            this.iconButtonSearchNames.UseVisualStyleBackColor = false;
            this.iconButtonSearchNames.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(33, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(31, 29);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(70, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(529, 30);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.Text = "Buscar paciente por No. Historia";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // groupBoxpatientData
            // 
            this.groupBoxpatientData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxpatientData.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxpatientData.Enabled = false;
            this.groupBoxpatientData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxpatientData.Location = new System.Drawing.Point(11, 239);
            this.groupBoxpatientData.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxpatientData.Name = "groupBoxpatientData";
            this.groupBoxpatientData.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxpatientData.Size = new System.Drawing.Size(1094, 226);
            this.groupBoxpatientData.TabIndex = 24;
            this.groupBoxpatientData.TabStop = false;
            this.groupBoxpatientData.Text = "Datos del paciente";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.18349F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75841F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.09756F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.17073F));
            this.tableLayoutPanel3.Controls.Add(this.labelsecondSurname, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelAge, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxAge, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxhistoryNumber, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxsecondSurname, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxfirstName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxsecondName, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxfirstSurname, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelsecondName, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelGender, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxGender, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelID, 3, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(35, 24);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1025, 193);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelsecondSurname
            // 
            this.labelsecondSurname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelsecondSurname.AutoSize = true;
            this.labelsecondSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsecondSurname.Location = new System.Drawing.Point(544, 0);
            this.labelsecondSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelsecondSurname.Name = "labelsecondSurname";
            this.labelsecondSurname.Size = new System.Drawing.Size(97, 38);
            this.labelsecondSurname.TabIndex = 5;
            this.labelsecondSurname.Text = "Segundo apellido";
            // 
            // labelAge
            // 
            this.labelAge.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(583, 44);
            this.labelAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(58, 25);
            this.labelAge.TabIndex = 16;
            this.labelAge.Text = "Edad";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(645, 42);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAge.MaxLength = 3;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(378, 30);
            this.textBoxAge.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.labelhistoryNumber);
            this.panel1.Location = new System.Drawing.Point(50, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 32);
            this.panel1.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(51, 3);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.labelhistoryNumber.Location = new System.Drawing.Point(65, 6);
            this.labelhistoryNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelhistoryNumber.Name = "labelhistoryNumber";
            this.labelhistoryNumber.Size = new System.Drawing.Size(104, 25);
            this.labelhistoryNumber.TabIndex = 10;
            this.labelhistoryNumber.Text = "No historia";
            // 
            // textBoxhistoryNumber
            // 
            this.textBoxhistoryNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxhistoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxhistoryNumber.Location = new System.Drawing.Point(208, 4);
            this.textBoxhistoryNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxhistoryNumber.MaxLength = 20;
            this.textBoxhistoryNumber.Name = "textBoxhistoryNumber";
            this.textBoxhistoryNumber.Size = new System.Drawing.Size(269, 30);
            this.textBoxhistoryNumber.TabIndex = 0;
            // 
            // textBoxsecondSurname
            // 
            this.textBoxsecondSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxsecondSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsecondSurname.Location = new System.Drawing.Point(645, 4);
            this.textBoxsecondSurname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxsecondSurname.MaxLength = 20;
            this.textBoxsecondSurname.Name = "textBoxsecondSurname";
            this.textBoxsecondSurname.Size = new System.Drawing.Size(378, 30);
            this.textBoxsecondSurname.TabIndex = 5;
            // 
            // textBoxfirstName
            // 
            this.textBoxfirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfirstName.Location = new System.Drawing.Point(208, 42);
            this.textBoxfirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxfirstName.MaxLength = 20;
            this.textBoxfirstName.Name = "textBoxfirstName";
            this.textBoxfirstName.Size = new System.Drawing.Size(269, 30);
            this.textBoxfirstName.TabIndex = 1;
            // 
            // textBoxsecondName
            // 
            this.textBoxsecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxsecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsecondName.Location = new System.Drawing.Point(208, 80);
            this.textBoxsecondName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxsecondName.MaxLength = 20;
            this.textBoxsecondName.Name = "textBoxsecondName";
            this.textBoxsecondName.Size = new System.Drawing.Size(269, 30);
            this.textBoxsecondName.TabIndex = 2;
            // 
            // textBoxfirstSurname
            // 
            this.textBoxfirstSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxfirstSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfirstSurname.Location = new System.Drawing.Point(208, 157);
            this.textBoxfirstSurname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxfirstSurname.MaxLength = 20;
            this.textBoxfirstSurname.Name = "textBoxfirstSurname";
            this.textBoxfirstSurname.Size = new System.Drawing.Size(269, 30);
            this.textBoxfirstSurname.TabIndex = 4;
            // 
            // labelsecondName
            // 
            this.labelsecondName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelsecondName.AutoSize = true;
            this.labelsecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsecondName.Location = new System.Drawing.Point(41, 82);
            this.labelsecondName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.panel2.Location = new System.Drawing.Point(50, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 32);
            this.panel2.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(24, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.labelfirstName.Location = new System.Drawing.Point(38, 7);
            this.labelfirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.panel3.Location = new System.Drawing.Point(76, 156);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 32);
            this.panel3.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(4, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.labelfirstSurname.Location = new System.Drawing.Point(15, 6);
            this.labelfirstSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.labelGender.Location = new System.Drawing.Point(564, 82);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(77, 25);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "Género";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBoxGender.Location = new System.Drawing.Point(645, 78);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(378, 33);
            this.comboBoxGender.TabIndex = 11;
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(645, 152);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(378, 25);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "label10";
            this.labelID.Visible = false;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1063, 81);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 32);
            this.panel4.TabIndex = 29;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(211, 6);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.label24.Location = new System.Drawing.Point(221, 6);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(114, 25);
            this.label24.TabIndex = 10;
            this.label24.Text = "Diagnostico";
            // 
            // textBoxDiagnosis
            // 
            this.textBoxDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiagnosis.Location = new System.Drawing.Point(326, 2);
            this.textBoxDiagnosis.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDiagnosis.MaxLength = 150;
            this.textBoxDiagnosis.Multiline = true;
            this.textBoxDiagnosis.Name = "textBoxDiagnosis";
            this.textBoxDiagnosis.Size = new System.Drawing.Size(735, 77);
            this.textBoxDiagnosis.TabIndex = 7;
            this.textBoxDiagnosis.TextChanged += new System.EventHandler(this.textBoxDiagnosis_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 105);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // iconButtonRequest
            // 
            this.iconButtonRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonRequest.BackColor = System.Drawing.Color.White;
            this.iconButtonRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonRequest.Enabled = false;
            this.iconButtonRequest.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRequest.ForeColor = System.Drawing.Color.Black;
            this.iconButtonRequest.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonRequest.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRequest.IconSize = 30;
            this.iconButtonRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRequest.Location = new System.Drawing.Point(1109, 422);
            this.iconButtonRequest.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonRequest.Name = "iconButtonRequest";
            this.iconButtonRequest.Size = new System.Drawing.Size(166, 40);
            this.iconButtonRequest.TabIndex = 28;
            this.iconButtonRequest.Text = "Solicitar cirugía";
            this.iconButtonRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRequest.UseVisualStyleBackColor = false;
            this.iconButtonRequest.Visible = false;
            this.iconButtonRequest.Click += new System.EventHandler(this.iconButtonRequest_Click);
            // 
            // iconButtonCreateAndRequest
            // 
            this.iconButtonCreateAndRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonCreateAndRequest.BackColor = System.Drawing.Color.White;
            this.iconButtonCreateAndRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCreateAndRequest.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonCreateAndRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonCreateAndRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCreateAndRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCreateAndRequest.ForeColor = System.Drawing.Color.Black;
            this.iconButtonCreateAndRequest.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonCreateAndRequest.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonCreateAndRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCreateAndRequest.IconSize = 30;
            this.iconButtonCreateAndRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCreateAndRequest.Location = new System.Drawing.Point(1109, 361);
            this.iconButtonCreateAndRequest.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonCreateAndRequest.Name = "iconButtonCreateAndRequest";
            this.iconButtonCreateAndRequest.Size = new System.Drawing.Size(166, 40);
            this.iconButtonCreateAndRequest.TabIndex = 27;
            this.iconButtonCreateAndRequest.Text = "Crear y solicitar";
            this.iconButtonCreateAndRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCreateAndRequest.UseVisualStyleBackColor = false;
            this.iconButtonCreateAndRequest.Visible = false;
            this.iconButtonCreateAndRequest.Click += new System.EventHandler(this.iconButtonCreateAndRequest_Click);
            // 
            // RequestSurgery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 894);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconButtonRequest);
            this.Controls.Add(this.iconButtonCreateAndRequest);
            this.Controls.Add(this.groupBoxpatientData);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestSurgery";
            this.Text = "RequestSurgery";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.groupBoxpatientData.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxpatientData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxDiagnosis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelsecondSurname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelhistoryNumber;
        private System.Windows.Forms.TextBox textBoxhistoryNumber;
        private System.Windows.Forms.TextBox textBoxsecondSurname;
        private System.Windows.Forms.TextBox textBoxfirstName;
        private System.Windows.Forms.TextBox textBoxsecondName;
        private System.Windows.Forms.TextBox textBoxfirstSurname;
        private System.Windows.Forms.Label labelsecondName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelfirstName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelfirstSurname;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelID;
        private FontAwesome.Sharp.IconButton iconButtonRequest;
        private FontAwesome.Sharp.IconButton iconButtonCreateAndRequest;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButtonSearchNames;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}