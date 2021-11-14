
namespace UI
{
    partial class PostOperation
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
            this.textBoxProcI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProcF = new System.Windows.Forms.TextBox();
            this.labelDiff = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonContinue = new FontAwesome.Sharp.IconButton();
            this.iconButtonCancel = new FontAwesome.Sharp.IconButton();
            this.checkedListBoxAnesthesiaTypes = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxProcI
            // 
            this.textBoxProcI.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProcI.Location = new System.Drawing.Point(331, 94);
            this.textBoxProcI.Name = "textBoxProcI";
            this.textBoxProcI.Size = new System.Drawing.Size(403, 26);
            this.textBoxProcI.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Procedimiento inicial";
            // 
            // textBoxProcF
            // 
            this.textBoxProcF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProcF.Location = new System.Drawing.Point(331, 126);
            this.textBoxProcF.Multiline = true;
            this.textBoxProcF.Name = "textBoxProcF";
            this.textBoxProcF.Size = new System.Drawing.Size(403, 150);
            this.textBoxProcF.TabIndex = 6;
            // 
            // labelDiff
            // 
            this.labelDiff.AutoSize = true;
            this.labelDiff.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiff.Location = new System.Drawing.Point(138, 129);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(187, 20);
            this.labelDiff.TabIndex = 5;
            this.labelDiff.Text = "Procedimiento postoperatorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Datos Postoperatorios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.iconButtonContinue.Location = new System.Drawing.Point(1044, 334);
            this.iconButtonContinue.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonContinue.Name = "iconButtonContinue";
            this.iconButtonContinue.Size = new System.Drawing.Size(119, 40);
            this.iconButtonContinue.TabIndex = 38;
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
            this.iconButtonCancel.Location = new System.Drawing.Point(11, 334);
            this.iconButtonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.iconButtonCancel.Name = "iconButtonCancel";
            this.iconButtonCancel.Size = new System.Drawing.Size(119, 40);
            this.iconButtonCancel.TabIndex = 37;
            this.iconButtonCancel.Text = "Cancelar";
            this.iconButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCancel.UseVisualStyleBackColor = false;
            this.iconButtonCancel.Click += new System.EventHandler(this.iconButtonCancel_Click);
            // 
            // checkedListBoxAnesthesiaTypes
            // 
            this.checkedListBoxAnesthesiaTypes.FormattingEnabled = true;
            this.checkedListBoxAnesthesiaTypes.Location = new System.Drawing.Point(758, 94);
            this.checkedListBoxAnesthesiaTypes.Name = "checkedListBoxAnesthesiaTypes";
            this.checkedListBoxAnesthesiaTypes.Size = new System.Drawing.Size(225, 184);
            this.checkedListBoxAnesthesiaTypes.TabIndex = 39;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(290, 232);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(35, 30);
            this.listBox1.TabIndex = 40;
            this.listBox1.Visible = false;
            // 
            // PostOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 385);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBoxAnesthesiaTypes);
            this.Controls.Add(this.iconButtonContinue);
            this.Controls.Add(this.iconButtonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProcI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProcF);
            this.Controls.Add(this.labelDiff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostOperation";
            this.Load += new System.EventHandler(this.PostOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProcI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProcF;
        private System.Windows.Forms.Label labelDiff;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonCancel;
        private FontAwesome.Sharp.IconButton iconButtonContinue;
        private System.Windows.Forms.CheckedListBox checkedListBoxAnesthesiaTypes;
        private System.Windows.Forms.ListBox listBox1;
    }
}