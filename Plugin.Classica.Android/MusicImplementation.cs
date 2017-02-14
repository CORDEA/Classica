using Plugin.Classica.Abstractions;

namespace Plugin.Classica
{
    public class MusicImplementation : IMusic
    {
        private Classica.Bindings.Android.Music Music { get; }

        public MusicImplementation(Classica.Bindings.Android.Music music)
        {
            Music = music;
        }

        public int Id => Music.Id;

        public int ComposerId => Music.ComposerId;

        public string Name => Music.Name;

        public int Year => Music.Year;

        public string OpusNumber => Music.OpusNumber;

    }
}
