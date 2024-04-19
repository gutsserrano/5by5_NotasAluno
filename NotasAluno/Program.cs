/* Faça um algoritmo que leia duas notas reais positivos, calcule a sua média e informe a situação do aluno:	
        Media <= 3(reprovado)
        Media > 3 ou Media <= 5 (de exame)
	    senão (aprovado)
*/

float n1, n2;
float media;

Console.WriteLine("Digite a primeira nota: ");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
n2 = float.Parse(Console.ReadLine());

if (n1 < 0 || n1 > 10 || n2 < 0 || n2 > 10)
{
    Console.WriteLine("Notas inválidas!\n");
}
else
{
    media = (n1 + n2) / 2;

    if (media <= 3)
    {
        Console.WriteLine("Aluno reprovado!\n");
    }
    else
    {
        if (media <= 5)
        {
            Console.WriteLine("Aluno de exame!\n");
        }
        else
        {
            Console.WriteLine("Aluno aprovado!\n");
        }
    }
}

Console.WriteLine("Digite qualquer tecla para sair...");
Console.ReadKey();