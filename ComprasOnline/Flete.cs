namespace ComprasOnline
{
    public class Flete: IRegla
    {
        public decimal Calcular(Compra compra)
        {
            CiudadEnum ciudad = compra.CiudadEnum;

            switch (ciudad)
            {
                //regla para Argentina
                case (CiudadEnum.BuenosAires):
                    return 5;
                    break;

                //regla para Peru
                case CiudadEnum.Cusco:
                case CiudadEnum.Lima:
                    return 6;
                    break;

                //regla para Brasil
                case CiudadEnum.RioDeJaneiro:
                case CiudadEnum.SaoPaulo:
                    return 7;
                    break;

                //regla para Ecuador
                case (CiudadEnum.Quito):
                    return 8;
                    break;

                //regla para Bolivia
                case (CiudadEnum.LaPaz):
                    return 9;
                    break;

                //regla para uruguay
                case (CiudadEnum.Montevideo):
                    return 10;
                    break;

                //regla para Chile
                case (CiudadEnum.Santiago):
                    return 11;
                    break;
                default:
                    return 20;
                    break;
            }
        }

    }
}
