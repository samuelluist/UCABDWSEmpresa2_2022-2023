﻿using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ServicesDeskUCABWS.BussinesLogic.DTO.Usuario;
using ServicesDeskUCABWS.BussinesLogic.Exceptions;
using ServicesDeskUCABWS.BussinesLogic.Mapper.UserMapper;
using ServicesDeskUCABWS.Data;
using ServicesDeskUCABWS.Entities;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ServicesDeskUCABWS.BussinesLogic.DAO.UserRolDAO
{
    public class UserRolDAO : IUserRol
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public UserRolDAO(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public RolUsuarioDTO AgregarRol(RolUsuario rolUsuario)
        {
            try
            {

                _dataContext.RolUsuarios.Add(rolUsuario);
                _dataContext.SaveChanges();

                var nuevoRolUsuario = _dataContext.RolUsuarios.Where(rolu => rolu.UserId == rolUsuario.UserId && rolu.RolId == rolUsuario.RolId)
                                        .Select(d => new RolUsuarioDTO
                                        {
                                            idusuario = d.UserId,
                                            idrol = d.UserId,
                                        });

                return nuevoRolUsuario.First();
            }

            catch (Exception ex)
            {
                throw new ExceptionsControl("Uno de los id (Usuario o rol) es invalido", ex);
            }


        }

        public RolUsuarioDTO consularRolID(Guid usuario)
        {
            try
            {
                var data = _dataContext.RolUsuarios.AsNoTracking().Where(p => p.UserId == usuario).Single();
                var user = new RolUsuarioDTO { idrol = data.RolId,idusuario = data.UserId };
                return user;
            }
            catch (Exception ex)
            {
                throw new ExceptionsControl("No existe la plantilla con ese ID", ex);
            }
        }

        public RolUsuarioDTO EliminarRol(Guid user, Guid Rol)
        {
            try
            {
                var rolusuario = _dataContext.RolUsuarios
                .Where(u => u.UserId == user && u.RolId == Rol).First();

                _dataContext.RolUsuarios.Remove(rolusuario);
                _dataContext.SaveChanges();

                return UserRolMapper.MapperEntityToDtoUR(rolusuario);

            }
            catch (Exception ex)
            {
                throw new ExceptionsControl("Uno de los id (Usuario o rol) es invalido", ex);
            }
        }

        public List<RolUsuarioDTO> ObtenerUsuariosRoles()
        {
            try
            {

                var lista = _dataContext.RolUsuarios.Select(
                    roluser => new RolUsuarioDTO
                    {
                        idrol = roluser.RolId,
                        idusuario = roluser.UserId,
                    });


                return lista.ToList();

            }
            catch (Exception ex)
            {
                throw new ExceptionsControl("Algo salio mal en la consulta", ex);
            }
        }
    }
}
