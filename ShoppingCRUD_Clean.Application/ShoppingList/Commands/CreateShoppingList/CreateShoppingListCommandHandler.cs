using AutoMapper;
using MediatR;
using ShoppingCRUD_Clean.Application.ShoppingList.Queries.GetShoppingList;
using ShoppingCRUD_Clean.Domain.Entity;
using ShoppingCRUD_Clean.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCRUD_Clean.Application.ShoppingList.Commands.CreateShoppingList
{
    public class CreateShoppingListCommandHandler : IRequestHandler<CreateShoppingListCommand, ShoppingListVM>
    {
        private readonly IShoppingListRepository _shoppingRepository;
        private readonly IMapper _mapper;

        public CreateShoppingListCommandHandler(IShoppingListRepository shoppingRepository, IMapper mapper)
        {
            _shoppingRepository = shoppingRepository;
            _mapper = mapper;
        }
        public async Task<ShoppingListVM> Handle(CreateShoppingListCommand request, CancellationToken cancellationToken)
        {
            var shoppingListEnity = new ShoppingCRUD_Clean.Domain.Entity.ShoppingList()
            {
                Name = request.Name,
                Description = string.Empty,
                StarCategory = request.StarCategory,
                Item = request.Item,
            };
            var Result = await _shoppingRepository.CreateAsync(shoppingListEnity);
            return _mapper.Map<ShoppingListVM>(Result);
        }
    }
}
