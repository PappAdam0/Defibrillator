using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Defi
{
    public partial class foForm : Form
    {
        static List<Keszulek> lista = new List<Keszulek>();
        public foForm()
        {
            
            InitializeComponent();
            lBKiiras.Items.Clear();

        }

        private void btAdatok_Click(object sender, EventArgs e)
        {
            StreamReader be = new StreamReader("data.csv");
            be.ReadLine();

            while (!be.EndOfStream)
            {
                string[] a = be.ReadLine().Split(';');
                lista.Add(new Keszulek(Convert.ToInt32(a[0]), a[1], Convert.ToDouble(a[2]), Convert.ToDouble(a[3]), a[4], a[5]));
            }
            be.Close();

            //double x = Convert.ToDouble(tBX);
            //double y = Convert.ToDouble(tBY);


            //foreach (var i in lista)
            //{
            //    lBKiiras.Items.Add($"{DistCalc(x,y)}");
            //}

        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUjAdat_Click(object sender, EventArgs e)
        {
            lBKiiras.Items.Clear();
            tBX.Text = "";
            tBY.Text = "";

            MessageBox.Show("Adatok törölve");
        }

        private void lBKiiras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
