namespace Hubster.Abstractions.Interfaces
{
    public interface IQueryValueModel
    {
        IQueryValueModel Add(string name, object value);
        IQueryValueModel Clear();
        IQueryValueModel Copy();
        //IQueryValueModel From(IQueryValueModel value);
        T Get<T>(string name, T defaultValue = default);
    }
}