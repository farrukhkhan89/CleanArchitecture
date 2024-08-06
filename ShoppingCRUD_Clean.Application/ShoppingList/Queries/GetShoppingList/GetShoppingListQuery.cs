using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCRUD_Clean.Application.ShoppingList.Queries.GetShoppingList
{
    public class GetShoppingListQuery : IRequest<List<ShoppingListVM>>
    {

    }

}
