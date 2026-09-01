using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace MyWorkflows.Steps;

internal sealed class HelloWorld : StepBodyAsync
{
    public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        Console.WriteLine($"Hello from {nameof(HelloWorld)} step!");
        await Task.Delay(1, context.CancellationToken);
        return ExecutionResult.Next();
    }
}
