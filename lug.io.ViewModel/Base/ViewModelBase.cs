using System;
using System.Collections.Generic;
using lug.io.ViewModel.Interfaces;

namespace lug.io.ViewModel.Base
{
    public abstract class ViewModelBase<Dto, DDto, TId> : ViewModelNonGenericBase, IViewModelBase<Dto, DDto, TId>
        where Dto : class, IDto<TId>, new()
        where DDto : class, IDto<TId>, new()
    {

        public ViewModelBase()
        {
            List = new List<Dto>();
            Item = new Dto();
            ItemDetail = new DDto();
        }

        public List<Dto> List { get; set; }
        public Dto Item { get; set; }
        public DDto ItemDetail { get; set; }
        public bool ItemDetailIsNew { get; set; }


        public abstract TId GetDefaultIdValue();
    }
}