namespace R09546014HungYLAss04
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
            this.buttonCreateUniverse = new System.Windows.Forms.Button();
            this.theTree = new System.Windows.Forms.TreeView();
            this.mainchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.theGrid = new System.Windows.Forms.PropertyGrid();
            this.btnCreateFuzzySet = new System.Windows.Forms.Button();
            this.comboBoxSelectFS = new System.Windows.Forms.ComboBox();
            this.btnDeleteFuzzySet = new System.Windows.Forms.Button();
            this.cbxUnaryOperator = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreatedUnaryOperatedFS = new System.Windows.Forms.Button();
            this.labLeftFS = new System.Windows.Forms.Label();
            this.labRightFS = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateBinaryFuzzySet = new System.Windows.Forms.Button();
            this.cbxBinaryOperator = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateUniverse
            // 
            this.buttonCreateUniverse.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateUniverse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateUniverse.Name = "buttonCreateUniverse";
            this.buttonCreateUniverse.Size = new System.Drawing.Size(176, 53);
            this.buttonCreateUniverse.TabIndex = 0;
            this.buttonCreateUniverse.Text = "Create Universe";
            this.buttonCreateUniverse.UseVisualStyleBackColor = true;
            this.buttonCreateUniverse.Click += new System.EventHandler(this.btnCreateUniverse_Click);
            // 
            // theTree
            // 
            this.theTree.Location = new System.Drawing.Point(3, 61);
            this.theTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.theTree.Name = "theTree";
            this.theTree.Size = new System.Drawing.Size(190, 211);
            this.theTree.TabIndex = 1;
            this.theTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.theTree_AfterSelect);
            // 
            // mainchart
            // 
            this.mainchart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Name = "ChartArea1";
            this.mainchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainchart.Legends.Add(legend1);
            this.mainchart.Location = new System.Drawing.Point(2, 142);
            this.mainchart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainchart.Name = "mainchart";
            this.mainchart.Size = new System.Drawing.Size(921, 450);
            this.mainchart.TabIndex = 2;
            // 
            // theGrid
            // 
            this.theGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.theGrid.Location = new System.Drawing.Point(3, 4);
            this.theGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.theGrid.Name = "theGrid";
            this.theGrid.Size = new System.Drawing.Size(293, 289);
            this.theGrid.TabIndex = 3;
            this.theGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.theGrid_PropertyValueChanged);
            // 
            // btnCreateFuzzySet
            // 
            this.btnCreateFuzzySet.Location = new System.Drawing.Point(3, 4);
            this.btnCreateFuzzySet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateFuzzySet.Name = "btnCreateFuzzySet";
            this.btnCreateFuzzySet.Size = new System.Drawing.Size(141, 29);
            this.btnCreateFuzzySet.TabIndex = 4;
            this.btnCreateFuzzySet.Text = "CreateFuzzySet";
            this.btnCreateFuzzySet.UseVisualStyleBackColor = true;
            this.btnCreateFuzzySet.Click += new System.EventHandler(this.btnCreateFuzzySet_Click);
            // 
            // comboBoxSelectFS
            // 
            this.comboBoxSelectFS.FormattingEnabled = true;
            this.comboBoxSelectFS.Items.AddRange(new object[] {
            "Gaussian FS",
            "S FS",
            "Z FS",
            "Pi FS",
            "Bell FS",
            "Triangle FS",
            "TwoSidedPi FS",
            "TwoSidedGaussian FS"});
            this.comboBoxSelectFS.Location = new System.Drawing.Point(3, 40);
            this.comboBoxSelectFS.Name = "comboBoxSelectFS";
            this.comboBoxSelectFS.Size = new System.Drawing.Size(164, 28);
            this.comboBoxSelectFS.TabIndex = 5;
            // 
            // btnDeleteFuzzySet
            // 
            this.btnDeleteFuzzySet.Location = new System.Drawing.Point(150, 3);
            this.btnDeleteFuzzySet.Name = "btnDeleteFuzzySet";
            this.btnDeleteFuzzySet.Size = new System.Drawing.Size(127, 30);
            this.btnDeleteFuzzySet.TabIndex = 6;
            this.btnDeleteFuzzySet.Text = "Delete FuzzySet";
            this.btnDeleteFuzzySet.UseVisualStyleBackColor = true;
            this.btnDeleteFuzzySet.Click += new System.EventHandler(this.btnDeleteFuzzySet_Click);
            // 
            // cbxUnaryOperator
            // 
            this.cbxUnaryOperator.FormattingEnabled = true;
            this.cbxUnaryOperator.Items.AddRange(new object[] {
            "negate",
            "value cut",
            "concentrate",
            "dilate",
            "intensificate",
            "diminish",
            "Sugeno\'s negate"});
            this.cbxUnaryOperator.Location = new System.Drawing.Point(330, 61);
            this.cbxUnaryOperator.Name = "cbxUnaryOperator";
            this.cbxUnaryOperator.Size = new System.Drawing.Size(164, 28);
            this.cbxUnaryOperator.TabIndex = 7;
            this.cbxUnaryOperator.SelectedIndexChanged += new System.EventHandler(this.cbxUniaryOperator_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "UnaryOperatedFs";
            // 
            // btnCreatedUnaryOperatedFS
            // 
            this.btnCreatedUnaryOperatedFS.Location = new System.Drawing.Point(330, 105);
            this.btnCreatedUnaryOperatedFS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreatedUnaryOperatedFS.Name = "btnCreatedUnaryOperatedFS";
            this.btnCreatedUnaryOperatedFS.Size = new System.Drawing.Size(167, 29);
            this.btnCreatedUnaryOperatedFS.TabIndex = 10;
            this.btnCreatedUnaryOperatedFS.Text = "CreateUnaryOperatedFS";
            this.btnCreatedUnaryOperatedFS.UseVisualStyleBackColor = true;
            this.btnCreatedUnaryOperatedFS.Click += new System.EventHandler(this.btnCreatedUnaryOperatedFS_Click);
            // 
            // labLeftFS
            // 
            this.labLeftFS.AutoSize = true;
            this.labLeftFS.Location = new System.Drawing.Point(592, 38);
            this.labLeftFS.Name = "labLeftFS";
            this.labLeftFS.Size = new System.Drawing.Size(83, 20);
            this.labLeftFS.TabIndex = 11;
            this.labLeftFS.Text = "SelectLFS";
            this.labLeftFS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labLeftFS.Click += new System.EventHandler(this.labLeftFS_Click);
            // 
            // labRightFS
            // 
            this.labRightFS.AutoSize = true;
            this.labRightFS.Location = new System.Drawing.Point(691, 38);
            this.labRightFS.Name = "labRightFS";
            this.labRightFS.Size = new System.Drawing.Size(84, 20);
            this.labRightFS.TabIndex = 12;
            this.labRightFS.Text = "SelectRFS";
            this.labRightFS.Click += new System.EventHandler(this.labRightFS_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreateBinaryFuzzySet);
            this.splitContainer1.Panel2.Controls.Add(this.cbxBinaryOperator);
            this.splitContainer1.Panel2.Controls.Add(this.mainchart);
            this.splitContainer1.Panel2.Controls.Add(this.labRightFS);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreateFuzzySet);
            this.splitContainer1.Panel2.Controls.Add(this.labLeftFS);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxSelectFS);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreatedUnaryOperatedFS);
            this.splitContainer1.Panel2.Controls.Add(this.btnDeleteFuzzySet);
            this.splitContainer1.Panel2.Controls.Add(this.cbxUnaryOperator);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1243, 596);
            this.splitContainer1.SplitterDistance = 313;
            this.splitContainer1.TabIndex = 13;
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
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer2.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer2.Panel1.Controls.Add(this.buttonCreateUniverse);
            this.splitContainer2.Panel1.Controls.Add(this.theTree);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splitContainer2.Panel2.Controls.Add(this.theGrid);
            this.splitContainer2.Size = new System.Drawing.Size(313, 596);
            this.splitContainer2.SplitterDistance = 298;
            this.splitContainer2.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(313, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "BinaryOperatedFs";
            // 
            // btnCreateBinaryFuzzySet
            // 
            this.btnCreateBinaryFuzzySet.Location = new System.Drawing.Point(596, 105);
            this.btnCreateBinaryFuzzySet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateBinaryFuzzySet.Name = "btnCreateBinaryFuzzySet";
            this.btnCreateBinaryFuzzySet.Size = new System.Drawing.Size(164, 29);
            this.btnCreateBinaryFuzzySet.TabIndex = 15;
            this.btnCreateBinaryFuzzySet.Text = "CreateBinaryOperatedFS";
            this.btnCreateBinaryFuzzySet.UseVisualStyleBackColor = true;
            this.btnCreateBinaryFuzzySet.Click += new System.EventHandler(this.btnCreateBinaryFuzzySet_Click);
            // 
            // cbxBinaryOperator
            // 
            this.cbxBinaryOperator.FormattingEnabled = true;
            this.cbxBinaryOperator.Items.AddRange(new object[] {
            "Intersection ",
            "union",
            "substraction"});
            this.cbxBinaryOperator.Location = new System.Drawing.Point(594, 61);
            this.cbxBinaryOperator.Name = "cbxBinaryOperator";
            this.cbxBinaryOperator.Size = new System.Drawing.Size(164, 28);
            this.cbxBinaryOperator.TabIndex = 14;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1243, 613);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainchart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateUniverse;
        private System.Windows.Forms.TreeView theTree;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainchart;
        private System.Windows.Forms.PropertyGrid theGrid;
        private System.Windows.Forms.Button btnCreateFuzzySet;
        private System.Windows.Forms.ComboBox comboBoxSelectFS;
        private System.Windows.Forms.Button btnDeleteFuzzySet;
        private System.Windows.Forms.ComboBox cbxUnaryOperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreatedUnaryOperatedFS;
        private System.Windows.Forms.Label labLeftFS;
        private System.Windows.Forms.Label labRightFS;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox cbxBinaryOperator;
        private System.Windows.Forms.Button btnCreateBinaryFuzzySet;
        private System.Windows.Forms.Label label2;
    }
}

