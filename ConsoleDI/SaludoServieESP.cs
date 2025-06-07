using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDI
{
    internal class SaludoServieESP : ISaludoService
    {
{
        public Guid Identificador { get; set; }

        public string Saludad(string nombre)
        {
            return$"Hola! Encantado de saludarte {nombre}";
        }
    }
}
}
