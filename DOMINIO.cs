public class Funcionario
{
    public string Nome { get; set; }
    public int Matricula { get; private set; }
    public decimal Salário { get; private set; }
    
    public void Daraumento(decimal valor)
    {
        Salário += valor;
    }

    public Funcionario(string nome, decimal salario)
    {
        Nome = nome;
        Salário = salario;

        Random random = new Random();
        Matricula = random.Next(1, 1000);
    }

}
