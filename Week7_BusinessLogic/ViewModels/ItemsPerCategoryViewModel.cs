using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_BusinessLogic.ViewModels
{
    public class ItemsPerCategoryViewModel
    {
        public string CategoryName { get; set; }

        public int ItemsCount { get; set; }

        public decimal AvgPrice { get; set; }
    }
}
