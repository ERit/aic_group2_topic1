using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BillingService
{
    public class BillingService : IBillingService
    {

        public IList<int> ListUsersBills(string username)
        {
            IList<int> result = new List<int>();
            try
            {
                User u = User.getByUsername(username);
                if (u != null) // if user does not exist, silenty ignore this (prevent user enumeration (not really))
                {
                    IList<Bill> bills = BillDao.getByUserId(u.id);
                    for (IEnumerator<Bill> e = bills.GetEnumerator(); e.MoveNext(); )
                    {
                        result.Add(e.Current.id);
                    }
                }
            }
            catch (ApplicationException e)
            {
                throw new FaultException("internal error while data querying, occured");
            }
            return result;
        }


        public BillDetails GetBill(int Id)
        {
            BillDetails result = new BillDetails();
            try
            {
                Bill b = BillDao.getById(Id);
                if (b != null)
                {
                    result.id = b.id;
                    result.customerId = b.userId;
                    User u = User.getById(b.userId);
                    if (u != null)
                    {
                        result.customerUsername = u.username;
                    }
                    else
                    {
                        result.customerUsername = "";
                    }
                    result.amount = b.price;
                    result.isPayed = b.isPayed;
                    return result;
                }
            }
            catch (ApplicationException e)
            {
                throw new FaultException("internal error while query bill occured");
            }
            return null;
        }


        public void PayBill(int Id)
        {
            try
            {
                Bill b = BillDao.getById(Id);
                if (b != null)
                {
                    User u = User.getById(b.userId);
                    if (u != null)
                    {
                        // some basic checks
                        if (u.email == null || u.email.Equals(""))
                            throw new FaultException("user for given bill does not have a valid email address: " + u.email);

                        if (u.creditcard == null || u.creditcard.Equals(""))
                            throw new FaultException("user for given bill does not have credit card information");

                        // now use pay service and check if there were no errors

                        // all went fine, set bill field to be payed
                        b.isPayed = true;
                        try
                        {
                            BillDao.update(b);
                        }
                        catch (ArgumentException e)
                        {
                            // roll back  paying steps...


                            throw new FaultException("internal error during paying the bill");
                        }
                    }
                    else
                    {
                        throw new FaultException("user for given bill does not exist");
                    }
                }
                else
                {
                    throw new FaultException("Bill with given Id not found");
                }
            }
            catch (ApplicationException e)
            {
                throw new FaultException("internal error while data querying occured");
            }
        }


        public void CalculateBillsForUser(string username)
        {
            try
            {
                User u = User.getByUsername(username);
                if (u != null)
                {
                    if (u.acitveDate != DateTime.MinValue)
                    {
                        // calculate new bill from last bill date to now
                        Bill b = BillDao.getLastBillForUser(u.id);
                        if (b != null)
                        {
                            Bill curBill = new Bill();
                            curBill.userId = u.id;
                            curBill.created = DateTime.Now;
                            curBill.accountedUntil = DateTime.Today;
                            if (u.deactiveDate.CompareTo(DateTime.MinValue) > 0)
                                curBill.accountedUntil = u.deactiveDate.Date;

                            TimeSpan t = curBill.accountedUntil.Subtract(b.accountedUntil);
                            int queryCounts = BillDao.getQueriesByUser(username, b.accountedUntil);

                            // if there is no timespan since last bill to calulate a bill, silenty ignore this 
                            if (t.Ticks > 0)
                            {
                                curBill.calculatePrice(t.Days, queryCounts);
                                curBill.isPayed = false;

                                BillDao.insert(curBill);

                            }

                        }
                    }
                }
                else
                {
                    throw new FaultException("user with given id not found");
                }
            }
            catch (ApplicationException e)
            {
                throw new FaultException("internal error while data querying");
            }
        }

    }
}
