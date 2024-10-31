namespace taskD05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(5, 6);

            Base b1 = new Derived();
            b1.Show();
            Derived d1 = new Derived();
            d1.Show();

        }

    }
}
