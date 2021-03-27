namespace R09546014YLHungAss01
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnDrawgFunction = new System.Windows.Forms.Button();
            this.textBoxCenter = new System.Windows.Forms.TextBox();
            this.txtcenter = new System.Windows.Forms.Label();
            this.txtsigma = new System.Windows.Forms.Label();
            this.textBoxSigma = new System.Windows.Forms.TextBox();
            this.Thechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButtonTfunction = new System.Windows.Forms.RadioButton();
            this.radioButtonGfunction = new System.Windows.Forms.RadioButton();
            this.radioButtonBfunction = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxC_Bfunction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxB_Bfunction = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxA_Bfunction = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Thechart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDrawgFunction
            // 
            this.btnDrawgFunction.Location = new System.Drawing.Point(85, 223);
            this.btnDrawgFunction.Name = "btnDrawgFunction";
            this.btnDrawgFunction.Size = new System.Drawing.Size(190, 23);
            this.btnDrawgFunction.TabIndex = 0;
            this.btnDrawgFunction.Text = "Draw  fuction";
            this.btnDrawgFunction.UseVisualStyleBackColor = true;
            this.btnDrawgFunction.Click += new System.EventHandler(this.btnDrawgFunction_Click);
            // 
            // textBoxCenter
            // 
            this.textBoxCenter.Location = new System.Drawing.Point(340, 73);
            this.textBoxCenter.Name = "textBoxCenter";
            this.textBoxCenter.Size = new System.Drawing.Size(130, 29);
            this.textBoxCenter.TabIndex = 1;
            this.textBoxCenter.Text = "5.0";
            this.textBoxCenter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtcenter
            // 
            this.txtcenter.AutoSize = true;
            this.txtcenter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcenter.Location = new System.Drawing.Point(277, 76);
            this.txtcenter.Name = "txtcenter";
            this.txtcenter.Size = new System.Drawing.Size(16, 18);
            this.txtcenter.TabIndex = 2;
            this.txtcenter.Text = "c";
            // 
            // txtsigma
            // 
            this.txtsigma.AutoSize = true;
            this.txtsigma.Location = new System.Drawing.Point(277, 111);
            this.txtsigma.Name = "txtsigma";
            this.txtsigma.Size = new System.Drawing.Size(49, 18);
            this.txtsigma.TabIndex = 5;
            this.txtsigma.Text = "sigma";
            // 
            // textBoxSigma
            // 
            this.textBoxSigma.Location = new System.Drawing.Point(340, 108);
            this.textBoxSigma.Name = "textBoxSigma";
            this.textBoxSigma.Size = new System.Drawing.Size(130, 29);
            this.textBoxSigma.TabIndex = 4;
            this.textBoxSigma.Text = "2.0";
            // 
            // Thechart
            // 
            chartArea3.Name = "ChartArea1";
            this.Thechart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Thechart.Legends.Add(legend3);
            this.Thechart.Location = new System.Drawing.Point(85, 252);
            this.Thechart.Name = "Thechart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.Blue;
            series3.Name = "Series1";
            this.Thechart.Series.Add(series3);
            this.Thechart.Size = new System.Drawing.Size(480, 300);
            this.Thechart.TabIndex = 6;
            this.Thechart.Text = "chart1";
            this.Thechart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // radioButtonTfunction
            // 
            this.radioButtonTfunction.AutoSize = true;
            this.radioButtonTfunction.Location = new System.Drawing.Point(85, 27);
            this.radioButtonTfunction.Name = "radioButtonTfunction";
            this.radioButtonTfunction.Size = new System.Drawing.Size(99, 22);
            this.radioButtonTfunction.TabIndex = 7;
            this.radioButtonTfunction.TabStop = true;
            this.radioButtonTfunction.Text = "t function";
            this.radioButtonTfunction.UseVisualStyleBackColor = true;
            // 
            // radioButtonGfunction
            // 
            this.radioButtonGfunction.AutoSize = true;
            this.radioButtonGfunction.Location = new System.Drawing.Point(340, 27);
            this.radioButtonGfunction.Name = "radioButtonGfunction";
            this.radioButtonGfunction.Size = new System.Drawing.Size(102, 22);
            this.radioButtonGfunction.TabIndex = 8;
            this.radioButtonGfunction.TabStop = true;
            this.radioButtonGfunction.Text = "g function";
            this.radioButtonGfunction.UseVisualStyleBackColor = true;
            // 
            // radioButtonBfunction
            // 
            this.radioButtonBfunction.AutoSize = true;
            this.radioButtonBfunction.Location = new System.Drawing.Point(602, 27);
            this.radioButtonBfunction.Name = "radioButtonBfunction";
            this.radioButtonBfunction.Size = new System.Drawing.Size(102, 22);
            this.radioButtonBfunction.TabIndex = 9;
            this.radioButtonBfunction.TabStop = true;
            this.radioButtonBfunction.Text = "b function";
            this.radioButtonBfunction.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "b";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(85, 108);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(130, 29);
            this.textBoxB.TabIndex = 12;
            this.textBoxB.Text = "1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "a";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(85, 73);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(130, 29);
            this.textBoxA.TabIndex = 10;
            this.textBoxA.Text = "0.0";
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "c";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(85, 143);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(130, 29);
            this.textBoxC.TabIndex = 14;
            this.textBoxC.Text = "2.0";
            this.textBoxC.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "c";
            // 
            // textBoxC_Bfunction
            // 
            this.textBoxC_Bfunction.Location = new System.Drawing.Point(602, 135);
            this.textBoxC_Bfunction.Name = "textBoxC_Bfunction";
            this.textBoxC_Bfunction.Size = new System.Drawing.Size(130, 29);
            this.textBoxC_Bfunction.TabIndex = 20;
            this.textBoxC_Bfunction.Text = "2.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "b";
            // 
            // textBoxB_Bfunction
            // 
            this.textBoxB_Bfunction.Location = new System.Drawing.Point(602, 100);
            this.textBoxB_Bfunction.Name = "textBoxB_Bfunction";
            this.textBoxB_Bfunction.Size = new System.Drawing.Size(130, 29);
            this.textBoxB_Bfunction.TabIndex = 18;
            this.textBoxB_Bfunction.Text = "2.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Location = new System.Drawing.Point(539, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "a";
            // 
            // textBoxA_Bfunction
            // 
            this.textBoxA_Bfunction.Location = new System.Drawing.Point(602, 65);
            this.textBoxA_Bfunction.Name = "textBoxA_Bfunction";
            this.textBoxA_Bfunction.Size = new System.Drawing.Size(130, 29);
            this.textBoxA_Bfunction.TabIndex = 16;
            this.textBoxA_Bfunction.Text = "5.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 676);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxC_Bfunction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxB_Bfunction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxA_Bfunction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.radioButtonBfunction);
            this.Controls.Add(this.radioButtonGfunction);
            this.Controls.Add(this.radioButtonTfunction);
            this.Controls.Add(this.Thechart);
            this.Controls.Add(this.txtsigma);
            this.Controls.Add(this.textBoxSigma);
            this.Controls.Add(this.txtcenter);
            this.Controls.Add(this.textBoxCenter);
            this.Controls.Add(this.btnDrawgFunction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Thechart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDrawgFunction;
        private System.Windows.Forms.TextBox textBoxCenter;
        private System.Windows.Forms.Label txtcenter;
        private System.Windows.Forms.Label txtsigma;
        private System.Windows.Forms.TextBox textBoxSigma;
        private System.Windows.Forms.DataVisualization.Charting.Chart Thechart;
        private System.Windows.Forms.RadioButton radioButtonTfunction;
        private System.Windows.Forms.RadioButton radioButtonGfunction;
        private System.Windows.Forms.RadioButton radioButtonBfunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxC_Bfunction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxB_Bfunction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxA_Bfunction;
    }
}

