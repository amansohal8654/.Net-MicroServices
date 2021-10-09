# .NET Microservices using the REST API pattern

## Description

Working with .net core 5 and dedicated persistence layer for multiple services.
Using Docker for containerization and Deploying our services to Kubernetes cluster.
Employing the API Gateway pattern to route to our services.
Building Synchronous messaging between services (HTTP & gRPC).

## Running the Solution

To run the solution you will need the dotnet CLI which can be installed by issuing the following command in a powershell terminal:

`dotnet-install.ps1 -Channel 5.0 -Runtime aspnetcore`

More information can be found here: https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net50

To run the solution browse to the root directory in a terminal and issue the following command:

`dotnet run --project WebApi`