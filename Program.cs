int numero;

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Digite um número entre 1 e 9 (ou 0 para cancelar):");
    numero = Convert.ToInt32(Console.ReadLine()!);
    Console.ResetColor();

    if(numero > 0)
    {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Número selecionado: {numero}");
    Console.WriteLine($"Volte Sempre");
    Console.ResetColor();
    }
    
    
    if( numero == 0)
    {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Operação Cancelada \n");
    Console.WriteLine($"Volte Sempre");
    Console.ResetColor();
    }

while (numero != 0)
{
        Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Digite um número entre 1 e 9 (ou 0 para cancelar):");
    numero = Convert.ToInt32(Console.ReadLine()!);
    Console.ResetColor();


    if(numero > 0)
    {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Número selecionado: {numero}");
    Console.WriteLine($"Volte Sempre");
    Console.ResetColor();
    }
    
    
    if( numero == 0)
    {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Operação Cancelada \n");
    Console.WriteLine($"Volte Sempre");
    Console.ResetColor();
    }
}