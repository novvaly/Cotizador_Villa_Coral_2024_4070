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

        private void btnPesos_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            decimal tasa = nudTasa.Value;

            decimal totalPesos = reserva.Total * tasa;

            lstResultados.Items.Add(
                $"Total en pesos: RD$ {totalPesos:N2}"
            );
        }

        private void btnPorPersona_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            decimal personas = nudPersonas.Value;

            decimal porPersona = reserva.Total / personas;

            lstResultados.Items.Add(
                $"Por persona: US$ {porPersona:N2}"
            );
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            decimal deposito = reserva.Total * 0.30m;
            decimal saldo = reserva.Total - deposito;

            lstResultados.Items.Add($"Depósito (30%): US$ {deposito:N2}");
            lstResultados.Items.Add($"Saldo pendiente: US$ {saldo:N2}");
        }

        private void btnFinSemana_Click(object sender, EventArgs e)
        {
            decimal tarifa = nudTarifa.Value;

            if (chkFinSemana.Checked)
            {
                tarifa = tarifa * 1.15m;
            }

            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = tarifa
            };

            lstResultados.Items.Add(
                $"Total fin de semana: US$ {reserva.Total:N2}"
            );
        }

        private void btnDesglose_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            lstResultados.Items.Add($"Subtotal: US$ {reserva.Subtotal:N2}");
            lstResultados.Items.Add($"Descuento: US$ {reserva.Descuento:N2}");
            lstResultados.Items.Add($"Base imponible: US$ {reserva.BaseImponible:N2}");
            lstResultados.Items.Add($"ITBIS: US$ {reserva.Itbis:N2}");
            lstResultados.Items.Add($"Servicio: US$ {reserva.Servicio:N2}");
            lstResultados.Items.Add($"Total: US$ {reserva.Total:N2}");
        }

        private void btnTraslado_Click(object sender, EventArgs e)
        {
            var traslado = new TrasladoAeropuerto
            {
                Pasajeros = 2,
                Nocturno = true
            };

            lstResultados.Items.Add(
                $"Traslado aeropuerto: US$ {traslado.Total:N2}"
            );
        }

        private void btnMinibar_Click(object sender, EventArgs e)
        {
            var minibar = new ConsumoMinibar
            {
                Cantidad = 2,
                PrecioUnitario = 3.50m
            };

            lstResultados.Items.Add(
                $"Consumo minibar: US$ {minibar.Total:N2}"
            );
        }

        private void btnCuentaTotal_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            var traslado = new TrasladoAeropuerto
            {
                Pasajeros = 2,
                Nocturno = true
            };

            var excursion = new Excursion
            {
                Personas = 4,
                PrecioPorPersona = 45m
            };

            var minibar = new ConsumoMinibar
            {
                Cantidad = 2,
                PrecioUnitario = 3.50m
            };

            decimal cuentaTotal =
                reserva.Total +
                traslado.Total +
                excursion.Total +
                minibar.Total;

            lstResultados.Items.Add(
                $"Cuenta total: US$ {cuentaTotal:N2}"
            );
        }

        private void btnViejo_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Add(
                $"Depósito de 1000: {SistemaViejo.CalcularDeposito(1000m):N2}"
            );

            lstResultados.Items.Add(
                $"100 USD a tasa 60: {SistemaViejo.APesos(100m, 60m):N2}"
            );

            lstResultados.Items.Add(
                $"Tarifa 200 fin de semana: {SistemaViejo.TarifaFinDeSemana(200m, true):N2}"
            );

            lstResultados.Items.Add(
                $"Excursión 4 × 50: {SistemaViejo.TotalExcursion(4, 50m):N2}"
            );

            lstResultados.Items.Add(
                $"Minibar 3 × 4: {SistemaViejo.TotalMinibar(3, 4m):N2}"
            );
        }
    }
}

