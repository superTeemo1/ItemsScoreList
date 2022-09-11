using GRMTestApp.Models;

namespace GRMTestApp.ViewModel
{
    public class ItemsVM
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Item> Matches { get; set; } = new List<Item>();
    }
}
