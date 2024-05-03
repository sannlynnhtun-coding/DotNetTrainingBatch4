namespace DotNetTrainingBatch4.RestApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogAdoDotNetController : ControllerBase
{
    [HttpGet]
    public IActionResult GetBlogs()
    {
        string query = "select * from Tbl_Blog";

        SqlConnection connection = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
        connection.Open();

        SqlCommand cmd = new SqlCommand(query, connection);
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sqlDataAdapter.Fill(dt);

        connection.Close();

        //List<BlogModel> lst = new List<BlogModel>();
        //foreach (DataRow dr in dt.Rows)
        //{
        //    //BlogModel blog = new BlogModel();
        //    //blog.BlogId = Convert.ToInt32(dr["BlogId"]);
        //    //blog.BlogTitle = Convert.ToString(dr["BlogTitle"]);
        //    //blog.BlogAuthor = Convert.ToString(dr["BlogAuthor"]);
        //    //blog.BlogContent = Convert.ToString(dr["BlogContent"]);

        //    BlogModel blog = new BlogModel
        //    {
        //        BlogId = Convert.ToInt32(dr["BlogId"]),
        //        BlogTitle = Convert.ToString(dr["BlogTitle"]),
        //        BlogAuthor = Convert.ToString(dr["BlogAuthor"]),
        //        BlogContent = Convert.ToString(dr["BlogContent"])
        //    };
        //    lst.Add(blog);
        //}

        List<BlogModel> lst = dt.AsEnumerable().Select(dr => new BlogModel
        {
            BlogId = Convert.ToInt32(dr["BlogId"]),
            BlogTitle = Convert.ToString(dr["BlogTitle"]),
            BlogAuthor = Convert.ToString(dr["BlogAuthor"]),
            BlogContent = Convert.ToString(dr["BlogContent"])
        }).ToList();

        return Ok(lst);
    }

    [HttpGet("{id}")]
    public IActionResult GetBlog(int id)
    {
        string query = "select * from Tbl_Blog where BlogId = @BlogId";

        SqlConnection connection = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
        connection.Open();

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@BlogId", id);
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sqlDataAdapter.Fill(dt);

        connection.Close();

        if (dt.Rows.Count == 0)
        {
            return NotFound("No data found.");
        }

        DataRow dr = dt.Rows[0];
        var item = new BlogModel
        {
            BlogId = Convert.ToInt32(dr["BlogId"]),
            BlogTitle = Convert.ToString(dr["BlogTitle"]),
            BlogAuthor = Convert.ToString(dr["BlogAuthor"]),
            BlogContent = Convert.ToString(dr["BlogContent"])
        };

        return Ok(dt);
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

        SqlConnection connection = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
        connection.Open();

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@BlogTitle", blog.BlogTitle);
        cmd.Parameters.AddWithValue("@BlogAuthor", blog.BlogAuthor);
        cmd.Parameters.AddWithValue("@BlogContent", blog.BlogContent);
        int result = cmd.ExecuteNonQuery();

        connection.Close();

        string message = result > 0 ? "Saving Successful." : "Saving Failed.";
        //return StatusCode(500, message);
        return Ok(message);
    }

    [HttpPut("{id}")]
    public IActionResult PutBlog(int id, BlogModel blog)
    {
        string getQuery = "SELECT COUNT(*) FROM tbl_blogs WHERE BlogId = @BlogId";
        SqlConnection connection = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
        connection.Open();
        SqlCommand checkCmd = new SqlCommand(getQuery, connection);
        checkCmd.Parameters.AddWithValue("@BlogId", id);
        var count = (int)checkCmd.ExecuteScalar();
        if (count == 0) return NotFound();

        string updateQuery = @"UPDATE [dbo].[Tbl_Blogs]
                           SET [BlogTitle] = @BlogTitle,
                               [BlogAuthor] = @BlogAuthor,
                               [BlogContent] = @BlogContent
                           WHERE BlogId = @BlogId";

        SqlCommand cmd = new SqlCommand(updateQuery, connection);
        cmd.Parameters.AddWithValue("@BlogId", id);
        cmd.Parameters.AddWithValue("@BlogTitle", blog.BlogTitle);
        cmd.Parameters.AddWithValue("@BlogAuthor", blog.BlogAuthor);
        cmd.Parameters.AddWithValue("@BlogContent", blog.BlogContent);

        int result = cmd.ExecuteNonQuery();
        connection.Close();
        string message = result > 0 ? "Updating Successful." : "Updating Failed.";
        return Ok(message);
    }

    [HttpPatch("{id}")]
    public IActionResult PatchBlog(int id, BlogModel blog)
    {
        SqlConnection connection = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
        connection.Open();
        string query = "select * from Tbl_Blog where BlogId = @BlogId";
        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@BlogId", id);
        var count = (int)cmd.ExecuteScalar();
        if (count == 0) return NotFound();
        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        dataAdapter.Fill(dt);
        List<BlogModel> lst = new List<BlogModel>();
        if (dt.Rows.Count == 0)
        {
            var response = new { IsSuccess = false, Message = "No data found." };
            return NotFound(response);
        }

        DataRow row = dt.Rows[0];

        BlogModel item = new BlogModel
        {
            BlogId = Convert.ToInt32(row["BlogId"]),
            BlogTitle = Convert.ToString(row["BlogTitle"]),
            BlogAuthor = Convert.ToString(row["BlogAuthor"]),
            BlogContent = Convert.ToString(row["BlogContent"]),
        };
        lst.Add(item);
        string conditions = "";
        List<SqlParameter> parameters = new List<SqlParameter>();

        #region Patch Validation Conditions

        if (!string.IsNullOrEmpty(blog.BlogTitle))
        {
            conditions += " [BlogTitle] = @BlogTitle, ";
            parameters.Add(new SqlParameter("@BlogTitle", SqlDbType.NVarChar) { Value = blog.BlogTitle });
            item.BlogTitle = blog.BlogTitle;
        }

        if (!string.IsNullOrEmpty(blog.BlogAuthor))
        {
            conditions += " [BlogAuthor] = @BlogAuthor, ";
            parameters.Add(new SqlParameter("@BlogAuthor", SqlDbType.NVarChar) { Value = blog.BlogAuthor });
            item.BlogAuthor = blog.BlogAuthor;
        }

        if (!string.IsNullOrEmpty(blog.BlogContent))
        {
            conditions += " [BlogContent] = @BlogContent, ";
            parameters.Add(new SqlParameter("@BlogContent", SqlDbType.NVarChar) { Value = blog.BlogContent });
            item.BlogContent = blog.BlogContent;
        }

        if (conditions.Length == 0)
        {
            var response = new { IsSuccess = false, Message = "No data found." };
            return NotFound(response);
        }

        #endregion

        conditions = conditions.TrimEnd(',', ' ');
        query = $@"UPDATE [dbo].[Tbl_Blog] SET {conditions} WHERE BlogId = @BlogId";

        using SqlCommand cmd2 = new SqlCommand(query, connection);
        cmd2.Parameters.AddWithValue("@BlogId", id);
        cmd2.Parameters.AddRange(parameters.ToArray());

        int result = cmd2.ExecuteNonQuery();
        connection.Close();
        string message = result > 0 ? "Patch Updating Successful." : "Patch Updating Failed.";
        return Ok(message);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBlog(int id)
    {
        string query = @"DELETE FROM [dbo].[Tbl_Blog]
                           WHERE BlogId = @BlogId";
        SqlConnection connection = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
        connection.Open();

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@BlogId", id);

        int result = cmd.ExecuteNonQuery();
        connection.Close();

        string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
        return Ok(message);
    }
}