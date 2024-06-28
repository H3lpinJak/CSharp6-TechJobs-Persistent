using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels;

public class AddEmployerViewModel
{
    [Required(ErrorMessage = "Where's dat Name?")]
    public string? Name { get; set;}
    [Required(ErrorMessage = "Where's dat Location?")]
    public string? Location { get; set; }

}
