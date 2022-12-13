using CustomerIncidentManagement.Incidents.Models.Enums;

namespace CustomerIncidentManagement.Incidents.Commands;

public record CategoriseIncidentCommand(
    Guid IncidentId,
    IncidentCategory Category,
    Guid CategorisedBy
);