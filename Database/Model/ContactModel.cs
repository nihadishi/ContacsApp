﻿namespace Database.Model
{
    public class Contact
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string WorkNumber { get; set; }

        public int IdUser { get; set; }
    }
}
