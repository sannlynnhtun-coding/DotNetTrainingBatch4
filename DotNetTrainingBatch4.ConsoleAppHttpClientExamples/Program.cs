using DotNetTrainingBatch4.ConsoleAppHttpClientExamples;

Console.WriteLine("Hello, World!");

// Console App - Client (Frontend)
// ASP.NET Core Web API - Server  (Backend)

//HttpClient client = new HttpClient();
//var response = await client.GetAsync("https://localhost:7230/api/blog");
//if (response.IsSuccessStatusCode)
//{
//    string jsonStr = await response.Content.ReadAsStringAsync();
//    //Console.WriteLine(jsonStr);
//    List<BlogDto> lst = JsonConvert.DeserializeObject<List<BlogDto>>(jsonStr)!;
//    foreach (var blog in lst)
//    {
//        Console.WriteLine(JsonConvert.SerializeObject(blog));
//        Console.WriteLine($"Title => {blog.BlogTitle}");
//        Console.WriteLine($"Author => {blog.BlogAuthor}");
//        Console.WriteLine($"Content => {blog.BlogContent}");
//    }
//}

HttpClientExample httpClientExample = new HttpClientExample();
await httpClientExample.RunAsync();

Console.ReadLine();

// task 1 - 5
// task 2 - 5
// task 3 - 5
// task 4 - 5
// task 5 - 5

// 25

// task 1, task 2
// 5

// async
