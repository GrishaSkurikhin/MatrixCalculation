using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Kursovoy_project.View
{
    public partial class DataMatrix : DataGridView
    {
        public DataMatrix()
        {
            InitializeComponent();
        }

        public DataMatrix(double[,] table)
        {
            InitializeComponent();

            //Заполнение матрицы значениями из входного массива
            if (table.GetLength(0) > 7 && table.GetLength(1) > 7) //случай, когда много строк и столбцов
            {
                ColumnCount = 7;
                RowCount = 7;

                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        this[j, i].Value = Math.Round(table[i, j], 2);

                for (int i = RowCount - 3; i < RowCount; i++)
                    for (int j = ColumnCount - 3; j < ColumnCount; j++)
                        this[ColumnCount - j + 3, RowCount - i + 3].Value = Math.Round(table[i, j], 2);

                for (int i = 0; i < 3; i++)
                    for (int j = ColumnCount - 3; j < ColumnCount; j++)
                        this[ColumnCount - j + 3, i].Value = Math.Round(table[i, j], 2);

                for (int i = RowCount - 3; i < RowCount; i++)
                    for (int j = 0; j < 3; j++)
                        this[j, RowCount - i + 3].Value = Math.Round(table[i, j], 2);

                for (int i = 0; i < RowCount; i++)
                    this[3, i].Value = "...";

                for (int j = 0; j < ColumnCount; j++)
                    this[j, 3].Value = "...";
            }
            else if (table.GetLength(1) > 7) //случай, когда много столбцов
            {
                ColumnCount = 7;
                RowCount = table.GetLength(0);

                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < ColumnCount; j++)
                        this[j, i].Value = Math.Round(table[i, j], 2);

                for (int j = 0; j < ColumnCount; j++)
                    this[j, 3].Value = "...";

                for (int i = RowCount - 3; i < RowCount; i++)
                    for (int j = 0; j < ColumnCount; j++)
                        this[j, RowCount - i + 3].Value = Math.Round(table[i, j], 2);
            }
            else if (table.GetLength(0) > 7) //случай, когда много строк
            {
                ColumnCount = table.GetLength(1);
                RowCount = 7;

                for (int i = 0; i < RowCount; i++)
                    for (int j = 0; j < 3; j++)
                        this[j, i].Value = Math.Round(table[i, j], 2);

                for (int i = 0; i < RowCount; i++)
                    this[3, i].Value = "...";

                for (int i = 0; i < RowCount; i++)
                    for (int j = ColumnCount - 3; j < ColumnCount; j++)
                        this[ColumnCount - j + 3, i].Value = Math.Round(table[i, j], 2);
            }
            else
            {
                RowCount = table.GetLength(0);
                ColumnCount = table.GetLength(1);
                for (int i = 0; i < RowCount; i++)
                    for (int j = 0; j < ColumnCount; j++)
                        this[j, i].Value = Math.Round(table[i, j], 2);
            }

            int c = Rows[0].Height;
            Size = new Size(Size.Width, Size.Height - (5 - RowCount)*c - ColumnHeadersHeight - HorizontalScrollBar.Height + 6);

            Table = table;
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            // 1) Изменение значений атрибутов DataGridView
            ColumnHeadersVisible = false;
            RowHeadersVisible = false;
            BackgroundColor = Color.White;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DefaultCellStyle.SelectionForeColor = Color.Black;
            DefaultCellStyle.SelectionBackColor = Color.White;
            DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            BorderStyle = BorderStyle.None;

            // 2) Выравнивание размеров матрицы под размеры столбцов и строк

            int width = 0;
            int height = 0;

            foreach (DataGridViewRow row in Rows)
                height += row.Height;

            foreach (DataGridViewColumn column in Columns)
                width += column.Width;

            Size = new Size(width + 2, height + 18);

            // 3) Вызов метода OnPaint базового класса для прорисовки элемента управления
            base.OnPaint(e);


            // 4) Рисование границ
            Pen pen = new Pen(Color.Black, 2);
            e.Graphics.DrawLine(pen, 1, 0, 1, this.Height - 16);
            e.Graphics.DrawLine(pen, this.Width - 1, 0, this.Width - 1, this.Height - 16);
            e.Graphics.DrawLine(pen, 1, 1, this.Width / 5, 1);
            e.Graphics.DrawLine(pen, this.Width - this.Width / 5, 1, this.Width, 1);
            e.Graphics.DrawLine(pen, 1, this.Height - 17, this.Width / 5, this.Height - 17);
            e.Graphics.DrawLine(pen, this.Width - this.Width / 5, this.Height - 17, this.Width, this.Height - 17);

            // 5) Рисование размеров матрицы
            string size = Convert.ToString(Table.GetLength(0)) + "x" + Convert.ToString(Table.GetLength(1));
            TextRenderer.DrawText(e.Graphics, size, this.Font, new Point(this.Width / 2 - size.Length * Convert.ToInt32(this.Font.Size) / 2, this.Height - 17), SystemColors.ControlText);

        }

        private void DataMatrix_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Просмотреть"));
                m.MenuItems.Add(new MenuItem("Удалить"));
                m.MenuItems[0].Click += new EventHandler(Look);
                m.MenuItems[1].Click += new EventHandler(Delete);

                m.Show(this, new Point(e.X, e.Y));
            }
            else
            {
                DataMatrix copy = new DataMatrix(Table);
                copy.Size = Size;
                DoDragDrop(copy, DragDropEffects.Copy);
            }

        }

        private void Look(object sender, EventArgs e)
        {
            ShowMatrixDialog showMatrixDialog = new ShowMatrixDialog();
            showMatrixDialog.dataGridView1.ColumnCount = Table.GetLength(1);
            showMatrixDialog.dataGridView1.RowCount = Table.GetLength(0);
            for (int i = 0; i < Table.GetLength(0); i++)
            {
                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    showMatrixDialog.dataGridView1[j, i].Value = Table[i, j];
                }
            }
            if(Table.GetLength(0) < 7 && Table.GetLength(1) < 7)
            {
                showMatrixDialog.MinimumSize = new Size(Size.Width + 15, Size.Height + 25);
                showMatrixDialog.MaximumSize = new Size(Size.Width + 15, Size.Height + 25);
                showMatrixDialog.Size = new Size(Size.Width + 15, Size.Height + 25);
            }
                
            showMatrixDialog.ShowDialog();
        }

        private void Delete(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private double[,] Table;

        public double[,] table
        {
            get { return Table; }
            set { Table = value; }
        }

        //Будем использовать Table вместо this[i, j].Value, 
        //потому что там может храниться строка "..." 
    }
}
