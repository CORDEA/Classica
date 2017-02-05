using System;
using Plugin.Classica.Abstractions;

namespace Plugin.Classica.Sample
{
	public class ComposerViewModel
	{

		public IComposer[] Composers { get; }

		public ComposerViewModel()
		{
			var classica = CrossClassica.Current;
			Composers = classica.Composers;
		}

		public string GetDetailText(IComposer composer)
		{
		    var age = composer.Death - composer.Birth;
			return $"{composer.Birth} - {composer.Death} ({age})";
		}
	}
}
