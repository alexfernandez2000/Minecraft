using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class testing
{
    public static void Main()
    {
        //var user = new User { Name = "John", Email = "invalidemail", Password = "123" };

        //ValidateProperty(user, nameof(user.Email));
        //ValidateProperty(user, nameof(user.Password));
    }

    public static void ValidateProperty<T>(T instance, string propertyName)
    {
        var property = typeof(T).GetProperty(propertyName);
        if (property == null)
        {
            throw new ArgumentException("Property not found", nameof(propertyName));
        }

        var context = new ValidationContext(instance)
        {
            MemberName = propertyName
        };

        var results = new List<ValidationResult>();
        var isValid = Validator.TryValidateProperty(property.GetValue(instance), context, results);

        if (isValid)
        {
            Console.WriteLine($"{propertyName} is valid.");
        }
        else
        {
            Console.WriteLine($"{propertyName} is not valid:");
            foreach (var validationResult in results)
            {
                Console.WriteLine($" - {validationResult.ErrorMessage}");
            }
        }
    }
}
