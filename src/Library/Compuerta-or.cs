namespace Program
{
  public class CompuertaOR : ICompuerta
  {
    private string nombre;
    private Dictionary<string, double> entradas;

    public CompuertaOR(string nombre)
    {
      this.nombre = nombre;
      this.entradas = new Dictionary<string, double>();
    }

    public string GetNombre()
    {
      return nombre;
    }

    public void AgregarEntrada(string conector, double valor)
    {
      entradas[conector] = valor;
    }

    public double Calcular()
    {
      double suma = 0;
      foreach (var valor in entradas.Values)
      {
        suma += valor;
      }
      if (suma == 2)
        suma = 1;

      return suma;
    }
  }

}