//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoRepairService
{
    using System;
    using System.Collections.Generic;
    
    public partial class RequestExecution
    {
        public int ExecutionID { get; set; }
        public Nullable<int> RequestID { get; set; }
        public Nullable<System.DateTime> ExecutionDate { get; set; }
        public string PartsUsed { get; set; }
        public Nullable<int> TimeSpent { get; set; }
        public string Report { get; set; }
    
        public virtual Requests Requests { get; set; }
    }
}
