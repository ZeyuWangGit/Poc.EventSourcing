namespace CustomerIncidentManagement.Incidents.Events;

public record AgentAssignedToIncidentEvent(
    Guid IncidentId,
    Guid AgentId,
    DateTimeOffset AssignedAt
);