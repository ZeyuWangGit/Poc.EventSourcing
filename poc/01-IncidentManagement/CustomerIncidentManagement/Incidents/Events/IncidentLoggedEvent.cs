using CustomerIncidentManagement.Incidents.Models;

namespace CustomerIncidentManagement.Incidents.Events;

public record IncidentLoggedEvent(
    Guid IncidentId,
    Guid CustomerId,
    Contact Contact,
    string Description,
    Guid LoggedBy,
    DateTimeOffset LoggedAt
);