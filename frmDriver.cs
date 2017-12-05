using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransManager
{
    public partial class frmDriver : Form
    {
        Drivers j;

        IEnumerable<Driver> querybySurname;
        IEnumerable<Driver> querybyAddress;
        IEnumerable<Driver> querybyTown;
        IEnumerable<Driver> queryCurrent;

        
        public frmDriver()
        {
            InitializeComponent();
            
        }

        

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportManagerDataSet.Clients' table. You can move, or remove it, as needed.

            j = new Drivers(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            querybySurname = j.Where(s => s.isActive == this.radActiveTrue.Checked || s.isActive == (this.radActiveTrue.Checked || this.radActiveAll.Checked)).Where(s => s.Surname.ToString().ToUpper().StartsWith(this.txtSearchSurname.Text.ToUpper())).OrderBy(id => id.Surname);
            querybyAddress = j.Where(s => s.isActive == this.radActiveTrue.Checked || s.isActive == (this.radActiveTrue.Checked || this.radActiveAll.Checked)).Where(s => s.AddressLine1.ToUpper().Contains(this.txtSearchAddressLine1.Text.ToUpper())).OrderBy(id => id.Surname);
            querybyTown = j.Where(s => s.isActive == this.radActiveTrue.Checked || s.isActive == (this.radActiveTrue.Checked || this.radActiveAll.Checked)).Where(s => s.Town.ToUpper().Contains(this.txtSearchTown.Text.ToUpper())).OrderBy(id => id.Surname);

            queryCurrent = querybySurname;
                                  
        }

        
        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            
        }

        private void txtSearchSurname_TextChanged(object sender, EventArgs e)
        {
            queryCurrent = querybySurname;
            LoadListView(queryCurrent);
        }

        private void LoadListView(IEnumerable<Driver> query){

            listView1.Items.Clear();
            //Driver x = query.FirstOrDefault();

            foreach (Driver driver in query)
            {
                        ListViewItem lvi = listView1.Items.Add(driver.DriverID.ToString());
                        lvi.SubItems.Add(driver.Title);
                        lvi.SubItems.Add(driver.FirstName);
                        lvi.SubItems.Add(driver.Surname);
                        lvi.SubItems.Add(driver.AddressLine1);
                        lvi.SubItems.Add(driver.AddressLine2);
                        lvi.SubItems.Add(driver.Town);
                        lvi.SubItems.Add(driver.Postcode);
                        lvi.BackColor = System.Drawing.Color.LightSalmon;
                        if (!driver.isActive)
                        {
                            lvi.BackColor = System.Drawing.Color.Bisque;
                        }
            }
        }

        private void radActiveTrue_CheckedChanged(object sender, EventArgs e)
        {
            LoadListView(queryCurrent);
        }

        private void radActiveFalse_CheckedChanged(object sender, EventArgs e)
        {

            LoadListView(queryCurrent);
        }

        private void radActiveAll_CheckedChanged(object sender, EventArgs e)
        {
            
            LoadListView(queryCurrent);
        }

        private void txtSearchAddressLine1_TextChanged(object sender, EventArgs e)
        {
            queryCurrent = querybyAddress;            
            LoadListView(queryCurrent);
        }

        private void txtSearchTown_TextChanged(object sender, EventArgs e)
        {
            queryCurrent = querybyTown;
            LoadListView(queryCurrent);

        }



        
    }
}
