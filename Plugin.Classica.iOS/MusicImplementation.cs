using Plugin.Classica.Abstractions;

namespace Plugin.Classica
{
    public class MusicImplementation : IMusic
    {

        private Classica.Bindings.iOS.Music Music { get; }

        public MusicImplementation(Classica.Bindings.iOS.Music music)
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