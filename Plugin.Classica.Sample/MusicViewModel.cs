using System;
using Plugin.Classica.Abstractions;

namespace Plugin.Classica.Sample
{
    public class MusicViewModel
    {
        public IMusic[] Musics { get; }

        public MusicViewModel(int composerId)
        {
            var classica = CrossClassica.Current;
            Musics = classica.GetComposer(composerId)?.Musics ?? new IMusic[] { };
        }
    }
}