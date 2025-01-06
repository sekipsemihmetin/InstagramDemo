using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.AbstractServices
{
   public  interface IEmailService
    {
        void SendEmail(string email,string subject,string bady);
    }
}
