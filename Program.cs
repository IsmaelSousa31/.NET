class Program
{

    static void Main()
    {
        int[] numeros = new int[5];
        float[] valor = new float[5];
        int inicio = 0;
        

        void CarregarSaldo(int ntag, float valortag)
        {      
            
            valor[ntag] = valor[ntag] + valortag;
            Console.WriteLine($"O valor R$ {valortag:F2} foi adicionado a Tag {ntag}, saldo atual R$ {valor[ntag]:F2}");
                    
        }

        void PassarPedagio(int numero_tag, float valorpedagio)
        {
            if (valor[numero_tag] >= valorpedagio)
            {
                valor[numero_tag] = valor[numero_tag] - valorpedagio;
                Console.WriteLine($"Sucesso, a TAG {numero_tag} passou pelo pedágio. Saldo restante = R$ {valor[numero_tag]:F2}");
            }
            else
            {
                Console.WriteLine($"A TAG {numero_tag} não possui saldo suficiente."); 
            }

        }

        void SaldoAtual(int VSaldo)
        {

            Console.WriteLine($"Saldo da Tag {VSaldo} = R$ {valor[VSaldo]:F2} ");


        }

        int r = 0;

        do
        {
            Console.WriteLine("=== TAGS Pedágio ===");
            Console.WriteLine("1 - Carregar Saldo");
            Console.WriteLine("2 - Passar pelo Pedagio");
            Console.WriteLine("3 - Visualizar saldo");
            Console.WriteLine("4 - Sair");

            r = int.Parse(Console.ReadLine());

            if (r == 1)
            {
                Console.WriteLine("Digite o número de 0 a 4 referente a tag que deseja carregar: ");
                int n_tag = int.Parse(Console.ReadLine());

                for (int x = inicio; x < numeros.Length; x++)
                {
                   
                    if (n_tag >= 0 && n_tag <= 4)
                    {
                        Console.WriteLine("Digite o valor que deseja carregar: ");
                        float valor_tag = float.Parse(Console.ReadLine());

                        CarregarSaldo(n_tag, valor_tag);
                        break;
                    }
                    else if (x != numeros.Length)
                    {
                        Console.WriteLine("Tag digitada não foi encontrada! tente novamente.");
                        Console.WriteLine("============================================");
                        break;
                    }
                
                }
                

            }
                else if (r == 2)
                {
                    Console.WriteLine("Digite o número de 0 a 4 referente a tag que deseja utilizar: ");
                    int nu_tag = int.Parse(Console.ReadLine());

                    for (int y = inicio; y < numeros.Length; y++)
                    {
                    if (nu_tag >= 0 && nu_tag <= 4)
                    {
                        Console.WriteLine("Digite o valor do pedagio: ");
                        float valor_pedagio = float.Parse(Console.ReadLine());

                        PassarPedagio(nu_tag, valor_pedagio);
                        break;
                        }
                    else if (y != numeros.Length)
                    {
                        Console.WriteLine("Tag digitada não foi encontrada! tente novamente.");
                        Console.WriteLine("=================================================");
                        break;
                    }
                            
                    }

                   

                }
                else if (r == 3)
                {
                    Console.WriteLine("Digite o número de 0 a 4 referente a tag que deseja saber o saldo: ");
                    int saldo_tag = int.Parse(Console.ReadLine());

                    for (int z = inicio; z < numeros.Length; z++)
                    {
                    if (saldo_tag >= 0 && saldo_tag <= 4)
                    {

                        SaldoAtual(saldo_tag);
                        break;
                        
                        }
                    else if (z != numeros.Length)
                    {
                        Console.WriteLine("Tag digitada não foi encontrada! tente novamente.");
                        Console.WriteLine("=================================================");
                        break;
                    }
                            
                    }
                }
                else if (r == 4)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente");

                }

        } while (r != 4);

    }
}