using System;
using System.Collections.Generic;
using System.Text;
using MvvmHelpers;

namespace IcelandWahidin.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public IList<ProductViewModel> Products { get; set; }
        public MainViewModel()
        {
            Products = new ObservableRangeCollection<ProductViewModel>()
            {
                new ProductViewModel()
                {
                    Name = "Sky Blue",
                    HeroColor = "#95C9F7",
                    ImageUrl = "mossGreen",
                    Price = 12,
                    IsFeatured = true
                },
                new ProductViewModel()
                {
                    Name = "Yellow Sun",
                    HeroColor = "#FFCA81",
                    ImageUrl = "mossGreen",
                    Price = 17,
                    IsFeatured = false
                },
                new ProductViewModel()
                {
                    Name = "Lavender",
                    HeroColor = "#D69EFC",
                    ImageUrl = "mossGreen",
                    Price = 19,
                    IsFeatured = false
                },
                new ProductViewModel()
                {
                    Name = "Green Life",
                    HeroColor = "#74D69E",
                    ImageUrl = "mossGreen",
                    Price = 14,
                    IsFeatured = true
                },
            };
        }
    }
}
