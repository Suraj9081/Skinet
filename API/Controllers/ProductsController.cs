using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Core.Entities;
using Infastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

  

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {

        private readonly  StoreContext _Context;
         public  ProductsController(StoreContext Context)
         {
            _Context =Context;
         }

        [HttpGet]
        public async Task <ActionResult<List<Products>>> GetProducts()
        {

            var Product = await _Context.Product.ToListAsync();
            return Ok(Product);

        }

         [HttpGet("{id}")]
        public async Task<ActionResult<Products>>GetProduct(int id)
        {
           return await _Context.Product.FindAsync(id);

        }

    }
}