﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServicesDeskUCABWS.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Etiquetas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etiquetas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Familia_Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familia_Tickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_ultima_edicion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    fecha_eliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Prioridades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fecha_descripcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_ultima_edic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prioridades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Cargos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    nivel_jerarquia = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_ult_edic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_eliminacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Cargos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Estados",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    permiso = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_ult_edic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_elim = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Minimo_Aprobado = table.Column<int>(type: "int", nullable: true),
                    Maximo_Rechazado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Tickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EtiquetasTipoEstados",
                columns: table => new
                {
                    etiquetaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tipoEstadoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtiquetasTipoEstados", x => new { x.etiquetaID, x.tipoEstadoID });
                    table.ForeignKey(
                        name: "FK_EtiquetasTipoEstados_Etiquetas_etiquetaID",
                        column: x => x.etiquetaID,
                        principalTable: "Etiquetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EtiquetasTipoEstados_Tipos_Estados_tipoEstadoID",
                        column: x => x.tipoEstadoID,
                        principalTable: "Tipos_Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlantillasNotificaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoEstadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantillasNotificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlantillasNotificaciones_Tipos_Estados_TipoEstadoId",
                        column: x => x.TipoEstadoId,
                        principalTable: "Tipos_Estados",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_ultima_edicion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    fecha_eliminacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_grupo = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tipo_TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Departamentos_Grupos_id_grupo",
                        column: x => x.id_grupo,
                        principalTable: "Grupos",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Departamentos_Tipos_Tickets_Tipo_TicketId",
                        column: x => x.Tipo_TicketId,
                        principalTable: "Tipos_Tickets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Flujos_Aprobaciones",
                columns: table => new
                {
                    IdTipo_cargo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTicket = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo_CargoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tipo_TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrdenAprobacion = table.Column<int>(type: "int", nullable: true),
                    Minimo_aprobado_nivel = table.Column<int>(type: "int", nullable: true),
                    Maximo_Rechazado_nivel = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flujos_Aprobaciones", x => new { x.IdTicket, x.IdTipo_cargo });
                    table.ForeignKey(
                        name: "FK_Flujos_Aprobaciones_Tipos_Cargos_Tipo_CargoId",
                        column: x => x.Tipo_CargoId,
                        principalTable: "Tipos_Cargos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Flujos_Aprobaciones_Tipos_Tickets_Tipo_TicketId",
                        column: x => x.Tipo_TicketId,
                        principalTable: "Tipos_Tickets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre_departamental = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_ultima_edicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_eliminacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tipo_CargoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Departamentoid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cargos_Departamentos_Departamentoid",
                        column: x => x.Departamentoid,
                        principalTable: "Departamentos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cargos_Tipos_Cargos_Tipo_CargoId",
                        column: x => x.Tipo_CargoId,
                        principalTable: "Tipos_Cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_ultima_edic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado_PadreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Departamentoid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estados_Departamentos_Departamentoid",
                        column: x => x.Departamentoid,
                        principalTable: "Departamentos",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Estados_Tipos_Estados_Estado_PadreId",
                        column: x => x.Estado_PadreId,
                        principalTable: "Tipos_Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cedula = table.Column<int>(type: "int", nullable: false),
                    primer_nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    segundo_nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    primer_apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    segundo_apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fecha_nacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_ultima_edicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_eliminacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDeCuentasBloqueadas = table.Column<int>(type: "int", nullable: true),
                    CargoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RolUsuarios",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolUsuarios", x => new { x.UserId, x.RolId });
                    table.ForeignKey(
                        name: "FK_RolUsuarios_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolUsuarios_Usuarios_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_eliminacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PrioridadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo_TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Departamento_Destinoid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Familia_TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ticket_PadreId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmisorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    nro_cargo_actual = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Departamentos_Departamento_Destinoid",
                        column: x => x.Departamento_Destinoid,
                        principalTable: "Departamentos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Familia_Tickets_Familia_TicketId",
                        column: x => x.Familia_TicketId,
                        principalTable: "Familia_Tickets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Prioridades_PrioridadId",
                        column: x => x.PrioridadId,
                        principalTable: "Prioridades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Tickets_Ticket_PadreId",
                        column: x => x.Ticket_PadreId,
                        principalTable: "Tickets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Tipos_Tickets_Tipo_TicketId",
                        column: x => x.Tipo_TicketId,
                        principalTable: "Tipos_Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Usuarios_EmisorId",
                        column: x => x.EmisorId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Bitacora_Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha_Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Fin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bitacora_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bitacora_Tickets_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bitacora_Tickets_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votos_Tickets",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTicket = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    voto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    comentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Turno = table.Column<int>(type: "int", nullable: true),
                    EmpleadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votos_Tickets", x => new { x.IdUsuario, x.IdTicket });
                    table.ForeignKey(
                        name: "FK_Votos_Tickets_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Votos_Tickets_Usuarios_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bitacora_Tickets_EstadoId",
                table: "Bitacora_Tickets",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Bitacora_Tickets_TicketId",
                table: "Bitacora_Tickets",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_Departamentoid",
                table: "Cargos",
                column: "Departamentoid");

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_Tipo_CargoId",
                table: "Cargos",
                column: "Tipo_CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_id_grupo",
                table: "Departamentos",
                column: "id_grupo");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_nombre",
                table: "Departamentos",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_Tipo_TicketId",
                table: "Departamentos",
                column: "Tipo_TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Estados_Departamentoid",
                table: "Estados",
                column: "Departamentoid");

            migrationBuilder.CreateIndex(
                name: "IX_Estados_Estado_PadreId",
                table: "Estados",
                column: "Estado_PadreId");

            migrationBuilder.CreateIndex(
                name: "IX_EtiquetasTipoEstados_tipoEstadoID",
                table: "EtiquetasTipoEstados",
                column: "tipoEstadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Flujos_Aprobaciones_Tipo_CargoId",
                table: "Flujos_Aprobaciones",
                column: "Tipo_CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Flujos_Aprobaciones_Tipo_TicketId",
                table: "Flujos_Aprobaciones",
                column: "Tipo_TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_nombre",
                table: "Grupos",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlantillasNotificaciones_TipoEstadoId",
                table: "PlantillasNotificaciones",
                column: "TipoEstadoId",
                unique: true,
                filter: "[TipoEstadoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RolUsuarios_RolId",
                table: "RolUsuarios",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Departamento_Destinoid",
                table: "Tickets",
                column: "Departamento_Destinoid");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EmisorId",
                table: "Tickets",
                column: "EmisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EstadoId",
                table: "Tickets",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Familia_TicketId",
                table: "Tickets",
                column: "Familia_TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PrioridadId",
                table: "Tickets",
                column: "PrioridadId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Ticket_PadreId",
                table: "Tickets",
                column: "Ticket_PadreId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Tipo_TicketId",
                table: "Tickets",
                column: "Tipo_TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CargoId",
                table: "Usuarios",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_correo",
                table: "Usuarios",
                column: "correo",
                unique: true,
                filter: "[correo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Votos_Tickets_EmpleadoId",
                table: "Votos_Tickets",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Votos_Tickets_TicketId",
                table: "Votos_Tickets",
                column: "TicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bitacora_Tickets");

            migrationBuilder.DropTable(
                name: "EtiquetasTipoEstados");

            migrationBuilder.DropTable(
                name: "Flujos_Aprobaciones");

            migrationBuilder.DropTable(
                name: "PlantillasNotificaciones");

            migrationBuilder.DropTable(
                name: "RolUsuarios");

            migrationBuilder.DropTable(
                name: "Votos_Tickets");

            migrationBuilder.DropTable(
                name: "Etiquetas");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Familia_Tickets");

            migrationBuilder.DropTable(
                name: "Prioridades");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Tipos_Estados");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Tipos_Cargos");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Tipos_Tickets");
        }
    }
}
