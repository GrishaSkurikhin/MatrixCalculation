using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoy_project.View
{
    public partial class MultNumPanel : UserControl
    {
        public MultNumPanel()
        {
            InitializeComponent();
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (panel1.Controls.Count != 0)
                panel1.Controls.Clear();

            DataMatrix m = ((DataMatrix)e.Data.GetData(typeof(DataMatrix)));
            panel1.Controls.Add(m);
            int x = panel1.Width / 2 - m.Width / 2;
            int y = panel1.Height / 2 - m.Height / 2;
            m.Location = new Point(x, y);
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count != 1)
            {
                MessageBox.Show("Должна быть введена матрица", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataMatrix mat1 = (DataMatrix)panel1.Controls[0];
                double[,] ans = new double[mat1.table.GetLength(0), mat1.table.GetLength(1)];
                double k = 0;
                bool IsNum = false;
                try
                {
                    k = Convert.ToDouble(richTextBox1.Text);
                    IsNum = true;
                }
                catch (Exception) { MessageBox.Show("Введите число типа double", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }


                if (IsNum)
                {
                    if (Parent is MainWindow)
                    {
                        if (panel2.Controls.Count != 0)
                            panel2.Controls.Clear();

                        ans = ((MainWindow)Parent).controller.multNum(mat1.table, k);
                        DataMatrix mat2 = new DataMatrix(ans);
                        Size s = new Size(mat1.Size.Width, mat1.Size.Height);
                        mat2.Size = s;
                        int x = panel2.Width / 2 - mat2.Width / 2;
                        int y = panel2.Height / 2 - mat2.Height / 2;
                        mat2.Location = new Point(x, y);
                        panel2.Controls.Add(mat2);
                    }
                }
            }
        }
    }
}

