using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public class SingleOrderController : ControllerBase
    {
       
        // POST: api/SingleOrder
        [HttpPost]
        public int Post([FromBody] SingleOrderModel model)
        {
            return SingleOrderProcessor.CreateSingleOrder(model.Id, model.CustomerId, model.PaymentType, model.Adress,
                model.DeliveryType, model.Price);
        }

        [HttpGet]
        public Collection<SingleOrderModel> Get()
        {
            return SingleOrderProcessor.GetAllResults();
        }


    }
}
