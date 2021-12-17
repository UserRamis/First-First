using System;


namespace _11._12._21
{
    public class DeveloperInfoAttribute : Attribute
    {
        public string Developer;
        public string Time;

        public DeveloperInfoAttribute(string developer, string time)
        {
            Developer = developer;
            Time = time;
        }
    }
}