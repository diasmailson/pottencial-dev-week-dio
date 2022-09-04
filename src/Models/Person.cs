namespace src.Models;

public class Person
{
    public string Nome { get; set; }
    public int Idade { get; set; }  
    public string? Cpf { get; set; }
    public bool Ativado { get; set; }

    public Person()
    {
        this.Nome = "Riko";
        this.Idade = 0;
    }

    public Person(string nome, int idade, string cpf)
    {
        this.Nome = nome;
        this.Idade = idade;
        this. Cpf = cpf;
    }
}

