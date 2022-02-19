using System.Text;

namespace Quiz_Assignment
{
    public partial class Form1 : Form
    {
        int NUM1 = 0;
        int NUM2 = 0;
        int NUM3 = 0;
        int NUM4 = 0;
        private string filePath;

        //AllDATA oQA = new AllDATA();
        public Form1()
        {
            InitializeComponent();
        }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addDataToGridView(string List, string Income, string Expenses)
        {
            this.dataGridView1.Rows.Add(new string[] { List, Income, Expenses });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBoxList.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBoxIncome.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBoxExpenses.Text;

            NUM2 = Convert.ToInt32(textBoxIncome.Text);
            NUM4 = Convert.ToInt32(textBoxExpenses.Text);

            NUM1 = NUM2 + NUM1;
            NUM3 = NUM4 + NUM3;

            Total_Income.Text = NUM1.ToString();
            Total_Expenses.Text = NUM3.ToString();

            textBoxList.Text = "";
            textBoxIncome.Text = "";
            textBoxExpenses.Text = "";
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string column = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                column += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += column;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(saveFileDialog.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Total_Income.Text = "";
            Total_Expenses.Text = "";
        }
    }
}