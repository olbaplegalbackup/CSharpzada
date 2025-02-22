﻿
List<Produto> produtos = new();

produtos.Add(new Produto() { Nome = "Clips", Preco = 3.95m });
produtos.Add(new Produto() { Nome = "Caneta", Preco = 5.99m });
produtos.Add(new Produto() { Nome = "Lápis", Preco = 4.15m });
produtos.Add(new Produto() { Nome = "Estojo", Preco = 6.99m });
produtos.Add(new Produto() { Nome = "Caderno", Preco = 7.55m });

Console.WriteLine($"\nProdutos:\tPreço:");
for (int i = 0; i < produtos.Count; i++)
{
    Console.WriteLine($"{produtos[i].Nome}\t\t{produtos[i].Preco}");
}

//relação dos produtos
decimal somaProdutos = 0m;
decimal mediaProdutos = 0m;
for (int i = 0; i < produtos.Count; i++)
{
    somaProdutos += produtos[i].Preco;
}
Console.WriteLine("\n>Relação dos Produtos");
Console.WriteLine($"\nQuantidade de Produtos na Lista: {produtos.Count}");
Console.WriteLine($"Soma Total dos Preços dos Produtos: {somaProdutos}");
Console.WriteLine($"Média dos Preços dos Produtos: {Math.Round(somaProdutos / produtos.Count, 2)}");

//incluindo mochila
Console.WriteLine("\n>Incluindo Produto: Mochila, 22.44");
produtos.Add(new Produto() { Nome = "Mochila", Preco = 22.44m });

Console.WriteLine($"\nProdutos:\tPreço:");
for (int i = 0; i < produtos.Count; i++)
{
    Console.WriteLine($"{produtos[i].Nome}\t\t{produtos[i].Preco}");
}

//ordenando por nome
Console.WriteLine("\n>Ordenando por Nome");
produtos = produtos.OrderBy(x => x.Nome).ToList();
Console.WriteLine($"\nProdutos:\tPreço:");
for (int i = 0; i < produtos.Count; i++)
{
    Console.WriteLine($"{produtos[i].Nome}\t\t{produtos[i].Preco}");
}

//exibindo preços menores que 5
Console.WriteLine("\n>Exibindo Preços Menores que 5");
Console.WriteLine($"\nProdutos:\tPreço:");
for (int i = 0; i < produtos.Count; i++)
{
    if (produtos[i].Preco < 5) { Console.WriteLine($"{produtos[i].Nome}\t\t{produtos[i].Preco}"); }
}

//Procurando Estojo
Console.WriteLine("\n>Localizando na lista o produto com nome Estojo\n");
var produtoEstojo = produtos.Find(n => n.Nome.Equals("Estojo")); //predicado
Console.WriteLine($"Produto: {produtoEstojo.Nome} - {produtoEstojo.Preco}");

Console.ReadLine();

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}