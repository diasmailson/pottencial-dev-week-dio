namespace src.Models;

public class Contrato
{
    public DateTime DataCriacao { get; set; }   
    public string? TokenId { get; set; }
    public Double Valor { get; set; }
    public bool Pago { get; set; }

    public Contrato()
    {
        this.DataCriacao = DateTime.Now;
        this.TokenId = "00000";
        this.Valor = 0;
    }

    public Contrato(string TokenId, Double Valor)
    {
        this.DataCriacao = DateTime.Now;
        this.TokenId = TokenId;
        this.Valor = Valor;
    }
}