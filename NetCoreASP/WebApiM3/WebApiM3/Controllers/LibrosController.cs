using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiM3.Contexts;
using WebApiM3.Entities;

namespace WebApiM3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public LibrosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/Libros
        [HttpGet]
        public ActionResult<IEnumerable<Libros>> Get()
        {
            //Include cuando existen relaciones entre tablas
            return context.Libros.Include(x => x.Autor).ToList();
        }

        // GET: api/Libros/5
        [HttpGet("{id}", Name = "ObtenerLibro")]
        public ActionResult<Libros> Get(int id)
        {
            var libro = context.Libros.Include(x => x.Autor).FirstOrDefault(x => x.Id == id);

            if (libro == null)
            {
                return NotFound();
            }

            return libro;
        }

        // POST: api/Libros
        [HttpPost]
        public ActionResult Post([FromBody] Libros libro)
        {
            context.Libros.Add(libro);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerLibro", new { id = libro.Id }, libro);
        }

        // PUT: api/Libros/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Libros Libro)
        {
            if (id != Libro.Id)
            {
                return BadRequest();
            }

            context.Entry(Libro).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<Libros> Delete(int id)
        {
            var libro = context.Libros.FirstOrDefault(x => x.Id == id);

            if (libro == null)
            {
                return NotFound();
            }

            context.Libros.Remove(libro);
            context.SaveChanges();
            return libro;
        }
    }
}
