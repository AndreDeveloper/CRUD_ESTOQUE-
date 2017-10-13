using Crud_estoque.DAL;
using Crud_estoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_estoque.DAO
{

    public class ProdutoDAO
    {
        private static ProdutoDAO instance;
        private EstoqueContext db;

        private ProdutoDAO(EstoqueContext context)
        {
            db = context;
        }

        public static ProdutoDAO getInstance()
        {
            if (instance == null)
            {
                instance = new ProdutoDAO(EstoqueContext.getInstance());
            }
            return instance;
        }

        internal void insert(Produto produto)
        {
            db.Produtos.Add(produto);
            db.SaveChanges();
        }

        internal IList<Produto> getAll()
        {
            return db.Produtos.ToList();
        }

        internal Produto getById(int id)
        {
            return db.Produtos.Find(id);
        }

        internal void delete(Produto produto)
        {
            db.Produtos.Remove(produto);
            db.SaveChanges();
        }

        internal void update(Produto produto)
        {
            Produto old = getById(produto.id);
            db.Entry(old).CurrentValues.SetValues(produto);
            db.SaveChanges();
        }

    }
}