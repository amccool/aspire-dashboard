using AspireDashboard.Extensions;
using OpenTelemetry.Resources;

var builder = WebApplication.CreateBuilder(args);


//builder.Services.AddOpenTelemetry()
//    .ConfigureResource(r => r.AddService("Sample App"))
//    .WithTracing(tracerProviderBuilder => {
//        //tracerProviderBuilder.AddAspNetCoreInstrumentation();
//    });


//Environment varible to set the OTLP endpoint
//internal const string DashboardOtlpUrlVariableName = "DOTNET_DASHBOARD_OTLP_ENDPOINT_URL";
//internal const string DashboardOtlpUrlDefaultValue = "http://0.0.0.0:18889";

builder.Services.AddAspireDashboard();




var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
