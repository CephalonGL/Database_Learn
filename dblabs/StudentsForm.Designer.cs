namespace dblabs
{
    partial class StudentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label номер_зачётной_книжкиLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label номер_группыLabel;
            System.Windows.Forms.Label серия_и_номер_паспортаLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label адрес_пропискиLabel;
            System.Windows.Forms.Label фактический_адрес_проживанияLabel;
            System.Windows.Forms.Label фотографияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            System.Windows.Forms.Label год_поступленияLabel;
            this.студентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.студентыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_зачётной_книжкиTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.номер_группыTextBox = new System.Windows.Forms.TextBox();
            this.серия_и_номер_паспортаTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.адрес_пропискиTextBox = new System.Windows.Forms.TextBox();
            this.фактический_адрес_проживанияTextBox = new System.Windows.Forms.TextBox();
            this.фотографияPictureBox = new System.Windows.Forms.PictureBox();
            this.openPhotoButton = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyDataSet = new dblabs.facultyDataSet();
            this.студентыTableAdapter = new dblabs.facultyDataSetTableAdapters.СтудентыTableAdapter();
            this.tableAdapterManager = new dblabs.facultyDataSetTableAdapters.TableAdapterManager();
            this.год_поступленияComboBox = new System.Windows.Forms.ComboBox();
            номер_зачётной_книжкиLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            номер_группыLabel = new System.Windows.Forms.Label();
            серия_и_номер_паспортаLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            адрес_пропискиLabel = new System.Windows.Forms.Label();
            фактический_адрес_проживанияLabel = new System.Windows.Forms.Label();
            фотографияLabel = new System.Windows.Forms.Label();
            год_поступленияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).BeginInit();
            this.студентыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотографияPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_зачётной_книжкиLabel
            // 
            номер_зачётной_книжкиLabel.AutoSize = true;
            номер_зачётной_книжкиLabel.Location = new System.Drawing.Point(12, 38);
            номер_зачётной_книжкиLabel.Name = "номер_зачётной_книжкиLabel";
            номер_зачётной_книжкиLabel.Size = new System.Drawing.Size(196, 20);
            номер_зачётной_книжкиLabel.TabIndex = 1;
            номер_зачётной_книжкиLabel.Text = "Номер зачётной книжки:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(12, 70);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(51, 20);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // номер_группыLabel
            // 
            номер_группыLabel.AutoSize = true;
            номер_группыLabel.Location = new System.Drawing.Point(12, 102);
            номер_группыLabel.Name = "номер_группыLabel";
            номер_группыLabel.Size = new System.Drawing.Size(119, 20);
            номер_группыLabel.TabIndex = 5;
            номер_группыLabel.Text = "Номер группы:";
            // 
            // серия_и_номер_паспортаLabel
            // 
            серия_и_номер_паспортаLabel.AutoSize = true;
            серия_и_номер_паспортаLabel.Location = new System.Drawing.Point(12, 134);
            серия_и_номер_паспортаLabel.Name = "серия_и_номер_паспортаLabel";
            серия_и_номер_паспортаLabel.Size = new System.Drawing.Size(199, 20);
            серия_и_номер_паспортаLabel.TabIndex = 7;
            серия_и_номер_паспортаLabel.Text = "Серия и номер паспорта:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(12, 167);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(132, 20);
            дата_рожденияLabel.TabIndex = 9;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // адрес_пропискиLabel
            // 
            адрес_пропискиLabel.AutoSize = true;
            адрес_пропискиLabel.Location = new System.Drawing.Point(12, 198);
            адрес_пропискиLabel.Name = "адрес_пропискиLabel";
            адрес_пропискиLabel.Size = new System.Drawing.Size(135, 20);
            адрес_пропискиLabel.TabIndex = 11;
            адрес_пропискиLabel.Text = "Адрес прописки:";
            // 
            // фактический_адрес_проживанияLabel
            // 
            фактический_адрес_проживанияLabel.AutoSize = true;
            фактический_адрес_проживанияLabel.Location = new System.Drawing.Point(12, 230);
            фактический_адрес_проживанияLabel.Name = "фактический_адрес_проживанияLabel";
            фактический_адрес_проживанияLabel.Size = new System.Drawing.Size(261, 20);
            фактический_адрес_проживанияLabel.TabIndex = 13;
            фактический_адрес_проживанияLabel.Text = "Фактический адрес проживания:";
            // 
            // фотографияLabel
            // 
            фотографияLabel.AutoSize = true;
            фотографияLabel.Location = new System.Drawing.Point(677, 33);
            фотографияLabel.Name = "фотографияLabel";
            фотографияLabel.Size = new System.Drawing.Size(113, 20);
            фотографияLabel.TabIndex = 17;
            фотографияLabel.Text = "Фотография:";
            // 
            // студентыBindingNavigator
            // 
            this.студентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.студентыBindingNavigator.BindingSource = this.студентыBindingSource;
            this.студентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.студентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.студентыBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.студентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.студентыBindingNavigatorSaveItem});
            this.студентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.студентыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.студентыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.студентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.студентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.студентыBindingNavigator.Name = "студентыBindingNavigator";
            this.студентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.студентыBindingNavigator.Size = new System.Drawing.Size(939, 33);
            this.студентыBindingNavigator.TabIndex = 0;
            this.студентыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // студентыBindingNavigatorSaveItem
            // 
            this.студентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.студентыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("студентыBindingNavigatorSaveItem.Image")));
            this.студентыBindingNavigatorSaveItem.Name = "студентыBindingNavigatorSaveItem";
            this.студентыBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.студентыBindingNavigatorSaveItem.Text = "Save Data";
            this.студентыBindingNavigatorSaveItem.Click += new System.EventHandler(this.студентыBindingNavigatorSaveItem_Click);
            // 
            // номер_зачётной_книжкиTextBox
            // 
            this.номер_зачётной_книжкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Номер зачётной книжки", true));
            this.номер_зачётной_книжкиTextBox.Location = new System.Drawing.Point(279, 35);
            this.номер_зачётной_книжкиTextBox.Name = "номер_зачётной_книжкиTextBox";
            this.номер_зачётной_книжкиTextBox.Size = new System.Drawing.Size(357, 26);
            this.номер_зачётной_книжкиTextBox.TabIndex = 2;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(279, 67);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(357, 26);
            this.фИОTextBox.TabIndex = 4;
            // 
            // номер_группыTextBox
            // 
            this.номер_группыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Номер группы", true));
            this.номер_группыTextBox.Location = new System.Drawing.Point(279, 99);
            this.номер_группыTextBox.Name = "номер_группыTextBox";
            this.номер_группыTextBox.Size = new System.Drawing.Size(357, 26);
            this.номер_группыTextBox.TabIndex = 6;
            // 
            // серия_и_номер_паспортаTextBox
            // 
            this.серия_и_номер_паспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Серия и номер паспорта", true));
            this.серия_и_номер_паспортаTextBox.Location = new System.Drawing.Point(279, 131);
            this.серия_и_номер_паспортаTextBox.Name = "серия_и_номер_паспортаTextBox";
            this.серия_и_номер_паспортаTextBox.Size = new System.Drawing.Size(357, 26);
            this.серия_и_номер_паспортаTextBox.TabIndex = 8;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(279, 163);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(357, 26);
            this.дата_рожденияDateTimePicker.TabIndex = 10;
            // 
            // адрес_пропискиTextBox
            // 
            this.адрес_пропискиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Адрес прописки", true));
            this.адрес_пропискиTextBox.Location = new System.Drawing.Point(279, 195);
            this.адрес_пропискиTextBox.Name = "адрес_пропискиTextBox";
            this.адрес_пропискиTextBox.Size = new System.Drawing.Size(357, 26);
            this.адрес_пропискиTextBox.TabIndex = 12;
            // 
            // фактический_адрес_проживанияTextBox
            // 
            this.фактический_адрес_проживанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Фактический адрес проживания", true));
            this.фактический_адрес_проживанияTextBox.Location = new System.Drawing.Point(279, 227);
            this.фактический_адрес_проживанияTextBox.Name = "фактический_адрес_проживанияTextBox";
            this.фактический_адрес_проживанияTextBox.Size = new System.Drawing.Size(357, 26);
            this.фактический_адрес_проживанияTextBox.TabIndex = 14;
            // 
            // фотографияPictureBox
            // 
            this.фотографияPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.студентыBindingSource, "Фотография", true));
            this.фотографияPictureBox.Location = new System.Drawing.Point(681, 62);
            this.фотографияPictureBox.Name = "фотографияPictureBox";
            this.фотографияPictureBox.Size = new System.Drawing.Size(234, 289);
            this.фотографияPictureBox.TabIndex = 18;
            this.фотографияPictureBox.TabStop = false;
            // 
            // openPhotoButton
            // 
            this.openPhotoButton.Location = new System.Drawing.Point(796, 26);
            this.openPhotoButton.Name = "openPhotoButton";
            this.openPhotoButton.Size = new System.Drawing.Size(119, 30);
            this.openPhotoButton.TabIndex = 19;
            this.openPhotoButton.Text = "Открыть";
            this.openPhotoButton.UseVisualStyleBackColor = true;
            this.openPhotoButton.Click += new System.EventHandler(this.openPhotoButton_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialogPhoto";
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.facultyDataSet;
            // 
            // facultyDataSet
            // 
            this.facultyDataSet.DataSetName = "facultyDataSet";
            this.facultyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = dblabs.facultyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГруппыTableAdapter = null;
            this.tableAdapterManager.Изучение_предметов_студентамиTableAdapter = null;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = this.студентыTableAdapter;
            this.tableAdapterManager.ФакультетTableAdapter = null;
            // 
            // год_поступленияLabel
            // 
            год_поступленияLabel.AutoSize = true;
            год_поступленияLabel.Location = new System.Drawing.Point(12, 259);
            год_поступленияLabel.Name = "год_поступленияLabel";
            год_поступленияLabel.Size = new System.Drawing.Size(143, 20);
            год_поступленияLabel.TabIndex = 19;
            год_поступленияLabel.Text = "Год поступления:";
            // 
            // год_поступленияComboBox
            // 
            this.год_поступленияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Год поступления", true));
            this.год_поступленияComboBox.FormattingEnabled = true;
            this.год_поступленияComboBox.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.год_поступленияComboBox.Location = new System.Drawing.Point(279, 259);
            this.год_поступленияComboBox.Name = "год_поступленияComboBox";
            this.год_поступленияComboBox.Size = new System.Drawing.Size(357, 28);
            this.год_поступленияComboBox.TabIndex = 20;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 419);
            this.Controls.Add(год_поступленияLabel);
            this.Controls.Add(this.год_поступленияComboBox);
            this.Controls.Add(this.openPhotoButton);
            this.Controls.Add(номер_зачётной_книжкиLabel);
            this.Controls.Add(this.номер_зачётной_книжкиTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(номер_группыLabel);
            this.Controls.Add(this.номер_группыTextBox);
            this.Controls.Add(серия_и_номер_паспортаLabel);
            this.Controls.Add(this.серия_и_номер_паспортаTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(адрес_пропискиLabel);
            this.Controls.Add(this.адрес_пропискиTextBox);
            this.Controls.Add(фактический_адрес_проживанияLabel);
            this.Controls.Add(this.фактический_адрес_проживанияTextBox);
            this.Controls.Add(фотографияLabel);
            this.Controls.Add(this.фотографияPictureBox);
            this.Controls.Add(this.студентыBindingNavigator);
            this.Name = "StudentsForm";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).EndInit();
            this.студентыBindingNavigator.ResumeLayout(false);
            this.студентыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотографияPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private facultyDataSet facultyDataSet;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private facultyDataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private facultyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator студентыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton студентыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номер_зачётной_книжкиTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox номер_группыTextBox;
        private System.Windows.Forms.TextBox серия_и_номер_паспортаTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox адрес_пропискиTextBox;
        private System.Windows.Forms.TextBox фактический_адрес_проживанияTextBox;
        private System.Windows.Forms.PictureBox фотографияPictureBox;
        private System.Windows.Forms.Button openPhotoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.ComboBox год_поступленияComboBox;
    }
}