using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.Abstraction.AbstractClass
{
    public abstract class NotifcationAbstractClass
    {
        protected string Message;

        public NotifcationAbstractClass(string message)
        {
            Message = message;
        }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Message))
                throw new Exception("Message cannot be empty");
        }

        public abstract void Send();
    }
}
