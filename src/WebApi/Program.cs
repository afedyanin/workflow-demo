using WorkflowCore.Interface;
using MyWorkflows;

namespace WebApi;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddOpenApi();
        builder.Services.AddWorkflow();
        builder.Services.AddWorkflowSteps();

        var app = builder.Build();

        var host = app.Services.GetRequiredService<IWorkflowHost>();
        host.UseWorkflows();
        host.Start();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/openapi/v1.json", "v1");
            });
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
