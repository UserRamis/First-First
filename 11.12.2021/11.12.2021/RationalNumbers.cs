
namespace _11._12._21
{
    [DeveloperInfo("Гарипов Рамис ", "11.12.21")]
    [OrganizationInfo("Гарипов Рамис", "Google")]
    class RationalNumbers
    {
        public int Numerator { get; set; } 
        public uint Denominator { get; set; } 
        public double Rational => ((double)Numerator) / ((double)Denominator);
    }
}