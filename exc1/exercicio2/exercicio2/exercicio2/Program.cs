namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso da classe RegistroDeCompras
            RegistroDeCompras registro = new RegistroDeCompras();

            registro.AdicionarCompra(DateTime.Parse("2024-04-25"), "Camiseta", 29.99);
            registro.AdicionarCompra(DateTime.Parse("2024-04-26"), "Calça", 49.99);
            registro.AdicionarCompra(DateTime.Parse("2024-04-27"), "Tênis", 99.99);

            registro.ListarCompras();

            Console.ReadLine();
        }
    }
}