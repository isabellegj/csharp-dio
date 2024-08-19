using ExemploFundamentos.Models;

Calculadora calc = new Calculadora();

calc.Somar(4, 8);












// // Operadores Lógicos
// bool maiorDeIdade = true;
// bool possuiAutorizacao = false;

// // OR ou Pipe
// if(maiorDeIdade || possuiAutorizacao) {
//     Console.WriteLine("Não entra");
// }
// else {
//     Console.WriteLine("Entrou");
// }

// // AND &&
// bool presencaMinima = true;
// double media = 7.5;

// if(presencaMinima && media >= 7) {
//     Console.WriteLine("Aprovado");
// }
// else {Console.WriteLine("Reprovado");}

// // NOT !
// bool choveu = true;
// bool tarde = true;

// if(!choveu && !tarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else {
//     Console.Write("To indo");
// }








// Operadores Condicionais
// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Consoante");
//         break;
// }

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if(quantidadeCompra == 0) {
//     Console.WriteLine("Venda inválida");
// }
// else if(possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else {
//     Console.WriteLine("Desculpe, não temos a quantidade em estoque.");
// }











// Cast - Casting
// int a = Convert.ToInt32(null); // O Convert "trata" o null como 0, evita erros
// int b = int.Parse("5");
// string c = 5.ToString();

// // Casting implícito
// int d = 5;
// double e = d;

// // Casting seguro
// string tal = "15-";
// int tal2 = 0;
// int.TryParse(tal, out tal2); // vai sair o valor de tal2, pois o parse não deu certo e ele manteve o valor original de tal2









// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// string presentation = "Oláaa, tudo beimmm?";
// int quantity = 1;
// double size = 1.60;
// decimal price = 1.75M;
// bool trueOrFalse = true;

// Console.WriteLine(presentation);
// Console.WriteLine("Valor da variável quantity: " + quantity);
// Console.WriteLine("Valor da variável size: " + size.ToString("0.00"));
// Console.WriteLine("Valor da variável price: " + price);
// Console.WriteLine("Valor da variável trueOrFalse: " + trueOrFalse);

// Person person1 = new Person();

// person1.Name = "Izzy";
// person1.Age = 27;
// person1.Presentation();