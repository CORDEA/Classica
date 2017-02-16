using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.Classica.Abstractions;

namespace Plugin.Classica.Sample.Android
{
    public class MusicListAdapter : ArrayAdapter<IMusic>
    {
        public MusicListAdapter(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
        }

        public MusicListAdapter(Context context, IMusic[] objects)
            : base(context, Resource.Layout.ListItemMain, objects)
        {
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? LayoutInflater.From(Context).Inflate(Resource.Layout.ListItemMain, parent, false);
            var item = GetItem(position);

            var title = view.FindViewById<TextView>(Resource.Id.title);
            var description = view.FindViewById<TextView>(Resource.Id.description);

            title.Text = item.Name;
            description.Text = item.Year.ToString();

            return view;
        }
    }
}