using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Try
    {
        protected int ID { get; set; }
        private string Name { get; set; }
        internal int Age { get; set; }
        public string Address { get; set; }

        public void  SetPrivateString(string x)
        {
            Name = x;
        }

        public void SetProtectedID(int x)
        {
            ID = x;
        }

        public void SetInternalAge(int x)
        {
            Age = x;
        }

        public int GetProtectedID() 
        {
            return ID;
        }

        public int CatchInternal()
        {
            return Age;
        }

        public string CatchPrivate()
        {
            if (Name == null)
            {
                throw new InvalidOperationException();
            }
            return Name; 
        }
    }
}
