// POLIMORFISMO: Mesma variável tipo base, objetos diferentes
Funcionario f1 = new Gerente { Nome = "Alice", Bonus = 1000 };
Funcionario f2 = new Vendedor { Nome = "Marcos", Comissao = 500 };

// POLIMORFISMO: Mesmo método, comportamentos diferentes
f1.ExibirInfo();  // Chama a versão de Gerente
f2.ExibirInfo();  // Chama a versão de Vendedor

Console.WriteLine($"\nTotal da folha: R${(f1.CalcularSalario() + f2.CalcularSalario()):F2}");

public abstract class Funcionario
{
    // ENCAPSULAMENTO: Campo privado com propriedade pública
    private string _nome;

    public string Nome
    {
        get => _nome;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _nome = value;
        }
    }

    // ABSTRAÇÃO: Método abstrato - cada tipo implementa sua lógica
    public abstract decimal CalcularSalario();

    // Método para exibir informações (pode ser sobrescrito)
    public virtual void ExibirInfo()
    {
        Console.WriteLine($"{Nome} recebe R${CalcularSalario():F2}");
    }
}

// HERANÇA: Gerente herda de Funcionario
public class Gerente : Funcionario
{
    // ENCAPSULAMENTO: Controla acesso ao bônus
    private decimal _bonus;

    public decimal Bonus
    {
        get => _bonus;
        set => _bonus = value >= 0 ? value : 0;
    }

    // POLIMORFISMO: Implementação específica de CalcularSalario()
    public override decimal CalcularSalario() => 5000 + Bonus;

    // POLIMORFISMO: Sobrescreve comportamento do método base
    public override void ExibirInfo()
    {
        Console.WriteLine($"{Nome} (Gerente) recebe R${CalcularSalario():F2} " +
                         $"(Salário: R${CalcularSalario()-Bonus:F2} + Bônus: R${Bonus})");
    }
}

// HERANÇA: Vendedor herda de Funcionario
public class Vendedor : Funcionario
{
    // ENCAPSULAMENTO: Controla o acesso à comissão
    private decimal _comissao;

    public decimal Comissao
    {
        get => _comissao;
        set => _comissao = value >= 0 ? value : 0;
    }

    // POLIMORFISMO: Implementação específica de CalcularSalario
    public override decimal CalcularSalario() => 3000M + Comissao;

    // POLIMORFISMO: Sobrescreve comportamento do método base
    public override void ExibirInfo()
    {
        Console.WriteLine($"{Nome} (Vendedor) recebe R${CalcularSalario():F2} " +
                         $"(Salário: R${CalcularSalario()-Comissao:F2} + Comissão: R${Comissao})");
    }
}
