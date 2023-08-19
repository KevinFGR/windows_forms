namespace pesquisa_de_satisfação
{
    public partial class Form1 : Form
    {
        int contS = 0;
        int contN = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            contS++;
            lb_contS.Text = contS.ToString();


        }

        private void btn_nao_Click(object sender, EventArgs e)
        {
            contN++;
            lb_contN.Text = contN.ToString();


        }
    }
}