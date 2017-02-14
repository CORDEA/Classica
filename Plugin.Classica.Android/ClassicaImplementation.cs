using System;
using System.ComponentModel.Design;
using System.Linq;
using Android.App;
using Java.Lang;
using Plugin.Classica.Abstractions;

namespace Plugin.Classica
{
    public class ClassicaImplementation : IClassica
    {

        private Bindings.Android.Classica Classica { get; }

        public ClassicaImplementation()
        {
            Classica = new Bindings.Android.Classica(Application.Context);
        }

        public IMusic[] Musics => Classica.Musics.Select(music => new MusicImplementation(music)).ToArray();

        public IComposer[] Composers => Classica.Composers.Select(composer => new ComposerImplementation(composer))
            .ToArray();

        public IComposer GetComposer(int id)
        {
            return new ComposerImplementation(Classica.GetComposer(id));
        }

        public IMusic GetMusic(int id)
        {
            return new MusicImplementation(Classica.GetMusic(id));
        }
    }
}
