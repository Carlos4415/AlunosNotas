// Este programa permite ao usuário inserir o nome de um aluno e suas notas.  
// Após receber as notas, o programa calcula a média aritmética e exibe o resultado.  
// O objetivo é demonstrar a entrada de dados, o uso de listas para armazenar as notas e cálculos básicos em C#.
Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();

// Adicione notas para alunos
notasAlunos["João"] = new List<double> { 8.5, 9.0, 7.5 };
notasAlunos["Maria"] = new List<double> { 7.0, 8.0, 6.5 };

foreach (var aluno in notasAlunos)
{
    double soma = 0;

    for (int i = 0; i < aluno.Value.Count; i++)
    {
        soma += aluno.Value[i];
    }

    double media = soma / aluno.Value.Count;

    Console.WriteLine($"Média de {aluno.Key}: {media}");
}