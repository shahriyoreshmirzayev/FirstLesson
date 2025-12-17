namespace ConsoleApp1;

class Hafta_kuni
{
    public int MyProperty { get; set; }
    public WeekInfo WeekInput { get; set; }
}
enum WeekInfo
{
    Dushanba = 1,
    Seshanba, 
    Chorshanba,
    Payshanba,
    Juma,
    Shanba,
    Yakshanba
}
