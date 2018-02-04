using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementALEVEL
{
    class PeformanceAnalysis
    {
        public class PerformanceObj
        {
            public string ItemName { get; set; }
            public int Transfers { get; set; }
        }


        SQLServerAccessor SqlLink = new SQLServerAccessor();

        public string GeneratePerformanceAnalysisText(PerformanceTable PerfData)
        {
            //create a an array where index 0 corresponds to january , 1 to February and so on
            int[] TransfersMonths = new int[12];
            TransfersMonths[0] = PerfData.January.Value;
            TransfersMonths[1] = PerfData.February.Value;
            TransfersMonths[2] = PerfData.March.Value;
            TransfersMonths[3] = PerfData.April.Value;
            TransfersMonths[4] = PerfData.May.Value;
            TransfersMonths[5] = PerfData.June.Value;
            TransfersMonths[6] = PerfData.July.Value;
            TransfersMonths[7] = PerfData.August.Value;
            TransfersMonths[8] = PerfData.September.Value;
            TransfersMonths[9] = PerfData.October.Value;
            TransfersMonths[10] = PerfData.November.Value;
            TransfersMonths[11] = PerfData.December.Value;
            int lastHighestVal = 0; 
            int lastHighestIndex = 0;
            int lastLowestVal = 0;
            int lastLowestIndex = 0;
            string worstMonth = "";
            string bestMonth = "";
            //iterate through the array
            for (int pos = 0; pos < TransfersMonths.Length; pos++)
            {
                //if its the first iteration then setup the variables
                if (pos == 0)
                {
                    lastHighestIndex = pos;
                    lastHighestVal = TransfersMonths[pos];
                    lastLowestIndex = pos;
                    lastLowestVal = TransfersMonths[pos];
                }
                //if the month being iterated through has had more transfers than last highest month
                else if(TransfersMonths[pos] > lastHighestVal)
                {
                    //update the last highest values and index
                    lastHighestVal = TransfersMonths[pos];
                    lastHighestIndex = pos;
                }
                //if the month being iterated through has had less transfers than last highest month
                else if (TransfersMonths[pos] < lastLowestVal)
                {
                    //update the last lowest values and index
                    lastLowestVal = TransfersMonths[pos];
                    lastLowestIndex = pos;
                }
            }

            if (lastHighestIndex == 0 )
            {
                bestMonth = "January";
            }
            if (lastHighestIndex == 1 )
            {
                bestMonth = "February";
            }
            if (lastHighestIndex == 2 )
            {
                bestMonth = "March";
            }
            if (lastHighestIndex == 3 )
            {
                bestMonth = "April";
            }
            if (lastHighestIndex == 4 )
            {
                bestMonth = "May";
            }
            if (lastHighestIndex == 5 )
            {
                bestMonth = "June";
            }
            if (lastHighestIndex == 6 )
            {
                bestMonth = "July";
            }
            if (lastHighestIndex == 7 )
            {
                bestMonth = "August";
            }
            if (lastHighestIndex == 8 )
            {
                bestMonth = "September";
            }
            if (lastHighestIndex == 9 )
            {
                bestMonth = "October";
            }
            if (lastHighestIndex == 10 )
            {
                bestMonth = "November";
            }
            if (lastHighestIndex == 11 )
            {
                bestMonth = "December";
            }

            if (lastLowestIndex == 0)
            {
                worstMonth = "January";
            }
            if (lastLowestIndex == 1)
            {
                worstMonth = "February";
            }
            if (lastLowestIndex == 2)
            {
                worstMonth = "March";
            }
            if (lastLowestIndex == 3)
            {
                worstMonth = "April";
            }
            if (lastLowestIndex == 4)
            {
                worstMonth = "May";
            }
            if (lastLowestIndex == 5)
            {
                worstMonth = "June";
            }
            if (lastLowestIndex == 6)
            {
                worstMonth = "July";
            }
            if (lastLowestIndex == 7)
            {
                worstMonth = "August";
            }
            if (lastLowestIndex == 8)
            {
                worstMonth = "September";
            }
            if (lastLowestIndex == 9)
            {
                worstMonth = "October";
            }
            if (lastLowestIndex == 10)
            {
                worstMonth = "November";
            }
            if (lastLowestIndex == 11)
            {
                worstMonth = "December";
            }


            return (PerfData.ItemName.Replace(" ","") + "  has shown to sell best in the month " + bestMonth + " and sells worst in the month " + worstMonth );
           


        }

        public List<PerformanceTable> GetSearchResults(string name)
        {
            return SqlLink.GetPerformanceItemsByLIKEName(name);
        }

        public PeformanceAnalysis()
        {

        }

        public bool GetPerformanceThisMonthAsBool(string ItemName)
        {
            //returns false is item sells good in current month , and true if not
            //if a performance record for the 
            if (SqlLink.GetPerformanceItemsByName(ItemName).Count != 0)
            {
                //get the actual performance record
                var PerfData = SqlLink.DataContextInv.PerformanceTables.Single(x => x.ItemName == ItemName);
                //gets the current month
                string currentMonth = DateTime.Now.ToString("MMMM");
                int[] TransfersMonths = new int[12];
                TransfersMonths[0] = PerfData.January.Value;
                TransfersMonths[1] = PerfData.February.Value;
                TransfersMonths[2] = PerfData.March.Value;
                TransfersMonths[3] = PerfData.April.Value;
                TransfersMonths[4] = PerfData.May.Value;
                TransfersMonths[5] = PerfData.June.Value;
                TransfersMonths[6] = PerfData.July.Value;
                TransfersMonths[7] = PerfData.August.Value;
                TransfersMonths[8] = PerfData.September.Value;
                TransfersMonths[9] = PerfData.October.Value;
                TransfersMonths[10] = PerfData.November.Value;
                TransfersMonths[11] = PerfData.December.Value;

                if (currentMonth == "January")
                {
                    for (int pos = 0; pos < TransfersMonths.Length; pos++)
                    {
                        //if any other month had more sales than the current month , then its not likely to sell best in this month
                        if (TransfersMonths[0] < TransfersMonths[pos])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (currentMonth == "February")
                {
                    for (int pos = 0; pos < TransfersMonths.Length; pos++)
                    {
                        if (TransfersMonths[1] < TransfersMonths[pos])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (currentMonth == "March")
                {
                    for (int pos = 0; pos < TransfersMonths.Length; pos++)
                    {
                        if (TransfersMonths[2] < TransfersMonths[pos])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (currentMonth == "April")
                {
                    for (int pos = 0; pos < TransfersMonths.Length; pos++)
                    {
                        if (TransfersMonths[3] < TransfersMonths[pos])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (currentMonth == "May")
                {
                    for (int pos = 0; pos < TransfersMonths.Length; pos++)
                    {
                        if (TransfersMonths[4] < TransfersMonths[pos])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (currentMonth == "June")
                {
                    for (int pos = 0; pos < TransfersMonths.Length; pos++)
                    {
                        if (TransfersMonths[5] < TransfersMonths[pos])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (currentMonth == "July ")
                {
                    for (int pos = 0; pos < TransfersMonths.Length; pos++)
                    {
                        if (TransfersMonths[6] < TransfersMonths[pos])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (currentMonth == "August")
                {
                    for (int pos = 0; pos < TransfersMonths.Length; pos++)
                    {
                        if (TransfersMonths[7] < TransfersMonths[pos])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (currentMonth == "September")
                {
                    for (int pos = 0; pos < TransfersMonths.Length; pos++)
                    {
                        if (TransfersMonths[8] < TransfersMonths[pos])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (currentMonth == "October")
                {
                    for (int pos = 0; pos < TransfersMonths.Length; pos++)
                    {
                        if (TransfersMonths[9] < TransfersMonths[pos])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (currentMonth == "November")
                {
                    for (int pos = 0; pos < TransfersMonths.Length; pos++)
                    {
                        if (TransfersMonths[10] < TransfersMonths[pos])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (currentMonth == "December")
                {
                    for (int pos = 0; pos < TransfersMonths.Length; pos++)
                    {
                        if (TransfersMonths[11] < TransfersMonths[pos])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else { return false; }
            return false;
        }

        public List<PerformanceObj> GetTopFiveThisMonth()
        {
            //get every performance record
            List<PerformanceTable> AllPerformanceItems = SqlLink.GetPerformanceItems();
            //the top five items
            List<PerformanceTable> TopFivePerformance = new List<PerformanceTable>();
            //top five items as performance objects
            List<PerformanceObj> TopFivePerformanceObjects = new List<PerformanceObj>();
            
            //get the current month
            string currentMonth = DateTime.Now.ToString("MMMM");

            if (currentMonth == "January")
            {
                //orders the list in descending order for the January column
                AllPerformanceItems = AllPerformanceItems.OrderByDescending(o => o.January).ToList();
            }
            if (currentMonth == "February")
            {
                AllPerformanceItems = AllPerformanceItems.OrderByDescending(o => o.February).ToList();
            }
            if (currentMonth == "March")
            {
                AllPerformanceItems = AllPerformanceItems.OrderByDescending(o => o.March).ToList();
            }
            if (currentMonth == "April")
            {
                AllPerformanceItems = AllPerformanceItems.OrderByDescending(o => o.April).ToList();
            }
            if (currentMonth == "May")
            {
                AllPerformanceItems = AllPerformanceItems.OrderByDescending(o => o.May).ToList();
            }
            if (currentMonth == "June")
            {
                AllPerformanceItems = AllPerformanceItems.OrderByDescending(o => o.June).ToList();
            }
            if (currentMonth == "July ")
            {
                AllPerformanceItems = AllPerformanceItems.OrderByDescending(o => o.July).ToList();
            }
            if (currentMonth == "August")
            {
                AllPerformanceItems = AllPerformanceItems.OrderByDescending(o => o.August).ToList();
            }
            if (currentMonth == "September")
            {
                AllPerformanceItems = AllPerformanceItems.OrderByDescending(o => o.September).ToList();
            }
            if (currentMonth == "October")
            {
                AllPerformanceItems = AllPerformanceItems.OrderByDescending(o => o.October).ToList();
            }
            if (currentMonth == "November")
            {
                AllPerformanceItems = AllPerformanceItems.OrderByDescending(o => o.November).ToList();
            }
            if (currentMonth == "December")
            {
                AllPerformanceItems = AllPerformanceItems.OrderByDescending(o => o.December).ToList();
            }
            int x = 1;
            //add the first five items to the top five performance list
            foreach (PerformanceTable perfElement in AllPerformanceItems)
            {
                if (x <= 5)
                {
                    TopFivePerformance.Add(perfElement);
                    x++;
                }
            }
            foreach (PerformanceTable conv in TopFivePerformance)
            {
                PerformanceObj nextobj = new PerformanceObj();
                //setup the performance object 
                nextobj.ItemName = conv.ItemName;
                if (currentMonth == "January")
                {
                    nextobj.Transfers = conv.January.Value;
                }
                if (currentMonth == "February")
                {
                    nextobj.Transfers = conv.February.Value;
                }
                if (currentMonth == "March")
                {
                    nextobj.Transfers = conv.March.Value;
                }
                if (currentMonth == "April")
                {
                    nextobj.Transfers = conv.April.Value;
                }
                if (currentMonth == "May")
                {
                    nextobj.Transfers = conv.May.Value;
                }
                if (currentMonth == "June")
                {
                    nextobj.Transfers = conv.June.Value;
                }
                if (currentMonth == "July ")
                {
                    nextobj.Transfers = conv.July.Value;
                }
                if (currentMonth == "August")
                {
                    nextobj.Transfers = conv.August.Value;
                }
                if (currentMonth == "September")
                {
                    nextobj.Transfers = conv.September.Value;
                }
                if (currentMonth == "October")
                {
                    nextobj.Transfers = conv.October.Value;
                }
                if (currentMonth == "November")
                {
                    nextobj.Transfers = conv.November.Value;
                }
                if (currentMonth == "December")
                {
                    nextobj.Transfers = conv.December.Value;
                }
                TopFivePerformanceObjects.Add(nextobj);
            }
            return TopFivePerformanceObjects;
        }

        public List<PerformanceObj> GetTopFiveWorstThisMonth()
        {
            List<PerformanceTable> AllPerformanceItems = SqlLink.GetPerformanceItems();
            List<PerformanceTable> TopFiveWorstPerformance = new List<PerformanceTable>();
            List<PerformanceObj> TopFivePerformanceObjectsWorst = new List<PerformanceObj>();
            string currentMonth = DateTime.Now.ToString("MMMM");

            if (currentMonth == "January")
            {
                AllPerformanceItems = AllPerformanceItems.OrderBy(o => o.January).ToList();
            }
            if (currentMonth == "February")
            {
                AllPerformanceItems = AllPerformanceItems.OrderBy(o => o.February).ToList();
            }
            if (currentMonth == "March")
            {
                AllPerformanceItems = AllPerformanceItems.OrderBy(o => o.March).ToList();
            }
            if (currentMonth == "April")
            {
                AllPerformanceItems = AllPerformanceItems.OrderBy(o => o.April).ToList();
            }
            if (currentMonth == "May")
            {
                AllPerformanceItems = AllPerformanceItems.OrderBy(o => o.May).ToList();
            }
            if (currentMonth == "June")
            {
                AllPerformanceItems = AllPerformanceItems.OrderBy(o => o.June).ToList();
            }
            if (currentMonth == "July ")
            {
                AllPerformanceItems = AllPerformanceItems.OrderBy(o => o.July).ToList();
            }
            if (currentMonth == "August")
            {
                AllPerformanceItems = AllPerformanceItems.OrderBy(o => o.August).ToList();
            }
            if (currentMonth == "September")
            {
                AllPerformanceItems = AllPerformanceItems.OrderBy(o => o.September).ToList();
            }
            if (currentMonth == "October")
            {
                AllPerformanceItems = AllPerformanceItems.OrderBy(o => o.October).ToList();
            }
            if (currentMonth == "November")
            {
                AllPerformanceItems = AllPerformanceItems.OrderBy(o => o.November).ToList();
            }
            if (currentMonth == "December")
            {
                AllPerformanceItems = AllPerformanceItems.OrderBy(o => o.December).ToList();
            }
            int x = 1;
            foreach (PerformanceTable perfElement in AllPerformanceItems)
            {
                if (x <= 5)
                {
                    TopFiveWorstPerformance.Add(perfElement);
                    x++;
                }
            }
            foreach (PerformanceTable conv in TopFiveWorstPerformance)
            {
                PerformanceObj nextobj = new PerformanceObj();
                nextobj.ItemName = conv.ItemName;
                if (currentMonth == "January")
                {
                    nextobj.Transfers = conv.January.Value;
                }
                if (currentMonth == "February")
                {
                    nextobj.Transfers = conv.February.Value;
                }
                if (currentMonth == "March")
                {
                    nextobj.Transfers = conv.March.Value;
                }
                if (currentMonth == "April")
                {
                    nextobj.Transfers = conv.April.Value;
                }
                if (currentMonth == "May")
                {
                    nextobj.Transfers = conv.May.Value;
                }
                if (currentMonth == "June")
                {
                    nextobj.Transfers = conv.June.Value;
                }
                if (currentMonth == "July ")
                {
                    nextobj.Transfers = conv.July.Value;
                }
                if (currentMonth == "August")
                {
                    nextobj.Transfers = conv.August.Value;
                }
                if (currentMonth == "September")
                {
                    nextobj.Transfers = conv.September.Value;
                }
                if (currentMonth == "October")
                {
                    nextobj.Transfers = conv.October.Value;
                }
                if (currentMonth == "November")
                {
                    nextobj.Transfers = conv.November.Value;
                }
                if (currentMonth == "December")
                {
                    nextobj.Transfers = conv.December.Value;
                }
                TopFivePerformanceObjectsWorst.Add(nextobj);
            }
            return TopFivePerformanceObjectsWorst;
        }



    }
}
