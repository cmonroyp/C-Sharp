using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiModulo5.Contexts;
using WebApiModulo5.Entities;
using WebApiModulo5.Models;

namespace WebApiModulo5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public AutoresController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        // GET api/autores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AutorDTO>>> Get()
        {
            var autores = await context.Autores.ToListAsync();
            var autoresDTO = mapper.Map<List<AutorDTO>>(autores);
            return autoresDTO;
        }

        /* el AutorDTO es el responsable de mostrar la informacion que queremos al cliente y la entidad Autor, es la encargada
          de servir como entidad a la base de datos, aqui se dejan responsabilidades unicas, principio de responsabilidad unica
        */
        //ObtenerAutor nombre de las reglas de ruteo
        // GET api/autores/5 
        [HttpGet("{id}", Name = "ObtenerAutor")]
        public async Task<ActionResult<AutorDTO>> Get(int id)
        {
            var autor = await context.Autores.FirstOrDefaultAsync(x => x.Id == id);

            if (autor == null)
            {
                return NotFound();
            }

            //automapper permite hacer mapeo de propiedades por nosotros
            var autorDTO = mapper.Map<AutorDTO>(autor);

            return autorDTO;
        }

        // POST api/autores
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AutorCreacionDTO autorCreacion)
        {
            var autor = mapper.Map<Autor>(autorCreacion);
            context.Add(autor);
            await context.SaveChangesAsync();
            var autorDTO = mapper.Map<AutorDTO>(autor);

            //CreatedAtRouteResult crea la respuesta correcta desde nuestro web api, en la cabecera mostrara el nuevo recurso creado
            ///ObtenerAutor cabecera location 
            return new CreatedAtRouteResult("ObtenerAutor", new { id = autor.Id }, autorDTO);
        }

        //actualiza todos los campos de las propiedades existentes en la clase AutorCreacionDTO
        // PUT api/autores/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] AutorCreacionDTO autorActualizacion)
        {
            var autor = mapper.Map<Autor>(autorActualizacion);
            autor.Id = id;
            context.Entry(autor).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        //realiza actualizaciones parciales a un recusros, un ejemplo solo actualizar la fecha
        [HttpPatch("{id}")]
        public async Task<ActionResult> Patch(int id, [FromBody] JsonPatchDocument<AutorCreacionDTO> patchDocument)
        {
            if (patchDocument == null)
            {
                return BadRequest();
            }

            var autorDeLaDB = await context.Autores.FirstOrDefaultAsync(x => x.Id == id);

            if (autorDeLaDB == null)
            {
                return NotFound();
            }

            var autorDTO = mapper.Map<AutorCreacionDTO>(autorDeLaDB);

            //se utiliza ModelState por que si alguna de las acciones que se estan enviando viola las reglas de negocio, necesitamos saber que el modelo no es valido.
            patchDocument.ApplyTo(autorDTO, ModelState);

            var isValid = TryValidateModel(autorDeLaDB);

            if (!isValid)
            {
                return BadRequest(ModelState);
            }
            //mapea autorDTO a autorDeLaDB
            mapper.Map(autorDTO, autorDeLaDB);

            await context.SaveChangesAsync();

            return NoContent();

        }

        // DELETE api/autores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Autor>> Delete(int id)
        {
            //busca solamente un recurso de la BD en este caso el Id, esto optimiza el borrado en la bd 
            var autorId = await context.Autores.Select(x => x.Id).FirstOrDefaultAsync(x => x == id);

            if (autorId == default(int))
            {
                return NotFound();
            }

            context.Remove(new Autor { Id = autorId });
            await context.SaveChangesAsync();
            return NoContent();

        }

    }
}
