using CustomerIncidentManagement.Incidents.Models.Enums;

namespace CustomerIncidentManagement.Incidents.Events;

public record IncidentResolvedEvent(
    Guid IncidentId,
    ResolutionType Resolution,
    Guid ResolvedBy,
    DateTimeOffset ResolvedAt
);