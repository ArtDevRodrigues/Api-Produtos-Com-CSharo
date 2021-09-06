using System.ComponentModel.DataAnnotations;

namespace apiProdutosCRUD.Models
{
    public class Produto
    {
        [Key]
        private int Id{get;set;}
        private string Nome{get;set;}
        private int Quant{get;set;}
        private double Preco{get;set;}


    }
}