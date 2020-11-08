namespace Ex3_Decorator
{
    public class Chocolate : Dop
    {
        public Chocolate(Product next, Size size) : base("Шоколадная крошка", 15, next, size)
        {
        }
    }
}