using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09546014HungYLAss06
{
    public delegate int FuctionTakesNoArgumentReturnInt();
    static class Program
    {
        //static int f()
        //{
        //    MessageBox.Show("F()");
        //    return 1;

        //}

        //static int g()
        //{
        //    MessageBox.Show("G()");
        //    return 1;
        //}
       
        //static int j(int k)
        //{
        //    MessageBox.Show("J()");
        //    return 1;
        //}

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Delegate 委派 函式指標(集合)
            //FuctionTakesNoArgumentReturnInt ptr;
            //ptr = f;
            //ptr();
            //ptr = g;
            //ptr();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());


            Application.Run(new Mainform());

        }
   }
    }
