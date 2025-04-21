public class Police : EmergencyUnit
{
    public Police(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }
    
    public override bool CanHandle(string incidentType) => incidentType == "Crime";
    
    public override void RespondToIncident(Incident incident)
    {
        Console.WriteLine(
            string.Format(FormatResponse("responding to crime scene"), 
            incident.Location
        );
    }
}
