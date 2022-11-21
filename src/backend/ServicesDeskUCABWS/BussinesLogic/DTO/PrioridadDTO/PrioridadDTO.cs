﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ServicesDeskUCABWS.BussinesLogic.DTO.PrioridadDTO
{
    public class PrioridadDTO
    {
        public Guid Id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string descripcion { get; set; } = string.Empty;
        public string estado { get; set; }
        public DateTime fecha_descripcion { get; set; }
        public DateTime fecha_ultima_edic { get; set; }
    }
}