using BLL;
using DAL;
using Entities;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuideApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        Business bL = new Business();
        private void form1_load(object sender, EventArgs e)
        {
            listing();
        }

        private void listing()
        {
            List<Employees> name = bL.List();
            if (name != null && name.Count > 0)
            {
                dataGridView1.DataSource = name;
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e) {}

        private void button1_Click(object sender, EventArgs e)
        {
            List<Employees> name = bL.List();
            string filter = txtAra.Text.ToLower();
            dataGridView1.DataSource = name.FindAll(item =>item.EmployeeName.ToLower().Contains(txtAra.Text));
        }

        private void label2_Click(object sender, EventArgs e) {}
    }
 }
