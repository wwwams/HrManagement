using Domain.Models;
namespace RoleService;
public class RoleService
{
    private List<Role> roles = new List<Role>();
    public List<Role> GetRole()
    {
        return roles;
    }
    public void Add(Role role)
    {
        roles.Add(role);
    }
    public void Update(Role role, int id)
    {
        int n = 0;
        foreach (var item in roles)
        {
            if (item.Id == id)
            {
                roles.Remove(item);
                roles.Insert(n, role);
            }
            n++;
        }
    }
    public Role GetRoleById(int id)
    {
        Role idd = new Role();
        foreach (var item in roles)
        {
            if (item.Id == id)
                idd = item;
        }
        return idd;
    }
    public void Delete(int id)
    {
        foreach (var item in roles)
        {
            if (item.Id == id)
            {
                roles.Remove(item);
            }
        }
    }
    public int Count()
    {
        int n = roles.Count();
        return n;
    }
}
