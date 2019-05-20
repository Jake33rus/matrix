using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class MyForm : Form
    {
        public const int MATRIX_MIN = 0;
        public const int MATRIX_MAX = 1;
        public const int MATRIX_OPR = 2;
        public const int MATRIX_TRANSP = 3;
        public const int MATRIX_REV = 4;
        public const int MATRIX_SUM = 5;
        public const int MATRIX_MULTI = 6;
        int action;
        int K, R;
        int[][] matrix1;
        int[][] matrix2;
        int[][] matrix3;
        public MyForm()
        {
            InitializeComponent();
        }

        private void минимальныйЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
            K = 3; R = 3;
            label1.Text = "A=";
            action = MATRIX_MIN;
            DataGridViewColumn column;
            dataGridView1.AllowUserToAddRows = false;
            for (int i = 0; i < K; i++)
            {
                column = new DataGridViewTextBoxColumn();
                dataGridView1.Columns.Add(column);
            }
            for (int i = 0; i < R; i++)
                dataGridView1.Rows.Add();
            label1.Visible = true;
            dataGridView1.Visible = true;
        }

        private void максимальныйЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
            K = 3; R = 3;
            label1.Text = "A=";
            action = MATRIX_MIN;
            DataGridViewColumn column;
            dataGridView1.AllowUserToAddRows = false;
            for (int i = 0; i < K; i++)
            {
                column = new DataGridViewTextBoxColumn();
                dataGridView1.Columns.Add(column);
            }
            for (int i = 0; i < R; i++)
                dataGridView1.Rows.Add();
            label1.Visible = true;
            dataGridView1.Visible = true;
        }

        private void расчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            switch (action)
            {
                case MATRIX_MIN:
                    Min();
                    break;
                case MATRIX_MAX:
                    Max();
                    break;
                case MATRIX_OPR:
                    break;
                case MATRIX_REV:
                    break;
                case MATRIX_TRANSP:
                    Transponirovanie();
                    break;
                case MATRIX_SUM:
                    SummaAB();
                    break;
                case MATRIX_MULTI:
                    MultiplacationAB();
                    break;
            }
           
        }

        private void определительМатрицыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void транспонированиеМатрицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
            K = 3; R = 3;
            label1.Text = "A=";
            action = MATRIX_TRANSP;
            DataGridViewColumn column;
            DataGridViewColumn column2;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;
            for (int i = 0; i < K; i++)
            {
                column = new DataGridViewTextBoxColumn();
                column2 = new DataGridViewTextBoxColumn();
                dataGridView1.Columns.Add(column);
                dataGridView3.Columns.Add(column2);
            }
            for (int i = 0; i < R; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView3.Rows.Add();
            }
            label1.Visible = true;
            dataGridView1.Visible = true;
        }

        private void обратнаяМатрицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
            K = 3; R = 3;
            label1.Text = "A=";
            action = MATRIX_REV;
            DataGridViewColumn column;
            DataGridViewColumn column2;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;
            for (int i = 0; i < K; i++)
            {
                column = new DataGridViewTextBoxColumn();
                column2 = new DataGridViewTextBoxColumn();
                dataGridView1.Columns.Add(column);
                dataGridView3.Columns.Add(column2);
            }
            for (int i = 0; i < R; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView3.Rows.Add();
            }
            label1.Visible = true;
            dataGridView1.Visible = true;
        }

        private void суммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
            K = 3; R = 3;
            label1.Text = "A=";
            label2.Text = "B=";
            action = MATRIX_SUM;
            DataGridViewColumn column;
            DataGridViewColumn column2;
            DataGridViewColumn column3;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;
            for (int i = 0; i < K; i++)
            {
                column = new DataGridViewTextBoxColumn();
                column2 = new DataGridViewTextBoxColumn();
                column3 = new DataGridViewTextBoxColumn();
                dataGridView1.Columns.Add(column);
                dataGridView2.Columns.Add(column2);
                dataGridView3.Columns.Add(column3);
            }
            for (int i = 0; i < R; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView2.Rows.Add();
                dataGridView3.Rows.Add();
            }
            label1.Visible = true;
            label2.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
        }

        private void умножениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
            K = 3; R = 3;
            label1.Text = "A=";
            label2.Text = "B=";
            action = MATRIX_MULTI;
            DataGridViewColumn column;
            DataGridViewColumn column2;
            DataGridViewColumn column3;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;
            for (int i = 0; i < K; i++)
            {
                column = new DataGridViewTextBoxColumn();
                column2 = new DataGridViewTextBoxColumn();
                column3 = new DataGridViewTextBoxColumn();
                dataGridView1.Columns.Add(column);
                dataGridView2.Columns.Add(column2);
                dataGridView3.Columns.Add(column3);
            }
            for (int i = 0; i < R; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView2.Rows.Add();
                dataGridView3.Rows.Add();
            }
            label1.Visible = true;
            label2.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {

        }

        private void Min()
        {
            int temp;
            int min = Int32.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    temp = Int32.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    if (temp < min)
                        min = temp;
                }
            label3.Text = $"MIN = {min}";
            label3.Visible = true;
        }
        private void Max()
        {
            int temp;
            int max = Int32.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    temp = Int32.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    if (temp > max)
                        max = temp;
                }
            label3.Text = $"MAX = {max}";
            label3.Visible = true;
        }
        private void Opridelitel()
        {

        }
        private void Transponirovanie()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int temp = Int32.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString());
                    dataGridView3.Rows[i].Cells[j].Value = temp;
                }
            }
            label2.Text = "Транспонированая матрица A=";
            label2.Visible = true;
            dataGridView3.Visible = true;
        }
        private void Revers()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int temp = Int32.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString());
                    dataGridView3.Rows[i].Cells[j].Value = temp;
                }
            }
            label2.Text = "Транспонированая матрица A=";
            label2.Visible = true;
            dataGridView3.Visible = true;
        }
        private void SummaAB()
        {
            int temp, temp2;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    temp = Int32.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    temp2 = Int32.Parse(dataGridView2.Rows[i].Cells[j].Value.ToString());
                    dataGridView3.Rows[i].Cells[j].Value = (temp + temp2).ToString();
                }
            label4.Text = "=";
            label4.Visible = true;
            dataGridView3.Visible = true;
        } 
        private void MultiplacationAB()
        {
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    int temp = 0;
                    for (int k = 0; k < K; k++)
                    {
                        temp += Int32.Parse(dataGridView1.Rows[i].Cells[k].Value.ToString()) * Int32.Parse(dataGridView2.Rows[k].Cells[j].Value.ToString());
                    }
                    dataGridView3.Rows[i].Cells[j].Value = temp.ToString();
                }
            }
            label4.Text = "=";
            label4.Visible = true;
            dataGridView3.Visible = true;
        }
        private void ClearForm()
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
    }
}
