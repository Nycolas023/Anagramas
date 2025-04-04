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

int index1 = palavra1.Length;
int index2 = palavra2.Length;

string[] a = new string[index1];
string[] b = new string[index2];

try 
{
    if (a.Length == b.Length)
    {
      
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