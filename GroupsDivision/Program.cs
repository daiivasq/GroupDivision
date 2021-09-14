using System;
using System.Collections.Generic;
using System.Data.Common;

namespace GroupsDivision
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }


    }

    public class Topic
    {
        public string Id { get; set; }
        public string Name { get; set; }


    }

    public class Group
    {
        public string Id { get; set; }
        public List<Student> Students { get; set; }
        public List<string> Topics { get; set; }

        public Group(string id, List<Student> student, List<string> topic)
        {
            Id = id;
            Students = student;
            Topics = topic;
        }

    }

    public class Division
    {
        static void Main(string[] args)
        {
            int groupQuantity = 2;
            var studentsQuantity = 3;
            var topicsQuantity = 2;

            List<Student> students = new List<Student>()
            {
                new Student() {Name = "Ana Vasquez", Id = "1"},
                new Student() {Name = "Juan Soto", Id = "2"},
                new Student() {Name = "Luis Vargas", Id = "3"},
            };

            List<Topic> topics = new List<Topic>()
            {
                new Topic() {Name = "c#", Id = "1"},
                new Topic() {Name = "Dart", Id = "2"}
            };

           
            try
            {
             // List<Group> groups = GenerateGroups(groupQuantity, students, topics);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
        public void  GenerateGroups(int groupQuantity, List<Student> students, List<Topic> topics)
        {
            
        }
        
        void PrintData()
        {
            
        }
    }
}


