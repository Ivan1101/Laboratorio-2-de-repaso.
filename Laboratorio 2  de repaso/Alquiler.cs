﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2__de_repaso
{
    class Alquiler: Vehiculos
    {
        string nombre;
        DateTime fechad;
        float total;

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fechad { get => fechad; set => fechad = value; }
        public float Total { get => total; set => total = value; }
    }
}
