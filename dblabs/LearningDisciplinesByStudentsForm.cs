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
    public partial class LearningDisciplinesByStudentsForm : Form
    {
        public LearningDisciplinesByStudentsForm()
        {
            InitializeComponent();
        }

        private void изучение_предметов_студентамиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.изучение_предметов_студентамиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.facultyDataSet);

        }

        private void LearningDisciplinesByStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'facultyDataSet.Студенты' table. You can move, or remove it, as needed.
            this.студентыTableAdapter.Fill(this.facultyDataSet.Студенты);
            this.изучение_предметов_студентамиTableAdapter.Fill(this.facultyDataSet.Изучение_предметов_студентами);
        }

        string GetSelectedFieldName()
        {
            return
           изучение_предметов_студентамиDataGridView.Columns[
               изучение_предметов_студентамиDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void изучение_предметов_студентамиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Discipline form = new Discipline();
            //form.
            form.Show();

            //decimal price = 0;
            //int idDishCurrent = -1;

            //int.TryParse((((DataRowView)проданоBindingSource.Current)["код_блюда"]).ToString(), out idDishCurrent);
            //int idDish = FormDishesList.fd.ShowSelectForm(idDishCurrent, out price);
            //MessageBox.Show("Код блюда=" + idDish.ToString());
            //((DataRowView)проданоBindingSource.Current)["код_блюда"] = idDish;
            //((DataRowView)проданоBindingSource.Current)["цена"] = price;
            //проданоBindingSource.EndEdit();
            //проданоTableAdapter.Update(this.cafeDataSet);
            //блюдаTableAdapter.Fill(this.cafeDataSet.Блюда);
        }
    }
}
