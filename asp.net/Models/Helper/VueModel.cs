namespace asp.net.Models
{

[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class VueData : Attribute
{
    public VueData(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
}