using MyWorkflows.Steps;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace MyWorkflows;

public class HelloWorkflow : IWorkflow
{
    public string Id => "HelloWorld";

    public int Version => 1;

    public void Build(IWorkflowBuilder<object> builder)
    {
        builder
            .UseDefaultErrorBehavior(WorkflowErrorHandling.Suspend)
            .StartWith<HelloWorld>()
            .Then<GoodbyeWorld>();
    }
}
