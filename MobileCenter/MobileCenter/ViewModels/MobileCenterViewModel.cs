using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;

using MvvmHelpers;
using Newtonsoft.Json;
using Xamarin.Forms;
using Plugin.Connectivity;

namespace MobileCenter
{
    public class MobileCenterViewModel : BaseViewModel
    {
        public MobileCenterViewModel()
        {
            Title = "Posts";
        }

        public ObservableRangeCollection<Post> AllPosts { get; set; } = new ObservableRangeCollection<Post>();

        public async Task GetData()
        {
            IsBusy = true;

            AllPosts.Clear();

            var url = "https://jsonplaceholder.typicode.com/posts";
            var client = new HttpClient();

            if (CrossConnectivity.Current.IsConnected)
            {
                var json = await client.GetStringAsync(url);

                var thePosts = JsonConvert.DeserializeObject<List<Post>>(json);

                AllPosts.ReplaceRange(thePosts);
            }

            IsBusy = false;
        }

        Command _getData;
        public Command GetDataCommand => _getData ??
            (_getData = new Command(async () => await GetData()));
    }
}
