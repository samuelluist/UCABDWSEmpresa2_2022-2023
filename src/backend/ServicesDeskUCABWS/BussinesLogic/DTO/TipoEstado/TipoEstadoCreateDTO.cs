﻿using ServicesDeskUCABWS.BussinesLogic.DTO.EtiquetaTipoEstado;
using ServicesDeskUCABWS.BussinessLogic.DTO.Etiqueta;
using ServicesDeskUCABWS.Entities;
using System.Collections.Generic;

namespace ServicesDeskUCABWS.BussinessLogic.DTO.TipoEstado
{
    public class TipoEstadoCreateDTO
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public HashSet<EtiquetaDTO> etiqueta { get; set; }
    }
}