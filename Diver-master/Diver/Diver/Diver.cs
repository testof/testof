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
    public partial class Diver : Form
    {
        private Tournament tournatment = new Tournament();
        //lägg till till en annan list
        private List<hoppare> hopparedata = new List<hoppare>();//det här är empty
        private Points otherform = new Points();
        //write to the list in the design
        BindingSource hoppareBinding = new BindingSource();
        BindingSource hoppbinding = new BindingSource();
        public static string SetvalueForname = "Display";
        public static string setvalueForlastname = "Display";
        public static string setvalueForjump = "Display";
        //BindingSource namebinding = new BindingSource(); 
        public Diver()
        {
            //dont write anything befor initializecomponet()
            InitializeComponent();
            setupdata();//call
            hoppareBinding.DataSource = tournatment.hopparelist.Where(x => x.dive == false).ToList();
            DiverList.DataSource = hoppareBinding;
            

            DiverList.DisplayMember = "Display";
            DiverList.DisplayMember = "Display";
            //lägg till från vänster lista to right lista
            hoppbinding.DataSource = hopparedata;
            pointlist.DataSource = hoppbinding;

            pointlist.DisplayMember = "Diplay";
            pointlist.DisplayMember = "Display";

           

        }

        private void Diver_Load(object sender, EventArgs e)
        {
             //s = new Points();
            //s.Show();

        }
        private void setupdata()
        {
            //lägg till judges

            tournatment.judges.Add(new judge { FirstName = "jek", LastName = "hurry" });//add to list
            tournatment.judges.Add(new judge { FirstName = "son", LastName = "hurry" });
            tournatment.judges.Add(new judge { FirstName = "sarmad", LastName = "hurry" });
            tournatment.judges.Add(new judge { FirstName = "ako", LastName = "hurry" });
            tournatment.judges.Add(new judge { FirstName = "ronny", LastName = "hurry" });

            //add hoppare
            tournatment.hopparelist.Add(new hoppare { FirstName = "jon", LastName = "obama", dateofbirth = "1990.12.12" });
            tournatment.hopparelist.Add(new hoppare { FirstName = "jin", LastName = "obama", dateofbirth = "1990.12.12"});
            tournatment.hopparelist.Add(new hoppare { FirstName = "jun", LastName = "obama", dateofbirth = "1990.12.12" });

            tournatment.Name = "OS";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            
            //figure out what is selected from the diver list
            //copy that diver to point list
            //do we remove the diver from the diver list? - no
            hoppare selectedItem = (hoppare)DiverList.SelectedItem;

            //MessageBox.Show(selectedItem.FirstName);
            hopparedata.Add(selectedItem);
            hoppbinding.ResetBindings(true);//list is not changed
            

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            
            
            foreach(hoppare item in hopparedata)
            {
                item.dive = true;
            }
            hoppare selectedItem = (hoppare)pointlist.SelectedItem;
            hopparedata.Remove(selectedItem);
            //hoppareBinding.DataSource = tournatment.hopparelist.Where(x => x.dive == false).ToList();
            hoppbinding.ResetBindings(false);
           // hoppareBinding.ResetBindings(false);
        }

        private void btnstart_Click_1(object sender, EventArgs e)
        {
            SetvalueForname = txtfirstname.Text;
            setvalueForlastname = txtlastname.Text;
            setvalueForjump = txtjump.Text;
            Points f = new Points();
           
            Points open = new Points();
            open.Show();
        }

        private void DiverList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void pointlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
