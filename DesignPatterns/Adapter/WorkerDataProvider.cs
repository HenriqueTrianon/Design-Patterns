using System.Collections.Generic;

namespace Adapter
{
    public static class WorkerDataProvider
    {
        public static List<Worker> GetData() => new List<Worker>(){ new Worker(){Name = "Henrique Trianon", Position = "Developer",Salary = 5000},
                                                                  new Worker(){Name = "Samiramis Gracielly",Position = "Designer", Salary = 4500},
                                                                  new Worker(){Name = "Jonh Doe", Position = "Manager", Salary = 8000}
        };
    }
}
