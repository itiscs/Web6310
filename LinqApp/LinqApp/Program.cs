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

            //foreach (var product in cats) 
            //{
            //    Console.WriteLine(product);
            //}


            List<Group> groups = new List<Group>()
            { 
                new Group() {Id=4, Number="1111",
                Faculty = "F1", Speciality="S1"},
                new Group() {Id=2, Number="1122",
                Faculty = "F1", Speciality="S2"},
                new Group() {Id=3, Number="22222",
                Faculty = "F2", Speciality="S3"},
            };


            List<Student> students = new List<Student>()
            {
                new Student()
                {Id=1, GroupID = 1,
                Name="Ivanov",
                Marks=new List<int>{ 5,5,5,5,4,5} },
                new Student(){Id=2, GroupID = 1,
                Name="Petrov",Marks=new List<int>{ 5,4,3,5,4,5} },
                new Student(){Id=3, GroupID = 1,
                Name="Sidorov",Marks=new List<int>{ 5,5,5,5,4,5} },
new Student(){Id=4, GroupID = 2,
                Name="Maksimov",Marks=new List<int>{ 2,2,2,2,2,5} },
new Student(){Id=5, GroupID = 2,
                Name="Ivanova",Marks=new List<int>{ 4,3,4,3,3,3,4,5} },
new Student(){Id=6, GroupID = 3,
                Name="Fillipov",Marks=new List<int>{ 5,5,3,3,3,3,5,5,4,5} }
            };



            var lst = students.Join(groups,
                s => s.GroupID, g => g.Id,
                (s, g) => new { s.Name, g.Number, g.Faculty, g.Speciality, Avg = s.Marks.Average() });

            var lst2 = groups.Join(students,
             g => g.Id, s => s.GroupID,
             (g, s) => new { s.Name, g.Number, g.Faculty, g.Speciality, s.Marks, Avg = Math.Round(s.Marks.Average(),2) })
             .OrderBy(l => l.Marks.Count());
  
            foreach (var s in lst2)
            {
                Console.WriteLine(s);
            }


        }
    }
}
