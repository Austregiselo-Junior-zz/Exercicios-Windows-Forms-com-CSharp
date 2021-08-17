using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Exercicios_LendoJSON.Models.Entities
{
    class Entity
    {
        [Required(ErrorMessage = "O CEP é obrigatório.")]
        //[RegularExpression("([0 - 9]{5}-[0 - 9]{3})", ErrorMessage ="O campo só aceita valores numéricos")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "CPF deve ter 9 dígitos")]
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string ddd { get; set; }
        public string siafi { get; set; }

        /// <summary>
        /// Método para validação das entidades junto com o Data Annotation
        /// </summary>
        public void ValidateEntity()
        {
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (isValid == false)
            {
                StringBuilder sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }
        }
    }
}
