using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kursovoy_project.View
{
    public partial class MainWindow : Form
    {
        internal Controller controller;

        public MainWindow()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void CreateMatrixButton_Click(object sender, EventArgs e)
        {
            InputMatrixDialog inputMatrixDialog = new InputMatrixDialog();
            inputMatrixDialog.Owner = this;
            inputMatrixDialog.ShowDialog();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(Controls.Find("panel2", true)[0]);
            SumPanel sumPanel = new SumPanel();
            sumPanel.Location = new Point(194, 217);
            sumPanel.Name = "panel2";
            Controls.Add(sumPanel);
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(Controls.Find("panel2", true)[0]);
            SubPanel subPanel = new SubPanel();
            subPanel.Location = new Point(194, 217);
            subPanel.Name = "panel2";
            Controls.Add(subPanel);
        }

        private void MultButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(Controls.Find("panel2", true)[0]);
            MultPanel multPanel = new MultPanel();
            multPanel.Location = new Point(194, 217);
            multPanel.Name = "panel2";
            Controls.Add(multPanel);
        }

        private void TransButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(Controls.Find("panel2", true)[0]);
            TransposePanel transposePanel = new TransposePanel();
            transposePanel.Location = new Point(194, 217);
            transposePanel.Name = "panel2";
            Controls.Add(transposePanel);
        }

        private void MultNumButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(Controls.Find("panel2", true)[0]);
            MultNumPanel multNumPanel = new MultNumPanel();
            multNumPanel.Location = new Point(194, 217);
            multNumPanel.Name = "panel2";
            Controls.Add(multNumPanel);
        }

        private void PowButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(Controls.Find("panel2", true)[0]);
            PowPanel powPanel = new PowPanel();
            powPanel.Location = new Point(194, 217);
            powPanel.Name = "panel2";
            Controls.Add(powPanel);
        }

        private void DetButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(Controls.Find("panel2", true)[0]);
            DeterminantPanel detPanel = new DeterminantPanel();
            detPanel.Location = new Point(194, 217);
            detPanel.Name = "panel2";
            Controls.Add(detPanel);
        }

        private void RangButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(Controls.Find("panel2", true)[0]);
            RangPanel rangPanel = new RangPanel();
            rangPanel.Location = new Point(194, 217);
            rangPanel.Name = "panel2";
            Controls.Add(rangPanel);
        }

        private void InverseButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(Controls.Find("panel2", true)[0]);
            InversePanel inversePanel = new InversePanel();
            inversePanel.Location = new Point(194, 217);
            inversePanel.Name = "panel2";
            Controls.Add(inversePanel);
        }

        private void LUButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(Controls.Find("panel2", true)[0]);
            LUPanel luPanel = new LUPanel();
            luPanel.Location = new Point(194, 217);
            luPanel.Name = "panel2";
            Controls.Add(luPanel);
        }

        private void CramerButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(Controls.Find("panel2", true)[0]);
            CramerPanel cramerPanel = new CramerPanel();
            cramerPanel.Location = new Point(194, 217);
            cramerPanel.Name = "panel2";
            Controls.Add(cramerPanel);
        }

        private void UnitMatrixButton_Click(object sender, EventArgs e)
        {
            UnitMatrixForm um = new UnitMatrixForm();
            um.Owner = this;
            um.ShowDialog();
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            DataMatrix m = ((DataMatrix)e.Data.GetData(typeof(DataMatrix)));
            int y = Convert.ToInt32(panel.Height / 2 - m.Height / 2);
            int x = 20;
            if (panel.Controls.Count != 0)
                foreach (Control c in panel.Controls)
                    x += c.Width + 20;
            m.Location = new Point(x, y);
            panel.Controls.Add(m);

        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel_ControlsChanged(object sender, ControlEventArgs e)
        {
            int x = 20;
            foreach (Control control in panel.Controls)
            {
                if (control is DataMatrix)
                {
                    DataMatrix mat = (DataMatrix)control;
                    int y = Convert.ToInt32(panel.Height / 2 - mat.Height / 2);
                    mat.Location = new Point(x, y);
                    x += mat.Width + 20;
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;

            double[,] t;
            int k;

            using (StreamReader sr = new StreamReader(filename))
            {
                panel.Controls.Clear();
                k = int.Parse(sr.ReadLine());
                for(int l = 0; l < k; l++)
                {
                    int n = int.Parse(sr.ReadLine());
                    int m = int.Parse(sr.ReadLine());
                    t = new double[n, m];
                    for (int i = 0; i < n; i++)
                    {
                        string temp = sr.ReadLine();
                        string[] line = temp.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < m; j++)
                        {
                            t[i, j] = double.Parse(line[j]);
                        }
                    }
                    DataMatrix dataMatrix = new DataMatrix(t);
                    panel.Controls.Add(dataMatrix);
                }
            }
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            int k = panel.Controls.Count;

            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                sw.WriteLine(k);
                foreach (DataMatrix m in panel.Controls)
                {
                    double[,] t = m.table;

                    sw.WriteLine(t.GetLength(0));
                    sw.WriteLine(t.GetLength(1));
                    for (int i = 0; i < t.GetLength(0); i++)
                    {
                        string[] line = new string[t.GetLength(1)];
                        for (int j = 0; j < t.GetLength(1); j++)
                        {
                            line[j] = t[i, j].ToString();
                        }
                        sw.WriteLineAsync(String.Join(" ", line));
                    }
                }
            }
        }

        private void сведенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm i = new InformationForm();
            i.ShowDialog();
        }
    }
}
