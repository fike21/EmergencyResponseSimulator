public class Firefighter : EmergencyUnit
{
    public Firefighter(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }
    
    public override bool CanHandle(string incidentType) => incidentType == "Fire";
    
    public override void RespondToIncident(Incident incident)
    {
        Console.WriteLine(
            string.Format(FormatResponse("fighting fire"), 
            incident.Location
        );
    }
}
