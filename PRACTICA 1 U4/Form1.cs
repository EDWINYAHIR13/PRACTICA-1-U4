namespace PRACTICA_1_U4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int sumar(int num1, int num2)
        {
            int resultado;
            resultado = num1 + num2;
            return resultado;

        }
        private Double operaciones(int num1, int num2, string op)
        {
            Double resultado;
            if (op == "s")
            {
                resultado = num1 + num2;
            }
            else if (op == "r")
            {
                resultado = num1 - num2;
            }
            else if (op == "m")
            {
                resultado = num1 * num2;
            }
            else
            {
                resultado = num1 / num2;
            }
            return resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;

            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);

            resultado = operaciones(numero1, numero2, "s");
            textBox3.Text = Convert.ToString(resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;

            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);

            resultado = operaciones(numero1, numero2, "r");
            textBox3.Text = Convert.ToString(resultado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;

            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);

            resultado = operaciones(numero1, numero2, "m");
            textBox3.Text = Convert.ToString(resultado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;

            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);

            resultado = operaciones(numero1, numero2, "d");
            textBox3.Text = Convert.ToString(resultado);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}