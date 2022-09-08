namespace _23Aug.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public List<Employee> GetEmployee()
        { var e1= new Employee();
            var e2= new Employee();
            var emp= new List<Employee>();
            e1.Id = 1;
            e1.Name = "buvi";
            e2.Id = 2;
            e2.Name = "masi";
            emp.Add(e1);
            emp.Add(e2);
            return emp;
        }
    }

}
