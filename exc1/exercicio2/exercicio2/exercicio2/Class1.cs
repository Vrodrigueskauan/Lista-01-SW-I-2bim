using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

public class RegistroDeCompras
{
    // Classe interna para representar uma compra
    private class Compra
    {
        public DateTime Data { get; }
        public string Produto { get; }
        public double Valor { get; }

        public Compra(DateTime data, string produto, double valor)
        {
            Data = data;
            Produto = produto;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"Data: {Data}, Produto: {Produto}, Valor: {Valor:C}";
        }
    }

    // Lista para armazenar as compras
    private List<Compra> compras;

    // Construtor
    public RegistroDeCompras()
    {
        compras = new List<Compra>();
    }

    // Método para adicionar uma compra ao registro
    public void AdicionarCompra(DateTime data, string produto, double valor)
    {
        Compra novaCompra = new Compra(data, produto, valor);
        compras.Add(novaCompra);
        Console.WriteLine("Compra adicionada com sucesso!");
    }

    // Método para listar todas as compras registradas
    public void ListarCompras()
    {
        if (compras.Count == 0)
        {
            Console.WriteLine("Não há compras registradas.");
        }
        else
        {
            Console.WriteLine("Lista de Compras:");
            foreach (var compra in compras)
            {
                Console.WriteLine(compra);
            }
        }
    }
}




