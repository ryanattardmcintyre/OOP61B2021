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
        //it is an access point to my database represented as a property with the name Entity
        //Entity will help in accessing data in tables in the database
        public ShoppingCartEntities Entity { get; set; }

        public ConnectionDb()
        {
            Entity = new ShoppingCartEntities(); //initializing the "access point"

        }

    }
}
