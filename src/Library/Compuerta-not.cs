namespace Program
{
  public class CompuertaNOT : ICompuerta
  {
    private string nombre;
    private Tuple<string, double> entrada;

    public CompuertaNOT(string nombre)
    {
      this.nombre = nombre;
      this.entrada = Tuple.Create<string, double>(null, 0);
    }

    public string GetNombre()
    {
      return nombre;
    }

    public void AgregarEntrada(string conector, double valor)
    {
      entrada = Tuple.Create(conector, valor);
    }

    public double Calcular()
    {
      if (entrada.Item2 == 1)
      {
        return 0;
      }
      else if (entrada.Item2 == 0)
      {
        return 1;
      }
      else
      {
        return 1 - entrada.Item2;
      }
    }
  }
}