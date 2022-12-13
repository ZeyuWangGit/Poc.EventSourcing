using CustomerIncidentManagement.Incidents.Models.Enums;

namespace CustomerIncidentManagement.Incidents.Commands;

public record ResolveIncidentCommand(
    Guid IncidentId,
    ResolutionType Resolution,
    Guid ResolvedBy
);