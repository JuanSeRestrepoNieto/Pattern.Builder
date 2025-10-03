namespace PatternBuilder
{ 
  public class Director
  {
    private IBuilder builder;

    public IBuilder Builder
    {
      set { this.builder = value; }
    }

    // The Director can construct several product variations using the same
    // building steps.
    public void BuildMinimalViableProduct()
    {
      this.builder.BuildPartA();
    }

    public void BuildFullFeaturedProduct()
    {
      this.builder.BuildPartA();
      this.builder.BuildPartB();
      this.builder.BuildPartC();
    }
  }
}