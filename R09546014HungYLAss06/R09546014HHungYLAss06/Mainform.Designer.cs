namespace R09546014HungYLAss06
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.buttonCreateUniverse = new System.Windows.Forms.Button();
            this.theTree = new System.Windows.Forms.TreeView();
            this.mainchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.radiobtnSugeno = new System.Windows.Forms.RadioButton();
            this.radiobtnTsukamoto = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.theGrid = new System.Windows.Forms.PropertyGrid();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.radiobtnMamdani = new System.Windows.Forms.RadioButton();
            this.tbcswitch = new System.Windows.Forms.TabControl();
            this.tabPageFs = new System.Windows.Forms.TabPage();
            this.btnAddEquation = new System.Windows.Forms.Button();
            this.listBoxEquation = new System.Windows.Forms.ListBox();
            this.btnCreateBinaryFuzzySet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectFS = new System.Windows.Forms.ComboBox();
            this.btnCreateFuzzySet = new System.Windows.Forms.Button();
            this.labRightFS = new System.Windows.Forms.Label();
            this.cbxBinaryOperator = new System.Windows.Forms.ComboBox();
            this.labLeftFS = new System.Windows.Forms.Label();
            this.btnDeleteFuzzySet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxUnaryOperator = new System.Windows.Forms.ComboBox();
            this.btnCreatedUnaryOperatedFS = new System.Windows.Forms.Button();
            this.tabPageRules = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btndeleteRules = new System.Windows.Forms.Button();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.btnAddRules = new System.Windows.Forms.Button();
            this.btnDeleteInferenceResult = new System.Windows.Forms.Button();
            this.dgvCondition = new System.Windows.Forms.DataGridView();
            this.btnInference = new System.Windows.Forms.Button();
            this.tabPageSystem = new System.Windows.Forms.TabPage();
            this.btnCrispInCrispOut = new System.Windows.Forms.Button();
            this.ppgSystem = new System.Windows.Forms.PropertyGrid();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.panelsettings = new System.Windows.Forms.Panel();
            this.tchartOutput = new Steema.TeeChart.TChart();
            this.surface1 = new Steema.TeeChart.Styles.Surface();
            this.chart2Doutput = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartController1 = new Steema.TeeChart.ChartController();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.mainchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbcswitch.SuspendLayout();
            this.tabPageFs.SuspendLayout();
            this.tabPageRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondition)).BeginInit();
            this.tabPageSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.panelsettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2Doutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateUniverse
            // 
            this.buttonCreateUniverse.Location = new System.Drawing.Point(0, 96);
            this.buttonCreateUniverse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateUniverse.Name = "buttonCreateUniverse";
            this.buttonCreateUniverse.Size = new System.Drawing.Size(145, 28);
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
            this.theTree.Location = new System.Drawing.Point(-10, 135);
            this.theTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.theTree.Name = "theTree";
            treeNode3.Name = "NodeInput";
            treeNode3.Text = "Inputs";
            treeNode4.Name = "NodeOutput";
            treeNode4.Text = "Output";
            this.theTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.theTree.Size = new System.Drawing.Size(184, 217);
            this.theTree.TabIndex = 1;
            this.toolTip1.SetToolTip(this.theTree, "Feel free to add universe without the order");
            this.theTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.theTree_AfterSelect);
            // 
            // mainchart
            // 
            chartArea3.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea3.Name = "ChartArea1";
            this.mainchart.ChartAreas.Add(chartArea3);
            this.mainchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.mainchart.Legends.Add(legend3);
            this.mainchart.Location = new System.Drawing.Point(0, 0);
            this.mainchart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainchart.Name = "mainchart";
            this.mainchart.Size = new System.Drawing.Size(863, 508);
            this.mainchart.TabIndex = 2;
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Size = new System.Drawing.Size(1243, 791);
            this.splitContainer1.SplitterDistance = 376;
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
            this.splitContainer2.Panel1.Controls.Add(this.radiobtnSugeno);
            this.splitContainer2.Panel1.Controls.Add(this.radiobtnTsukamoto);
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            this.splitContainer2.Panel1.Controls.Add(this.radiobtnMamdani);
            this.splitContainer2.Panel1.Controls.Add(this.buttonCreateUniverse);
            this.splitContainer2.Panel1.Controls.Add(this.theTree);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Aqua;
            this.splitContainer2.Panel2.Controls.Add(this.tbcswitch);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(376, 791);
            this.splitContainer2.SplitterDistance = 467;
            this.splitContainer2.TabIndex = 0;
            // 
            // radiobtnSugeno
            // 
            this.radiobtnSugeno.AutoSize = true;
            this.radiobtnSugeno.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnSugeno.Location = new System.Drawing.Point(7, 33);
            this.radiobtnSugeno.Name = "radiobtnSugeno";
            this.radiobtnSugeno.Size = new System.Drawing.Size(70, 20);
            this.radiobtnSugeno.TabIndex = 5;
            this.radiobtnSugeno.Text = "Sugeno";
            this.radiobtnSugeno.UseVisualStyleBackColor = true;
            this.radiobtnSugeno.CheckedChanged += new System.EventHandler(this.radiobtnSugeno_CheckedChanged);
            this.radiobtnSugeno.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radiobtnTsukamoto
            // 
            this.radiobtnTsukamoto.AutoSize = true;
            this.radiobtnTsukamoto.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnTsukamoto.Location = new System.Drawing.Point(6, 59);
            this.radiobtnTsukamoto.Name = "radiobtnTsukamoto";
            this.radiobtnTsukamoto.Size = new System.Drawing.Size(89, 20);
            this.radiobtnTsukamoto.TabIndex = 6;
            this.radiobtnTsukamoto.Text = "Tsukamoto";
            this.radiobtnTsukamoto.UseVisualStyleBackColor = true;
            this.radiobtnTsukamoto.CheckedChanged += new System.EventHandler(this.radiobtnTsukamoto_CheckedChanged);
            this.radiobtnTsukamoto.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.theGrid);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnOpen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(176, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 467);
            this.panel3.TabIndex = 17;
            // 
            // theGrid
            // 
            this.theGrid.Location = new System.Drawing.Point(4, 135);
            this.theGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.theGrid.Name = "theGrid";
            this.theGrid.Size = new System.Drawing.Size(186, 217);
            this.theGrid.TabIndex = 3;
            this.theGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.theGrid_PropertyValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(4, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(95, 96);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 20;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // radiobtnMamdani
            // 
            this.radiobtnMamdani.AutoSize = true;
            this.radiobtnMamdani.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radiobtnMamdani.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnMamdani.Location = new System.Drawing.Point(7, 7);
            this.radiobtnMamdani.Name = "radiobtnMamdani";
            this.radiobtnMamdani.Size = new System.Drawing.Size(88, 20);
            this.radiobtnMamdani.TabIndex = 4;
            this.radiobtnMamdani.Text = "Mandanmi";
            this.radiobtnMamdani.UseVisualStyleBackColor = true;
            this.radiobtnMamdani.CheckedChanged += new System.EventHandler(this.radiobtnMamdani_CheckedChanged);
            this.radiobtnMamdani.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // tbcswitch
            // 
            this.tbcswitch.Controls.Add(this.tabPageFs);
            this.tbcswitch.Controls.Add(this.tabPageRules);
            this.tbcswitch.Controls.Add(this.tabPageSystem);
            this.tbcswitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcswitch.Location = new System.Drawing.Point(0, 0);
            this.tbcswitch.Name = "tbcswitch";
            this.tbcswitch.SelectedIndex = 0;
            this.tbcswitch.Size = new System.Drawing.Size(376, 320);
            this.tbcswitch.TabIndex = 14;
            this.tbcswitch.Tag = "";
            // 
            // tabPageFs
            // 
            this.tabPageFs.Controls.Add(this.btnAddEquation);
            this.tabPageFs.Controls.Add(this.listBoxEquation);
            this.tabPageFs.Controls.Add(this.btnCreateBinaryFuzzySet);
            this.tabPageFs.Controls.Add(this.label1);
            this.tabPageFs.Controls.Add(this.comboBoxSelectFS);
            this.tabPageFs.Controls.Add(this.btnCreateFuzzySet);
            this.tabPageFs.Controls.Add(this.labRightFS);
            this.tabPageFs.Controls.Add(this.cbxBinaryOperator);
            this.tabPageFs.Controls.Add(this.labLeftFS);
            this.tabPageFs.Controls.Add(this.btnDeleteFuzzySet);
            this.tabPageFs.Controls.Add(this.label2);
            this.tabPageFs.Controls.Add(this.cbxUnaryOperator);
            this.tabPageFs.Controls.Add(this.btnCreatedUnaryOperatedFS);
            this.tabPageFs.Location = new System.Drawing.Point(4, 24);
            this.tabPageFs.Name = "tabPageFs";
            this.tabPageFs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFs.Size = new System.Drawing.Size(368, 292);
            this.tabPageFs.TabIndex = 0;
            this.tabPageFs.Text = "Fuzzyset";
            this.tabPageFs.UseVisualStyleBackColor = true;
            // 
            // btnAddEquation
            // 
            this.btnAddEquation.Location = new System.Drawing.Point(199, 12);
            this.btnAddEquation.Name = "btnAddEquation";
            this.btnAddEquation.Size = new System.Drawing.Size(86, 24);
            this.btnAddEquation.TabIndex = 21;
            this.btnAddEquation.Text = "AddEquation";
            this.btnAddEquation.UseVisualStyleBackColor = true;
            this.btnAddEquation.Click += new System.EventHandler(this.btnAddEquation_Click);
            // 
            // listBoxEquation
            // 
            this.listBoxEquation.FormattingEnabled = true;
            this.listBoxEquation.ItemHeight = 15;
            this.listBoxEquation.Items.AddRange(new object[] {
            "Z = -X +Y+1",
            "Z =-Y+3",
            "Z = -X +3",
            "Z = X+Y+2"});
            this.listBoxEquation.Location = new System.Drawing.Point(199, 42);
            this.listBoxEquation.Name = "listBoxEquation";
            this.listBoxEquation.Size = new System.Drawing.Size(128, 79);
            this.listBoxEquation.TabIndex = 0;
            this.listBoxEquation.SelectedIndexChanged += new System.EventHandler(this.listBoxEquation_SelectedIndexChanged);
            // 
            // btnCreateBinaryFuzzySet
            // 
            this.btnCreateBinaryFuzzySet.Location = new System.Drawing.Point(3, 234);
            this.btnCreateBinaryFuzzySet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateBinaryFuzzySet.Name = "btnCreateBinaryFuzzySet";
            this.btnCreateBinaryFuzzySet.Size = new System.Drawing.Size(81, 50);
            this.btnCreateBinaryFuzzySet.TabIndex = 15;
            this.btnCreateBinaryFuzzySet.Text = "CreateBinaryOperatedFS";
            this.btnCreateBinaryFuzzySet.UseVisualStyleBackColor = true;
            this.btnCreateBinaryFuzzySet.Click += new System.EventHandler(this.btnCreateBinaryFuzzySet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "UnaryOperatedFs";
            // 
            // comboBoxSelectFS
            // 
            this.comboBoxSelectFS.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSelectFS.FormattingEnabled = true;
            this.comboBoxSelectFS.Items.AddRange(new object[] {
            "Gaussian FS",
            "S FS",
            "Z FS",
            "Pi FS",
            "Bell FS",
            "Triangle FS",
            "TwoSidedPi FS",
            "TwoSidedGaussian FS",
            "StepDown FS",
            "StepUp FS",
            "Sigmoid FS",
            "negative Sigmoid FS"});
            this.comboBoxSelectFS.Location = new System.Drawing.Point(3, 42);
            this.comboBoxSelectFS.Name = "comboBoxSelectFS";
            this.comboBoxSelectFS.Size = new System.Drawing.Size(175, 23);
            this.comboBoxSelectFS.TabIndex = 5;
            // 
            // btnCreateFuzzySet
            // 
            this.btnCreateFuzzySet.Location = new System.Drawing.Point(3, 7);
            this.btnCreateFuzzySet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateFuzzySet.Name = "btnCreateFuzzySet";
            this.btnCreateFuzzySet.Size = new System.Drawing.Size(80, 29);
            this.btnCreateFuzzySet.TabIndex = 4;
            this.btnCreateFuzzySet.Text = "CreateFuzzySet";
            this.btnCreateFuzzySet.UseVisualStyleBackColor = true;
            this.btnCreateFuzzySet.Click += new System.EventHandler(this.btnCreateFuzzySet_Click);
            // 
            // labRightFS
            // 
            this.labRightFS.AutoSize = true;
            this.labRightFS.Location = new System.Drawing.Point(111, 224);
            this.labRightFS.Name = "labRightFS";
            this.labRightFS.Size = new System.Drawing.Size(56, 15);
            this.labRightFS.TabIndex = 12;
            this.labRightFS.Text = "SelectRFS";
            this.labRightFS.Click += new System.EventHandler(this.labRightFS_Click);
            // 
            // cbxBinaryOperator
            // 
            this.cbxBinaryOperator.FormattingEnabled = true;
            this.cbxBinaryOperator.Items.AddRange(new object[] {
            "Intersection ",
            "Algebraic product",
            "Minimum",
            "Union"});
            this.cbxBinaryOperator.Location = new System.Drawing.Point(3, 204);
            this.cbxBinaryOperator.Name = "cbxBinaryOperator";
            this.cbxBinaryOperator.Size = new System.Drawing.Size(81, 23);
            this.cbxBinaryOperator.TabIndex = 14;
            // 
            // labLeftFS
            // 
            this.labLeftFS.AutoSize = true;
            this.labLeftFS.Location = new System.Drawing.Point(112, 184);
            this.labLeftFS.Name = "labLeftFS";
            this.labLeftFS.Size = new System.Drawing.Size(55, 15);
            this.labLeftFS.TabIndex = 11;
            this.labLeftFS.Text = "SelectLFS";
            this.labLeftFS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labLeftFS.Click += new System.EventHandler(this.labLeftFS_Click);
            // 
            // btnDeleteFuzzySet
            // 
            this.btnDeleteFuzzySet.Location = new System.Drawing.Point(89, 7);
            this.btnDeleteFuzzySet.Name = "btnDeleteFuzzySet";
            this.btnDeleteFuzzySet.Size = new System.Drawing.Size(89, 29);
            this.btnDeleteFuzzySet.TabIndex = 6;
            this.btnDeleteFuzzySet.Text = "Delete FuzzySet";
            this.btnDeleteFuzzySet.UseVisualStyleBackColor = true;
            this.btnDeleteFuzzySet.Click += new System.EventHandler(this.btnDeleteFuzzySet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "BinaryOperatedFs";
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
            "Yager\'s negate",
            "scale"});
            this.cbxUnaryOperator.Location = new System.Drawing.Point(3, 131);
            this.cbxUnaryOperator.Name = "cbxUnaryOperator";
            this.cbxUnaryOperator.Size = new System.Drawing.Size(167, 23);
            this.cbxUnaryOperator.TabIndex = 7;
            // 
            // btnCreatedUnaryOperatedFS
            // 
            this.btnCreatedUnaryOperatedFS.Location = new System.Drawing.Point(3, 97);
            this.btnCreatedUnaryOperatedFS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreatedUnaryOperatedFS.Name = "btnCreatedUnaryOperatedFS";
            this.btnCreatedUnaryOperatedFS.Size = new System.Drawing.Size(167, 29);
            this.btnCreatedUnaryOperatedFS.TabIndex = 10;
            this.btnCreatedUnaryOperatedFS.Text = "CreateUnaryOperatedFS";
            this.btnCreatedUnaryOperatedFS.UseVisualStyleBackColor = true;
            this.btnCreatedUnaryOperatedFS.Click += new System.EventHandler(this.btnCreatedUnaryOperatedFS_Click);
            // 
            // tabPageRules
            // 
            this.tabPageRules.Controls.Add(this.splitContainer3);
            this.tabPageRules.Location = new System.Drawing.Point(4, 24);
            this.tabPageRules.Name = "tabPageRules";
            this.tabPageRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRules.Size = new System.Drawing.Size(368, 292);
            this.tabPageRules.TabIndex = 1;
            this.tabPageRules.Text = "IfthenRules";
            this.tabPageRules.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.Azure;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btndeleteRules);
            this.splitContainer3.Panel1.Controls.Add(this.dgvRules);
            this.splitContainer3.Panel1.Controls.Add(this.btnAddRules);
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnDeleteInferenceResult);
            this.splitContainer3.Panel2.Controls.Add(this.dgvCondition);
            this.splitContainer3.Panel2.Controls.Add(this.btnInference);
            this.splitContainer3.Size = new System.Drawing.Size(362, 286);
            this.splitContainer3.SplitterDistance = 140;
            this.splitContainer3.TabIndex = 4;
            // 
            // btndeleteRules
            // 
            this.btndeleteRules.Location = new System.Drawing.Point(92, 14);
            this.btndeleteRules.Name = "btndeleteRules";
            this.btndeleteRules.Size = new System.Drawing.Size(75, 23);
            this.btndeleteRules.TabIndex = 19;
            this.btndeleteRules.Text = "Delete rules";
            this.btndeleteRules.UseVisualStyleBackColor = true;
            this.btndeleteRules.Click += new System.EventHandler(this.btndeleteRules_Click);
            // 
            // dgvRules
            // 
            this.dgvRules.AllowUserToAddRows = false;
            this.dgvRules.AllowUserToDeleteRows = false;
            this.dgvRules.AllowUserToResizeColumns = false;
            this.dgvRules.AllowUserToResizeRows = false;
            this.dgvRules.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Location = new System.Drawing.Point(4, 43);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.RowHeadersWidth = 62;
            this.dgvRules.RowTemplate.Height = 31;
            this.dgvRules.Size = new System.Drawing.Size(317, 97);
            this.dgvRules.TabIndex = 17;
            this.dgvRules.AllowUserToDeleteRowsChanged += new System.EventHandler(this.dgvRules_AllowUserToDeleteRowsChanged);
            this.dgvRules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRules_CellClick);
            // 
            // btnAddRules
            // 
            this.btnAddRules.Location = new System.Drawing.Point(4, 14);
            this.btnAddRules.Name = "btnAddRules";
            this.btnAddRules.Size = new System.Drawing.Size(75, 23);
            this.btnAddRules.TabIndex = 18;
            this.btnAddRules.Text = "Add rules";
            this.btnAddRules.UseVisualStyleBackColor = true;
            this.btnAddRules.Click += new System.EventHandler(this.btnAddRules_Click);
            // 
            // btnDeleteInferenceResult
            // 
            this.btnDeleteInferenceResult.Location = new System.Drawing.Point(140, 2);
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
            this.dgvCondition.Size = new System.Drawing.Size(315, 90);
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
            // tabPageSystem
            // 
            this.tabPageSystem.Controls.Add(this.btnCrispInCrispOut);
            this.tabPageSystem.Controls.Add(this.ppgSystem);
            this.tabPageSystem.Location = new System.Drawing.Point(4, 24);
            this.tabPageSystem.Name = "tabPageSystem";
            this.tabPageSystem.Size = new System.Drawing.Size(368, 292);
            this.tabPageSystem.TabIndex = 2;
            this.tabPageSystem.Text = "System";
            this.tabPageSystem.UseVisualStyleBackColor = true;
            // 
            // btnCrispInCrispOut
            // 
            this.btnCrispInCrispOut.Location = new System.Drawing.Point(206, 24);
            this.btnCrispInCrispOut.Name = "btnCrispInCrispOut";
            this.btnCrispInCrispOut.Size = new System.Drawing.Size(86, 71);
            this.btnCrispInCrispOut.TabIndex = 20;
            this.btnCrispInCrispOut.Text = "Crisp In Crisp out";
            this.btnCrispInCrispOut.UseVisualStyleBackColor = true;
            this.btnCrispInCrispOut.Click += new System.EventHandler(this.btnCrispInCrispOut_Click_1);
            // 
            // ppgSystem
            // 
            this.ppgSystem.Location = new System.Drawing.Point(3, 24);
            this.ppgSystem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ppgSystem.Name = "ppgSystem";
            this.ppgSystem.Size = new System.Drawing.Size(186, 203);
            this.ppgSystem.TabIndex = 19;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.mainchart);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.panelsettings);
            this.splitContainer4.Size = new System.Drawing.Size(863, 791);
            this.splitContainer4.SplitterDistance = 508;
            this.splitContainer4.TabIndex = 9;
            // 
            // panelsettings
            // 
            this.panelsettings.Controls.Add(this.tchartOutput);
            this.panelsettings.Controls.Add(this.chart2Doutput);
            this.panelsettings.Controls.Add(this.chartController1);
            this.panelsettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelsettings.Location = new System.Drawing.Point(0, 0);
            this.panelsettings.Name = "panelsettings";
            this.panelsettings.Size = new System.Drawing.Size(863, 279);
            this.panelsettings.TabIndex = 1;
            // 
            // tchartOutput
            // 
            // 
            // 
            // 
            this.tchartOutput.Aspect.HorizOffset = -9;
            this.tchartOutput.Aspect.HorizOffsetFloat = -9D;
            this.tchartOutput.Aspect.Zoom = 46;
            this.tchartOutput.Aspect.ZoomFloat = 46D;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tchartOutput.Axes.Depth.LabelsAsSeriesTitles = true;
            this.tchartOutput.Axes.Depth.Visible = true;
            // 
            // 
            // 
            this.tchartOutput.Axes.DepthTop.LabelsAsSeriesTitles = true;
            this.tchartOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.tchartOutput.Legend.Visible = false;
            this.tchartOutput.Location = new System.Drawing.Point(0, 25);
            this.tchartOutput.Name = "tchartOutput";
            this.tchartOutput.Series.Add(this.surface1);
            this.tchartOutput.Size = new System.Drawing.Size(863, 254);
            this.tchartOutput.TabIndex = 0;
            this.tchartOutput.Click += new System.EventHandler(this.tchartOutput_Click);
            // 
            // surface1
            // 
            // 
            // 
            // 
            this.surface1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            this.surface1.Brush.Gradient.Transparency = 1;
            this.surface1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.surface1.ColorEach = false;
            this.surface1.PaletteMin = 0D;
            this.surface1.PaletteStep = 0D;
            this.surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.GrayScale;
            this.surface1.SmoothPalette = true;
            this.surface1.Title = "surface";
            // 
            // 
            // 
            this.surface1.XValues.DataMember = "X";
            // 
            // 
            // 
            this.surface1.YValues.DataMember = "Y";
            // 
            // 
            // 
            this.surface1.ZValues.DataMember = "Z";
            // 
            // chart2Doutput
            // 
            chartArea4.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea4.Name = "ChartArea1";
            this.chart2Doutput.ChartAreas.Add(chartArea4);
            this.chart2Doutput.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart2Doutput.Legends.Add(legend4);
            this.chart2Doutput.Location = new System.Drawing.Point(0, 25);
            this.chart2Doutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart2Doutput.Name = "chart2Doutput";
            this.chart2Doutput.Size = new System.Drawing.Size(863, 254);
            this.chart2Doutput.TabIndex = 3;
            this.chart2Doutput.Click += new System.EventHandler(this.chart2Doutput_Click);
            // 
            // chartController1
            // 
            this.chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
            this.chartController1.Chart = this.tchartOutput;
            this.chartController1.LabelValues = true;
            this.chartController1.Location = new System.Drawing.Point(0, 0);
            this.chartController1.Name = "chartController1";
            this.chartController1.Size = new System.Drawing.Size(863, 25);
            this.chartController1.TabIndex = 7;
            this.chartController1.Text = "chartController1";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 1500;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "txt";
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "txt";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1243, 808);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainchart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tbcswitch.ResumeLayout(false);
            this.tabPageFs.ResumeLayout(false);
            this.tabPageFs.PerformLayout();
            this.tabPageRules.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondition)).EndInit();
            this.tabPageSystem.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.panelsettings.ResumeLayout(false);
            this.panelsettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2Doutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateUniverse;
        private System.Windows.Forms.TreeView theTree;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainchart;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radiobtnTsukamoto;
        private System.Windows.Forms.RadioButton radiobtnSugeno;
        private System.Windows.Forms.RadioButton radiobtnMamdani;
        private Steema.TeeChart.TChart tchartOutput;
        private Steema.TeeChart.Styles.Surface surface1;
        private Steema.TeeChart.ChartController chartController1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2Doutput;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TabControl tbcswitch;
        private System.Windows.Forms.TabPage tabPageFs;
        private System.Windows.Forms.Button btnAddEquation;
        private System.Windows.Forms.ListBox listBoxEquation;
        private System.Windows.Forms.Button btnCreateBinaryFuzzySet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectFS;
        private System.Windows.Forms.Button btnCreateFuzzySet;
        private System.Windows.Forms.Label labRightFS;
        private System.Windows.Forms.ComboBox cbxBinaryOperator;
        private System.Windows.Forms.Label labLeftFS;
        private System.Windows.Forms.Button btnDeleteFuzzySet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxUnaryOperator;
        private System.Windows.Forms.Button btnCreatedUnaryOperatedFS;
        private System.Windows.Forms.TabPage tabPageRules;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dgvRules;
        private System.Windows.Forms.Button btnAddRules;
        private System.Windows.Forms.Button btnDeleteInferenceResult;
        private System.Windows.Forms.DataGridView dgvCondition;
        private System.Windows.Forms.Button btnInference;
        private System.Windows.Forms.TabPage tabPageSystem;
        private System.Windows.Forms.Button btnCrispInCrispOut;
        private System.Windows.Forms.PropertyGrid ppgSystem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PropertyGrid theGrid;
        private System.Windows.Forms.Panel panelsettings;
        private System.Windows.Forms.Button btndeleteRules;
    }
}

