namespace CodastroProdutos.Models
{
    public class Produtos : Base 
    {
        public int ProdutosId { get; set; }
        public decimal Preco {  get; set; }
        public  int QuantidadeDisponivel {  get; set; }
        public Ecor Cor { get; set; }
        public int Potencia { get; set; }

    }
    public enum Ecor 
    { 
        Branco = 1,
        Preto = 2,
        cinza = 3,
        roxo = 4,

    }


}
