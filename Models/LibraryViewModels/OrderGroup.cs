using System.ComponentModel.DataAnnotations;
namespace Miclea_Adela_Laborator2.Models.LibraryViewModels
{
    public class OrderGroup
    {
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        public int BookCount { get; set; }

    }
}
