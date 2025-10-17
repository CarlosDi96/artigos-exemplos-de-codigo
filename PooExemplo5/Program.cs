// Demonstração de polimorfismo:
// Declaramos a variável como tipo Animal (classe base),
// mas instanciamos um objeto Cachorro (classe derivada)
Animal meuCachorro = new Cachorro();

// Ao chamar EmitirSom(), é usado o método da classe REAL do objeto (Cachorro)
// e não da classe declarada (Animal) 
meuCachorro.EmitirSom(); // Saída: Au Au!

// Comparação: criando um animal genérico
Animal animal = new Animal();
animal.EmitirSom(); // Saída: Som genérico

// Array de animais com polimorfismo
Animal[] animais = new Animal[]
{
                new Animal(),      // Som genérico
                new Cachorro(),    // Au Au!
                new Cachorro()     // Au Au!
};

Console.WriteLine("\nDemonstrando polimorfismo com múltiplos animais:");

foreach (Animal a in animais)
{
    a.EmitirSom();
}


// Classe base que representa um animal genérico
public class Animal
{
    // Método virtual que pode ser sobrescrito pelas classes derivadas
    // A palavra-chave 'virtual' permite que classes filhas tenham sua própria implementação
    public virtual void EmitirSom() => Console.WriteLine("Som genérico");
}

// Classe Cachorro herda de Animal
public class Cachorro : Animal
{
    // Sobrescreve o método EmitirSom() da classe base
    // 'override' indica a substituição da implementação do método virtual da classe pai
    public override void EmitirSom() => Console.WriteLine("Au Au!");
}