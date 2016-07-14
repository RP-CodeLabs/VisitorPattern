namespace VisitorPatternWebDemo2.Models.Shared
{
    public class CreateInstance<T> : ICreateInstance<T> where T : new()
    {
        T ICreateInstance<T>.Create()
        {
            return new T();
        }
    }
}