//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.DataFilesApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public Nullable<int> TourId { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual Tour Tour { get; set; }
        public virtual User User { get; set; }
    }
}
