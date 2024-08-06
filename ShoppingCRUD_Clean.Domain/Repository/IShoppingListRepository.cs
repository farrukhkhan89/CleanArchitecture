using ShoppingCRUD_Clean.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCRUD_Clean.Domain.Repository
{
    public interface IShoppingListRepository
    {
        Task<List<ShoppingList>> GetAllShoppingListsAsync();
        Task<ShoppingList> GetByIdAsync(int id);
        Task<ShoppingList> CreateAsync(ShoppingList shoppingList);
        Task<int> UpdateAsync(int id, ShoppingList shoppingList);
        Task<int> DeleteAsync(int id);
    }
}
