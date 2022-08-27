using Domain.Models;
namespace EmployeeService;
public class EmployeeService
{
    private List<Employee> employees = new List<Employee>();
    public List<Employee> GetEmployee()
    {
        return employees;
    }
    public void Add(Employee employee)
    {
        employees.Add(employee);
    }
    public void Update(Employee employee, int id)
    {
        int n = 0;
        foreach (var item in employees)
        {
            if (item.Id == id)
            {
                employees.Remove(item);
                employees.Insert(n, employee);
            }
            n++;
        }
    }
    public Employee GetEmployeeById(int id)
    {
        Employee idd = new Employee();
        foreach (var item in employees)
        {
            if (item.Id == id)
                idd = item;
        }
        return idd;
    }
    public void Delete(int id)
    {
        foreach (var item in employees)
        {
            if (item.Id == id)
            {
                employees.Remove(item);
            }
        }
    }
    public int Count()
    {
        int n = employees.Count();
        return n;
    }
}
