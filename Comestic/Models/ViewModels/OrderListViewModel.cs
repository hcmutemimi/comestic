using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comestic.Models.ViewModels
{
    public class OrderListViewModel
    {
        public IList<OrderDetailsViewModel> Orders { get; set; }
        //public PagingInfo PagingInfo { get; internal set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
