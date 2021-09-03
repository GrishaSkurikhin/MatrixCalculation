using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_project.Model
{
    static class MatrixOperations
    {
        static SimpleOperations s = new SimpleOperations();
        static ComplicatedOperations c = new ComplicatedOperations();

        public static double[,] sum(double[,] table1, double[,] table2)
        {
            return s.sum(table1, table2);
        }

        public static double[,] sub(double[,] table1, double[,] table2)
        {
            return s.sub(table1, table2);
        }

        public static double[,] mult(double[,] table1, double[,] table2)
        {
            return s.mult(table1, table2);
        }

        public static double[,] transpose(double[,] table)
        {
            return s.transpose(table);
        }

        public static double[,] multNum(double[,] table, double k)
        {
            return s.multNum(table, k);
        }

        public static double[,] pow(double[,] table, int k)
        {
            return s.pow(table, k);
        }

        public static double det(double[,] table)
        {
            return c.det(table);
        }

        public static double[,,] lu(double[,] table)
        {
            return c.lu(table);
        }

        public static double[,] inverse(double[,] table)
        {
            return c.inverse(table);
        }

        public static int rang(double[,] table)
        {
            return c.rang(table);
        }

        public static double[] solveCramer(double[,] table, double[] b)
        {
            return c.solveCramer(table, b);
        }
    }
}
