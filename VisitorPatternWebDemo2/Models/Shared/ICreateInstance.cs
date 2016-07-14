namespace VisitorPatternWebDemo2.Models.Shared
{
    public interface ICreateInstance<out T>
    {
        T Create();
    }
}