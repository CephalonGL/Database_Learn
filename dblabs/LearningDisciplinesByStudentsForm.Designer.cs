namespace dblabs
{
    partial class LearningDisciplinesByStudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearningDisciplinesByStudentsForm));
            this.facultyDataSet = new dblabs.facultyDataSet();
            this.изучение_предметов_студентамиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.изучение_предметов_студентамиTableAdapter = new dblabs.facultyDataSetTableAdapters.Изучение_предметов_студентамиTableAdapter();
            this.tableAdapterManager = new dblabs.facultyDataSetTableAdapters.TableAdapterManager();
            this.изучение_предметов_студентамиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.изучение_предметов_студентамиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.изучение_предметов_студентамиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изучение_предметов_студентамиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изучение_предметов_студентамиBindingNavigator)).BeginInit();
            this.изучение_предметов_студентамиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изучение_предметов_студентамиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // facultyDataSet
            // 
            this.facultyDataSet.DataSetName = "facultyDataSet";
            this.facultyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // изучение_предметов_студентамиBindingSource
            // 
            this.изучение_предметов_студентамиBindingSource.DataMember = "Изучение предметов студентами";
            this.изучение_предметов_студентамиBindingSource.DataSource = this.facultyDataSet;
            // 
            // изучение_предметов_студентамиTableAdapter
            // 
            this.изучение_предметов_студентамиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = dblabs.facultyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГруппыTableAdapter = null;
            this.tableAdapterManager.Изучение_предметов_студентамиTableAdapter = this.изучение_предметов_студентамиTableAdapter;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = null;
            this.tableAdapterManager.ФакультетTableAdapter = null;
            // 
            // изучение_предметов_студентамиBindingNavigator
            // 
            this.изучение_предметов_студентамиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.изучение_предметов_студентамиBindingNavigator.BindingSource = this.изучение_предметов_студентамиBindingSource;
            this.изучение_предметов_студентамиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.изучение_предметов_студентамиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.изучение_предметов_студентамиBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.изучение_предметов_студентамиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.изучение_предметов_студентамиBindingNavigatorSaveItem});
            this.изучение_предметов_студентамиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.изучение_предметов_студентамиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.изучение_предметов_студентамиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.изучение_предметов_студентамиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.изучение_предметов_студентамиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.изучение_предметов_студентамиBindingNavigator.Name = "изучение_предметов_студентамиBindingNavigator";
            this.изучение_предметов_студентамиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.изучение_предметов_студентамиBindingNavigator.Size = new System.Drawing.Size(1273, 38);
            this.изучение_предметов_студентамиBindingNavigator.TabIndex = 0;
            this.изучение_предметов_студентамиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // изучение_предметов_студентамиBindingNavigatorSaveItem
            // 
            this.изучение_предметов_студентамиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.изучение_предметов_студентамиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("изучение_предметов_студентамиBindingNavigatorSaveItem.Image")));
            this.изучение_предметов_студентамиBindingNavigatorSaveItem.Name = "изучение_предметов_студентамиBindingNavigatorSaveItem";
            this.изучение_предметов_студентамиBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.изучение_предметов_студентамиBindingNavigatorSaveItem.Text = "Save Data";
            this.изучение_предметов_студентамиBindingNavigatorSaveItem.Click += new System.EventHandler(this.изучение_предметов_студентамиBindingNavigatorSaveItem_Click);
            // 
            // изучение_предметов_студентамиDataGridView
            // 
            this.изучение_предметов_студентамиDataGridView.AutoGenerateColumns = false;
            this.изучение_предметов_студентамиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.изучение_предметов_студентамиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2});
            this.изучение_предметов_студентамиDataGridView.DataSource = this.изучение_предметов_студентамиBindingSource;
            this.изучение_предметов_студентамиDataGridView.Location = new System.Drawing.Point(12, 36);
            this.изучение_предметов_студентамиDataGridView.Name = "изучение_предметов_студентамиDataGridView";
            this.изучение_предметов_студентамиDataGridView.RowHeadersWidth = 62;
            this.изучение_предметов_студентамиDataGridView.RowTemplate.Height = 28;
            this.изучение_предметов_студентамиDataGridView.Size = new System.Drawing.Size(1249, 406);
            this.изучение_предметов_студентамиDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер зачётной книжки";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер зачётной книжки";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название предмета";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название предмета";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Оценка";
            this.dataGridViewTextBoxColumn3.HeaderText = "Оценка";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Своевременная сдача";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Своевременная сдача";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Перезачёт";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Перезачёт";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 150;
            // 
            // LearningDisciplinesByStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 454);
            this.Controls.Add(this.изучение_предметов_студентамиDataGridView);
            this.Controls.Add(this.изучение_предметов_студентамиBindingNavigator);
            this.Name = "LearningDisciplinesByStudentsForm";
            this.Text = "LearningDisciplinesByStudents";
            this.Load += new System.EventHandler(this.LearningDisciplinesByStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изучение_предметов_студентамиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изучение_предметов_студентамиBindingNavigator)).EndInit();
            this.изучение_предметов_студентамиBindingNavigator.ResumeLayout(false);
            this.изучение_предметов_студентамиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изучение_предметов_студентамиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private facultyDataSet facultyDataSet;
        private System.Windows.Forms.BindingSource изучение_предметов_студентамиBindingSource;
        private facultyDataSetTableAdapters.Изучение_предметов_студентамиTableAdapter изучение_предметов_студентамиTableAdapter;
        private facultyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator изучение_предметов_студентамиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton изучение_предметов_студентамиBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView изучение_предметов_студентамиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    }
}