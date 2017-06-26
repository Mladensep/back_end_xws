using BankApi.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BankApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceBank" in both code and config file together.
    [ServiceContract]
    public interface IServiceBank
    {
        [OperationContract]
        bool AddUplatnica(UplatnicaModel uplatnica);

    }
}
