using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class Form1 : Form
    {
        public int[,] Graph { get; set; } = new[,] { { 0, 7, 9, 0, 0, 14 },
                                                     { 7, 0, 10, 15, 0, 0 },
                                                     { 9, 10, 0, 11, 0, 2 },
                                                     { 0, 15, 11, 0, 6, 0},
                                                     { 0, 0, 0, 6, 0, 9},
                                                     { 14, 0, 2, 0, 9, 0 } };
        public Form1()
        {
            InitializeComponent();
            InitGraphView();
        }

        private void InitGraphView()
        {
            dgGraph.ColumnCount = Graph.GetLength(1);
            dgGraph.RowCount = Graph.GetLength(0);

            for (int i = 0; i < Graph.GetLength(0); ++i)
            {
                for (int j = 0; j < Graph.GetLength(1); ++j)
                {
                    dgGraph.Rows[i].Cells[j].Value = Graph[i, j];
                }
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            Dijkstra solver = new(Graph);
            var path = solver.FindBestRoute(0, 4);

            dgPath.ColumnCount = path.Length;
            dgPath.Rows.Add();
            for (int i = 0; i < path.Length; ++i)
            {
                dgPath.Rows[0].Cells[i].Value = path[i];
            }
        }
    }
}
