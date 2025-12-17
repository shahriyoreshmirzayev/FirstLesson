namespace ConsoleApp1;

static class Calculatorr<T>
{
    public static T Add(T a, T b)
    {
        return (dynamic)a + (dynamic)b;
    }
}
