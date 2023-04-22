Console.Clear();

Console.WriteLine("Digite o número de uma opção:\n");
Console.Write("| 1 - Criptografar 		\n");
Console.Write("| 2 - Descriptografar  	\n");
Console.WriteLine("| 3 - Sair              	\n");
Console.Write("Digite uma opção: ");
		
int opcao = Convert.ToInt32(Console.ReadLine());

try
{		
switch (opcao) {

	case 1:
	Console.WriteLine("--- CRIPTOGRAFIA ---");
    Console.WriteLine("Escreva a mensagem que deseja criptografar: ");
    string frase = Console.ReadLine()!;

        Console.WriteLine("");
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        string capslock = frase.ToUpper(); 

        string fraseAlterada = AumentarAlfabeto(capslock, numero);

        Console.WriteLine("");
        Console.WriteLine("Frase Original: " + frase);
        Console.WriteLine("Frase Alterada: " + fraseAlterada);


        static string AumentarAlfabeto(string frase, int numero)
        {
        char[] letras = frase.ToCharArray();
        string novaFrase = "";

        foreach (char letra in letras)
        {
        if (char.IsLetter(letra)) 
        {
        char novaLetra = (char)(((letra - 'A' + numero) % 26) + 'A'); 
        novaFrase += novaLetra;
        }
        else
        {
        novaFrase += letra; 
        }
        }

return novaFrase;
        }
			
	break;
		
	case 2:
	Console.WriteLine("--- DESCRIPTOGRAFIA ---");
	Console.WriteLine("Não está pronto");

    /*Console.WriteLine("Escreva a mensagem criptografada, que deseja descriptografar: ");

    string mnsg = Console.ReadLine()!;

        Console.WriteLine("");
        Console.Write("Digite um número: ");
        int number = Convert.ToInt32(Console.ReadLine());

        string caps = mnsg.ToUpper(); 

        string mnsgAlterada = Aumentar_Alfabeto(caps, number);

        Console.WriteLine("");
        Console.WriteLine("Frase Original: " + mnsg);
        Console.WriteLine("Frase Alterada: " + mnsgAlterada);


        static string Aumentar_Alfabeto(string mnsg, int numero)
        {
        char[] letras = mnsg.ToCharArray();
        string novaFrase = "";

        foreach (char letra in letras)
        {
        if (char.IsLetter(letra)) 
        {
        char novaLetra = (char)(((letra - 'A' + numero) % 26) + 'A'); 
        novaFrase += novaLetra;
        }
        else
        {
        novaFrase += letra; 
        }
        }

return novaFrase;
        }
		*/	
    break;

    case 3:
    Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine("\nAté logo!");
    break;
		
default:
    Console.ForegroundColor = ConsoleColor.DarkRed;
	Console.Write("\nOpção Inválida!");
	break;
}}
	
    finally
    {
        Console.ReadLine();
        Console.ResetColor();
        Console.Clear();
    }
