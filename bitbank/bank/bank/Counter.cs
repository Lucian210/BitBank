using bank.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace bank
{
    public class Counter : ISubject
    {
        private List<IObserver> observers;
        private String count;

        public Counter()
        {
            observers = new List<IObserver>();
            count = "";
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\scuta\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        public void Increment(String a)
        {
            Con.Open();
            String Query = "SELECT * from UsersTable Where Username='" + a + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda1);
            var ds = new DataSet();
            sda1.Fill(ds);

            count = ds.Tables[0].Rows[0]["Userpass"].ToString();
            Con.Close();
            //count++;
            NotifyObserver(count);
        }

        public void NotifyObserver(String c)
        {
           foreach (IObserver ob in observers)
            {
                ob.Update(count);
            }
        }

        public void RegisterObserve(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserve(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
