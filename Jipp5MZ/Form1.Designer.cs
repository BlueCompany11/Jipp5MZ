namespace Jipp5MZ
{
    partial class Form1
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
            this.osobliwyTextBoxCola = new Jipp5MZ.OsobliwyTextBox();
            this.buttonCola = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSok = new System.Windows.Forms.Button();
            this.osobliwyTextBoxSok = new Jipp5MZ.OsobliwyTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // osobliwyTextBoxCola
            // 
            this.osobliwyTextBoxCola.Location = new System.Drawing.Point(290, 100);
            this.osobliwyTextBoxCola.Name = "osobliwyTextBoxCola";
            this.osobliwyTextBoxCola.Size = new System.Drawing.Size(159, 24);
            this.osobliwyTextBoxCola.TabIndex = 0;
            this.osobliwyTextBoxCola.Text = "";
            // 
            // buttonCola
            // 
            this.buttonCola.Location = new System.Drawing.Point(162, 101);
            this.buttonCola.Name = "buttonCola";
            this.buttonCola.Size = new System.Drawing.Size(122, 23);
            this.buttonCola.TabIndex = 1;
            this.buttonCola.Text = "Wypij";
            this.buttonCola.UseVisualStyleBackColor = true;
            this.buttonCola.Click += new System.EventHandler(this.buttonCola_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "litrów coli";
            // 
            // buttonSok
            // 
            this.buttonSok.Location = new System.Drawing.Point(162, 159);
            this.buttonSok.Name = "buttonSok";
            this.buttonSok.Size = new System.Drawing.Size(122, 23);
            this.buttonSok.TabIndex = 3;
            this.buttonSok.Text = "Wypij";
            this.buttonSok.UseVisualStyleBackColor = true;
            this.buttonSok.Click += new System.EventHandler(this.buttonSok_Click);
            // 
            // osobliwyTextBoxSok
            // 
            this.osobliwyTextBoxSok.Location = new System.Drawing.Point(291, 159);
            this.osobliwyTextBoxSok.Name = "osobliwyTextBoxSok";
            this.osobliwyTextBoxSok.Size = new System.Drawing.Size(158, 22);
            this.osobliwyTextBoxSok.TabIndex = 4;
            this.osobliwyTextBoxSok.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "litrów soku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.osobliwyTextBoxSok);
            this.Controls.Add(this.buttonSok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCola);
            this.Controls.Add(this.osobliwyTextBoxCola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OsobliwyTextBox osobliwyTextBoxCola;
        private System.Windows.Forms.Button buttonCola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSok;
        private OsobliwyTextBox osobliwyTextBoxSok;
        private System.Windows.Forms.Label label2;
    }
}

