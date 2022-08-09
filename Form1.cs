namespace ProyectoEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(textAltura.Text);
            double diametro = Convert.ToDouble(textAltura.Text);

            double radio = diametro / 2;
            double area = (2 * Math.PI * radio);
            double volumen = Math.PI * Math.Pow(radio, 2);

            textAltura.Text = "La altura es: " + Convert.ToString(altura);





        }


        private void Clean_All()
        {
            textAltura.Clear();
            textDiametro.Clear();
            textBox3.Clear();
        }


    }
}