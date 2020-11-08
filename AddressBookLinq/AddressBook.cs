using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookLinq
{
    class AddressBook
    {
        DataTable dataTable = new DataTable();
        /// <summary>
        /// DataTable created for storing contact information
        /// </summary>
        public void CreateAddressBook()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("ZipCode", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("EmailID", typeof(string));
        }
        /// <summary>
        /// Insert Contacts in a the addressBook
        /// </summary>
        public void InsertContacts()
        {
            dataTable.Rows.Add("Harry", "Potter", "Station 9 4/3", "Hogwards", "London", "582465", "852963147", "harryporter@gmail.com");
            dataTable.Rows.Add("Sheldon", "Cooper", "Street 4", "Casper", "Texas", "525252", "9876778434", "cooper@yahoo.com");
            dataTable.Rows.Add("Siddhi", "Seth", "Gopal Vihar", "Jabalpur", "Madhya Pradesh", "856985", "7458658925", "siddhiseth@gmail.com");
            dataTable.Rows.Add("Priyanka", "Chopra", "Street 5", "NewYork", "NewYork", "520147", "5201118267", "priyanka@gmail.com");
            dataTable.Rows.Add("Kareena", "Kapoor", "Bandra", "Mumbai", "Maharashtra", "852412", "7458965896", "kareena@yahoo.com");
            dataTable.Rows.Add("Aditya", "Singh", "NavyNagar", "Vizag", "Andra Pradesh", "842563", "7849876734", "aditya@rediffmail.com");
            dataTable.Rows.Add("John", "Parker", "Broadway", "NewYork", "NewYork", "10028", "4256387459", "parker@gmail.com");
            dataTable.Rows.Add("Bugs", "Bunny", "GrandmaHome", "Tristate Area", "NewYork", "100001", "8987224534", "Bugs@gmail.com");
            dataTable.Rows.Add("Captain", "Hook", "Sea Waters", "Island", "California", "452652", "6767986886", "hook@gmail.com");
            dataTable.Rows.Add("Monica", "Gellar", "Richwood", "Manhattan", "NewYork", "652369", "9874523555", "monicagellar@yahoo.com");
        }

    }
}
