// Cria uma nova conta bancária
ContaBancaria conta = new ContaBancaria();

// Exibe o saldo inicial (será 0.0 por padrão)
Console.WriteLine($"Saldo inicial: R$ {conta.Saldo}");

// Realiza um depósito válido
conta.Depositar(100.50);
Console.WriteLine($"Saldo após depósito de R$ 100,50: R$ {conta.Saldo}");

// Tenta depositar um valor inválido
conta.Depositar(-50);
Console.WriteLine($"Saldo após tentar depositar R$ -50: R$ {conta.Saldo}");

// Realiza outro depósito válido
conta.Depositar(250.75);
Console.WriteLine($"Saldo final: R$ {conta.Saldo}");

// Classe que representa uma conta bancária básica
public class ContaBancaria
{
    // Campo privado que armazena o saldo real da conta
    // A palavra private garante que só pode ser acessado dentro da classe
    private double saldo;

    // Propriedade pública que controla o acesso ao saldo
    public double Saldo
    {
        // Qualquer código pode ler o saldo
        get { return saldo; }

        // Set privado: somente os métodos da classe podem modificar o saldo diretamente
        private set { saldo = value; }
    }

    // Método público para depositar dinheiro na conta
    public void Depositar(double valor)
    {
        // Valida se o valor é positivo antes de adicionar ao saldo
        if (valor > 0)
        {
            // Usa a propriedade Saldo para adicionar o valor
            // Internamente, acessa o setter privado que modifica o campo saldo
            Saldo += valor;
        }
    }
}