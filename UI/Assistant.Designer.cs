
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelID = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.comboTypeAssistant = new System.Windows.Forms.ComboBox();
            this.textCui = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textSecondLastName = new System.Windows.Forms.TextBox();
            this.textFirstLastName = new System.Windows.Forms.TextBox();
            this.textThirdName = new System.Windows.Forms.TextBox();
            this.textSecondName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.iconButtonList = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.iconButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.iconButtonNew = new FontAwesome.Sharp.IconButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBoxAssistantData = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.boxValidateMail = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.labelfirstSurname = new System.Windows.Forms.Label();
            this.labelsecondName = new System.Windows.Forms.Label();
            this.labelthirdName = new System.Windows.Forms.Label();
            this.labelsecondSurname = new System.Windows.Forms.Label();
            this.labelphoneNumber = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDPI = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.labelfirstName = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBoxAssistantData.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxValidateMail)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(7, 259);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(54, 17);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "label10";
            this.labelID.Visible = false;
            // 
            // comboStatus
            // 
            this.comboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.comboStatus.Location = new System.Drawing.Point(779, 191);
            this.comboStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(324, 24);
            this.comboStatus.TabIndex = 19;
            // 
            // comboTypeAssistant
            // 
            this.comboTypeAssistant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTypeAssistant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypeAssistant.FormattingEnabled = true;
            this.comboTypeAssistant.Location = new System.Drawing.Point(779, 145);
            this.comboTypeAssistant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboTypeAssistant.Name = "comboTypeAssistant";
            this.comboTypeAssistant.Size = new System.Drawing.Size(324, 24);
            this.comboTypeAssistant.TabIndex = 17;
            // 
            // textCui
            // 
            this.textCui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textCui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCui.Location = new System.Drawing.Point(321, 7);
            this.textCui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCui.Name = "textCui";
            this.textCui.Size = new System.Drawing.Size(219, 30);
            this.textCui.TabIndex = 15;
            this.textCui.TextChanged += new System.EventHandler(this.textCui_TextChanged);
            // 
            // textPhone
            // 
            this.textPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.Location = new System.Drawing.Point(779, 52);
            this.textPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(324, 30);
            this.textPhone.TabIndex = 12;
            this.textPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPhone_KeyPress);
            // 
            // textEmail
            // 
            this.textEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(4, 7);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(280, 30);
            this.textEmail.TabIndex = 10;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textSecondLastName
            // 
            this.textSecondLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textSecondLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSecondLastName.Location = new System.Drawing.Point(779, 7);
            this.textSecondLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSecondLastName.Name = "textSecondLastName";
            this.textSecondLastName.Size = new System.Drawing.Size(324, 30);
            this.textSecondLastName.TabIndex = 8;
            this.textSecondLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSecondLastName_KeyPress);
            // 
            // textFirstLastName
            // 
            this.textFirstLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textFirstLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstLastName.Location = new System.Drawing.Point(321, 188);
            this.textFirstLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFirstLastName.Name = "textFirstLastName";
            this.textFirstLastName.Size = new System.Drawing.Size(219, 30);
            this.textFirstLastName.TabIndex = 6;
            this.textFirstLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFirstLastName_KeyPress);
            // 
            // textThirdName
            // 
            this.textThirdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textThirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textThirdName.Location = new System.Drawing.Point(321, 142);
            this.textThirdName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textThirdName.Name = "textThirdName";
            this.textThirdName.Size = new System.Drawing.Size(219, 30);
            this.textThirdName.TabIndex = 4;
            this.textThirdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textThirdName_KeyPress);
            // 
            // textSecondName
            // 
            this.textSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSecondName.Location = new System.Drawing.Point(321, 97);
            this.textSecondName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSecondName.Name = "textSecondName";
            this.textSecondName.Size = new System.Drawing.Size(219, 30);
            this.textSecondName.TabIndex = 2;
            this.textSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSecondName_KeyPress);
            // 
            // textFirstName
            // 
            this.textFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstName.Location = new System.Drawing.Point(321, 52);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(219, 30);
            this.textFirstName.TabIndex = 0;
            this.textFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFirstName_KeyPress);
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
            this.iconButtonList.Location = new System.Drawing.Point(1267, 237);
            this.iconButtonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonList.Name = "iconButtonList";
            this.iconButtonList.Size = new System.Drawing.Size(160, 49);
            this.iconButtonList.TabIndex = 26;
            this.iconButtonList.Text = "Listar";
            this.iconButtonList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonList.UseVisualStyleBackColor = false;
            this.iconButtonList.Click += new System.EventHandler(this.iconButtonList_Click);
            this.iconButtonList.MouseLeave += new System.EventHandler(this.iconButtonList_MouseLeave);
            this.iconButtonList.MouseHover += new System.EventHandler(this.iconButtonList_MouseHover);
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
            this.iconButtonSave.Location = new System.Drawing.Point(1267, 176);
            this.iconButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(160, 47);
            this.iconButtonSave.TabIndex = 25;
            this.iconButtonSave.Text = "Guardar";
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            this.iconButtonSave.MouseLeave += new System.EventHandler(this.iconButtonSave_MouseLeave);
            this.iconButtonSave.MouseHover += new System.EventHandler(this.iconButtonSave_MouseHover);
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
            this.iconButtonUpdate.Location = new System.Drawing.Point(1267, 114);
            this.iconButtonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonUpdate.Name = "iconButtonUpdate";
            this.iconButtonUpdate.Size = new System.Drawing.Size(160, 49);
            this.iconButtonUpdate.TabIndex = 24;
            this.iconButtonUpdate.Text = "Actualizar";
            this.iconButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdate.UseVisualStyleBackColor = false;
            this.iconButtonUpdate.Click += new System.EventHandler(this.iconButtonUpdate_Click);
            this.iconButtonUpdate.MouseLeave += new System.EventHandler(this.iconButtonUpdate_MouseLeave);
            this.iconButtonUpdate.MouseHover += new System.EventHandler(this.iconButtonUpdate_MouseHover);
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
            this.iconButtonNew.Location = new System.Drawing.Point(1267, 48);
            this.iconButtonNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonNew.Name = "iconButtonNew";
            this.iconButtonNew.Size = new System.Drawing.Size(160, 49);
            this.iconButtonNew.TabIndex = 23;
            this.iconButtonNew.Text = "Nuevo";
            this.iconButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNew.UseVisualStyleBackColor = false;
            this.iconButtonNew.Click += new System.EventHandler(this.iconButtonNew_Click);
            this.iconButtonNew.MouseLeave += new System.EventHandler(this.iconButtonNew_MouseLeave);
            this.iconButtonNew.MouseHover += new System.EventHandler(this.iconButtonNew_MouseHover);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(12, 638);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1435, 399);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBoxAssistantData
            // 
            this.groupBoxAssistantData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAssistantData.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxAssistantData.Controls.Add(this.labelID);
            this.groupBoxAssistantData.Location = new System.Drawing.Point(96, 48);
            this.groupBoxAssistantData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAssistantData.Name = "groupBoxAssistantData";
            this.groupBoxAssistantData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAssistantData.Size = new System.Drawing.Size(1131, 287);
            this.groupBoxAssistantData.TabIndex = 28;
            this.groupBoxAssistantData.TabStop = false;
            this.groupBoxAssistantData.Text = "Datos del asistente";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.73016F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.9375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboTypeAssistant, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelsecondName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelthirdName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textCui, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textPhone, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelsecondSurname, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelphoneNumber, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelEmail, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textSecondLastName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textFirstLastName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textThirdName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textFirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textSecondName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboStatus, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelStatus, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1107, 226);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.boxValidateMail);
            this.panel4.Controls.Add(this.textEmail);
            this.panel4.Location = new System.Drawing.Point(779, 94);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 37);
            this.panel4.TabIndex = 23;
            // 
            // boxValidateMail
            // 
            this.boxValidateMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxValidateMail.Location = new System.Drawing.Point(292, 4);
            this.boxValidateMail.Margin = new System.Windows.Forms.Padding(4);
            this.boxValidateMail.Name = "boxValidateMail";
            this.boxValidateMail.Size = new System.Drawing.Size(29, 28);
            this.boxValidateMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxValidateMail.TabIndex = 0;
            this.boxValidateMail.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.labelfirstSurname);
            this.panel3.Location = new System.Drawing.Point(143, 183);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 39);
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
            this.labelfirstSurname.Location = new System.Drawing.Point(24, 5);
            this.labelfirstSurname.Name = "labelfirstSurname";
            this.labelfirstSurname.Size = new System.Drawing.Size(140, 25);
            this.labelfirstSurname.TabIndex = 4;
            this.labelfirstSurname.Text = "Primer apellido";
            // 
            // labelsecondName
            // 
            this.labelsecondName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelsecondName.AutoSize = true;
            this.labelsecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsecondName.Location = new System.Drawing.Point(151, 100);
            this.labelsecondName.Name = "labelsecondName";
            this.labelsecondName.Size = new System.Drawing.Size(163, 25);
            this.labelsecondName.TabIndex = 2;
            this.labelsecondName.Text = "Segundo nombre";
            // 
            // labelthirdName
            // 
            this.labelthirdName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelthirdName.AutoSize = true;
            this.labelthirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelthirdName.Location = new System.Drawing.Point(174, 145);
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
            this.labelsecondSurname.Location = new System.Drawing.Point(608, 10);
            this.labelsecondSurname.Name = "labelsecondSurname";
            this.labelsecondSurname.Size = new System.Drawing.Size(164, 25);
            this.labelsecondSurname.TabIndex = 5;
            this.labelsecondSurname.Text = "Segundo apellido";
            // 
            // labelphoneNumber
            // 
            this.labelphoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelphoneNumber.AutoSize = true;
            this.labelphoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphoneNumber.Location = new System.Drawing.Point(602, 55);
            this.labelphoneNumber.Name = "labelphoneNumber";
            this.labelphoneNumber.Size = new System.Drawing.Size(170, 25);
            this.labelphoneNumber.TabIndex = 6;
            this.labelphoneNumber.Text = "Número de celular";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(700, 100);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(72, 25);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Correo";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.labelDPI);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(161, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 39);
            this.panel1.TabIndex = 23;
            // 
            // labelDPI
            // 
            this.labelDPI.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDPI.AutoSize = true;
            this.labelDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDPI.Location = new System.Drawing.Point(103, 7);
            this.labelDPI.Name = "labelDPI";
            this.labelDPI.Size = new System.Drawing.Size(44, 25);
            this.labelDPI.TabIndex = 0;
            this.labelDPI.Text = "DPI";
            this.labelDPI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(81, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "*";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.labelfirstName);
            this.panel2.Location = new System.Drawing.Point(143, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 39);
            this.panel2.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(4, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 24);
            this.label13.TabIndex = 24;
            this.label13.Text = "*";
            // 
            // labelfirstName
            // 
            this.labelfirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelfirstName.AutoSize = true;
            this.labelfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfirstName.Location = new System.Drawing.Point(17, 7);
            this.labelfirstName.Name = "labelfirstName";
            this.labelfirstName.Size = new System.Drawing.Size(139, 25);
            this.labelfirstName.TabIndex = 1;
            this.labelfirstName.Text = "Primer nombre";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(699, 190);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(73, 25);
            this.labelStatus.TabIndex = 24;
            this.labelStatus.Text = "Estado";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(607, 138);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 39);
            this.panel5.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tipo Asistente";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(7, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 24);
            this.label15.TabIndex = 23;
            this.label15.Text = "*";
            // 
            // Assistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1459, 1048);
            this.Controls.Add(this.groupBoxAssistantData);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.iconButtonList);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.iconButtonUpdate);
            this.Controls.Add(this.iconButtonNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Assistant";
            this.Text = "Assistant";
            this.Load += new System.EventHandler(this.Assistant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBoxAssistantData.ResumeLayout(false);
            this.groupBoxAssistantData.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxValidateMail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textSecondLastName;
        private System.Windows.Forms.TextBox textFirstLastName;
        private System.Windows.Forms.TextBox textThirdName;
        private System.Windows.Forms.TextBox textSecondName;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.ComboBox comboTypeAssistant;
        private System.Windows.Forms.TextBox textCui;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label labelID;
        private FontAwesome.Sharp.IconButton iconButtonList;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton iconButtonUpdate;
        private FontAwesome.Sharp.IconButton iconButtonNew;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBoxAssistantData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox boxValidateMail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelfirstSurname;
        private System.Windows.Forms.Label labelsecondName;
        private System.Windows.Forms.Label labelthirdName;
        private System.Windows.Forms.Label labelsecondSurname;
        private System.Windows.Forms.Label labelphoneNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDPI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelfirstName;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}