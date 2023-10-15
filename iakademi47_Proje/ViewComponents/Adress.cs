using iakademi47_Proje.Models;
using Microsoft.AspNetCore.Mvc;

namespace iakademi47_Proje.ViewComponents
{
    public class Adress : ViewComponent
    {
        iakademi47Context context=new iakademi47Context();

        public string Invoke()
        {
            string? adress = context.Settings.FirstOrDefault(s => s.SettingID == 1).Adress;
            return $"{adress}";

        }
    }
}
