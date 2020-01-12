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
    public class RequestsController : ControllerBase
    {
        

      
        // POST: api/Requests
        [HttpPost]
        public int Post([FromBody] RequestsModel model)
        {
            return RequestsProcessor.CreateRequest(model.Id, model.UserId, model.Request);
        }

       
    }
}
