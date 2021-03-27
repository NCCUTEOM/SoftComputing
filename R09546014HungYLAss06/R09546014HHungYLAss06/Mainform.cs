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
using R09546014HungYLAss06.R09546014HungYLAss04;
using System.Collections;
using System.Net.Http.Headers;
using System.IO;
using r09546030caiyuzhuAss06;

namespace R09546014HungYLAss06
{
    public partial class Mainform : Form
    {

        public Mainform()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            
            radioButton1_Click(null, null);
            //DelegateEvent();




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
            btnAddEquation.Enabled = false;
            //toolStripLabelBinaryOperator.Enabled = false;
            //toolStripLabelUnaryOperator.Enabled = false;
            //toolStripLabelFuzzySet.Enabled = false;
            mainchart.ChartAreas.Clear();
            chart2Doutput.ChartAreas.Clear();
            splitContainer3.SendToBack();
            btnDeleteInferenceResult.Enabled = false;

            
            


            //default to choose "Inputs"
            TreeNode[] t = theTree.Nodes.Find("NodeInput",false);
            if(t != null)
            {
                theTree.SelectedNode = t[0];
                theTree.SelectedNode.BackColor = Color.RoyalBlue;
            }



            //cbxMtoCrispvalue.DataSource = Enum.GetValues(typeof(DefuzzificationType));
            
            

        }


        //private void DelegateEvent()
        //{
        //    radiobtnMamdani.Click += new System.EventHandler(radioButton1_Click);
        //    radiobtnMamdani.Checked = true;
        //    radiobtnSugeno.Click += new System.EventHandler(radioButton1_Click);
        //    radiobtnTsukamoto.Click += new System.EventHandler(radioButton1_Click);
        //}


        public event EventHandler theTreeisSelected;
        void theTreeSelect()
        {
            if (theTreeisSelected != null) theTreeisSelected(this, null);
        }
        public enum DefuzzificationType { COA, BOA,/* MOM,*/ SOM, LOM }

        //public bool Cut { get => checkBoxCut.Checked; }

        //public bool CheckBoxCut { get => checkBoxCut.Checked; }


        public int CbxSugeno { get => listBoxEquation.SelectedIndex; }

        static int InferenceTimes = 0;

        //public DefuzzificationType CbxMcripseValue { get => (DefuzzificationType)cbxMtoCrispvalue.SelectedItem; }















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
            if (theTree.SelectedNode.Tag is Universe && theTree.SelectedNode.Parent.Name == "NodeOutput") btnAddEquation.Enabled = true;
            else { btnAddEquation.Enabled = false; }
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
            TreeNode t = theTree.Nodes.Find("NodeOutput", false)[0];
            if ((t.Nodes.Count == 1))
            {
                t.BackColor = Color.Gray;
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
                    case 8:
                        aFs = new StepDownFuzzySet(selectedU);
                        break;
                    case 9:
                        aFs = new StepUpFuzzySet(selectedU);
                        break;
                    case 10:
                        aFs = new SigmoidFuzzySet(selectedU);
                        break;
                    case 11:
                        aFs = new negativeSigmoidFuzzySet(selectedU);
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
            //GridItem gi = e.ChangedItem;
            //object ov = e.OldValue;



            //if (theTree.SelectedNode.Tag is Universe) //左邊的物件是不是右邊的類別或父類別
            //{
            //    //變更Universe tree node的名稱

            //    dgvRules.Columns[theTree.SelectedNode.Text].HeaderText = ((Universe)theTree.SelectedNode.Tag).Title;
            //    theTree.SelectedNode.Text = ((Universe)theTree.SelectedNode.Tag).Title;






            //}
            //else if (theTree.SelectedNode.Tag is FuzzySet && mainchart.Series.IndexOf(theTree.SelectedNode.Text) != -1)
            //{
            //    //改變FuzzySet的Title時，mainchart連動改變
            //    mainchart.Series[theTree.SelectedNode.Text].Name = ((FuzzySet)theTree.SelectedNode.Tag).Title;

            //    //變更FuzzySet tree node的名稱
            //    theTree.SelectedNode.Text = ((FuzzySet)theTree.SelectedNode.Tag).Title;


            if (theTree.SelectedNode.Tag is Universe) //左邊的物件是不是右邊的類別或父類別
            {
                theTree.SelectedNode.Text = ((Universe)theTree.SelectedNode.Tag).Title;

                if(theTree.SelectedNode.Parent.Name == "NodeOutput")
                {
                    dgvRules.Columns[dgvRules.Columns.Count - 1].HeaderText = ((Universe)theTree.SelectedNode.Tag).Title;
                    dgvRules.Columns[dgvRules.Columns.Count - 1].Name = ((Universe)theTree.SelectedNode.Tag).Title;


                }
                else
                {
                    dgvRules.Columns[theTree.SelectedNode.Index].HeaderText = ((Universe)theTree.SelectedNode.Tag).Title;
                    dgvRules.Columns[theTree.SelectedNode.Index].Name = ((Universe)theTree.SelectedNode.Tag).Title;
                    dgvCondition.Columns[theTree.SelectedNode.Index].HeaderText = ((Universe)theTree.SelectedNode.Tag).Title;
                    dgvCondition.Columns[theTree.SelectedNode.Index].Name = ((Universe)theTree.SelectedNode.Tag).Title;

                    if(theTree.SelectedNode.Tag is FuzzySet) mainchart.Series[theTree.SelectedNode.Text].Name = ((FuzzySet)theTree.SelectedNode.Tag).Title;



                }

            }
            else if(theTree.SelectedNode.Tag is FuzzySet)
            {
                theTree.SelectedNode.Text = ((FuzzySet)theTree.SelectedNode.Tag).Title;
               
                if(e.OldValue is string)mainchart.Series[(string)e.OldValue].Name = ((FuzzySet)theTree.SelectedNode.Tag).Title;

            }


            //}
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

            if (theTree.SelectedNode.Tag is int) theTree.Nodes.Remove(theTree.SelectedNode);






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
                    break;

                case 8://Scale
                    newFs = 0.8 * fs;

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

        private void btnAddRules_Click(object sender, EventArgs e)
        {
            dgvRules.Rows.Add();
        }

        
        private void dgvRules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;//預防點擊錯誤

            DataGridViewCell thecell = dgvRules.Rows[e.RowIndex].Cells[e.ColumnIndex];
            thecell.Style.BackColor = Color.DodgerBlue;


            if (!(theTree.SelectedNode.Tag is FuzzySet) && !(theTree.SelectedNode.Tag is int)) { return; }
            else
            {

                //thecell.Tag = theTree.SelectedNode.Tag;
                thecell.Value = theTree.SelectedNode.Tag;

            }

            //防錯 
            // ex:第0個universe放第0 row
            // ex:必須選到Fuzzyset才能放

            //if (listBoxEquation.SelectedIndex != -1)
            //{

            //    thecell.Tag = listBoxEquation.SelectedItem;
            //    thecell.Value = listBoxEquation.SelectedIndex;
            //    listBoxEquation.SelectedItem = -1;
            //    listBoxEquation.ClearSelected();

            //}
            //else
            //{
                if (theTree.SelectedNode.Tag is Universe || theTree.SelectedNode.Parent.Text != dgvRules.Columns[e.ColumnIndex].HeaderText) { return; }
                else
                {

                    thecell.Tag = theTree.SelectedNode.Tag;
                    thecell.Value = theTree.SelectedNode.Tag;

                }
            //}
            }
            


            


        

        private void btnInference_Click(object sender, EventArgs e)
        {

            radioButton1_Click(null, null);

            //RadioButton clickedRdo = (RadioButton)sender;
            //RadioButton currentRdo = null;
            //if (radiobtnMamdani.Checked)
            //    

            //else if (radiobtnSugeno.Checked)
            //    currentRdo = radiobtnSugeno;
            //else if (radiobtnTsukamoto.Checked)
            //    currentRdo = radiobtnTsukamoto;

            if (mySystem is MamdaniFuzzySystem)
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
                if (!(dgvRules.Rows[r].Cells[dgvRules.Columns.Count - 1].Value is FuzzySet)) { MessageBox.Show("Conclusion need to be fuzzayset!"); return; }

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
                    if (resultinfFS == null) resultinfFS = rule.FuzzyInFuzzyOutInferencing(condtions,((MamdaniFuzzySystem)mySystem).IsCut);
                    else
                    {
                        //把推理結果聯集
                        resultinfFS = resultinfFS | rule.FuzzyInFuzzyOutInferencing(condtions, ((MamdaniFuzzySystem)mySystem).IsCut);
                    }
                }

                //Show the final FuzzySet
                resultinfFS.ShowSeries = true;
                resultinfFS.TheSeries.ChartType = SeriesChartType.Area;
                resultinfFS.TheSeries.Color = Color.FromArgb(50, output.TheSeries.Color);

                btnDeleteInferenceResult.Tag = resultinfFS;

                btnDeleteInferenceResult.Enabled = true;
            }

            else if(mySystem is SugenoFuzzySystem)
            {
                //create if-then rules
                SugenoIfThenRule[] allRules = new SugenoIfThenRule[dgvRules.Rows.Count];
             
                int output =0 ;
                for (int r = 0; r < dgvRules.Rows.Count; r++)
                {
                    FuzzySet[] inputs = new FuzzySet[dgvRules.Columns.Count - 1];

                    for (int c = 0; c < dgvRules.Columns.Count - 1; c++)
                    {

                        inputs[c] = (FuzzySet)dgvRules.Rows[r].Cells[c].Value;




                    }

                    if (!(dgvRules.Rows[r].Cells[dgvRules.Columns.Count - 1].Value is int)) { MessageBox.Show("Conclusion need to be an equation"); return; }




                    output = (int)dgvRules.Rows[r].Cells[dgvRules.Columns.Count - 1].Value;


                    allRules[r] = new SugenoIfThenRule(inputs, output);
                    

                }
                //conditions

                FuzzySet[] condtions = new FuzzySet[dgvCondition.Columns.Count];

                //set contents of conditions

                for (int c = 0; c < dgvCondition.Columns.Count; c++)
                {
                    {
                        condtions[c] = (FuzzySet)dgvCondition.Rows[0].Cells[c].Value;

                    }
                }


                double weightedsum = 0;
                double weighttotal = 0;
                foreach (SugenoIfThenRule rule in allRules)
                {
                    
                    double[] input = rule.FuzzyInCrispOutInferencing(condtions);
                    weightedsum += rule.GetOutputValueZ(input) * rule.FiringStrength;
                    weighttotal += rule.FiringStrength;

                    //if (resultinfFS == null) rule.FuzzyInCrispOutInferencing(condtions);
                    //else
                    //{
                    //    //把推理結果聯集
                    //    resultinfFS = resultinfFS | rule.FuzzyInFuzzyOutInferencing(condtions);
                    //}
                }
                if (mySystem.IsWeightedaverage) MessageBox.Show($"Crisp value is:{weightedsum / weighttotal}");

                else { MessageBox.Show($"Crisp value is:{weightedsum}"); }
            
                

            }
            else 
            {
                //create if-then rules
                IfThenFuzzyRule[] allRules = new IfThenFuzzyRule[dgvRules.Rows.Count];
                FuzzySet output ;
                for (int r = 0; r < dgvRules.Rows.Count; r++)
                {
                    FuzzySet[] inputs = new FuzzySet[dgvRules.Columns.Count - 1];

                    for (int c = 0; c < dgvRules.Columns.Count - 1; c++)
                    {
                        {
                            inputs[c] = (FuzzySet)dgvRules.Rows[r].Cells[c].Value;


                        }

                        if (!(dgvRules.Rows[r].Cells[dgvRules.Columns.Count - 1].Value is FuzzySet))
                        {
                            MessageBox.Show("Conclusion need to be a Fuzzyset"); return;
                        }
                        if (((FuzzySet)dgvRules.Rows[r].Cells[dgvRules.Columns.Count - 1].Value).Monotonic == false)
                        {
                            MessageBox.Show("Plz select monotonic FuzzySet for conclusion");
                            return;
                        }
                        output = (FuzzySet)dgvRules.Rows[r].Cells[dgvRules.Columns.Count - 1].Value;
                        allRules[r] = new IfThenFuzzyRule(inputs, output);
                    }

                }
                //conditions

                FuzzySet[] condtions = new FuzzySet[dgvCondition.Columns.Count];

                //set contents of conditions

                for (int c = 0; c < dgvCondition.Columns.Count; c++)
                {
                    {
                        condtions[c] = (FuzzySet)dgvCondition.Rows[0].Cells[c].Value;

                    }
                }


                double weightedsum = 0;
                double weighttotal = 0;
                foreach (IfThenFuzzyRule rule in allRules)
                {
                    weightedsum += rule.FuzzyInCrispOutTsuInferencing(condtions,mySystem.IsWeightedaverage) * rule.FiringStrength;
                    weighttotal += rule.FiringStrength;

                    //if (resultinfFS == null) rule.FuzzyInCrispOutInferencing(condtions);
                    //else
                    //{
                    //    //把推理結果聯集
                    //    resultinfFS = resultinfFS | rule.FuzzyInFuzzyOutInferencing(condtions);
                    //}
                }

                if (mySystem.IsWeightedaverage) MessageBox.Show($"Crisp value is:{weightedsum / weighttotal}");

                else { MessageBox.Show($"Crisp value is:{weightedsum}"); }

            }
        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            ////panelOutputEquation.SendToBack();
            //panelOutputEquation.Enabled = false;
            ////panel2.SendToBack();
            //panel2.Enabled = false;

            ////panelfuzzyset.BringToFront();
            //panelfuzzyset.Enabled = true;
            //panelfuzzyset.Visible = true;

            

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            //panelfuzzyset.SendToBack();
            //panelOutputEquation.SendToBack();
            //panelfuzzyset.Enabled = false;
            //panelOutputEquation.Enabled = false;
            





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


        IFuzzyInferencing mySystem;
        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radiobtnMamdani.Checked)
            {
                mySystem = new MamdaniFuzzySystem();
                listBoxEquation.Hide();
                listBoxEquation.Enabled = false;
                btnAddEquation.Hide();
                btnAddEquation.Enabled = false;
            }



            else if (radiobtnSugeno.Checked)
            {
                mySystem = new SugenoFuzzySystem();
                listBoxEquation.Show();
                listBoxEquation.Enabled = true;
                btnAddEquation.Show();
                btnAddEquation.Enabled = true;
            }
            else
            {
                mySystem = new TsukamotoFuzzySystem();
                listBoxEquation.Hide();
                listBoxEquation.Enabled = false;
                btnAddEquation.Hide();
                btnAddEquation.Enabled = false;
            }

                ppgSystem.SelectedObject = mySystem;
        }

        //private void btnCrispInCrispOut_Click(object sender, EventArgs e)
        //{
        //    if (chart2Doutput.ChartAreas.Count == 3) chart2Doutput.ChartAreas.Clear();

        //    if (dgvRules.Columns.Count == 2)
        //    {
        //        string s = $"Inferencing Output{InferenceTimes++}";
        //        ChartArea theArea = new ChartArea(s);
        //        chart2Doutput.ChartAreas.Add(theArea);




        //        Universe u1 = ((FuzzySet)dgvRules.Rows[0].Cells[0].Tag).TheUniverse;
        //        int res = 100;
        //        double deltaX = (u1.Maximum - u1.Minimum) / (res - 1);

        //        double[] conditions = new double[2];
        //        mySystem.Construct(dgvRules);


        //        Series aSeries = new Series();
        //        aSeries.ChartArea = theArea.Name;


        //        aSeries.ChartType = SeriesChartType.Line;


               

        //        for (double x = u1.Minimum; x < u1.Maximum; x += deltaX)
        //        {
        //            double y;
        //            conditions[0] = x;
        //            y = mySystem.CrispInCrispOutInferencing(conditions);


                    
        //            Console.WriteLine($"x = {x},y = {y}");
        //            aSeries.Points.AddXY(x, y);




        //        }

        //        //add the series to Chart.Series
        //        chart2Doutput.Series.Add(aSeries);



        //        theArea.AxisX.Title = dgvRules.Columns[0].HeaderText; 
        //        theArea.AxisY.Title = dgvRules.Columns[1].HeaderText;
        //        theArea.AxisX.Enabled = AxisEnabled.True;
        //        theArea.AxisY.Enabled = AxisEnabled.True;

        //        theArea.AxisX.Minimum = u1.Minimum;
        //        theArea.AxisX.Maximum = u1.Maximum;
        //        theArea.AxisY.Minimum = 0;
               





                
        //        //chart2Doutput.Legends[theArea.Name].DockedToChartArea = theArea.Name;
        //        //chart2Doutput.Legends[theArea.Name].IsDockedInsideChartArea = false;
        //        //chart2Doutput.Legends[theArea.Name].Docking = Docking.Top;

        //    }


        //    else
        //    {

        //        Universe u1 = ((FuzzySet)dgvRules.Rows[0].Cells[0].Tag).TheUniverse;
        //        Universe u2 = ((FuzzySet)dgvRules.Rows[0].Cells[1].Tag).TheUniverse;

        //        int res = 100;
        //        double deltaX = (u1.Maximum - u1.Minimum) / (res - 1);
        //        double deltaZ = (u2.Maximum - u2.Minimum) / (res - 1);

        //        double[] conditions = new double[2];
        //        mySystem.Construct(dgvRules);

        //        for (double x = u1.Minimum; x < u1.Maximum; x += deltaX)
        //        {
        //            for (double z = u2.Minimum; z < u2.Maximum; z += deltaZ)
        //            {
        //                conditions[0] = x; conditions[1] = z;
        //                double y = mySystem.CrispInCrispOutInferencing(conditions);
        //                Console.WriteLine($"x = {x},y = {y},z = {z}");
        //                surface1.Add(x, y, z);


        //            }

        //        }

        //    }


        //}

        private void cbxSugeno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripOutputEquation_Click(object sender, EventArgs e)
        {
            
            //panelOutputEquation.BringToFront();
            //panelOutputEquation.Enabled = true;
            //panelOutputEquation.Visible = true;

            
            ////panelfuzzyset.SendToBack();
            //panelfuzzyset.Enabled = false;
            //panelfuzzyset.Visible = false;

            //panel2.Enabled = false;
            //panel2.Visible = false;






        }

        private void listBoxEquation_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void radiobtnSugeno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiobtnTsukamoto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tchartOutput_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRules_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {

        }

        private void chart2Doutput_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult ans = dlgSave.ShowDialog();
            if (ans != DialogResult.OK) return;
            StreamWriter sw = new StreamWriter(dlgSave.FileName);
            if (radiobtnMamdani.Checked) sw.WriteLine("Model:Mamdani");
            else if (radiobtnSugeno.Checked) sw.WriteLine("Model:Sugeno");
            else { sw.WriteLine("Model:Tsukamoto"); }

            //traverse universe

            //從InputIniverse開始
            

            int numUniverse = theTree.Nodes[0].Nodes.Count;

            sw.WriteLine($"NumberOfInputUniverses:{numUniverse}");

            TreeNode univNode;
            Universe univ;

            int numFSs;
            TreeNode fsNode;
            FuzzySet fs;
            

            for (int i = 0; i < numUniverse; i++)
            {
               
                univNode = theTree.Nodes[0].Nodes[i];
                univ = (Universe)univNode.Tag;
                univ.Savefile(sw);

                //report including fuzzy set
                numFSs = univNode.Nodes.Count;
                sw.WriteLine($"NumberOfFSs:{numFSs}");
                for(int j = 0; j <numFSs; j++)
                {
                    fsNode = univNode.Nodes[j];
                    fs = (FuzzySet)fsNode.Tag;
                    fs.Savefile(sw);
                }

            }

            //OutputUniverse
            sw.WriteLine("NumberOfOutputUniverses:1");

            univNode = theTree.Nodes[1].Nodes[0];
            univ = (Universe)univNode.Tag;
            univ.Savefile(sw);

            //report including fuzzy set
            numFSs = univNode.Nodes.Count;
            sw.WriteLine($"NumberOfFSs:{numFSs}");
            for (int j = 0; j <numFSs; j++)
            {
                fsNode = univNode.Nodes[j];
                fs = (FuzzySet)fsNode.Tag;
                fs.Savefile(sw);
            }
            //rule datagridview
            sw.WriteLine($"NumberOfRows:{dgvRules.Rows.Count}");
            sw.WriteLine($"NumberOfColumns:{dgvRules.Columns.Count}");

            foreach (DataGridViewRow dgvr in dgvRules.Rows)
            {
                foreach(DataGridViewCell dgvc in dgvr.Cells)
                {
                    if (dgvc.Value is FuzzySet)
                        sw.WriteLine($"FuzzySetHash:{dgvc.Value.GetHashCode()}");
                    else
                        sw.WriteLine($"EquationID:{dgvc.Value}");
                }
                
            }

            //condition datagridview
            sw.WriteLine($"NumberOfRows:{dgvCondition.Rows.Count}");
            sw.WriteLine($"NumberOfColumns:{dgvCondition.Columns.Count}");

            foreach (DataGridViewRow dgvr in dgvCondition.Rows)
            {
                foreach (DataGridViewCell dgvc in dgvr.Cells)
                {
                    if (dgvc.Value is FuzzySet)
                    {
                        sw.WriteLine($"FuzzySetHash:{dgvc.Value.GetHashCode()}");
                        sw.WriteLine($"EquationID:{dgvc.Value}");
                    }

                    else
                    {
                        sw.WriteLine($"FuzzySetHash:None");
                        sw.WriteLine($"EquationID:None");
                    }




                }

            }



            sw.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;

            
            
            string str;
            string[] items;
            StreamReader sr = new StreamReader(dlgOpen.FileName);

            items = sr.ReadLine().Split(':');
            switch (items[1])
            {


                case "Mamdani":
                    radiobtnMamdani.Checked = true;
                    radiobtnSugeno.Checked = false;
                    radiobtnTsukamoto.Checked = false;
                    break;
                case "Sugeno":
                    radiobtnSugeno.Checked = true;
                    radiobtnMamdani.Checked = false;
                    radiobtnTsukamoto.Checked = false;
                    break;
                default:
                    radiobtnTsukamoto.Checked = true;
                    radiobtnSugeno.Checked = false;
                    radiobtnMamdani.Checked = false;
                    break;


            }

            //setup tree view

            theTree.Nodes[0].Nodes.Clear();
            theTree.Nodes[1].Nodes.Clear();
            mainchart.Series.Clear();
            mainchart.ChartAreas.Clear();
            mainchart.Annotations.Clear();
            mainchart.Legends.Clear();


            items = sr.ReadLine().Split(':');
            int numInputUniverse = Convert.ToInt32(items[1]);
            int numFs;
            TreeNode fsNode;
            FuzzySet fs = null;
            int hash;

            TreeNode univNode;
            Universe univ;

            Dictionary<int, FuzzySet> codeVsFuzzyset = new Dictionary<int, FuzzySet> { };

            for (int i = 0; i < numInputUniverse; i++)
            {
                univNode = new TreeNode();
                univ = new Universe(this.mainchart);
                univNode.Tag = univ;
                univ.Readfile(sr);
                univNode.Name = univ.Title;
                univNode.Text = univ.Title;

                theTree.Nodes[0].Nodes.Add(univNode);

                //deal with included fuzzy set

               
                items = sr.ReadLine().Split(':');
                numFs = Convert.ToInt32(items[1]);
                for (int j = 0; j < numFs; j++)
                {
                    fsNode = new TreeNode();
                    items = sr.ReadLine().Split(':');//get fuzzy set type

                    switch (items[1])
                    {
                        case "GaussianFuzzySet":
                            fs = new GaussianFuzzySet(univ);
                            break;
                        case "TriangleFuzzySet":
                            fs = new TriangleFuzzySet(univ);
                            break;

                        case "BellFuzzySet":
                            fs = new BellFuzzySet(univ);
                            break;
                        case "PiFuzzySet":
                            fs = new PiFuzzySet(univ);
                            break;
                        case "SFuzzySet":
                            fs = new SFuzzySet(univ);
                            break;
                        case "ZFuzzySet":
                            fs = new ZFuzzySet(univ);
                            break;
                        case "twosidedGaussianFuzzySet":
                            fs = new twosidedGaussianFuzzySet(univ);
                            break;
                        case "twosidedPiFuzzySet":
                            fs = new twosidedPiFuzzySet(univ);
                            break;
                        case "SigmoidFuzzySet":
                            fs = new SigmoidFuzzySet(univ);
                            break;
                        case "StepDownFuzzySet":
                            fs = new StepDownFuzzySet(univ);
                            break;
                        case "StepUpFuzzySet":
                            fs = new StepUpFuzzySet(univ);
                            break;
                    }
                    items = sr.ReadLine().Split(':');//get fuzzy set hash
                    hash = Convert.ToInt32(items[1]);
                    codeVsFuzzyset.Add(hash, fs);

                    //let fs read file
                   

                    fs.Readfile(sr);
                    fsNode.Tag = fs;
                    fsNode.Text = fs.ToString();
                    fsNode.Name = fs.ToString();

                    univNode.Nodes.Add(fsNode);

                    fs.ShowSeries = true;
                }



            }
            sr.ReadLine().Split(':');
            //output universe
            univNode = new TreeNode();
            univ = new Universe(this.mainchart);
            univNode.Tag = univ;
            univ.Readfile(sr);
            univNode.Name = univ.Title;
            univNode.Text = univ.Title;
            theTree.Nodes[1].Nodes.Add(univNode);

            items = sr.ReadLine().Split(':');
            numFs = Convert.ToInt32(items[1]);
            for (int j = 0; j < numFs; j++)
            {
                fsNode = new TreeNode();
                items = sr.ReadLine().Split(':');//get fuzzy set type

                switch (items[1])
                {
                    case "GaussianFuzzySet":
                        fs = new GaussianFuzzySet(univ);
                        break;
                    case "TriangleFuzzySet":
                        fs = new TriangleFuzzySet(univ);
                        break;

                    case "BellFuzzySet":
                        fs = new BellFuzzySet(univ);
                        break;
                    case "PiFuzzySet":
                        fs = new PiFuzzySet(univ);
                        break;
                    case "SFuzzySet":
                        fs = new SFuzzySet(univ);
                        break;
                    case "ZFuzzySet":
                        fs = new ZFuzzySet(univ);
                        break;
                    case "twosidedGaussianFuzzySet":
                        fs = new twosidedGaussianFuzzySet(univ);
                        break;
                    case "twosidedPiFuzzySet":
                        fs = new twosidedPiFuzzySet(univ);
                        break;
                    case "SigmoidFuzzySet":
                        fs = new SigmoidFuzzySet(univ);
                        break;
                    case "StepDownFuzzySet":
                        fs = new StepDownFuzzySet(univ);
                        break;
                    case "StepUpFuzzySet":
                        fs = new StepUpFuzzySet(univ);
                        break;
                }
                items = sr.ReadLine().Split(':');//get fuzzy set hash
                hash = Convert.ToInt32(items[1]);
                codeVsFuzzyset.Add(hash, fs);
                //let fs read file
                fs.Readfile(sr);
                fsNode.Tag = fs;
                fsNode.Text = fs.ToString();
                fsNode.Name = fs.ToString();
                fs.ShowSeries = true;

                univNode.Nodes.Add(fsNode);


            }


            //Read in Rules
            dgvRules.Rows.Clear();
            dgvRules.Columns.Clear();
            foreach(TreeNode tn in theTree.Nodes[0].Nodes)dgvRules.Columns.Add(tn.Text,tn.Text);
            dgvRules.Columns.Add(theTree.Nodes[1].Nodes[0].Text, theTree.Nodes[1].Nodes[0].Text);

            int rows, cols;

            items = sr.ReadLine().Split(':');
            rows = Convert.ToInt32(items[1]);
            items = sr.ReadLine().Split(':');
            cols = Convert.ToInt32(items[1]);
            int code;

            for(int r = 0; r < rows; r++)
            {
                dgvRules.Rows.Add();

                for (int c =0;c < cols; c++)
                {
                    items = sr.ReadLine().Split(':');
                    if(items[0] == "FuzzySetHash")
                    {
                        code = Convert.ToInt32(items[1]);
                        dgvRules.Rows[r].Cells[c].Value = codeVsFuzzyset[code];
                        dgvRules.Rows[r].Cells[c].Tag = codeVsFuzzyset[code];



                    }
                    else
                    {
                        dgvRules.Rows[r].Cells[c].Value = Convert.ToInt32(items[1]);
                        dgvRules.Rows[r].Cells[c].Tag = Convert.ToInt32(items[1]); 

                    }

                }
            }

            //condition datagridview
            dgvCondition.Rows.Clear();
            dgvCondition.Columns.Clear();
            foreach (TreeNode tn in theTree.Nodes[0].Nodes)
                dgvCondition.Columns.Add(tn.Text, tn.Text);
            //dgvCondition.Columns.Add(theTree.Nodes[1].Nodes[0].Text, theTree.Nodes[1].Nodes[0].Text);

            int crows, ccols;

            items = sr.ReadLine().Split(':');
            crows = Convert.ToInt32(items[1]);
            items = sr.ReadLine().Split(':');
            ccols = Convert.ToInt32(items[1]);
            int ccode;

            for (int r = 0; r < crows; r++)
            {
                dgvCondition.Rows.Add();

                for (int c = 0; c < ccols; c++)
                {

                    if (c == cols - 1) sr.ReadLine();


                    items = sr.ReadLine().Split(':');
                    if (items[0] == "FuzzySetHash")
                    {
                        if (items[1] != "None")
                        {
                            ccode = Convert.ToInt32(items[1]);
                            dgvCondition.Rows[r].Cells[c].Value = codeVsFuzzyset[ccode];
                        }
                        //dgvCondition.Rows[r].Cells[c].Tag = codeVsFuzzyset[ccode];





                    }
                    //else
                    //{
                    //    dgvCondition.Rows[r].Cells[c].Value = Convert.ToInt32(items[1]);
                    //    dgvCondition.Rows[r].Cells[c].Tag = Convert.ToInt32(items[1]);

                    //}

                }
            }


            


            theTree.ExpandAll();

            sr.Close();










        }


        private void btnAddEquation_Click(object sender, EventArgs e)
        {

            int aEquation;
            Universe selectedu;

            if (theTree.SelectedNode.Tag is Universe)
            {
                selectedu = (Universe)theTree.SelectedNode.Tag;
                string equationtitle = " ";

                switch (listBoxEquation.SelectedIndex)
                {
                    case 0:
                        aEquation = 0;
                        equationtitle = "Z = -X +Y +1";
                        break;
                    case 1:
                        aEquation = 1;
                        equationtitle = "Z = -Y + 3";
                        break;

                    case 2:
                        aEquation = 2;
                        equationtitle = "Z = -X +3";
                        break;
                    case 3:
                        aEquation = 3;
                        equationtitle = "Z = X +Y +2";
                        break;
                    default:
                        aEquation = 0;
                        break;
                }



                //Add a childnode to selected node
                TreeNode cNode = new TreeNode(equationtitle);
                cNode.Tag = aEquation;
                theTree.SelectedNode.Nodes.Add(cNode);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radiobtnMamdani_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCrispInCrispOut_Click_1(object sender, EventArgs e)
        {
            radioButton1_Click(null, null);

            {
                if (chart2Doutput.ChartAreas.Count !=0) chart2Doutput.ChartAreas.Clear();

                if (dgvRules.Columns.Count == 2)
                {
                    string s = $"{mySystem.ToString()}";
                    ChartArea theArea = new ChartArea(s);
                    chart2Doutput.ChartAreas.Add(theArea);




                    Universe u1 = ((FuzzySet)dgvRules.Rows[0].Cells[0].Tag).TheUniverse;
                    int res = 100;
                    double deltaX = (u1.Maximum - u1.Minimum) / (res - 1);

                    double[] conditions = new double[2];
                    mySystem.Construct(dgvRules);


                    Series aSeries = new Series();
                    aSeries.ChartArea = theArea.Name;


                    aSeries.ChartType = SeriesChartType.Line;




                    for (double x = u1.Minimum; x < u1.Maximum; x += deltaX)
                    {
                        double y=double.NaN;
                        conditions[0] = x;
                        y = mySystem.CrispInCrispOutInferencing(conditions);



                        Console.WriteLine($"x = {x},y = {y}");
                        aSeries.Points.AddXY(x, y);




                    }

                    //add the series to Chart.Series
                    chart2Doutput.Series.Add(aSeries);



                    theArea.AxisX.Title = dgvRules.Columns[0].HeaderText;
                    theArea.AxisX.Interval = 1.0;
                    theArea.AxisY.Title = dgvRules.Columns[1].HeaderText;
                    theArea.AxisX.Enabled = AxisEnabled.True;
                    theArea.AxisY.Enabled = AxisEnabled.True;

                    theArea.AxisX.Minimum = u1.Minimum;
                    theArea.AxisX.Maximum = u1.Maximum;
                    theArea.AxisY.Minimum = 0;







                    //chart2Doutput.Legends[theArea.Name].DockedToChartArea = theArea.Name;
                    //chart2Doutput.Legends[theArea.Name].IsDockedInsideChartArea = false;
                    //chart2Doutput.Legends[theArea.Name].Docking = Docking.Top;
                    chart2Doutput.BringToFront();
                    
                }


                else
                {   surface1.Title = $"{mySystem}";


                    Universe u1 = ((FuzzySet)dgvRules.Rows[0].Cells[0].Tag).TheUniverse;
                    Universe u2 = ((FuzzySet)dgvRules.Rows[0].Cells[1].Tag).TheUniverse;

                    int res = 100;
                    double deltaX = (u1.Maximum - u1.Minimum) / (res - 1);
                    double deltaZ = (u2.Maximum - u2.Minimum) / (res - 1);

                    double[] conditions = new double[2];
                    mySystem.Construct(dgvRules);

                    for (double x = u1.Minimum; x < u1.Maximum; x += deltaX)
                    {
                        for (double z = u2.Minimum; z < u2.Maximum; z += deltaZ)
                        {
                            conditions[0] = x; conditions[1] = z;
                            double y = mySystem.CrispInCrispOutInferencing(conditions);
                            Console.WriteLine($"x = {x},y = {y},z = {z}");
                            surface1.Add(x,y,z);


                        }

                    }

                    chart2Doutput.SendToBack();



                }


            }
        }

        private void btndeleteRules_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dgvr in dgvRules.SelectedRows){
                dgvRules.Rows.Remove(dgvr);
            }
        }

        private void checkBoxCut_CheckedChanged(object sender, EventArgs e)
        {
            
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



    

