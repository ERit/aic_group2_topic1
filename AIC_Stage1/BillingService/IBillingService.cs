﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BillingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBillingService
    {
        [FaultContract(typeof(ArgumentException))]
        [OperationContract]
        IList<int> ListUsersBills(string username);

        [FaultContract(typeof(ArgumentException))]
        [OperationContract]
        BillDetails GetBill(int Id);

        [FaultContract(typeof(ArgumentException))]
        [OperationContract]
        void PayBill(int Id);

        [FaultContract(typeof(ArgumentException))]
        [OperationContract]
        void CalculateBillsForUser(string username);

        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    [DataContract]
    public class BillDetails
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int customerId { get; set; }
        [DataMember]
        public string customerUsername { get; set; }

        [DataMember]
        public double amount { get; set; }
        [DataMember]
        public bool isPayed { get; set; }
    }



    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
