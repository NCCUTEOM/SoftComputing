namespace R09546014HungYLAss07
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBruteForce = new System.Windows.Forms.ToolStripButton();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvAssTable = new System.Windows.Forms.DataGridView();
            this.richTextBoxbruteforce = new System.Windows.Forms.RichTextBox();
            this.statusStripTime = new System.Windows.Forms.StatusStrip();
            this.labMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripBestAnswer = new System.Windows.Forms.StatusStrip();
            this.tspAnswer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssTable)).BeginInit();
            this.statusStripTime.SuspendLayout();
            this.statusStripBestAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonBruteForce});
            this.toolStrip1.Location = new System.Drawing.Point(0, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1196, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(85, 33);
            this.toolStripButtonOpen.Text = "Open";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonBruteForce
            // 
            this.toolStripButtonBruteForce.AutoSize = false;
            this.toolStripButtonBruteForce.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonBruteForce.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBruteForce.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonBruteForce.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBruteForce.Image")));
            this.toolStripButtonBruteForce.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBruteForce.Name = "toolStripButtonBruteForce";
            this.toolStripButtonBruteForce.Size = new System.Drawing.Size(120, 28);
            this.toolStripButtonBruteForce.Text = "Brute Force";
            this.toolStripButtonBruteForce.Click += new System.EventHandler(this.toolStripButtonBruteForce_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "*.aop";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1196, 36);
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(169, 34);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "aop";
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 74);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvAssTable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxbruteforce);
            this.splitContainer1.Size = new System.Drawing.Size(1196, 554);
            this.splitContainer1.SplitterDistance = 448;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvAssTable
            // 
            this.dgvAssTable.AllowUserToAddRows = false;
            this.dgvAssTable.AllowUserToDeleteRows = false;
            this.dgvAssTable.AllowUserToResizeColumns = false;
            this.dgvAssTable.AllowUserToResizeRows = false;
            this.dgvAssTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAssTable.Location = new System.Drawing.Point(0, 0);
            this.dgvAssTable.Name = "dgvAssTable";
            this.dgvAssTable.RowHeadersWidth = 62;
            this.dgvAssTable.RowTemplate.Height = 31;
            this.dgvAssTable.Size = new System.Drawing.Size(448, 564);
            this.dgvAssTable.TabIndex = 0;
            // 
            // richTextBoxbruteforce
            // 
            this.richTextBoxbruteforce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxbruteforce.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxbruteforce.Name = "richTextBoxbruteforce";
            this.richTextBoxbruteforce.Size = new System.Drawing.Size(744, 554);
            this.richTextBoxbruteforce.TabIndex = 3;
            this.richTextBoxbruteforce.Text = "";
            // 
            // statusStripTime
            // 
            this.statusStripTime.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labMessage,
            this.toolStripStatusLabel1});
            this.statusStripTime.Location = new System.Drawing.Point(0, 606);
            this.statusStripTime.Name = "statusStripTime";
            this.statusStripTime.Size = new System.Drawing.Size(1196, 22);
            this.statusStripTime.TabIndex = 3;
            this.statusStripTime.Text = "statusStrip1";
            this.statusStripTime.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked_1);
            // 
            // labMessage
            // 
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(0, 15);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1181, 15);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // statusStripBestAnswer
            // 
            this.statusStripBestAnswer.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripBestAnswer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspAnswer});
            this.statusStripBestAnswer.Location = new System.Drawing.Point(0, 584);
            this.statusStripBestAnswer.Name = "statusStripBestAnswer";
            this.statusStripBestAnswer.Size = new System.Drawing.Size(1196, 22);
            this.statusStripBestAnswer.TabIndex = 4;
            this.statusStripBestAnswer.Text = "statusStrip1";
            // 
            // tspAnswer
            // 
            this.tspAnswer.Name = "tspAnswer";
            this.tspAnswer.Size = new System.Drawing.Size(0, 15);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 628);
            this.Controls.Add(this.statusStripBestAnswer);
            this.Controls.Add(this.statusStripTime);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "MainForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssTable)).EndInit();
            this.statusStripTime.ResumeLayout(false);
            this.statusStripTime.PerformLayout();
            this.statusStripBestAnswer.ResumeLayout(false);
            this.statusStripBestAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBoxbruteforce;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripTime;
        private System.Windows.Forms.ToolStripStatusLabel labMessage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dgvAssTable;
        private System.Windows.Forms.StatusStrip statusStripBestAnswer;
        private System.Windows.Forms.ToolStripStatusLabel tspAnswer;
        private System.Windows.Forms.ToolStripButton toolStripButtonBruteForce;
    }
}

