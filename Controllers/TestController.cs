using  Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("test/")]
public class TestControler :  ControllerBase
{
    [httpGet]
    public string Get()
    {
        return "my app is working!:)";
    }
}