using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("test/")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "My App is Working!";
    }

    [HttpGet("quadratica/{x}")]
    public string Get(int x, int a = 1, int b = 0, int c = 0)
    {
        int resultado = a * x * x + b * x + c;
        return resultado.ToString();
    }

    [HttpGet("solucao")]
    public object Get(
        double a = 1, double b = 0, double c = 0)
    {
        if (a == 0)
        {
            return new {
                status = "Fail",
                message = "'a' não pode ser zero."
            };
        }

        double delta = b * b - 4 * a * c;
        if (delta < 0)
        {
            return new {
                status = "Fail",
                message = "delta não pode ser negativo"
            };
        }

        double x1 = (-b + Math.Sqrt(delta)) / a;
        double x2 = (-b - Math.Sqrt(delta)) / a;

        return new {
            status = "Sucesso",
            solucao1 = x1,
            solucao2 = x2
        };
    }
}