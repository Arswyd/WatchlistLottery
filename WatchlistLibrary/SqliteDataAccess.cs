using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchlistLibrary
{
    public class SqliteDataAccess
    {
        public static List<ItemModel> LoadItems(string currentList)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ItemModel>("select * from " + currentList, new DynamicParameters());
                return output.ToList();
            }
        }

        public static void AddItemToList(ItemModel item, string currentList)
        {
            item.ID = SetItemID(currentList);
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into " + currentList + " (ID, Title, Date, Category, Score) values (@ID, @Title, @Date, @Category, @Score)", item);
            }
        }

        public static void EditListItem(ItemModel item, string currentList)
        {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("update " + currentList + " Set Title=@Title, Date=@Date, Category=@Category, Score=@Score where ID = @ID", item);
                }
        }

        public static void TransferWatchOrCompleted(ItemModel item, string currentList, string transferList)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from " + currentList + " where ID = @ID", item);
                item.ID = SetItemID(transferList);
                cnn.Execute("insert into " + transferList + " (ID, Title, Date, Category, Score) values (@ID, @Title, @Date, @Category, @Score)", item);
            }
        }

        public static void DeleteFromList(ItemModel item, string currentList)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from " + currentList + " where ID = @ID", item);
            }
        }

        private static int SetItemID(string currentList)
        {
            List<ItemModel> _items = LoadItems(currentList);

            int id;

            if(_items.Count() == 0)
            {
                return 1;
            }
            else if (_items[_items.Count()-1].ID == _items.Count())
            {
                id = _items.Count() + 1;
                return id;
            }
            else
            {
                _items = _items.OrderBy(x => x.ID).ToList();
                int i = 0;
                id = 1;
                while (i < _items.Count() && _items[i].ID == id)
                {
                    id++;
                    i++;
                }
                return id;
            }
        }

        public static List<SettingsModel> LoadSettings()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SettingsModel>("select * from Settings", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
