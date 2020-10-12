using System;
namespace TextFileDataAccessDemo
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Url { get; set; }

        public Person()
        {
        }

        public Person(string first, string last, string url)
        {
            firstName = first;
            lastName = last;
            Url = url;
        }
    }
}
