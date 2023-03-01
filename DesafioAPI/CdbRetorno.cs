namespace DesafioAPI
{
    public class CdbRetorno
    {
        private decimal TaxaBase => 108 / 100;
        private decimal TaxaCDI => (decimal)0.9 /100;
        private decimal IR6 => (decimal)22.5 / 100;
        private decimal IR12 => (decimal)20 / 100;
        private decimal IR24 => (decimal)17.5 / 100;
        private decimal IR => (decimal)15 / 100;
        private decimal ValorAplicacao { get; set; }
        private int Meses { get; set; }

        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }

        public void CalcularValores(decimal valorAplicacao, int meses)
        {
            this.ValorAplicacao = valorAplicacao;
            this.Meses = meses;

            CalcularValorBruto();
            CalcularValorLiquido();
        }

        private void CalcularValorBruto()
        {
            decimal valorBruto = ValorAplicacao;
            decimal taxa = TaxaCDI * TaxaBase;
            
            for (int i = 0; i < Meses; i++)
            {
                valorBruto = valorBruto * (1 + taxa);
            }

            this.ValorBruto = Math.Round(valorBruto, 2);
        }

        private void CalcularValorLiquido()
        {
            switch (Meses)
            {
                case <= 6:
                    ValorLiquido = Math.Round((ValorBruto - (ValorBruto * IR6)),2);
                    break;
                case <= 12:
                    ValorLiquido = Math.Round((ValorBruto - (ValorBruto * IR12)), 2);
                    break;
                case <= 24:
                    ValorLiquido = Math.Round((ValorBruto - (ValorBruto * IR24)), 2);
                    break;
                default:
                    ValorLiquido = Math.Round((ValorBruto - (ValorBruto * IR)), 2);
                    break;
            }
        }
    }
}