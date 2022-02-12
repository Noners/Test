public class SingletonClass<T> where T : new()
{
    public static readonly T Instance = new T();
}
