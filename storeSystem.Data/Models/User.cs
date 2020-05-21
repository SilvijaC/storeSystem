using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace storeSystem.Data.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        [NotMapped]
        public string Password
        {
            get => _password;
            set => _password = Utility.ComputeSha256Hash(value);
        }
        [Required]
        [Column("Password")]
        public string _password { get; private set; }

        public bool DoPasswordsMatch(string textPassword)
        {
            var hashed = Utility.ComputeSha256Hash(textPassword);
            return hashed.Equals(_password);
        }

    }
}
