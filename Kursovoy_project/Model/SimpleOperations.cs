using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_project.Model
{
    internal class SimpleOperations
    {
        internal double[,] sum(double[,] table1, double[,] table2) // сложение
        {
            if ((table1.GetLength(0) != table2.GetLength(0)) || (table1.GetLength(1) != table2.GetLength(1)))
            {
                throw new Exception("Матрицы должны быть одинаковых размеров");
            }
            int ColumnCount = table1.GetLength(0);
            int RowCount = table1.GetLength(1);
            double[,] ans = new double[ColumnCount, RowCount];
            for (int i = 0; i < ColumnCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    ans[i, j] = table1[i, j] + table2[i, j];
                }
            }
            return ans;
        }

        internal double[,] sub(double[,] table1, double[,] table2) //вычитание
        {
            if ((table1.GetLength(0) != table2.GetLength(0)) || (table1.GetLength(1) != table2.GetLength(1)))
            {
                throw new Exception("Матрицы должны быть одинаковых размеров");
            }
            int ColumnCount = table1.GetLength(0);
            int RowCount = table1.GetLength(1);
            double[,] ans = new double[ColumnCount, RowCount];
            for (int i = 0; i < ColumnCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    ans[i, j] = table1[i, j] - table2[i, j];
                }
            }
            return ans;
        }

        internal double[,] mult(double[,] table1, double[,] table2) //умножение
        {
            if (table1.GetLength(1) != table2.GetLength(0))
            {
                throw new Exception("Матрицы должны быть согласованы");
            }

            double[,] ans = new double[table1.GetLength(0), table2.GetLength(1)];
            for (int i = 0; i < table1.GetLength(0); i++)
            {
                for (int j = 0; j < table2.GetLength(1); j++)
                {
                    for (int k = 0; k < table2.GetLength(0); k++)
                    {
                        ans[i, j] += table1[i, k] * table2[k, j];
                    }
                }
            }
            return ans;
        }

        internal double[,] transpose(double[,] table) //транспонирование
        {
            double[,] ans = new double[table.GetLength(1), table.GetLength(0)];
            for (int j = 0; j < table.GetLength(1); j++)
            {
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    ans[j, i] = table[i, j];
                }
            }
            return ans;
        }

        internal double[,] multNum(double[,] table, double k) //умножение на число
        {
            double[,] ans = new double[table.GetLength(0), table.GetLength(1)];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    ans[i, j] = table[i, j] * k;
                }
            }
            return ans;
        }

        internal double[,] pow(double[,] table, int k) //возведение в степень
        {
            if (table.GetLength(0) != table.GetLength(1))
            {
                throw new Exception("Матрица должна быть квадратной");
            }
            double[,] ans = new double[table.GetLength(0), table.GetLength(1)];
            ans = table;
            for (int i = 1; i < k; i++)
            {
                ans = this.mult(ans, table);
            }
            return ans;
        }
    }
}
