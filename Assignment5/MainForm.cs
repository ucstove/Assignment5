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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbPersonDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbPersonDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.dbPersonDataSet.Person);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbPersonDataSet);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            personBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.dbPersonDataSet);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addPersonForm add = new addPersonForm();
            if (add.ShowDialog() == DialogResult.OK)
            {
                var newRow = this.dbPersonDataSet.Person.NewPersonRow();
                newRow.Name = add.Name;
                newRow.Phone = add.Phone;
                this.dbPersonDataSet.Person.AddPersonRow(newRow);
                this.Validate();
                personBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbPersonDataSet);
            }
        }
    }
}
