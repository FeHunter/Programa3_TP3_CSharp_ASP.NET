namespace Programa3_TP3_CSharp_ASP.NET.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }

        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
    }
}
