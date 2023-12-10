using System;
using System.Windows.Forms;

namespace Combustivel
{
    public partial class Form1 : Form
    {
        private double precoAlcool = 2.74;
        private double precoGasolina = 4.25;
        private double precoDiesel = 3.00;

        private int alcool = 0;
        private int gasolina = 0;
        private int diesel = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            cmbCombustivel.Items.Add("Álcool (1)");
            cmbCombustivel.Items.Add("Gasolina (2)");
            cmbCombustivel.Items.Add("Diesel (3)");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbCombustivel.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de combustível.");
                return;
            }

            if (!double.TryParse(txtQuantidadeLitros.Text, out double quantidadeLitros) || quantidadeLitros <= 0)
            {
                MessageBox.Show("Insira uma quantidade válida de litros.");
                return;
            }

            int tipo = cmbCombustivel.SelectedIndex + 1; // Índices de ComboBox começam em 0

            if (tipo == 1)
            {
                alcool += (int)quantidadeLitros;
                UpdateDisplay("Álcool", alcool, precoAlcool);
            }
            else if (tipo == 2)
            {
                gasolina += (int)quantidadeLitros;
                UpdateDisplay("Gasolina", gasolina, precoGasolina);
            }
            else if (tipo == 3)
            {
                diesel += (int)quantidadeLitros;
                UpdateDisplay("Diesel", diesel, precoDiesel);
            }
        }

        private void UpdateDisplay(string tipo, int quantidade, double precoUnitario)
        {
            string mensagem = $"{tipo} - Total: {quantidade} litros, Valor total: R${quantidade * precoUnitario:F2}";
            lstResultados.Items.Add(mensagem);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MUITO OBRIGADO");
            this.Close();
        }

        private void cmbCombustivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
