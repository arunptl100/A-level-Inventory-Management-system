using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementALEVEL
{
    class SQLServerAccessor
    {
        public InventoryManagementLINKQtoSQLClassDataContext DataContextInv 
            = new InventoryManagementLINKQtoSQLClassDataContext(Properties.Settings.Default.InventoryManagementDBConnectionString1);


        public bool deleteItemsInventory(int[] itemIDs, string username)
        {
            //deletes a list of items from inventory
            try
            {
                //loop through the list of itemIDs
                for (int x = 0; x < itemIDs.Length; x++)
                {
                    // This uses a lambda expression query to create a inventory table object that corresponds to the current item id
                    InventoryTable deleteitem = DataContextInv.InventoryTables.FirstOrDefault(e => e.ItemID.Equals(itemIDs[x]));
                    //delete the item
                    DataContextInv.InventoryTables.DeleteOnSubmit(deleteitem);
                    //generate a log message
                    string message = username + " has removed " + deleteitem.ItemName + " from inventory ";
                    AddLogEntry(username, message);
                    DataContextInv.SubmitChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public List<EventLogTable> GetLogEntriesAfterDate(DateTime ShowAferDate)
        {
            //A list of the event logs 
            List<EventLogTable> eventLog = DataContextInv.EventLogTables.ToList();
            //A list of all the event logs that are after the given date , initially it is empty
            List<EventLogTable> sortedLog = new List<EventLogTable>();
            //iterate through eventlog
            foreach (EventLogTable Log in eventLog)
            {
                Console.WriteLine(Log.TimeOfAction.Date);
                //if the date of the log is after the given date
                if (Log.TimeOfAction.Date > ShowAferDate.Date)
                {
                    //add it to the sorted log
                    sortedLog.Add(Log);
                }
            }
            return sortedLog;
        }

        public void AddLogEntry(string username, string actionMessage)
        {
            EventLogTable newlog = new EventLogTable();
            //replaces any white spaces in the message
            actionMessage = System.Text.RegularExpressions.Regex.Replace(actionMessage, @"\s+", " ");
            //get the accounts table object for the user passed
            var GetUserData = DataContextInv.AccountsTables.Single(x => x.Username == username);
            //setup the new event log instance
            newlog.Username = GetUserData.Username;
            newlog.FirstName = GetUserData.FirstName;
            newlog.Role = GetUserData.Role;
            newlog.Action = actionMessage;
            newlog.TimeOfAction = DateTime.Now;
            DataContextInv.EventLogTables.InsertOnSubmit(newlog);
            DataContextInv.SubmitChanges();
        }

        public bool deleteItemsForSale(int[] itemIDs, string username)
        {
            try
            {
                for (int x = 0; x < itemIDs.Length; x++)
                {
                    ForSaleTable deleteitem = DataContextInv.ForSaleTables.FirstOrDefault(e => e.ItemID.Equals(itemIDs[x]));
                    string message = username + " has removed " + deleteitem.ItemName + " from the for sale table ";
                    AddLogEntry(username, message);
                    DataContextInv.ForSaleTables.DeleteOnSubmit(deleteitem);
                    DataContextInv.SubmitChanges();


                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        public List<InventoryTable> getNewInventoryTable(string category, string name)
        {
            DataContextInv.Dispose();
            DataContextInv = new InventoryManagementLINKQtoSQLClassDataContext();
            if (name != "" && category == "Any")
            {
                //returns the items which are similar or exactly the same as the input name but can come from any category
                return (from x in DataContextInv.InventoryTables
                        where x.ItemName.Contains(name)
                        select x).ToList();
            }
            else if (name != "" && category != "Any")
            {
                //returns the items which are similar or exactly the same as the input name and are in the input category
                return (from x in DataContextInv.InventoryTables
                        where x.ItemName.Contains(name) &&
                        x.CategoryName.Equals(category)
                        select x).ToList();
            }
            else if (name == "" && category != "Any")
            {
                //returns items in the input category
                return (from x in DataContextInv.InventoryTables
                        where x.CategoryName.Equals(category)
                        select x).ToList();
            }

            else
            {
                //no filter , return everything
                return (from x in DataContextInv.InventoryTables
                        select x).ToList();
            }

        }

        public List<ForSaleTable> getNewForSaleTable(string category, string name)
        {
            DataContextInv.Dispose();
            DataContextInv = new InventoryManagementLINKQtoSQLClassDataContext();

            if (name != "" && category == "Any")
            {
                //returns the items which are similar or exactly the same as the input name but can come from any category
                return (from x in DataContextInv.ForSaleTables
                        where x.ItemName.Contains(name)
                        select x).ToList();
            }
            else if (name != "" && category != "Any")
            {
                //returns the items which are similar or exactly the same as the input name and are in the input category
                return (from x in DataContextInv.ForSaleTables
                        where x.ItemName.Contains(name) &&
                        x.CategoryName.Equals(category)
                        select x).ToList();
            }
            else if (name == "" && category != "Any")
            {
                //returns items in the input category
                return (from x in DataContextInv.ForSaleTables
                        where x.CategoryName.Equals(category)
                        select x).ToList();
            }
            else
            {
                //no filter , return everything
                return (from x in DataContextInv.ForSaleTables
                        select x).ToList();
            }

        }
     



        public List<InventoryTable> SearchForItemInventory(string name)
        {
            //returns a list of all items with the item name the same as the parameter
            return (from x in DataContextInv.InventoryTables
                    where x.ItemName.Equals(name)
                    select x).ToList();
        }

        public List<ForSaleTable> SearchForItemForSale(string name)
        {
            return (from x in DataContextInv.ForSaleTables
                    where x.ItemName.Contains(name)
                    select x).ToList();
        }

        public List<PerformanceTable> GetPerformanceItems()
        {
            return (from x in DataContextInv.PerformanceTables
                    select x).ToList();
        }
        public List<PerformanceTable> GetPerformanceItemsByName(string itemName)
        {
            return (from x in DataContextInv.PerformanceTables
                    where x.ItemName == itemName
                    select x).ToList();
        }
        public List<PerformanceTable> GetPerformanceItemsByLIKEName(string itemName)
        {
            return (from x in DataContextInv.PerformanceTables
                    where x.ItemName.Contains(itemName)
                    select x).ToList();
        }

        public List<InventoryTable> PopulateSelectedItemsWithSearchResults(int[] itemIDs)
        {

            List<InventoryTable> nitems = new List<InventoryTable>();

            for (int x = 0; x < itemIDs.Length; x++)
            {
                nitems.Add(DataContextInv.InventoryTables.FirstOrDefault(e => e.ItemID.Equals(itemIDs[x])));

            }
            return nitems;
        

        }

        public bool AuthenticateLogin(string Username, string Password)
        {
            //the method returns true if the login was authenticated 
            Console.WriteLine("authenticating login");
            //Query the accounts table for a username with the entered username and the entered password
            var accQuery = from u in DataContextInv.AccountsTables
                           where u.Username.Equals(Username) &&
                           u.Password.Equals(Password)
                           select u;
            if (accQuery.Count() != 0) 
                //if the query returns nothing , the username and password does not exist together in a record 
                //so the username or password was incorrect
            {
                Console.WriteLine("Authenticated");
                return true;
            }
            else
            {
                Console.WriteLine("Authentication failed");
                return false;
            }
        }

        public bool CreateNewAccount(string username, string firstname, string lastname, string password, string role)
        {
            //search for an existing user with the same username
            var accQuery = from u in DataContextInv.AccountsTables
                           where u.Username.Equals(username)
                           select u;
            if (accQuery.Count() == 0)  //if the query returns more than 0 , the username is taken
            {
                //create a new Accounts table instance and fill it with the passed values
                AccountsTable newuser = new AccountsTable();
                newuser.Username = username;
                newuser.FirstName = firstname;
                newuser.LastName = lastname;
                newuser.Password = password;
                newuser.Role = role;
                DataContextInv.AccountsTables.InsertOnSubmit(newuser);
                DataContextInv.SubmitChanges();
                string message = "Created a new account for the user " + username;
                AddLogEntry(username, message);
                return true;
            }
            else //the username was taken so return false
            {
                return false;
            }

        }
        public IEnumerable<CategoryTable> getCategories()
        {
            return from s in DataContextInv.CategoryTables
                   select s;

        }
        public bool addNewItemInventory(string _itemName, int _quantity, string Category, string username)
        {
            try
            {
                InventoryTable newItem = new InventoryTable();
                newItem.ItemName = _itemName;
                newItem.Quantity = _quantity;
                newItem.CategoryName = Category;
                DataContextInv.InventoryTables.InsertOnSubmit(newItem);
                DataContextInv.SubmitChanges();
                string message = username + " Has added " + _itemName + " to inventory," + " quantity " + _quantity + " category " + Category;
                AddLogEntry(username, message);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        public bool addNewItemForSale(string _itemName, int _quantity, string Category, DateTime SellByDate, string username)
        {
            try
            {
                ForSaleTable newItem = new ForSaleTable();
                newItem.ItemName = _itemName;
                newItem.Quantity = _quantity;
                newItem.CategoryName = Category;
                newItem.SellByDate = SellByDate;
                DataContextInv.ForSaleTables.InsertOnSubmit(newItem);
                DataContextInv.SubmitChanges();
                string message = username + " Has added " + _itemName + " to the for sale table," + " quantity " + _quantity + " category " + Category;
                AddLogEntry(username, message);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        
        public void GeneratePerformanceLog(ForSaleTable ActItem)
        {
              
            var PerfQuery = from u in DataContextInv.PerformanceTables
                            where u.ItemName == ActItem.ItemName
                           select u;
            if (PerfQuery.Count() == 0) // then a perf record for the item doesnt exist
            {
                PerformanceTable PerformanceLog = new PerformanceTable();
                PerformanceLog.ItemName = ActItem.ItemName;
                PerformanceLog.January = 0;
                PerformanceLog.February = 0;
                PerformanceLog.March = 0;
                PerformanceLog.April = 0;
                PerformanceLog.May = 0;
                PerformanceLog.June = 0;
                PerformanceLog.July = 0;
                PerformanceLog.August = 0;
                PerformanceLog.September = 0;
                PerformanceLog.October = 0;
                PerformanceLog.November = 0;
                PerformanceLog.December = 0;
                //returns the current month , e.g. January
                string currentMonth = DateTime.Now.ToString("MMMM");

                Console.WriteLine("The quantity is "  + ActItem.Quantity);

                if (currentMonth == "January")
                {
                    PerformanceLog.January += ActItem.Quantity.Value;
                }
                if (currentMonth == "February")
                {
                    PerformanceLog.February = ActItem.Quantity.Value;
                }
                if (currentMonth == "March")
                {
                    PerformanceLog.March = ActItem.Quantity.Value;
                }
                if (currentMonth == "April")
                {
                    PerformanceLog.April = ActItem.Quantity.Value;
                }
                if (currentMonth == "May")
                {
                    PerformanceLog.May = ActItem.Quantity.Value;
                }
                if (currentMonth == "June")
                {
                    PerformanceLog.June = ActItem.Quantity.Value;
                }
                if (currentMonth == "July ")
                {
                    PerformanceLog.July = ActItem.Quantity.Value;
                }
                if (currentMonth == "August")
                {
                    PerformanceLog.August = ActItem.Quantity.Value;
                }
                if (currentMonth == "September")
                {
                    PerformanceLog.September = ActItem.Quantity.Value;
                }
                if (currentMonth == "October")
                {
                    PerformanceLog.October = ActItem.Quantity.Value;
                }
                if (currentMonth == "November")
                {
                    PerformanceLog.November = ActItem.Quantity.Value;
                }
                if (currentMonth == "December")
                {
                    PerformanceLog.December = ActItem.Quantity.Value;
                }
                DataContextInv.PerformanceTables.InsertOnSubmit(PerformanceLog);
                DataContextInv.SubmitChanges();
            }
            else
            {
                //get the actual record in the performance table
                var PerfData = DataContextInv.PerformanceTables.Single(x => x.ItemName == ActItem.ItemName);
                string currentMonth = DateTime.Now.ToString("MMMM");
                if (currentMonth == "January")
                {
                    //increment the value by the quantity of item
                    PerfData.January += ActItem.Quantity.Value;
                }
                if (currentMonth == "February")
                {
                    PerfData.February += ActItem.Quantity.Value;
                }
                if (currentMonth == "March")
                {
                    PerfData.March += ActItem.Quantity.Value;
                }
                if (currentMonth == "April")
                {
                    PerfData.April  += ActItem.Quantity.Value;
                }
                if (currentMonth == "May")
                {
                    PerfData.May += ActItem.Quantity.Value;
                }
                if (currentMonth == "June")
                {
                    PerfData.June += ActItem.Quantity.Value;
                }
                if (currentMonth == "July ")
                {
                    PerfData.July += ActItem.Quantity.Value;
                }
                if (currentMonth == "August")
                {
                    PerfData.August += ActItem.Quantity.Value;
                }
                if (currentMonth == "September")
                {
                    PerfData.September += ActItem.Quantity.Value;
                }
                if (currentMonth == "October")
                {
                    PerfData.October += ActItem.Quantity.Value;
                }
                if (currentMonth == "November")
                {
                    PerfData.November += ActItem.Quantity.Value;
                }
                if (currentMonth == "December")
                {
                    PerfData.December += ActItem.Quantity.Value;
                }
                DataContextInv.SubmitChanges();
            }

        }
        public void TransferItemsToForWITHsellByDate(InventoryTable itemToTransfer, DateTime sellbydate, string username)
        {
            //get the transferred item from inventory first
            var oldItem = DataContextInv.InventoryTables.Single(x => x.ItemID == itemToTransfer.ItemID);

            Console.WriteLine("is " + itemToTransfer.Quantity + " < " + oldItem.Quantity);
            if (itemToTransfer.Quantity < oldItem.Quantity)
            {
                //update the quantity of the item in inventory
                oldItem.Quantity = oldItem.Quantity - itemToTransfer.Quantity;
                ForSaleTable transitem = new ForSaleTable();
                transitem.ItemName = itemToTransfer.ItemName;
                transitem.Quantity = itemToTransfer.Quantity;
                transitem.SellByDate = sellbydate;
                transitem.CategoryName = itemToTransfer.CategoryName;
                DataContextInv.ForSaleTables.InsertOnSubmit(transitem);
                DataContextInv.SubmitChanges();
                GeneratePerformanceLog(transitem);
                string message = username + " has made " + transitem.Quantity + " " + transitem.ItemName + " available for sale and added the sell by date of " + transitem.SellByDate;
                AddLogEntry(username, message);
            }
            else
            {
                ForSaleTable transitem = new ForSaleTable();
                transitem.ItemName = itemToTransfer.ItemName;
                transitem.Quantity = itemToTransfer.Quantity;
                transitem.SellByDate = sellbydate;
                transitem.CategoryName = itemToTransfer.CategoryName;
                DataContextInv.InventoryTables.DeleteOnSubmit(oldItem);
                DataContextInv.ForSaleTables.InsertOnSubmit(transitem);
                DataContextInv.SubmitChanges();
                GeneratePerformanceLog(transitem);
                string message = username + " has made " + transitem.ItemName + " available for sale and added the sell by date of " + transitem.SellByDate;
                AddLogEntry(username, message);
            }
        }
        public void TransferItemsToForSaleNoSellBy(List<InventoryTable> ListOfItemsToTransfer, string username)
        {
            foreach (InventoryTable nextItem in ListOfItemsToTransfer)
            {
                var oldItem = DataContextInv.InventoryTables.Single(x => x.ItemID == nextItem.ItemID);
                Console.WriteLine("is " + nextItem.Quantity + " < " + oldItem.Quantity);
                if (nextItem.Quantity < oldItem.Quantity)
                {
                    oldItem.Quantity = oldItem.Quantity - nextItem.Quantity;
                    ForSaleTable transitem = new ForSaleTable();
                    transitem.ItemName = nextItem.ItemName;
                    transitem.Quantity = nextItem.Quantity;
                    DateTime? newdate = null;
                    transitem.SellByDate = newdate;
                    transitem.CategoryName = nextItem.CategoryName;
                    DataContextInv.ForSaleTables.InsertOnSubmit(transitem);
                    DataContextInv.SubmitChanges();
                    GeneratePerformanceLog(transitem);
                    string message = username + " has made " + transitem.Quantity + " " + transitem.ItemName + " available for sale";
                    AddLogEntry(username, message);
                }
                else
                {
                    ForSaleTable transitem = new ForSaleTable();
                    transitem.ItemName = nextItem.ItemName;
                    transitem.Quantity = nextItem.Quantity;
                    DateTime? newdate = null;
                    transitem.SellByDate = newdate;
                    transitem.CategoryName = nextItem.CategoryName;
                    DataContextInv.InventoryTables.DeleteOnSubmit(oldItem);
                    DataContextInv.ForSaleTables.InsertOnSubmit(transitem);
                    DataContextInv.SubmitChanges();
                    GeneratePerformanceLog(transitem);
                    string message = username + " has made " + transitem.ItemName + " available for sale";
                    AddLogEntry(username, message);
                }
            }

        }

        public string GetAccountType(string username)
        {
            //returns the user group of the passed username
            var UserData = DataContextInv.AccountsTables.Single(x => x.Username == username);
            //remove any whitespace in the returned query
            return UserData.Role.Replace(" ","");
        }

    }
}
