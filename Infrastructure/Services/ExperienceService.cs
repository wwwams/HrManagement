using Domain.Models;
namespace ExperienceService;
public class ExperienceService
{
    private List<Experience> experiences = new List<Experience>();
    public List<Experience> GetExperience()
    {
        return experiences;
    }
    public void Add(Experience experience)
    {
        experiences.Add(experience);
    }
    public void Update(Experience experience, int id)
    {
        int n = 0;
        foreach (var item in experiences)
        {
            if (item.Id == id)
            {
                experiences.Remove(item);
                experiences.Insert(n, experience);
            }
            n++;
        }
    }
    public Experience GetExperienceById(int id)
    {
        Experience idd = new Experience();
        foreach (var item in experiences)
        {
            if (item.Id == id)
                idd = item;
        }
        return idd;
    }
    public void Delete(int id)
    {
        foreach (var item in experiences)
        {
            if (item.Id == id)
            {
                experiences.Remove(item);
            }
        }
    }
    public int Count()
    {
        int n = experiences.Count();
        return n;
    }
}
