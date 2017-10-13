using Crud_estoque.DAO;
using Crud_estoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_estoque.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoDAO produtoDAO = ProdutoDAO.getInstance();
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Novo(Produto produto)
        {
            if (ModelState.IsValid)
            {
                produtoDAO.insert(produto);
            }

            return RedirectToAction("Cadastro");
        }

        public ActionResult Lista()
        {
            ViewBag.produtos = produtoDAO.getAll();
            return View();
        }

        public ActionResult Delete(int id)
        {
            Produto produto = produtoDAO.getById(id);
            if(produto != null)
            {
                produtoDAO.delete(produto);
            }
            return RedirectToAction("Lista");
        }

        public ActionResult Editar(int id)
        {
            Produto produto = produtoDAO.getById(id);
            if (produto != null)
            {
                ViewBag.produto = produto;
            }
            return View();
        }

        public ActionResult EditaProduto(Produto produto)
        {
            if (produto != null)
            {
                produtoDAO.update(produto);
            }
            return RedirectToAction("Lista");
        }
    }
}