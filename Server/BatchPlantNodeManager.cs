using Opc.Ua;
using Opc.Ua.Server;

namespace BatchPlant 
{
  public class BatchPlantNodeManager : CustomNodeManager2
  {
    private BatchPlantServerConfiguration myConfiguration;
    private static BatchPlantState myBatchPlant1;
    private System.Threading.Timer mySimulationTimer;

    public BatchPlantNodeManager(IServerInternal server, ApplicationConfiguration configuration, params string[] namespaceUris) : 
      base(server, configuration, namespaceUris)
    {
      SystemContext.NodeIdFactory = this;

      var namespaceUrls = new string[2];
      namespaceUrls[0] = BatchPlant.Namespaces.BatchPlant;
      namespaceUrls[1] = BatchPlant.Namespaces.BatchPlant + "/Instance";
      SetNamespaces(namespaceUrls);

      myConfiguration = configuration.ParseExtension<BatchPlantServerConfiguration>();
      if (myConfiguration == null) 
      {
        myConfiguration = new BatchPlantServerConfiguration();
      }
    }

    protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
    {
      var predefinedNodes = new NodeStateCollection();

      predefinedNodes.LoadFromBinaryResource(
        context, 
        "/home/ralvescosta/Desktop/Rafael/csharp/opc-ua-hello-world/Server/NodeSet2/BatchPlant.PredefinedNodes.uanodes", 
        typeof(BatchPlantNodeManager).GetType().Assembly, 
        true
      );

      return predefinedNodes;
    }

    public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences) 
    {
      lock(Lock) 
      {
        LoadPredefinedNodes(SystemContext, externalReferences);

        var passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(BatchPlant.Objects.BatchPlant1,  NamespaceIndexes[0]), typeof(BaseObjectState));

         // convert the untyped node to a typed node that can be manipulated within the server.
        myBatchPlant1 = new BatchPlantState(null);
        myBatchPlant1.Create(SystemContext, passiveNode);

        // replaces the untyped predefined nodes with their strongly typed versions.
        AddPredefinedNode(SystemContext, myBatchPlant1);

        myBatchPlant1.StartProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStartProcess);
        myBatchPlant1.StopProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStopProcess);

        mySimulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);
      }
    }

    public void DoSimulation(object state)
    {
      myBatchPlant1.Mixer.LoadcellTransmitter.Output.Value = 85;
    }

    private ServiceResult OnStartProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
    {
      return ServiceResult.Good;
    }

    private ServiceResult OnStopProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
    {
      return ServiceResult.Good;
    }
  }
}