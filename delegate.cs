internal class Program
{
    private static void Main(string[] args)
    {
        int[] values = { 4, 5, 6 };
        Util.Transform(values, Square);                    // Acoplamento dinâmico de método Square
        foreach (int i in values) Console.Write(i + " ");   // 1 4 9

        int Square(int x) => x * x;


        StringAction sa = new StringAction(ActOnObject);
        sa("hello");
        static void ActOnObject(object o) => Console.WriteLine(o);       // hello
    }
}

public delegate T Transformer<T>(T arg);           // Declaração de um tipo delegate com uso de genéricos

public class Util
{
  public static void Transform<T>(T[] values, Transformer<T> t)
  {
    for (int i = 0; i < values.Length; i++)
      values[i] = t(values[i]);
  }
}

delegate void StringAction(string s);