using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using XabluApp.Core.Helpers;

namespace XabluApp.Core
{
    public class BlogsViewModel : BaseViewModel
    {
        private IBlogService blogService { get; }
        public BlogsViewModel(IBlogService blogService)
        {
            Title = "Blogs";
            this.blogService = blogService;
        }

        public async Task Init()
        {
            var blogs = await blogService.GetBlogs();
            List<ListItemModel> blogListItems = new List<ListItemModel>();
            foreach (var blog in blogs)
            {
                var blogCell = new BlogCellViewModel(blogService);
                await blogCell.Init(blog.Id);
                blogListItems.Add(new ListItemModel(blogCell));
            }

            Blogs.ReplaceWith(blogListItems);
        }

        public OptimizedObservableCollection<ListItemModel> Blogs { get; set; } = new OptimizedObservableCollection<ListItemModel>();

        public MvxCommand<ListItemModel> SelectBlogCommand => new MvxCommand<ListItemModel>(li =>
        {
            ShowViewModel<WebViewViewModel>(new { webUrl = li.BlogCellViewModel.Blog.Url });
        });
    }
}
