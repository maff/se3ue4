namespace A1
{
    partial class Taschenrechner
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
            this.button_Restwert = new System.Windows.Forms.Button();
            this.button_Division = new System.Windows.Forms.Button();
            this.button_Multiplikation = new System.Windows.Forms.Button();
            this.button_Subtraktion = new System.Windows.Forms.Button();
            this.button_Addition = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Ergebnis = new System.Windows.Forms.TextBox();
            this.textBox_Operand2 = new System.Windows.Forms.TextBox();
            this.textBox_Operand1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Restwert
            // 
            this.button_Restwert.Location = new System.Drawing.Point(256, 61);
            this.button_Restwert.Name = "button_Restwert";
            this.button_Restwert.Size = new System.Drawing.Size(75, 23);
            this.button_Restwert.TabIndex = 21;
            this.button_Restwert.Text = "%";
            this.button_Restwert.UseVisualStyleBackColor = true;
            this.button_Restwert.Click += new System.EventHandler(this.button_Restwert_Click);
            // 
            // button_Division
            // 
            this.button_Division.Location = new System.Drawing.Point(173, 61);
            this.button_Division.Name = "button_Division";
            this.button_Division.Size = new System.Drawing.Size(75, 23);
            this.button_Division.TabIndex = 20;
            this.button_Division.Text = "/";
            this.button_Division.UseVisualStyleBackColor = true;
            this.button_Division.Click += new System.EventHandler(this.button_Division_Click);
            // 
            // button_Multiplikation
            // 
            this.button_Multiplikation.Location = new System.Drawing.Point(173, 36);
            this.button_Multiplikation.Name = "button_Multiplikation";
            this.button_Multiplikation.Size = new System.Drawing.Size(75, 23);
            this.button_Multiplikation.TabIndex = 19;
            this.button_Multiplikation.Text = "*";
            this.button_Multiplikation.UseVisualStyleBackColor = true;
            this.button_Multiplikation.Click += new System.EventHandler(this.button_Multiplikation_Click);
            // 
            // button_Subtraktion
            // 
            this.button_Subtraktion.Location = new System.Drawing.Point(256, 10);
            this.button_Subtraktion.Name = "button_Subtraktion";
            this.button_Subtraktion.Size = new System.Drawing.Size(75, 23);
            this.button_Subtraktion.TabIndex = 18;
            this.button_Subtraktion.Text = "-";
            this.button_Subtraktion.UseVisualStyleBackColor = true;
            this.button_Subtraktion.Click += new System.EventHandler(this.button_Subtraktion_Click);
            // 
            // button_Addition
            // 
            this.button_Addition.Location = new System.Drawing.Point(173, 10);
            this.button_Addition.Name = "button_Addition";
            this.button_Addition.Size = new System.Drawing.Size(75, 23);
            this.button_Addition.TabIndex = 17;
            this.button_Addition.Text = "+";
            this.button_Addition.UseVisualStyleBackColor = true;
            this.button_Addition.Click += new System.EventHandler(this.button_Addition_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ergebnis:";
            // 
            // textBox_Ergebnis
            // 
            this.textBox_Ergebnis.Location = new System.Drawing.Point(67, 64);
            this.textBox_Ergebnis.Name = "textBox_Ergebnis";
            this.textBox_Ergebnis.ReadOnly = true;
            this.textBox_Ergebnis.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ergebnis.TabIndex = 15;
            // 
            // textBox_Operand2
            // 
            this.textBox_Operand2.Location = new System.Drawing.Point(67, 38);
            this.textBox_Operand2.Name = "textBox_Operand2";
            this.textBox_Operand2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Operand2.TabIndex = 14;
            this.textBox_Operand2.TextChanged += new System.EventHandler(this.textBox_Operand2_TextChanged);
            // 
            // textBox_Operand1
            // 
            this.textBox_Operand1.Location = new System.Drawing.Point(67, 12);
            this.textBox_Operand1.Name = "textBox_Operand1";
            this.textBox_Operand1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Operand1.TabIndex = 13;
            this.textBox_Operand1.TextChanged += new System.EventHandler(this.textBox_Operand1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Zahl 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zahl 1:";
            // 
            // Taschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 101);
            this.Controls.Add(this.button_Restwert);
            this.Controls.Add(this.button_Division);
            this.Controls.Add(this.button_Multiplikation);
            this.Controls.Add(this.button_Subtraktion);
            this.Controls.Add(this.button_Addition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Ergebnis);
            this.Controls.Add(this.textBox_Operand2);
            this.Controls.Add(this.textBox_Operand1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Taschenrechner";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Restwert;
        private System.Windows.Forms.Button button_Division;
        private System.Windows.Forms.Button button_Multiplikation;
        private System.Windows.Forms.Button button_Subtraktion;
        private System.Windows.Forms.Button button_Addition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Ergebnis;
        private System.Windows.Forms.TextBox textBox_Operand2;
        private System.Windows.Forms.TextBox textBox_Operand1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

