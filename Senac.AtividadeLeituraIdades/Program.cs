//ENTRADA
bool continuar = true;
bool NovaConsulta = true;
int idade;

while (continuar)
   
{
    NovaConsulta = true;

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("################################################");
    Console.WriteLine("BEM VINDO A SISTEMA DE VERIFICACAO DE CATEGORIA ");
    Console.WriteLine("################################################");
    Console.Write("Insira sua IDADE em NUMEROS: ");
    Console.ResetColor();

    //PROCESSAMENTO e SAIDA
    if (!int.TryParse(Console.ReadLine(), out idade))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Erro, Digite um idade Valida!"); //Erro de idade
        Console.ResetColor();
        Console.ReadKey();
        continue;
    }
    else if (idade < 5)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Você não tem a idade minima para participar!");//Nao tem idade suficiente
        Console.ResetColor();
    }

    else if (idade <= 10)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Parabens, sua categoria é INFANTIL!");//Categoria Infantil
        Console.ResetColor();
    }

    else if (idade <= 17)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Parabens, sua categoria é JUVENIL!");//Categoria JUVENIL 
        Console.ResetColor();
    }

    else if (idade < 30)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Parabens, sua categoria é PROFISSIONAl!");//Categoria Profissional
        Console.ResetColor();
    }

    else 
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Parabens, sua categoria é SÊNIOR!");//Categoria Senior
        Console.ResetColor();
    }

    while (NovaConsulta)
    {
        Console.WriteLine("Deseja realizar uma nova consulta? (S/N)");
        string resposta = Console.ReadLine().ToUpper();
        if (resposta == "N")
        {
            continuar = false;
            NovaConsulta = false;
            Console.WriteLine("Obrigado por usar o nosso sistema");
            Console.ReadKey();
        }
        else if (resposta == "S")
        {
            continuar = true;
            NovaConsulta = false;
        }
        else
        { 
            Console.WriteLine("Entrada invalida, responda com (S/N)");
        }
    }
}

