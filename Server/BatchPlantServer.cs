using Opc.Ua;
using Opc.Ua.Server;

namespace BatchPlant {
  class BatchPlantServer : StandardServer 
  {
    protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
    {
      Utils.Trace("Creating the Node Manager");

      var nodeManagers = new List<INodeManager>();
      nodeManagers.Add(new BatchPlantNodeManager(server, configuration));

      return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
    }

    protected override ServerProperties LoadServerProperties()
    {
      var properties = new ServerProperties();

      properties.ManufacturerName = "ralvescosta";
      properties.ProductName = "BatchPlant InformationModel Server";
      properties.ProductUri = "http://opcfundation.org/BatchPlant/InformationModelServer/v1.0";
      properties.SoftwareVersion = Utils.GetAssemblySoftwareVersion();
      properties.BuildNumber = Utils.GetAssemblyBuildNumber();
      properties.BuildDate = Utils.GetAssemblyTimestamp();

      return properties;
    }
  }
}