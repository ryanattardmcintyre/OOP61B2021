using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7_BusinessLogic.Context;

namespace Week7_BusinessLogic.Repositories
{
    public class ConnectionDb
    {
        public ShoppingCartEntities Entity { get; set; }

        public ConnectionDb()
        {
            Entity = new ShoppingCartEntities();
        }

    }
}
