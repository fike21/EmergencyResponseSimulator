public class Incident
{
    public string Type { get; }
    public string Location { get; }
    
    public Incident(string type, string location)
    {
        Type = type;
        Location = location;
    }
}
