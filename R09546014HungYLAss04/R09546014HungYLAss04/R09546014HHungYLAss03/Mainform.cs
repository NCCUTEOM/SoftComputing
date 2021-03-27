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
using R09546014HungYLAss04.R09546014HungYLAss04;

namespace R09546014HungYLAss04
{
    public partial class Mainform : Form
    {
        //public event EventHandler FsSelected;



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

            theTree.Nodes.Add(aNode);
            theTree.SelectedNode = aNode;
            theGrid.SelectedObject = uobj;

        }



        private void theTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
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
                theTree.Nodes.Remove(theTree.SelectedNode);
                mainchart.Series.RemoveAt(theTree.SelectedNode.Index);
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
                    op = new ConcentrateOperator();
                    newFs = new UnaryOperatedFuzzySet(fs, op);
                    break;

                case 3://dilate
                    op = new DilateOperator();
                    newFs = new UnaryOperatedFuzzySet(fs, op);
                    break;

                case 4://intensificate
                    op = new IntensificateOperator();
                    newFs = new UnaryOperatedFuzzySet(fs, op);
                    break;
                case 5://diminish
                    op = new DiminishOperator();
                    newFs = new UnaryOperatedFuzzySet(fs, op);
                    break;

                case 6://Sugeno's negate
                    op = new SugenoNegateOperator();
                    newFs = new UnaryOperatedFuzzySet(fs, op);
                    break;
                    








            }
            btnCreatedUnaryOperatedFS.Enabled = false;


            //newFs = new UnaryOperatedFuzzySet(fs, op);

            //Add a subnode to selected node

            TreeNode cNode = new TreeNode(newFs.Title);
            cNode.Tag = newFs;

            //把unaryoperated fuzzyset 加在被作用的fuzzyset底下
            if (theTree.SelectedNode.PrevNode != null) theTree.SelectedNode.Parent.Nodes.Add(cNode);
            else { theTree.SelectedNode.Nodes.Add(cNode); }



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

            if (!lfs.TheUniverse.Equals(rfs.TheUniverse)){
                labRightFS.Tag = null;
                labRightFS.Text = "SelectRFS";
                MessageBox.Show("Two FuzzySet need to share the same universe");
                return;
                               
            }

            BinaryFSOperator op = null;
            FuzzySet newFs = null;

            switch (cbxBinaryOperator.SelectedIndex)
            {
                case 0: //intersection
                    newFs = lfs * rfs;

                    //op = new NegateOperator();

                    break;
                case 1:// union
                    op = new UnionOperator();
                    newFs = new BinaryOperatedFuzzySet(lfs, rfs, op);

                    break;

                case 2://substraction
                    op = new SubstractionOperator();
                    newFs = new BinaryOperatedFuzzySet(lfs, rfs, op);
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
    }
}


    

