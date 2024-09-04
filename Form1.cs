namespace Senac.ConversorMoedas
{
    public partial class Form1 : Form
    {
        decimal valorDolar = 1;
        decimal valorReal_Dolar = 0.18m;
        decimal valorEuro_Dolar = 1.11m;
        decimal valorIene_Dolar = 0.0068m;
        decimal valorBitcoin_Dolar = 0.000017m;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxMoedaOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMoedaOrigem.Text)
            {
                case "Real":
                    pictureBoxImagemOrigem.Image = Image.FromFile(@"..\..\..\Imagens\real.png");
                    break;
                case "Dolar":
                    pictureBoxImagemOrigem.Image = Image.FromFile(@"..\..\..\Imagens\dolar.png");
                    break;
                case "Euro":
                    pictureBoxImagemOrigem.Image = Image.FromFile(@"..\..\..\Imagens\euro.png");
                    break;
                case "Iene":
                    pictureBoxImagemOrigem.Image = Image.FromFile(@"..\..\..\Imagens\iene.png");
                    break;
                case "Bitcoin":
                    pictureBoxImagemOrigem.Image = Image.FromFile(@"..\..\..\Imagens\bitcoin.png");
                    break;

            }
        }

        private void comboBoxMoedaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMoedaDestino.Text)
            {
                case "Real":
                    pictureBoxImagemDestino.Image = Image.FromFile(@"..\..\..\Imagens\real.png");
                    break;
                case "Dolar":
                    pictureBoxImagemDestino.Image = Image.FromFile(@"..\..\..\Imagens\dolar.png");
                    break;
                case "Euro":
                    pictureBoxImagemDestino.Image = Image.FromFile(@"..\..\..\Imagens\euro.png");
                    break;
                case "Iene":
                    pictureBoxImagemDestino.Image = Image.FromFile(@"..\..\..\Imagens\iene.png");
                    break;
                case "Bitcoin":
                    pictureBoxImagemDestino.Image = Image.FromFile(@"..\..\..\Imagens\bitcoin.png");
                    break;
            }
        }

        public decimal ConverteValores(decimal valorOrigem, string moedaOrigem, string moedaDestino)
        {
            switch (moedaOrigem)
            {
                case "Real":
                    valorDolar = valorOrigem * valorReal_Dolar;
                    break;
                case "Dolar":
                    valorDolar = valorOrigem;
                    break;
                case "Euro":
                    valorDolar = valorOrigem * valorEuro_Dolar;
                    break;
                case "Iene":
                    valorDolar = valorOrigem * valorIene_Dolar;
                    break;
                case "Bitcoin":
                    valorDolar = valorOrigem * valorBitcoin_Dolar;
                    break;
            }
            decimal valorDestino = 0;
            switch (moedaDestino)
            {
                case "Real":
                    valorDestino = valorDolar / valorReal_Dolar;
                    break;
                case "Dolar":
                    valorDestino = valorDolar;
                    break;
                case "Euro":
                    valorDestino = valorDolar / valorEuro_Dolar;
                    break;
                case "Iene":
                    valorDestino = valorDolar / valorIene_Dolar;
                    break;
                case "Bitcoin":
                    valorDestino = valorDolar / valorBitcoin_Dolar;
                    break;
            }
            return valorDestino;
        }
        private void buttonConverter_Click(object sender, EventArgs e)
        {
            if (comboBoxMoedaOrigem.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a moeda de origem",
                "Origem nao selecionada");

                return;
            }

            if (comboBoxMoedaDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a moeda de destino",
                "Destino nao selecionada");

                return;
            }

            if (textBoxValorOrigem.Text == "")
            {
                MessageBox.Show("Digite o valor de origem",
                "Valor de origem nao digitado");

                return;
            }

            decimal valorOrigem = Convert.ToDecimal(textBoxValorOrigem.Text);

            decimal valorDestino = ConverteValores(valorOrigem, comboBoxMoedaOrigem.Text, comboBoxMoedaDestino.Text);

            textBoxValorDestino.Text = valorDestino.ToString("N2");

            ValorMoedaExtenso();
        }

        public void ValorMoedaExtenso()
        {
            string simboloOrigem = "";

            switch (comboBoxMoedaOrigem.Text)
                {
                case "Real":
                    simboloOrigem = "R$";
                    break;
                case "Dolar":
                    simboloOrigem = "US$";
                    break;
                case "Euro":
                    simboloOrigem = "€";
                    break;
                case "Iene":
                    simboloOrigem = "¥";
                    break;
                case "Bitcoin":
                    simboloOrigem = "?";
                    break;
                }

                string simboloDestino = "";

                switch (comboBoxMoedaDestino.Text)
                {
                    case "Real":
                        simboloDestino = "R$";
                        break;
                    case "Dolar":
                        simboloDestino = "US$";
                        break;
                    case "Euro":
                        simboloDestino = "€";
                        break;
                    case "Iene":
                        simboloDestino = "¥";
                        break;
                    case "Bitcoin":
                        simboloDestino = "?";
                        break;
                }

                decimal valor = ConverteValores(1, comboBoxMoedaOrigem.Text, comboBoxMoedaDestino.Text);

                string mensagem = $"{simboloOrigem} 1,00 = {simboloDestino}" + $"{valor.ToString("N2")}";

              toolStripLabelValorMoedas.Text = mensagem;
            }
        }
    }
