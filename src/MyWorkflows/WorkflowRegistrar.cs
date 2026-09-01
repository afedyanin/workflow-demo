using Microsoft.Extensions.DependencyInjection;
using MyWorkflows.Steps;
using WorkflowCore.Interface;

namespace MyWorkflows;

public static class WorkflowRegistrar
{
    public static IServiceCollection AddWorkflowSteps(this IServiceCollection services)
    {
        services.AddTransient<HelloWorld>();
        services.AddTransient<GoodbyeWorld>();
        return services;
    }

    public static void UseWorkflows(this IWorkflowHost workflowHost)
    {
        workflowHost.RegisterWorkflow<HelloWorkflow>();
    }
}
