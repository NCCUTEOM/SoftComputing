using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace R09546014HHungYLAss03
{
    public partial class Mainform : Form
    {
        

        public Mainform()
        {
            InitializeComponent();
            comboBoxSelectFS.SelectedIndex = 0;//預設選GaussianFS
        }

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
        }

        private void btnCreateFuzzySet_Click(object sender, EventArgs e)
       {
            Fuzzyset aFs;
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
            else if (theTree.SelectedNode.Tag is Fuzzyset)
            {
                //改變FuzzySet的Title時，mainchart連動改變
                mainchart.Series[theTree.SelectedNode.Text].Name = ((Fuzzyset)theTree.SelectedNode.Tag).Title;

                //變更FuzzySet tree node的名稱
                theTree.SelectedNode.Text = ((Fuzzyset)theTree.SelectedNode.Tag).Title;
                



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
            
           
            if (theTree.SelectedNode.Tag is Fuzzyset) 
            {
                theTree.Nodes.Remove(theTree.SelectedNode);
                mainchart.Series.RemoveAt(theTree.SelectedNode.Index);
            }




               
            }

       
    }
    }

