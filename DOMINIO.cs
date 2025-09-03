public class Funcionario
{
    
public string Nome { get; set; }
public int Matricula { get; set; }
public decimal Salário { get; set; }


    public void Daraumento(decimal valor)
    {
        Salário += valor;
    }

}