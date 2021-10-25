
namespace UI
{
    partial class FormsSchedules
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.iconButtonReSchedule = new FontAwesome.Sharp.IconButton();
            this.iconButtonDiffer = new FontAwesome.Sharp.IconButton();
            this.iconButtonFinish = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programaciones";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(563, 24);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(92, 32);
            this.labelDate.TabIndex = 12;
            this.labelDate.Text = "Fecha";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSchedule.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSchedule.EnableHeadersVisualStyles = false;
            this.dataGridViewSchedule.GridColor = System.Drawing.Color.White;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(11, 58);
            this.dataGridViewSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSchedule.RowHeadersVisible = false;
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dataGridViewSchedule.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSchedule.RowTemplate.Height = 24;
            this.dataGridViewSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(1264, 780);
            this.dataGridViewSchedule.TabIndex = 35;
            this.dataGridViewSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellClick);
            this.dataGridViewSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iconButtonReSchedule
            // 
            this.iconButtonReSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonReSchedule.BackColor = System.Drawing.Color.White;
            this.iconButtonReSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonReSchedule.Enabled = false;
            this.iconButtonReSchedule.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonReSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonReSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonReSchedule.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonReSchedule.ForeColor = System.Drawing.Color.Black;
            this.iconButtonReSchedule.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconButtonReSchedule.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonReSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonReSchedule.IconSize = 60;
            this.iconButtonReSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReSchedule.Location = new System.Drawing.Point(11, 842);
            this.iconButtonReSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonReSchedule.Name = "iconButtonReSchedule";
            this.iconButtonReSchedule.Size = new System.Drawing.Size(312, 94);
            this.iconButtonReSchedule.TabIndex = 37;
            this.iconButtonReSchedule.Text = "Reprogramar";
            this.iconButtonReSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonReSchedule.UseVisualStyleBackColor = false;
            this.iconButtonReSchedule.Click += new System.EventHandler(this.iconButtonReSchedule_Click);
            // 
            // iconButtonDiffer
            // 
            this.iconButtonDiffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDiffer.BackColor = System.Drawing.Color.White;
            this.iconButtonDiffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonDiffer.Enabled = false;
            this.iconButtonDiffer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonDiffer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonDiffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDiffer.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDiffer.ForeColor = System.Drawing.Color.Black;
            this.iconButtonDiffer.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.iconButtonDiffer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonDiffer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDiffer.IconSize = 60;
            this.iconButtonDiffer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDiffer.Location = new System.Drawing.Point(1020, 842);
            this.iconButtonDiffer.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonDiffer.Name = "iconButtonDiffer";
            this.iconButtonDiffer.Size = new System.Drawing.Size(255, 94);
            this.iconButtonDiffer.TabIndex = 36;
            this.iconButtonDiffer.Text = "Diferir";
            this.iconButtonDiffer.UseVisualStyleBackColor = false;
            this.iconButtonDiffer.Click += new System.EventHandler(this.iconButtonDiffer_Click);
            // 
            // iconButtonFinish
            // 
            this.iconButtonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonFinish.BackColor = System.Drawing.Color.White;
            this.iconButtonFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonFinish.Enabled = false;
            this.iconButtonFinish.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFinish.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonFinish.ForeColor = System.Drawing.Color.Black;
            this.iconButtonFinish.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.iconButtonFinish.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonFinish.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFinish.IconSize = 60;
            this.iconButtonFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFinish.Location = new System.Drawing.Point(504, 842);
            this.iconButtonFinish.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonFinish.Name = "iconButtonFinish";
            this.iconButtonFinish.Size = new System.Drawing.Size(331, 94);
            this.iconButtonFinish.TabIndex = 38;
            this.iconButtonFinish.Text = "Finalizar cirugía";
            this.iconButtonFinish.UseVisualStyleBackColor = false;
            this.iconButtonFinish.Click += new System.EventHandler(this.iconButtonFinish_Click);
            // 
            // FormsSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 947);
            this.Controls.Add(this.iconButtonFinish);
            this.Controls.Add(this.iconButtonReSchedule);
            this.Controls.Add(this.iconButtonDiffer);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormsSchedules";
            this.Text = "FormsSchedules";
            this.Activated += new System.EventHandler(this.FormsSchedules_Activated);
            this.Load += new System.EventHandler(this.FormsSchedules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private FontAwesome.Sharp.IconButton iconButtonDiffer;
        private FontAwesome.Sharp.IconButton iconButtonReSchedule;
        private FontAwesome.Sharp.IconButton iconButtonFinish;
    }
}