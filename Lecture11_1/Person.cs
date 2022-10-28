namespace Lecture11_1;

public class Person
{
    private string _firstName;
    private string _lastName;
    private DateTime _birthDate;

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (value.Length > 10)
            {
                throw new Exception($"Wrong firstname {value}");
            }
            else
            {
                _firstName = value;
            }
        }
    }

    public int Age
    {
        get => _birthDate.Year;
        set
        {
            if (value > 150)
            {
                throw 
                    new AgeOutOfRangeException($"year {DateTime.Now.AddYears(-value).Year} is out of range","please enter correct value");
            }

            _birthDate = DateTime.Now.AddYears(-value);
        }
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public Person(string firstName, string lastName, DateTime birthDate)
    {
        _firstName = firstName;
        _lastName = lastName;
        _birthDate = birthDate;
    }
}