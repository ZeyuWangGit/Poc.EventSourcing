namespace CustomerIncidentManagement.Incidents.Models.Enums;

public enum IncidentStatus
{
    Pending = 1,
    Resolved = 8,
    ResolutionAcknowledgedByCustomer = 16,
    Closed = 32
}