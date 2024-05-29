using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DotNetTrainingBatch4.RestApiWithNLayer.Features.LatHtaukBayDin;

[Route("api/[controller]")]
[ApiController]
public class LatHtaukBayDinController : ControllerBase
{
    private async Task<LatHtaukBayDinModel> GetDataAsync()
    {
        string jsonStr = await System.IO.File.ReadAllTextAsync("data.json");
        var model = JsonConvert.DeserializeObject<LatHtaukBayDinModel>(jsonStr);
        return model!;
    }

    // api/LatHtaukBayDin/questions
    [HttpGet("questions")]
    public async Task<IActionResult> Questions()
    {
        var model = await GetDataAsync();
        return Ok(model.questions);
    }

    [HttpGet]
    public async Task<IActionResult> NumberList()
    {
        var model = await GetDataAsync();
        return Ok(model.numberList);
    }

    [HttpGet("{questionNo}/{no}")]
    public async Task<IActionResult> Answser(int questionNo, int no)
    {
        var model = await GetDataAsync();
        return Ok(model.answers.FirstOrDefault(x => x.questionNo == questionNo && x.answerNo == no));
    }
}
