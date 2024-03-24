using Microsoft.Extensions.DependencyInjection;
using Calculator.Presentation;
using Calculator.Infrastructure;
using Calculator.Application;


var services = new ServiceCollection();

services.InstallInfrastructure();
services.InstallApplication();
services.InstallPresentation();

var serviceProvider = services.BuildServiceProvider();

var consoleApp = serviceProvider.GetService<App>();
consoleApp.Run();
