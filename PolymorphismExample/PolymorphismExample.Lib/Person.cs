namespace PolymorphismExample.Lib;
using System;
public class Person
{
    private string firstname;
    private string lastname;
    private string email;
    private DateTime birthday;
    private int age;
    private bool isValid;

    public Person(string f,string l, string mail, DateTime bday)
    {
        firstname=f;
        lastname=l;
        email=mail;
        birthday=bday;
    }
    public Person(string f,string l, DateTime bday)
    {
        firstname=f;
        lastname=l;
        birthday=bday;
    }
    private void agevalidate()
    {
        isValid = true;
        DateTime today = DateTime.Today;
        int age = today.Year - birthday.Year;
        if (birthday.Date > today.AddYears(-age))
        {
        age--;
        }
        if (age < 0 || age > 135)
        {
            isValid = false;
        }
    }
    private string GetChineseSign()
    {
        List<string> signs = new List<string>
        {"Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig"};
        int i = (dateOfBirth.Year - 4) % 12;

        if(i < 0)
        {
            i += 12;
        }
        return signs[i];
    }
    public int GetAge()
    {
        return age;
    }

    public bool IsValid()
    {
        return isValid;
    }

    public bool IsAdult()
    {
        if (!isValid)
        {
            return false;
        }

        return age >= 18;
    }

    public bool IsBirthday()
    {
        DateTime today = DateTime.Today;
        return today.Month == birthday.Month && today.Day == birthday.Day;
    }
    public string GetScreenName()
    {
        string username = firstname + lastname + birthday.ToString("yyMMdd");
        return option;
    }



    
    



}