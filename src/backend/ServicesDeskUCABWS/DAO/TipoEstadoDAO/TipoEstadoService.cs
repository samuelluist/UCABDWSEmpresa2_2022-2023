﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ServicesDeskUCABWS.Data;
using ServicesDeskUCABWS.Exceptions;
using ServicesDeskUCABWS.Models;
using ServicesDeskUCABWS.Models.DTO.PlantillaDTO;
using ServicesDeskUCABWS.Models.DTO.TipoEstadoDTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicesDeskUCABWS.DAO.TipoEstadoDAO
{
    public class TipoEstadoService:ITipoEstadoDAO
    {
        private readonly DataContext _tipoEstadoContext;
        private readonly IMapper _mapper;

        public TipoEstadoService(DataContext plantillaContext, IMapper mapper)
        {
            _tipoEstadoContext = plantillaContext;
            _mapper = mapper;
        }

        //GET: Servicio para consultar todos los tipos estados
        public List<TipoEstadoSearchDTO> ConsultaTipoEstados()
        {
            try
            {
                var data = _tipoEstadoContext.Tipos_Estados.AsNoTracking().Include(t => t.Etiqueta);
                var tipoEstadoSearchDTO = _mapper.Map<List<TipoEstadoSearchDTO>>(data);
                return tipoEstadoSearchDTO.ToList();
            }catch(Exception ex)
            {
                throw new ExceptionsControl("Hubo un problema en la consulta", ex);
            }
        }

        //GET: Servicio para consultar una plantilla notificacion en especifico
        public TipoEstadoSearchDTO ConsultarTipoEstadoGUID(Guid id)
        {
            try
            {
                var data = _tipoEstadoContext.Tipos_Estados.AsNoTracking().Include(t => t.Etiqueta).Where(t => t.Id == id).Single();
                var tipoEstadoSearchDTO = _mapper.Map<TipoEstadoSearchDTO>(data);
                return tipoEstadoSearchDTO;
            }
            catch (Exception ex)
            {
                throw new ExceptionsControl("No existe el tipo estado con ese ID", ex);
            }

        }

        //GET: Servicio para consultar una tipo estado por un título específico
        public List<TipoEstadoSearchDTO> ConsultarTipoEstadoTitulo(string titulo)
        {
            try
            {
                var data = _tipoEstadoContext.Tipos_Estados.AsNoTracking().Include(t => t.Etiqueta).Where(t => t.nombre == titulo);
                var tipoEstadoSearchDTO = _mapper.Map<List<TipoEstadoSearchDTO>>(data);
                return tipoEstadoSearchDTO.ToList();
            }
            catch (Exception ex)
            {
                throw new ExceptionsControl("No existe la tipo estado con ese título", ex);
            }
        }

        //POST: Servicio para crear tipo estado
        public Boolean RegistroTipoEstado(Tipo_Estado tipoEstado)
        {
            try
            {
                _tipoEstadoContext.Tipos_Estados.Add(tipoEstado);
                _tipoEstadoContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new ExceptionsControl("No se pudo registrar la tipo estado", ex);
            }
        }

        //DELETE: Servicio para eliminar plantilla notificacion
        public Boolean EliminarTipoEstado(Guid id)
        {
            try
            {
                var tipoEstado = _tipoEstadoContext.Tipo_Estados.Include(t => t.Etiqueta).Where(t => t.Id == id).Single();
                _tipoEstadoContext.Tipo_Estados.Remove(tipoEstado);
                _tipoEstadoContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new ExceptionsControl("No se pudo eliminar el tipo de estado", ex);
            }

        }
    }
}