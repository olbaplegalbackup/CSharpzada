﻿public class Pessoa
{
    public static int IdadeMinima;

    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("\nExecutando o construtor parametrizado");
        Idade = idade;
        Nome = nome;
    }
    public Pessoa()
    { }

    static Pessoa()
    {
        Console.WriteLine("\nexecutando construtor estático");
        Console.WriteLine("\ninicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }
}