using APIPersonajesAWS.Models;
using APIPersonajesAWS.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPersonajesAWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajesController : ControllerBase
    {
        private RepositoryPersonajes repo;

        public PersonajesController(RepositoryPersonajes repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Personaje>> GetPersonajes()
        {
            return this.repo.GetPersonajes();
        }

        [HttpGet("{id}")]
        public ActionResult<Personaje> FindPersonaje(int id)
        {
            return this.repo.FindPersonaje(id);
        }

        [HttpPost]
        public ActionResult InsertarPersonaje(Personaje personaje)
        {
            this.repo.InsertPersonaje(personaje.IdPersonaje, personaje.Nombre, personaje.Imagen);
            return Ok();
        }
    }
}
