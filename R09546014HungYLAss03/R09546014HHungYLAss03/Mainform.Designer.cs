namespace R09546014HHungYLAss03
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
            ((System.ComponentModel.ISupportInitialize)(this.mainchart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateUniverse
            // 
            this.buttonCreateUniverse.Location = new System.Drawing.Point(42, 21);
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
            this.theTree.Location = new System.Drawing.Point(42, 84);
            this.theTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.theTree.Name = "theTree";
            this.theTree.Size = new System.Drawing.Size(175, 183);
            this.theTree.TabIndex = 1;
            this.theTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.theTree_AfterSelect);
            // 
            // mainchart
            // 
            this.mainchart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.mainchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainchart.Legends.Add(legend1);
            this.mainchart.Location = new System.Drawing.Point(270, 84);
            this.mainchart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainchart.Name = "mainchart";
            this.mainchart.Size = new System.Drawing.Size(662, 406);
            this.mainchart.TabIndex = 2;
            // 
            // theGrid
            // 
            this.theGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.theGrid.Location = new System.Drawing.Point(41, 275);
            this.theGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.theGrid.Name = "theGrid";
            this.theGrid.Size = new System.Drawing.Size(176, 215);
            this.theGrid.TabIndex = 3;
            this.theGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.theGrid_PropertyValueChanged);
            // 
            // btnCreateFuzzySet
            // 
            this.btnCreateFuzzySet.Location = new System.Drawing.Point(270, 21);
            this.btnCreateFuzzySet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateFuzzySet.Name = "btnCreateFuzzySet";
            this.btnCreateFuzzySet.Size = new System.Drawing.Size(112, 29);
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
            "Triangle FS"});
            this.comboBoxSelectFS.Location = new System.Drawing.Point(569, 20);
            this.comboBoxSelectFS.Name = "comboBoxSelectFS";
            this.comboBoxSelectFS.Size = new System.Drawing.Size(164, 28);
            this.comboBoxSelectFS.TabIndex = 5;
            // 
            // btnDeleteFuzzySet
            // 
            this.btnDeleteFuzzySet.Location = new System.Drawing.Point(388, 20);
            this.btnDeleteFuzzySet.Name = "btnDeleteFuzzySet";
            this.btnDeleteFuzzySet.Size = new System.Drawing.Size(127, 30);
            this.btnDeleteFuzzySet.TabIndex = 6;
            this.btnDeleteFuzzySet.Text = "Delete FuzzySet";
            this.btnDeleteFuzzySet.UseVisualStyleBackColor = true;
            this.btnDeleteFuzzySet.Click += new System.EventHandler(this.btnDeleteFuzzySet_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.btnDeleteFuzzySet);
            this.Controls.Add(this.comboBoxSelectFS);
            this.Controls.Add(this.btnCreateFuzzySet);
            this.Controls.Add(this.theGrid);
            this.Controls.Add(this.mainchart);
            this.Controls.Add(this.theTree);
            this.Controls.Add(this.buttonCreateUniverse);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainchart)).EndInit();
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
    }
}

