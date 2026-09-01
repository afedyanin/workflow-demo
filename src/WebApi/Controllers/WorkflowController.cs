using Microsoft.AspNetCore.Mvc;
using WorkflowCore.Interface;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkflowController : ControllerBase
{
    private readonly IWorkflowHost _workflowHost;
    private readonly ILogger<WorkflowController> _logger;

    public WorkflowController(
        IWorkflowHost workflowHost,
        ILogger<WorkflowController> logger)
    {
        _workflowHost = workflowHost;
        _logger = logger;
    }

    [HttpPost]
    public async Task<string> PostAsync([FromBody] string workflowId)
    {
        _logger.LogInformation("Starting workflow={WorkflowId}", workflowId);
        var id = await _workflowHost.StartWorkflow(workflowId);
        _logger.LogInformation("Workflow completed. {WorkflowId} id={Id}", workflowId, id);

        return id;
    }
}
