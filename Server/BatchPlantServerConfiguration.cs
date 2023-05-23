using System.Runtime.Serialization;

namespace BatchPlant 
{
  [DataContract(Namespace = Namespaces.BatchPlant)]
  public class BatchPlantServerConfiguration 
  {

    public BatchPlantServerConfiguration() 
    {
      Initialize();
    }


    [OnDeserialized()]
    private void Initialize(StreamingContext context) 
    {
      Initialize();
    }

    private void Initialize() 
    {
    }
  }
}