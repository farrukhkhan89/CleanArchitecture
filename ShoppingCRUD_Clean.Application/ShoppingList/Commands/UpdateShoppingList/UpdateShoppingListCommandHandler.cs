using ShoppingCRUD_Clean.Domain.Entity;
using ShoppingCRUD_Clean.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCRUD_Clean.Application.ShoppingList.Commands.UpdateShoppingList
{
    public class UpdateShoppingListCommandHandler
    {
        private readonly IShoppingListRepository _shoppingRepository;

        public UpdateShoppingListCommandHandler(IShoppingListRepository shoppingRepository)
        {
            _shoppingRepository = shoppingRepository;
        }
        public async Task<int> Handle(UpdateShoppingListCommand request, CancellationToken cancellationToken)
        {
            var updateShoppingListEntity = new ShoppingCRUD_Clean.Domain.Entity.ShoppingList()
            {
                Id = request.Id,
                StarCategory = request.StarCategory,
                ShoppingListCategory = request.ShoppingListCategory,
                Name = request.Name,
                Item = request.Item,
            };

            return await _shoppingRepository.UpdateAsync(request.Id, updateShoppingListEntity);
        }
    }
}
