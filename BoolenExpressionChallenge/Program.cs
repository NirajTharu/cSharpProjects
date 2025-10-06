// DecesionLogic Challenge
/*In this challenge, you implement decision logic based on a series of business rules. 
The business rules specify the access that is granted to users based on their role-based permissions and their career level. 
Code branches display a different message to the user depending on their permissions and level.

1. If the user is an Admin with a level greater than 55, output the message:
Welcome, Super Admin user.
2. If the user is an Admin with a level less than or equal to 55, output the message:
Welcome, Admin user.
3. If the user is a Manager with a level 20 or greater, output the message:
Contact an Admin for access.
4. If the user is a Manager with a level less than 20, output the message:
You do not have sufficient privileges.
5. If the user isn't an Admin or a Manager, output the message:
You do not have sufficient privileges.
*/

using System;
namespace PermissionLevesls
{
    class Program
    {
        static void Main(string[] args)
        {
            string persmission = "Admin|Manager";
            int level = 56;
            if (persmission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else if (level <= 55)
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (persmission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else if (level < 20)
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
    }
}