using MediatR;
using ShoppingCRUD_Clean.Application.ShoppingList.Queries.GetShoppingList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCRUD_Clean.Application.ShoppingList.Queries.GetShoppingListById
{
    public class GetShoppingListByIdQuery : IRequest<ShoppingListVM>
    {
        public int ShoppingListId { get; set; }
    }
}
