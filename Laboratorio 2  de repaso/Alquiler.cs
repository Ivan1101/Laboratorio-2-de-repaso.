using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2__de_repaso
{
    class Alquiler
    {
        string nit;
        string placa;
        DateTime fechaalquiler;
        DateTime fechadevolución;

        public string Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime Fechaalquiler { get => fechaalquiler; set => fechaalquiler = value; }
        public DateTime Fechadevolución { get => fechadevolución; set => fechadevolución = value; }
    }
}
