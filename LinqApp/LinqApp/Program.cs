namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prods = Product.GetProducts();

            //var prs = prods.Where(p => p.Price > 300).Where(p => p.Count < 600);
            //var prs = prods.OrderByDescending(p=>p.Category).ThenBy(p => p.Price);

            //var prs = prods.Select(p => new { NewName=p.Name, Amount = p.Price * p.Count })
            //    .OrderBy(p=> - p.Amount).Take(3);

            var cats = prods.GroupBy(p => p.Category)
                .Select(g=>new {Category = g.Key, MaxPrice = g.Max(p=>p.Price), Kolvo = g.Count(),
                       TotalCount = g.Sum(p=>p.Count)}).OrderByDescending(g=>g.TotalCount);

            foreach (var product in cats) 
            {
                Console.WriteLine(product);
            }


        }
    }
}
