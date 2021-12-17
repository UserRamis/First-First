using System;


namespace _11._12._21
{
    class OrganizationInfoAttribute : Attribute
    {
        public string Developer;
        public string Organization;

        public OrganizationInfoAttribute(string developer, string organization)
        {
            Developer = developer;
            Organization = organization;
        }
    }
}