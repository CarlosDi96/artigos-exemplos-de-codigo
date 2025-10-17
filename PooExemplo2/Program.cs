// Cria um retângulo e calcula sua área
Retangulo retangulo = new Retangulo();
retangulo.Largura = 5.0;
retangulo.Altura = 3.0;

// Chama o método CalcularArea() e exibe o resultado
double area = retangulo.CalcularArea();
Console.WriteLine($"A área do retângulo é: {area}");

// Polimorfismo: podemos usar a classe base como tipo
Forma forma = new Retangulo { Largura = 4.0, Altura = 6.0 };
Console.WriteLine($"Área usando polimorfismo: {forma.CalcularArea()}");
public abstract class Forma
{
    // Método abstrato que obriga as classes derivadas a implementarem
    // o cálculo da área de acordo com suas características específicas
    public abstract double CalcularArea();
}

// Classe Retangulo herda de Forma (indicado pelo símbolo :)
// Deve obrigatoriamente implementar todos os métodos abstratos da classe pai
public class Retangulo : Forma
{
    // Propriedade que armazena a largura do retângulo
    public double Largura { get; set; }

    // Propriedade que armazena a altura do retângulo
    public double Altura { get; set; }

    // Implementação do método abstrato
    // Override indica que estamos sobrescrevendo o método da classe base
    public override double CalcularArea() => Largura * Altura;
}

