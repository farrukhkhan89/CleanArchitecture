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

namespace ShoppingCRUD_Clean.Application.ShoppingList.Queries.GetShoppingListById
{
    public class GetShoppingListByIdQueryHandler : IRequestHandler<GetShoppingListByIdQuery, ShoppingListVM>
    {
        private readonly IShoppingListRepository _shoppingListRepository;
        private readonly IMapper _mapper;

        public GetShoppingListByIdQueryHandler(IShoppingListRepository shoppingListRepository, IMapper mapper)
        {
            _shoppingListRepository = shoppingListRepository;
            _mapper = mapper;
        }
        public async Task<ShoppingListVM> Handle(GetShoppingListByIdQuery request, CancellationToken cancellationToken)
        {
            var shoppingList = await _shoppingListRepository.GetByIdAsync(request.ShoppingListId);
            return _mapper.Map<ShoppingListVM>(shoppingList);
        }
    }
}
