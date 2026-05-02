using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_assesment_task_3___Ria_C___2026
{
    public class Product
{
    public string Category { get; set; }
    public string Size { get; set; }
    public string Colour { get; set; }
    public int Stock { get; set; }
    public double Price { get; set; }
}
    public static class TransactionHistory
    {
              public static List<Product> SavedOrders = new List<Product>();
    }
}
