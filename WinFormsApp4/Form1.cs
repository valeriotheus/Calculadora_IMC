namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;
            altura = Convert.ToDouble(txtAltura.Text) / 100;
            peso = Convert.ToDouble(txtPeso.Text);
            imc = peso / (altura * altura);
            txtResIMC.Text = imc.ToString();

            if (imc < 18.5)
                MessageBox.Show("Você está abaixo do peso");
            else if (imc >= 18.5 && imc < 25)
                MessageBox.Show("Você está com o peso saudável");
            else if (imc >= 25 && imc < 30)
                MessageBox.Show("Você está acima do peso");
            else if (imc >= 30 && imc < 35)
                MessageBox.Show("Você está com obesidade Grau 1");
            else if (imc >= 35 && imc < 40)
                MessageBox.Show("Você está com obesidade Grau 2 (Severa)");
            else
                MessageBox.Show("Você está com obesidade Grau 3 (Mórbida)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtResIMC.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
