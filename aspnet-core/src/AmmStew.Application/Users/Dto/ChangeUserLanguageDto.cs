using System.ComponentModel.DataAnnotations;

namespace AmmStew.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}