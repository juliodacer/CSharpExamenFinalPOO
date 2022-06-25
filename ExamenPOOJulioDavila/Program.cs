using ExamenPOOJulioDavila;
using System.Collections;

namespace HerenciaPOO
{
    class Program
    {
        static void Main(String[] argas)
        {
            ArrayList animales = new ArrayList();

            Perro perro = new Perro();
            perro.Sonidos = "Ladrido";
            perro.Alimento = "Carnivoro";
            perro.NombreCientifico = "Canis Lupus familiaris";

            Lobo lobo = new Lobo();
            lobo.Sonidos = "Aullido";
            lobo.Alimento = "Carnivora";
            lobo.NombreCientifico = "Canis lupus";

            Leon leon = new Leon();
            leon.Sonidos = "Rugido";
            leon.Alimento = "Carnivoro";
            leon.NombreCientifico = "Panthera leo";

            Gato gato = new Gato();
            gato.Sonidos = "Maullido";
            gato.Alimento = "Ratones";
            gato.NombreCientifico = "Felis silvestrus catus";

            animales.Add(perro);
            animales.Add(lobo);
            animales.Add(leon);
            animales.Add(gato);

            foreach (Animal animal in animales)
            {
                Console.WriteLine("Animal: " + animal.NombreCientifico + "\t\t Alimento: " +
                animal.Alimento + "\t\t Sonido: " + animal.Sonidos);
             
            }

        }
    }
}