﻿namespace WorkSpaceAPI.Model
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Department Department { get; set; }
    }
}
