using Repository;

namespace BusinessLogic
{
    public sealed class BusinessLogic
    {
        private readonly IRepository _repository;

        public BusinessLogic(IRepository repository)
        {
            _repository = repository;
        }

        public float GetGraduationRate()
        {
            var students = _repository.GetStudents();
            return (float)students.Count(s => s.IsGraduate) / (float)students.Count * 100;
        }
    }
}
