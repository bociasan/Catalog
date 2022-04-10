using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SINU.DTO
{
	public class ChangePasswordDTO
	{
		 
         public string Password { get; set; }
         public string NewPassword { get; set; } 
         public string Email { get; set; }
         public string Address { get; set; }
         public string Phone { get; set; }
         public string Nationality { get; set; }
        
}
}