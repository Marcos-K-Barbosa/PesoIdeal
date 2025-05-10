String Resposta;
String Gênero;
Double Altura, PesoIdeal;
Console.Clear();
Console.Write("Olá, boas vindas! Você gostaria de calcular o peso que seria ideal para você, segundo suas proporções? ( Sim ou Não ): ");
Resposta = (Console.ReadLine())!;

if (Resposta == "Não")
{

}

else if (Resposta == "Sim")
{
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Ok! Então vamos lá. Primeiro insira sua altura ( Em metros ): ");
Altura = Convert.ToDouble (Console.ReadLine());

Console.Write("Agora insira seu gênero ( M para Masculino e F para Feminino): ");
Gênero = (Console.ReadLine())!;


if (Gênero=="M")

{
Console.Write("Calculando seu peso...");
Thread.Sleep(2000);
PesoIdeal = Convert.ToDouble(0);
PesoIdeal = (Altura * 72.7) - 58.0;
Console.WriteLine($"\nSeu peso ideal é: {PesoIdeal:N1}kg");
}

else if (Gênero=="F")
{
Console.Write("Calculando seu peso...");
Thread.Sleep(2000);
PesoIdeal = Convert.ToDouble(0);
PesoIdeal = (Altura * 62.1) - 44.7;
Console.WriteLine($"\nSeu peso ideal é: {PesoIdeal:N1}kg");
}
}