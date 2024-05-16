using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Calculation()
        {
            ErrorProvider errorProvider = new ErrorProvider();
            SportsSect sportsSect = new SportsSect();

            if (string.IsNullOrEmpty(input_Data.Text))
            {
                errorProvider.SetError(input_Data, "Поле не должно быть пустым");
            }
            else if (int.TryParse(input_Data.Text, out int time2))
            {
                if (time2 <= 0)
                {
                    errorProvider.SetError(input_Data, "Введите положительное число больше нуля");
                }
                else
                {
                    sportsSect.setTime(time2);
                    double Distance = sportsSect.CalculateTime();
                    double Distance2 = sportsSect.CalculateTime2();
                    result_1.Text = $"{Distance}";
                    result_2.Text = $"{Distance2}";
                }
            }
            else
            {
                errorProvider.SetError(input_Data, "Введите целое число");
            }
            //if (string.IsNullOrEmpty() = null)
            //{
            //    errorProvider.Clear();
            //}
            //else 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calculation();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void главноеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void создательToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void оСебеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input_Data.Clear();
            result_1.Clear();
            result_2.Clear();
        }

        private void вычислитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выполнитьРасчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculation();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void inputData(object sender, EventArgs e)
        {

        }

        private void result1(object sender, EventArgs e)
        {

        }

        private void result2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
