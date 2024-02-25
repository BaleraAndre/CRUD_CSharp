using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Errors
{
    public class InvalidEntityException:Exception
    {
        public Type EntityType;

        public InvalidEntityException(Type entityType, string msg):base(msg) 
        {
            EntityType = entityType;
        }
        
    }
}
