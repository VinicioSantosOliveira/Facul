bool loop = true;
do
{
    Console.WriteLine("Informe seu nome: ");
    string? nome = Console.ReadLine();
    Console.WriteLine("Infome sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite sua altura: ");
    double altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite seu peso: ");
    int peso = Convert.ToInt32(Console.ReadLine());

    double imc = peso /(altura * altura);

    //IMC
    string IMC;

    if (imc <= 18.4)
    {
        IMC = "Abaixo do peso";
    }
    else if (imc >= 18.5 && imc <= 24.9)
    {
        IMC = "Peso ideal, Parabéns";
    }
    else if (imc >= 25 && imc <= 29.9)
    {
        IMC = "Levemente acima do peso";
    }
    else if (imc >= 30 && imc <= 34.9)
    {
        IMC = "Obesidade grau I";
    }
    else if (imc >= 35 && imc <= 39.9)
    {
        IMC = "Obesidade grau II(Severa)";
    }
    else
    {
        IMC = "Obesidade grau III(Morbida)";
    }

    //FAIXA ETARIA
    string faixaEtaria;

    if (idade <= 12)
    {
        faixaEtaria = "Criança";     
    }
    else if (idade >= 13 && idade <= 17)
    {
        faixaEtaria = "Adolescente";
    }
    else if (idade >= 18 && idade <= 64)
    {
        faixaEtaria = "Adulto";
    }
    else 
    {
        faixaEtaria = "Idoso";
    }

    //RELATORIO
    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Idade: {idade}");
    Console.WriteLine($"Faixa Etária: {faixaEtaria}");
    Console.WriteLine($"Imc: {imc} = {IMC}");

    
    //GERAR NOVO RELATORIO OU SAIR DO PROGRAMA
    Console.WriteLine("\nVoce quer gerar um novo relatorio? \ndigite 1 - fazer um novo relatorio \ndigite 2 - sair ");
    int opcao = Convert.ToInt32(Console.ReadLine());

    if (opcao == 1)
    {
        continue;
    }
    else
    {
        loop = false;
    }
    
} while (loop);

Console.WriteLine("Saindo...");