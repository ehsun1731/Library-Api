﻿namespace Library_api.Entities
{
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<Book> Books { get; set; }

    }
}
