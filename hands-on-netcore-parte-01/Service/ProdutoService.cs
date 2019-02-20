using System;
using System.Collections.Generic;
using hands_on_netcore.Model;

namespace hands_on_netcore.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IList<Produto> _lista;

        public ProdutoService(int qtdProdutos)
        {
            _lista = new List<Produto>();
            for (int i = 1; i <= qtdProdutos; i++)
            {
                _lista.Add(new Produto(i, i * 100, "Produto 0" + i, i * 10, "2019-02-19T15:00:00", Convert.ToBoolean(i % 2)));
            }
        }

        public IList<Produto> ObterProdutos()
        {
            return _lista;
        }

    }
}