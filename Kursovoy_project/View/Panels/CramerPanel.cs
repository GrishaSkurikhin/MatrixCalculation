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
    public partial class CramerPanel : UserControl
    {
        public CramerPanel()
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

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            DataMatrix m = ((DataMatrix)e.Data.GetData(typeof(DataMatrix)));
            if(m.table.GetLength(1) != 1)
            {
                MessageBox.Show("Матрица b должна быть размеров nx1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (panel2.Controls.Count != 0)
                    panel2.Controls.Clear();

                panel2.Controls.Add(m);
                int x = panel2.Width / 2 - m.Width / 2;
                int y = panel2.Height / 2 - m.Height / 2;
                m.Location = new Point(x, y);
            }
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count != 1 || panel2.Controls.Count != 1)
            {
                MessageBox.Show("Должны быть введены матрицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Parent is MainWindow)
                {

                    //try
                    //{
                    if (panel3.Controls.Count != 0)
                        panel3.Controls.Clear();

                    DataMatrix mat1 = (DataMatrix)panel1.Controls[0];
                    DataMatrix mat2 = (DataMatrix)panel2.Controls[0];
                    double[,] ans = new double[mat2.table.GetLength(0), 1];
                    double[] b = new double[mat2.table.GetLength(0)];
                    double[] X = new double[mat2.table.GetLength(0)];
                    for (int i = 0; i < mat2.table.GetLength(0); i++)
                    {
                        b[i] = mat2.table[i, 0];
                    }

                    X = ((MainWindow)Parent).controller.solveCramer(mat1.table, b);

                    for (int i = 0; i < mat2.table.GetLength(0); i++)
                    {
                        ans[i, 0] = X[i];
                    }
                    DataMatrix mat3 = new DataMatrix(ans);
                    Size s = new Size(mat2.Size.Width, mat2.Size.Height);
                    mat3.Size = s;
                    int x = panel3.Width / 2 - mat3.Width / 2;
                    int y = panel3.Height / 2 - mat3.Height / 2;
                    mat3.Location = new Point(x, y);
                    panel3.Controls.Add(mat3);
                    //}
                    //catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
    }
}
