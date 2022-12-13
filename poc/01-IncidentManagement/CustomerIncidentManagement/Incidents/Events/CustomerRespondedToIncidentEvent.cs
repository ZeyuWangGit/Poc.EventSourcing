using CustomerIncidentManagement.Incidents.Models;

namespace CustomerIncidentManagement.Incidents.Events;

public record CustomerRespondedToIncidentEvent(
    Guid IncidentId,
    IncidentResponse.FromCustomer Response,
    DateTimeOffset RespondedAt
);