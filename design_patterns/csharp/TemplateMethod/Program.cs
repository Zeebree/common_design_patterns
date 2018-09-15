using TemplateMethod.Domain;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HotBeverage tea = new Tea();
            HotBeverage coffee = new Coffee();

            tea.Create();
            coffee.Create();
        }
    }
}
