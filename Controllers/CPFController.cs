using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("cpf/")]
public class CpfController : ControllerBase
{
    [HttpGet("validate/{cpf}")]
    public object Validate(
        [FromServices]CpfService cpfService,
        string cpf)
    {
        throw new NotImplementedException();
    }

    [HttpGet("generate")]
    public object Generate(
        [FromServices]CpfService cpfService)
    {
        string CPF = cpfService.Generate();
        return CPF;
    }
}