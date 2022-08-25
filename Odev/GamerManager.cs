using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        //GamerManager bağlı olduğu ve doğrulama kullanacağı belirlendik
        //Constructor işlemi
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Oyuncu Eklendi");
            }
            else
            {
                Console.WriteLine("Doğrulama ve Kayıt işlemi başarısızdır");
            }           
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Bilgileri Güncellendi");
        }
    }
}
