using CustomerIncidentManagement.Incidents.Models;

namespace CustomerIncidentManagement.Incidents.Commands;

public record LogIncidentCommand(
    Guid IncidentId,
    Guid CustomerId,
    Contact Contact,
    string Description,
    Guid LoggedBy
);