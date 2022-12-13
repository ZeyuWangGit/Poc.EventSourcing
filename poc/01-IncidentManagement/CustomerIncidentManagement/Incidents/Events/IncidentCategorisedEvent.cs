using CustomerIncidentManagement.Incidents.Models.Enums;

namespace CustomerIncidentManagement.Incidents.Events;

public record IncidentCategorisedEvent(
    Guid IncidentId,
    IncidentCategory Category,
    Guid CategorisedBy,
    DateTimeOffset CategorisedAt
);