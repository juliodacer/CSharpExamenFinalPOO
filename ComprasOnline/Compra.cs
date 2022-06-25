namespace ComprasOnline
{
    public class Compra
    {
        public int IdCompra { get;  set; }
        public CiudadEnum CiudadEnum { get; set; }
        public decimal Valor { get; set; }

        public Compra(int idCompra, CiudadEnum ciudadEnum, decimal valor)
        {
            IdCompra = idCompra;
            CiudadEnum = ciudadEnum;
            Valor = valor;
        }

    }
}
