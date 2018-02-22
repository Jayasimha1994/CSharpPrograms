using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class UserClass
    {
        int UserId;
        string Password;
        public void setUserId(int i)
        {
            this.UserId = i;
        }
        public void setPassword(String p)
        {
            this.Password = p;
        }
        public int getUserId()
        {
            return this.UserId;
        }
        public String getPassword()
        {
            return this.Password;
        }
    }
    class EncapsulationDemo
    {
        static void Main(string[] args)
        {
            UserClass user = new UserClass();
            user.setUserId(101);
            user.setPassword("jay");
            Console.WriteLine(user.getUserId());
            Console.WriteLine(user.getPassword());
            Console.Read();
        }
    }
}
