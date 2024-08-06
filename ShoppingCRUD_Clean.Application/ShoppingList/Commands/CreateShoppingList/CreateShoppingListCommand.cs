using MediatR;
using ShoppingCRUD_Clean.Application.ShoppingList.Queries.GetShoppingList;
using ShoppingCRUD_Clean.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCRUD_Clean.Application.ShoppingList.Commands.CreateShoppingList
{
    public class CreateShoppingListCommand : IRequest<ShoppingListVM>
    {
        public string Name { get; set; }
        public bool StarCategory { get; set; }

        public List<Item> Item { get; set; }
        public Category ShoppingListCategory { get; set; }
    }
}
