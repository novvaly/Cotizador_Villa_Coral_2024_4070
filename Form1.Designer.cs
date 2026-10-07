namespace Cotizador_2024_4070
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHuesped = new TextBox();
            nudNoches = new NumericUpDown();
            nudTarifa = new NumericUpDown();
            lstResultados = new ListBox();
            txtTarifas = new TextBox();
            txtNoches = new TextBox();
            btnNivel1 = new Button();
            lblTasa = new Label();
            btnPesos = new Button();
            nudTasa = new NumericUpDown();
            nudPersonas = new NumericUpDown();
            btnPorPersona = new Button();
            txtPersonas = new Label();
            btnDeposito = new Button();
            chkFinSemana = new CheckBox();
            btnFinSemana = new Button();
            btnDesglose = new Button();
            btnTraslado = new Button();
            btnExcursion = new Button();
            btnMinibar = new Button();
            btnCuentaTotal = new Button();
            btnViejo = new Button();
            btnFactura = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
            SuspendLayout();
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(25, 12);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(201, 27);
            txtHuesped.TabIndex = 0;
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(149, 63);
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(150, 27);
            nudNoches.TabIndex = 1;
            nudNoches.ValueChanged += btnNivel1_Click;
            // 
            // nudTarifa
            // 
            nudTarifa.Location = new Point(149, 117);
            nudTarifa.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(150, 27);
            nudTarifa.TabIndex = 2;
            nudTarifa.ValueChanged += btnNivel1_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(25, 159);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(274, 144);
            lstResultados.TabIndex = 3;
            // 
            // txtTarifas
            // 
            txtTarifas.Location = new Point(25, 117);
            txtTarifas.Name = "txtTarifas";
            txtTarifas.Size = new Size(113, 27);
            txtTarifas.TabIndex = 4;
            txtTarifas.Text = "Tarifa:";
            // 
            // txtNoches
            // 
            txtNoches.Location = new Point(25, 62);
            txtNoches.Name = "txtNoches";
            txtNoches.Size = new Size(113, 27);
            txtNoches.TabIndex = 5;
            txtNoches.Text = "Noches:";
            // 
            // btnNivel1
            // 
            btnNivel1.BackColor = SystemColors.ActiveCaption;
            btnNivel1.Location = new Point(750, 63);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(94, 29);
            btnNivel1.TabIndex = 6;
            btnNivel1.Text = "Nivel1";
            btnNivel1.UseVisualStyleBackColor = false;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // lblTasa
            // 
            lblTasa.AutoSize = true;
            lblTasa.Location = new Point(350, 63);
            lblTasa.Name = "lblTasa";
            lblTasa.Size = new Size(101, 20);
            lblTasa.TabIndex = 7;
            lblTasa.Text = "Tasa del dolar";
            // 
            // btnPesos
            // 
            btnPesos.Location = new Point(531, 63);
            btnPesos.Name = "btnPesos";
            btnPesos.Size = new Size(108, 29);
            btnPesos.TabIndex = 8;
            btnPesos.Text = "Total en RD$";
            btnPesos.UseVisualStyleBackColor = true;
            btnPesos.Click += btnPesos_Click;
            // 
            // nudTasa
            // 
            nudTasa.DecimalPlaces = 2;
            nudTasa.Location = new Point(457, 63);
            nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTasa.Name = "nudTasa";
            nudTasa.Size = new Size(68, 27);
            nudTasa.TabIndex = 9;
            // 
            // nudPersonas
            // 
            nudPersonas.Location = new Point(513, 117);
            nudPersonas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPersonas.Name = "nudPersonas";
            nudPersonas.Size = new Size(68, 27);
            nudPersonas.TabIndex = 10;
            nudPersonas.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnPorPersona
            // 
            btnPorPersona.Location = new Point(587, 116);
            btnPorPersona.Name = "btnPorPersona";
            btnPorPersona.Size = new Size(118, 29);
            btnPorPersona.TabIndex = 12;
            btnPorPersona.Text = "Por persona";
            btnPorPersona.UseVisualStyleBackColor = true;
            btnPorPersona.Click += btnPorPersona_Click;
            // 
            // txtPersonas
            // 
            txtPersonas.AutoSize = true;
            txtPersonas.Location = new Point(350, 120);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(147, 20);
            txtPersonas.TabIndex = 11;
            txtPersonas.Text = "Numero de personas";
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(350, 159);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(142, 29);
            btnDeposito.TabIndex = 13;
            btnDeposito.Text = "Depósito y saldo";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // chkFinSemana
            // 
            chkFinSemana.AutoSize = true;
            chkFinSemana.Location = new Point(513, 164);
            chkFinSemana.Name = "chkFinSemana";
            chkFinSemana.Size = new Size(178, 24);
            chkFinSemana.TabIndex = 14;
            chkFinSemana.Text = "Fin de semana (+15%)";
            chkFinSemana.UseVisualStyleBackColor = true;
            // 
            // btnFinSemana
            // 
            btnFinSemana.Location = new Point(697, 161);
            btnFinSemana.Name = "btnFinSemana";
            btnFinSemana.Size = new Size(123, 29);
            btnFinSemana.TabIndex = 15;
            btnFinSemana.Text = "Fin de semana";
            btnFinSemana.UseVisualStyleBackColor = true;
            btnFinSemana.Click += btnFinSemana_Click;
            // 
            // btnDesglose
            // 
            btnDesglose.Location = new Point(484, 231);
            btnDesglose.Name = "btnDesglose";
            btnDesglose.Size = new Size(155, 29);
            btnDesglose.TabIndex = 16;
            btnDesglose.Text = "Desglose completo";
            btnDesglose.UseVisualStyleBackColor = true;
            btnDesglose.Click += btnDesglose_Click;
            // 
            // btnTraslado
            // 
            btnTraslado.Location = new Point(34, 353);
            btnTraslado.Name = "btnTraslado";
            btnTraslado.Size = new Size(159, 29);
            btnTraslado.TabIndex = 17;
            btnTraslado.Text = "Traslado areopuerto";
            btnTraslado.UseVisualStyleBackColor = true;
            btnTraslado.Click += btnTraslado_Click;
            // 
            // btnExcursion
            // 
            btnExcursion.Location = new Point(34, 388);
            btnExcursion.Name = "btnExcursion";
            btnExcursion.Size = new Size(140, 29);
            btnExcursion.TabIndex = 18;
            btnExcursion.Text = "Excursion Saona";
            btnExcursion.UseVisualStyleBackColor = true;
            // 
            // btnMinibar
            // 
            btnMinibar.AccessibleRole = AccessibleRole.Cursor;
            btnMinibar.Location = new Point(34, 423);
            btnMinibar.Name = "btnMinibar";
            btnMinibar.Size = new Size(136, 29);
            btnMinibar.TabIndex = 19;
            btnMinibar.Text = "Consumo Minibar";
            btnMinibar.UseVisualStyleBackColor = true;
            btnMinibar.Click += btnMinibar_Click;
            // 
            // btnCuentaTotal
            // 
            btnCuentaTotal.Location = new Point(34, 458);
            btnCuentaTotal.Name = "btnCuentaTotal";
            btnCuentaTotal.Size = new Size(147, 29);
            btnCuentaTotal.TabIndex = 20;
            btnCuentaTotal.Text = "Cuenta total";
            btnCuentaTotal.UseVisualStyleBackColor = true;
            btnCuentaTotal.Click += btnCuentaTotal_Click;
            // 
            // btnViejo
            // 
            btnViejo.Location = new Point(295, 357);
            btnViejo.Name = "btnViejo";
            btnViejo.Size = new Size(164, 29);
            btnViejo.TabIndex = 21;
            btnViejo.Text = "Probar boton viejo";
            btnViejo.UseVisualStyleBackColor = true;
            btnViejo.Click += btnViejo_Click;
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.MistyRose;
            btnFactura.Location = new Point(484, 357);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(164, 29);
            btnFactura.TabIndex = 22;
            btnFactura.Text = "Factura de la estadia";
            btnFactura.UseVisualStyleBackColor = false;
            btnFactura.Click += btnFactura_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 713);
            Controls.Add(btnFactura);
            Controls.Add(btnViejo);
            Controls.Add(btnCuentaTotal);
            Controls.Add(btnMinibar);
            Controls.Add(btnExcursion);
            Controls.Add(btnTraslado);
            Controls.Add(btnDesglose);
            Controls.Add(btnFinSemana);
            Controls.Add(chkFinSemana);
            Controls.Add(btnDeposito);
            Controls.Add(btnPorPersona);
            Controls.Add(txtPersonas);
            Controls.Add(nudPersonas);
            Controls.Add(nudTasa);
            Controls.Add(btnPesos);
            Controls.Add(lblTasa);
            Controls.Add(btnNivel1);
            Controls.Add(txtNoches);
            Controls.Add(txtTarifas);
            Controls.Add(lstResultados);
            Controls.Add(nudTarifa);
            Controls.Add(nudNoches);
            Controls.Add(txtHuesped);
            Name = "Form1";
            Text = "Novaly Pujols 2024-4070";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHuesped;
        private NumericUpDown nudNoches;
        private NumericUpDown nudTarifa;
        private ListBox lstResultados;
        private TextBox txtTarifas;
        private TextBox txtNoches;
        private Button btnNivel1;
        private Label lblTasa;
        private Button btnPesos;
        private NumericUpDown nudTasa;
        private NumericUpDown nudPersonas;
        private Button btnPorPersona;
        private Label txtPersonas;
        private Button btnDeposito;
        private CheckBox chkFinSemana;
        private Button btnFinSemana;
        private Button btnDesglose;
        private Button btnTraslado;
        private Button btnExcursion;
        private Button btnMinibar;
        private Button btnCuentaTotal;
        private Button btnViejo;
        private Button btnFactura;
    }
}
