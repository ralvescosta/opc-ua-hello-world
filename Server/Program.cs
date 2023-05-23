using BatchPlant;
using Opc.Ua.Configuration;

Console.WriteLine("Stating OPC UA Server...");

var application = new ApplicationInstance();
application.ApplicationType = Opc.Ua.ApplicationType.Server;
application.ConfigSectionName = "BatchPlantServer";

try {
  application.LoadApplicationConfiguration("/home/ralvescosta/Desktop/Rafael/csharp/opc-ua-hello-world/Server/BatchPlantServer.config.xml", false).Wait();

  /// If we check and force to use the certificate, the ApplicationInstance will check the dir '/usr/share\OPC Foundation\CertificateStores\MachineDefault'
  /// to get the certificates, we need to find a way to define the cert dir and how we can created this cerdiciates by our selfs
  // application.CheckApplicationInstanceCertificate(false, 0).Wait();

  application.Start(new BatchPlantServer()).Wait();
} catch(Exception e) {
  Console.WriteLine(e);
}


