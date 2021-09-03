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
    public partial class LUPanel : UserControl
    {
        public LUPanel()
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
                try
                {
                    if (panel2.Controls.Count != 0)
                        panel2.Controls.Clear();

                    if (panel3.Controls.Count != 0)
                        panel3.Controls.Clear();

                    DataMatrix mat = (DataMatrix)panel1.Controls[0];

                    double[,,] ans = new double[mat.table.GetLength(0), mat.table.GetLength(1), 2];
                    double[,] L = new double[mat.table.GetLength(0), mat.table.GetLength(1)];
                    double[,] U = new double[mat.table.GetLength(0), mat.table.GetLength(1)];

                    if (Parent is MainWindow)
                    {
                        ans = ((MainWindow)Parent).controller.lu(mat.table);

                        for (int i = 0; i < mat.table.GetLength(0); i++)
                        {
                            for (int j = 0; j < mat.table.GetLength(1); j++)
                            {
                                L[i, j] = ans[i, j, 0];
                                U[i, j] = ans[i, j, 1];
                            }
                        }

                        DataMatrix mat2 = new DataMatrix(L);
                        Size s = new Size(mat.Size.Width, mat.Size.Height);
                        mat2.Size = s;
                        int x = panel2.Width / 2 - mat2.Width / 2;
                        int y = panel2.Height / 2 - mat2.Height / 2;
                        mat2.Location = new Point(x, y);
                        panel2.Controls.Add(mat2);

                        DataMatrix mat3 = new DataMatrix(U);
                        mat3.Size = s;
                        mat3.Location = new Point(x, y);
                        panel3.Controls.Add(mat3);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
