namespace DotNetTrainingBatch4.RestApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogAdoDotNet2Controller : ControllerBase
{
    private readonly AdoDotNetService _adoDotNetService =
        new AdoDotNetService(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);

    [HttpGet]
    public IActionResult GetBlogs()
    {
        string query = "select * from tbl_blog";
        var lst = _adoDotNetService.Query<BlogModel>(query);

        return Ok(lst);
    }

    [HttpGet("{id}")]
    public IActionResult GetBlog(int id)
    {
        string query = "select * from tbl_blog where BlogId = @BlogId";

        //AdoDotNetParameter[] parameters = new AdoDotNetParameter[1];
        //parameters[0] = new AdoDotNetParameter("@BlogId", id);
        //var lst = _adoDotNetService.Query<BlogModel>(query, parameters);

        var item = _adoDotNetService.QueryFirstOrDefault<BlogModel>(query, new AdoDotNetParameter("@BlogId", id));

        //SqlConnection connection = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
        //connection.Open();

        //SqlCommand cmd = new SqlCommand(query, connection);
        //cmd.Parameters.AddWithValue("@BlogId", id);
        //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
        //DataTable dt = new DataTable();
        //sqlDataAdapter.Fill(dt);

        //connection.Close();

        if (item is null)
        {
            return NotFound("No data found.");
        }

        return Ok(item);
    }

    [HttpPost]
    public IActionResult CreateBlog(BlogModel blog)
    {
        string query = @"INSERT INTO [dbo].[Tbl_Blog]
           ([BlogTitle]
           ,[BlogAuthor]
           ,[BlogContent])
     VALUES
           (@BlogTitle
           ,@BlogAuthor       
           ,@BlogContent)";

        int result = _adoDotNetService.Execute(query,
            new AdoDotNetParameter("@BlogTitle", blog.BlogTitle),
            new AdoDotNetParameter("@BlogAuthor", blog.BlogAuthor),
            new AdoDotNetParameter("@BlogContent", blog.BlogContent)
        );

        string message = result > 0 ? "Saving Successful." : "Saving Failed.";
        //return StatusCode(500, message);
        return Ok(message);
    }

    [HttpPut("{id}")]
    public IActionResult PutBlog(int id, BlogModel blog)
    {
        string query = @"UPDATE [dbo].[Tbl_Blog]
                        SET [BlogTitle] = @BlogTitle,
                            [BlogAuthor] = @BlogAuthor,
                            [BlogContent] = @BlogContent
                        WHERE [BlogId] = @BlogId";

        int result = _adoDotNetService.Execute(query,
            new AdoDotNetParameter("@BlogId", id),
            new AdoDotNetParameter("@BlogTitle", blog.BlogTitle),
            new AdoDotNetParameter("@BlogAuthor", blog.BlogAuthor),
            new AdoDotNetParameter("@BlogContent", blog.BlogContent)
        );

        string message = result > 0 ? "Update Successful." : "Update Failed.";
        return Ok(message);
    }

    [HttpPatch("{id}")]
    public IActionResult PatchBlog(int id, BlogModel blog)
    {
        List<AdoDotNetParameter> lst = new List<AdoDotNetParameter>();
        string conditions = string.Empty;
        if (!string.IsNullOrEmpty(blog.BlogTitle))
        {
            conditions += " [BlogTitle] = @BlogTitle, ";
            lst.Add(new AdoDotNetParameter("@BlogTitle", blog.BlogTitle));
        }

        if (!string.IsNullOrEmpty(blog.BlogAuthor))
        {
            conditions += " [BlogAuthor] = @BlogAuthor, ";
            lst.Add(new AdoDotNetParameter("@BlogAuthor", blog.BlogAuthor));
        }

        if (!string.IsNullOrEmpty(blog.BlogContent))
        {
            conditions += " [BlogContent] = @BlogContent, ";
            lst.Add(new AdoDotNetParameter("@BlogContent", blog.BlogContent));
        }

        if (conditions.Length == 0)
        {
            var response = new { IsSuccess = false, Message = "No data found." };
            return NotFound(response);
        }

        lst.Add(new AdoDotNetParameter("@BlogId", id));

        conditions = conditions.Substring(0, conditions.Length - 2);
        string query = $@"UPDATE [dbo].[Tbl_Blog] SET {conditions} WHERE BlogId = @BlogId";

        int result = _adoDotNetService.Execute(query,
            lst.ToArray()
        );

        string message = result > 0 ? "Updating Successful." : "Updating Failed.";
        return Ok(message);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBlog(int id)
    {
        string query = @"DELETE FROM [dbo].[Tbl_Blog]
                           WHERE BlogId = @BlogId";

        int result = _adoDotNetService.Execute(query, new AdoDotNetParameter("@BlogId", id));
        string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
        return Ok(message);
    }
}