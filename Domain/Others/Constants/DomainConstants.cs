using Domain.Others.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Others.Constants
{
    /// <summary>
    /// Clase que almacena las contantes utilizadas en la capa de DOMINIO.
    /// </summary>
    internal static class DomainConstants //Nos va a permitir acceder a la clase sin tener que instanciarla.
    {
        public const string DUMMY_CONSTANTS = "DUMMY_CONSTANTS";//Creamos una constante dentro para poder hacer uso de los mejs hardcodeados
    }
    /*DomainConstants instance = new DomainConstants();*///Para evitar esto
    /*public class LALALA 
    {
        public void Method()
        {
            DummyUtils.DummyMethod();
            string variable = string.Empty;
            variable.DummyExtensionMethod("lalala");
        }
    }*/
}
