using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoy_project
{
    public class Controller
    {
        private View.MainWindow view;

        public Form CreateView()
        {
            view = new View.MainWindow();
            view.Show();
            return view;
        }

        public double[,] sum(double[,] table1, double[,] table2)
        {
            return Model.MatrixOperations.sum(table1, table2);
        }

        public double[,] sub(double[,] table1, double[,] table2)
        {
            return Model.MatrixOperations.sub(table1, table2);
        }

        public double[,] mult(double[,] table1, double[,] table2)
        {
            return Model.MatrixOperations.mult(table1, table2);
        }

        public double[,] transpose(double[,] table)
        {
            return Model.MatrixOperations.transpose(table);
        }

        public double[,] multNum(double[,] table, double k)
        {
            return Model.MatrixOperations.multNum(table, k);
        }

        public double[,] pow(double[,] table, int k)
        {
            return Model.MatrixOperations.pow(table, k);
        }

        public double det(double[,] table)
        {
            return Model.MatrixOperations.det(table);
        }

        public double[,,] lu(double[,] table)
        {
            return Model.MatrixOperations.lu(table);
        }

        public double[,] inverse(double[,] table)
        {
            return Model.MatrixOperations.inverse(table);
        }

        public int rang(double[,] table)
        {
            return Model.MatrixOperations.rang(table);
        }

        public double[] solveCramer(double[,] table, double[] b)
        {
            return Model.MatrixOperations.solveCramer(table, b);
        }
    }
}

