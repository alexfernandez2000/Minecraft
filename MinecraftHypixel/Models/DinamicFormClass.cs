using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MinecraftHypixel.Models
{
    public class DinamicFormClass
    {
        public PropertyInfo Property { get; set; }
        public bool ShowErrorMessage { get; set; }
        public string ErrorMessage { get; set; }
        public DinamicFormClass(PropertyInfo property)
        {
            ErrorMessage=GetErrorMessageFromProperty(property);
            Property = property;
            ShowErrorMessage=false;
        }
        private static string GetErrorMessageFromProperty(PropertyInfo property)
        {
            // Obtener el primer ValidationAttribute (o nulo si no hay ninguno)
            var attribute = property.GetCustomAttributes(typeof(ValidationAttribute), true)
                                    .Cast<ValidationAttribute>()
                                    .FirstOrDefault();

            // Si se encuentra un ValidationAttribute, devolver su mensaje de error
            return attribute?.ErrorMessage ?? "No validation attribute found.";
        }

    }

}
