using SINU.Model;

namespace SINU.VM
{
    public class TeacherVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }

        public TeacherVM() { }

        public TeacherVM(User user)
        {
            this.Id = user.Id;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;  
            this.Email = user.Email;    
            this.Phone = user.Phone;
            this.Role = user.Role;
        }




    }



}