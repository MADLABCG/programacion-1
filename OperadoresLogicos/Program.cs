// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores Logicos");

// Operadores lógicos
// Son aquellos que nos permiten combinar dos o más expresiones booleanas y obtener un resultado booleano.

bool boolean1 = 5 > 3; 
bool boolean2 = 10 < 4;

// && AND lógico (verdadero si ambas expresiones son verdaderas)
// || OR lógico (verdadero si al menos una expresión es verdadera)
// ! NOT lógico (invierte el valor de una expresión booleana)

Console.WriteLine("boolean1: " + boolean1);
Console.WriteLine("boolean2: " + boolean2);

Console.WriteLine("boolean1 && !boolean2: " + (boolean1 && !boolean2));
Console.WriteLine("boolean1 || boolean2: " + (!boolean1 || boolean2));
Console.WriteLine("!boolean1: " + (!boolean1));