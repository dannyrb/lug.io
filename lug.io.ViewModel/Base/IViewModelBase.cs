using System.Collections.Generic;
using lug.io.ViewModel.Common;
using lug.io.ViewModel.DTO;
using lug.io.ViewModel.Interfaces;

namespace lug.io.ViewModel.Base
{
    public interface IViewModelBase<Dto, DDto, TId>
        where Dto : class, IDto<TId>, new()
        where DDto : class, IDto<TId>, new()
    {
        List<Dto> List { get; set; } // List || Table
        SimpleModelState ModelState { get; set; }
        Dto Item { get; set; }
        DDto ItemDetail { get; set; } // Form || Selected
        KOMapping KOMapping { get; set; }
        string ToJson();
        bool ItemDetailIsNew { get; set; }
        string Title { get; set; }
        LoggedInUserDto User { get; set; }
    }
}