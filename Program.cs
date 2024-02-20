using ExerciciosPOO;

// Exercicio 1.

//Console.WriteLine("Calcular Área e perímetro do circulo.\n\nDigite o valor do raio do circulo: ");
//double raio = double.Parse(Console.ReadLine());

//Circulo circulo = new Circulo();
//circulo.ExibirInformacoes();

//

// Exercicio 2.

//Console.WriteLine("Conta Bancaria.\n\nDigite o número da conta bancaria: ");
//string numeroConta = Console.ReadLine();

//Console.WriteLine("Digite o nome do titular: ");
//string nomeTitular = Console.ReadLine();

//Console.WriteLine("Insira o saldo inicial da conta: ");
//double saldoInicial = double.Parse(Console.ReadLine());

//Console.WriteLine("Você deseja realizar um deposito? (S/N): ");
//string deposito = Console.ReadLine();

//Console.WriteLine("Você deseja fazer um saque?: (S/N): ");
//string saque = Console.ReadLine();

//ContaBancaria conta = new ContaBancaria(numeroConta, nomeTitular, saldoInicial);
//conta.Depositar(deposito);
//conta.Sacar(saque);
//conta.ExibirInformacoes();

//

// Exercicio 3.

//Console.WriteLine("Calcular Área do retângulo.\n\nDigite a altura no retângulo: ");
//double altura = double.Parse(Console.ReadLine());

//Console.WriteLine("Digite a largura no retângulo: ");
//double largura = double.Parse(Console.ReadLine());

//Retangulo retangulo = new Retangulo(altura, largura);
//retangulo.ExibirInformacoes();

//

// Exercicio 4.

//Console.WriteLine("Média dos alunos.\n\nDigite o nome do aluno: ");
//string nome = Console.ReadLine();

//Console.WriteLine("Digite a matrícula do aluno: ");
//int matricula = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite as notas do aluno separada por espaços");
//double[] notas = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

//Aluno aluno = new Aluno(nome, matricula, notas);
//aluno.DefinirNotas(notas);
//aluno.ExibirInformacoes();

//

// Exercicio 5

//Console.WriteLine("Salário Líquido.\n\nDigite o nome do funcionário: ");
//string nome = Console.ReadLine();

//Console.WriteLine("Digite o salário do funcionário: ");
//double salario = double.Parse(Console.ReadLine());

//Console.WriteLine("Digite o cargo do funcionario: ");
//string cargo = Console.ReadLine();

//Console.WriteLine("Qual o valor dos impostos?: ");
//double impostos = double.Parse(Console.ReadLine());

//Console.WriteLine("Ouve benefícios esse mês? (S/N): ");
//string beneficio = Console.ReadLine();

//Funcionario funcionario = new Funcionario();
//funcionario.Nome = nome;
//funcionario.Salario = salario;
//funcionario.Cargo = cargo;
//funcionario.Impostos = impostos;
//funcionario.OuveBeneficio(beneficio);
//funcionario.ExibirInformacoes();

//

// Exercicio 6

//Random random = new Random();

//// Gerar um número aleatório entre 0 e 100
//int qntdEstoque = random.Next(0, 1000);

//Console.WriteLine("Produtos e estoque\n\nDigite o Nome do produto: ");
//string nome = Console.ReadLine();

//Console.WriteLine("Digite o valor do produto: ");
//double valor = double.Parse(Console.ReadLine());

//Produto produto = new Produto(nome, valor, qntdEstoque);
//produto.ExibirInformacoes();

//

// Exercicio 7

//Console.WriteLine("Área do triângulo.\n\nDigite os três lados separados por espaço. Ex: \"3 4 5\"");
//double[] lados = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

//Triangulo triangulo = new Triangulo(lados);
//triangulo.ValidarTriangulo();

//

// Exercicio 8

//Console.WriteLine("Carro em movimento.\n\nDigite a marca do carro: ");
//string marca = Console.ReadLine();

//Console.WriteLine("Digite o modelo do carro: ");
//string modelo = Console.ReadLine();

//Console.WriteLine("Digite a velocidade atual do carro: ");
//double velocidadeAtual = double.Parse(Console.ReadLine());

//Carro carro = new Carro(marca, modelo, velocidadeAtual);
//carro.IniciarControleCarro();

//

// Exercicio 9

//Console.WriteLine("Pacientes.\n\nDigite o nome do Paciente: ");
//string nome = Console.ReadLine();

//Console.WriteLine("Digite a idade do paciente: ");
//int idade = int.Parse(Console.ReadLine());

//Paciente paciente = new Paciente(nome, idade);
//paciente.AddConsulta();
//paciente.ExibirConsultas();

//

// Exercicio 10

//Console.WriteLine("Biblioteca.\n\nDigite o nome do livro: ");
//string nome  = Console.ReadLine();

//Console.WriteLine("Digite a quantidade de páginas qu o livro contem: ");
//int qntdPags = int.Parse(Console.ReadLine());

//Livro livro = new Livro(nome, qntdPags);
//livro.OpcoesLivro();