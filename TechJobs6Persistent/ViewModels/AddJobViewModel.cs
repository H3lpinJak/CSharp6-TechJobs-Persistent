using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels;

public class AddJobViewModel
{
    [Required(ErrorMessage = "Where dat Job Name at?")]
    public string Name { get; set;}
    [Required(ErrorMessage = "Where's dat EmployerId")]
    public int EmployerId { get; set; }
    public List<SelectListItem> Employers { get; set; }

    public AddJobViewModel(List<Employer> employerList)
        {
            Employers = new List<SelectListItem>();

            foreach (Employer employers in employerList)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = employers.Id.ToString(),
                        Text = employers.Name
                    }
                ); 
            }
        }
            public AddJobViewModel()
            {
            }
        
}