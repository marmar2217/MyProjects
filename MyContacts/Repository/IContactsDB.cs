using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyContacts
{
    interface IContactsDB
    {
        DataTable SelectAll();        
        bool Insert(string Name, string Family, int Age, string Mobile, string Email, string Address);
        bool Update(int ID,string Name, string Family, int Age, string Mobile, string Email, string Address);
        DataTable SelectRow(int contactId);
        bool Delete(int ID);
    }
}
