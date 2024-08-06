using AutoMapper;
using MediatR;
using ShoppingCRUD_Clean.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCRUD_Clean.Application.ShoppingList.Queries.GetShoppingList
{
    public class GetShoppingListQueryHandler : IRequestHandler<GetShoppingListQuery, List<ShoppingListVM>>
    {
        private readonly IShoppingListRepository _shoppingListRepository;
        private readonly IMapper _mapper;
        public GetShoppingListQueryHandler(IShoppingListRepository shoppingListRepository, IMapper mapper)
        {
            _shoppingListRepository = shoppingListRepository;
            _mapper = mapper;
        }
        public async Task<List<ShoppingListVM>> Handle(GetShoppingListQuery request, CancellationToken cancellationToken)
        {
            var shopList = await _shoppingListRepository.GetAllShoppingListsAsync();
            //var shoppingListVM = shopList.Select(x => new ShoppingListVM
            //{
            //    Name = x.Name,
            //    Description = x.Description,
            //    Id = x.Id,

            //}).ToList();

            var shoppingList = _mapper.Map<List<ShoppingListVM>>(shopList);
            return shoppingList;
        }
    }


}
