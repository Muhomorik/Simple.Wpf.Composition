﻿using System;

namespace Simple.Wpf.Composition.Core.Services
{
    public interface IMemoryService
    {
        IObservable<decimal> MemoryInBytes { get; }

        IObservable<decimal> MemoryInKiloBytes { get; }

        IObservable<decimal> MemoryInMegaBytes { get; }

        IObservable<decimal> MemoryInGigaBytes { get; }
    }
}