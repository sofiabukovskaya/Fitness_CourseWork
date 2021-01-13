
namespace Fitness_CourseWork
{
    partial class GroupSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupSchedule));
            System.Windows.Forms.Label назваLabel;
            System.Windows.Forms.Label вид_занятьLabel;
            System.Windows.Forms.Label iD_тренераLabel;
            System.Windows.Forms.Label кількість_вільних_місцьLabel;
            this.fitness_DbDataSet1 = new Fitness_CourseWork.Fitness_DbDataSet1();
            this.групиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.групиTableAdapter = new Fitness_CourseWork.Fitness_DbDataSet1TableAdapters.ГрупиTableAdapter();
            this.tableAdapterManager = new Fitness_CourseWork.Fitness_DbDataSet1TableAdapters.TableAdapterManager();
            this.групиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.групиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.назваTextBox = new System.Windows.Forms.TextBox();
            this.вид_занятьTextBox = new System.Windows.Forms.TextBox();
            this.iD_тренераTextBox = new System.Windows.Forms.TextBox();
            this.кількість_вільних_місцьTextBox = new System.Windows.Forms.TextBox();
            this.розклад_групиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.розклад_групиTableAdapter = new Fitness_CourseWork.Fitness_DbDataSet1TableAdapters.Розклад_групиTableAdapter();
            this.розклад_групиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptChangeButton = new System.Windows.Forms.Button();
            назваLabel = new System.Windows.Forms.Label();
            вид_занятьLabel = new System.Windows.Forms.Label();
            iD_тренераLabel = new System.Windows.Forms.Label();
            кількість_вільних_місцьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitness_DbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingNavigator)).BeginInit();
            this.групиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.розклад_групиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.розклад_групиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fitness_DbDataSet1
            // 
            this.fitness_DbDataSet1.DataSetName = "Fitness_DbDataSet1";
            this.fitness_DbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // групиBindingSource
            // 
            this.групиBindingSource.DataMember = "Групи";
            this.групиBindingSource.DataSource = this.fitness_DbDataSet1;
            // 
            // групиTableAdapter
            // 
            this.групиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Fitness_CourseWork.Fitness_DbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АбонементTableAdapter = null;
            this.tableAdapterManager.АдміністраторTableAdapter = null;
            this.tableAdapterManager.Акаунт_адміністратораTableAdapter = null;
            this.tableAdapterManager.Акаунт_клієнтаTableAdapter = null;
            this.tableAdapterManager.ГрупиTableAdapter = this.групиTableAdapter;
            this.tableAdapterManager.Групові_заняттяTableAdapter = null;
            this.tableAdapterManager.КлієнтTableAdapter = null;
            this.tableAdapterManager.КупівляTableAdapter = null;
            this.tableAdapterManager.Розклад_групиTableAdapter = this.розклад_групиTableAdapter;
            this.tableAdapterManager.Розклад_тренераTableAdapter = null;
            this.tableAdapterManager.ТренерTableAdapter = null;
            // 
            // групиBindingNavigator
            // 
            this.групиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.групиBindingNavigator.BindingSource = this.групиBindingSource;
            this.групиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.групиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.групиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.групиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.групиBindingNavigatorSaveItem});
            this.групиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.групиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.групиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.групиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.групиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.групиBindingNavigator.Name = "групиBindingNavigator";
            this.групиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.групиBindingNavigator.Size = new System.Drawing.Size(991, 27);
            this.групиBindingNavigator.TabIndex = 0;
            this.групиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // групиBindingNavigatorSaveItem
            // 
            this.групиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.групиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("групиBindingNavigatorSaveItem.Image")));
            this.групиBindingNavigatorSaveItem.Name = "групиBindingNavigatorSaveItem";
            this.групиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.групиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.групиBindingNavigatorSaveItem.Click += new System.EventHandler(this.групиBindingNavigatorSaveItem_Click);
            // 
            // назваLabel
            // 
            назваLabel.AutoSize = true;
            назваLabel.Location = new System.Drawing.Point(34, 78);
            назваLabel.Name = "назваLabel";
            назваLabel.Size = new System.Drawing.Size(52, 17);
            назваLabel.TabIndex = 3;
            назваLabel.Text = "Назва:";
            // 
            // назваTextBox
            // 
            this.назваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.групиBindingSource, "Назва", true));
            this.назваTextBox.Location = new System.Drawing.Point(270, 75);
            this.назваTextBox.Name = "назваTextBox";
            this.назваTextBox.Size = new System.Drawing.Size(100, 22);
            this.назваTextBox.TabIndex = 4;
            // 
            // вид_занятьLabel
            // 
            вид_занятьLabel.AutoSize = true;
            вид_занятьLabel.Location = new System.Drawing.Point(34, 106);
            вид_занятьLabel.Name = "вид_занятьLabel";
            вид_занятьLabel.Size = new System.Drawing.Size(86, 17);
            вид_занятьLabel.TabIndex = 5;
            вид_занятьLabel.Text = "Вид занять:";
            // 
            // вид_занятьTextBox
            // 
            this.вид_занятьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.групиBindingSource, "Вид занять", true));
            this.вид_занятьTextBox.Location = new System.Drawing.Point(270, 103);
            this.вид_занятьTextBox.Name = "вид_занятьTextBox";
            this.вид_занятьTextBox.Size = new System.Drawing.Size(100, 22);
            this.вид_занятьTextBox.TabIndex = 6;
            // 
            // iD_тренераLabel
            // 
            iD_тренераLabel.AutoSize = true;
            iD_тренераLabel.Location = new System.Drawing.Point(34, 134);
            iD_тренераLabel.Name = "iD_тренераLabel";
            iD_тренераLabel.Size = new System.Drawing.Size(84, 17);
            iD_тренераLabel.TabIndex = 7;
            iD_тренераLabel.Text = "ID тренера:";
            // 
            // iD_тренераTextBox
            // 
            this.iD_тренераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.групиBindingSource, "ID_тренера", true));
            this.iD_тренераTextBox.Location = new System.Drawing.Point(270, 131);
            this.iD_тренераTextBox.Name = "iD_тренераTextBox";
            this.iD_тренераTextBox.Size = new System.Drawing.Size(100, 22);
            this.iD_тренераTextBox.TabIndex = 8;
            // 
            // кількість_вільних_місцьLabel
            // 
            кількість_вільних_місцьLabel.AutoSize = true;
            кількість_вільних_місцьLabel.Location = new System.Drawing.Point(34, 162);
            кількість_вільних_місцьLabel.Name = "кількість_вільних_місцьLabel";
            кількість_вільних_місцьLabel.Size = new System.Drawing.Size(159, 17);
            кількість_вільних_місцьLabel.TabIndex = 9;
            кількість_вільних_місцьLabel.Text = "Кількість вільних місць:";
            // 
            // кількість_вільних_місцьTextBox
            // 
            this.кількість_вільних_місцьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.групиBindingSource, "Кількість вільних місць", true));
            this.кількість_вільних_місцьTextBox.Location = new System.Drawing.Point(270, 159);
            this.кількість_вільних_місцьTextBox.Name = "кількість_вільних_місцьTextBox";
            this.кількість_вільних_місцьTextBox.Size = new System.Drawing.Size(100, 22);
            this.кількість_вільних_місцьTextBox.TabIndex = 10;
            // 
            // розклад_групиBindingSource
            // 
            this.розклад_групиBindingSource.DataMember = "FK__Розклад г__ID_гр__4E88ABD4";
            this.розклад_групиBindingSource.DataSource = this.групиBindingSource;
            // 
            // розклад_групиTableAdapter
            // 
            this.розклад_групиTableAdapter.ClearBeforeFill = true;
            // 
            // розклад_групиDataGridView
            // 
            this.розклад_групиDataGridView.AutoGenerateColumns = false;
            this.розклад_групиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.розклад_групиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.розклад_групиDataGridView.DataSource = this.розклад_групиBindingSource;
            this.розклад_групиDataGridView.Location = new System.Drawing.Point(129, 274);
            this.розклад_групиDataGridView.Name = "розклад_групиDataGridView";
            this.розклад_групиDataGridView.RowHeadersWidth = 51;
            this.розклад_групиDataGridView.RowTemplate.Height = 24;
            this.розклад_групиDataGridView.Size = new System.Drawing.Size(679, 220);
            this.розклад_групиDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_групи";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_групи";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "День тижня";
            this.dataGridViewTextBoxColumn2.HeaderText = "День тижня";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Початок занять";
            this.dataGridViewTextBoxColumn3.HeaderText = "Початок занять";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Кінець занять";
            this.dataGridViewTextBoxColumn4.HeaderText = "Кінець занять";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Вид занять";
            this.dataGridViewTextBoxColumn5.HeaderText = "Вид занять";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // acceptChangeButton
            // 
            this.acceptChangeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.acceptChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.acceptChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.acceptChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptChangeButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptChangeButton.Location = new System.Drawing.Point(691, 78);
            this.acceptChangeButton.Name = "acceptChangeButton";
            this.acceptChangeButton.Size = new System.Drawing.Size(160, 69);
            this.acceptChangeButton.TabIndex = 12;
            this.acceptChangeButton.Text = "Підтвердити зміни";
            this.acceptChangeButton.UseVisualStyleBackColor = true;
            this.acceptChangeButton.Click += new System.EventHandler(this.acceptChangeButton_Click);
            // 
            // GroupSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 575);
            this.Controls.Add(this.acceptChangeButton);
            this.Controls.Add(this.розклад_групиDataGridView);
            this.Controls.Add(назваLabel);
            this.Controls.Add(this.назваTextBox);
            this.Controls.Add(вид_занятьLabel);
            this.Controls.Add(this.вид_занятьTextBox);
            this.Controls.Add(iD_тренераLabel);
            this.Controls.Add(this.iD_тренераTextBox);
            this.Controls.Add(кількість_вільних_місцьLabel);
            this.Controls.Add(this.кількість_вільних_місцьTextBox);
            this.Controls.Add(this.групиBindingNavigator);
            this.Name = "GroupSchedule";
            this.Text = "GroupSchedule";
            this.Load += new System.EventHandler(this.GroupSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitness_DbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingNavigator)).EndInit();
            this.групиBindingNavigator.ResumeLayout(false);
            this.групиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.розклад_групиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.розклад_групиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Fitness_DbDataSet1 fitness_DbDataSet1;
        private System.Windows.Forms.BindingSource групиBindingSource;
        private Fitness_DbDataSet1TableAdapters.ГрупиTableAdapter групиTableAdapter;
        private Fitness_DbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator групиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton групиBindingNavigatorSaveItem;
        private Fitness_DbDataSet1TableAdapters.Розклад_групиTableAdapter розклад_групиTableAdapter;
        private System.Windows.Forms.TextBox назваTextBox;
        private System.Windows.Forms.TextBox вид_занятьTextBox;
        private System.Windows.Forms.TextBox iD_тренераTextBox;
        private System.Windows.Forms.TextBox кількість_вільних_місцьTextBox;
        private System.Windows.Forms.BindingSource розклад_групиBindingSource;
        private System.Windows.Forms.DataGridView розклад_групиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button acceptChangeButton;
    }
}