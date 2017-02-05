using System;
using System.Linq;
using Plugin.Classica.Bindings.iOS;
using Plugin.Classica.Abstractions;

namespace Plugin.Classica
{
	public class ComposerImplementation : IComposer
	{

		private Bindings.iOS.Composer Composer { get; }

		public ComposerImplementation(Bindings.iOS.Composer composer)
		{
			Composer = composer;
		}

		public int Id => Composer.Id;

		public string Name => Composer.Name;

		public int Birth => Composer.Birth;

		public int Death => Composer.Death;

		public IMusic[] Musics => Composer.Musics.Select(music => new MusicImplementation(music)).ToArray();

		public string[] MusicNames => Composer.GetMusicNames();

	}
}