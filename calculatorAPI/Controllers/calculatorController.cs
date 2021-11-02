using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using calculatorLib;
namespace calculatorAPI.Controllers
{
    [ApiController]
    [Route("[action]")]
    public class calculatorController : ControllerBase
    {

        [HttpGet]
        public double add(double a, double b)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:11293");
            return calculatorLib.Class1.Add(a, b);

        }

        [HttpGet]
        public double sub(double a, double b)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:11293");
            return calculatorLib.Class1.Substract(a, b);
        }

    }

}