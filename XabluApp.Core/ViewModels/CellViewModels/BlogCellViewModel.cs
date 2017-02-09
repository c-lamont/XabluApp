using System;
using System.Threading.Tasks;

namespace XabluApp.Core
{
    public class BlogCellViewModel : BaseViewModel
    {
        private IBlogService blogService { get; }
        public BlogCellViewModel(IBlogService blogService)
        {
            Title = "Blogs";
            this.blogService = blogService;
        }

        public async Task Init(int id)
        {
            Blog = await blogService.GetBlog(id);
        }

        private BlogModel blog;
        public BlogModel Blog
        {
            get { return blog; }
            set { SetProperty(ref blog, value); }
        }
    }
}
