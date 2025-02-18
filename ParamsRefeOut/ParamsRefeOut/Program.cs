// See https://aka.ms/new-console-template for more information
using ParamsRefeOut;

int a = 10;
Calculator.Triple(ref a); 
//modificador ref serve pra alterar o número aqui, e não apenas enquanto a função está sendo executada
//Faz ser uma referência pra variável original
Console.WriteLine(a);

//Já o out, não exige que a variável original seja iniciada com nenhum valor.
int b = 10;
int triple;
Calculator.Triplicar(b, out triple);
Console.WriteLine(triple);
