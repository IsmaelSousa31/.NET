class Program{

static void Main(string[] nome){
string[] fila = new string[5];
int inicio = 0;
int fim = -1;
void Enfilerar(string nome)
{
    if (fim < fila.Length - 1)
    {
        fim++;
        fila[fim] = nome;
        Console.WriteLine($"{nome} foi adicionado à fila.");
    }
    else
    {
        Console.WriteLine("A fila está cheia.");
    }
}

void Desenfileirar()
{
    if (inicio <= fim)
    {
        Console.WriteLine($"{fila[inicio]} foi removido da fila.");
        inicio++;
    }
    else
    {
        Console.WriteLine("A fila está vazia.");
    }
}

void Fila()
        {
            if (inicio <= fim)
            {
                Console.Write("Clientes na fila:");
                for (int i = inicio; i <= fim; i++)
                {
                    Console.Write($" {fila[i]} |");
                }
                Console.WriteLine("  ");
                Console.WriteLine("================================================");
            }
            else
            {
                Console.WriteLine("A fila está vazia.");
            }
        }


        int resposta = 0;


        do
        {
        
            Console.WriteLine("===Menu Sorveteria===");
            Console.WriteLine("Escolha um opção: ");
            Console.WriteLine("1 - adicionar cliente");
            Console.WriteLine("2  - atender clientes");
            Console.WriteLine("3 - Exibir o estado atual da fila");
            Console.WriteLine("4 - Sair");
            resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
            {
                Console.WriteLine("Digite o nome do cliente:");
                string nome_ = Console.ReadLine();

                Enfilerar(nome_);
            }
            else if (resposta == 2)
            {
                Desenfileirar();
            }
            else if (resposta == 3)
            {
                Fila();

            }
            else if (resposta == 4)
            {
                Console.WriteLine("Saindo...");
                
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
            

        } while (resposta != 4);
}
}


