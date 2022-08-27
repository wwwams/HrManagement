using Domain.Models;
namespace Serveces.DepartmentService;
public class DepartmentService
{
    private List<Department> departments = new List<Department>();
    public List<Department> GetDepartments()
    {
        return departments;
    }
    public void Add(Department department)
    {
        departments.Add(department);
    }
    public void Update(Department department, int id)
    {
        int n = 0;
        foreach (var item in departments)
        {
            if (item.Id == id)
            {
                departments.Remove(item);
                departments.Insert(n, department);
            }
            n++;
        }
    }
    public Department GetDepartmentById(int id)
    {
        Department idd = new Department();
        foreach (var item in departments)
        {
            if (item.Id == id)
                idd = item;
        }
        return idd;
    }
    public void Delete(int id)
    {
        foreach (var item in departments)
        {
            if (item.Id == id)
            {
                departments.Remove(item);
            }
        }
    }
    public int Count()
    {
        int n = departments.Count();
        return n;
    }
}
