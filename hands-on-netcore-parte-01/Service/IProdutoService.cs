using System.Collections.Generic;
using hands_on_netcore.Model;

public interface IProdutoService
{
    IList<Produto> ObterProdutos();
}