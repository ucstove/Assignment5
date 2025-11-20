using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class addPersonForm : Form
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public addPersonForm()
        {
            InitializeComponent();
        }

        private void addPersonForm_Load(object sender, EventArgs e)
        {
            this.btnOk.DialogResult = DialogResult.OK;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;
            Phone = txtPhone.Text;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
