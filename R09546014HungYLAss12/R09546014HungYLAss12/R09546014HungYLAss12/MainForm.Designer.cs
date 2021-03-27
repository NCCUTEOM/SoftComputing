namespace R09546014HungYLAss12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpencal = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.numericUpDownNeuronNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHiddenLayers = new System.Windows.Forms.NumericUpDown();
            this.labelNeuronNumber = new System.Windows.Forms.Label();
            this.labelHiddenLayers = new System.Windows.Forms.Label();
            this.listBoxHiddenLayerNeuronNumbers = new System.Windows.Forms.ListBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.theChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnTrainAnEpoch = new System.Windows.Forms.Button();
            this.buttonTrainToEnd = new System.Windows.Forms.Button();
            this.richTextBoxRMSE = new System.Windows.Forms.RichTextBox();
            this.labelRMSE = new System.Windows.Forms.Label();
            this.labelCorrectness = new System.Windows.Forms.Label();
            this.richTextBoxCorrectness = new System.Windows.Forms.RichTextBox();
            this.labelConfusionMatrix = new System.Windows.Forms.Label();
            this.richTextBoxConfusionMatrix = new System.Windows.Forms.RichTextBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.propertyGridTrainingSetting = new System.Windows.Forms.PropertyGrid();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeuronNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHiddenLayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpencal});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1043, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpencal
            // 
            this.toolStripButtonOpencal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpencal.Image")));
            this.toolStripButtonOpencal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpencal.Name = "toolStripButtonOpencal";
            this.toolStripButtonOpencal.Size = new System.Drawing.Size(89, 28);
            this.toolStripButtonOpencal.Text = "Open .cal";
            this.toolStripButtonOpencal.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer1.Size = new System.Drawing.Size(1043, 552);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
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
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownNeuronNumber);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownHiddenLayers);
            this.splitContainer2.Panel1.Controls.Add(this.labelNeuronNumber);
            this.splitContainer2.Panel1.Controls.Add(this.labelHiddenLayers);
            this.splitContainer2.Panel1.Controls.Add(this.listBoxHiddenLayerNeuronNumbers);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(346, 552);
            this.splitContainer2.SplitterDistance = 159;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // numericUpDownNeuronNumber
            // 
            this.numericUpDownNeuronNumber.Location = new System.Drawing.Point(139, 46);
            this.numericUpDownNeuronNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownNeuronNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNeuronNumber.Name = "numericUpDownNeuronNumber";
            this.numericUpDownNeuronNumber.Size = new System.Drawing.Size(29, 22);
            this.numericUpDownNeuronNumber.TabIndex = 4;
            this.numericUpDownNeuronNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownNeuronNumber.ValueChanged += new System.EventHandler(this.numericUpDownNeuronNumber_ValueChanged);
            // 
            // numericUpDownHiddenLayers
            // 
            this.numericUpDownHiddenLayers.Location = new System.Drawing.Point(139, 17);
            this.numericUpDownHiddenLayers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownHiddenLayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHiddenLayers.Name = "numericUpDownHiddenLayers";
            this.numericUpDownHiddenLayers.Size = new System.Drawing.Size(29, 22);
            this.numericUpDownHiddenLayers.TabIndex = 3;
            this.numericUpDownHiddenLayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHiddenLayers.ValueChanged += new System.EventHandler(this.numericUpDownHiddenLayers_ValueChanged);
            // 
            // labelNeuronNumber
            // 
            this.labelNeuronNumber.AutoSize = true;
            this.labelNeuronNumber.Location = new System.Drawing.Point(54, 47);
            this.labelNeuronNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNeuronNumber.Name = "labelNeuronNumber";
            this.labelNeuronNumber.Size = new System.Drawing.Size(81, 12);
            this.labelNeuronNumber.TabIndex = 2;
            this.labelNeuronNumber.Text = "Neuron Number";
            // 
            // labelHiddenLayers
            // 
            this.labelHiddenLayers.AutoSize = true;
            this.labelHiddenLayers.Location = new System.Drawing.Point(54, 17);
            this.labelHiddenLayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHiddenLayers.Name = "labelHiddenLayers";
            this.labelHiddenLayers.Size = new System.Drawing.Size(73, 12);
            this.labelHiddenLayers.TabIndex = 1;
            this.labelHiddenLayers.Text = "Hidden Layers";
            // 
            // listBoxHiddenLayerNeuronNumbers
            // 
            this.listBoxHiddenLayerNeuronNumbers.FormattingEnabled = true;
            this.listBoxHiddenLayerNeuronNumbers.ItemHeight = 12;
            this.listBoxHiddenLayerNeuronNumbers.Items.AddRange(new object[] {
            "4"});
            this.listBoxHiddenLayerNeuronNumbers.Location = new System.Drawing.Point(2, 17);
            this.listBoxHiddenLayerNeuronNumbers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxHiddenLayerNeuronNumbers.Name = "listBoxHiddenLayerNeuronNumbers";
            this.listBoxHiddenLayerNeuronNumbers.Size = new System.Drawing.Size(49, 64);
            this.listBoxHiddenLayerNeuronNumbers.TabIndex = 0;
            this.listBoxHiddenLayerNeuronNumbers.SelectedIndexChanged += new System.EventHandler(this.listBoxHiddenLayerNeuronNumbers_SelectedIndexChanged);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.theChart);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer5_Panel2_Paint);
            this.splitContainer5.Size = new System.Drawing.Size(694, 552);
            this.splitContainer5.SplitterDistance = 262;
            this.splitContainer5.SplitterWidth = 3;
            this.splitContainer5.TabIndex = 0;
            // 
            // theChart
            // 
            chartArea4.Name = "ChartArea1";
            this.theChart.ChartAreas.Add(chartArea4);
            this.theChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.theChart.Legends.Add(legend4);
            this.theChart.Location = new System.Drawing.Point(0, 0);
            this.theChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.theChart.Name = "theChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.theChart.Series.Add(series4);
            this.theChart.Size = new System.Drawing.Size(694, 262);
            this.theChart.TabIndex = 0;
            this.theChart.Text = "chart1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(338, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MLP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(2, 2);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.richTextBoxConfusionMatrix);
            this.splitContainer3.Panel2.Controls.Add(this.labelConfusionMatrix);
            this.splitContainer3.Panel2.Controls.Add(this.richTextBoxCorrectness);
            this.splitContainer3.Panel2.Controls.Add(this.labelCorrectness);
            this.splitContainer3.Panel2.Controls.Add(this.labelRMSE);
            this.splitContainer3.Panel2.Controls.Add(this.richTextBoxRMSE);
            this.splitContainer3.Panel2.Controls.Add(this.buttonTrainToEnd);
            this.splitContainer3.Panel2.Controls.Add(this.btnTrainAnEpoch);
            this.splitContainer3.Size = new System.Drawing.Size(334, 360);
            this.splitContainer3.SplitterDistance = 209;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 0;
            // 
            // btnTrainAnEpoch
            // 
            this.btnTrainAnEpoch.Location = new System.Drawing.Point(2, -2);
            this.btnTrainAnEpoch.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrainAnEpoch.Name = "btnTrainAnEpoch";
            this.btnTrainAnEpoch.Size = new System.Drawing.Size(103, 63);
            this.btnTrainAnEpoch.TabIndex = 1;
            this.btnTrainAnEpoch.Text = "Train An Epoch";
            this.btnTrainAnEpoch.UseVisualStyleBackColor = true;
            this.btnTrainAnEpoch.Click += new System.EventHandler(this.btnTrainAnEpoch_Click);
            // 
            // buttonTrainToEnd
            // 
            this.buttonTrainToEnd.Location = new System.Drawing.Point(1, 65);
            this.buttonTrainToEnd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTrainToEnd.Name = "buttonTrainToEnd";
            this.buttonTrainToEnd.Size = new System.Drawing.Size(104, 58);
            this.buttonTrainToEnd.TabIndex = 3;
            this.buttonTrainToEnd.Text = "Train To End";
            this.buttonTrainToEnd.UseVisualStyleBackColor = true;
            this.buttonTrainToEnd.Click += new System.EventHandler(this.buttonTrainToEnd_Click);
            // 
            // richTextBoxRMSE
            // 
            this.richTextBoxRMSE.Location = new System.Drawing.Point(1, 152);
            this.richTextBoxRMSE.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxRMSE.Name = "richTextBoxRMSE";
            this.richTextBoxRMSE.Size = new System.Drawing.Size(119, 28);
            this.richTextBoxRMSE.TabIndex = 4;
            this.richTextBoxRMSE.Text = "";
            // 
            // labelRMSE
            // 
            this.labelRMSE.AutoSize = true;
            this.labelRMSE.Location = new System.Drawing.Point(2, 138);
            this.labelRMSE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRMSE.Name = "labelRMSE";
            this.labelRMSE.Size = new System.Drawing.Size(36, 12);
            this.labelRMSE.TabIndex = 5;
            this.labelRMSE.Text = "RMSE";
            // 
            // labelCorrectness
            // 
            this.labelCorrectness.AutoSize = true;
            this.labelCorrectness.Location = new System.Drawing.Point(2, 205);
            this.labelCorrectness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCorrectness.Name = "labelCorrectness";
            this.labelCorrectness.Size = new System.Drawing.Size(59, 12);
            this.labelCorrectness.TabIndex = 6;
            this.labelCorrectness.Text = "Correctness";
            this.labelCorrectness.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBoxCorrectness
            // 
            this.richTextBoxCorrectness.Location = new System.Drawing.Point(4, 219);
            this.richTextBoxCorrectness.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxCorrectness.Name = "richTextBoxCorrectness";
            this.richTextBoxCorrectness.Size = new System.Drawing.Size(116, 17);
            this.richTextBoxCorrectness.TabIndex = 7;
            this.richTextBoxCorrectness.Text = "";
            this.richTextBoxCorrectness.TextChanged += new System.EventHandler(this.richTextBoxCorrectness_TextChanged);
            // 
            // labelConfusionMatrix
            // 
            this.labelConfusionMatrix.AutoSize = true;
            this.labelConfusionMatrix.Location = new System.Drawing.Point(2, 264);
            this.labelConfusionMatrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConfusionMatrix.Name = "labelConfusionMatrix";
            this.labelConfusionMatrix.Size = new System.Drawing.Size(88, 12);
            this.labelConfusionMatrix.TabIndex = 8;
            this.labelConfusionMatrix.Text = "Confusion Matrix";
            this.labelConfusionMatrix.Click += new System.EventHandler(this.labelConfusionMatrix_Click);
            // 
            // richTextBoxConfusionMatrix
            // 
            this.richTextBoxConfusionMatrix.Location = new System.Drawing.Point(4, 292);
            this.richTextBoxConfusionMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxConfusionMatrix.Name = "richTextBoxConfusionMatrix";
            this.richTextBoxConfusionMatrix.Size = new System.Drawing.Size(116, 63);
            this.richTextBoxConfusionMatrix.TabIndex = 9;
            this.richTextBoxConfusionMatrix.Text = "";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.buttonReset);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.propertyGridTrainingSetting);
            this.splitContainer4.Size = new System.Drawing.Size(209, 360);
            this.splitContainer4.SplitterDistance = 45;
            this.splitContainer4.SplitterWidth = 3;
            this.splitContainer4.TabIndex = 1;
            // 
            // propertyGridTrainingSetting
            // 
            this.propertyGridTrainingSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridTrainingSetting.Location = new System.Drawing.Point(0, 0);
            this.propertyGridTrainingSetting.Margin = new System.Windows.Forms.Padding(2);
            this.propertyGridTrainingSetting.Name = "propertyGridTrainingSetting";
            this.propertyGridTrainingSetting.Size = new System.Drawing.Size(209, 312);
            this.propertyGridTrainingSetting.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReset.Location = new System.Drawing.Point(0, 0);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(209, 45);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 390);
            this.tabControl1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 583);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeuronNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHiddenLayers)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpencal;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBoxHiddenLayerNeuronNumbers;
        private System.Windows.Forms.NumericUpDown numericUpDownNeuronNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownHiddenLayers;
        private System.Windows.Forms.Label labelNeuronNumber;
        private System.Windows.Forms.Label labelHiddenLayers;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataVisualization.Charting.Chart theChart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.PropertyGrid propertyGridTrainingSetting;
        private System.Windows.Forms.RichTextBox richTextBoxConfusionMatrix;
        private System.Windows.Forms.Label labelConfusionMatrix;
        private System.Windows.Forms.RichTextBox richTextBoxCorrectness;
        private System.Windows.Forms.Label labelCorrectness;
        private System.Windows.Forms.Label labelRMSE;
        private System.Windows.Forms.RichTextBox richTextBoxRMSE;
        private System.Windows.Forms.Button buttonTrainToEnd;
        private System.Windows.Forms.Button btnTrainAnEpoch;
    }
}

