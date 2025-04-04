//Duas palavras são anagramas se e somente se possuem as mesmas letras na mesma frequencia
//Ex:
//amor - orma-- true
//aac - aca-- true
//baa - bba-- false
//qwert - qwerty - false


//Desenvolva uma algoritmo que determina se duas palavras são anagramas utilizando apenas funcinalidades basicas da linguagem como loops e estrutura de dados como listas, objetos, diagramas, etc...

Console.WriteLine("Escrava a sua primeira palavra anagrama: ");
string ? palavra1 = Console.ReadLine();

Console.WriteLine("Escrava a sua segunda palavra anagrama: ");
string ? palavra2 = Console.ReadLine();

string[] a = new string[palavra1.Length];
string[] b = new string[palavra2.Length];
string[] c = new string[palavra2.Length];


try 
{
    if (a.Length == b.Length)
    {
        for (int i = 0; i < palavra1.Length; i++)
        {
            a[i] = palavra1[i].ToString();
        }

        for (int i = 0; i < palavra2.Length; i++)
        {
            b[i] = palavra2[i].ToString();
        }

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == b[i])
            {
                c[i] = b[i];
            }
        }

        for (int i = 0; i < c.Length; i++)
        {
            Console.WriteLine(c[i]);
        }
    
    }
    else 
    {
        throw new Exception("Ambas palavras não possuem a mesma quantia de letras");
    }
}
catch (Exception ex)
{
    Console.WriteLine("\n" + ex.ToString());
}