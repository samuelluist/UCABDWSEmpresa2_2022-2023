﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicesDeskUCABWS.BussinesLogic.Recursos {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErroresVotos {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErroresVotos() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ServicesDeskUCABWS.BussinesLogic.Recursos.ErroresVotos", typeof(ErroresVotos).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El comentario no puede ser mayor a 300 caracteres.
        /// </summary>
        public static string COMENTARIO_FUERA_RANGO {
            get {
                return ResourceManager.GetString("COMENTARIO_FUERA_RANGO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El ticket ingresado no se encuentra registrado en el sistema .
        /// </summary>
        public static string ERROR_TICKET_DESC {
            get {
                return ResourceManager.GetString("ERROR_TICKET_DESC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El usuario no está registrado en el sistema .
        /// </summary>
        public static string ERROR_USUARIO_DESC {
            get {
                return ResourceManager.GetString("ERROR_USUARIO_DESC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El formato ingresado para el ID del usuario  o elticket no es valido.
        /// </summary>
        public static string FORMATO_NO_VALIDO {
            get {
                return ResourceManager.GetString("FORMATO_NO_VALIDO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Su turno de votación ha expirado, no puede ingresar este voto.
        /// </summary>
        public static string VOTACION_EXPIRADA {
            get {
                return ResourceManager.GetString("VOTACION_EXPIRADA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Usted no tiene los permisos para participar en esta votación.
        /// </summary>
        public static string VOTO_NO_PERMITIDO {
            get {
                return ResourceManager.GetString("VOTO_NO_PERMITIDO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El voto ingresado no es valido, el voto debe ser &quot;Aprobado&quot;, &quot;Rechazado&quot; o &quot;Pendiente&quot;.
        /// </summary>
        public static string VOTO_NO_VALIDO {
            get {
                return ResourceManager.GetString("VOTO_NO_VALIDO", resourceCulture);
            }
        }
    }
}
