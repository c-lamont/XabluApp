using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XabluApp.Core
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogModel>> GetBlogs();
        Task<BlogModel> GetBlog(int id);
    }
}
