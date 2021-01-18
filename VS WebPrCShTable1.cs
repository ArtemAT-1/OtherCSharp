    public class PersonModel : PageModel
    {
        //public string TagName { get; set; }

        //public string Type { get; set; }

        //public float Value { get; set; }


        List<Table1> people;
        public List<Table1> DisplayedPeople { get; set; }
        public PersonModel()
        {
            people = new List<Table1>()
            {
                new Table1{ Name="Name1", Age=23, Age1=23},
                new Table1 {Name = "Name2", Age=25, Age1=25},
                new Table1 {Name="Name3", Age=23, Age1=23},
                new Table1{Name="Name4", Age=25, Age1=25}
            };
        }

        public void OnGet()
        {
            DisplayedPeople = people;
        }
        public void OnPostGreaterThan(int age)
        {
            DisplayedPeople = people.Where(p => p.Age > age).ToList();
        }
        public void OnPostLessThan(int age)
        {
            DisplayedPeople = people.Where(p => p.Age < age).ToList();
        }

    }

    public class Table1
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int Age1 { get; set; }
    }