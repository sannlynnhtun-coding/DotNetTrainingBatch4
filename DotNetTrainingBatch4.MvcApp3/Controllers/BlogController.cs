using DotNetTrainingBatch4.MvcApp3.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace DotNetTrainingBatch4.MvcApp3.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;

        // constructor injection
        public BlogController(AppDbContext db)
        {
            _db = db;
        }

        // logical path => https://localhost:3000/blog/index
        // physical path => https://localhost:3000/blog/blogindex
        //[ActionName("Index")] // Ko Lin
        //public IActionResult BlogIndex([FromServices] AppDbContext db) // method injection
        //{
        //    return View("BlogIndex"); // Sann Lynn Htun
        //}

        //[FromServices]
        //public AppDbContext db { get; set; } // property injection

        // CRUD

        // Read
        [HttpGet]
        [ActionName("Index")]
        public IActionResult BlogIndex()
        {
            // select * from tbl_blog
            // select * from tbl_blog with (nolock)
            // 10
            // 1 - a
            // 2 - b => other => bb
            // 3 - c
            List<BlogEntity> lst = _db.Blogs.AsNoTracking()
                .OrderByDescending(x => x.BlogId)
                .ToList();
            return View("BlogIndex", lst);
        }

        // Create
        [HttpGet]
        [ActionName("Create")]
        public IActionResult BlogCreate()
        {
            return View("BlogCreate");
        }

        // Save
        [HttpPost]
        [ActionName("Save")]
        public IActionResult BlogSave(BlogEntity blog)
        {
            _db.Blogs.Add(blog);
            //_db.Add(blog);
            var result = _db.SaveChanges();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";

            //return View("BlogCreate");
            return Json(new { Message = message, IsSuccess = result > 0 });
        }

        // blog/edit?blogId=1
        // blog/edit/1
        // Edit
        [HttpGet]
        [ActionName("Edit")]
        public IActionResult BlogEdit(int id)
        {
            var item = _db.Blogs.AsNoTracking().FirstOrDefault(x => x.BlogId == id);
            if (item is null) return RedirectToAction("Index");

            return View("BlogEdit", item);
        }

        // Update
        [HttpPost]
        [ActionName("Update")]
        public IActionResult BlogUpdate(int id, BlogEntity blog)
        {
            var item = _db.Blogs.AsNoTracking().FirstOrDefault(x => x.BlogId == id);
            if (item is null) return Json(new { Message = "No data found.", IsSuccess = false });

            item.BlogTitle = blog.BlogTitle;
            item.BlogAuthor = blog.BlogAuthor;
            item.BlogContent = blog.BlogContent;

            _db.Entry(item).State = EntityState.Modified;
            var result = _db.SaveChanges();
            string message = result > 0 ? "Updating Successful." : "Updating Failed.";

            //return View("BlogCreate");
            return Json(new { Message = message, IsSuccess = result > 0 });
        }

        // Delete
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult BlogDelete(BlogEntity blog)
        {
            var item = _db.Blogs.AsNoTracking().FirstOrDefault(x => x.BlogId == blog.BlogId);
            if (item is null) return Json(new { Message = "No data found.", IsSuccess = false });

            _db.Entry(item).State = EntityState.Deleted;
            var result = _db.SaveChanges();
            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";

            return Json(new { Message = message, IsSuccess = result > 0 });
        }
    }
}
