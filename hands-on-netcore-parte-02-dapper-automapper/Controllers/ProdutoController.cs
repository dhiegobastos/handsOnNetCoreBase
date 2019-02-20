using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using hands_on_netcore.Model.Domain;
using hands_on_netcore.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace hands_on_netcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> RecuperarLista()
        {
            IList<Produto> produtos = _produtoService.ObterProdutos();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public ActionResult<ProdutoDto> RecuperarPodId(int id)
        {
            Produto produto = _produtoService.ObterProdutoPorId(id);
            if (produto != null)
            {
                return Ok(produto);
            }
            return NotFound(id);
        }

        [HttpPost]
        public ActionResult<Produto> AdicionarProduto([FromBody] Produto produto)
        {
            Produto produtoCriado = _produtoService.AddProduto(produto);
            return CreatedAtAction(nameof(RecuperarPodId), new { id = produtoCriado.Id }, produto);
        }

        [HttpDelete]
        public ActionResult RemoverProduto(int id)
        {
            return null;
        }
    }
}