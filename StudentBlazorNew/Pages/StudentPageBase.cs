using Microsoft.AspNetCore.Components;
using StudentBlazorNew.Data;
using StudentBlazorNew.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentBlazorNew.Pages
{
    public class StudentPageBase : ComponentBase
    {
        [Inject]
        public IStudentService StudentService { get; set; }
        public List<Student> Students { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Students = await StudentService.GetStudents();
        }
    }
}
