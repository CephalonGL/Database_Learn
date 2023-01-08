namespace dblabs
{
    partial class FormSQL
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
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPageExample = new System.Windows.Forms.TabPage();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.groupBoxDataRequests = new System.Windows.Forms.GroupBox();
            this.radioButtonStudents = new System.Windows.Forms.RadioButton();
            this.radioButtonDisciplines = new System.Windows.Forms.RadioButton();
            this.radioButtonGroups = new System.Windows.Forms.RadioButton();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.labelGroupNumber = new System.Windows.Forms.Label();
            this.textBoxGroupNumber = new System.Windows.Forms.TextBox();
            this.checkBoxDescendingNameSort = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControlSQL.SuspendLayout();
            this.tabPageExample.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            this.groupBoxDataRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSQL.Controls.Add(this.tabPageExample);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Location = new System.Drawing.Point(12, 12);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(1507, 707);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPageExample
            // 
            this.tabPageExample.Controls.Add(this.groupBoxDataRequests);
            this.tabPageExample.Location = new System.Drawing.Point(4, 29);
            this.tabPageExample.Name = "tabPageExample";
            this.tabPageExample.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExample.Size = new System.Drawing.Size(1499, 674);
            this.tabPageExample.TabIndex = 0;
            this.tabPageExample.Text = "Примеры запросов";
            this.tabPageExample.UseVisualStyleBackColor = true;
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.checkBoxDescendingNameSort);
            this.tabPageSelect.Controls.Add(this.textBoxGroupNumber);
            this.tabPageSelect.Controls.Add(this.labelGroupNumber);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 29);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(1499, 674);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // groupBoxDataRequests
            // 
            this.groupBoxDataRequests.Controls.Add(this.dataGridViewSelect);
            this.groupBoxDataRequests.Controls.Add(this.radioButtonGroups);
            this.groupBoxDataRequests.Controls.Add(this.radioButtonDisciplines);
            this.groupBoxDataRequests.Controls.Add(this.radioButtonStudents);
            this.groupBoxDataRequests.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDataRequests.Name = "groupBoxDataRequests";
            this.groupBoxDataRequests.Size = new System.Drawing.Size(756, 381);
            this.groupBoxDataRequests.TabIndex = 0;
            this.groupBoxDataRequests.TabStop = false;
            this.groupBoxDataRequests.Text = "Запросы по данным";
            // 
            // radioButtonStudents
            // 
            this.radioButtonStudents.AutoSize = true;
            this.radioButtonStudents.Location = new System.Drawing.Point(100, 25);
            this.radioButtonStudents.Name = "radioButtonStudents";
            this.radioButtonStudents.Size = new System.Drawing.Size(110, 24);
            this.radioButtonStudents.TabIndex = 0;
            this.radioButtonStudents.TabStop = true;
            this.radioButtonStudents.Text = "Студенты";
            this.radioButtonStudents.UseVisualStyleBackColor = true;
            this.radioButtonStudents.CheckedChanged += new System.EventHandler(this.radioButtonStudents_CheckedChanged);
            // 
            // radioButtonDisciplines
            // 
            this.radioButtonDisciplines.AutoSize = true;
            this.radioButtonDisciplines.Location = new System.Drawing.Point(216, 25);
            this.radioButtonDisciplines.Name = "radioButtonDisciplines";
            this.radioButtonDisciplines.Size = new System.Drawing.Size(115, 24);
            this.radioButtonDisciplines.TabIndex = 1;
            this.radioButtonDisciplines.TabStop = true;
            this.radioButtonDisciplines.Text = "Предметы";
            this.radioButtonDisciplines.UseVisualStyleBackColor = true;
            this.radioButtonDisciplines.CheckedChanged += new System.EventHandler(this.radioButtonDisciplines_CheckedChanged);
            // 
            // radioButtonGroups
            // 
            this.radioButtonGroups.AutoSize = true;
            this.radioButtonGroups.Location = new System.Drawing.Point(6, 25);
            this.radioButtonGroups.Name = "radioButtonGroups";
            this.radioButtonGroups.Size = new System.Drawing.Size(88, 24);
            this.radioButtonGroups.TabIndex = 2;
            this.radioButtonGroups.TabStop = true;
            this.radioButtonGroups.Text = "Группы";
            this.radioButtonGroups.UseVisualStyleBackColor = true;
            this.radioButtonGroups.CheckedChanged += new System.EventHandler(this.radioButtonGroups_CheckedChanged);
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Location = new System.Drawing.Point(6, 55);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.RowHeadersWidth = 62;
            this.dataGridViewSelect.RowTemplate.Height = 28;
            this.dataGridViewSelect.Size = new System.Drawing.Size(1481, 607);
            this.dataGridViewSelect.TabIndex = 3;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFSelect.Controls.Add(this.dataGridView1);
            this.groupBoxFSelect.Location = new System.Drawing.Point(6, 98);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(1487, 570);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Информация об успеваемости студентов";
            // 
            // labelGroupNumber
            // 
            this.labelGroupNumber.AutoSize = true;
            this.labelGroupNumber.Location = new System.Drawing.Point(6, 3);
            this.labelGroupNumber.Name = "labelGroupNumber";
            this.labelGroupNumber.Size = new System.Drawing.Size(115, 20);
            this.labelGroupNumber.TabIndex = 1;
            this.labelGroupNumber.Text = "Номер группы";
            // 
            // textBoxGroupNumber
            // 
            this.textBoxGroupNumber.Location = new System.Drawing.Point(127, 3);
            this.textBoxGroupNumber.Name = "textBoxGroupNumber";
            this.textBoxGroupNumber.Size = new System.Drawing.Size(100, 26);
            this.textBoxGroupNumber.TabIndex = 2;
            this.textBoxGroupNumber.Leave += new System.EventHandler(this.textBoxGroupNumber_Leave);
            // 
            // checkBoxDescendingNameSort
            // 
            this.checkBoxDescendingNameSort.AutoSize = true;
            this.checkBoxDescendingNameSort.Location = new System.Drawing.Point(279, 6);
            this.checkBoxDescendingNameSort.Name = "checkBoxDescendingNameSort";
            this.checkBoxDescendingNameSort.Size = new System.Drawing.Size(279, 24);
            this.checkBoxDescendingNameSort.TabIndex = 3;
            this.checkBoxDescendingNameSort.Text = "Сортировать по убыванию ФИО";
            this.checkBoxDescendingNameSort.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1475, 539);
            this.dataGridView1.TabIndex = 4;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 731);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPageExample.ResumeLayout(false);
            this.tabPageSelect.ResumeLayout(false);
            this.tabPageSelect.PerformLayout();
            this.groupBoxDataRequests.ResumeLayout(false);
            this.groupBoxDataRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPageExample;
        private System.Windows.Forms.GroupBox groupBoxDataRequests;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.RadioButton radioButtonGroups;
        private System.Windows.Forms.RadioButton radioButtonDisciplines;
        private System.Windows.Forms.RadioButton radioButtonStudents;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.TextBox textBoxGroupNumber;
        private System.Windows.Forms.Label labelGroupNumber;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.CheckBox checkBoxDescendingNameSort;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}