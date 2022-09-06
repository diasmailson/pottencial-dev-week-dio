using System.Collections.Generic;
namespace src.Models;


public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }  
    public string? Cpf { get; set; }
    public bool Ativado { get; set; }
    public List<Contrato> contratos { get; set; }

    public Pessoa()
    {
        this.Nome = "Riko";
        this.Idade = 0;
       this.contratos = new List<Contrato>();
    }

    public Pessoa(string nome, int idade, string cpf)
    {
        this.Nome = nome;
        this.Idade = idade;
        this. Cpf = cpf;
        this.contratos = new List<Contrato>();
    }
}

