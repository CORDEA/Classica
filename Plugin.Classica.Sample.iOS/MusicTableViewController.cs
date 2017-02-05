using System;
using Foundation;
using Plugin.Classica.Abstractions;
using UIKit;

namespace Plugin.Classica.Sample.iOS
{
	public partial class MusicTableViewController : UITableViewController
	{
		public int ComposerId { get; set; }

	    private MusicViewModel ViewModel { get; set; }

		public MusicTableViewController() : base("MusicTableViewController", null)
		{
			Initialize();
		}

		public MusicTableViewController(IntPtr handle) : base (handle)
		{
			Initialize();
		}

		private void Initialize()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			ViewModel = new MusicViewModel(ComposerId);
			TableView.Source = new TableViewSource(ViewModel.Musics);
		}

	    private class TableViewSource : UITableViewSource
		{
			private IMusic[] Musics { get; }

			public TableViewSource(IMusic[] musics)
			{
				Musics = musics;
			}

			public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
			{
				var cell = tableView.DequeueReusableCell("MusicCell", indexPath);
				var music = Musics[indexPath.Row];
				cell.TextLabel.Text = music.Name;
				cell.DetailTextLabel.Text = music.Year.ToString();
				return cell;
			}

			public override nint RowsInSection(UITableView tableview, nint section)
			{
				return Musics.Length;
			}
		}
	}
}

