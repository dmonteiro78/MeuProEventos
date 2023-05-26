using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Model;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public EventosController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _dataContext.Eventos.ToList();
        }
    }
}
