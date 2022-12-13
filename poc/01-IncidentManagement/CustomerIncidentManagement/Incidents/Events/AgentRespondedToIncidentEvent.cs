using CustomerIncidentManagement.Incidents.Models;

namespace CustomerIncidentManagement.Incidents.Events;

public record AgentRespondedToIncidentEvent(
    Guid IncidentId,
    IncidentResponse.FromAgent Response,
    DateTimeOffset RespondedAt
);