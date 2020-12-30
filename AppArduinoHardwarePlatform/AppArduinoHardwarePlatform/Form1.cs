using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppArduinoHardwarePlatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arduinohardwareplatformDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.arduinohardwareplatformDataSet.Project);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arduinohardwareplatformDataSet.ArduinoBoard". При необходимости она может быть перемещена или удалена.
            this.arduinoBoardTableAdapter.Fill(this.arduinohardwareplatformDataSet.ArduinoBoard);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arduinohardwareplatformDataSet.InputsOutputs". При необходимости она может быть перемещена или удалена.
            this.inputsOutputsTableAdapter.Fill(this.arduinohardwareplatformDataSet.InputsOutputs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arduinohardwareplatformDataSet.Interfaces". При необходимости она может быть перемещена или удалена.
            this.interfacesTableAdapter.Fill(this.arduinohardwareplatformDataSet.Interfaces);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arduinohardwareplatformDataSet.Memory". При необходимости она может быть перемещена или удалена.
            this.memoryTableAdapter.Fill(this.arduinohardwareplatformDataSet.Memory);

        }
    }
}
