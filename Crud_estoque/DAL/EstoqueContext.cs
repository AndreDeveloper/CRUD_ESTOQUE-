using Crud_estoque.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Crud_estoque.DAL
{
    public class EstoqueContext : DbContext
    {
        private static EstoqueContext instance;
        public EstoqueContext()
            : base("ESTOQUE")
        {

        }

        public static EstoqueContext getInstance()
        {
            if(instance == null)
            {
                instance = new EstoqueContext();
            }

            return instance;
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}