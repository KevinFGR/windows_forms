namespace aula_01_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Name = txtBox_name.Text;
            pessoa1.BornDate = txtBox_bornDate.Text;
            pessoa1.PetsQuantity = numeric_petsQuantity.Value;
            txtBox_name.Text = "";
            txtBox_bornDate.Text = null;
            numeric_petsQuantity.Value = 0;
            dataGridView1.Rows.Add(pessoa1.Name,
                                    pessoa1.BornDate,
                                    pessoa1.PetsQuantity);


        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }
    }
    public class Pessoa
    {
        public string Name { get; set; }

        public string BornDate { get; set; }

        public decimal PetsQuantity { get; set; }
    }
}