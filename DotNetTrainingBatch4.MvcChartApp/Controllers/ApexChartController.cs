using DotNetTrainingBatch4.MvcChartApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch4.MvcChartApp.Controllers
{
    public class ApexChartController : Controller
    {
        public IActionResult SimplePieChart()
        {
            PieChartModel model = new PieChartModel();
            model.Lables = new List<string>() { "Team A", "Team B", "Team C", "Team D", "Team E" };
            model.Series = new List<int> { 44, 55, 13, 43, 22 };

            return View(model);
        }
        
        public IActionResult MixedLineColumnChart()
        {
            MixedLineColumnChartModel model = new MixedLineColumnChartModel();
            model.Title = "Traffic Sources";
            model.Series = new List<LineColumnChartSerie>();

            LineColumnChartSerie column = new LineColumnChartSerie
            {
                name = "Website Blog",
                type = "column",
                data = new List<int> { 440, 505, 414, 671, 227, 413, 201, 352, 752, 320, 257, 160 }
            };

            LineColumnChartSerie line = new LineColumnChartSerie
            {
                name = "Social Media",
                type = "line",
                data = new List<int> { 23, 42, 35, 27, 43, 22, 17, 31, 22, 22, 12, 16 }
            };

            model.Series.Add(column);
            model.Series.Add(line);

            model.Labels = new List<string>()
            {
                "01 June 2024",
                "02 June 2024",
                "03 June 2024",
                "04 June 2024",
                "05 June 2024",
                "06 June 2024",
                "07 June 2024",
                "08 June 2024",
                "09 June 2024",
                "10 June 2024",
                "11 June 2024",
                "12 June 2024"
            };

            return View(model);
        }

        public IActionResult GroupedBar()
        {
            GroupBarModel model = new GroupBarModel();

            GroupBar firstBar = new GroupBar();
            firstBar.data = new List<int> { 44, 55, 41, 64, 22, 43, 21 };

            GroupBar secBar = new GroupBar();
            secBar.data = new List<int> { 53, 32, 33, 52, 13, 44, 32 };

            model.BarGroup = new List<GroupBar> { firstBar, secBar };
            model.Categories = new List<int> { 2001, 2002, 2003, 2004, 2005, 2006, 2007 };

            return View(model);
        }

        public IActionResult MultiSeriesTimelineChart()
        {
            var responseList = new List<MultiSeriesTimelineChartModel>
            {
                new()
                {
                    Name = "Bob",
                    Timelines = new List<Timelines>
                    {
                        new()
                        {
                            Title = "Design",
                            DateTimes = new List<DateTime>
                            {
                                new(2019, 3, 5),
                                new DateTime(2019, 3, 8)
                            }
                        },
                        new()
                        {
                            Title = "Code",
                            DateTimes = new List<DateTime>
                            {
                                new(2019, 3, 8),
                                new DateTime(2019, 3, 11)
                            }
                        },
                        new()
                        {
                            Title = "Test",
                            DateTimes = new List<DateTime>
                            {
                                new(2019, 3, 11),
                                new DateTime(2019, 3, 16)
                            }
                        }
                    }
                },
                new()
                {
                    Name = "Joe",
                    Timelines = new List<Timelines>
                    {
                        new()
                        {
                            Title = "Design",
                            DateTimes = new List<DateTime>
                            {
                                new(2019, 3, 2),
                                new DateTime(2019, 3, 5)
                            }
                        },
                        new()
                        {
                            Title = "Code",
                            DateTimes = new List<DateTime>
                            {
                                new(2019, 3, 6),
                                new DateTime(2019, 3, 9)
                            }
                        },
                        new()
                        {
                            Title = "Test",
                            DateTimes = new List<DateTime>
                            {
                                new(2019, 3, 10),
                                new DateTime(2019, 3, 19)
                            }
                        }
                    }
                }
            };
            return View(responseList);
        }

        public IActionResult StesplineChart()
        {
            SteplineChartModel model = new SteplineChartModel();
            model.Data = new List<int>() { 34, 44, 54, 21, 12, 43, 33, 23, 66, 66, 58 };
            return View("SteplineChart", model);
        }

        public IActionResult BasicColumnChart()
        {
            ColumnChartModel model = new ColumnChartModel();
            model.Series = new List<Series>
            {
                new Series
                {
                    Name = "Net Profit",
                    Data = new List<int> { 44, 55, 57, 56, 61, 58, 63, 60, 66 }
                },
                new Series
                {
                    Name = "Revenue",
                    Data = new List<int> { 76, 85, 101, 98, 87, 105, 91, 114, 94 }
                },
                new Series
                {
                    Name = "Free Cash Flow",
                    Data = new List<int> { 35, 41, 36, 26, 45, 48, 52, 53, 41 }
                }
            };
            model.Categories = new List<string>
            {
                "Feb",
                "Mar",
                "Apr",
                "May",
                "Jun",
                "Jul",
                "Aug",
                "Sep",
                "Oct"
            };
            return View(model);
        }

        public IActionResult ColumnChartWithDataLables()
        {
            ColumnChartWithDataLablesModel model = new ColumnChartWithDataLablesModel();
            model.Categories = new List<string>()
            {
                "Jan",
                "Feb",
                "Mar",
                "Apr",
                "May",
                "Jun",
                "Jul",
                "Aug",
                "Sep",
                "Oct",
                "Nov",
                "Dec"
            };
            model.Inflation = new List<double>
            {
                2.3,
                3.1,
                4.0,
                10.1,
                4.0,
                3.6,
                3.2,
                2.3,
                1.4,
                0.8,
                0.5,
                0.2
            };
            return View(model);
        }

        public IActionResult BasicSlopeChart()
        {
            BasicSlopeChartModel model = new BasicSlopeChartModel
            {
                Categories = new List<string> { "Jan", "Feb" },
                Series = new List<SeriesData>
                {
                    new SeriesData
                    {
                        Name = "Blue",
                        Data = new List<DataPoint>
                        {
                            new DataPoint { Jan = "Jan", Feb = 43 },
                            new DataPoint { Jan = "Feb", Feb = 58 }
                        }
                    },
                    new SeriesData
                    {
                        Name = "Green",
                        Data = new List<DataPoint>
                        {
                            new DataPoint { Jan = "Jan", Feb = 33 },
                            new DataPoint { Jan = "Feb", Feb = 38 }
                        }
                    },
                    new SeriesData
                    {
                        Name = "Red",
                        Data = new List<DataPoint>
                        {
                            new DataPoint { Jan = "Jan", Feb = 55 },
                            new DataPoint { Jan = "Feb", Feb = 21 }
                        }
                    }
                }
            };

            return View(model);
        }

        public IActionResult LineColumnArea()
        {
            LineColumnAreaModel model = new LineColumnAreaModel
            {
                Series = new List<LineColumnAreaSeriesModel>()
                {
                    new LineColumnAreaSeriesModel()
                    {
                        Name = "Team A",
                        Type = "column",
                        Data = new List<int> { 23, 11, 22, 27, 13, 22, 37, 21, 44, 22, 30 }
                    },
                    new LineColumnAreaSeriesModel()
                    {
                        Name = "Team B",
                        Type = "area",
                        Data = new List<int> { 44, 55, 41, 67, 22, 43, 21, 41, 56, 27, 43 }
                    },
                    new LineColumnAreaSeriesModel()
                    {
                        Name = "Team C",
                        Type = "line",
                        Data = new List<int> { 30, 25, 36, 30, 45, 35, 64, 52, 59, 36, 39 }
                    }
                },
                Labels = new List<DateOnly>
                {
                    new DateOnly(2024, 7, 1),
                    new DateOnly(2024, 7, 2),
                    new DateOnly(2024, 7, 3),
                    new DateOnly(2024, 7, 4),
                    new DateOnly(2024, 7, 5),
                    new DateOnly(2024, 7, 6),
                    new DateOnly(2024, 7, 7),
                    new DateOnly(2024, 7, 8),
                    new DateOnly(2024, 7, 9),
                    new DateOnly(2024, 7, 10),
                    new DateOnly(2024, 7, 11)
                }
            };
            return View(model);
        }

        public IActionResult BasicLineChart()
        {
            BasicLineChartModel model = new BasicLineChartModel();
            model.ProductName = "Desktops";
            model.Datas = new List<int>() { 10, 41, 35, 51, 49, 62, 69, 91, 148 };
            model.Categories = new List<string>()
            {
                "Jan",
                "Feb",
                "Mar",
                "Apr",
                "May",
                "Jun",
                "Jul",
                "Aug",
                "Sep"
            };
            return View(model);
        }

        public IActionResult LineWithDataLabelsChart()
        {
            LineWithDataLabelsChartModel FirstDataModel = new LineWithDataLabelsChartModel();
            FirstDataModel.Name = "High - 2013";
            FirstDataModel.dataList = new List<int> { 28, 29, 33, 36, 32, 32, 33 };

            LineWithDataLabelsChartModel SecondDataModel = new LineWithDataLabelsChartModel();
            SecondDataModel.Name = "Low - 2013";
            SecondDataModel.dataList = new List<int> { 12, 11, 14, 18, 17, 13, 13 };

            LineWithDataLabelsChartRespondModel respondModel =
                new LineWithDataLabelsChartRespondModel();
            respondModel.FirstRecord = FirstDataModel;
            respondModel.SecondRecord = SecondDataModel;

            return View(respondModel);
        }

        public IActionResult PyramidChart()
        {
            PyramidChartModel model = new PyramidChartModel()
            {
                Series = new List<PyramidChartSeriesData>()
                {
                    new PyramidChartSeriesData()
                    {
                        name="",
                        data=new List<int>(){200, 330, 548, 740, 880, 990, 1100, 1380 },
                    }
                },
                Colors = new List<string>()
                {
                    "#F44F5E","#E55A89","#D863B1","#CA6CD8","#B57BED",
                    "#8D95EB","#62ACEA","#4BC3E6"
                },
                Categories=new List<string>()
                {
                    "Sweets", "Processed Foods", "Healthy Fats", "Meat", "Beans & Legumes", "Dairy", "Fruits & Vegetables", "Grains"
                }
            };

            return View(model);
        }
        
        public IActionResult BasicBarChart()
        {
            BasicBarChartModel model = new BasicBarChartModel();
            model.Labels = new List<string>()
            {
                "South Korea",
                "Canada",
                "United Kingdom",
                "Netherlands",
                "Italy",
                "France",
                "Japan",
                "United States",
                "China",
                "Germany"
            };
            model.Series = new List<int> { 400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380 };
            return View(model);
        }

        public IActionResult StackedBarChart()
        {
            var seriesData = new List<StackedBarSeries>
            {
                new StackedBarSeries { name = "Marine Sprite", data = new List<int> { 44, 55, 41, 37, 22, 43, 21 } },
                new StackedBarSeries { name = "Striking Calf", data = new List<int> { 53, 32, 33, 52, 13, 43, 32 } },
                new StackedBarSeries { name = "Tank Picture", data = new List<int> { 12, 17, 11, 9, 15, 11, 20 } },
                new StackedBarSeries { name = "Bucket Slope", data = new List<int> { 9, 7, 5, 8, 6, 9, 4 } },
                new StackedBarSeries { name = "Reborn Kid", data = new List<int> { 25, 12, 19, 32, 25, 24, 10 } }
            };

            var model = new StackedBarChartModel
            {
                Series = seriesData,
                Categories = new List<int> { 2008, 2009, 2010, 2011, 2012, 2013, 2014 }
            };
            return View(model);
        }

        public IActionResult StackedColumns()
        {
            StackedColumnModel model = new StackedColumnModel();
            model.Series = new List<Group>()
            {
                new Group
                {
                    Name = "Product A",
                    Data = new List<int> { 44, 55, 41, 67, 22, 43 }
                },
                new Group
                {
                    Name = "Product B",
                    Data = new List<int> { 13, 23, 20, 8, 13, 27 }
                },
                new Group
                {
                    Name = "Product C",
                    Data = new List<int> { 11, 17, 15, 15, 21, 14 }
                }
            };
            model.Categories = new List<string>() { "01/01/2011 GMT", "01/02/2011 GMT", "01/03/2011 GMT", "01/04/2011 GMT",
                    "01/05/2011 GMT", "01/06/2011 GMT"};

            return View(model);
        }

        public IActionResult MultipleYAxisChart()
        {
            MultipleYAxisChartModel model = new MultipleYAxisChartModel();
            model.Series = new List<ListOfSeries>()
            {
                new ListOfSeries
                {
                    name = "Income",
                    type = "column",
                    data = new List<double> { 1.4, 2, 2.5, 1.5, 2.5, 2.8, 3.8, 4.6 }
                },
                new ListOfSeries
                {
                    name = "Cashflow",
                    type = "column",
                    data = new List<double> { 1.1, 3, 3.1, 4, 4.1, 4.9, 6.5, 8.5 }
                },
                new ListOfSeries
                { 
                    name = "Revenue",
                    type = "line",
                    data = new List<double> { 20, 29, 37, 36, 44, 45, 50, 58 }
                }
            };
            
            model.Categories = new List<int> { 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016 };
            return View(model);
        }
        
        public IActionResult RadialBarCustomAngleCircleChart()
        {
            RadialBarCustomAngleCircleChartModel model = new RadialBarCustomAngleCircleChartModel();
            model.RadialBarSeries = new List<int> { 76, 67, 61, 90 };
            model.RadialBarLabels = new List<string> { "Vimeo", "Messenger", "Facebook", "LinkedIn" };
            model.RadialBarColors = new List<string> { "#1ab7ea", "#0084ff", "#39539E", "#0077B5" };

            return View(model);
        }
        public IActionResult MonochromePieChart()
        {
            MonochromePieChartModel model = new MonochromePieChartModel();
            model.Data = new List<int> { 25, 15, 44, 55, 41, 17 };
            model.Date = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            return View(model);
        }

        public IActionResult CustomDataLabelsBarChart()
        {
            CustomDataLabelsBarChartModel model = new CustomDataLabelsBarChartModel();
            model.Data = new List<int> { 400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380 };
            model.Colors = new List<string>
            {
                "#33b2df", "#546E7A", "#d4526e", "#13d8aa", "#A5978B", "#2b908f", "#f9a3a4", "#90ee7e",
            "#f48024", "#69d2e7"
            };
            model.Categories = new List<string>
            {
                "South Korea", "Canada", "United Kingdom", "Netherlands", "Italy", "France", "Japan",
            "United States", "China", "India"
            };
            return View(model);
        }

        public IActionResult FunnelChart()
        {
            FunnelChartModel model = new FunnelChartModel();
            model.Data = new List<int> { 1380, 1100, 990, 880, 740, 548, 330, 200 };
            model.Category = new List<string> {
                    "Sourced",
                    "Screened",
                    "Assessed",
                    "HR Interview",
                    "Technical",
                    "Verify",
                    "Offered",
                    "Hired"};
            return View(model);
        }
        
        public IActionResult BasicTimeLineChart()
        {
            BasicTimelineChartModel model = new BasicTimelineChartModel();
            model.Data = new List<TaskName>
            {
                new TaskName
                {
                    x = "Code",
                    y = new DateTime[] { new DateTime(2019, 3, 2), new DateTime(2019, 3, 4) }
                },
                new TaskName
                {
                    x = "Test",
                    y = new DateTime[] { new DateTime(2019, 3, 4), new DateTime(2019, 3, 8) }
                },
                new TaskName
                {
                    x = "Validation",
                    y = new DateTime[] { new DateTime(2019, 3, 8), new DateTime(2019, 3, 12) }
                },
                new TaskName
                {
                    x = "Deployment",
                    y = new DateTime[] { new DateTime(2019, 3, 12), new DateTime(2019, 3, 18) }
                }
            };
            return View(model);
        }

        public IActionResult BarWithMarker()
        {
            BarWithMarkerModel model = new BarWithMarkerModel
            {
                Name = "Actual",
                Expect = new List<ExpecxtList>
                {
                    new ExpecxtList
                    {
                        X = "2011",
                        Y = 12,
                        Goals = new List<GoalsList>
                        {
                            new GoalsList
                            {
                                Name = "Expected",
                                Value = 14,
                                StrokeWidth = 2,
                                StrokeDashArray = "2",
                                StrokeColor = "#775DD0"
                            }
                        }
                    },
                    new ExpecxtList
                    {
                        X = "2012",
                        Y = 44,
                        Goals = new List<GoalsList>
                        {
                            new GoalsList
                            {
                                Name = "Expected",
                                Value = 54,
                                StrokeWidth = 5,
                                StrokeHeight = 10,
                                StrokeColor = "#775DD0"
                            }
                        }
                    },
                    new ExpecxtList
                    {
                        X = "2013",
                        Y = 23,
                        Goals = new List<GoalsList>
                        {
                            new GoalsList
                            {
                                Name = "Expected",
                                Value = 13,
                                StrokeWidth = 5,
                                StrokeHeight = 10,
                                StrokeColor = "#775DD0"
                            }
                        }
                    },
                    new ExpecxtList
                    {
                        X = "2014",
                        Y = 34,
                        Goals = new List<GoalsList>
                        {
                            new GoalsList
                            {
                                Name = "Expected",
                                Value = 34,
                                StrokeWidth = 5,
                                StrokeHeight = 10,
                                StrokeColor = "#775DD0"
                            }
                        }
                    },
                    new ExpecxtList
                    {
                        X = "2015",
                        Y = 81,
                        Goals = new List<GoalsList>
                        {
                            new GoalsList
                            {
                                Name = "Expected",
                                Value = 66,
                                StrokeWidth = 5,
                                StrokeHeight = 10,
                                StrokeColor = "#775DD0"
                            }
                        }
                    },
                    new ExpecxtList
                    {
                        X = "2016",
                        Y = 67,
                        Goals = new List<GoalsList>
                        {
                            new GoalsList
                            {
                                Name = "Expected",
                                Value = 70,
                                StrokeWidth = 5,
                                StrokeHeight = 10,
                                StrokeColor = "#775DD0"
                            }
                        }
                    }
                }
            };
            return View(model);
        }
    }
}
