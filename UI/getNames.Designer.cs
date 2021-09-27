
namespace UI
{
    partial class getNames
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxThirdName = new System.Windows.Forms.TextBox();
            this.textBoxFirstSurname = new System.Windows.Forms.TextBox();
            this.textBoxSecondSurname = new System.Windows.Forms.TextBox();
            this.iconButtonContinue = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(114, 55);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(171, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(114, 81);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(171, 20);
            this.textBoxSecondName.TabIndex = 1;
            // 
            // textBoxThirdName
            // 
            this.textBoxThirdName.Location = new System.Drawing.Point(114, 107);
            this.textBoxThirdName.Name = "textBoxThirdName";
            this.textBoxThirdName.Size = new System.Drawing.Size(171, 20);
            this.textBoxThirdName.TabIndex = 2;
            // 
            // textBoxFirstSurname
            // 
            this.textBoxFirstSurname.Location = new System.Drawing.Point(445, 51);
            this.textBoxFirstSurname.Name = "textBoxFirstSurname";
            this.textBoxFirstSurname.Size = new System.Drawing.Size(171, 20);
            this.textBoxFirstSurname.TabIndex = 3;
            // 
            // textBoxSecondSurname
            // 
            this.textBoxSecondSurname.Location = new System.Drawing.Point(445, 81);
            this.textBoxSecondSurname.Name = "textBoxSecondSurname";
            this.textBoxSecondSurname.Size = new System.Drawing.Size(171, 20);
            this.textBoxSecondSurname.TabIndex = 4;
            // 
            // iconButtonContinue
            // 
            this.iconButtonContinue.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonContinue.IconColor = System.Drawing.Color.Black;
            this.iconButtonContinue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonContinue.Location = new System.Drawing.Point(445, 136);
            this.iconButtonContinue.Name = "iconButtonContinue";
            this.iconButtonContinue.Size = new System.Drawing.Size(75, 23);
            this.iconButtonContinue.TabIndex = 5;
            this.iconButtonContinue.Text = "Continuar";
            this.iconButtonContinue.UseVisualStyleBackColor = true;
            this.iconButtonContinue.Click += new System.EventHandler(this.iconButtonContinue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Primer Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Segundo nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tercer nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Primer apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Segundo Apellido";
            // 
            // getNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 202);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButtonContinue);
            this.Controls.Add(this.textBoxSecondSurname);
            this.Controls.Add(this.textBoxFirstSurname);
            this.Controls.Add(this.textBoxThirdName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "getNames";
            this.Text = "getNames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxThirdName;
        private System.Windows.Forms.TextBox textBoxFirstSurname;
        private System.Windows.Forms.TextBox textBoxSecondSurname;
        private FontAwesome.Sharp.IconButton iconButtonContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}