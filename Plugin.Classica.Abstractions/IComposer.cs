using System;

namespace Plugin.Classica.Abstractions
{
    public interface IComposer
    {
        int Id { get; }

        string Name { get; }

        int Birth { get; }

        int Death { get; }

        IMusic[] Musics { get; }
    }
}