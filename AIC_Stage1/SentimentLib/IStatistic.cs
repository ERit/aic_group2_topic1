using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SentimentLib
{
    [ServiceContract]
    public interface IStatistic
    {
        [OperationContract]
        double getStatisticValue(string username);

    }
}
