using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Gufi.WebApi.Domains;

namespace Senai.Gufi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ITipoUsuarioController : ControllerBase
    {
        private ITipoUsuarioController _TipoUsuarioController;

        public ITipoUsuarioController()
        {
            _TipoUsuarioController = new ITipoUsuarioController();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_TipoUsuarioController.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return StatusCode(200, _TipoUsuarioController.BuscarPorId(id));
        }


        [HttpPost]
        public IActionResult Post(TipoUsuario novoTipoUsuario)
        {
            _TipoUsuarioController.Cadastrar(novoTipoUsuario);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TipoUsuario TipoUsuarioAtualizado)
        {
            TipoUsuario TipoUsuarioBuscado = _TipoUsuarioController.BuscarPorId(id);

            if (TipoUsuarioBuscado != null)
            {
                try
                {
                    _TipoUsuarioController.Atualizar(id, TipoUsuarioAtualizado);

                    return StatusCode(200);
                }
                catch (Exception erro)
                {
                    return BadRequest(erro);
                }
            }

            return StatusCode(404);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            TipoUsuario TipoUsuarioBuscado = _TipoUsuarioController.BuscarPorId(id);

            if (TipoUsuarioBuscado == null)
            {
                return NotFound();
            }

            _TipoUsuarioController.Deletar(id);

            return StatusCode(202);
        }
    }
}