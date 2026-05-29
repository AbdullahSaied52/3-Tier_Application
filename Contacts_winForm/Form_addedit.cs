using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts_winForm
{
    public partial class Form_addedit : Form
    {
        public enum enmode { addnew=0,edit=1};
        private enmode _mode;

        clscontact_business _contact;
        int _ID;
        public Form_addedit(int id)
        {
            InitializeComponent();
            _ID = id;
            if (id == -1)
                _mode = enmode.addnew;
            else
                _mode = enmode.edit;

        }

        private void _fill_country_combobox()
        {
            DataTable dt = clscountry_business.list();
            foreach(DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row["CountryName"]);
            }
        }

        private void _load()
        {
            _fill_country_combobox();
            if(_mode==enmode.addnew)
            {
                label1.Text = "Add new contact";
                _contact = new clscontact_business();
                return;
            }
            _contact = clscontact_business.find(_ID);
            label1.Text = "Edif contact "+_ID;
            txtid.Text = _contact.ID.ToString();
            txtfirstname.Text = _contact.FirstName;
            txtlastname.Text = _contact.LastName;
            txtemail.Text = _contact.Email;
            txtphone.Text = _contact.Phone;
            txtaddress.Text = _contact.Address;

            comboBox1.SelectedIndex=comboBox1.FindString(clscountry_business.find_by_id(_contact.CountryID).Name);

        }

        private void Form_addedit_Load(object sender, EventArgs e)
        {
            _load();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _contact.FirstName = txtfirstname.Text;
            _contact.LastName = txtlastname.Text;
            _contact.Email = txtemail.Text;
            _contact.Phone = txtphone.Text;
            _contact.Address = txtaddress.Text;
            _contact.CountryID = clscountry_business.find_by_name(comboBox1.Text).ID;
            if (_contact.Save())
            {
                MessageBox.Show("saved");
                _mode = enmode.edit;
                label1.Text = "Edit contact " + _contact.ID;
                txtid.Text = _contact.ID.ToString();
            }
            else
                MessageBox.Show(" not saved");


        }
    }
}
