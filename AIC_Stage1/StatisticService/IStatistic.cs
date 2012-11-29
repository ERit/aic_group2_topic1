using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StatisticService
{
    [ServiceContract]
    public interface IStatistic
    {
        [OperationContract]
        double getStatisticValue(string username);

    }
}
