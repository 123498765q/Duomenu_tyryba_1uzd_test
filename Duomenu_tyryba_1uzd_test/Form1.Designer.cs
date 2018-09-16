namespace Duomenu_tyryba_1uzd_test
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
            this.vAll = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.vartotojoKaina = new System.Windows.Forms.TextBox();
            this.vartotojoAtstumas = new System.Windows.Forms.TextBox();
            this.vartotojoRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vAll
            // 
            this.vAll.AutoSize = true;
            this.vAll.Location = new System.Drawing.Point(73, 175);
            this.vAll.Name = "vAll";
            this.vAll.Size = new System.Drawing.Size(0, 17);
            this.vAll.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1039, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viešbučiai mieste";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(467, 263);
            this.Calculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(179, 28);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Rasti optimaliausią";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // vartotojoKaina
            // 
            this.vartotojoKaina.Location = new System.Drawing.Point(92, 186);
            this.vartotojoKaina.Name = "vartotojoKaina";
            this.vartotojoKaina.Size = new System.Drawing.Size(100, 22);
            this.vartotojoKaina.TabIndex = 3;
            // 
            // vartotojoAtstumas
            // 
            this.vartotojoAtstumas.Location = new System.Drawing.Point(92, 227);
            this.vartotojoAtstumas.Name = "vartotojoAtstumas";
            this.vartotojoAtstumas.Size = new System.Drawing.Size(100, 22);
            this.vartotojoAtstumas.TabIndex = 4;
            // 
            // vartotojoRate
            // 
            this.vartotojoRate.Location = new System.Drawing.Point(92, 269);
            this.vartotojoRate.Name = "vartotojoRate";
            this.vartotojoRate.Size = new System.Drawing.Size(100, 22);
            this.vartotojoRate.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 514);
            this.Controls.Add(this.vartotojoRate);
            this.Controls.Add(this.vartotojoAtstumas);
            this.Controls.Add(this.vartotojoKaina);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vAll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox vartotojoKaina;
        private System.Windows.Forms.TextBox vartotojoAtstumas;
        private System.Windows.Forms.TextBox vartotojoRate;
    }
}

