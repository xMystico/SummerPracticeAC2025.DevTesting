namespace Repository
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public bool IsGraduate => Grade > 4;
    }
}
