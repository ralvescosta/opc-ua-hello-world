// See https://aka.ms/new-console-template for more information
using Opc.Ua.Configuration;


Console.WriteLine("Stating OPC UA Server...");

var application = new ApplicationInstance();
application.ApplicationType = Opc.Ua.ApplicationType.Server;
application.ConfigSectionName = "BatchPlantServer";
application.LoadApplicationConfiguration("/home/ralvescosta/Desktop/Rafael/csharp/opc-ua-hello-world/Server/BatchPlantServer.config.xml", false).Wait();
application.CheckApplicationInstanceCertificate(false, 0).Wait();
