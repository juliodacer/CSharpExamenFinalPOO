
using ComprasOnline;

List<Compra> compras = new List<Compra>();
compras.Add(new Compra(1, CiudadEnum.BuenosAires, 1000));
compras.Add(new Compra(2, CiudadEnum.RioDeJaneiro,3000));
compras.Add(new Compra(3, CiudadEnum.Cusco, 4000));
compras.Add(new Compra(4, CiudadEnum.Santiago, 5000));
compras.Add(new Compra(5, CiudadEnum.SaoPaulo, 5500));
compras.Add(new Compra(6, CiudadEnum.Quito, 6000));
compras.Add(new Compra(7, CiudadEnum.LaPaz, 8000));
compras.Add(new Compra(8, CiudadEnum.Montevideo, 9000));
compras.Add(new Compra(9, CiudadEnum.Lima, 4000));

List<Decimal> costoDeFlete = new List<Decimal>();

var calculadoraDePrecio = new CalculadoraDePrecio();
var flete = new Flete();
var descuento = new TablaDePrecioEstandar();

foreach (var compra in compras) {
    var dcto = descuento.Calcular(compra);
    var costoFlete = flete.Calcular(compra);
    calculadoraDePrecio.Calcular(compra, dcto, costoFlete);
    Console.WriteLine("Compra: " + compra.IdCompra + "\t Ciudad: " + compra.CiudadEnum + "\t\t Valor: " + compra.Valor);
}