using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeesCRUD.Models
{
    public class Employee : IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [Display(Name = "Nombre *")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido.")]
        [Display(Name = "Correo Electrónico *")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El área es obligatoria.")]
        [Display(Name = "Área *")]
        [StringLength(50)]
        public string Department { get; set; }

        [Required(ErrorMessage = "La fecha de ingreso es obligatoria.")]
        [Display(Name = "Fecha de Ingreso *")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }

        [Display(Name = "¿Está activo?")]
        public bool IsActive { get; set; }

        // Validación personalizada integrada con ModelState
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (EntryDate > DateTime.Today)
            {
                yield return new ValidationResult(
                    "La fecha de ingreso no puede ser mayor a hoy.",
                    new[] { nameof(EntryDate) });
            }
        }
    }
}