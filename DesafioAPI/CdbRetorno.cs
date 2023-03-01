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
        private decimal ValorAplicado { get; set; }
        private int Meses { get; set; }

        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }

        public void CalcularValores(decimal valorAplicado, int meses)
        {
            //VF = VI x [1 + (CDI x TB)]
            this.ValorAplicado = valorAplicado;
            this.Meses = meses;

            CalcularValorBruto();
            CalcularValorLiquido();
        }

        private void CalcularValorBruto()
        {
            ValorBruto = ValorAplicado;
            decimal taxa = TaxaCDI * TaxaBase;
            
            for (int i = 0; i < Meses; i++)
            {
                ValorBruto = ValorBruto * (1 + taxa);
            }
        }

        private void CalcularValorLiquido()
        {
            switch (Meses)
            {
                case <= 6:
                    ValorLiquido = ValorBruto - (ValorBruto * IR6);
                    break;
                case <= 12:
                    ValorLiquido = ValorBruto - (ValorBruto * IR12);
                    break;
                case <= 24:
                    ValorLiquido = ValorBruto - (ValorBruto * IR24);
                    break;
                default:
                    ValorLiquido = ValorBruto - (ValorBruto * IR);
                    break;
            }
        }
    }
}