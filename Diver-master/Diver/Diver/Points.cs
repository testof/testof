using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diver
{
    public partial class Points : Form
    {
        private Tournament tournatment = new Tournament();
        public Points()
        {
            
            InitializeComponent();

        }

        private void hoppareName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void Points_Load(object sender, EventArgs e)
        {
            labelfirstname.Text = Diver.SetvalueForname;
            labellastname.Text = Diver.setvalueForlastname;
            labeljump.Text = Diver.setvalueForjump;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int x = 0;
            int y = 0;
            int z = 0;
            int w = 0;
            int q = 0;
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text)
                && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text)
                && !string.IsNullOrEmpty(textBox5.Text))
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                z = Convert.ToInt32(textBox3.Text);
                w = Convert.ToInt32(textBox4.Text);
                q = Convert.ToInt32(textBox5.Text);
                tournatment.number.Add(x);
                tournatment.number.Add(y);
                tournatment.number.Add(z);
                tournatment.number.Add(w);
                tournatment.number.Add(q);
            }
     


        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            //int[] n = { 2, 3, 4, 5, 6 };
            int max = 0;
            int min = int.MaxValue;
            double sum = 0;
            double k = tournatment.number.Sum();

            foreach (int i in tournatment.number)

            {
                if (i > max)
                    max = i;
                if (i < min)
                    min = i;
                sum = k - max - min;
            }
            double j = sum / (tournatment.number.Count() - 2);


            

            txtcalculate.Text = j.ToString("0.0");
            
        }
    }
}
