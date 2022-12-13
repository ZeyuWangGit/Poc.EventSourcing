using CustomerIncidentManagement.Incidents.Commands;
using CustomerIncidentManagement.Incidents.Events;
using CustomerIncidentManagement.Incidents.Models;
using CustomerIncidentManagement.Incidents.Models.Enums;

namespace CustomerIncidentManagement.Incidents;

public static class IncidentCommandHandler
{
    public static IncidentLoggedEvent Handle(LogIncidentCommand command)
    {
        var (incidentId, customerId, contact, description, loggedBy) = command;
        return new IncidentLoggedEvent(incidentId, customerId, contact, description, loggedBy, DateTimeOffset.UtcNow);
    }

    public static IncidentCategorisedEvent Handle(Incident current, CategoriseIncidentCommand command)
    {
        if (current.Status == IncidentStatus.Closed)
        {
            throw new InvalidOperationException("Incident Already Closed");
        }

        var (incidentId, incidentCategory, categorisedBy) = command;
        return new IncidentCategorisedEvent(incidentId, incidentCategory, categorisedBy, DateTimeOffset.Now);
    }

}