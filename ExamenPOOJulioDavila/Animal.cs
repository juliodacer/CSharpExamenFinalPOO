using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOOJulioDavila
{
    public class Animal
    {
        private string _sonidos;
        private string _alimento;
        private string _nombreCientifico;

        public string Sonidos 
        { 
            get { return _sonidos; }
            set { _sonidos = value; }
        }

        public string Alimento
        {
            get { return _alimento; }   
            set { _alimento = value; }
        }

        public string NombreCientifico
        {
            get { return _nombreCientifico; }
            set { _nombreCientifico = value; }
        }
    }
}
