namespace R09546014HungYLAss11PSO
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.theChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonRunToEnd = new System.Windows.Forms.Button();
            this.buttonRunOneIteration = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.propertyGridPSOsetting = new System.Windows.Forms.PropertyGrid();
            this.btnCreatePSOsolver = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNewProblem = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 48);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainerMain.Size = new System.Drawing.Size(725, 407);
            this.splitContainerMain.SplitterDistance = 240;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonRunToEnd);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRunOneIteration);
            this.splitContainer1.Panel2.Controls.Add(this.buttonReset);
            this.splitContainer1.Panel2.Controls.Add(this.propertyGridPSOsetting);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreatePSOsolver);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Size = new System.Drawing.Size(483, 407);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.theChart);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer2.Size = new System.Drawing.Size(292, 407);
            this.splitContainer2.SplitterDistance = 188;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // theChart
            // 
            chartArea1.Name = "ChartArea1";
            this.theChart.ChartAreas.Add(chartArea1);
            this.theChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.theChart.Legends.Add(legend1);
            this.theChart.Location = new System.Drawing.Point(0, 0);
            this.theChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.theChart.Name = "theChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.theChart.Series.Add(series1);
            this.theChart.Size = new System.Drawing.Size(292, 188);
            this.theChart.TabIndex = 0;
            this.theChart.Text = "chart1";
            // 
            // buttonRunToEnd
            // 
            this.buttonRunToEnd.Location = new System.Drawing.Point(20, 110);
            this.buttonRunToEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRunToEnd.Name = "buttonRunToEnd";
            this.buttonRunToEnd.Size = new System.Drawing.Size(147, 31);
            this.buttonRunToEnd.TabIndex = 7;
            this.buttonRunToEnd.Text = "Run To End";
            this.buttonRunToEnd.UseVisualStyleBackColor = true;
            this.buttonRunToEnd.Click += new System.EventHandler(this.buttonRunToEnd_Click);
            // 
            // buttonRunOneIteration
            // 
            this.buttonRunOneIteration.Location = new System.Drawing.Point(20, 74);
            this.buttonRunOneIteration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRunOneIteration.Name = "buttonRunOneIteration";
            this.buttonRunOneIteration.Size = new System.Drawing.Size(147, 31);
            this.buttonRunOneIteration.TabIndex = 6;
            this.buttonRunOneIteration.Text = "Run One Iteration";
            this.buttonRunOneIteration.UseVisualStyleBackColor = true;
            this.buttonRunOneIteration.Click += new System.EventHandler(this.buttonRunOneIteration_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(20, 39);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(147, 31);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // propertyGridPSOsetting
            // 
            this.propertyGridPSOsetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridPSOsetting.Location = new System.Drawing.Point(0, 141);
            this.propertyGridPSOsetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.propertyGridPSOsetting.Name = "propertyGridPSOsetting";
            this.propertyGridPSOsetting.Size = new System.Drawing.Size(188, 266);
            this.propertyGridPSOsetting.TabIndex = 3;
            // 
            // btnCreatePSOsolver
            // 
            this.btnCreatePSOsolver.Location = new System.Drawing.Point(20, 0);
            this.btnCreatePSOsolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreatePSOsolver.Name = "btnCreatePSOsolver";
            this.btnCreatePSOsolver.Size = new System.Drawing.Size(147, 31);
            this.btnCreatePSOsolver.TabIndex = 2;
            this.btnCreatePSOsolver.Text = "Create PSO solver";
            this.btnCreatePSOsolver.UseVisualStyleBackColor = true;
            this.btnCreatePSOsolver.Click += new System.EventHandler(this.btnCreatePSOsolver_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(188, 141);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(-4, 8);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(50, 25);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNewProblem
            // 
            this.btnNewProblem.Location = new System.Drawing.Point(73, 8);
            this.btnNewProblem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewProblem.Name = "btnNewProblem";
            this.btnNewProblem.Size = new System.Drawing.Size(114, 25);
            this.btnNewProblem.TabIndex = 1;
            this.btnNewProblem.Text = "New Problem";
            this.btnNewProblem.UseVisualStyleBackColor = true;
            this.btnNewProblem.Click += new System.EventHandler(this.btnNewProblem_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(725, 48);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 455);
            this.Controls.Add(this.btnNewProblem);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.splitter2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnNewProblem;
        private System.Windows.Forms.Button btnCreatePSOsolver;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PropertyGrid propertyGridPSOsetting;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRunOneIteration;
        private System.Windows.Forms.Button buttonRunToEnd;
        private System.Windows.Forms.DataVisualization.Charting.Chart theChart;
    }
}

