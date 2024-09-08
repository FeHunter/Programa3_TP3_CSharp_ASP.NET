using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Programa3_TP3_CSharp_ASP.NET.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
