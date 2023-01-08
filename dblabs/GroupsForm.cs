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
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            InitializeComponent();
        }

        string GetSelectedFieldName()
        {
            return
           студентыDataGridView.Columns[студентыDataGridView.CurrentCell.ColumnIndex
           ].DataPropertyName;
        }

        private void группыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.группыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.facultyDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void Groups_Load(object sender, EventArgs e)
        {
            this.студентыTableAdapter.Fill(this.facultyDataSet.Студенты);
            this.студентыTableAdapter.Fill(this.facultyDataSet.Студенты);
            this.группыTableAdapter.Fill(this.facultyDataSet.Группы);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Validate();
            студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.facultyDataSet);
        }

        private void findToolStripButton_Click(object sender, EventArgs e)
        {

            if (findToolStripTextBox.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
               студентыBindingSource.Find(GetSelectedFieldName(),
               findToolStripTextBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                студентыBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                студентыBindingSource.Position = 0;
            }
        }

        private void findCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (findCheckBox.Checked)
            {
                if (findToolStripTextBox.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        студентыBindingSource.Filter =
                       GetSelectedFieldName() + "='" + findToolStripTextBox.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                студентыBindingSource.Filter = "";
            if (студентыBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                студентыBindingSource.Filter = "";
                findCheckBox.Checked = false;
            }
        }
    }
}
