using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using WebApiModulo7.Services;

namespace WebApiModulo7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [EnableCors("PermitirApiRequest")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ValuesController : ControllerBase
    {

        private readonly IDataProtector _protector;
        //servio para hash
        private readonly HashService _hashService;

        //encriptar valores
        public ValuesController(IDataProtectionProvider protectionProvider, HashService hashService)
        {
            _protector = protectionProvider.CreateProtector("valor_unico_y_quizas_secreto");
            _hashService = hashService;
        }

        // GET api/values
        [HttpGet]
        [EnableCors("PermitirApiRequest")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("hash")]
        public ActionResult GetHash()
        {
            string textoPlano = "Carlos Mario Monroy";
            var hashResult1 = _hashService.Hash(textoPlano).Hash;
            var hashResult2 = _hashService.Hash(textoPlano).Hash;
            return Ok(new { textoPlano, hashResult1, hashResult2 });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            //var protectorLimitadoPorTiempo = _protector.ToTimeLimitedDataProtector();

            //string textoPlano = "Carlos Mario Monroy";
            //string textoCifrado = protectorLimitadoPorTiempo.Protect(textoPlano, TimeSpan.FromSeconds(5));
            //Thread.Sleep(6000);
            //string textoDesencriptado = protectorLimitadoPorTiempo.Unprotect(textoCifrado);
            //return Ok(new { textoPlano, textoCifrado, textoDesencriptado });

            string textoPlano = "Carlos Mario Monroy";
            string textoCifrado = _protector.Protect(textoPlano);
            string textoDesencriptado = _protector.Unprotect(textoCifrado);
            return Ok(new { textoPlano, textoCifrado, textoDesencriptado });
        }

        private void EjemploDeEncriptacionLimitadaPorTiempo()
        {
            var protectorLimitadoPorTiempo = _protector.ToTimeLimitedDataProtector();
            string textoPlano = "Carlos Mario Monroy";
            string textoCifrado = protectorLimitadoPorTiempo.Protect(textoPlano, TimeSpan.FromSeconds(5));
            string textoDesencriptado = protectorLimitadoPorTiempo.Unprotect(textoCifrado);
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
