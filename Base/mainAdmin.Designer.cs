using System.Windows.Forms;

namespace Base
{
    partial class mainAdmin
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
            this.tabDop = new System.Windows.Forms.TabPage();
            this.delType = new System.Windows.Forms.Button();
            this.delClass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridClass = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDataSet = new Base.BaseDataSet();
            this.gridType = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabProvide = new System.Windows.Forms.TabPage();
            this.gridProviders = new System.Windows.Forms.DataGridView();
            this.delProv = new System.Windows.Forms.Button();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.employeeMessage = new System.Windows.Forms.Label();
            this.delEmp = new System.Windows.Forms.Button();
            this.searchStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridEmployee = new System.Windows.Forms.DataGridView();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabItems = new System.Windows.Forms.TabPage();
            this.reportW = new System.Windows.Forms.Button();
            this.reportEx = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchItemName = new System.Windows.Forms.TextBox();
            this.costMax = new System.Windows.Forms.TextBox();
            this.costMin = new System.Windows.Forms.TextBox();
            this.delItem = new System.Windows.Forms.Button();
            this.gridItems = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStorage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveInStorageButton = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxItemName = new System.Windows.Forms.ComboBox();
            this.DelStorage = new System.Windows.Forms.Button();
            this.gridStorage = new System.Windows.Forms.DataGridView();
            this.tabPosition = new System.Windows.Forms.TabPage();
            this.delPositionButton = new System.Windows.Forms.Button();
            this.gridPosition = new System.Windows.Forms.DataGridView();
            this.типTableAdapter = new Base.BaseDataSetTableAdapters.ТипTableAdapter();
            this.категорияTableAdapter = new Base.BaseDataSetTableAdapters.КатегорияTableAdapter();
            this.сотрудникиTableAdapter = new Base.BaseDataSetTableAdapters.СотрудникиTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tabDop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типBindingSource)).BeginInit();
            this.tabProvide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProviders)).BeginInit();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.tabItems.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabStorage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStorage)).BeginInit();
            this.tabPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDop
            // 
            this.tabDop.Controls.Add(this.delType);
            this.tabDop.Controls.Add(this.delClass);
            this.tabDop.Controls.Add(this.label2);
            this.tabDop.Controls.Add(this.label1);
            this.tabDop.Controls.Add(this.gridClass);
            this.tabDop.Controls.Add(this.gridType);
            this.tabDop.Location = new System.Drawing.Point(4, 22);
            this.tabDop.Name = "tabDop";
            this.tabDop.Size = new System.Drawing.Size(795, 392);
            this.tabDop.TabIndex = 4;
            this.tabDop.Text = "Доп";
            this.tabDop.UseVisualStyleBackColor = true;
            // 
            // delType
            // 
            this.delType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delType.Location = new System.Drawing.Point(471, 73);
            this.delType.Name = "delType";
            this.delType.Size = new System.Drawing.Size(120, 48);
            this.delType.TabIndex = 4;
            this.delType.Text = "Удалить тип";
            this.delType.UseVisualStyleBackColor = true;
            this.delType.Click += new System.EventHandler(this.delType_Click);
            // 
            // delClass
            // 
            this.delClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delClass.Location = new System.Drawing.Point(471, 282);
            this.delClass.Name = "delClass";
            this.delClass.Size = new System.Drawing.Size(120, 59);
            this.delClass.TabIndex = 4;
            this.delClass.Text = "Удалить категорию";
            this.delClass.UseVisualStyleBackColor = true;
            this.delClass.Click += new System.EventHandler(this.delClass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Типы товаров";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Категории товаров";
            // 
            // gridClass
            // 
            this.gridClass.AutoGenerateColumns = false;
            this.gridClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClass.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn2});
            this.gridClass.DataSource = this.категорияBindingSource;
            this.gridClass.Location = new System.Drawing.Point(19, 235);
            this.gridClass.Name = "gridClass";
            this.gridClass.Size = new System.Drawing.Size(409, 137);
            this.gridClass.TabIndex = 1;
            this.gridClass.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "код";
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            // 
            // наименованиеDataGridViewTextBoxColumn2
            // 
            this.наименованиеDataGridViewTextBoxColumn2.DataPropertyName = "наименование";
            this.наименованиеDataGridViewTextBoxColumn2.HeaderText = "наименование";
            this.наименованиеDataGridViewTextBoxColumn2.Name = "наименованиеDataGridViewTextBoxColumn2";
            // 
            // категорияBindingSource
            // 
            this.категорияBindingSource.DataMember = "Категория";
            this.категорияBindingSource.DataSource = this.baseDataSet;
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "BaseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridType
            // 
            this.gridType.AutoGenerateColumns = false;
            this.gridType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridType.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn1});
            this.gridType.DataSource = this.типBindingSource;
            this.gridType.Location = new System.Drawing.Point(19, 36);
            this.gridType.Name = "gridType";
            this.gridType.Size = new System.Drawing.Size(409, 138);
            this.gridType.TabIndex = 0;
            this.gridType.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn1
            // 
            this.наименованиеDataGridViewTextBoxColumn1.DataPropertyName = "наименование";
            this.наименованиеDataGridViewTextBoxColumn1.HeaderText = "наименование";
            this.наименованиеDataGridViewTextBoxColumn1.Name = "наименованиеDataGridViewTextBoxColumn1";
            // 
            // типBindingSource
            // 
            this.типBindingSource.DataMember = "Тип";
            this.типBindingSource.DataSource = this.baseDataSet;
            // 
            // tabProvide
            // 
            this.tabProvide.Controls.Add(this.gridProviders);
            this.tabProvide.Controls.Add(this.delProv);
            this.tabProvide.Location = new System.Drawing.Point(4, 22);
            this.tabProvide.Name = "tabProvide";
            this.tabProvide.Size = new System.Drawing.Size(795, 392);
            this.tabProvide.TabIndex = 3;
            this.tabProvide.Text = "Поставщики";
            this.tabProvide.UseVisualStyleBackColor = true;
            // 
            // gridProviders
            // 
            this.gridProviders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProviders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridProviders.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProviders.Location = new System.Drawing.Point(25, 22);
            this.gridProviders.Name = "gridProviders";
            this.gridProviders.Size = new System.Drawing.Size(753, 306);
            this.gridProviders.TabIndex = 2;
            this.gridProviders.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            // 
            // delProv
            // 
            this.delProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delProv.Location = new System.Drawing.Point(613, 345);
            this.delProv.Name = "delProv";
            this.delProv.Size = new System.Drawing.Size(165, 30);
            this.delProv.TabIndex = 1;
            this.delProv.Text = "Удалить поставщика";
            this.delProv.UseVisualStyleBackColor = true;
            this.delProv.Click += new System.EventHandler(this.delProv_Click);
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.employeeMessage);
            this.tabEmployee.Controls.Add(this.delEmp);
            this.tabEmployee.Controls.Add(this.searchStatus);
            this.tabEmployee.Controls.Add(this.label3);
            this.tabEmployee.Controls.Add(this.gridEmployee);
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(795, 392);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "Сотрудники";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // employeeMessage
            // 
            this.employeeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeMessage.Location = new System.Drawing.Point(554, 106);
            this.employeeMessage.Name = "employeeMessage";
            this.employeeMessage.Size = new System.Drawing.Size(225, 132);
            this.employeeMessage.TabIndex = 4;
            this.employeeMessage.Text = "Введите наименование должности";
            // 
            // delEmp
            // 
            this.delEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delEmp.Location = new System.Drawing.Point(554, 334);
            this.delEmp.Name = "delEmp";
            this.delEmp.Size = new System.Drawing.Size(161, 38);
            this.delEmp.TabIndex = 3;
            this.delEmp.Text = "Удалить сотрудника";
            this.delEmp.UseVisualStyleBackColor = true;
            this.delEmp.Click += new System.EventHandler(this.delEmp_Click);
            // 
            // searchStatus
            // 
            this.searchStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchStatus.Location = new System.Drawing.Point(554, 38);
            this.searchStatus.Name = "searchStatus";
            this.searchStatus.Size = new System.Drawing.Size(177, 23);
            this.searchStatus.TabIndex = 2;
            this.searchStatus.TextChanged += new System.EventHandler(this.searchStatus_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(550, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Фильтр по должности";
            // 
            // gridEmployee
            // 
            this.gridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEmployee.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployee.Location = new System.Drawing.Point(16, 15);
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.Size = new System.Drawing.Size(523, 357);
            this.gridEmployee.TabIndex = 0;
            this.gridEmployee.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.baseDataSet;
            // 
            // tabItems
            // 
            this.tabItems.Controls.Add(this.reportW);
            this.tabItems.Controls.Add(this.reportEx);
            this.tabItems.Controls.Add(this.groupBox1);
            this.tabItems.Controls.Add(this.delItem);
            this.tabItems.Controls.Add(this.gridItems);
            this.tabItems.Location = new System.Drawing.Point(4, 22);
            this.tabItems.Name = "tabItems";
            this.tabItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabItems.Size = new System.Drawing.Size(795, 392);
            this.tabItems.TabIndex = 1;
            this.tabItems.Text = "Товары";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // reportW
            // 
            this.reportW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportW.Location = new System.Drawing.Point(159, 329);
            this.reportW.Name = "reportW";
            this.reportW.Size = new System.Drawing.Size(136, 48);
            this.reportW.TabIndex = 6;
            this.reportW.Text = "Отчет Word";
            this.reportW.UseVisualStyleBackColor = true;
            this.reportW.Click += new System.EventHandler(this.reportW_Click);
            // 
            // reportEx
            // 
            this.reportEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportEx.Location = new System.Drawing.Point(17, 329);
            this.reportEx.Name = "reportEx";
            this.reportEx.Size = new System.Drawing.Size(136, 48);
            this.reportEx.TabIndex = 6;
            this.reportEx.Text = "Отчет Excel";
            this.reportEx.UseVisualStyleBackColor = true;
            this.reportEx.Click += new System.EventHandler(this.reportEx_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.searchItem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.searchItemName);
            this.groupBox1.Controls.Add(this.costMax);
            this.groupBox1.Controls.Add(this.costMin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(318, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск товара по параметрам";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "до";
            // 
            // searchItem
            // 
            this.searchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchItem.Location = new System.Drawing.Point(289, 28);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(144, 49);
            this.searchItem.TabIndex = 2;
            this.searchItem.Text = "Найти товар";
            this.searchItem.UseVisualStyleBackColor = true;
            this.searchItem.Click += new System.EventHandler(this.searchItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "цена от";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "наименование";
            // 
            // searchItemName
            // 
            this.searchItemName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchItemName.Location = new System.Drawing.Point(119, 25);
            this.searchItemName.Name = "searchItemName";
            this.searchItemName.Size = new System.Drawing.Size(142, 23);
            this.searchItemName.TabIndex = 3;
            // 
            // costMax
            // 
            this.costMax.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.costMax.Location = new System.Drawing.Point(212, 57);
            this.costMax.Name = "costMax";
            this.costMax.Size = new System.Drawing.Size(49, 23);
            this.costMax.TabIndex = 3;
            this.costMax.Text = "1000";
            // 
            // costMin
            // 
            this.costMin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.costMin.Location = new System.Drawing.Point(131, 57);
            this.costMin.Name = "costMin";
            this.costMin.Size = new System.Drawing.Size(45, 23);
            this.costMin.TabIndex = 3;
            this.costMin.Text = "1";
            // 
            // delItem
            // 
            this.delItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delItem.Location = new System.Drawing.Point(17, 289);
            this.delItem.Name = "delItem";
            this.delItem.Size = new System.Drawing.Size(278, 34);
            this.delItem.TabIndex = 1;
            this.delItem.Text = "Удалить товар";
            this.delItem.UseVisualStyleBackColor = true;
            this.delItem.Click += new System.EventHandler(this.delItem_Click);
            // 
            // gridItems
            // 
            this.gridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridItems.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItems.Location = new System.Drawing.Point(17, 18);
            this.gridItems.Name = "gridItems";
            this.gridItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItems.Size = new System.Drawing.Size(757, 256);
            this.gridItems.TabIndex = 0;
            this.gridItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabItems);
            this.tabControl1.Controls.Add(this.tabEmployee);
            this.tabControl1.Controls.Add(this.tabProvide);
            this.tabControl1.Controls.Add(this.tabStorage);
            this.tabControl1.Controls.Add(this.tabPosition);
            this.tabControl1.Controls.Add(this.tabDop);
            this.tabControl1.Location = new System.Drawing.Point(3, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 418);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Deselected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Deselected);
            // 
            // tabStorage
            // 
            this.tabStorage.Controls.Add(this.groupBox2);
            this.tabStorage.Controls.Add(this.DelStorage);
            this.tabStorage.Controls.Add(this.gridStorage);
            this.tabStorage.Location = new System.Drawing.Point(4, 22);
            this.tabStorage.Name = "tabStorage";
            this.tabStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tabStorage.Size = new System.Drawing.Size(795, 392);
            this.tabStorage.TabIndex = 5;
            this.tabStorage.Text = "Склады";
            this.tabStorage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.SaveInStorageButton);
            this.groupBox2.Controls.Add(this.numericUpDown);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxItemName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(31, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить товар на склад";
            // 
            // SaveInStorageButton
            // 
            this.SaveInStorageButton.Location = new System.Drawing.Point(542, 106);
            this.SaveInStorageButton.Name = "SaveInStorageButton";
            this.SaveInStorageButton.Size = new System.Drawing.Size(182, 47);
            this.SaveInStorageButton.TabIndex = 5;
            this.SaveInStorageButton.Text = "Сохранить";
            this.SaveInStorageButton.UseVisualStyleBackColor = true;
            this.SaveInStorageButton.Click += new System.EventHandler(this.SaveInStorageButton_Click);
            this.SaveInStorageButton.Leave += new System.EventHandler(this.ClearLabelStatus);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(579, 52);
            this.numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.ReadOnly = true;
            this.numericUpDown.Size = new System.Drawing.Size(89, 27);
            this.numericUpDown.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(576, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Наименование товара";
            // 
            // comboBoxItemName
            // 
            this.comboBoxItemName.FormattingEnabled = true;
            this.comboBoxItemName.Location = new System.Drawing.Point(9, 52);
            this.comboBoxItemName.Name = "comboBoxItemName";
            this.comboBoxItemName.Size = new System.Drawing.Size(456, 28);
            this.comboBoxItemName.TabIndex = 1;
            // 
            // DelStorage
            // 
            this.DelStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelStorage.Location = new System.Drawing.Point(610, 157);
            this.DelStorage.Name = "DelStorage";
            this.DelStorage.Size = new System.Drawing.Size(169, 38);
            this.DelStorage.TabIndex = 1;
            this.DelStorage.Text = "Удалить склад";
            this.DelStorage.UseVisualStyleBackColor = true;
            this.DelStorage.Click += new System.EventHandler(this.DelStorage_Click);
            // 
            // gridStorage
            // 
            this.gridStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStorage.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStorage.Location = new System.Drawing.Point(31, 22);
            this.gridStorage.Name = "gridStorage";
            this.gridStorage.Size = new System.Drawing.Size(568, 173);
            this.gridStorage.TabIndex = 0;
            // 
            // tabPosition
            // 
            this.tabPosition.Controls.Add(this.delPositionButton);
            this.tabPosition.Controls.Add(this.gridPosition);
            this.tabPosition.Location = new System.Drawing.Point(4, 22);
            this.tabPosition.Name = "tabPosition";
            this.tabPosition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPosition.Size = new System.Drawing.Size(795, 392);
            this.tabPosition.TabIndex = 6;
            this.tabPosition.Text = "Должности";
            this.tabPosition.UseVisualStyleBackColor = true;
            // 
            // delPositionButton
            // 
            this.delPositionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delPositionButton.Location = new System.Drawing.Point(551, 315);
            this.delPositionButton.Name = "delPositionButton";
            this.delPositionButton.Size = new System.Drawing.Size(205, 52);
            this.delPositionButton.TabIndex = 1;
            this.delPositionButton.Text = "Удалить должность";
            this.delPositionButton.UseVisualStyleBackColor = true;
            this.delPositionButton.Click += new System.EventHandler(this.delPositionButton_Click);
            // 
            // gridPosition
            // 
            this.gridPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPosition.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPosition.Location = new System.Drawing.Point(30, 24);
            this.gridPosition.Name = "gridPosition";
            this.gridPosition.Size = new System.Drawing.Size(484, 343);
            this.gridPosition.TabIndex = 0;
            // 
            // типTableAdapter
            // 
            this.типTableAdapter.ClearBeforeFill = true;
            // 
            // категорияTableAdapter
            // 
            this.категорияTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(692, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(89, 30);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "обновить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.UploadInfo);
            this.buttonUpdate.Leave += new System.EventHandler(this.ClearLabelStatus);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(507, 12);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(78, 17);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "labelStatus";
            // 
            // mainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 451);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainAdmin";
            this.Text = "mainAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainAdmin_FormClosing);
            this.Load += new System.EventHandler(this.mainAdmin_Load);
            this.tabDop.ResumeLayout(false);
            this.tabDop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типBindingSource)).EndInit();
            this.tabProvide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProviders)).EndInit();
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.tabItems.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabStorage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStorage)).EndInit();
            this.tabPosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BaseDataSet baseDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource типBindingSource;
        private BaseDataSetTableAdapters.ТипTableAdapter типTableAdapter;
        private System.Windows.Forms.BindingSource категорияBindingSource;
        private BaseDataSetTableAdapters.КатегорияTableAdapter категорияTableAdapter;
        private System.Windows.Forms.TabPage tabDop;
        private System.Windows.Forms.Button delType;
        private System.Windows.Forms.Button delClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView gridType;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabProvide;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.DataGridView gridEmployee;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.Button delItem;
        private System.Windows.Forms.DataGridView gridItems;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label3;
        private Button delProv;
        private GroupBox groupBox1;
        private TextBox searchItemName;
        private TextBox searchStatus;
        private TextBox costMin;
        private Label label4;
        private Label label7;
        private Label label5;
        private Button searchItem;
        private TextBox costMax;
        private Button delEmp;
        private Button reportEx;
        private Button reportW;
        private DataGridView gridProviders;
        private BindingSource сотрудникиBindingSource;
        private BaseDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private Label employeeMessage;
        private Button buttonUpdate;
        private Label labelStatus;
        private TabPage tabStorage;
        private DataGridView gridStorage;
        private Button DelStorage;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown;
        private Label label9;
        private Label label6;
        private ComboBox comboBoxItemName;
        private Button SaveInStorageButton;
        private TabPage tabPosition;
        private DataGridView gridPosition;
        private Button delPositionButton;
    }
}