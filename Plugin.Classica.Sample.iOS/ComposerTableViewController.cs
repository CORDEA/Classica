using System;
using Foundation;
using UIKit;

namespace Plugin.Classica.Sample.iOS
{
	public partial class ComposerTableViewController : UITableViewController
	{
	    private ComposerViewModel ViewModel { get; set; }

		public ComposerTableViewController() : base("ComposerTableViewController", null)
		{
			Initialize();
		}

		public ComposerTableViewController(IntPtr handle) : base (handle)
		{
			Initialize();
		}

		private void Initialize()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			ViewModel = new ComposerViewModel();
			TableView.Source = new TableViewSource(ViewModel);
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
		    if (segue.Identifier != "Music")
		    {
		        return;
		    }

		    var vc = segue.DestinationViewController as MusicTableViewController;
		    var indexPath = TableView.IndexPathForSelectedRow;
		    if (vc != null)
		    {
		        vc.ComposerId = ViewModel.Composers[indexPath.Row].Id;
		    }
		}

	    private class TableViewSource : UITableViewSource
		{

		    private ComposerViewModel ViewModel { get; }

			public TableViewSource(ComposerViewModel viewModel)
			{
			    ViewModel = viewModel;
			}

			public override nint RowsInSection(UITableView tableview, nint section)
			{
				return ViewModel.Composers.Length;
			}

			public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
			{
				var cell = tableView.DequeueReusableCell("ComposerCell", indexPath);
				var composer = ViewModel.Composers[indexPath.Row];
				cell.TextLabel.Text = composer.Name;
				cell.DetailTextLabel.Text = ViewModel.GetDetailText(composer);
				return cell;
			}
		}
	}
}

