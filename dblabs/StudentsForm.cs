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
    public partial class StudentsForm : Form
    {
        public StudentsForm()
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
            this.студентыTableAdapter.Fill(this.facultyDataSet.Студенты);

        }

        private void openPhotoButton_Click(object sender, EventArgs e)
        {
            string fileImage = "";
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                фотографияPictureBox.Image = new
                    Bitmap(openFileDialogPhoto.FileName);
            }
            else fileImage = "";
        }
    }
}
