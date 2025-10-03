namespace PatternBuilder
{
  public class ConcreteBuilder : IBuilder
  {
    private Product product = new Product();

    public ConcreteBuilder()
    {
      this.Reset();
    }

    public void Reset()
    {
      this.product = new Product();
    }

    public void BuildPartA()
    {
      this.product.Add("PartA");
    }

    public void BuildPartB()
    {
      this.product.Add("PartB");
    }

    public void BuildPartC()
    {
      this.product.Add("PartC");
    }

    public Product GetProduct()
    {
      Product result = this.product;

      this.Reset();

      return result;
    }
  }
}