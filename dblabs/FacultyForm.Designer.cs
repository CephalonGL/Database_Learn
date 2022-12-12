namespace dblabs
{
    partial class FacultyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyForm));
            System.Windows.Forms.Label название_факультетаLabel;
            System.Windows.Forms.Label фИО_деканаLabel;
            this.facultyDataSet = new dblabs.facultyDataSet();
            this.факультетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.факультетTableAdapter = new dblabs.facultyDataSetTableAdapters.ФакультетTableAdapter();
            this.tableAdapterManager = new dblabs.facultyDataSetTableAdapters.TableAdapterManager();
            this.факультетBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.факультетBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.название_факультетаTextBox = new System.Windows.Forms.TextBox();
            this.фИО_деканаTextBox = new System.Windows.Forms.TextBox();
            название_факультетаLabel = new System.Windows.Forms.Label();
            фИО_деканаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingNavigator)).BeginInit();
            this.факультетBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // facultyDataSet
            // 
            this.facultyDataSet.DataSetName = "facultyDataSet";
            this.facultyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // факультетBindingSource
            // 
            this.факультетBindingSource.DataMember = "Факультет";
            this.факультетBindingSource.DataSource = this.facultyDataSet;
            // 
            // факультетTableAdapter
            // 
            this.факультетTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = dblabs.facultyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГруппыTableAdapter = null;
            this.tableAdapterManager.Изучение_предметов_студентамиTableAdapter = null;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = null;
            this.tableAdapterManager.ФакультетTableAdapter = this.факультетTableAdapter;
            // 
            // факультетBindingNavigator
            // 
            this.факультетBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.факультетBindingNavigator.BindingSource = this.факультетBindingSource;
            this.факультетBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.факультетBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.факультетBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.факультетBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.факультетBindingNavigatorSaveItem});
            this.факультетBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.факультетBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.факультетBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.факультетBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.факультетBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.факультетBindingNavigator.Name = "факультетBindingNavigator";
            this.факультетBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.факультетBindingNavigator.Size = new System.Drawing.Size(584, 33);
            this.факультетBindingNavigator.TabIndex = 0;
            this.факультетBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // факультетBindingNavigatorSaveItem
            // 
            this.факультетBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.факультетBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("факультетBindingNavigatorSaveItem.Image")));
            this.факультетBindingNavigatorSaveItem.Name = "факультетBindingNavigatorSaveItem";
            this.факультетBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.факультетBindingNavigatorSaveItem.Text = "Save Data";
            this.факультетBindingNavigatorSaveItem.Click += new System.EventHandler(this.факультетBindingNavigatorSaveItem_Click);
            // 
            // название_факультетаLabel
            // 
            название_факультетаLabel.AutoSize = true;
            название_факультетаLabel.Location = new System.Drawing.Point(12, 35);
            название_факультетаLabel.Name = "название_факультетаLabel";
            название_факультетаLabel.Size = new System.Drawing.Size(185, 20);
            название_факультетаLabel.TabIndex = 1;
            название_факультетаLabel.Text = "Название факультета:";
            // 
            // название_факультетаTextBox
            // 
            this.название_факультетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.факультетBindingSource, "Название факультета", true));
            this.название_факультетаTextBox.Location = new System.Drawing.Point(203, 32);
            this.название_факультетаTextBox.Name = "название_факультетаTextBox";
            this.название_факультетаTextBox.Size = new System.Drawing.Size(343, 26);
            this.название_факультетаTextBox.TabIndex = 2;
            // 
            // фИО_деканаLabel
            // 
            фИО_деканаLabel.AutoSize = true;
            фИО_деканаLabel.Location = new System.Drawing.Point(12, 67);
            фИО_деканаLabel.Name = "фИО_деканаLabel";
            фИО_деканаLabel.Size = new System.Drawing.Size(110, 20);
            фИО_деканаLabel.TabIndex = 3;
            фИО_деканаLabel.Text = "ФИО декана:";
            // 
            // фИО_деканаTextBox
            // 
            this.фИО_деканаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.факультетBindingSource, "ФИО декана", true));
            this.фИО_деканаTextBox.Location = new System.Drawing.Point(203, 64);
            this.фИО_деканаTextBox.Name = "фИО_деканаTextBox";
            this.фИО_деканаTextBox.Size = new System.Drawing.Size(343, 26);
            this.фИО_деканаTextBox.TabIndex = 4;
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 111);
            this.Controls.Add(название_факультетаLabel);
            this.Controls.Add(this.название_факультетаTextBox);
            this.Controls.Add(фИО_деканаLabel);
            this.Controls.Add(this.фИО_деканаTextBox);
            this.Controls.Add(this.факультетBindingNavigator);
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.Load += new System.EventHandler(this.FacultyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingNavigator)).EndInit();
            this.факультетBindingNavigator.ResumeLayout(false);
            this.факультетBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private facultyDataSet facultyDataSet;
        private System.Windows.Forms.BindingSource факультетBindingSource;
        private facultyDataSetTableAdapters.ФакультетTableAdapter факультетTableAdapter;
        private facultyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator факультетBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton факультетBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox название_факультетаTextBox;
        private System.Windows.Forms.TextBox фИО_деканаTextBox;
    }
}