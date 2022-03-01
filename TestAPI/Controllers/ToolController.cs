using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestAPI.Models;

namespace TestAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController] 
    public class ToolController :ControllerBase
    {
      /*  public IActionResult Index()
        {
            return View();


        }*/
        [HttpPost]
        public HttpResponseMessage AddTool( Tool tool)
        {
            Console.WriteLine("Added Model");
            HttpResponseMessage response = new HttpResponseMessage( System.Net.HttpStatusCode.OK);
            return response;
        }


        [HttpPut]
        public HttpResponseMessage EditTool(String  toolId)
        {
            Console.WriteLine("Added Model");
            HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            return response;
        }


        [HttpDelete]
        public HttpResponseMessage DeleteTool (String toolID)
        {
            Console.WriteLine("Deleted Model");
            HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            return response;
        }






    }
}
