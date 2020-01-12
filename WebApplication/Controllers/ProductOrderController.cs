using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.BussinessLogic;
using DataLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOrderController : ControllerBase
    {
       

        // POST: api/ProductOrder
        [HttpPost]
        public int Post([FromBody] ProductOrderModel model)
        {
            return ProductOrderProcessor.CreateProductOrder(model.Id, model.ProductId, model.OrderId);
        }

    }
}
