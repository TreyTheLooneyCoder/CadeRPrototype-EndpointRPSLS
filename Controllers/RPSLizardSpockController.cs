using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadeRPrototype_EndpointRPSLS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadeRPrototype_EndpointRPSLS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RPSLizardSpockController : ControllerBase
    {
        private readonly RPSLizardSpockServices _rPSLizardSpockServices;
        public RPSLizardSpockController(RPSLizardSpockServices rPSLizardSpockServices)
        {
            _rPSLizardSpockServices = rPSLizardSpockServices;
        }

        [HttpGet]
        [Route("RPS/{userChoice}")]

        public string lizardSpock(string userChoice)
        {
            return _rPSLizardSpockServices.lizardSpock(userChoice);
        }
        
    }
}