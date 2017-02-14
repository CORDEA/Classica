using System.Linq;
using Plugin.Classica.Abstractions;

namespace Plugin.Classica
{
    public class ComposerImplementation : IComposer
    {
        private Bindings.Android.Composer Composer { get; }

        public ComposerImplementation(Bindings.Android.Composer composer)
        {
            Composer = composer;
        }

        public int Id => Composer.Id;

        public string Name => Composer.Name;

        public int Birth => Composer.Birth;

        public int Death => Composer.Death;

        public IMusic[] Musics => Composer.Musics.Select(music => new MusicImplementation(music)).ToArray();

        public string[] MusicNames => Composer.MusicNames.ToArray();
    }
}
