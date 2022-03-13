using informations;

namespace validNumbers;
public class NumbersValidator{
    
    public static bool validateCpf(string cpf){
        string validCPF = cpf;
        if(cpf.Contains('.') && cpf.Contains('-')){
           validCPF = cpf.Replace(".", "").Replace("-", "");
        }
        return validCPF.Trim().Length == 11;

    }
}


class TestValidator{
    static void Main(string[] args){
        Console.WriteLine(InformationGenerator.GerarCpf());
    }
}



