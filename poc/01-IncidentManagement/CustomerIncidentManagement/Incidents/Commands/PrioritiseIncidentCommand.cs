using CustomerIncidentManagement.Incidents.Models;

namespace CustomerIncidentManagement.Incidents.Commands;

public record PrioritiseIncidentCommand(
    Guid IncidentId,
    IncidentPriority Priority,
    Guid PrioritisedBy
);
