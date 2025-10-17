// Cria um objeto Carro usando inicializador de objeto { }
// Esta sintaxe permite definir as propriedades durante a criação
Carro meuCarro = new Carro
{
    Modelo = "Sedan",        // Propriedade herdada de Veiculo
    NumeroPortas = 4         // Propriedade específica de Carro
};

// Chama o método Ligar() que foi herdado da classe Veiculo
// Mesmo não estando definido na classe Carro, está disponível pela herança
meuCarro.Ligar();

// Exibe as informações do carro
Console.WriteLine($"Modelo: {meuCarro.Modelo}");
Console.WriteLine($"Número de portas: {meuCarro.NumeroPortas}");

// Demonstração adicional: criando um veículo genérico
Veiculo veiculo = new Veiculo { Modelo = "Genérico" };
veiculo.Ligar();
// veiculo.NumeroPortas causaria erro - propriedade não existe em Veiculo

// Classe base que representa um veículo genérico
public class Veiculo
{
    // Propriedade que armazena o modelo do veículo
    public string Modelo { get; set; }

    // Método que simula a ação de ligar o veículo
    public void Ligar() => Console.WriteLine("Veículo ligado!");
}

// Classe Carro herda todas as propriedades e métodos públicos da classe Veiculo
public class Carro : Veiculo
{
    // Propriedade específica da classe Carro
    // Não existe na classe base Veiculo
    public int NumeroPortas { get; set; }
}

