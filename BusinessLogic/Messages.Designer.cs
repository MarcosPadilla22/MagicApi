﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessLogic {
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
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BusinessLogic.Messages", typeof(Messages).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a La afinidad es requerida.
        /// </summary>
        internal static string AffinityRequired {
            get {
                return ResourceManager.GetString("AffinityRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a La edad es requerida.
        /// </summary>
        internal static string AgeRequired {
            get {
                return ResourceManager.GetString("AgeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a La edad solo permite numeros y tiene una longitud maxima de 2 caracteres.
        /// </summary>
        internal static string AgeValidation {
            get {
                return ResourceManager.GetString("AgeValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a La Identificacion es requerida.
        /// </summary>
        internal static string IdentificationRequired {
            get {
                return ResourceManager.GetString("IdentificationRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a La identificacion solo permite numero, letras y una longitud maxima de 10 caracteres.
        /// </summary>
        internal static string IdentificationValidation {
            get {
                return ResourceManager.GetString("IdentificationValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El nombre es requerido.
        /// </summary>
        internal static string NameRequired {
            get {
                return ResourceManager.GetString("NameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El nombre  solo permite letras y una longitud maxima de 20 caracteres.
        /// </summary>
        internal static string NameValidation {
            get {
                return ResourceManager.GetString("NameValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El apellido es requerido.
        /// </summary>
        internal static string SurnameRequired {
            get {
                return ResourceManager.GetString("SurnameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El apellido solo permite letras y una longitud maxima de 20 caracteres.
        /// </summary>
        internal static string SurnameValidation {
            get {
                return ResourceManager.GetString("SurnameValidation", resourceCulture);
            }
        }
    }
}
