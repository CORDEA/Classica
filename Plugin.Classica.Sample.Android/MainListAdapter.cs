using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.Classica.Abstractions;

namespace Plugin.Classica.Sample.Android
{
    public class MainListAdapter : ArrayAdapter<IComposer>
    {
        private ComposerViewModel ViewModel { get; }

        public MainListAdapter(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
        }

        public MainListAdapter(Context context, ComposerViewModel viewModel)
            : base(context, Resource.Layout.ListItemMain, viewModel.Composers)
        {
            ViewModel = viewModel;
        }

        public override long GetItemId(int position)
        {
            return GetItem(position).Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? LayoutInflater.From(Context).Inflate(Resource.Layout.ListItemMain, parent, false);
            var item = GetItem(position);

            var title = view.FindViewById<TextView>(Resource.Id.title);
            var description = view.FindViewById<TextView>(Resource.Id.description);

            title.Text = item.Name;
            description.Text = ViewModel.GetDetailText(item);

            return view;
        }
    }
}