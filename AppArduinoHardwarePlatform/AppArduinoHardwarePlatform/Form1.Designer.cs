namespace AppArduinoHardwarePlatform
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arduinohardwareplatformDataSet = new AppArduinoHardwarePlatform.arduinohardwareplatformDataSet();
            this.memoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memoryTableAdapter = new AppArduinoHardwarePlatform.arduinohardwareplatformDataSetTableAdapters.MemoryTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.interfacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interfacesTableAdapter = new AppArduinoHardwarePlatform.arduinohardwareplatformDataSetTableAdapters.InterfacesTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.inputsOutputsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputsOutputsTableAdapter = new AppArduinoHardwarePlatform.arduinohardwareplatformDataSetTableAdapters.InputsOutputsTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.arduinoBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arduinoBoardTableAdapter = new AppArduinoHardwarePlatform.arduinohardwareplatformDataSetTableAdapters.ArduinoBoardTableAdapter();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new AppArduinoHardwarePlatform.arduinohardwareplatformDataSetTableAdapters.ProjectTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardSizeMMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerSupplyVoltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arduinohardwareplatformDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputsOutputsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arduinoBoardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // arduinohardwareplatformDataSet
            // 
            this.arduinohardwareplatformDataSet.DataSetName = "arduinohardwareplatformDataSet";
            this.arduinohardwareplatformDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memoryBindingSource
            // 
            this.memoryBindingSource.DataMember = "Memory";
            this.memoryBindingSource.DataSource = this.arduinohardwareplatformDataSet;
            // 
            // memoryTableAdapter
            // 
            this.memoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.fullNameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.interfacesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 186);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(360, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // interfacesBindingSource
            // 
            this.interfacesBindingSource.DataMember = "Interfaces";
            this.interfacesBindingSource.DataSource = this.arduinohardwareplatformDataSet;
            // 
            // interfacesTableAdapter
            // 
            this.interfacesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.fullNameDataGridViewTextBoxColumn2,
            this.descriptionDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.inputsOutputsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 366);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(360, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // inputsOutputsBindingSource
            // 
            this.inputsOutputsBindingSource.DataMember = "InputsOutputs";
            this.inputsOutputsBindingSource.DataSource = this.arduinohardwareplatformDataSet;
            // 
            // inputsOutputsTableAdapter
            // 
            this.inputsOutputsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boardNameDataGridViewTextBoxColumn,
            this.boardSizeMMDataGridViewTextBoxColumn,
            this.powerSupplyVoltageDataGridViewTextBoxColumn,
            this.processorNameDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.arduinoBoardBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(504, 186);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(463, 150);
            this.dataGridView4.TabIndex = 3;
            // 
            // arduinoBoardBindingSource
            // 
            this.arduinoBoardBindingSource.DataMember = "ArduinoBoard";
            this.arduinoBoardBindingSource.DataSource = this.arduinohardwareplatformDataSet;
            // 
            // arduinoBoardTableAdapter
            // 
            this.arduinoBoardTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn3,
            this.photoDataGridViewTextBoxColumn,
            this.settingsDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.projectBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(504, 12);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(359, 150);
            this.dataGridView5.TabIndex = 4;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.arduinohardwareplatformDataSet;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            this.fullNameDataGridViewTextBoxColumn1.DataPropertyName = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn1.HeaderText = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // fullNameDataGridViewTextBoxColumn2
            // 
            this.fullNameDataGridViewTextBoxColumn2.DataPropertyName = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn2.HeaderText = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn2.Name = "fullNameDataGridViewTextBoxColumn2";
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // settingsDataGridViewTextBoxColumn
            // 
            this.settingsDataGridViewTextBoxColumn.DataPropertyName = "Settings";
            this.settingsDataGridViewTextBoxColumn.HeaderText = "Settings";
            this.settingsDataGridViewTextBoxColumn.Name = "settingsDataGridViewTextBoxColumn";
            // 
            // boardNameDataGridViewTextBoxColumn
            // 
            this.boardNameDataGridViewTextBoxColumn.DataPropertyName = "BoardName";
            this.boardNameDataGridViewTextBoxColumn.HeaderText = "BoardName";
            this.boardNameDataGridViewTextBoxColumn.Name = "boardNameDataGridViewTextBoxColumn";
            // 
            // boardSizeMMDataGridViewTextBoxColumn
            // 
            this.boardSizeMMDataGridViewTextBoxColumn.DataPropertyName = "BoardSizeMM";
            this.boardSizeMMDataGridViewTextBoxColumn.HeaderText = "BoardSizeMM";
            this.boardSizeMMDataGridViewTextBoxColumn.Name = "boardSizeMMDataGridViewTextBoxColumn";
            // 
            // powerSupplyVoltageDataGridViewTextBoxColumn
            // 
            this.powerSupplyVoltageDataGridViewTextBoxColumn.DataPropertyName = "PowerSupplyVoltage";
            this.powerSupplyVoltageDataGridViewTextBoxColumn.HeaderText = "PowerSupplyVoltage";
            this.powerSupplyVoltageDataGridViewTextBoxColumn.Name = "powerSupplyVoltageDataGridViewTextBoxColumn";
            // 
            // processorNameDataGridViewTextBoxColumn
            // 
            this.processorNameDataGridViewTextBoxColumn.DataPropertyName = "Processor_Name";
            this.processorNameDataGridViewTextBoxColumn.HeaderText = "Processor_Name";
            this.processorNameDataGridViewTextBoxColumn.Name = "processorNameDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1463, 560);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "AppArduinoHardwarePlatform";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arduinohardwareplatformDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputsOutputsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arduinoBoardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private arduinohardwareplatformDataSet arduinohardwareplatformDataSet;
        private System.Windows.Forms.BindingSource memoryBindingSource;
        private arduinohardwareplatformDataSetTableAdapters.MemoryTableAdapter memoryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource interfacesBindingSource;
        private arduinohardwareplatformDataSetTableAdapters.InterfacesTableAdapter interfacesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource inputsOutputsBindingSource;
        private arduinohardwareplatformDataSetTableAdapters.InputsOutputsTableAdapter inputsOutputsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource arduinoBoardBindingSource;
        private arduinohardwareplatformDataSetTableAdapters.ArduinoBoardTableAdapter arduinoBoardTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private arduinohardwareplatformDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardSizeMMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerSupplyVoltageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn settingsDataGridViewTextBoxColumn;
    }
}

