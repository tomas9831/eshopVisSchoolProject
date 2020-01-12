using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Model;
using DataLibrary;
using DataLibrary.BussinessLogic;
using System.Collections.ObjectModel;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // POST: api/User
        [HttpPost]
        public int Post([FromBody] UserModel model)
        {
            return UserProcessor.CreateUser(model.Id, model.Email, model.Name,
                model.Surname, model.Phone, model.Adress, model.BirthDate, model.Verified, model.Password, model.UserType);
        }
        // GET: api/User
        [HttpGet]
        public Collection<DataLibrary.Models.UserModel> Get()
        {
            return UserProcessor.GetAllResults();
        }

    }
}
