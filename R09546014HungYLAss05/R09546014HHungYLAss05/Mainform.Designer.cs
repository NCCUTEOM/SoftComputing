namespace R09546014HungYLAss05
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Inputs");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Output");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
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
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnAddRules = new System.Windows.Forms.Button();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.btnDeleteInferenceResult = new System.Windows.Forms.Button();
            this.dgvCondition = new System.Windows.Forms.DataGridView();
            this.btnInference = new System.Windows.Forms.Button();
            this.panelfuzzyset = new System.Windows.Forms.Panel();
            this.btnCreateBinaryFuzzySet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBinaryOperator = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondition)).BeginInit();
            this.panelfuzzyset.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateUniverse
            // 
            this.buttonCreateUniverse.Location = new System.Drawing.Point(0, 3);
            this.buttonCreateUniverse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateUniverse.Name = "buttonCreateUniverse";
            this.buttonCreateUniverse.Size = new System.Drawing.Size(176, 33);
            this.buttonCreateUniverse.TabIndex = 0;
            this.buttonCreateUniverse.Text = "Create Universe";
            this.buttonCreateUniverse.UseVisualStyleBackColor = true;
            this.buttonCreateUniverse.Click += new System.EventHandler(this.btnCreateUniverse_Click);
            // 
            // theTree
            // 
            this.theTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theTree.Location = new System.Drawing.Point(0, 40);
            this.theTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.theTree.Name = "theTree";
            treeNode3.Name = "NodeInput";
            treeNode3.Text = "Inputs";
            treeNode4.Name = "NodeOutput";
            treeNode4.Text = "Output";
            this.theTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.theTree.Size = new System.Drawing.Size(176, 211);
            this.theTree.TabIndex = 1;
            this.toolTip1.SetToolTip(this.theTree, "Feel free to add universe without the order");
            this.theTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.theTree_AfterSelect);
            // 
            // mainchart
            // 
            chartArea2.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea2.Name = "ChartArea1";
            this.mainchart.ChartAreas.Add(chartArea2);
            this.mainchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.mainchart.Legends.Add(legend2);
            this.mainchart.Location = new System.Drawing.Point(0, 0);
            this.mainchart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainchart.Name = "mainchart";
            this.mainchart.Size = new System.Drawing.Size(854, 596);
            this.mainchart.TabIndex = 2;
            // 
            // theGrid
            // 
            this.theGrid.Location = new System.Drawing.Point(182, 3);
            this.theGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.theGrid.Name = "theGrid";
            this.theGrid.Size = new System.Drawing.Size(186, 248);
            this.theGrid.TabIndex = 3;
            this.theGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.theGrid_PropertyValueChanged);
            // 
            // btnCreateFuzzySet
            // 
            this.btnCreateFuzzySet.Location = new System.Drawing.Point(3, 9);
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
            this.comboBoxSelectFS.Location = new System.Drawing.Point(3, 45);
            this.comboBoxSelectFS.Name = "comboBoxSelectFS";
            this.comboBoxSelectFS.Size = new System.Drawing.Size(164, 23);
            this.comboBoxSelectFS.TabIndex = 5;
            // 
            // btnDeleteFuzzySet
            // 
            this.btnDeleteFuzzySet.Location = new System.Drawing.Point(150, 8);
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
            "Sugeno\'s negate",
            "Yager\'s negate"});
            this.cbxUnaryOperator.Location = new System.Drawing.Point(3, 119);
            this.cbxUnaryOperator.Name = "cbxUnaryOperator";
            this.cbxUnaryOperator.Size = new System.Drawing.Size(164, 23);
            this.cbxUnaryOperator.TabIndex = 7;
            this.cbxUnaryOperator.SelectedIndexChanged += new System.EventHandler(this.cbxUniaryOperator_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "UnaryOperatedFs";
            // 
            // btnCreatedUnaryOperatedFS
            // 
            this.btnCreatedUnaryOperatedFS.Location = new System.Drawing.Point(182, 119);
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
            this.labLeftFS.Location = new System.Drawing.Point(178, 194);
            this.labLeftFS.Name = "labLeftFS";
            this.labLeftFS.Size = new System.Drawing.Size(55, 15);
            this.labLeftFS.TabIndex = 11;
            this.labLeftFS.Text = "SelectLFS";
            this.labLeftFS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labLeftFS.Click += new System.EventHandler(this.labLeftFS_Click);
            // 
            // labRightFS
            // 
            this.labRightFS.AutoSize = true;
            this.labRightFS.Location = new System.Drawing.Point(284, 194);
            this.labRightFS.Name = "labRightFS";
            this.labRightFS.Size = new System.Drawing.Size(56, 15);
            this.labRightFS.TabIndex = 12;
            this.labRightFS.Text = "SelectRFS";
            this.labRightFS.Click += new System.EventHandler(this.labRightFS_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.splitContainer1.Panel2.Controls.Add(this.mainchart);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1243, 596);
            this.splitContainer1.SplitterDistance = 385;
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
            this.splitContainer2.Panel1.Controls.Add(this.theGrid);
            this.splitContainer2.Panel1.Controls.Add(this.theTree);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Aqua;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.Controls.Add(this.panelfuzzyset);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(385, 596);
            this.splitContainer2.SplitterDistance = 298;
            this.splitContainer2.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(385, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.Azure;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 25);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnAddRules);
            this.splitContainer3.Panel1.Controls.Add(this.dgvRules);
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnDeleteInferenceResult);
            this.splitContainer3.Panel2.Controls.Add(this.dgvCondition);
            this.splitContainer3.Panel2.Controls.Add(this.btnInference);
            this.splitContainer3.Size = new System.Drawing.Size(385, 269);
            this.splitContainer3.SplitterDistance = 136;
            this.splitContainer3.TabIndex = 4;
            // 
            // btnAddRules
            // 
            this.btnAddRules.Location = new System.Drawing.Point(0, 11);
            this.btnAddRules.Name = "btnAddRules";
            this.btnAddRules.Size = new System.Drawing.Size(75, 23);
            this.btnAddRules.TabIndex = 18;
            this.btnAddRules.Text = "Add rules";
            this.btnAddRules.UseVisualStyleBackColor = true;
            this.btnAddRules.Click += new System.EventHandler(this.btnAddRules_Click);
            // 
            // dgvRules
            // 
            this.dgvRules.AllowUserToAddRows = false;
            this.dgvRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRules.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Location = new System.Drawing.Point(3, 40);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.RowHeadersWidth = 62;
            this.dgvRules.RowTemplate.Height = 31;
            this.dgvRules.Size = new System.Drawing.Size(335, 93);
            this.dgvRules.TabIndex = 17;
            this.dgvRules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRules_CellClick);
            this.dgvRules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdRules_CellContentClick);
            // 
            // btnDeleteInferenceResult
            // 
            this.btnDeleteInferenceResult.Location = new System.Drawing.Point(150, 3);
            this.btnDeleteInferenceResult.Name = "btnDeleteInferenceResult";
            this.btnDeleteInferenceResult.Size = new System.Drawing.Size(128, 27);
            this.btnDeleteInferenceResult.TabIndex = 21;
            this.btnDeleteInferenceResult.Text = "Delete Inference result";
            this.btnDeleteInferenceResult.UseVisualStyleBackColor = true;
            this.btnDeleteInferenceResult.Click += new System.EventHandler(this.btnDeleteInferenceResult_Click);
            // 
            // dgvCondition
            // 
            this.dgvCondition.AllowUserToAddRows = false;
            this.dgvCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCondition.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondition.Location = new System.Drawing.Point(0, 36);
            this.dgvCondition.Name = "dgvCondition";
            this.dgvCondition.RowHeadersWidth = 62;
            this.dgvCondition.RowTemplate.Height = 31;
            this.dgvCondition.Size = new System.Drawing.Size(338, 90);
            this.dgvCondition.TabIndex = 20;
            this.dgvCondition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCondition_CellClick);
            // 
            // btnInference
            // 
            this.btnInference.Location = new System.Drawing.Point(0, 3);
            this.btnInference.Name = "btnInference";
            this.btnInference.Size = new System.Drawing.Size(134, 27);
            this.btnInference.TabIndex = 19;
            this.btnInference.Text = "Inference one instance";
            this.btnInference.UseVisualStyleBackColor = true;
            this.btnInference.Click += new System.EventHandler(this.btnInference_Click);
            // 
            // panelfuzzyset
            // 
            this.panelfuzzyset.Controls.Add(this.btnCreateFuzzySet);
            this.panelfuzzyset.Controls.Add(this.btnCreateBinaryFuzzySet);
            this.panelfuzzyset.Controls.Add(this.label2);
            this.panelfuzzyset.Controls.Add(this.cbxBinaryOperator);
            this.panelfuzzyset.Controls.Add(this.btnDeleteFuzzySet);
            this.panelfuzzyset.Controls.Add(this.comboBoxSelectFS);
            this.panelfuzzyset.Controls.Add(this.labRightFS);
            this.panelfuzzyset.Controls.Add(this.label1);
            this.panelfuzzyset.Controls.Add(this.labLeftFS);
            this.panelfuzzyset.Controls.Add(this.cbxUnaryOperator);
            this.panelfuzzyset.Controls.Add(this.btnCreatedUnaryOperatedFS);
            this.panelfuzzyset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelfuzzyset.Location = new System.Drawing.Point(0, 25);
            this.panelfuzzyset.Name = "panelfuzzyset";
            this.panelfuzzyset.Size = new System.Drawing.Size(385, 269);
            this.panelfuzzyset.TabIndex = 6;
            // 
            // btnCreateBinaryFuzzySet
            // 
            this.btnCreateBinaryFuzzySet.Location = new System.Drawing.Point(185, 224);
            this.btnCreateBinaryFuzzySet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateBinaryFuzzySet.Name = "btnCreateBinaryFuzzySet";
            this.btnCreateBinaryFuzzySet.Size = new System.Drawing.Size(164, 29);
            this.btnCreateBinaryFuzzySet.TabIndex = 15;
            this.btnCreateBinaryFuzzySet.Text = "CreateBinaryOperatedFS";
            this.btnCreateBinaryFuzzySet.UseVisualStyleBackColor = true;
            this.btnCreateBinaryFuzzySet.Click += new System.EventHandler(this.btnCreateBinaryFuzzySet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "BinaryOperatedFs";
            // 
            // cbxBinaryOperator
            // 
            this.cbxBinaryOperator.FormattingEnabled = true;
            this.cbxBinaryOperator.Items.AddRange(new object[] {
            "Intersection ",
            "Algebraic product",
            "Minimum",
            "Union"});
            this.cbxBinaryOperator.Location = new System.Drawing.Point(3, 225);
            this.cbxBinaryOperator.Name = "cbxBinaryOperator";
            this.cbxBinaryOperator.Size = new System.Drawing.Size(164, 23);
            this.cbxBinaryOperator.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(385, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripTextBox1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripTextBox1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTextBox1.Image")));
            this.toolStripTextBox1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(68, 22);
            this.toolStripTextBox1.Text = "Fuzzy Sets";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripTextBox2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripTextBox2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTextBox2.Image")));
            this.toolStripTextBox2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(80, 22);
            this.toolStripTextBox2.Text = "If-Then rules";
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 1500;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondition)).EndInit();
            this.panelfuzzyset.ResumeLayout(false);
            this.panelfuzzyset.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnInference;
        private System.Windows.Forms.Button btnAddRules;
        private System.Windows.Forms.DataGridView dgvRules;
        private System.Windows.Forms.DataGridView dgvCondition;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panelfuzzyset;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDeleteInferenceResult;
        private System.Windows.Forms.ToolStripButton toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripTextBox2;
    }
}

