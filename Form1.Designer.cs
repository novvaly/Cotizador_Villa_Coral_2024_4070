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
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            SuspendLayout();
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(200, 37);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(201, 27);
            txtHuesped.TabIndex = 0;
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(287, 109);
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(150, 27);
            nudNoches.TabIndex = 1;
            // 
            // nudTarifa
            // 
            nudTarifa.Location = new Point(287, 159);
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(150, 27);
            nudTarifa.TabIndex = 2;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(149, 213);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(415, 164);
            lstResultados.TabIndex = 3;
            // 
            // txtTarifas
            // 
            txtTarifas.Location = new Point(149, 158);
            txtTarifas.Name = "txtTarifas";
            txtTarifas.Size = new Size(113, 27);
            txtTarifas.TabIndex = 4;
            txtTarifas.Text = "Tarifa:";
            // 
            // txtNoches
            // 
            txtNoches.Location = new Point(149, 108);
            txtNoches.Name = "txtNoches";
            txtNoches.Size = new Size(113, 27);
            txtNoches.TabIndex = 5;
            txtNoches.Text = "Noches:";
            // 
            // btnNivel1
            // 
            btnNivel1.BackColor = SystemColors.ActiveCaption;
            btnNivel1.Location = new Point(610, 159);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(94, 29);
            btnNivel1.TabIndex = 6;
            btnNivel1.Text = "Nivel1";
            btnNivel1.UseVisualStyleBackColor = false;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 450);
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
    }
}
