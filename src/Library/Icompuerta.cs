namespace Program;

public interface ICompuerta
{
  string GetNombre();
  void AgregarEntrada(string conector, double valor);
  double Calcular();
}