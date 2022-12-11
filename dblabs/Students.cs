using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dblabs
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.facultyDataSet);

        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'facultyDataSet.Студенты' table. You can move, or remove it, as needed.
            this.студентыTableAdapter.Fill(this.facultyDataSet.Студенты);

        }
    }
}
