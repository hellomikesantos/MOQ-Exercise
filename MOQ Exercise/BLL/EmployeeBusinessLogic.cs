using MOQ_Exercise.DAL;
using MOQ_Exercise.Models;
using System.Linq;
using System.Text;

namespace MOQ_Exercise.BLL
{
    public class EmployeeBusinessLogic
    {
        private IRepository<Employee> repo;

        public EmployeeBusinessLogic(IRepository<Employee> repo)
        {
            this.repo = repo;
        }

        public double CalculateAnnualBonus(int id)
        {
            Employee employee = repo.Get(id);
            int yearsInCompany = DateTime.Now.Year - employee.HiringYear;
            double annualBonusPercentage = 0.01 * (double)yearsInCompany;
            double annualBonus = employee.Salary * annualBonusPercentage;
            return annualBonus;
        }

        public ICollection<Employee> PrintTop3SalariedEmployees()
        {
            ICollection<Employee> top3List = repo.GetTop3SalariedEmployees();
            StringBuilder output = new StringBuilder();
            foreach(Employee emp in top3List)
            {
                output.Append(emp.Name);
                output.Append(" - Salary: ");
                output.Append("emp.Salary, ");
            }
            //return output.ToString();
            return top3List;
        }
    }
}
