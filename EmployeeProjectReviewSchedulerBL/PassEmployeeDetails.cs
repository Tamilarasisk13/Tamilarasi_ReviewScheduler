using EmployeeProjectReviewSchedulerDAL;
using EmployeeProjectReviewSchedulerEntity;
namespace EmployeeProjectReviewSchedulerBL
{
    public class PassEmployeeDetails
    {
        public static string Login(string username,string password)
        {
           return UserRepositary.Login(username, password);
        }
        public static int AddEmployee(Employee employee)
        {
            return UserRepositary.AddEmployee( employee);
        }
        public static int DeleteEmployee( int id)
        {
            return UserRepositary.DeleteEmployee(id);
        }
        public static int UpdateEmployee(Employee employee,int id)
        {
            return UserRepositary.UpdateEmployee(employee,id);
        }
        //public static int DisplayEmployee(string id)
        //{
        //    return UserRepositary.DisplayEmployee(id);
        //}
    }
}
