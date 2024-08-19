﻿using ExemploFundamentos.Models;

// Cast - Casting
int a = Convert.ToInt32(null); // O Convert "trata" o null como 0, evita erros
int b = int.Parse("5");
string c = 5.ToString();

// Casting implícito
int d = 5;
double e = d;

// Casting seguro
string tal = "15-";
int tal2 = 0;
int.TryParse(tal, out tal2); // vai sair o valor de tal2, pois o parse não deu certo e ele manteve o valor original de tal2

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