namespace CustomerIncidentManagement.Incidents.Events;

public record IncidentClosedEvent(
    Guid IncidentId,
    Guid ClosedBy,
    DateTimeOffset ClosedAt
);