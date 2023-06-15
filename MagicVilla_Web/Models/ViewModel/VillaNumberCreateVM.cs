using MagicVilla_Web.Models.DTO;

namespace MagicVilla_Web.Models.ViewModel
{
    public class VillaNumberCreateVM
    {
        public VillaNumberCreateVM()
        {
            VillaNumber = new VillaNumberCreateDTO();
        }
        public VillaNumberCreateDTO VillaNumber { get; set; }
    }
}
