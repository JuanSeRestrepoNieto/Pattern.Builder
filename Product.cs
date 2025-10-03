namespace PatternBuilder
{
  public class Product
  {
    private List<string> parts = new List<string>();

    public void Add(string part)
    {
      this.parts.Add(part);
    }

    public string ListParts()
    {
      string str = string.Empty;

      for (int i = 0; i < this.parts.Count; i++)
      {
        str += this.parts[i] + ", ";
      }

      str = str.Remove(str.Length - 2); // removing last ", "

      return "Product parts: " + str + "\n";
    }
  }
}