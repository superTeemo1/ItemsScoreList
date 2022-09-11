using GRMTestApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GRMTestApp.Repository
{
    public class AppRepository : IAppRepository
    {
        private readonly AppContext _context;
        public AppRepository(AppContext context)
        {
            _context = context;
        }

        public async Task<List<Item>> GetAllItems()
        {
            return await _context
                .Item
                .OrderByDescending(a => a.Score)
                .ToListAsync();
        }

        public async Task<List<Match>> GetAllMatches()
        {
            return await _context
                .Match
                .ToListAsync();
        }

        public async Task<List<Item>> GetNextMatch()
        {
            var match = await _context.Match.Where(u => u.isPlayed != true).FirstOrDefaultAsync();

            var allItems = await _context.Item.ToListAsync();

            var nextMatch = new List<Item>();

            nextMatch.Add(allItems.Where(e => e.ItemID == match.Home).FirstOrDefault());
            nextMatch.Add(allItems.Where(e => e.ItemID == match.Away).FirstOrDefault());

            match.isPlayed = true;

            await _context.SaveChangesAsync();

            return nextMatch;
        }

        public async Task MatchesInitial()
        {
            if(_context.Match.Count() == 0)
            {
                for (int i = 1; i < 7; i++)
                {
                    for (int j = 1; j < 7; j++)
                    {
                        if (i != j)
                        {
                            var match = new Match
                            {
                                Home = i,
                                Away = j,
                                isPlayed = false
                            };
                            _context.Match.Add(match);
                            await _context.SaveChangesAsync();

                        }

                    }
                }
            }
            
        }
        //public Tuple<List<Item>, List<Item>> GetItems()
        //{
        //    List<Item> items = new List<Item>();

        //    List<Item> first = new List<Item>();
        //    List<Item> second = new List<Item>();

        //    var pairs = new List<Tuple<Item, Item>>();
        //    items = _context.Item.ToList();
        //    foreach (var item in items)
        //    {
        //        foreach (var item2 in items)
        //        {
        //            if (item.Name != item2.Name)
        //            {
        //                first.Add(item);
        //                second.Add(item2);
        //            }
        //            pairs.Add(new Tuple<Item, Item>(item, item2));
        //        }
        //    }
        //    return new Tuple<List<Item>, List<Item>>(first, second);
        //}
    }
}
