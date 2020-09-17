using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecondAPIForSummerSchool.Models;

namespace SecondAPIForSummerSchool.Controllers
{
    //[Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;
        public ProductsController(ShopContext context)
        {
            _context = context;
            // The <context class>.Database.EnsureData() call seeds the data, if that hasn't happened before.
            _context.Database.EnsureCreated();
        }

        //Example 1
        //[HttpGet]
        //public string GetProducts()
        //{
        //    return "OK. SummerSchool";
        //}

        // Example 2: returning a list of items
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        // Example 3: Using IActionResult
        // The okay helper method returns, HTTP status code of 200, 
        // and you may recall that, okay, 
        // is the text description of that HTTP status code, 
        // plus the actual product in JSON format.
        //[HttpGet]
        //public IActionResult GetAllProducts()
        //{
        //    var products = _context.Products.ToList();
        //    return Ok(products);
        //}

        // Example 4: Returning an Item
        //[HttpGet, Route("{id}")]
        //public IActionResult GetAllProducts(int id)
        //{
        //    var product = _context.Products.Find(id);
        //    return Ok(product);
        //}

        //Example 5: Handling errors
        //[HttpGet, Route("{id:int}")]
        //public IActionResult GetAllProducts2(int id)
        //{
        //    var product = _context.Products.Find(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}

        // Example 6: the resource here, this URI doesn't exist.
        [HttpGet, Route("{id:int}")]
        public IActionResult GetAllProducts(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // Example 7: Adding an item with POST
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct([FromBody] Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostProduct", new { id = product.Id }, product);
        }

        // Example 8: Updating an item with PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct([FromRoute] int id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_context.Products.Find(id) == null)
                {
                    return NotFound();
                }

                throw;
            }

            return NoContent();
        }

        // Example 8: Deleting an item with DELETE
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }
    }
}
