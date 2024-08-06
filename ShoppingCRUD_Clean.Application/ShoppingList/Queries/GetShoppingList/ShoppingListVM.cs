using ShoppingCRUD_Clean.Application.Common.Mappings;
using ShoppingCRUD_Clean.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ShoppingCRUD_Clean.Application.ShoppingList.Queries.GetShoppingList
{
    public class ShoppingListVM: IMapFrom<ShoppingCRUD_Clean.Domain.Entity.ShoppingList>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool StarCategory { get; set; }

        public List<Item> Item { get; set; }
        public Category ShoppingListCategory { get; set; }
    }
}
