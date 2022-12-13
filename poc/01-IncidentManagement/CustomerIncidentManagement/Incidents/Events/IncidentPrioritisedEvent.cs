using CustomerIncidentManagement.Incidents.Models;

namespace CustomerIncidentManagement.Incidents.Events;

public record IncidentPrioritisedEvent(
    Guid IncidentId,
    IncidentPriority Priority,
    Guid PrioritisedBy,
    DateTimeOffset PrioritisedAt
);