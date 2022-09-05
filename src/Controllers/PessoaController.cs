using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase{

    [HttpGet]
    public Pessoa Get(){
        Pessoa pessoa = new Pessoa("Riko", 31, "002251366");
        Contrato novoContrato = new Contrato("contrato01", 151.30);
        pessoa.contratos.Add(novoContrato);
        return pessoa;
    }
}