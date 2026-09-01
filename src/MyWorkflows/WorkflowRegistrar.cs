using WorkflowCore.Interface;

namespace MyWorkflows;

public static class WorkflowRegistrar
{
    public static void RegisterWorkflows(this IWorkflowHost workflowHost)
    {
        workflowHost.RegisterWorkflow<HelloWorkflow>();
    }
}
