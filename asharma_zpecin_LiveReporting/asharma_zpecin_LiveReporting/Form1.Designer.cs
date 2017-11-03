namespace asharma_zpecin_LiveReporting
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.productCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AllProducts_Checkbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TotalPartsModelLabel = new System.Windows.Forms.Label();
            this.TotalPartsSuccessfullyModeledLabel = new System.Windows.Forms.Label();
            this.YieldAtMoldLabel = new System.Windows.Forms.Label();
            this.TotalPartsSuccessfullyPaintedLabel = new System.Windows.Forms.Label();
            this.YieldAtPaintLabel = new System.Windows.Forms.Label();
            this.TotalPartsSuccessfullyAssembeledLabel = new System.Windows.Forms.Label();
            this.YieldAtAssemblyLabel = new System.Windows.Forms.Label();
            this.TotalPartsPackagedLabel = new System.Windows.Forms.Label();
            this.TotalYieldLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(629, 449);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // productCombo
            // 
            this.productCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCombo.FormattingEnabled = true;
            this.productCombo.Location = new System.Drawing.Point(666, 72);
            this.productCombo.Name = "productCombo";
            this.productCombo.Size = new System.Drawing.Size(228, 28);
            this.productCombo.TabIndex = 1;
            this.productCombo.SelectedIndexChanged += new System.EventHandler(this.productCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(666, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generate Report:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(665, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select YOYO:";
            // 
            // AllProducts_Checkbox
            // 
            this.AllProducts_Checkbox.AutoSize = true;
            this.AllProducts_Checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProducts_Checkbox.ForeColor = System.Drawing.Color.Navy;
            this.AllProducts_Checkbox.Location = new System.Drawing.Point(900, 72);
            this.AllProducts_Checkbox.Name = "AllProducts_Checkbox";
            this.AllProducts_Checkbox.Size = new System.Drawing.Size(129, 28);
            this.AllProducts_Checkbox.TabIndex = 4;
            this.AllProducts_Checkbox.Text = "All Products";
            this.AllProducts_Checkbox.UseVisualStyleBackColor = true;
            this.AllProducts_Checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(666, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Parts Molded:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(666, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Parts Successfully Molded:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(669, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yield at Mold:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(668, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total parts successfully Painted:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(668, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Yield at Paint: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(668, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total parts successfully assembled:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(669, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Yield at Assembly:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(669, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Total parts packaged:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(669, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total Yield:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(777, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TotalPartsModelLabel
            // 
            this.TotalPartsModelLabel.AutoSize = true;
            this.TotalPartsModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPartsModelLabel.Location = new System.Drawing.Point(1000, 114);
            this.TotalPartsModelLabel.Name = "TotalPartsModelLabel";
            this.TotalPartsModelLabel.Size = new System.Drawing.Size(19, 20);
            this.TotalPartsModelLabel.TabIndex = 15;
            this.TotalPartsModelLabel.Text = "0";
            // 
            // TotalPartsSuccessfullyModeledLabel
            // 
            this.TotalPartsSuccessfullyModeledLabel.AutoSize = true;
            this.TotalPartsSuccessfullyModeledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPartsSuccessfullyModeledLabel.Location = new System.Drawing.Point(1000, 145);
            this.TotalPartsSuccessfullyModeledLabel.Name = "TotalPartsSuccessfullyModeledLabel";
            this.TotalPartsSuccessfullyModeledLabel.Size = new System.Drawing.Size(19, 20);
            this.TotalPartsSuccessfullyModeledLabel.TabIndex = 16;
            this.TotalPartsSuccessfullyModeledLabel.Text = "0";
            // 
            // YieldAtMoldLabel
            // 
            this.YieldAtMoldLabel.AutoSize = true;
            this.YieldAtMoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YieldAtMoldLabel.Location = new System.Drawing.Point(1000, 174);
            this.YieldAtMoldLabel.Name = "YieldAtMoldLabel";
            this.YieldAtMoldLabel.Size = new System.Drawing.Size(19, 20);
            this.YieldAtMoldLabel.TabIndex = 17;
            this.YieldAtMoldLabel.Text = "0";
            // 
            // TotalPartsSuccessfullyPaintedLabel
            // 
            this.TotalPartsSuccessfullyPaintedLabel.AutoSize = true;
            this.TotalPartsSuccessfullyPaintedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPartsSuccessfullyPaintedLabel.Location = new System.Drawing.Point(1000, 203);
            this.TotalPartsSuccessfullyPaintedLabel.Name = "TotalPartsSuccessfullyPaintedLabel";
            this.TotalPartsSuccessfullyPaintedLabel.Size = new System.Drawing.Size(19, 20);
            this.TotalPartsSuccessfullyPaintedLabel.TabIndex = 18;
            this.TotalPartsSuccessfullyPaintedLabel.Text = "0";
            // 
            // YieldAtPaintLabel
            // 
            this.YieldAtPaintLabel.AutoSize = true;
            this.YieldAtPaintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YieldAtPaintLabel.Location = new System.Drawing.Point(1000, 236);
            this.YieldAtPaintLabel.Name = "YieldAtPaintLabel";
            this.YieldAtPaintLabel.Size = new System.Drawing.Size(19, 20);
            this.YieldAtPaintLabel.TabIndex = 19;
            this.YieldAtPaintLabel.Text = "0";
            // 
            // TotalPartsSuccessfullyAssembeledLabel
            // 
            this.TotalPartsSuccessfullyAssembeledLabel.AutoSize = true;
            this.TotalPartsSuccessfullyAssembeledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPartsSuccessfullyAssembeledLabel.Location = new System.Drawing.Point(1000, 265);
            this.TotalPartsSuccessfullyAssembeledLabel.Name = "TotalPartsSuccessfullyAssembeledLabel";
            this.TotalPartsSuccessfullyAssembeledLabel.Size = new System.Drawing.Size(19, 20);
            this.TotalPartsSuccessfullyAssembeledLabel.TabIndex = 20;
            this.TotalPartsSuccessfullyAssembeledLabel.Text = "0";
            // 
            // YieldAtAssemblyLabel
            // 
            this.YieldAtAssemblyLabel.AutoSize = true;
            this.YieldAtAssemblyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YieldAtAssemblyLabel.Location = new System.Drawing.Point(1000, 298);
            this.YieldAtAssemblyLabel.Name = "YieldAtAssemblyLabel";
            this.YieldAtAssemblyLabel.Size = new System.Drawing.Size(19, 20);
            this.YieldAtAssemblyLabel.TabIndex = 21;
            this.YieldAtAssemblyLabel.Text = "0";
            // 
            // TotalPartsPackagedLabel
            // 
            this.TotalPartsPackagedLabel.AutoSize = true;
            this.TotalPartsPackagedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPartsPackagedLabel.Location = new System.Drawing.Point(1000, 328);
            this.TotalPartsPackagedLabel.Name = "TotalPartsPackagedLabel";
            this.TotalPartsPackagedLabel.Size = new System.Drawing.Size(19, 20);
            this.TotalPartsPackagedLabel.TabIndex = 22;
            this.TotalPartsPackagedLabel.Text = "0";
            // 
            // TotalYieldLabel
            // 
            this.TotalYieldLabel.AutoSize = true;
            this.TotalYieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalYieldLabel.Location = new System.Drawing.Point(1000, 357);
            this.TotalYieldLabel.Name = "TotalYieldLabel";
            this.TotalYieldLabel.Size = new System.Drawing.Size(19, 20);
            this.TotalYieldLabel.TabIndex = 23;
            this.TotalYieldLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 473);
            this.Controls.Add(this.TotalYieldLabel);
            this.Controls.Add(this.TotalPartsPackagedLabel);
            this.Controls.Add(this.YieldAtAssemblyLabel);
            this.Controls.Add(this.TotalPartsSuccessfullyAssembeledLabel);
            this.Controls.Add(this.YieldAtPaintLabel);
            this.Controls.Add(this.TotalPartsSuccessfullyPaintedLabel);
            this.Controls.Add(this.YieldAtMoldLabel);
            this.Controls.Add(this.TotalPartsSuccessfullyModeledLabel);
            this.Controls.Add(this.TotalPartsModelLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AllProducts_Checkbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productCombo);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "asharma_zpecin_ReportGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox productCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AllProducts_Checkbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TotalPartsModelLabel;
        private System.Windows.Forms.Label TotalPartsSuccessfullyModeledLabel;
        private System.Windows.Forms.Label YieldAtMoldLabel;
        private System.Windows.Forms.Label TotalPartsSuccessfullyPaintedLabel;
        private System.Windows.Forms.Label YieldAtPaintLabel;
        private System.Windows.Forms.Label TotalPartsSuccessfullyAssembeledLabel;
        private System.Windows.Forms.Label YieldAtAssemblyLabel;
        private System.Windows.Forms.Label TotalPartsPackagedLabel;
        private System.Windows.Forms.Label TotalYieldLabel;
    }
}

