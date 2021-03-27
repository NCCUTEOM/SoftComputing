using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Security.AccessControl;
using R09546014HungYLAss05.R09546014HungYLAss04;
using System.Collections;

namespace R09546014HungYLAss05
{
    public partial class Mainform : Form
    {


        public Mainform()
        {
            InitializeComponent();
            comboBoxSelectFS.SelectedIndex = 0;//預設選GaussianFS
            cbxUnaryOperator.SelectedIndex = 0;//預設選negate
            cbxBinaryOperator.SelectedIndex = 0;//預設選intersect

            //this.MouseHoverPanel1 += DetectHasSelectFs;
            btnCreateFuzzySet.Enabled = false;
            btnDeleteFuzzySet.Enabled = false;
            btnCreatedUnaryOperatedFS.Enabled = false;
            btnCreateBinaryFuzzySet.Enabled = false;
            cbxUnaryOperator.Enabled = false;
            cbxBinaryOperator.Enabled = false;
            //toolStripLabelBinaryOperator.Enabled = false;
            //toolStripLabelUnaryOperator.Enabled = false;
            //toolStripLabelFuzzySet.Enabled = false;
            mainchart.ChartAreas.Clear();
            splitContainer3.SendToBack();
            btnDeleteInferenceResult.Enabled = false;

            //default to choose "Inputs"
            TreeNode[] t = theTree.Nodes.Find("NodeInput",false);
            if(t != null)
            {
                theTree.SelectedNode = t[0];
                theTree.SelectedNode.BackColor = Color.RoyalBlue;
            }

            


        }


    










    //private void DetectHasSelectFs(object sender, EventArgs e)
    //{

    //    if (theTree is null)
    //    {
    //        btnCreatedOperatedFS.Enabled = false;
    //        btnDeleteFuzzySet.Enabled = false;
    //    }
    //    else if(!(theTree.SelectedNode.Tag is FuzzySet))
    //    {
    //        btnCreatedOperatedFS.Enabled = false;
    //        btnDeleteFuzzySet.Enabled = false;
    //    }
    //    else
    //    {
    //        btnCreatedOperatedFS.Enabled = true;
    //        btnDeleteFuzzySet.Enabled = true;
    //    }
    //}

    private void btnCreateUniverse_Click(object sender, EventArgs e)
        {
            
            Universe uobj = new Universe(mainchart);

            //Add a node to tree view
            TreeNode aNode = new TreeNode(uobj.Title);
            aNode.Tag = uobj;

            if (theTree.SelectedNode.Name == "NodeInput")
            {
                theTree.SelectedNode.BackColor = Color.Empty;

                //找到 NodeIuput 並加入child node
                TreeNode[] found = theTree.Nodes.Find("NodeInput", false);

                found[0].Nodes.Add(aNode);
                theTree.SelectedNode = aNode;
                theGrid.SelectedObject = uobj;

                dgvCondition.Columns.Add(uobj.Title, uobj.Title);
                if (dgvCondition.Rows.Count < 1) dgvCondition.Rows.Add();



            }
            else
            {
                theTree.SelectedNode.BackColor = Color.Empty;

                //紀錄已經增加唯一Output Universe
                theTree.SelectedNode.Checked = true;
                //找到 NodeOuput 並加入child node
                TreeNode[] found = theTree.Nodes.Find("NodeOutput", false);


                found[0].Nodes.Add(aNode);
                theTree.SelectedNode = aNode;
                theGrid.SelectedObject = uobj;

            }

            DataGridViewTextBoxColumn newcol = new DataGridViewTextBoxColumn();
            newcol.Name = uobj.Title;
            newcol.HeaderText = uobj.Title;

            //Make sure that Output's Universe add to last column


            if (theTree.SelectedNode.Parent.Name == "NodeInput")
            {
                TreeNode[] tmp = theTree.Nodes.Find("NodeOutput", false);
                if (tmp[0].Checked == true)
                {
                    dgvRules.Columns.Insert(Universe.count-2, newcol); 
                }

                
                else { dgvRules.Columns.Insert(Universe.count - 1, newcol); }
            }


            else { dgvRules.Columns.Add(newcol); }

            //dgvRules.Columns.Add(uobj.Title, uobj.Title);



            //header text要自行處理

            //delete rules自己處理











        }



        private void theTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (theTree.SelectedNode.Name == "NodeOutput")
            {


                if (theTree.SelectedNode.Nodes.Count == 1)
                {
                    buttonCreateUniverse.Enabled = false;
                    return;
                }
                
                else { buttonCreateUniverse.Enabled = true; }
            }
            else if (theTree.SelectedNode.Name == "NodeInput")
            {
                buttonCreateUniverse.Enabled = true;
            }
            else
            {
                buttonCreateUniverse.Enabled = false;
               
            }
        

        
        
            theGrid.SelectedObject = theTree.SelectedNode.Tag;

            if (theTree.SelectedNode.Tag is Universe)
            {
                btnCreateFuzzySet.Enabled = true;
                btnDeleteFuzzySet.Enabled = false;
                btnCreatedUnaryOperatedFS.Enabled = false;
            }

            if (theTree.SelectedNode.Tag is FuzzySet)
            {
                btnDeleteFuzzySet.Enabled = true;
                btnCreatedUnaryOperatedFS.Enabled = true;
                cbxUnaryOperator.Enabled = true;

            }
        }

        private void btnCreateFuzzySet_Click(object sender, EventArgs e)
        {
            FuzzySet aFs;
            Universe selectedU;

            if (theTree.SelectedNode.Tag is Universe)
            {
                selectedU = (Universe)theTree.SelectedNode.Tag;

                switch (comboBoxSelectFS.SelectedIndex)
                {
                    case 0:
                        aFs = new GaussianFuzzySet(selectedU);
                        break;
                    case 1:
                        aFs = new SFuzzySet(selectedU);
                        break;
                    case 2:
                        aFs = new ZFuzzySet(selectedU);
                        break;
                    case 3:
                        aFs = new PiFuzzySet(selectedU);
                        break;
                    case 4:
                        aFs = new BellFuzzySet(selectedU);
                        break;
                    case 5:
                        aFs = new TriangleFuzzySet(selectedU);
                        break;
                    case 6:
                        aFs = new twosidedPiFuzzySet(selectedU);
                        break;
                    case 7:
                        aFs = new twosidedGaussianFuzzySet(selectedU);
                        break;
                    default:
                        aFs = null;
                        break;
                }



                //Add a subnode to selected node
                TreeNode cNode = new TreeNode(aFs.Title);
                cNode.Tag = aFs;
                theTree.SelectedNode.Nodes.Add(cNode);

                aFs.ShowSeries = true;
            }
        }

        private void theGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            GridItem gi = e.ChangedItem;
            object ov = e.OldValue;



            if (theTree.SelectedNode.Tag is Universe) //左邊的物件是不是右邊的類別或父類別
            {
                //變更Universe tree node的名稱

                dgvRules.Columns[theTree.SelectedNode.Text].HeaderText = ((Universe)theTree.SelectedNode.Tag).Title;
                theTree.SelectedNode.Text = ((Universe)theTree.SelectedNode.Tag).Title;
               





            }
            else if (theTree.SelectedNode.Tag is FuzzySet && mainchart.Series.IndexOf(theTree.SelectedNode.Text) != -1)
            {
                //改變FuzzySet的Title時，mainchart連動改變
                mainchart.Series[theTree.SelectedNode.Text].Name = ((FuzzySet)theTree.SelectedNode.Tag).Title;

                //變更FuzzySet tree node的名稱
                theTree.SelectedNode.Text = ((FuzzySet)theTree.SelectedNode.Tag).Title;




            }
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        //private void comboBoxSelectFS_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int idx = comboBoxSelectFS.SelectedIndex;
        //    switch (idx)
        //    {
        //        case 0:
        //            break;

        //        case 1:
        //            break;

        //        case 2:
        //            break;

        //    }
        //}

        private void btnDeleteFuzzySet_Click(object sender, EventArgs e)
        {


            if (theTree.SelectedNode.Tag is FuzzySet)
            {
                
                mainchart.Series.Remove(((FuzzySet)theTree.SelectedNode.Tag).TheSeries);



                //find all fuzzyset in the same universe whose basefuuzzy set is the deleted one
                if (!(theTree.SelectedNode.Tag is UnaryOperatedFuzzySet))
                {
                    TreeNode u = theTree.SelectedNode.Parent;
                    foreach (TreeNode t in u.Nodes)
                    {

                        if (t.Tag is UnaryOperatedFuzzySet)
                        {

                            //如果此UnaryOperatedFuuzySet 的 baseSet 要被刪除，則一併刪除此UnaryOperatedFuzzySet
                            if (Object.ReferenceEquals(((UnaryOperatedFuzzySet)t.Tag).TheBaseFS, ((FuzzySet)theTree.SelectedNode.Tag)))
                            {
                                mainchart.Series.Remove(((FuzzySet)t.Tag).TheSeries);
                                theTree.Nodes.Remove(t);

                            }


                        }
                    }
                }

                if (!(theTree.SelectedNode.Tag is BinaryOperatedFuzzySet))
                {
                    TreeNode u = theTree.SelectedNode.Parent;
                    foreach (TreeNode t in u.Nodes)
                    {
                        //找同一個universe底下的BinaryOperatedFuzzySet
                        if (t.Tag is BinaryOperatedFuzzySet)
                        {

                            //如果此BinaryOperatedFuuzySet 的 baseSets 要被刪除，則一併刪除此BinaryOperatedFuzzySet
                            if (Object.ReferenceEquals(((BinaryOperatedFuzzySet)t.Tag).TheleftFS, ((FuzzySet)theTree.SelectedNode.Tag)) || Object.ReferenceEquals(((BinaryOperatedFuzzySet)t.Tag).TherightFS, ((FuzzySet)theTree.SelectedNode.Tag)))
                            {
                                mainchart.Series.Remove(((FuzzySet)t.Tag).TheSeries);
                                theTree.Nodes.Remove(t);

                            }


                        }
                    }
                }

                theTree.Nodes.Remove(theTree.SelectedNode);

            }





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreatedUnaryOperatedFS_Click(object sender, EventArgs e)
        {
            if (!(theTree.SelectedNode.Tag is FuzzySet)) return;

            FuzzySet fs = (FuzzySet)theTree.SelectedNode.Tag;
            UnaryFSOperator op = null;
            FuzzySet newFs = null;

            switch (cbxUnaryOperator.SelectedIndex)
            {
                case 0: //negate
                    newFs = !fs;

                    //op = new NegateOperator();

                    break;
                case 1:// value -cut
                    newFs = -fs;



                    //op = new ValueCutOperator();
                    break;

                case 2://concentrate
                    newFs = +fs;
                    op = new ConcentrateOperator();
                    newFs = new UnaryOperatedFuzzySet(fs, op);
                    break;

                case 3://dilate

                    newFs = --fs;
                    break;

                case 4://intensificate
                    newFs = ++fs;
                    //op = new IntensificateOperator();
                    //newFs = new UnaryOperatedFuzzySet(fs, op);
                    break;
                case 5://diminish
                    newFs = ~fs;
                    //op = new DiminishOperator();
                    //newFs = new UnaryOperatedFuzzySet(fs, op);
                    break;

                case 6://Sugeno's negate
                    newFs = 0.5+fs;
                    //op = new SugenoNegateOperator();
                    //newFs = new UnaryOperatedFuzzySet(fs, op);
                    break;

                case 7://Yager's negate
                    newFs = 0.5/fs;

                    //op = new YagerNegateOperator();
                    //newFs = new UnaryOperatedFuzzySet(fs, op);
                    break;
                        









            }
            //btnCreatedUnaryOperatedFS.Enabled = false;


            //newFs = new UnaryOperatedFuzzySet(fs, op);

            //Add a subnode to selected node

            TreeNode cNode = new TreeNode(newFs.Title);
            cNode.Tag = newFs;

            //把unaryoperated fuzzyset 加在被作用的fuzzyset底下
            theTree.SelectedNode.Parent.Nodes.Add(cNode);



            newFs.ShowSeries = true;

            theTree.ExpandAll();
            theTree.Focus();


        }

        private void labLeftFS_Click(object sender, EventArgs e)
        {
            if (theTree.SelectedNode.Tag is FuzzySet)
            {
                labLeftFS.Tag = theTree.SelectedNode.Tag;
                labLeftFS.Text = theTree.SelectedNode.Text;
            }
            else
            {
                labLeftFS.Tag = null;
                labLeftFS.Text = "Click to set left FS";
            }
            if (labRightFS.Tag != null && labLeftFS.Tag != null)
            {
                cbxBinaryOperator.Enabled = true;
                btnCreateBinaryFuzzySet.Enabled = true;
            }


        }

        private void labRightFS_Click(object sender, EventArgs e)
        {
            {
                if (theTree.SelectedNode.Tag is FuzzySet)
                {
                    labRightFS.Tag = theTree.SelectedNode.Tag;
                    labRightFS.Text = theTree.SelectedNode.Text;
                }
                else
                {
                    labRightFS.Tag = null;
                    labRightFS.Text = "Click to set right FS";
                }
            }
            if (labRightFS.Tag != null && labLeftFS.Tag != null)
            {
                btnCreateBinaryFuzzySet.Enabled = true;
                cbxBinaryOperator.Enabled = true;
            }

        }











        private void toolStripLabelFuzzySet_Click(object sender, EventArgs e)
        {
            foreach (ChartArea C in mainchart.ChartAreas)
            {
                C.Visible = true;
            }
        }

        private void toolStripLabelUnaryOperator_Click(object sender, EventArgs e)
        {
            foreach (ChartArea c in mainchart.ChartAreas)
            {
                if (theTree.Nodes.ContainsKey(c.AxisX.Title))
                {
                    TreeNode[] n = theTree.Nodes.Find(c.Name, false);
                    if (!(n[0].LastNode.Tag is UnaryOperatedFuzzySet))
                    {
                        c.Visible = false;
                    }

                }
                else
                {
                    c.Visible = false;
                }


            }
        }

        private void toolStripLabelBinaryOperator_DoubleClick(object sender, EventArgs e)
        {

        }

        private void toolStripLabelUnaryOperator_DoubleClick(object sender, EventArgs e)
        {
            foreach (ChartArea c in mainchart.ChartAreas)
            {
                if (theTree.Nodes.ContainsKey(c.Name))
                {
                    TreeNode[] n = theTree.Nodes.Find(c.Name, false);
                    if (!(n[0].LastNode.Tag is UnaryOperatedFuzzySet))
                    {
                        c.Visible = false;
                    }

                }
                else
                {
                    c.Visible = false;
                }


            }
        }


        //只秀出有Unaryopered FuzzySet的chartarea

        //private void toolStripLabelUnaryOperator_Click_1(object sender, EventArgs e)
        //{
        //    foreach (ChartArea c in mainchart.ChartAreas)
        //    {
        //        //先找 tree node->universe 
        //        TreeNode[] search = theTree.Nodes.Find(c.AxisX.Title, false);


        //        //找chartarea對應的node
        //        if (search != null && !c.Equals(mainchart.ChartAreas.Last()))
        //        {
        //            Console.WriteLine(search[0].Text);
        //            TreeNode t = search[0].NextNode;

        //            //找node-> fuzyset 並且遍歷此universe底下的fuzzyset
        //            c.Visible = FindUnaryFuzzySet(t);









        //        }
        //    }
        //}

        //    private bool FindUnaryFuzzySet(TreeNode t) {
        //        if (t is FuzzySet)
        //        {
        //            if (t is UnaryOperatedFuzzySet) return true;


        //            else
        //            {
        //                return FindUnaryFuzzySet(t.NextNode);
        //            }




        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void cbxUniaryOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateBinaryFuzzySet_Click(object sender, EventArgs e)
        {
            if (!(theTree.SelectedNode.Tag is FuzzySet)) return;

            FuzzySet lfs = (FuzzySet)labLeftFS.Tag;
            FuzzySet rfs = (FuzzySet)labRightFS.Tag;

            if (!lfs.TheUniverse.Equals(rfs.TheUniverse)) {
                labRightFS.Tag = null;
                labRightFS.Text = "SelectRFS";
                MessageBox.Show("Two FuzzySet need to share the same universe");
                return;

            }

            //BinaryFSOperator op = null;
            FuzzySet newFs = null;

            switch (cbxBinaryOperator.SelectedIndex)
            {
                case 0: //intersection
                    newFs = lfs & rfs;

                    //op = new NegateOperator();

                    break;
                case 1://Algebraic product
                    newFs = lfs + rfs;
                   


                    break;

                case 2://minium
                    newFs = lfs ^ rfs;
                   
                    break;

                case 3:// union
                    newFs = lfs | rfs;

                    break;


            }
            TreeNode cNode = new TreeNode(newFs.Title);
            cNode.Tag = newFs;

            theTree.SelectedNode.Parent.Nodes.Add(cNode);

            //theTree.SelectedNode.Nodes.Add(cNode);



            newFs.ShowSeries = true;

            theTree.ExpandAll();
            theTree.Focus();

            labRightFS.Tag = null;
            labRightFS.Text = "Select RFS";
            btnCreateBinaryFuzzySet.Enabled = false;

            //private void toolStripSwitchView_MouseHover(object sender, EventArgs e)
            //{
            //    toolStripSwitchView.Focus();
            //}

            //private void Mainform_MouseMove(object sender, MouseEventArgs e)
            //{
            //    if (MouseHoverPanel1 != null)
            //    {
            //        MouseHoverPanel1(this, null);

            //    }
        }

        private void txtboxUnaryParammeter_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgdRules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddRules_Click(object sender, EventArgs e)
        {
            dgvRules.Rows.Add();
        }

        private void dgvRules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell thecell = dgvRules.Rows[e.RowIndex].Cells[e.ColumnIndex];
            thecell.Style.BackColor = Color.DodgerBlue;

            //防錯 
            // ex:第0個universe放第0 row
            // ex:必須選到Fuzzyset才能放

            if (theTree.SelectedNode.Tag is Universe || theTree.SelectedNode.Parent.Text != dgvRules.Columns[e.ColumnIndex].HeaderText) return;

            thecell.Tag = theTree.SelectedNode.Tag;
            thecell.Value = theTree.SelectedNode.Tag;
        }

        private void btnInference_Click(object sender, EventArgs e)
        {
            //create if-then rules
            IfThenFuzzyRule[] allRules = new IfThenFuzzyRule[dgvRules.Rows.Count];
            FuzzySet output = null;
            for (int r = 0; r < dgvRules.Rows.Count; r++) {
                FuzzySet[] inputs = new FuzzySet[dgvRules.Columns.Count - 1];

                for (int c = 0; c < dgvRules.Columns.Count-1; c++) {
                    {
                        inputs[c] = (FuzzySet)dgvRules.Rows[r].Cells[c].Value;


                    }
                    output = (FuzzySet)dgvRules.Rows[r].Cells[dgvRules.Columns.Count -1].Value;
                    allRules[r] = new IfThenFuzzyRule(inputs, output);
                 }

            }
            //conditions

            FuzzySet[] condtions = new FuzzySet[dgvCondition.Columns.Count];

            //set contents of conditions

            for (int c = 0; c < dgvCondition.Columns.Count ; c++)
            {
                {
                    condtions[c] = (FuzzySet)dgvCondition.Rows[0].Cells[c].Value;

                }
            }



            FuzzySet resultinfFS = null;
            foreach (IfThenFuzzyRule rule in allRules)
            {
                if (resultinfFS == null) resultinfFS = rule.FuzzyInFuzzyOutInferencing(condtions);
                else
                {
                    //把推理結果聯集
                    resultinfFS = resultinfFS | rule.FuzzyInFuzzyOutInferencing(condtions);
                }
            }
            //Show the final FuzzySet
            resultinfFS.ShowSeries = true;
            resultinfFS.TheSeries.ChartType = SeriesChartType.Area;
            resultinfFS.TheSeries.Color = Color.FromArgb(50,output.TheSeries.Color);

            btnDeleteInferenceResult.Tag = resultinfFS;

            btnDeleteInferenceResult.Enabled = true;
        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            splitContainer3.SendToBack();
            splitContainer3.Enabled = false;
            splitContainer3.Visible = false;


        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            splitContainer3.BringToFront();
            splitContainer3.Enabled = true;
            splitContainer3.Visible = true;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void dgvCondition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell thecell = dgvCondition.Rows[e.RowIndex].Cells[e.ColumnIndex];
            thecell.Style.BackColor = Color.DodgerBlue;

            //防錯 
            // ex:第0個universe放第0 row
            // ex:必須選到Fuzzyset才能放

            if (theTree.SelectedNode.Tag is Universe || (theTree.SelectedNode.Parent.Text != dgvCondition.Columns[e.ColumnIndex].HeaderText)) return;

            thecell.Tag = theTree.SelectedNode.Tag;
            thecell.Value = theTree.SelectedNode.Tag;
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteInferenceResult_Click(object sender, EventArgs e)
        {
            btnDeleteInferenceResult.Enabled = false;
            mainchart.Series.Remove(((FuzzySet)btnDeleteInferenceResult.Tag).TheSeries);

        }









        //private void theTree_MouseMove(object sender, MouseEventArgs e)
        //{
        //    ToolTip toolTip1 = new ToolTip();
        //    toolTip1.UseAnimation = true;   //動畫效果
        //    toolTip1.UseFading = true;      //淡入淡出效果
        //    toolTip1.IsBalloon = true;      //氣球狀外觀
        //    toolTip1.ShowAlways = true;
        //    toolTip1.AutoPopDelay = 2000;    //工具提示保持可見的時間期限


        //}

        //private void theTree_MouseHover(object sender, EventArgs e)
        //{

        //    ToolTip toolTip1 = new ToolTip();
        //    toolTip1.UseAnimation = true;   //動畫效果
        //    toolTip1.UseFading = true;      //淡入淡出效果
        //    toolTip1.IsBalloon = true;      //氣球狀外觀
        //    toolTip1.ShowAlways = true;
        //    toolTip1.AutoPopDelay = 2000;    //工具提示保持可見的時間期限
        //    toolTip1.Show("Test",2000);


        //}
    }
}


    

