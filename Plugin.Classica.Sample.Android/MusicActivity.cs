using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Plugin.Classica.Sample.Android
{
    [Activity(Label = "Musics")]
    public class MusicActivity : AppCompatActivity
    {
        private const string ComposerIdKey = "ComposerId";

        public static Intent CreateIntent(Context context, int composerId)
        {
            var intent = new Intent(context, typeof(MusicActivity));
            intent.PutExtra(ComposerIdKey, composerId);
            return intent;
        }

        private MusicViewModel ViewModel { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Music);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            ViewModel = new MusicViewModel(Intent.GetIntExtra(ComposerIdKey, -1));
            var listView = FindViewById<ListView>(Resource.Id.list_view);
            listView.Adapter = new MusicListAdapter(this, ViewModel.Musics);
        }
    }
}