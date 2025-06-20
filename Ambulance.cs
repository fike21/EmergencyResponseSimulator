public class Ambulance : EmergencyUnit
{
    public Ambulance(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }
    
    public override bool CanHandle(string incidentType) => incidentType == "Medical";
    
    public override void RespondToIncident(Incident incident)
    {
        Console.WriteLine(
            string.Format(FormatResponse("providing medical aid"), 
            incident.Location
        );
    }
}
