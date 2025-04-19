using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Entities.Exceptions
{
     class DomainException : ApplicationException
    {
        //Exceção personalizada para o domínio do sistema
        public DomainException(string message) : base(message) { }
    }
}
