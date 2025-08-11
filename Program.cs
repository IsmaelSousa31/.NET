Console.Write("Insira um numero inteiro: ");
string inputnumeroint = Console.ReadLine();

int numero_int = int.Parse(inputnumeroint);

Console.Write("Insira um numero com casa decimais: ");
string inputnumerofloat = Console.ReadLine();

float numero_float = float.Parse(inputnumerofloat);

Console.Write("Insira um caractere: ");
string caractere = Console.ReadLine();

char caractere_ = char.Parse(caractere);

Console.Write("Insira um valor booleano(true ou false)");
string valor_b = Console.ReadLine();

bool valor_boleano = bool.Parse(valor_b);


Console.WriteLine("Você inseriu: ");
Console.WriteLine("Numero inteiro: " + numero_int);
Console.WriteLine("Numero decimal: " +  numero_float);
Console.WriteLine("Caractere: " + caractere_);
Console.WriteLine("Valor Booleano: " + valor_boleano);

