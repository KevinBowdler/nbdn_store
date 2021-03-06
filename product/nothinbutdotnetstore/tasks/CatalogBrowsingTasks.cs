using System.Collections.Generic;
using nothinbutdotnetstore.model;

namespace nothinbutdotnetstore.tasks
{
    public interface CatalogBrowsingTasks
    {
        IEnumerable<Department> get_all_departments();
        IEnumerable<Department> get_sub_departments(string departmentname);
    }
}