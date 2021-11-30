using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7_BusinessLogic.Context;

namespace Week7_BusinessLogic.Repositories
{
    public class ItemsRepository: ConnectionDb
    {
        public ItemsRepository() : base() { }

        public List<Item> GetItems()
        {
            //ShoppingCartEntities declared in the connection class (is the base class) represents the database
            //i.e. it is an abstraction of the database

            //approach 1:
            //return Entity.Items.ToList(); //this is not linq

            //approach 2:
            var list = from item in Entity.Items //this is linq //select * from Items
                       select item;


            return list.ToList();
        }

        public List<Item> GetItems(string keyword)
        {
            //approach 1:
            //return Entity.Items.Where(item => item.Name.Contains(keyword)).ToList();

            //approach 2:
            var list = from item in Entity.Items
                       where item.Name.Contains(keyword)
                       select item;
            return list.ToList();
        }
    }
}
