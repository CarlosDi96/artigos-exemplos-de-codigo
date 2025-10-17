// Instancia um novo objeto da classe Pessoa
Pessoa pessoa1 = new Pessoa();

// Define o valor da propriedade Nome
pessoa1.Nome = "Carlos";

// Define o valor da propriedade Idade
pessoa1.Idade = 29;

// Chama o método Apresentar() que exibe a mensagem no console
pessoa1.Apresentar();



// Classe que representa uma pessoa com propriedades básicas
public class Pessoa
{
    // Propriedade para armazenar o nome
    public string Nome { get; set; }

    // Propriedade para armazenar a idade
    public int Idade { get; set; }

    // Método para apresentar uma pessoa
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}

