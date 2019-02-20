using System;
using System.Collections.Generic;
using hands_on_netcore.Model;
using Microsoft.AspNetCore.Mvc;

namespace hands_on_netcore.Controllers
{
    public class ProdutoController : ControllerBase
    {
        public ProdutoController()
        {

        }

        public ActionResult<IEnumerable<Produto>> RecuperarLista()
        {
            return null;
        }

        public ActionResult<Produto> RecuperarPodId(int id)
        {
            return null;
        }

        public ActionResult<Produto> AdicionarProduto(Produto produto)
        {
            return null;
        }

        public ActionResult RemoverProduto(int id)
        {
            return null;
        }
    }
}