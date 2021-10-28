
namespace UI
{
    partial class selectPerson
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.dataGridViewSearchPerson = new System.Windows.Forms.DataGridView();
            this.iconButtonContinue = new FontAwesome.Sharp.IconButton();
            this.iconButtonCancel = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(274, 65);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(255, 19);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Text = "BUSCAR";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(580, 62);
            this.comboBoxFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(229, 28);
            this.comboBoxFilter.TabIndex = 2;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // dataGridViewSearchPerson
            // 
            this.dataGridViewSearchPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSearchPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchPerson.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.dataGridViewSearchPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSearchPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchPerson.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSearchPerson.EnableHeadersVisualStyles = false;
            this.dataGridViewSearchPerson.GridColor = System.Drawing.Color.White;
            this.dataGridViewSearchPerson.Location = new System.Drawing.Point(11, 101);
            this.dataGridViewSearchPerson.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSearchPerson.Name = "dataGridViewSearchPerson";
            this.dataGridViewSearchPerson.ReadOnly = true;
            this.dataGridViewSearchPerson.RowHeadersVisible = false;
            this.dataGridViewSearchPerson.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dataGridViewSearchPerson.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSearchPerson.RowTemplate.Height = 24;
            this.dataGridViewSearchPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchPerson.Size = new System.Drawing.Size(1168, 272);
            this.dataGridViewSearchPerson.TabIndex = 30;
            this.dataGridViewSearchPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchPerson_CellClick);
            this.dataGridViewSearchPerson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchPerson_CellContentClick);
            this.dataGridViewSearchPerson.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchPerson_CellContentDoubleClick);
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
            this.iconButtonContinue.Location = new System.Drawing.Point(1060, 377);
            this.iconButtonContinue.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonContinue.Name = "iconButtonContinue";
            this.iconButtonContinue.Size = new System.Drawing.Size(119, 40);
            this.iconButtonContinue.TabIndex = 34;
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
            this.iconButtonCancel.TabIndex = 35;
            this.iconButtonCancel.Text = "Cancelar";
            this.iconButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCancel.UseVisualStyleBackColor = false;
            this.iconButtonCancel.Click += new System.EventHandler(this.iconButtonCancel_Click);
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonSearch.BackColor = System.Drawing.Color.White;
            this.iconButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSearch.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.IconSize = 30;
            this.iconButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSearch.Location = new System.Drawing.Point(847, 55);
            this.iconButtonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(119, 40);
            this.iconButtonSearch.TabIndex = 36;
            this.iconButtonSearch.Text = "Buscar";
            this.iconButtonSearch.UseVisualStyleBackColor = false;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(274, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 1);
            this.panel3.TabIndex = 37;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(240, 62);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox1.TabIndex = 38;
            this.iconPictureBox1.TabStop = false;
            // 
            // selectPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1190, 424);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.iconButtonSearch);
            this.Controls.Add(this.iconButtonCancel);
            this.Controls.Add(this.iconButtonContinue);
            this.Controls.Add(this.dataGridViewSearchPerson);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "selectPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar";
            this.Load += new System.EventHandler(this.selectPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.DataGridView dataGridViewSearchPerson;
        private FontAwesome.Sharp.IconButton iconButtonContinue;
        private FontAwesome.Sharp.IconButton iconButtonCancel;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}