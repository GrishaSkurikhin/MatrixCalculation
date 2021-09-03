using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoy_project.View
{
    public partial class UnitMatrixForm : Form
    {
        public UnitMatrixForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                k = Convert.ToInt32(textBox1.Text);
                if(k > 15 || k < 1)
                {
                    MessageBox.Show("Размеры матрицы должны быть в диапазоне от 1 до 15", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double[,] t = new double[k, k];
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            if (i == j)
                            {
                                t[i, j] = 1;
                            }
                            else
                            {
                                t[i, j] = 0;
                            }
                        }
                    }
                    MainWindow main = this.Owner as MainWindow;
                    DataMatrix mat = new DataMatrix(t);

                    main.panel.Controls.Add(mat);
                    this.Close();
                }
            }
            catch (Exception) { MessageBox.Show("Должно быть введено число типа int", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        int k;
    }
}
