namespace exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso da classe Produto
            Produto produto = new Produto("Camiseta", 29.99, 50);
            produto.ExibirInformacoes();

            produto.AdicionarItem(10);
            produto.ExibirInformacoes();

            produto.RemoverItem(5);
            produto.ExibirInformacoes();

            produto.RemoverItem(100); // Tentando remover mais itens do que disponível em estoque

            Console.ReadLine();
        }
    }
}