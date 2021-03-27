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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.theChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTesting = new System.Windows.Forms.Button();
            this.richTextBoxSoFarthebestobjvalue = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSofartheBestSolution = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSnratio = new System.Windows.Forms.RichTextBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnCreateSCAsolver = new System.Windows.Forms.Button();
            this.buttonRunToEnd = new System.Windows.Forms.Button();
            this.buttonRunOneIteration = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.propertyGridPSOsetting = new System.Windows.Forms.PropertyGrid();
            this.btnCreatePSOsolver = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNewProblem = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.labelSofatthebest = new System.Windows.Forms.Label();
            this.labelSofatthebestsoluton = new System.Windows.Forms.Label();
            this.labelSnratio = new System.Windows.Forms.Label();
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
            this.splitContainerMain.Size = new System.Drawing.Size(1123, 639);
            this.splitContainerMain.SplitterDistance = 369;
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
            this.splitContainer1.Panel2.Controls.Add(this.labelSnratio);
            this.splitContainer1.Panel2.Controls.Add(this.labelSofatthebestsoluton);
            this.splitContainer1.Panel2.Controls.Add(this.labelSofatthebest);
            this.splitContainer1.Panel2.Controls.Add(this.btnTesting);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxSoFarthebestobjvalue);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxSofartheBestSolution);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxSnratio);
            this.splitContainer1.Panel2.Controls.Add(this.splitter3);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreateSCAsolver);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRunToEnd);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRunOneIteration);
            this.splitContainer1.Panel2.Controls.Add(this.buttonReset);
            this.splitContainer1.Panel2.Controls.Add(this.propertyGridPSOsetting);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreatePSOsolver);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Size = new System.Drawing.Size(757, 639);
            this.splitContainer1.SplitterDistance = 454;
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
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(454, 639);
            this.splitContainer2.SplitterDistance = 292;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // theChart
            // 
            chartArea2.Name = "ChartArea1";
            this.theChart.ChartAreas.Add(chartArea2);
            this.theChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.theChart.Legends.Add(legend2);
            this.theChart.Location = new System.Drawing.Point(0, 0);
            this.theChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.theChart.Name = "theChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.theChart.Series.Add(series2);
            this.theChart.Size = new System.Drawing.Size(454, 292);
            this.theChart.TabIndex = 0;
            this.theChart.Text = "chart1";
            // 
            // btnTesting
            // 
            this.btnTesting.Location = new System.Drawing.Point(215, 2);
            this.btnTesting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTesting.Name = "btnTesting";
            this.btnTesting.Size = new System.Drawing.Size(85, 31);
            this.btnTesting.TabIndex = 13;
            this.btnTesting.Text = "Testing";
            this.btnTesting.UseVisualStyleBackColor = true;
            this.btnTesting.Click += new System.EventHandler(this.btnTesting_Click);
            // 
            // richTextBoxSoFarthebestobjvalue
            // 
            this.richTextBoxSoFarthebestobjvalue.Location = new System.Drawing.Point(0, 381);
            this.richTextBoxSoFarthebestobjvalue.Name = "richTextBoxSoFarthebestobjvalue";
            this.richTextBoxSoFarthebestobjvalue.Size = new System.Drawing.Size(341, 33);
            this.richTextBoxSoFarthebestobjvalue.TabIndex = 11;
            this.richTextBoxSoFarthebestobjvalue.Text = "";
            this.richTextBoxSoFarthebestobjvalue.TextChanged += new System.EventHandler(this.richTextBoxSoFarthebestobjvalue_TextChanged);
            // 
            // richTextBoxSofartheBestSolution
            // 
            this.richTextBoxSofartheBestSolution.Location = new System.Drawing.Point(2, 441);
            this.richTextBoxSofartheBestSolution.Name = "richTextBoxSofartheBestSolution";
            this.richTextBoxSofartheBestSolution.Size = new System.Drawing.Size(310, 85);
            this.richTextBoxSofartheBestSolution.TabIndex = 10;
            this.richTextBoxSofartheBestSolution.Text = "";
            this.richTextBoxSofartheBestSolution.TextChanged += new System.EventHandler(this.richTextBoxSofartheBestSolution_TextChanged);
            // 
            // richTextBoxSnratio
            // 
            this.richTextBoxSnratio.Location = new System.Drawing.Point(6, 558);
            this.richTextBoxSnratio.Name = "richTextBoxSnratio";
            this.richTextBoxSnratio.Size = new System.Drawing.Size(307, 79);
            this.richTextBoxSnratio.TabIndex = 9;
            this.richTextBoxSnratio.Text = "";
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(0, 409);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(300, 230);
            this.splitter3.TabIndex = 9;
            this.splitter3.TabStop = false;
            // 
            // btnCreateSCAsolver
            // 
            this.btnCreateSCAsolver.Location = new System.Drawing.Point(120, 0);
            this.btnCreateSCAsolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateSCAsolver.Name = "btnCreateSCAsolver";
            this.btnCreateSCAsolver.Size = new System.Drawing.Size(85, 31);
            this.btnCreateSCAsolver.TabIndex = 8;
            this.btnCreateSCAsolver.Text = "Create SCA solver";
            this.btnCreateSCAsolver.UseVisualStyleBackColor = true;
            this.btnCreateSCAsolver.Click += new System.EventHandler(this.btnCreateSCAsolver_Click);
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
            this.propertyGridPSOsetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertyGridPSOsetting.Location = new System.Drawing.Point(0, 141);
            this.propertyGridPSOsetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.propertyGridPSOsetting.Name = "propertyGridPSOsetting";
            this.propertyGridPSOsetting.Size = new System.Drawing.Size(300, 223);
            this.propertyGridPSOsetting.TabIndex = 3;
            // 
            // btnCreatePSOsolver
            // 
            this.btnCreatePSOsolver.Location = new System.Drawing.Point(20, 0);
            this.btnCreatePSOsolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreatePSOsolver.Name = "btnCreatePSOsolver";
            this.btnCreatePSOsolver.Size = new System.Drawing.Size(85, 31);
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
            this.splitter1.Size = new System.Drawing.Size(300, 141);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(0, 8);
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
            this.splitter2.Size = new System.Drawing.Size(1123, 48);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // labelSofatthebest
            // 
            this.labelSofatthebest.AutoSize = true;
            this.labelSofatthebest.Location = new System.Drawing.Point(3, 366);
            this.labelSofatthebest.Name = "labelSofatthebest";
            this.labelSofatthebest.Size = new System.Drawing.Size(114, 12);
            this.labelSofatthebest.TabIndex = 14;
            this.labelSofatthebest.Text = "So far the best objvalue";
            // 
            // labelSofatthebestsoluton
            // 
            this.labelSofatthebestsoluton.AutoSize = true;
            this.labelSofatthebestsoluton.Location = new System.Drawing.Point(2, 426);
            this.labelSofatthebestsoluton.Name = "labelSofatthebestsoluton";
            this.labelSofatthebestsoluton.Size = new System.Drawing.Size(111, 12);
            this.labelSofatthebestsoluton.TabIndex = 15;
            this.labelSofatthebestsoluton.Text = "So far the best solution";
            // 
            // labelSnratio
            // 
            this.labelSnratio.AutoSize = true;
            this.labelSnratio.Location = new System.Drawing.Point(4, 543);
            this.labelSnratio.Name = "labelSnratio";
            this.labelSnratio.Size = new System.Drawing.Size(43, 12);
            this.labelSnratio.TabIndex = 16;
            this.labelSnratio.Text = "SN ratio";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 687);
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
            this.splitContainer1.Panel2.PerformLayout();
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
        private System.Windows.Forms.Button btnCreateSCAsolver;
        private System.Windows.Forms.RichTextBox richTextBoxSnratio;
        private System.Windows.Forms.RichTextBox richTextBoxSofartheBestSolution;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.RichTextBox richTextBoxSoFarthebestobjvalue;
        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.Label labelSnratio;
        private System.Windows.Forms.Label labelSofatthebestsoluton;
        private System.Windows.Forms.Label labelSofatthebest;
    }
}

