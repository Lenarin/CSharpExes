namespace Ex3_Decorator
{
    public class Cinnamon : Dop
    {
        public Cinnamon(Product next, Size size) : base("Корица", 10, next, size)
        {
        }
    }
}