namespace R09546014YLHungAss02
{
    partial class Mainform
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.listBoxFunction = new System.Windows.Forms.ListBox();
            this.label0 = new System.Windows.Forms.Label();
            this.nudPar3 = new System.Windows.Forms.NumericUpDown();
            this.nudPar2 = new System.Windows.Forms.NumericUpDown();
            this.nudPar1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TheChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownAxisXmin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAxisYmin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAxisXmax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAxisYmax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxisXmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxisYmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxisXmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxisYmax)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFunction
            // 
            this.listBoxFunction.FormattingEnabled = true;
            this.listBoxFunction.ItemHeight = 16;
            this.listBoxFunction.Items.AddRange(new object[] {
            "Triangular Function",
            "Bell Function",
            "Gaussian Fucntion",
            "Sigmoid Function"});
            this.listBoxFunction.Location = new System.Drawing.Point(311, 61);
            this.listBoxFunction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxFunction.Name = "listBoxFunction";
            this.listBoxFunction.Size = new System.Drawing.Size(247, 116);
            this.listBoxFunction.TabIndex = 1;
            this.listBoxFunction.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(308, 31);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(115, 16);
            this.label0.TabIndex = 3;
            this.label0.Text = "Available function";
            this.label0.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudPar3
            // 
            this.nudPar3.DecimalPlaces = 1;
            this.nudPar3.Location = new System.Drawing.Point(134, 149);
            this.nudPar3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudPar3.Name = "nudPar3";
            this.nudPar3.Size = new System.Drawing.Size(120, 23);
            this.nudPar3.TabIndex = 4;
            // 
            // nudPar2
            // 
            this.nudPar2.DecimalPlaces = 1;
            this.nudPar2.Location = new System.Drawing.Point(134, 105);
            this.nudPar2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudPar2.Name = "nudPar2";
            this.nudPar2.Size = new System.Drawing.Size(120, 23);
            this.nudPar2.TabIndex = 5;
            this.nudPar2.ValueChanged += new System.EventHandler(this.nudPar2_ValueChanged);
            // 
            // nudPar1
            // 
            this.nudPar1.DecimalPlaces = 1;
            this.nudPar1.Location = new System.Drawing.Point(134, 63);
            this.nudPar1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudPar1.Name = "nudPar1";
            this.nudPar1.Size = new System.Drawing.Size(120, 23);
            this.nudPar1.TabIndex = 6;
            this.nudPar1.ValueChanged += new System.EventHandler(this.nudPar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label4_Click);
            // 
            // TheChart
            // 
            chartArea1.Name = "ChartArea1";
            this.TheChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TheChart.Legends.Add(legend1);
            this.TheChart.Location = new System.Drawing.Point(134, 236);
            this.TheChart.Name = "TheChart";
            this.TheChart.Size = new System.Drawing.Size(455, 300);
            this.TheChart.TabIndex = 10;
            this.TheChart.Text = "TheChart";
            this.TheChart.MouseHover += new System.EventHandler(this.TheChart_MouseHover);
            //// 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(605, 61);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create function";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.CreateButtonClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "AxisX";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(740, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "AxisY";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(591, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Max";
            // 
            // numericUpDownAxisXmin
            // 
            this.numericUpDownAxisXmin.DecimalPlaces = 1;
            this.numericUpDownAxisXmin.Location = new System.Drawing.Point(643, 406);
            this.numericUpDownAxisXmin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownAxisXmin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownAxisXmin.Name = "numericUpDownAxisXmin";
            this.numericUpDownAxisXmin.Size = new System.Drawing.Size(59, 23);
            this.numericUpDownAxisXmin.TabIndex = 20;
            this.numericUpDownAxisXmin.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownAxisXmin.ValueChanged += new System.EventHandler(this.numericUpDownAxisXmin_ValueChanged);
            // 
            // numericUpDownAxisYmin
            // 
            this.numericUpDownAxisYmin.DecimalPlaces = 1;
            this.numericUpDownAxisYmin.Location = new System.Drawing.Point(743, 406);
            this.numericUpDownAxisYmin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownAxisYmin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownAxisYmin.Name = "numericUpDownAxisYmin";
            this.numericUpDownAxisYmin.Size = new System.Drawing.Size(59, 23);
            this.numericUpDownAxisYmin.TabIndex = 21;
            // 
            // numericUpDownAxisXmax
            // 
            this.numericUpDownAxisXmax.DecimalPlaces = 1;
            this.numericUpDownAxisXmax.Location = new System.Drawing.Point(643, 444);
            this.numericUpDownAxisXmax.Name = "numericUpDownAxisXmax";
            this.numericUpDownAxisXmax.Size = new System.Drawing.Size(59, 23);
            this.numericUpDownAxisXmax.TabIndex = 22;
            this.numericUpDownAxisXmax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownAxisYmax
            // 
            this.numericUpDownAxisYmax.DecimalPlaces = 1;
            this.numericUpDownAxisYmax.Location = new System.Drawing.Point(743, 444);
            this.numericUpDownAxisYmax.Name = "numericUpDownAxisYmax";
            this.numericUpDownAxisYmax.Size = new System.Drawing.Size(59, 23);
            this.numericUpDownAxisYmax.TabIndex = 23;
            this.numericUpDownAxisYmax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 600);
            this.Controls.Add(this.numericUpDownAxisYmax);
            this.Controls.Add(this.numericUpDownAxisXmax);
            this.Controls.Add(this.numericUpDownAxisYmin);
            this.Controls.Add(this.numericUpDownAxisXmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.TheChart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPar1);
            this.Controls.Add(this.nudPar2);
            this.Controls.Add(this.nudPar3);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.listBoxFunction);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxisXmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxisYmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxisXmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxisYmax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFunction;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.NumericUpDown nudPar3;
        private System.Windows.Forms.NumericUpDown nudPar2;
        private System.Windows.Forms.NumericUpDown nudPar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart TheChart;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownAxisXmin;
        private System.Windows.Forms.NumericUpDown numericUpDownAxisYmin;
        private System.Windows.Forms.NumericUpDown numericUpDownAxisXmax;
        private System.Windows.Forms.NumericUpDown numericUpDownAxisYmax;
    }
}

