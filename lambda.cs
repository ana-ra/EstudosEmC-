
internal partial class Program
{
    private static void Main(string[] args)
    {
        Transformer sqr = x => x * x;
        Console.WriteLine(sqr(3));                       // 9

        // Usando um bloco como corpo da expressão
        Transformer sqrBlock = x => { return x * x; };
        Console.WriteLine(sqrBlock(3));                  // 9

        // Usando um delegate genérico
        Func<int, int> sqrFunc = x => x * x;
        Console.WriteLine(sqrFunc(3));                   // 9

        // Sem argumentos
        Func<string> greeter = () => "Hello, world";
        Console.WriteLine(greeter());                    // Hello, world

        // Com tipagem implícita
        var greeter2 = () => "Hello, world";
        Console.WriteLine(greeter2());                   // Hello, world

        // Usando múltiplos argumentos
        Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;
        int total = totalLength("hello", "world");
        Console.WriteLine(total);                        // 10

        // Explicitamente especificando os parâmetros
        Func<int, int> sqrExplicit = (x) => x * x;
        Console.WriteLine(sqrExplicit(3));               // 9

        Action[] actions = new Action[3];
        int i = 0;
        actions[0] = () => Console.Write(i);
        i = 1;
        actions[1] = () => Console.Write(i);
        i = 2;
        actions[2] = () => Console.Write(i);
        i = 3;
        foreach(Action a in actions) a();    // 333
        //A solução nesse caso, se quisermos escrever o valor 012
        //é definir a variável de iteração para uma variável local, que esteja dentro do escopo:
        //Action[] actions = new Action[3];

        //for (int i = 0; i < 3; i++)
       // {
       //     int loopScopedi = i;
       //     actions[i] = () => Console.Write(loopScopedi);
       // }

       // foreach (Action a in actions) a();
    }
}

delegate int Transformer(int i);
