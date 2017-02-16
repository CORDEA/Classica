using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Plugin.Classica.Sample.Android
{
    [Activity(Label = "Classica", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {
        private ComposerViewModel ViewModel { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            var listView = FindViewById<ListView>(Resource.Id.list_view);
            ViewModel = new ComposerViewModel();

            listView.Adapter = new MainListAdapter(this, ViewModel);
            listView.ItemClick += (sender, args) =>
            {
                var intent = MusicActivity.CreateIntent(this, (int) args.Id);
                StartActivity(intent);
            };
        }
    }
}