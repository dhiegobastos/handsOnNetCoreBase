using System;
using System.Collections.Generic;
using hands_on_netcore.Model.Domain;
using hands_on_netcore.Repository;

namespace hands_on_netcore.Service
{
    public class ProdutoService : IProdutoService
    {
        public ProdutoService()
        {

        }

        public IList<Produto> ObterProdutos()
        {
            throw new NotImplementedException();
        }

        public Produto ObterProdutoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Produto AddProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void RemoverProduto(int id)
        {
            throw new NotImplementedException();
        }

    }
}