using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class Produto
{
    // Atributos
    private string nome;
    private double preco;
    private int quantidadeEmEstoque;

    // Construtor
    public Produto(string nome, double preco, int quantidadeEmEstoque)
    {
        this.nome = nome;
        this.preco = preco;
        this.quantidadeEmEstoque = quantidadeEmEstoque;
    }

    // Método para adicionar itens ao estoque
    public void AdicionarItem(int quantidade)
    {
        if (quantidade > 0)
        {
            quantidadeEmEstoque += quantidade;
            Console.WriteLine($"{quantidade} itens adicionados ao estoque de {nome}.");
        }
        else
        {
            Console.WriteLine("A quantidade deve ser maior que zero.");
        }
    }

    // Método para remover itens do estoque
    public void RemoverItem(int quantidade)
    {
        if (quantidade > 0 && quantidade <= quantidadeEmEstoque)
        {
            quantidadeEmEstoque -= quantidade;
            Console.WriteLine($"{quantidade} itens removidos do estoque de {nome}.");
        }
        else if (quantidade > quantidadeEmEstoque)
        {
            Console.WriteLine("Quantidade solicitada excede a quantidade em estoque.");
        }
        else
        {
            Console.WriteLine("A quantidade deve ser maior que zero.");
        }
    }

    // Método para exibir informações do produto
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Preço: R${preco}");
        Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
    }
}


