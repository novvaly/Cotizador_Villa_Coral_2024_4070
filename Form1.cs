namespace Cotizador_2024_4070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
            private void btnNivel1_Click(object sender, EventArgs e)
        {
            // 1.1
            {
                int a = 10;
                int b = 3;
                int r = a / b;
            }

            // 1.2
            {
                decimal r = 10 / 4m;
            }

            // 1.3
            {
                int x = 5;
                x = x + 2;
                x = x * 3;
            }

            // 1.4
            {
                decimal p = 200m;
                decimal r = p * 0.18m;
            }

            // 1.5
            {
                int n = 7;
                decimal d = 0m;

                if (n > 7)
                {
                    d = 50m;
                }
            }

            // 1.6
            {
                int n = 7;
                bool larga = n >= 7;
            }

            // 1.7
            {
                string s = "Villa" + "Coral";
            }

            // 1.8
            {
                int n = 4;
                decimal t = 100m;
                decimal total = n * t * 1.28m;
            }

            // 1.9
            {
                decimal t = 120m;
                t = t + t * 0.25m;
            }

            // 1.10
            {
                int noches = (int)8.9m;
            }

            MessageBox.Show("Ejercicios del Nivel 1 ejecutados correctamente.");
        }
    }
    }

