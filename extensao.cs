Console.WriteLine("Perth".IsCapitalized());               // True

// Equivalnete a:
Console.WriteLine(StringHelper.IsCapitalized("Perth"));   // True

// Interfaces também podem ser estendidas
Console.WriteLine("Seattle".First());                     // S

public static class StringHelper
{
  public static bool IsCapitalized (this string s)        // Aplicação do modificador this
  {
    if (string.IsNullOrEmpty(s)) return false;
      return char.IsUpper(s[0]);
  }

  public static T First<T>(this IEnumerable<T> sequence)    // Estendendo interface IEnumerable
  {
    foreach (T element in sequence)
      return element;

    throw new InvalidOperationException("No elements!");
  }
}