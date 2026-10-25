using System;
using System.Globalization;

Console.Write("Salário base (ex.: 1500.00): ");
double salario double.Parse(Console.ReadLine() ?? "0", CultureInfo. InvariantCulture);
Console.Write("Comissão (%): ");
double percentual double.Parse(Console.ReadLine() ?? "0", CultureInfo. InvariantCulture);

if (salario || percentual < 0) {
    Console.WriteLine("Valores invalidos.");
} else {
    double comissao salario percentual / 100;
    Console.WriteLine($"Comissão: R$ (comissao:F2]");
    Console.WriteLine($"Total: R$ (salario comissao:F2]");
}
