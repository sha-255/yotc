//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoeduSam
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_ProductDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public Nullable<int> ImagesCount { get; set; }
        public Nullable<int> ProductsCount { get; set; }
        public Nullable<System.DateTime> DateLastSale { get; set; }
        public Nullable<int> VolumeLastSales { get; set; }
        public Nullable<int> AvgCountSaleInYear { get; set; }
        public string Active { get; set; }
        public int ManufacturerId { get; set; }

        public string NameWithAdds
        {
            get
            {
                return Name + " (" + ProductsCount.ToString() + ")";
            }
        }

    }
}
