using Microsoft.Extensions.Logging;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace MyWorkflows.Steps;

internal sealed class GoodbyeWorld : StepBodyAsync
{
    private readonly ILogger _logger;

    public GoodbyeWorld(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<GoodbyeWorld>();
    }

    public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        await Task.Delay(1, context.CancellationToken);
        _logger.LogInformation("Goodbye world!");
        return ExecutionResult.Next();
    }
}
