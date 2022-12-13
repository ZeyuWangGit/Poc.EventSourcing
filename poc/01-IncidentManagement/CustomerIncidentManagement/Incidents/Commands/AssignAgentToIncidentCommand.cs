namespace CustomerIncidentManagement.Incidents.Commands;

public record AssignAgentToIncidentCommand(
    Guid IncidentId,
    Guid AgentId
);