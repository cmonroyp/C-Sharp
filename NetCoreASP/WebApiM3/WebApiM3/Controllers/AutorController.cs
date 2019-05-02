﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiM3.Contexts;
using WebApiM3.Entities;

namespace WebApiM3.Controllers
{
    [Route("api/[controller]")]
    //ApiController retorna un conjunto de convenciones para simplificar el codigo de nuestras acciones
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AutoresController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //ActionResult tipicos mensajes de respuesta 200,404 etc,IEnumerable me retorna una lista de valores
        [HttpGet]
        public ActionResult<IEnumerable<Autor>> Get()
        {
            return context.Autores.Include(x => x.Libros).ToList();
        }

        [HttpGet("{id}", Name = "ObtenerAutor")]
        public ActionResult<Autor> Get(int id)
        {
            //var autor = context.Autores.FirstOrDefault(x => x.Id == id); sin traer ninguna relacion con otra tabla
            var autor = context.Autores.Include(x => x.Libros).FirstOrDefault(x => x.Id == id);

            if (autor == null)
            {
                return NotFound();
            }

            return autor;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {
            context.Autores.Add(autor);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerAutor", new { id = autor.Id }, autor);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Autor value)
        {
            if (id != value.Id)
            {
                return BadRequest();
            }
            context.Entry(value).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Autor> Delete(int id)
        {
            var autor = context.Autores.FirstOrDefault(x => x.Id == id);

            if (autor == null)
            {
                return NotFound();
            }

            context.Autores.Remove(autor);
            context.SaveChanges();
            return autor;
        }
    }
}
