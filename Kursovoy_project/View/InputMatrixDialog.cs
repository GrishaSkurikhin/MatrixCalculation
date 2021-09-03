using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoy_project.View
{
    public partial class InputMatrixDialog : Form
    {
        public InputMatrixDialog()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rows = 0;
            Int32.TryParse(textBox1.Text, out rows);
            if (rows > 15 || rows < 1)
            {
                MessageBox.Show("Кол-во строк должно быть в промежутке от 1 до 15", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rows = 1;
                textBox1.Text = "1";
            }
            else
            {
                dataGridView1.RowCount = rows;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                        dataGridView1[i, j].Value = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            columns = 0;
            Int32.TryParse(textBox2.Text, out columns);
            if (columns > 15 || columns < 1)
            {
                MessageBox.Show("Кол-во столбцов должно быть в промежутке от 1 до 15", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                columns = 1;
                textBox2.Text = "1";
            }
            else
            {
                dataGridView1.ColumnCount = columns;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                        dataGridView1[i, j].Value = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool larger = false;
            bool IsNotNum = false;

            if (columns < 1 || rows < 1 || columns > 15 || rows > 15)
            {
                MessageBox.Show("Кол-во столбцов и строк не должно быть в диапазоне от 1 до 15", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double[,] table = new double[rows, columns];

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < columns; j++)
                    {
                        try
                        {
                            if (Convert.ToDouble(dataGridView1[j, i].Value) > 9999)
                            {
                                larger = true;
                                break;
                            }
                            table[i, j] = Convert.ToDouble(dataGridView1[j, i].Value);
                        }
                        catch (Exception) { IsNotNum = true; }

                    }

                if (larger)
                {
                    MessageBox.Show("Число в матрице не должно превышать 9999", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (IsNotNum)
                {
                    MessageBox.Show("Все значения в матрице должны быть числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MainWindow main = this.Owner as MainWindow;
                    DataMatrix mat = new DataMatrix(table);

                    main.panel.Controls.Add(mat);

                    this.Close();
                }
            }
        }
        public int rows, columns;
    }
}
