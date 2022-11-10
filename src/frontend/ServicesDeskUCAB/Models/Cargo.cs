﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServicesDeskUCAB.Models
{
    public class Cargo
    {
        public int CargoID { get; set; }
        public string NombreDepartamental { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaUltimaEdic { get; set; }
        public DateTime? FechaEliminacion { get; set; }

        public ICollection<TipoCargo> TipoCargo { get; set; }
    }
}
