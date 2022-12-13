namespace CustomerIncidentManagement.Incidents.Commands;

public record AcknowledgeResolutionCommand(
    Guid IncidentId,
    Guid AcknowledgedBy
);