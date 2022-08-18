public class CpfService
{
    public CpfService(int seed)
    {
        this.rnd = new Random(seed);
    }
    Random rnd;

    public bool Validate(string cpf)
    {
        string cuspf = "";
        
        for(int i = 0; i<=10; i++)
        {
            if(i >= 9)
            {
                break;
            }
            cuspf += cpf.Substring(i, 1);
        }
        ultimosnum = getValidationDigits(cuspf)
    }

    public string Generate()
    {
        string semente = rnd.Next(100000000, 999999999).ToString();
        Console.WriteLine(semente);

        string verif = getValidationDigits(semente);
        string resuta = semente + verif;

        return resuta;
    }

    // detalhes em: https://www.calculadorafacil.com.br/computacao/validar-cpf
    private string getValidationDigits(string cpf9digits)
    {
        int digit0 = 0, digit1 = 0;
        for (int i = 0; i < cpf9digits.Length; i++)
        {
            var digit = cpf9digits[i] - '0';
            digit0 += digit * (i + 1);
            digit1 += digit * i;
        }
        digit0 %= 11;
        digit0 %= 10;
        
        digit1 += 9 * digit0;
        digit1 %= 11;
        digit1 %= 10;

        return digit0.ToString() + digit1.ToString();
    }
}