using System;
using System.Linq;
using Plugin.Classica.Abstractions;

namespace Plugin.Classica
{
	public class ClassicaImplementation : IClassica
	{
	    private Bindings.iOS.Classica Classica { get; }

		public ClassicaImplementation()
		{
			Classica = new Bindings.iOS.Classica();
		}

		public IMusic[] Musics => Classica.Musics.Select(music => new MusicImplementation(music)).ToArray();

		public IComposer[] Composers => Classica.Composers.Select(composer => new ComposerImplementation(composer)).ToArray();

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