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
    public partial class DisciplinesForm : Form
    {
        public DisciplinesForm()
        {
            InitializeComponent();
        }

        private void предметыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.предметыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.facultyDataSet);

        }

        private void Disciplines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'facultyDataSet.Предметы' table. You can move, or remove it, as needed.
            this.предметыTableAdapter.Fill(this.facultyDataSet.Предметы);

        }
    }
}
