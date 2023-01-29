using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryApp.Models
{
    public class Order
    {
        /// <summary>
        /// ID Order
        /// </summary>
        public long OrderId { get; set; }
        /// <summary>
        /// Number of order
        /// </summary>
        public string NumberOrder { get; set; } = Guid.NewGuid().ToString();
        /// <summary>
        /// City of the sender
        /// </summary>
        [Required(ErrorMessage = "Please enter a value SenderCity")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "The string length must be between 4 and 20 characters")]
        [RegularExpression(@"[A-Za-z ]{4,20}", ErrorMessage = "Incorrect city")]
        public string SenderCity { get; set; } = String.Empty;
        /// <summary>
        /// Adress of the sender
        /// </summary>
        [Required(ErrorMessage = "Please enter a value SenderAddress")]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "The string length must be between 10 and 150 characters")]
        [RegularExpression(@"[A-Za-z0-9., ]{10,150}", ErrorMessage = "Incorrect address")]
        public string SenderAdress { get; set; } = String.Empty;
        /// <summary>
        /// City of the recipient
        /// </summary>
        [Required(ErrorMessage = "Please enter a value RecipientCity")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "The string length must be between 4 and 20 characters")]
        [RegularExpression(@"[A-Za-z ]{4,20}", ErrorMessage = "Incorrect city")]
        public string RecipientCity { get; set; } = String.Empty;
        /// <summary>
        /// Adress of the recipient
        /// </summary>
        [Required(ErrorMessage = "Please enter a value RecipientAddress")]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "The string length must be between 10 and 150 characters")]
        [RegularExpression(@"[A-Za-z0-9., ]{10,150}", ErrorMessage = "Incorrect address")]
        public string RecipientAdress { get; set;} = String.Empty;
        /// <summary>
        /// Cargo Weight
        /// </summary>
        [Range(1, 999999, ErrorMessage = "Please enter a positive CargoWeight")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal CargoWeight { get; set; }
        /// <summary>
        /// Delivery Date
        /// </summary>
        public DateTime DeliveryDate { get; set; } = DateTime.Today;

    }
}
