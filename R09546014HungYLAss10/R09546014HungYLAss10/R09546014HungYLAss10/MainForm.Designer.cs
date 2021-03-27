namespace R09546014HungYLAss10
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
            this.buttonOpenTSP = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRunToEnd = new System.Windows.Forms.Button();
            this.btnRunOneItr = new System.Windows.Forms.Button();
            this.propertyGridSetting = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnCreateACSsolver = new System.Windows.Forms.Button();
            this.labelKnownBestObjvalue = new System.Windows.Forms.Label();
            this.spcfourth = new System.Windows.Forms.SplitContainer();
            this.theChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageShow = new System.Windows.Forms.TabPage();
            this.tabControlAns = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.checkBoxPheromone = new System.Windows.Forms.CheckBox();
            this.richTextBoxPheromoneMap = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.checkBoxSol = new System.Windows.Forms.CheckBox();
            this.richTextBoxShowSolution = new System.Windows.Forms.RichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainerBestSol = new System.Windows.Forms.SplitContainer();
            this.labelSofarthebestSol = new System.Windows.Forms.Label();
            this.richTextBoxbestSol = new System.Windows.Forms.RichTextBox();
            this.labelShortestLength = new System.Windows.Forms.Label();
            this.richTextBoxShortestLength = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcfourth)).BeginInit();
            this.spcfourth.Panel1.SuspendLayout();
            this.spcfourth.Panel2.SuspendLayout();
            this.spcfourth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageShow.SuspendLayout();
            this.tabControlAns.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBestSol)).BeginInit();
            this.splitContainerBestSol.Panel1.SuspendLayout();
            this.splitContainerBestSol.Panel2.SuspendLayout();
            this.splitContainerBestSol.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenTSP
            // 
            this.buttonOpenTSP.Location = new System.Drawing.Point(0, 28);
            this.buttonOpenTSP.Name = "buttonOpenTSP";
            this.buttonOpenTSP.Size = new System.Drawing.Size(109, 36);
            this.buttonOpenTSP.TabIndex = 0;
            this.buttonOpenTSP.Text = "Open TSP";
            this.buttonOpenTSP.UseVisualStyleBackColor = true;
            this.buttonOpenTSP.Click += new System.EventHandler(this.buttonOpenTSP_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(3, 268);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(106, 41);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Rest";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRunToEnd
            // 
            this.buttonRunToEnd.Location = new System.Drawing.Point(0, 410);
            this.buttonRunToEnd.Name = "buttonRunToEnd";
            this.buttonRunToEnd.Size = new System.Drawing.Size(109, 59);
            this.buttonRunToEnd.TabIndex = 2;
            this.buttonRunToEnd.Text = "Run to end";
            this.buttonRunToEnd.UseVisualStyleBackColor = true;
            this.buttonRunToEnd.Click += new System.EventHandler(this.buttonRunToEnd_Click);
            // 
            // btnRunOneItr
            // 
            this.btnRunOneItr.Location = new System.Drawing.Point(3, 334);
            this.btnRunOneItr.Name = "btnRunOneItr";
            this.btnRunOneItr.Size = new System.Drawing.Size(106, 46);
            this.btnRunOneItr.TabIndex = 3;
            this.btnRunOneItr.Text = "Run One Iteration";
            this.btnRunOneItr.UseVisualStyleBackColor = true;
            this.btnRunOneItr.Click += new System.EventHandler(this.btnRunOneIteration_Click);
            // 
            // propertyGridSetting
            // 
            this.propertyGridSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridSetting.Location = new System.Drawing.Point(0, 0);
            this.propertyGridSetting.Name = "propertyGridSetting";
            this.propertyGridSetting.Size = new System.Drawing.Size(454, 449);
            this.propertyGridSetting.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1403, 700);
            this.splitContainer1.SplitterDistance = 945;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.buttonRunToEnd);
            this.splitContainer3.Panel1.Controls.Add(this.btnCreateACSsolver);
            this.splitContainer3.Panel1.Controls.Add(this.btnRunOneItr);
            this.splitContainer3.Panel1.Controls.Add(this.labelKnownBestObjvalue);
            this.splitContainer3.Panel1.Controls.Add(this.buttonReset);
            this.splitContainer3.Panel1.Controls.Add(this.buttonOpenTSP);
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.spcfourth);
            this.splitContainer3.Size = new System.Drawing.Size(945, 700);
            this.splitContainer3.SplitterDistance = 106;
            this.splitContainer3.TabIndex = 4;
            // 
            // btnCreateACSsolver
            // 
            this.btnCreateACSsolver.Location = new System.Drawing.Point(3, 209);
            this.btnCreateACSsolver.Name = "btnCreateACSsolver";
            this.btnCreateACSsolver.Size = new System.Drawing.Size(106, 35);
            this.btnCreateACSsolver.TabIndex = 4;
            this.btnCreateACSsolver.Text = "Create ACS Solver";
            this.btnCreateACSsolver.UseVisualStyleBackColor = true;
            this.btnCreateACSsolver.Click += new System.EventHandler(this.btnCreateACSsolver_Click);
            // 
            // labelKnownBestObjvalue
            // 
            this.labelKnownBestObjvalue.AutoSize = true;
            this.labelKnownBestObjvalue.Location = new System.Drawing.Point(12, 91);
            this.labelKnownBestObjvalue.Name = "labelKnownBestObjvalue";
            this.labelKnownBestObjvalue.Size = new System.Drawing.Size(84, 18);
            this.labelKnownBestObjvalue.TabIndex = 5;
            this.labelKnownBestObjvalue.Text = "KnownInfo";
            // 
            // spcfourth
            // 
            this.spcfourth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcfourth.Location = new System.Drawing.Point(0, 0);
            this.spcfourth.Name = "spcfourth";
            this.spcfourth.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcfourth.Panel1
            // 
            this.spcfourth.Panel1.Controls.Add(this.theChart);
            // 
            // spcfourth.Panel2
            // 
            this.spcfourth.Panel2.Controls.Add(this.tabControl1);
            this.spcfourth.Size = new System.Drawing.Size(835, 700);
            this.spcfourth.SplitterDistance = 164;
            this.spcfourth.TabIndex = 0;
            // 
            // theChart
            // 
            chartArea1.Name = "ChartArea1";
            this.theChart.ChartAreas.Add(chartArea1);
            this.theChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.theChart.Legends.Add(legend1);
            this.theChart.Location = new System.Drawing.Point(0, 0);
            this.theChart.Name = "theChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.theChart.Series.Add(series1);
            this.theChart.Size = new System.Drawing.Size(835, 164);
            this.theChart.TabIndex = 0;
            this.theChart.Text = "chart1";
            this.theChart.Click += new System.EventHandler(this.theChart_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageShow);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageShow
            // 
            this.tabPageShow.Controls.Add(this.tabControlAns);
            this.tabPageShow.Location = new System.Drawing.Point(4, 28);
            this.tabPageShow.Name = "tabPageShow";
            this.tabPageShow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShow.Size = new System.Drawing.Size(827, 500);
            this.tabPageShow.TabIndex = 0;
            this.tabPageShow.Text = "City & Routes";
            this.tabPageShow.UseVisualStyleBackColor = true;
            this.tabPageShow.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPageShow_Paint);
            // 
            // tabControlAns
            // 
            this.tabControlAns.Controls.Add(this.tabPage3);
            this.tabControlAns.Controls.Add(this.tabPage4);
            this.tabControlAns.Location = new System.Drawing.Point(674, 260);
            this.tabControlAns.Name = "tabControlAns";
            this.tabControlAns.SelectedIndex = 0;
            this.tabControlAns.Size = new System.Drawing.Size(8, 8);
            this.tabControlAns.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(0, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer4);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pheromone & Solution";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.checkBoxPheromone);
            this.splitContainer4.Panel1.Controls.Add(this.richTextBoxPheromoneMap);
            this.splitContainer4.Panel1.Controls.Add(this.splitter1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.checkBoxSol);
            this.splitContainer4.Panel2.Controls.Add(this.richTextBoxShowSolution);
            this.splitContainer4.Panel2.Controls.Add(this.splitter2);
            this.splitContainer4.Size = new System.Drawing.Size(821, 494);
            this.splitContainer4.SplitterDistance = 174;
            this.splitContainer4.TabIndex = 0;
            // 
            // checkBoxPheromone
            // 
            this.checkBoxPheromone.AutoSize = true;
            this.checkBoxPheromone.Location = new System.Drawing.Point(3, 23);
            this.checkBoxPheromone.Name = "checkBoxPheromone";
            this.checkBoxPheromone.Size = new System.Drawing.Size(188, 22);
            this.checkBoxPheromone.TabIndex = 2;
            this.checkBoxPheromone.Text = "Show Pheromone Map";
            this.checkBoxPheromone.UseVisualStyleBackColor = true;
            // 
            // richTextBoxPheromoneMap
            // 
            this.richTextBoxPheromoneMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxPheromoneMap.Location = new System.Drawing.Point(0, 48);
            this.richTextBoxPheromoneMap.Name = "richTextBoxPheromoneMap";
            this.richTextBoxPheromoneMap.Size = new System.Drawing.Size(821, 126);
            this.richTextBoxPheromoneMap.TabIndex = 1;
            this.richTextBoxPheromoneMap.Text = "";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(821, 48);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // checkBoxSol
            // 
            this.checkBoxSol.AutoSize = true;
            this.checkBoxSol.Location = new System.Drawing.Point(3, 23);
            this.checkBoxSol.Name = "checkBoxSol";
            this.checkBoxSol.Size = new System.Drawing.Size(132, 22);
            this.checkBoxSol.TabIndex = 3;
            this.checkBoxSol.Text = "Show Solution";
            this.checkBoxSol.UseVisualStyleBackColor = true;
            // 
            // richTextBoxShowSolution
            // 
            this.richTextBoxShowSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxShowSolution.Location = new System.Drawing.Point(0, 48);
            this.richTextBoxShowSolution.Name = "richTextBoxShowSolution";
            this.richTextBoxShowSolution.Size = new System.Drawing.Size(821, 268);
            this.richTextBoxShowSolution.TabIndex = 0;
            this.richTextBoxShowSolution.Text = "";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(821, 48);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainerBestSol);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyGridSetting);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(454, 700);
            this.splitContainer2.SplitterDistance = 247;
            this.splitContainer2.TabIndex = 5;
            // 
            // splitContainerBestSol
            // 
            this.splitContainerBestSol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBestSol.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBestSol.Name = "splitContainerBestSol";
            this.splitContainerBestSol.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBestSol.Panel1
            // 
            this.splitContainerBestSol.Panel1.Controls.Add(this.labelSofarthebestSol);
            this.splitContainerBestSol.Panel1.Controls.Add(this.richTextBoxbestSol);
            // 
            // splitContainerBestSol.Panel2
            // 
            this.splitContainerBestSol.Panel2.Controls.Add(this.labelShortestLength);
            this.splitContainerBestSol.Panel2.Controls.Add(this.richTextBoxShortestLength);
            this.splitContainerBestSol.Size = new System.Drawing.Size(454, 247);
            this.splitContainerBestSol.SplitterDistance = 109;
            this.splitContainerBestSol.TabIndex = 9;
            // 
            // labelSofarthebestSol
            // 
            this.labelSofarthebestSol.AutoSize = true;
            this.labelSofarthebestSol.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelSofarthebestSol.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSofarthebestSol.Location = new System.Drawing.Point(3, 3);
            this.labelSofarthebestSol.Name = "labelSofarthebestSol";
            this.labelSofarthebestSol.Size = new System.Drawing.Size(186, 18);
            this.labelSofarthebestSol.TabIndex = 7;
            this.labelSofarthebestSol.Text = "So Far The Best Solution:";
            // 
            // richTextBoxbestSol
            // 
            this.richTextBoxbestSol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxbestSol.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxbestSol.Name = "richTextBoxbestSol";
            this.richTextBoxbestSol.Size = new System.Drawing.Size(454, 109);
            this.richTextBoxbestSol.TabIndex = 0;
            this.richTextBoxbestSol.Text = "";
            // 
            // labelShortestLength
            // 
            this.labelShortestLength.AutoSize = true;
            this.labelShortestLength.BackColor = System.Drawing.SystemColors.Window;
            this.labelShortestLength.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelShortestLength.Location = new System.Drawing.Point(3, 3);
            this.labelShortestLength.Name = "labelShortestLength";
            this.labelShortestLength.Size = new System.Drawing.Size(197, 18);
            this.labelShortestLength.TabIndex = 8;
            this.labelShortestLength.Text = "So Far the Shortest Length:";
            // 
            // richTextBoxShortestLength
            // 
            this.richTextBoxShortestLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxShortestLength.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxShortestLength.Name = "richTextBoxShortestLength";
            this.richTextBoxShortestLength.Size = new System.Drawing.Size(454, 134);
            this.richTextBoxShortestLength.TabIndex = 6;
            this.richTextBoxShortestLength.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 700);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.spcfourth.Panel1.ResumeLayout(false);
            this.spcfourth.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcfourth)).EndInit();
            this.spcfourth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageShow.ResumeLayout(false);
            this.tabControlAns.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainerBestSol.Panel1.ResumeLayout(false);
            this.splitContainerBestSol.Panel1.PerformLayout();
            this.splitContainerBestSol.Panel2.ResumeLayout(false);
            this.splitContainerBestSol.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBestSol)).EndInit();
            this.splitContainerBestSol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenTSP;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRunToEnd;
        private System.Windows.Forms.Button btnRunOneItr;
        private System.Windows.Forms.PropertyGrid propertyGridSetting;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer spcfourth;
        private System.Windows.Forms.Button btnCreateACSsolver;
        private System.Windows.Forms.Label labelKnownBestObjvalue;
        private System.Windows.Forms.DataVisualization.Charting.Chart theChart;
        private System.Windows.Forms.Label labelShortestLength;
        private System.Windows.Forms.Label labelSofarthebestSol;
        private System.Windows.Forms.RichTextBox richTextBoxShortestLength;
        private System.Windows.Forms.RichTextBox richTextBoxbestSol;
        private System.Windows.Forms.SplitContainer splitContainerBestSol;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageShow;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControlAns;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.CheckBox checkBoxPheromone;
        private System.Windows.Forms.RichTextBox richTextBoxPheromoneMap;
        private System.Windows.Forms.CheckBox checkBoxSol;
        private System.Windows.Forms.RichTextBox richTextBoxShowSolution;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
    }
}

