using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    class CustomerInfo
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public CustomerInfo(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public CustomerInfo()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public void PrintId()
        {
            Console.WriteLine("Id is:{0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name is:{0}", this.Name);
        }
    }
}
