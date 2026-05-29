using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Contacts_winForm
{
    public partial class Form_list_contact : Form
    {
        public Form_list_contact()
        {
            InitializeComponent();
        }

        private void _refresh_list()
        {
            dgv_1.DataSource = clscontact_business.list_all();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _refresh_list();
        }

        private void dgv_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_addedit frm = new Form_addedit((int)dgv_1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _refresh_list();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_addedit frm =new Form_addedit((int)dgv_1.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("do you want to delete: " + (dgv_1.CurrentRow.Cells[1].Value+" "+ dgv_1.CurrentRow.Cells[2].Value), " confirm delete ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clscontact_business.delete((int)dgv_1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("contact deleted");
                    _refresh_list();
                }
                else
                    MessageBox.Show("contact not deleted");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_addedit frm = new Form_addedit(-1);
            frm.Show();
            _refresh_list();

        }
    }
}
