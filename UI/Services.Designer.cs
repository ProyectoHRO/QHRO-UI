
namespace UI
{
    partial class Services
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxServices = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelServiceName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewOperatingRooms = new System.Windows.Forms.DataGridView();
            this.iconButtonList = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.iconButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.iconButtonNew = new FontAwesome.Sharp.IconButton();
            this.textBoxNameService = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxServices.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperatingRooms)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxServices
            // 
            this.groupBoxServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxServices.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxServices.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxServices.Location = new System.Drawing.Point(16, -2);
            this.groupBoxServices.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxServices.Name = "groupBoxServices";
            this.groupBoxServices.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxServices.Size = new System.Drawing.Size(759, 191);
            this.groupBoxServices.TabIndex = 38;
            this.groupBoxServices.TabStop = false;
            this.groupBoxServices.Text = "Datos del Servico";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.labelServiceName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(10, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 39);
            this.panel1.TabIndex = 23;
            // 
            // labelServiceName
            // 
            this.labelServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelServiceName.AutoSize = true;
            this.labelServiceName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceName.Location = new System.Drawing.Point(150, 7);
            this.labelServiceName.Name = "labelServiceName";
            this.labelServiceName.Size = new System.Drawing.Size(154, 24);
            this.labelServiceName.TabIndex = 0;
            this.labelServiceName.Text = "Nombre de Servicio";
            this.labelServiceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(129, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "*";
            // 
            // dataGridViewOperatingRooms
            // 
            this.dataGridViewOperatingRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOperatingRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOperatingRooms.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOperatingRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOperatingRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewOperatingRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperatingRooms.EnableHeadersVisualStyles = false;
            this.dataGridViewOperatingRooms.GridColor = System.Drawing.Color.White;
            this.dataGridViewOperatingRooms.Location = new System.Drawing.Point(3, 308);
            this.dataGridViewOperatingRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewOperatingRooms.Name = "dataGridViewOperatingRooms";
            this.dataGridViewOperatingRooms.RowHeadersVisible = false;
            this.dataGridViewOperatingRooms.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dataGridViewOperatingRooms.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewOperatingRooms.RowTemplate.Height = 24;
            this.dataGridViewOperatingRooms.Size = new System.Drawing.Size(1143, 485);
            this.dataGridViewOperatingRooms.TabIndex = 37;
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
            this.iconButtonList.Location = new System.Drawing.Point(805, 169);
            this.iconButtonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonList.Name = "iconButtonList";
            this.iconButtonList.Size = new System.Drawing.Size(304, 49);
            this.iconButtonList.TabIndex = 36;
            this.iconButtonList.Text = "Ver servicios";
            this.iconButtonList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonList.UseVisualStyleBackColor = false;
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
            this.iconButtonSave.Location = new System.Drawing.Point(805, 63);
            this.iconButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(304, 47);
            this.iconButtonSave.TabIndex = 35;
            this.iconButtonSave.Text = "Guardar";
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
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
            this.iconButtonUpdate.Location = new System.Drawing.Point(805, 114);
            this.iconButtonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonUpdate.Name = "iconButtonUpdate";
            this.iconButtonUpdate.Size = new System.Drawing.Size(304, 49);
            this.iconButtonUpdate.TabIndex = 34;
            this.iconButtonUpdate.Text = "Actualizar Servicio";
            this.iconButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdate.UseVisualStyleBackColor = false;
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
            this.iconButtonNew.Location = new System.Drawing.Point(805, 9);
            this.iconButtonNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonNew.Name = "iconButtonNew";
            this.iconButtonNew.Size = new System.Drawing.Size(304, 49);
            this.iconButtonNew.TabIndex = 33;
            this.iconButtonNew.Text = "Agregar nuevo Servicio";
            this.iconButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNew.UseVisualStyleBackColor = false;
            // 
            // textBoxNameService
            // 
            this.textBoxNameService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameService.Location = new System.Drawing.Point(365, 35);
            this.textBoxNameService.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNameService.MaxLength = 40;
            this.textBoxNameService.Name = "textBoxNameService";
            this.textBoxNameService.Size = new System.Drawing.Size(353, 30);
            this.textBoxNameService.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxNameService, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(722, 100);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 791);
            this.Controls.Add(this.groupBoxServices);
            this.Controls.Add(this.dataGridViewOperatingRooms);
            this.Controls.Add(this.iconButtonList);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.iconButtonUpdate);
            this.Controls.Add(this.iconButtonNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Services";
            this.Text = "Services";
            this.groupBoxServices.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperatingRooms)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxServices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelServiceName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewOperatingRooms;
        private FontAwesome.Sharp.IconButton iconButtonList;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton iconButtonUpdate;
        private FontAwesome.Sharp.IconButton iconButtonNew;
        private System.Windows.Forms.TextBox textBoxNameService;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}