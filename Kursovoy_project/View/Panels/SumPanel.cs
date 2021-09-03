﻿using System;
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
    public partial class SumPanel : UserControl
    {
        public SumPanel()
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
            if (panel2.Controls.Count != 0)
                panel2.Controls.Clear();

            DataMatrix m = ((DataMatrix)e.Data.GetData(typeof(DataMatrix)));
            panel2.Controls.Add(m);
            int x = panel2.Width / 2 - m.Width / 2;
            int y = panel2.Height / 2 - m.Height / 2;
            m.Location = new Point(x, y);
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
                DataMatrix mat1 = (DataMatrix)panel1.Controls[0];
                DataMatrix mat2 = (DataMatrix)panel2.Controls[0];
                int size = mat1.table.GetLength(0);
                double[,] ans = new double[size, size];
                try
                {
                    if (Parent is MainWindow)
                    {
                        ans = ((MainWindow)Parent).controller.sum(mat1.table, mat2.table);

                        if (panel3.Controls.Count != 0)
                            panel3.Controls.Clear();

                        DataMatrix mat3 = new DataMatrix(ans);
                        mat3.Size = mat1.Size;
                        int x = panel3.Width / 2 - mat3.Width / 2;
                        int y = panel3.Height / 2 - mat3.Height / 2;
                        mat3.Location = new Point(x, y);
                        panel3.Controls.Add(mat3);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
