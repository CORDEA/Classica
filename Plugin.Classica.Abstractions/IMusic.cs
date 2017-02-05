using System;

namespace Plugin.Classica.Abstractions
{
    public interface IMusic
    {
        int Id { get; }

        int ComposerId { get; }

        string Name { get; }

        int Year { get; }

        string OpusNumber { get; }
    }
}