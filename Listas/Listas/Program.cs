using System.Collections.Generic;
List<string> lista = new List<string>();
//Add = Adiciona ao fim da lista
lista.Add("Shadow, o ouriço");
lista.Add("Sonic, o rapidinho");
lista.Add("Tails, a raposinha bicha");
lista.Add("Knuckles, o machista");
//Insert = Escolhe a posição ao adicionar na lista
lista.Insert(2,"Amy, a rapariguinha");
foreach (string frase in lista)
{
    Console.WriteLine(frase);
}
//Count = Mostra o tamanho da lista
Console.WriteLine($"A lista tem {lista.Count} de tamanho");
//Find/FindLast = Encontrar o primeiro ou último elemento da lista que satisfaça um predicado
string sPrimeiro = lista.Find(x => x[0] == 'S');
Console.WriteLine($"O primeiro personagem com S no início do nome é: {sPrimeiro}");

string sUltimo = lista.FindLast(x => x[0] == 'S');
Console.WriteLine($"O último personagem com S no início do nome é: {sUltimo}");

//FindIndex/FindLastIndex = Mesma coisa, mas agora é só a posição que ele acha
int posS = lista.FindIndex(x => x[0] == 'S');
Console.WriteLine($"Posição do personagem com S iniciando em 0: {posS}, ou iniciando em 1: {posS+1}");

int posSUltimo = lista.FindLastIndex(x => x[0] == 'S');
Console.WriteLine($"Posição do último personagem com S iniciando em 0: {posSUltimo}, ou iniciando em 1: {posSUltimo + 1}");

List<string> listaFiltrada = lista.FindAll(x => x.Length <= 20);

Console.WriteLine($"Lista de personagens com até 20 caracteres:");

foreach (string pers in listaFiltrada)
{
    Console.WriteLine(pers);
}

//remove, remove all(esse usa uma condição, que nem os outros), removeAt (remove na posição), removeRange(uma posição, e uma contagem. A partir da posição x, quantos a mais).
Console.WriteLine("-------------");
lista.Remove("Sonic, o rapidinho");
foreach (string frase in lista)
{
    Console.WriteLine(frase);
}
