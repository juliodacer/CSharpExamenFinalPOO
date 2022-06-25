
namespace ComprasOnline
{
    public class CalculadoraDePrecio
    {
        public CalculadoraDePrecio()
        {
        }

        private IRegla _regla;

        public void DefinirRegla(IRegla reglaflete)
        {
            _regla = reglaflete;
        }

        public void Calcular(Compra compra, Decimal dscto, Decimal flete)
        {
           compra.Valor = dscto + flete;
        }
    }
}
