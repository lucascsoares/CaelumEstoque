using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaelumEstoque.Models;
using CaelumEstoque.DAO;

namespace CaelumEstoque.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produtos
        public ActionResult Index()
        {

            ProdutosDAO dao = new ProdutosDAO();
            IList<Produto> produtos = dao.Lista();
            ViewBag.Produtos = produtos;

            return View();
        }

        public ActionResult Form()
        {

            return View();
        }

        public ActionResult Adiciona(String nome, float preco, int quantidade, String descricao, int categoriaId)
        {
            Produto produto = new Produto() {
                Nome = nome,
                Preco = preco,
                Quantidade = quantidade,
                Descricao = descricao,
                CategoriaId = categoriaId
            };

            ProdutosDAO dao = new ProdutosDAO();
            dao.Adiciona(produto);

            return View();

    }


}
}