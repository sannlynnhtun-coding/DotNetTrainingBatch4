using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch4.RestApiWithNLayer.Features.Blog;

[Route("api/[controller]")]
[ApiController]
public class BlogController : ControllerBase
{
    private readonly BL_Blog _bL_Blog;

    public BlogController()
    {
        _bL_Blog = new BL_Blog();
    }

    [HttpGet]
    public IActionResult Read()
    {
        var lst = _bL_Blog.GetBlogs();
        return Ok(lst);
    }

    [HttpGet("{id}")]
    public IActionResult Edit(int id)
    {
        var item = _bL_Blog.GetBlog(id);
        if (item is null)
        {
            return NotFound("No data found.");
        }

        return Ok(item);
    }

    [HttpPost]
    public IActionResult Create(BlogModel blog)
    {
        var result = _bL_Blog.CreateBlog(blog);

        string message = result > 0 ? "Saving Successful." : "Saving Failed.";
        return Ok(message);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, BlogModel blog)
    {
        var item = _bL_Blog.GetBlog(id);
        if (item is null)
        {
            return NotFound("No data found.");
        }

        var result = _bL_Blog.UpdateBlog(id, blog);
        string message = result > 0 ? "Updating Successful." : "Updating Failed.";
        return Ok(message);
    }

    //[HttpPatch("{id}")]
    //public IActionResult Patch(int id, BlogModel blog)
    //{
    //    var item = _context.Blogs.FirstOrDefault(x => x.BlogId == id);
    //    if (item is null)
    //    {
    //        return NotFound("No data found.");
    //    }

    //    if (!string.IsNullOrEmpty(blog.BlogTitle))
    //    {
    //        item.BlogTitle = blog.BlogTitle;
    //    }

    //    if (!string.IsNullOrEmpty(blog.BlogAuthor))
    //    {
    //        item.BlogAuthor = blog.BlogAuthor;
    //    }

    //    if (!string.IsNullOrEmpty(blog.BlogContent))
    //    {
    //        item.BlogContent = blog.BlogContent;
    //    }

    //    var result = _context.SaveChanges();

    //    string message = result > 0 ? "Updating Successful." : "Updating Failed.";
    //    return Ok(message);
    //}

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var item = _bL_Blog.GetBlog(id);
        if (item is null)
        {
            return NotFound("No data found.");
        }

        var result = _bL_Blog.DeleteBlog(id);
        string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
        return Ok(message);
    }
}
