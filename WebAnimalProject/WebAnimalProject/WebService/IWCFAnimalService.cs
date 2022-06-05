using AnimalsEntity;
using System.Collections.Generic;
using System.ServiceModel;

namespace WebAnimalProject.WebService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IWCFAnimalService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IWCFAnimalService
    {
        [OperationContract]
        bool AddAnimal(string name, int age, double weight);

        [OperationContract]
        bool AddMammal(string name, double temp, bool isIswimming);

        [OperationContract]
        bool AddAtri(string name, int h_count, bool isRum);

        [OperationContract]
        bool AddBird(string name, Color wings, bool isTalking);

        [OperationContract]
        List<Animal> GetAnimals();

        [OperationContract]
        List<Mammal> GetMammals();

        [OperationContract]
        List<Artiodactyls> GetArti();

        [OperationContract]
        List<Bird> GetBirds();

        [OperationContract]
        bool RemoveAnimals();

        [OperationContract]
        bool RemoveMammals();

        [OperationContract]
        bool RemoveArti();

        [OperationContract]
        bool RemoveBirds();
    }
}
