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
    public partial class FacultyForm : Form
    {
        public FacultyForm()
        {
            InitializeComponent();
        }

        private void факультетBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.факультетBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.facultyDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {
            this.группыTableAdapter.Fill(this.facultyDataSet.Группы);
            this.факультетTableAdapter.Fill(this.facultyDataSet.Факультет);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Validate();
            группыBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.facultyDataSet);
        }
    }
}
