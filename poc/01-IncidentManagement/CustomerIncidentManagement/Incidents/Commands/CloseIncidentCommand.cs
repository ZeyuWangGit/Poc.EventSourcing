namespace CustomerIncidentManagement.Incidents.Commands;

public record CloseIncidentCommand(
    Guid IncidentId,
    Guid ClosedBy
);