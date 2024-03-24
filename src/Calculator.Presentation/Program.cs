﻿using Calculator.Application.Add;
using Calculator.Application.Services;
using Calculator.Application.Subtract;
using Calculator.Domain;
using Calculator.Infrastructure.Services;
using Calculator.Presentation;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddTransient<ICalculatorService, CalculatorService>();
services.AddTransient<RequestFacade>();
services.AddTransient<CalculatorRequestHandlerFactory>();
services.AddTransient<AddRequestHandler>();
services.AddTransient<SubtractRequestHandler>();

var provider = services.BuildServiceProvider();


string headline = @"
     a88888b.          dP                   dP            dP                     
    d8'   `88          88                   88            88                     
    88        .d8888b. 88 .d8888b. dP    dP 88 .d8888b. d8888P .d8888b. 88d888b. 
    88        88'  `88 88 88'  `88 88    88 88 88'  `88   88   88'  `88 88'  `88 
    Y8.   .88 88.  .88 88 88.  ... 88.  .88 88 88.  .88   88   88.  .88 88       
     Y88888P' `88888P8 dP `88888P' `88888P' dP `88888P8   dP   `88888P' dP
_______________________________________________________________________________________";

Console.WriteLine(headline);

int x, y;
char sign;
Console.Write("Enter first number: ");
if (!int.TryParse(Console.ReadLine(), out x))
{
    Console.WriteLine("Invalid number. Please enter a valid number.");
    return;
}

Console.Write("Enter sign: ");
sign = Console.ReadKey().KeyChar;

Console.Write("\nEnter second number: ");
if (!int.TryParse(Console.ReadLine(), out y))
{
    Console.WriteLine("Invalid number. Please enter a valid number.");
    return;
}

var requestFacade = provider.GetService<RequestFacade>();

var result = requestFacade.SendRequest(x, y, sign);

Console.WriteLine("\nResult: ");
Console.WriteLine(result);
