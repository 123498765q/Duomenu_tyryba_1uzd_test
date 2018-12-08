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
            this.Calculate = new System.Windows.Forms.Button();
            this.HotelsData = new System.Windows.Forms.ListView();
            this.txt_optimalManhattan = new System.Windows.Forms.Label();
            this.txt_optimalEuclidean = new System.Windows.Forms.Label();
            this.price_CB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stars_CB = new System.Windows.Forms.ComboBox();
            this.Pageidavimai = new System.Windows.Forms.GroupBox();
            this.virtuve_C = new System.Windows.Forms.CheckBox();
            this.kacialka_C = new System.Windows.Forms.CheckBox();
            this.parkingas_C = new System.Windows.Forms.CheckBox();
            this.minibaras_C = new System.Windows.Forms.CheckBox();
            this.gyvunai_C = new System.Windows.Forms.CheckBox();
            this.neigaliems_C = new System.Windows.Forms.CheckBox();
            this.kondicionierius_C = new System.Windows.Forms.CheckBox();
            this.wifi_C = new System.Windows.Forms.CheckBox();
            this.balkonas_C = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rate_CB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.meals_CB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.distance_CB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Pageidavimai.SuspendLayout();
            this.SuspendLayout();
            // 
            // vAll
            // 
            this.vAll.AutoSize = true;
            this.vAll.Location = new System.Drawing.Point(1, 283);
            this.vAll.Name = "vAll";
            this.vAll.Size = new System.Drawing.Size(0, 17);
            this.vAll.TabIndex = 0;
            // 
            // Calculate
            // 
            this.Calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(759, 840);
            this.Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(205, 39);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Rasti optimaliausią";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // HotelsData
            // 
            this.HotelsData.Location = new System.Drawing.Point(12, 12);
            this.HotelsData.Name = "HotelsData";
            this.HotelsData.Size = new System.Drawing.Size(1999, 569);
            this.HotelsData.TabIndex = 13;
            this.HotelsData.UseCompatibleStateImageBehavior = false;
            // 
            // txt_optimalManhattan
            // 
            this.txt_optimalManhattan.AutoSize = true;
            this.txt_optimalManhattan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_optimalManhattan.Location = new System.Drawing.Point(1036, 611);
            this.txt_optimalManhattan.Name = "txt_optimalManhattan";
            this.txt_optimalManhattan.Size = new System.Drawing.Size(110, 20);
            this.txt_optimalManhattan.TabIndex = 14;
            this.txt_optimalManhattan.Text = "Manhatanas";
            // 
            // txt_optimalEuclidean
            // 
            this.txt_optimalEuclidean.AutoSize = true;
            this.txt_optimalEuclidean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_optimalEuclidean.Location = new System.Drawing.Point(1424, 614);
            this.txt_optimalEuclidean.Name = "txt_optimalEuclidean";
            this.txt_optimalEuclidean.Size = new System.Drawing.Size(80, 20);
            this.txt_optimalEuclidean.TabIndex = 15;
            this.txt_optimalEuclidean.Text = "Euklidas";
            // 
            // price_CB
            // 
            this.price_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.price_CB.FormattingEnabled = true;
            this.price_CB.Items.AddRange(new object[] {
            "30 - 50 €",
            "50 - 130 €",
            "130 - 200 €",
            "200 - 300 €",
            "300 € ir daugiau"});
            this.price_CB.Location = new System.Drawing.Point(22, 54);
            this.price_CB.Name = "price_CB";
            this.price_CB.Size = new System.Drawing.Size(121, 24);
            this.price_CB.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kaina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Reitingas";
            // 
            // stars_CB
            // 
            this.stars_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stars_CB.FormattingEnabled = true;
            this.stars_CB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.stars_CB.Location = new System.Drawing.Point(213, 54);
            this.stars_CB.Name = "stars_CB";
            this.stars_CB.Size = new System.Drawing.Size(121, 24);
            this.stars_CB.TabIndex = 18;
            // 
            // Pageidavimai
            // 
            this.Pageidavimai.Controls.Add(this.virtuve_C);
            this.Pageidavimai.Controls.Add(this.kacialka_C);
            this.Pageidavimai.Controls.Add(this.parkingas_C);
            this.Pageidavimai.Controls.Add(this.minibaras_C);
            this.Pageidavimai.Controls.Add(this.gyvunai_C);
            this.Pageidavimai.Controls.Add(this.neigaliems_C);
            this.Pageidavimai.Controls.Add(this.kondicionierius_C);
            this.Pageidavimai.Controls.Add(this.wifi_C);
            this.Pageidavimai.Controls.Add(this.balkonas_C);
            this.Pageidavimai.Controls.Add(this.label9);
            this.Pageidavimai.Controls.Add(this.rate_CB);
            this.Pageidavimai.Controls.Add(this.label7);
            this.Pageidavimai.Controls.Add(this.meals_CB);
            this.Pageidavimai.Controls.Add(this.label6);
            this.Pageidavimai.Controls.Add(this.distance_CB);
            this.Pageidavimai.Controls.Add(this.label4);
            this.Pageidavimai.Controls.Add(this.label5);
            this.Pageidavimai.Controls.Add(this.price_CB);
            this.Pageidavimai.Controls.Add(this.stars_CB);
            this.Pageidavimai.Location = new System.Drawing.Point(12, 599);
            this.Pageidavimai.Name = "Pageidavimai";
            this.Pageidavimai.Size = new System.Drawing.Size(952, 226);
            this.Pageidavimai.TabIndex = 20;
            this.Pageidavimai.TabStop = false;
            this.Pageidavimai.Text = "Pageidavimai";
            // 
            // virtuve_C
            // 
            this.virtuve_C.AutoSize = true;
            this.virtuve_C.Location = new System.Drawing.Point(328, 142);
            this.virtuve_C.Name = "virtuve_C";
            this.virtuve_C.Size = new System.Drawing.Size(112, 21);
            this.virtuve_C.TabIndex = 34;
            this.virtuve_C.Text = "Mini virtuvėlė";
            this.virtuve_C.UseVisualStyleBackColor = true;
            // 
            // kacialka_C
            // 
            this.kacialka_C.AutoSize = true;
            this.kacialka_C.Location = new System.Drawing.Point(177, 142);
            this.kacialka_C.Name = "kacialka_C";
            this.kacialka_C.Size = new System.Drawing.Size(135, 21);
            this.kacialka_C.TabIndex = 33;
            this.kacialka_C.Text = "Treniruoklių salė";
            this.kacialka_C.UseVisualStyleBackColor = true;
            // 
            // parkingas_C
            // 
            this.parkingas_C.AutoSize = true;
            this.parkingas_C.Location = new System.Drawing.Point(17, 142);
            this.parkingas_C.Name = "parkingas_C";
            this.parkingas_C.Size = new System.Drawing.Size(140, 21);
            this.parkingas_C.TabIndex = 32;
            this.parkingas_C.Text = "Parkavimosi vieta";
            this.parkingas_C.UseVisualStyleBackColor = true;
            // 
            // minibaras_C
            // 
            this.minibaras_C.AutoSize = true;
            this.minibaras_C.Location = new System.Drawing.Point(728, 104);
            this.minibaras_C.Name = "minibaras_C";
            this.minibaras_C.Size = new System.Drawing.Size(91, 21);
            this.minibaras_C.TabIndex = 31;
            this.minibaras_C.Text = "Minibaras";
            this.minibaras_C.UseVisualStyleBackColor = true;
            // 
            // gyvunai_C
            // 
            this.gyvunai_C.AutoSize = true;
            this.gyvunai_C.Location = new System.Drawing.Point(547, 104);
            this.gyvunai_C.Name = "gyvunai_C";
            this.gyvunai_C.Size = new System.Drawing.Size(165, 21);
            this.gyvunai_C.TabIndex = 30;
            this.gyvunai_C.Text = "Leidžiamas augintinis";
            this.gyvunai_C.UseVisualStyleBackColor = true;
            // 
            // neigaliems_C
            // 
            this.neigaliems_C.AutoSize = true;
            this.neigaliems_C.Location = new System.Drawing.Point(359, 104);
            this.neigaliems_C.Name = "neigaliems_C";
            this.neigaliems_C.Size = new System.Drawing.Size(166, 21);
            this.neigaliems_C.TabIndex = 29;
            this.neigaliems_C.Text = "Pritaikytas neįgaliems";
            this.neigaliems_C.UseVisualStyleBackColor = true;
            // 
            // kondicionierius_C
            // 
            this.kondicionierius_C.AutoSize = true;
            this.kondicionierius_C.Location = new System.Drawing.Point(213, 104);
            this.kondicionierius_C.Name = "kondicionierius_C";
            this.kondicionierius_C.Size = new System.Drawing.Size(126, 21);
            this.kondicionierius_C.TabIndex = 28;
            this.kondicionierius_C.Text = "Kondicionierius";
            this.kondicionierius_C.UseVisualStyleBackColor = true;
            // 
            // wifi_C
            // 
            this.wifi_C.AutoSize = true;
            this.wifi_C.Location = new System.Drawing.Point(131, 104);
            this.wifi_C.Name = "wifi_C";
            this.wifi_C.Size = new System.Drawing.Size(62, 21);
            this.wifi_C.TabIndex = 27;
            this.wifi_C.Text = "Wi-Fi";
            this.wifi_C.UseVisualStyleBackColor = true;
            // 
            // balkonas_C
            // 
            this.balkonas_C.AutoSize = true;
            this.balkonas_C.Location = new System.Drawing.Point(17, 104);
            this.balkonas_C.Name = "balkonas_C";
            this.balkonas_C.Size = new System.Drawing.Size(88, 21);
            this.balkonas_C.TabIndex = 26;
            this.balkonas_C.Text = "Balkonas";
            this.balkonas_C.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(786, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Lankytojų balas";
            // 
            // rate_CB
            // 
            this.rate_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rate_CB.FormattingEnabled = true;
            this.rate_CB.Items.AddRange(new object[] {
            "1-2",
            "3-4",
            "5-6",
            "7-8",
            "9-10"});
            this.rate_CB.Location = new System.Drawing.Point(789, 54);
            this.rate_CB.Name = "rate_CB";
            this.rate_CB.Size = new System.Drawing.Size(121, 24);
            this.rate_CB.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(589, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Maitinimas *";
            // 
            // meals_CB
            // 
            this.meals_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.meals_CB.FormattingEnabled = true;
            this.meals_CB.Items.AddRange(new object[] {
            "Nėra",
            "P",
            "P + P",
            "P + P + V",
            "Neribotas maistas"});
            this.meals_CB.Location = new System.Drawing.Point(592, 54);
            this.meals_CB.Name = "meals_CB";
            this.meals_CB.Size = new System.Drawing.Size(121, 24);
            this.meals_CB.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Atsumas iki centro";
            // 
            // distance_CB
            // 
            this.distance_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distance_CB.FormattingEnabled = true;
            this.distance_CB.Items.AddRange(new object[] {
            "1 - 3 km",
            "3 - 5 km",
            "5 - 10 km",
            "10 - 20 km",
            "20 ir daugiau"});
            this.distance_CB.Location = new System.Drawing.Point(404, 54);
            this.distance_CB.Name = "distance_CB";
            this.distance_CB.Size = new System.Drawing.Size(121, 24);
            this.distance_CB.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 828);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 51);
            this.label8.TabIndex = 21;
            this.label8.Text = " *P - pusryčiai \r\n  P + P - pusryčiai + pietūs, \r\n  P + P + V - pusryčiai + pietū" +
    "s + vakarienė";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2048, 928);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Pageidavimai);
            this.Controls.Add(this.txt_optimalEuclidean);
            this.Controls.Add(this.txt_optimalManhattan);
            this.Controls.Add(this.HotelsData);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.vAll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pageidavimai.ResumeLayout(false);
            this.Pageidavimai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vAll;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ListView HotelsData;
        private System.Windows.Forms.Label txt_optimalManhattan;
        private System.Windows.Forms.Label txt_optimalEuclidean;
        private System.Windows.Forms.ComboBox price_CB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox stars_CB;
        private System.Windows.Forms.GroupBox Pageidavimai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox meals_CB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox distance_CB;
        private System.Windows.Forms.CheckBox balkonas_C;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox rate_CB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox wifi_C;
        private System.Windows.Forms.CheckBox minibaras_C;
        private System.Windows.Forms.CheckBox gyvunai_C;
        private System.Windows.Forms.CheckBox neigaliems_C;
        private System.Windows.Forms.CheckBox kondicionierius_C;
        private System.Windows.Forms.CheckBox virtuve_C;
        private System.Windows.Forms.CheckBox kacialka_C;
        private System.Windows.Forms.CheckBox parkingas_C;
    }
}

