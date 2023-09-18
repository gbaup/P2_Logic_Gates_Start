using System;
namespace Program;
class Program
{
    static void Main()
    {
        // Creamos la compuerta AND-1 y sus entradas
        CompuertaAND and1 = new CompuertaAND("AND-1");
        and1.AgregarEntrada("A", 1);
        and1.AgregarEntrada("B", 0);
        Console.WriteLine($"Resultado de {and1.GetNombre()}: {and1.Calcular()}");


        // Creamos la compuerta OR
        CompuertaOR or2 = new CompuertaOR("OR-2");
        or2.AgregarEntrada("C", 1);
        or2.AgregarEntrada("D", 1);
        Console.WriteLine($"Resultado de {or2.GetNombre()}: {or2.Calcular()}");

        // Y la compuerta NOT
        CompuertaNOT not3 = new CompuertaNOT("NOT-3");
        not3.AgregarEntrada("E", 0);
        Console.WriteLine($"Resultado de {not3.GetNombre()}: {not3.Calcular()}");


    }
}
