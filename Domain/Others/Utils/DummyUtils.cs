using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Others.Utils
{
    /// <summary>
    /// Clase que mantiene logica auxiliar(aislada) de la logica de negocio. Puede contener: funciones de todo
    /// tipo.
    /// </summary>
    public static class DummyUtils
    {       
        /// <summary>
        /// Metodo de la clase
        ///Ejemplo:
        ///string variable;
        ///variable = DummyUtils.Dummymethod()
        /// </summary>
        public static void DummyMethod()
        {        
        }
        /// <summary>
        /// Metodo de extension
        /// Ejemplo:
        /// srring variable:
        /// variable.DummyExtensionMethod()
        /// </summary>
        public static void DummyExtensionMethod(this string arg, string parameter)
        {
        }
    }
}
