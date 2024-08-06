using Microsoft.EntityFrameworkCore;
using ShoppingCRUD_Clean.Domain.Entity;
using ShoppingCRUD_Clean.Domain.Repository;
using ShoppingCRUD_Clean.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCRUD_Clean.Infrastructure.Repository
{
    internal class ShoppingListRepository : IShoppingListRepository
    {
        private readonly ShoppingDbContext _shoppingDbContext;
        public ShoppingListRepository(ShoppingDbContext shoppingDbContext)
        {
            _shoppingDbContext = shoppingDbContext;
        }
        public async Task<ShoppingList> CreateAsync(ShoppingList shoppingList)
        {
            await _shoppingDbContext.ShoppingListItems.AddAsync(shoppingList);
            await _shoppingDbContext.SaveChangesAsync();
            return shoppingList;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _shoppingDbContext.ShoppingListItems
                  .Where(model => model.Id == id)
                  .ExecuteDeleteAsync();
        }

        public async Task<List<ShoppingList>> GetAllBlogsAsync()
        {
            return await _shoppingDbContext.ShoppingListItems.ToListAsync();
        }

        public async Task<List<ShoppingList>> GetAllShoppingListsAsync()
        {
            return await _shoppingDbContext.ShoppingListItems.ToListAsync();
        }

        public Task<ShoppingList> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(int id, ShoppingList shoppingList)
        {
            throw new NotImplementedException();
        }
    }
}
