namespace Exercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int-é abreviação de "integer" (inteiro) e é usado para armazenar números inteiros, ou seja, números sem parte decimal. Por exemplo, 1, 10, -5 são todos inteiros.
            //double-por outro lado, é usado para armazenar números de ponto flutuante, ou seja, números que podem ter uma parte decimal. Por exemplo, 3.14, -0.5, 2.0 são todos números de ponto flutuante.
            //Maneira errada mas da
            //int comp = int.Parse(textBox1.Text);
            //int larg = int.Parse(textBox2.Text);
            //int altura = int.Parse(textBox3.Text);

            //Maneira certa
            int comp = Convert.ToInt32(textBox1.Text);
            int larg = Convert.ToInt32(textBox2.Text);
            int altura = Convert.ToInt32(textBox3.Text);

            int area = comp * larg;
            int perimetro = 2 * (comp + larg);
            int volume = area * altura;

            listBox1.Items.Add("Area " + area);
            listBox1.Items.Add("Perimetro " + perimetro);
            listBox1.Items.Add("Volume " + volume);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();
        }
    }
}