using MOQ_Exercise.Data;
using MOQ_Exercise.Models;

namespace MOQ_Exercise.DAL
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private MOQ_ExerciseContext _db;

        public EmployeeRepository(MOQ_ExerciseContext db)
        {
            _db = db;
        }
        public void Add(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            return _db.Employee.Find(id);
        }

        public Employee Get(Func<Employee, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public ICollection<Employee> GetAll()
        {
            return _db.Employee.ToList();
        }

        public ICollection<Employee> GetList(Func<Employee, bool> predicate)
        {
            return _db.Employee.Where(predicate).ToList();
        }

        public ICollection<Employee> GetTop3SalariedEmployees()
        {
            return GetAll().OrderBy(employee => employee.Salary).Take(3).ToList();

        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Employee Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
