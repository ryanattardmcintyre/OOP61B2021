using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7_BusinessLogic.Context;



namespace Week7_BusinessLogic.Repositories
{
    public enum SortCriteria {Name, Price }

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

        public List<Item> Sort(SortCriteria criterion, bool asc)
        { 
            switch(criterion)
            {
                case SortCriteria.Name:
                    //return Entity.Items.OrderBy(x => x.Name).ToList();

                    if (asc)
                    {
                        var list = from item in Entity.Items
                                   orderby item.Name ascending
                                   select item;
                        return list.ToList();
                    }
                    else
                    {
                        var list = from item in Entity.Items
                                   orderby item.Name descending
                                   select item;
                        return list.ToList();
                    }

                case SortCriteria.Price:
                    if (asc)
                    {
                        return Entity.Items.OrderBy(x => x.Price).ToList();
                    }
                    else
                    {
                        return Entity.Items.OrderByDescending(x => x.Price).ToList();
                    }
                     
            }
            return Entity.Items.OrderBy(x => x.Name).ToList();
        }

        public void Add(Item i)
        {
            Entity.Items.Add(i);//this will save the item within the application (in memory)
            Entity.SaveChanges();//this will save permanently the item in the db
        }


        public Item GetItem(int id)
        {
            return Entity.Items.SingleOrDefault(x =>x.Id == id);
        }

        public void Update(int id, string name, int categoryId, decimal price)
        {
            var originalItem = GetItem(id);
            originalItem.Name = name;
            originalItem.CategoryId = categoryId;
            originalItem.Price = price;

            Entity.SaveChanges();
        }

        public void Delete(int id)
        {
            var itemToDelete = GetItem(id);
            Entity.Items.Remove(itemToDelete);
            Entity.SaveChanges();

        }
         

        
    }
}
