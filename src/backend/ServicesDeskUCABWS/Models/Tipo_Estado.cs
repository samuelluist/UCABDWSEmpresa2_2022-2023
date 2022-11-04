﻿using ProyectD.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace ServicesDeskUCABWS.Models
{
    public class Tipo_Estado
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(150)]
        public string descripcion { get; set; } = string.Empty;

        public HashSet<Etiqueta> Etiqueta { get; set; }

        public PlantillaNotificacion PlantillaNotificacion { get; set; }
        
        public HashSet<Estado> ListaEstadosDerivados { get; set; }
    }
}