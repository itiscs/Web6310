using Microsoft.AspNetCore.Mvc;
using RolesApp.Data;

namespace RolesApp.Models
{
    public class Cart
    {
        ApplicationDbContext _db;

        public Cart(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddLine(int id, int kol) 
        {
            var l = Lines.FirstOrDefault(l => l.Product.Id == id);
            if (l != null)
            {
                l.Count += kol;
            }
            else
            {
                var prod = _db.Products.FirstOrDefault(p => p.Id == id);
                Lines.Add(new CartLine { Product = prod, Count = kol });
            }
        }

        public void RemoveLine(int id)
        {
            var l = Lines.FirstOrDefault(l => l.Product.Id == id);
            if (l != null)
            {
                Lines.Remove(l);  
            }
        }

        //public static Cart GetCart(ISession session)
        //{
        //    if(session.Keys.Contains("Cart"))
        //    {
        //        session.
        //    }
        //}

    }
    public class CartLine
    {
        public Product Product { get; set; }

        public int Count { get; set; }
    }
}
