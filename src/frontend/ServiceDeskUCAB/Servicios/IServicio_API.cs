﻿using ServiceDeskUCAB.Models.ModelsVotos;
using ServiceDeskUCAB.Models.Response;
using ServiceDeskUCAB.Models.TipoTicketsModels;

namespace ServiceDeskUCAB.Servicios
{
    public interface IServicio_API
    {

        Task<List<Tipo>> Lista();
        // Task<bool> AgregarTicket(NuevoTicket ticket);
        Task<ApplicationResponse<Votos_Ticket>> VotarTicket(VotarTicket voto_ticket);
        Task<List<Ticket>> ListaTickets();

        Task<List<Prioridad>> ObtenerPrioridades();
        Task<bool> AgregarTicket(NuevoTicket ticket);

        Task<ApplicationResponse<Tipo_TicketDTOCreate>> Guardar(Tipo_TicketDTOCreate tipo);

       
        Task<bool> Eliminar(Guid id);

        Task<List<Departament>> ListaDepa();

        Task<List<TipoCargo>> ListaCargos();

        Task<List<Votos_Ticket>> ObtenerVotos();

        Task<Ticket> ObtenerTicket(string id);
        Task<ApplicationResponse<Tipo_TicketDTOUpdate>> Actualizar(Tipo_TicketDTOUpdate tipoTicketDTO);
    }
}
