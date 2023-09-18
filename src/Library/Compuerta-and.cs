namespace Program
{
  public class CompuertaAND : ICompuerta
  {
    private string nombre;
    private Dictionary<string, double> entradas;

    public CompuertaAND(string nombre)
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
      double prod = 1;
      foreach (var valor in entradas.Values)
      {
        prod *= valor;
      }
      return prod;
    }
  }
}