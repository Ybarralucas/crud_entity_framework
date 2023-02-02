using Microsoft.AspNetCore.Mvc.Rendering;

namespace crudly.Models.ViewModels
{
    public class EmpleadoVM
    {
        public Empleado oEmpleado { get; set; }
        public List<SelectListItem> oListaCargo { get; set; }
    }
}
