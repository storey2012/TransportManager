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
    public partial class frmClient : Form
    {
        Clients j;

        IEnumerable<Client> querybySurname;
        IEnumerable<Client> querybyAddress;
        IEnumerable<Client> querybyTown;
        IEnumerable<Client> queryCurrent;

        
        public frmClient()
        {
            InitializeComponent();
            
        }

        

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportManagerDataSet.Clients' table. You can move, or remove it, as needed.
            
            j = new Clients();

            querybySurname = j.Where(s => s.isActive == this.radActiveTrue.Checked || s.isActive == (this.radActiveTrue.Checked || this.radActiveAll.Checked)).Where(s => s.Surname.ToString().ToUpper().StartsWith(this.txtSearchSurname.Text.ToUpper())).OrderBy(id => id.Surname);
            querybyAddress = j.Where(s => s.isActive == this.radActiveTrue.Checked || s.isActive == (this.radActiveTrue.Checked || this.radActiveAll.Checked)).Where(s => s.AddressLine1.ToUpper().Contains(this.txtSearchAddressLine1.Text.ToUpper())).OrderBy(id => id.Surname);
            querybyTown = j.Where(s => s.isActive == this.radActiveTrue.Checked || s.isActive == (this.radActiveTrue.Checked || this.radActiveAll.Checked)).Where(s => s.Town.ToUpper().Contains(this.txtSearchTown.Text.ToUpper())).OrderBy(id => id.Surname);

            queryCurrent = querybySurname;
            
            //LoadListView(queryCurrent);
            
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

        private void LoadListView(IEnumerable<Client> query){

            listView1.Items.Clear();
            Client x = query.FirstOrDefault();

            foreach (Client client in query)
            {
                        ListViewItem lvi = listView1.Items.Add(client.ClientID.ToString());
                        lvi.SubItems.Add(client.Title);
                        lvi.SubItems.Add(client.FirstName);
                        lvi.SubItems.Add(client.Surname);
                        lvi.SubItems.Add(client.AddressLine1);
                        lvi.SubItems.Add(client.AddressLine2);
                        lvi.SubItems.Add(client.Town);
                        lvi.SubItems.Add(client.Postcode);
                        lvi.BackColor = System.Drawing.Color.LightSalmon;
                        if (!client.isActive)
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
