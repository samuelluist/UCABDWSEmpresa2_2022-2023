﻿using ServiceDeskUCAB.Models;

namespace ServiceDeskUCAB.ViewModel.DepartamentoGrupo
{
    public class GrupoEditarViewModel
    {
        public List<DepartamentoModel> deptAsociado { get; set; }
        public  List<DepartamentoModel> departamento { get; set; }
        public  GrupoModel grupo { get; set; }

    }
}
