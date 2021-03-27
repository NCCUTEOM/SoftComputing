namespace JobAssignmnetGAsolver
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyGridGAsolver = new System.Windows.Forms.PropertyGrid();
            this.dgvAssTable = new System.Windows.Forms.DataGridView();
            this.txtboxBestObjValue = new System.Windows.Forms.TextBox();
            this.labelBestobjValue = new System.Windows.Forms.Label();
            this.richtextboxBestAns = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbcSettings = new System.Windows.Forms.TabControl();
            this.tabpageProblem = new System.Windows.Forms.TabPage();
            this.tabPageGAsettings = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxPermutationMutation = new System.Windows.Forms.ComboBox();
            this.cbxPermutationXover = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPointCut = new System.Windows.Forms.ComboBox();
            this.labelcrossover = new System.Windows.Forms.Label();
            this.radiobtnPermutation = new System.Windows.Forms.RadioButton();
            this.radiobtnBinary = new System.Windows.Forms.RadioButton();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.labelpenalty = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnOneiteration = new System.Windows.Forms.Button();
            this.radioButtonStochastic = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.radioButtonDeterministic = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelHardConstraintViolation = new System.Windows.Forms.Label();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.richTextBoxViolation = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPopulation = new System.Windows.Forms.RichTextBox();
            this.theChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tbcSettings.SuspendLayout();
            this.tabpageProblem.SuspendLayout();
            this.tabPageGAsettings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 27);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // propertyGridGAsolver
            // 
            this.propertyGridGAsolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridGAsolver.Location = new System.Drawing.Point(0, 0);
            this.propertyGridGAsolver.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGridGAsolver.Name = "propertyGridGAsolver";
            this.propertyGridGAsolver.Size = new System.Drawing.Size(312, 500);
            this.propertyGridGAsolver.TabIndex = 2;
            // 
            // dgvAssTable
            // 
            this.dgvAssTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssTable.Location = new System.Drawing.Point(3, 3);
            this.dgvAssTable.Name = "dgvAssTable";
            this.dgvAssTable.ReadOnly = true;
            this.dgvAssTable.RowHeadersWidth = 62;
            this.dgvAssTable.RowTemplate.Height = 31;
            this.dgvAssTable.Size = new System.Drawing.Size(386, 683);
            this.dgvAssTable.TabIndex = 0;
            this.dgvAssTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssTable_CellContentClick);
            // 
            // txtboxBestObjValue
            // 
            this.txtboxBestObjValue.Location = new System.Drawing.Point(3, 56);
            this.txtboxBestObjValue.Name = "txtboxBestObjValue";
            this.txtboxBestObjValue.Size = new System.Drawing.Size(179, 29);
            this.txtboxBestObjValue.TabIndex = 11;
            this.txtboxBestObjValue.TextChanged += new System.EventHandler(this.txtboxBestObjValue_TextChanged);
            // 
            // labelBestobjValue
            // 
            this.labelBestobjValue.AutoSize = true;
            this.labelBestobjValue.Location = new System.Drawing.Point(3, 35);
            this.labelBestobjValue.Name = "labelBestobjValue";
            this.labelBestobjValue.Size = new System.Drawing.Size(157, 18);
            this.labelBestobjValue.TabIndex = 12;
            this.labelBestobjValue.Text = "Best Objective Value";
            // 
            // richtextboxBestAns
            // 
            this.richtextboxBestAns.Location = new System.Drawing.Point(3, 91);
            this.richtextboxBestAns.Name = "richtextboxBestAns";
            this.richtextboxBestAns.Size = new System.Drawing.Size(179, 123);
            this.richtextboxBestAns.TabIndex = 13;
            this.richtextboxBestAns.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbcSettings);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 675);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 4;
            // 
            // tbcSettings
            // 
            this.tbcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcSettings.Controls.Add(this.tabpageProblem);
            this.tbcSettings.Controls.Add(this.tabPageGAsettings);
            this.tbcSettings.Location = new System.Drawing.Point(0, 35);
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            this.tbcSettings.Size = new System.Drawing.Size(326, 721);
            this.tbcSettings.TabIndex = 9;
            // 
            // tabpageProblem
            // 
            this.tabpageProblem.Controls.Add(this.dgvAssTable);
            this.tabpageProblem.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabpageProblem.Location = new System.Drawing.Point(4, 28);
            this.tabpageProblem.Name = "tabpageProblem";
            this.tabpageProblem.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageProblem.Size = new System.Drawing.Size(318, 689);
            this.tabpageProblem.TabIndex = 0;
            this.tabpageProblem.Text = "Problem";
            this.tabpageProblem.UseVisualStyleBackColor = true;
            // 
            // tabPageGAsettings
            // 
            this.tabPageGAsettings.Controls.Add(this.splitContainer3);
            this.tabPageGAsettings.Location = new System.Drawing.Point(4, 28);
            this.tabPageGAsettings.Name = "tabPageGAsettings";
            this.tabPageGAsettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGAsettings.Size = new System.Drawing.Size(318, 689);
            this.tabPageGAsettings.TabIndex = 1;
            this.tabPageGAsettings.Text = "GA Settings";
            this.tabPageGAsettings.UseVisualStyleBackColor = true;
            this.tabPageGAsettings.Click += new System.EventHandler(this.tabPageGAsettings_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOneiteration);
            this.panel1.Controls.Add(this.cbxPermutationMutation);
            this.panel1.Controls.Add(this.cbxPermutationXover);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Controls.Add(this.cbxPointCut);
            this.panel1.Controls.Add(this.labelcrossover);
            this.panel1.Controls.Add(this.radiobtnPermutation);
            this.panel1.Controls.Add(this.radiobtnBinary);
            this.panel1.Controls.Add(this.txtPenalty);
            this.panel1.Controls.Add(this.labelpenalty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 179);
            this.panel1.TabIndex = 0;
            // 
            // cbxPermutationMutation
            // 
            this.cbxPermutationMutation.FormattingEnabled = true;
            this.cbxPermutationMutation.Items.AddRange(new object[] {
            "Swap",
            "Inversion",
            "Insertion",
            "Displacemnt"});
            this.cbxPermutationMutation.Location = new System.Drawing.Point(115, 176);
            this.cbxPermutationMutation.Name = "cbxPermutationMutation";
            this.cbxPermutationMutation.Size = new System.Drawing.Size(151, 26);
            this.cbxPermutationMutation.TabIndex = 14;
            this.cbxPermutationMutation.SelectedIndexChanged += new System.EventHandler(this.cbxPermutationMutation_SelectedIndexChanged);
            // 
            // cbxPermutationXover
            // 
            this.cbxPermutationXover.FormattingEnabled = true;
            this.cbxPermutationXover.Items.AddRange(new object[] {
            "PMX",
            "Order Crossover",
            "Position-Based Crossover",
            "Order-Based Crossover",
            "Cycle Crossover",
            "SubtourExcahnge Crossover",
            "",
            "  "});
            this.cbxPermutationXover.Location = new System.Drawing.Point(115, 144);
            this.cbxPermutationXover.Name = "cbxPermutationXover";
            this.cbxPermutationXover.Size = new System.Drawing.Size(151, 26);
            this.cbxPermutationXover.TabIndex = 13;
            this.cbxPermutationXover.SelectedIndexChanged += new System.EventHandler(this.cbxPermutationXover_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mutation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Crossover";
            // 
            // cbxPointCut
            // 
            this.cbxPointCut.FormattingEnabled = true;
            this.cbxPointCut.Items.AddRange(new object[] {
            "One-point Cut",
            "Two-point Cut"});
            this.cbxPointCut.Location = new System.Drawing.Point(115, 35);
            this.cbxPointCut.Name = "cbxPointCut";
            this.cbxPointCut.Size = new System.Drawing.Size(151, 26);
            this.cbxPointCut.TabIndex = 10;
            this.cbxPointCut.SelectedIndexChanged += new System.EventHandler(this.cbxPointCut_SelectedIndexChanged);
            // 
            // labelcrossover
            // 
            this.labelcrossover.AutoSize = true;
            this.labelcrossover.Location = new System.Drawing.Point(32, 43);
            this.labelcrossover.Name = "labelcrossover";
            this.labelcrossover.Size = new System.Drawing.Size(77, 18);
            this.labelcrossover.TabIndex = 9;
            this.labelcrossover.Text = "Crossover";
            // 
            // radiobtnPermutation
            // 
            this.radiobtnPermutation.AutoSize = true;
            this.radiobtnPermutation.Location = new System.Drawing.Point(4, 107);
            this.radiobtnPermutation.Margin = new System.Windows.Forms.Padding(4);
            this.radiobtnPermutation.Name = "radiobtnPermutation";
            this.radiobtnPermutation.Size = new System.Drawing.Size(140, 22);
            this.radiobtnPermutation.TabIndex = 4;
            this.radiobtnPermutation.Text = "PermutationGA";
            this.radiobtnPermutation.UseVisualStyleBackColor = true;
            this.radiobtnPermutation.CheckedChanged += new System.EventHandler(this.radiobtnPermutation_CheckedChanged);
            // 
            // radiobtnBinary
            // 
            this.radiobtnBinary.AutoSize = true;
            this.radiobtnBinary.Checked = true;
            this.radiobtnBinary.Location = new System.Drawing.Point(4, 4);
            this.radiobtnBinary.Margin = new System.Windows.Forms.Padding(4);
            this.radiobtnBinary.Name = "radiobtnBinary";
            this.radiobtnBinary.Size = new System.Drawing.Size(103, 22);
            this.radiobtnBinary.TabIndex = 5;
            this.radiobtnBinary.TabStop = true;
            this.radiobtnBinary.Text = "BinaryGA";
            this.radiobtnBinary.UseVisualStyleBackColor = true;
            this.radiobtnBinary.CheckedChanged += new System.EventHandler(this.radiobtnBinary_CheckedChanged);
            this.radiobtnBinary.Click += new System.EventHandler(this.radiobtnBinary_Click);
            // 
            // txtPenalty
            // 
            this.txtPenalty.Location = new System.Drawing.Point(115, 67);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(100, 29);
            this.txtPenalty.TabIndex = 7;
            this.txtPenalty.TextChanged += new System.EventHandler(this.textPenalty_TextChanged);
            // 
            // labelpenalty
            // 
            this.labelpenalty.AutoSize = true;
            this.labelpenalty.Location = new System.Drawing.Point(32, 71);
            this.labelpenalty.Name = "labelpenalty";
            this.labelpenalty.Size = new System.Drawing.Size(59, 18);
            this.labelpenalty.TabIndex = 8;
            this.labelpenalty.Text = "Penalty";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            this.splitContainer3.Panel1.Controls.Add(this.radioButtonStochastic);
            this.splitContainer3.Panel1.Controls.Add(this.radioButtonDeterministic);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.propertyGridGAsolver);
            this.splitContainer3.Size = new System.Drawing.Size(312, 683);
            this.splitContainer3.SplitterDistance = 179;
            this.splitContainer3.TabIndex = 24;
            // 
            // btnOneiteration
            // 
            this.btnOneiteration.Location = new System.Drawing.Point(122, 208);
            this.btnOneiteration.Name = "btnOneiteration";
            this.btnOneiteration.Size = new System.Drawing.Size(130, 48);
            this.btnOneiteration.TabIndex = 17;
            this.btnOneiteration.Text = "One-iteration";
            this.btnOneiteration.UseVisualStyleBackColor = true;
            this.btnOneiteration.Click += new System.EventHandler(this.btnOneiteration_Click);
            // 
            // radioButtonStochastic
            // 
            this.radioButtonStochastic.AutoSize = true;
            this.radioButtonStochastic.Location = new System.Drawing.Point(278, 255);
            this.radioButtonStochastic.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonStochastic.Name = "radioButtonStochastic";
            this.radioButtonStochastic.Size = new System.Drawing.Size(104, 22);
            this.radioButtonStochastic.TabIndex = 23;
            this.radioButtonStochastic.Text = "Stochastic";
            this.radioButtonStochastic.UseVisualStyleBackColor = true;
            this.radioButtonStochastic.CheckedChanged += new System.EventHandler(this.radioButtonStochastic_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(7, 211);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 48);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // radioButtonDeterministic
            // 
            this.radioButtonDeterministic.AutoSize = true;
            this.radioButtonDeterministic.Checked = true;
            this.radioButtonDeterministic.Location = new System.Drawing.Point(124, 254);
            this.radioButtonDeterministic.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDeterministic.Name = "radioButtonDeterministic";
            this.radioButtonDeterministic.Size = new System.Drawing.Size(128, 22);
            this.radioButtonDeterministic.TabIndex = 22;
            this.radioButtonDeterministic.TabStop = true;
            this.radioButtonDeterministic.Text = "Deterministic";
            this.radioButtonDeterministic.UseVisualStyleBackColor = true;
            this.radioButtonDeterministic.CheckedChanged += new System.EventHandler(this.radioButtonDeterministic_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Selection mode";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(259, 211);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(106, 48);
            this.btnRun.TabIndex = 18;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
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
            this.splitContainer2.Panel1.Controls.Add(this.labelHardConstraintViolation);
            this.splitContainer2.Panel1.Controls.Add(this.labelPopulation);
            this.splitContainer2.Panel1.Controls.Add(this.richtextboxBestAns);
            this.splitContainer2.Panel1.Controls.Add(this.richTextBoxViolation);
            this.splitContainer2.Panel1.Controls.Add(this.txtboxBestObjValue);
            this.splitContainer2.Panel1.Controls.Add(this.labelBestobjValue);
            this.splitContainer2.Panel1.Controls.Add(this.richTextBoxPopulation);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.theChart);
            this.splitContainer2.Size = new System.Drawing.Size(870, 675);
            this.splitContainer2.SplitterDistance = 349;
            this.splitContainer2.TabIndex = 17;
            // 
            // labelHardConstraintViolation
            // 
            this.labelHardConstraintViolation.AutoSize = true;
            this.labelHardConstraintViolation.Location = new System.Drawing.Point(3, 228);
            this.labelHardConstraintViolation.Name = "labelHardConstraintViolation";
            this.labelHardConstraintViolation.Size = new System.Drawing.Size(187, 18);
            this.labelHardConstraintViolation.TabIndex = 15;
            this.labelHardConstraintViolation.Text = "Hard Constraint Violation";
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(202, 35);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(80, 18);
            this.labelPopulation.TabIndex = 17;
            this.labelPopulation.Text = "Population";
            // 
            // richTextBoxViolation
            // 
            this.richTextBoxViolation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxViolation.Location = new System.Drawing.Point(3, 261);
            this.richTextBoxViolation.Name = "richTextBoxViolation";
            this.richTextBoxViolation.Size = new System.Drawing.Size(179, 85);
            this.richTextBoxViolation.TabIndex = 16;
            this.richTextBoxViolation.Text = "";
            // 
            // richTextBoxPopulation
            // 
            this.richTextBoxPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxPopulation.Location = new System.Drawing.Point(194, 56);
            this.richTextBoxPopulation.Name = "richTextBoxPopulation";
            this.richTextBoxPopulation.Size = new System.Drawing.Size(673, 290);
            this.richTextBoxPopulation.TabIndex = 14;
            this.richTextBoxPopulation.Text = "";
            // 
            // theChart
            // 
            chartArea2.Name = "ChartArea1";
            this.theChart.ChartAreas.Add(chartArea2);
            this.theChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.theChart.Legends.Add(legend2);
            this.theChart.Location = new System.Drawing.Point(0, 0);
            this.theChart.Name = "theChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.theChart.Series.Add(series2);
            this.theChart.Size = new System.Drawing.Size(870, 322);
            this.theChart.TabIndex = 0;
            this.theChart.Text = "chart1";
            this.theChart.Click += new System.EventHandler(this.theChart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Mainform";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssTable)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tbcSettings.ResumeLayout(false);
            this.tabpageProblem.ResumeLayout(false);
            this.tabPageGAsettings.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid propertyGridGAsolver;
        private System.Windows.Forms.DataGridView dgvAssTable;
        private System.Windows.Forms.TextBox txtboxBestObjValue;
        private System.Windows.Forms.Label labelBestobjValue;
        private System.Windows.Forms.RichTextBox richtextboxBestAns;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBoxPopulation;
        private System.Windows.Forms.TabControl tbcSettings;
        private System.Windows.Forms.TabPage tabpageProblem;
        private System.Windows.Forms.TabPage tabPageGAsettings;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnOneiteration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxPermutationMutation;
        private System.Windows.Forms.ComboBox cbxPermutationXover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPointCut;
        private System.Windows.Forms.Label labelcrossover;
        private System.Windows.Forms.RadioButton radiobtnPermutation;
        private System.Windows.Forms.RadioButton radiobtnBinary;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Label labelpenalty;
        private System.Windows.Forms.RichTextBox richTextBoxViolation;
        private System.Windows.Forms.Label labelHardConstraintViolation;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart theChart;
        private System.Windows.Forms.Label labelPopulation;
        private System.Windows.Forms.RadioButton radioButtonStochastic;
        private System.Windows.Forms.RadioButton radioButtonDeterministic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}

