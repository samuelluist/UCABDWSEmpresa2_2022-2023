﻿using System;

namespace ServicesDeskUCABWS.BussinesLogic.DTO
{
    public class PrioridadDTO
    {
        public Guid Id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string descripcion { get; set; }
        public DateTime fecha_descripcion { get; set; }
        public DateTime fecha_ultima_edic { get; set; }
        public string estado { get; set; }
    }
}