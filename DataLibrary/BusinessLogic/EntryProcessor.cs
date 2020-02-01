using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class EntryProcessor
    {
        public static int CreateEntry(string name, int amount, string currency, string description)
        {
            EntryModel data = new EntryModel
            {
                Name = name,
                Amount = amount,
                Currency = currency,
                Description = description
            };

            string sql = @"insert into dbo.Entry (Name, Amount, Currency, Description)
                           values (@Name, @Amount, @Currency, @Description)";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EntryModel> LoadEntries()
        {
            string sql = @"select Name, Amount, Currency, Description
                           from dbo.Entry";

            return SqlDataAccess.LoadData<EntryModel>(sql);
        }
    }
}
