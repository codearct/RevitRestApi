using Business.Abstract;
using DataAccess.Concrete.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        public string SelectProject(string projectName)
        {
            return DatabaseConnection.SetConnectionString(projectName);
        }
    }
}
