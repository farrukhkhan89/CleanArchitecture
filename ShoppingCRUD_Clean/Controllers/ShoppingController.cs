using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCRUD_Clean.Application.ShoppingList.Commands.CreateShoppingList;
using ShoppingCRUD_Clean.Application.ShoppingList.Commands.UpdateShoppingList;
using ShoppingCRUD_Clean.Application.ShoppingList.Queries.GetShoppingList;
using ShoppingCRUD_Clean.Application.ShoppingList.Queries.GetShoppingListById;

namespace ShoppingCRUD_Clean.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var shoppingList = await Mediator.Send(new GetShoppingListQuery());
            return Ok(shoppingList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var shoppingList = await Mediator.Send(new GetShoppingListByIdQuery() { ShoppingListId = id });
            if (shoppingList == null)
            {
                return NotFound();
            }
            return Ok(shoppingList);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateShoppingListCommand command)
        {
            var createdShoppingList= await Mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = createdShoppingList.Id }, createdShoppingList);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateShoppingListCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            //var result = await Mediator.Send(new DeleteBlogCommand { Id = id });
            //if (result == 0)
            //{
            //    return BadRequest();
            //}
            return NoContent();
        }
    }
}
