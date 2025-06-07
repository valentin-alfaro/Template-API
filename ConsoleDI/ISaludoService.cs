using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDI
{
    internal interface ISaludoService
    {
        Guid Identificador { get; set; }
        string Saludad(string nombre);
    }
}
