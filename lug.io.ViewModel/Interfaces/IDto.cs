﻿namespace lug.io.ViewModel.Interfaces
{
    public interface IDto<TId>
    {
        TId Id { get; set; }
        string ClientId { get; set; }
    }
}