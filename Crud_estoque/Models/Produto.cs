using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Crud_estoque.Models
{
    [Table("PRODUTO")]
    public class Produto
    {
        [Key]
        public int id { get; set; }
        public String nome { get; set; }
        public String fornecedor { get; set; }
        public String descricao { get; set; }
        public DateTime dataValidade { get; set; }
        public DateTime dataFabricacao { get; set; }
    }
}