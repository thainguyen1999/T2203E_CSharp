using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.Ex2
{
    internal  class PhoneBook : Phone
    {
        private  List<PhoneEntry> PhoneList;
        public PhoneBook() {
            PhoneList = new List<PhoneEntry>();
            
        }
        public override void InsertPhone(string name, string phone)
        {
            bool found = false;
            foreach (var entry in PhoneList)
            {
                if (entry.Name == name)
                {
                    found = true;
                    if (!entry.PhoneNumbers.Contains(phone))
                    {
                        entry.PhoneNumbers.Add(phone);
                    }
                    break;
                }
            }
        }
        public override void RemovePhone(string name)
        {
            throw new NotImplementedException();
        }
        public override void SearchPhone(string name)
        {
            throw new NotImplementedException();
        }
        public override void UpdatePhone(string name, string newphone)
        {
            throw new NotImplementedException();
        }
        public override void Sort()
        {
            throw new NotImplementedException();
        }
      public class PhoneEntry
        {
            public string Name { get; set; }
            public List<string> PhoneNumbers { get; set; }
        }
    }
}
