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

    [HttpPost]
    public Pessoa Post([FromBody]Pessoa pessoa){
        return pessoa;
    }
    
    [HttpPut("{id}")]
    public string Update([FromRoute]int id, [FromBody] Pessoa pessoa){
        Console.WriteLine(id);
        return "Dados do id " + id + " atualizados";
    }

    [HttpDelete]
    public string Delete([FromRoute] int id){
        return "deletado pessoa de Id " + id;
    }
}