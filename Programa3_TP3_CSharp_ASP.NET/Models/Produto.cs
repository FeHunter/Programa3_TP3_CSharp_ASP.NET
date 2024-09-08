namespace Programa3_TP3_CSharp_ASP.NET.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public ICollection<Categoria> Categorias { get; set; }
    }
}
