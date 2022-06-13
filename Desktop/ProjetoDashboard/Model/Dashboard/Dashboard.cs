using System;
using System.Collections.Generic;

namespace Model
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class Dashboard
    {
        //Fields & Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumCustomers { get; set; }
        public int NumSuppliers { get; set; }
        public int NumProducts { get; set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; set; }
        public List<RevenueByDate> GrossRevenueList { get; set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int NumberDays { get => numberDays; set => numberDays = value; }

        //Constructor
        public Dashboard()
        {
        }
    }
}
