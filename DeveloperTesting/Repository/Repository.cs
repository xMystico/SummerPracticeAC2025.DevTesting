namespace Repository
{
    public class Repository : IRepository
    {
        public IList<Student> GetStudents()
            => new List<Student>
            {
                new Student {Grade = 8, Id = Guid.Parse("C0EDFFD8-38B5-4D78-835A-5B0AE24BEE1B"), Name = "Mike"},
                new Student {Grade = 3, Id = Guid.Parse("B3380E1D-A18A-4BE6-BF46-6A8454021C6D"), Name = "Mary"},
                new Student {Grade = 4, Id = Guid.Parse("CAC3C4A3-B97D-47D1-A8FC-04785EA54F09"), Name = "Marlin"},
                new Student {Grade = 5, Id = Guid.Parse("6F38C227-6A64-4944-A617-9796F1B962F1"), Name = "John"},
                new Student {Grade = 10, Id = Guid.Parse("F532637A-1FB3-488D-B6D0-1030486F40E4"), Name = "Jenny"}
            };
    }
}
