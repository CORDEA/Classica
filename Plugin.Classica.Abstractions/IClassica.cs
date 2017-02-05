using System;

namespace Plugin.Classica.Abstractions
{
    public interface IClassica
    {
        IMusic[] Musics { get; }

        IComposer[] Composers { get; }

        IComposer GetComposer(int id);

        IMusic GetMusic(int id);
    }
}