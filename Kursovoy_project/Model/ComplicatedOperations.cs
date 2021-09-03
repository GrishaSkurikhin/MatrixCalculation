using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_project.Model
{
    internal class ComplicatedOperations
    {
        internal double det(double[,] table)
        {
            if (table.GetLength(0) != table.GetLength(1))
            {
                throw new Exception("Матрица должна быть квадратной");
            }

            int n = (int)Math.Sqrt(table.Length);

            if (n == 1)
            {
                return table[0, 0];
            }

            double det = 0;

            for (int k = 0; k < n; k++)
            {
                det += table[0, k] * Cofactor(table, 0, k);
            }

            return det;
        }

        private double Cofactor(double[,] table, int row, int column)
        {
            return Convert.ToDouble(Math.Pow(-1, column + row)) * det(Minor(table, row, column));
        }

        private double[,] Minor(double[,] array, int row, int column)
        {
            int n = (int)Math.Sqrt(array.Length);
            double[,] minor = new double[n - 1, n - 1];

            int _i = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == row)
                {
                    continue;
                }
                int _j = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == column)
                    {
                        continue;
                    }
                    minor[_i, _j] = array[i, j];
                    _j++;
                }
                _i++;
            }
            return minor;
        }

        private double[,] transpose(double[,] table)
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

        internal double[,] inverse(double[,] table)
        {
            int size = table.GetLength(0);
            double d = det(table);
            if (d == 0)
            {
                throw new Exception("Матрица вырождена");
            }

            double[,] ans = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    ans[i, j] = Cofactor(table, i, j) / d;
                }
            }

            return transpose(ans);
        }

        internal double[,,] lu(double[,] table)
        {
            if (table.GetLength(0) != table.GetLength(1))
            {
                throw new Exception("Матрица должна быть квадратной");
            }

            int size = table.GetLength(0);
            double[,,] ans = new double[size, size, 2];

            for (int i = 0; i < size; i++)
            {
                for (int k = i; k < size; k++)
                {
                    double sum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sum += ans[i, j, 0] * ans[j, k, 1];
                    }
                    ans[i, k, 1] = table[i, k] - sum;
                }

                for (int k = i; k < size; k++)
                {
                    if (i == k)
                        ans[i, i, 0] = 1;
                    else
                    {
                        double sum = 0;
                        for (int j = 0; j < i; j++)
                        {
                            sum += ans[k, j, 0] * ans[j, i, 1];
                        }
                        ans[k, i, 0] = (table[k, i] - sum) / ans[i, i, 1];
                    }
                }
            }
            return ans;
        }

        internal int rang(double[,] table)
        {
            int ColumnCount = table.GetLength(0);
            int RowCount = table.GetLength(1);
            int min = Math.Min(ColumnCount, RowCount);
            if ((min == 0) || (ColumnCount == 1 && RowCount == 1 && table[ColumnCount-1, RowCount-1] == 0)) return 0;
            int r = 0;
            bool bl;
            while (r < min)
            {
                r++;
                bl = false;
                for (int k1 = 0; k1 < min - r; k1++)
                {
                    for (int k2 = 0; k2 < min - r; k2++)
                    {
                        double[,] minor = new double[r, r];
                        for (int i = 0; i < minor.GetLength(0); i++)
                        {
                            for (int j = 0; j < minor.GetLength(1); j++)
                            {
                                minor[i, j] = table[i + k1, j + k2];
                            }
                        }
                        if (det(minor) != 0)
                        {
                            bl = true;
                            break;
                        }
                    }
                    if (bl) break;
                }
                if (bl) continue;
            }
            return r;
        }

        private double[,] changeColumn(double[,] table, double[] column, int k)
        {
            int size = table.GetLength(0);
            double[,] ans = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    ans[i, j] = table[i, j];
                }

            }
            for (int i = 0; i < size; i++)
            {
                ans[i, k] = column[i];
            }
            return ans;
        }

        internal double[] solveCramer(double[,] table, double[] b)
        {
            if (table.GetLength(0) != table.GetLength(1))
            {
                throw new ArgumentException("Для решения методом Крамера кол-во уравнений должно быть равно числу неизвестных.");
            }
            int size = table.GetLength(0);
            double[] x = new double[size];
            double d = det(table);
            if (d == 0)
            {
                throw new Exception("Определитель равен 0. Решение методом Крамера невозможно.");
            }
            for (int i = 0; i < size; i++)
            {
                x[i] = det(changeColumn(table, b, i)) / d;
            }
            return x;
        }
    }
}
