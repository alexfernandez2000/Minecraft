using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MinecraftHypixel.Models
{
    public class DinamicFormClass
    {
        public PropertyInfo Property { get; set; }
        public bool ShowErrorMessage { get; set; }
        public IEnumerable<ValidationResult> Validate(object obj)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            object? value = Property.GetValue(obj);

            ValidationContext context = new ValidationContext(obj) { MemberName = Property.Name };
            Validator.TryValidateProperty(value, context, results);
            
            return results;
        }
        //TODO Concat if there is more than one error message
        public string GetErrorMessage(PropertyInfo propertyInfo)
        {
            ValidationAttribute? attribute = propertyInfo.GetCustomAttributes(typeof(ValidationAttribute), true)
                                    .Cast<ValidationAttribute>()
                                    .FirstOrDefault();

            if (attribute!=null && attribute.ErrorMessage!=null)
            {
                return attribute.ErrorMessage;
            }
            return "Missing error message.";
        }

    }

}
