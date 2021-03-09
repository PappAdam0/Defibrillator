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
            StreamReader sr = new StreamReader("data.csv");
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] a = sr.ReadLine().Split(';');
                lista.Add(new Keszulek(Convert.ToInt32(a[0]), a[1], Convert.ToDouble(a[2]), Convert.ToDouble(a[3]), a[4], a[5]));
            }
            sr.Close();


            foreach (var i in lista)
            {
                lBKiiras.Items.Add(i.Name);
            }
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUjAdat_Click(object sender, EventArgs e)
        {
            lBKiiras.Items.Clear();
            mTBX.Text = "";
            mTBY.Text = "";

            MessageBox.Show("Az adatok törlésre kerültek");
        }
    }
}
