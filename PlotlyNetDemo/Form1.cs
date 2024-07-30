using System;
using System.Net;
using System.Windows.Forms;
using Microsoft.FSharp.Core;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Plotly.NET.CSharp;
using Plotly.NET.LayoutObjects;
using Plotly.NET.TraceObjects;
using static Plotly.NET.StyleParam.Range;

namespace PlotlyNetDemo
{
    public partial class Form1 : Form
    {
        private WebView2 webView2;

        public Form1()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // 使用 WebView2 控件显示 HTML 文件
            webView2 = new WebView2 { Dock = DockStyle.Fill };
            Controls.Add(webView2);
        }

        #region Chart3D
        public static double[] Linspace(double min, double max, int n)
        {
            if (n <= 2)
            {
                throw new ArgumentException("n needs to be larger than 2");
            }

            double[] result = new double[n];
            double step = (max - min) / (n - 1.0);

            for (int i = 0; i < n; i++)
            {
                result[i] = min + (step * i);
            }

            return result;
        }

        public static double F(double x, double y)
        {
            return -(5.0 * x / (x * x + y * y + 1.0));
        }

        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            surfaceRowCol.Rows = surfaceRowCol.Columns = 100;
            //int size = 100;
            //double[] x = Linspace(-2.0 * Math.PI, 2.0 * Math.PI, size);
            //double[] y = Linspace(-2.0 * Math.PI, 2.0 * Math.PI, size);

            //// Create the Z data
            //double[,] z = new double[size, size];
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        z[i, j] = F(x[j], y[i]);
            //    }
            //}

            ////            Plotly.NET.CSharp.Chart.Point<double, double, string>(
            ////    x: new double[] { 1, 2 },
            ////    y: new double[] { 5, 10 }
            ////)
            ////.WithTraceInfo("Hello from C#", ShowLegend: true)
            ////.WithXAxisStyle<double, double, string>(Title: Plotly.NET.Title.init("xAxis"))
            ////.WithYAxisStyle<double, double, string>(Title: Plotly.NET.Title.init("yAxis"))
            ////.Show();
            //// Create a surface chart
            //var dd = Enumerable.Range(0, z.GetLength(0))
            //          .Select(row => Enumerable.Range(0, z.GetLength(1))
            //                                   .Select(col => z[row, col]));
            //var surface = Plotly.NET.CSharp.Chart.Surface<double, double, double, string>(
            //    zData: dd, X: x, Y: y, Name: "test wr", true, 1, "wr"
            //);

            //// Save the chart to an HTML file
            //var htmlFilePath = Path.Combine(Path.GetTempPath(), "surface_chart.html");
            //surface.SaveHtml(htmlFilePath);

            //// 下载 Plotly.js 脚本
            //var plotlyScriptUrl = "https://cdn.plot.ly/plotly-2.27.1.min.js";
            //var plotlyScript = new WebClient().DownloadString(plotlyScriptUrl);

            //// 读取 HTML 文件内容并插入本地脚本
            //var htmlContent = File.ReadAllText(htmlFilePath).Replace(
            //    "<script src=\"https://cdn.plot.ly/plotly-2.27.1.min.js\"></script>",
            //    $"<script>{plotlyScript}</script>"
            //);

            //// 重新写入修改后的 HTML 文件
            //File.WriteAllText(htmlFilePath, htmlContent);

            //// 加载 HTML 文件到 WebView2 控件中
            //webView2.Source = new Uri(htmlFilePath);
        }
        #endregion


        #region Chart2D
        //private async void Form1_LoadAsync(object sender, EventArgs e)
        //{
        //    // 初始化 WebView2 控件
        //    webView2 = new WebView2
        //    {
        //        Dock = DockStyle.Fill
        //    };
        //    Controls.Add(webView2);

        //    // 确保 WebView2 初始化完成
        //    await webView2.EnsureCoreWebView2Async();

        //    // 设置 JavaScript 与 C# 之间的通信事件
        //    webView2.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;

        //    // 创建一个简单的 Plotly.NET 图表
        //    var points = new[] { 1, 2, 3, 4, 5 };
        //    var values = new[] { 2, 4, 1, 3, 5 };
        //    var chart = Chart2D.Chart.Line<int, int, int>(points, values);

        //    // 保存图表为 HTML 文件
        //    var htmlFilePath = Path.Combine(Path.GetTempPath(), "plotlyChart.html");
        //    chart.SaveHtml(htmlFilePath, FSharpOption<bool>.None);

        //    // 下载 Plotly.js 脚本
        //    var plotlyScriptUrl = "https://cdn.plot.ly/plotly-2.27.1.min.js";
        //    var plotlyScript = new WebClient().DownloadString(plotlyScriptUrl);

        //    // 读取 HTML 文件内容并插入本地脚本
        //    var htmlContent = File.ReadAllText(htmlFilePath).Replace(
        //        "<script src=\"https://cdn.plot.ly/plotly-2.27.1.min.js\"></script>",
        //        $"<script>{plotlyScript}</script>"
        //    );

        //    // 插入 JavaScript 代码用于处理交互和与 C# 代码通信
        //    var customScript = @"
        //        <script>
        //            document.addEventListener('DOMContentLoaded', function () {
        //                if (window.chrome && window.chrome.webview) {
        //                    var divs = document.getElementsByTagName('div');

        //                    for (var i = 0; i < divs.length; i++) {
        //                        var div = divs[i];

        //                        if (div.id) {
        //                            var plotlyChart = div;

        //                            if (plotlyChart) {
        //                                Plotly.Plots.get(plotlyChart).on('plotly_hover', function(data){
        //                                    var infotext = data.points.map(function(d){
        //                                        return ('x= '+d.x+', y= '+d.y.toPrecision(3));
        //                                    });

        //                                    window.chrome.webview.postMessage(JSON.stringify(infotext));
        //                                });

        //                                Plotly.Plots.get(plotlyChart).on('plotly_selected', function(data){
        //                                    var selectedPoints = data.points.map(function(d){
        //                                        return { x: d.x, y: d.y };
        //                                    });

        //                                    window.chrome.webview.postMessage(JSON.stringify(selectedPoints));
        //                                });
        //                            } else {
        //                                console.error('Plotly chart not found');
        //                            }
        //                        }
        //                    }
        //                } else {
        //                    console.error('WebView2 API is not available');
        //                }
        //            });
        //        </script>";
        //    htmlContent = htmlContent.Replace("</body>", customScript + "</body>");

        //    // 重新写入修改后的 HTML 文件
        //    File.WriteAllText(htmlFilePath, htmlContent);

        //    // 加载 HTML 文件到 WebView2 控件中
        //    webView2.Source = new Uri(htmlFilePath);
        //}
        #endregion


        private void CoreWebView2_WebMessageReceived(
            object sender,
            CoreWebView2WebMessageReceivedEventArgs e
        )
        {
            // 处理来自 JavaScript 的消息
            string message = e.TryGetWebMessageAsString();
            MessageBox.Show(message);

            // 在这里处理收到的消息，更新图表或显示其他信息
        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    var row = histRowCol.Rows;
                    var multiX = new string[2, 5]
                    {
                        { "A", "A", "A", "B", "B" },
                        { "AA", "AA", "AB", "BA", "BB" }
                    };
                    var multiY = new string[2, 5]
                    {
                        { "A", "A", "A", "B", "B" },
                        { "AA", "AA", "AB", "BA", "BB" }
                    };

                    // Create a Histogram2D chart
                    var surface = Plotly.NET.CSharp.Chart.Histogram2D<string, string, string>(
                        multiX.Cast<string>(),
                        multiY.Cast<string>()
                    );

                    // Save the chart to an HTML file
                    var htmlFilePath = Path.Combine(Path.GetTempPath(), "Histogram2D_chart.html");
                    surface.SaveHtml(htmlFilePath);

                    // 下载 Plotly.js 脚本
                    //var plotlyScriptUrl = "https://cdn.plot.ly/plotly-2.27.1.min.js";
                    //var plotlyScript = new WebClient().DownloadString(plotlyScriptUrl);
                    var plotlyScript = File.ReadAllText(
                        Path.Combine(
                            AppDomain.CurrentDomain.BaseDirectory,
                            @"..\..\..\js",
                            "plotly-2.27.1.min.js"
                        )
                    );

                    // 读取 HTML 文件内容并插入本地脚本
                    var htmlContent = File.ReadAllText(htmlFilePath)
                        .Replace(
                            "<script src=\"https://cdn.plot.ly/plotly-2.27.1.min.js\"></script>",
                            $"<script>{plotlyScript}</script>"
                        );

                    // 重新写入修改后的 HTML 文件
                    File.WriteAllText(htmlFilePath, htmlContent);
                    if (panel2.InvokeRequired)
                    {
                        panel2.Invoke(
                            new Action(() =>
                            { // 使用 WebView2 控件显示 HTML 文件
                                var webView2 = CreateWebView2();
                                panel2.Controls.Add(webView2);
                                // 加载 HTML 文件到 WebView2 控件中
                                webView2.Source = new Uri(htmlFilePath);
                            })
                        );
                    }
                    else
                    {
                        // 使用 WebView2 控件显示 HTML 文件
                        var webView2 = CreateWebView2();
                        panel2.Controls.Add(webView2);
                        // 加载 HTML 文件到 WebView2 控件中
                        webView2.Source = new Uri(htmlFilePath);
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private WebView2 CreateWebView2()
        {
            var webView2 = new WebView2
            {
                Dock = DockStyle.Fill,
                //Size = new Size(400, 300)
            };
            webView2.CoreWebView2InitializationCompleted += WebView2_CoreWebView2InitializationCompleted;
            return webView2;
        }

        private void WebView2_CoreWebView2InitializationCompleted(object? sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                var webView = sender as WebView2;
                if(null != webView)
                {
                    webView.CoreWebView2.WebMessageReceived += WebView2_WebMessageReceived;
                }
            }
        }

        private void WebView2_WebMessageReceived(object? sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
                // 处理来自 JavaScript 的消息
                string message = e.WebMessageAsJson;
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnHeatmap_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    var row = heatmapRowCol.Rows;
                    var column = heatmapRowCol.Columns;
                    int[,] zData = new int[row, column];
                    string[,] annotationText = new string[row, column];
                    var x = new string[row];
                    var y = new string[column];
                    var idx = 0;
                    for (var i = 0; i < row; i++)
                    {
                        x[i] = $"C{i + 1}";
                        for (var j = 0; j < column; j++)
                        {
                            zData[i, j] = ++idx;
                            annotationText[i, j] = $"{i + 1},{j + 1}";
                        }
                    }

                    for (var i = 0; i < column; i++)
                    {
                        y[i] = $"R{i + 1}";
                    }

                    // Create a surface chart
                    var dd = Enumerable
                        .Range(0, zData.GetLength(0))
                        .Select(row =>
                            Enumerable.Range(0, zData.GetLength(1)).Select(col => zData[row, col])
                        );

                    var aa = Enumerable
                        .Range(0, annotationText.GetLength(0))
                        .Select(row =>
                            Enumerable
                                .Range(0, annotationText.GetLength(1))
                                .Select(col => annotationText[row, col])
                        );

                    var surface = Plotly.NET.CSharp.Chart.Heatmap<int, string, string, string>(
                        zData: dd,
                        Name: "wr",
                        true,
                        1,
                        X: x,
                        1,
                        Y: y,
                        1,
                        ""
                    );

                    // Save the chart to an HTML file
                    var htmlFilePath = Path.Combine(
                        Path.GetTempPath(),
                        "AnnotatedHeatmap_Huge_chart.html"
                    );
                    surface.SaveHtml(htmlFilePath);

                    // 下载 Plotly.js 脚本
                    //var plotlyScriptUrl = "https://cdn.plot.ly/plotly-2.27.1.min.js";
                    //var plotlyScript = new WebClient().DownloadString(plotlyScriptUrl);
                    var plotlyScript = File.ReadAllText(
                        Path.Combine(
                            AppDomain.CurrentDomain.BaseDirectory,
                            @"..\..\..\js",
                            "plotly-2.27.1.min.js"
                        )
                    );

                    // 读取 HTML 文件内容并插入本地脚本
                    var htmlContent = File.ReadAllText(htmlFilePath)
                        .Replace(
                            "<script src=\"https://cdn.plot.ly/plotly-2.27.1.min.js\"></script>",
                            $"<script>{plotlyScript}</script>"
                        );

                    // 重新写入修改后的 HTML 文件
                    File.WriteAllText(htmlFilePath, htmlContent);

                    // 使用 WebView2 控件显示 HTML 文件
                    if (panel3.InvokeRequired)
                    {
                        panel3.Invoke(
                            new Action(() =>
                            {
                                ClearWebView2(panel3);
                                var webView2 = CreateWebView2();
                                panel3.Controls.Add(webView2);
                                // 加载 HTML 文件到 WebView2 控件中
                                webView2.Source = new Uri(htmlFilePath);
                            })
                        );
                    }
                    else
                    {
                        ClearWebView2(panel3);
                        var webView2 = CreateWebView2();
                        panel3.Controls.Add(webView2);
                        // 加载 HTML 文件到 WebView2 控件中
                        webView2.Source = new Uri(htmlFilePath);
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn3DSurface_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    int size = surfaceRowCol.Rows;
                    double[] x = Linspace(-2.0 * Math.PI, 2.0 * Math.PI, size);
                    double[] y = Linspace(-2.0 * Math.PI, 2.0 * Math.PI, size);

                    // Create the Z data
                    double[,] z = new double[size, size];
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            z[i, j] = F(x[j], y[i]);
                        }
                    }

                    // Create a surface chart
                    var dd = Enumerable
                        .Range(0, z.GetLength(0))
                        .Select(row =>
                            Enumerable.Range(0, z.GetLength(1)).Select(col => z[row, col])
                        );
                    var surface = Plotly.NET.CSharp.Chart.Surface<double, double, double, string>(
                        zData: dd,
                        X: x,
                        Y: y,
                        Name: "test wr",
                        true,
                        1,
                        "wr"
                    );

                    // Save the chart to an HTML file
                    var htmlFilePath = Path.Combine(Path.GetTempPath(), "surface_chart.html");
                    surface.SaveHtml(htmlFilePath);

                    // 下载 Plotly.js 脚本
                    //var plotlyScriptUrl = "https://cdn.plot.ly/plotly-2.27.1.min.js";
                    //var plotlyScript = new WebClient().DownloadString(plotlyScriptUrl);
                    var plotlyScript = File.ReadAllText(
                        Path.Combine(
                            AppDomain.CurrentDomain.BaseDirectory,
                            @"..\..\..\js",
                            "plotly-2.27.1.min.js"
                        )
                    );

                    // 读取 HTML 文件内容并插入本地脚本
                    var htmlContent = File.ReadAllText(htmlFilePath)
                        .Replace(
                            "<script src=\"https://cdn.plot.ly/plotly-2.27.1.min.js\"></script>",
                            $"<script>{plotlyScript}</script>"
                        );

                    // 重新写入修改后的 HTML 文件
                    File.WriteAllText(htmlFilePath, htmlContent);
                    if (panel1.InvokeRequired)
                    {
                        panel1.Invoke(
                            new Action(() =>
                            { // 使用 WebView2 控件显示 HTML 文件
                                var webView2 = CreateWebView2();
                                panel1.Controls.Add(webView2);
                                // 加载 HTML 文件到 WebView2 控件中
                                webView2.Source = new Uri(htmlFilePath);
                            })
                        );
                    }
                    else
                    {
                        // 使用 WebView2 控件显示 HTML 文件
                        var webView2 = CreateWebView2();
                        panel1.Controls.Add(webView2);
                        // 加载 HTML 文件到 WebView2 控件中
                        webView2.Source = new Uri(htmlFilePath);
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnStackedBar_Click(object sender, EventArgs e)
        {
            try
            {
                var values = new int[] { 20, 14, 23 };
                var keys = new string[] { "Product A", "Product B", "Product C" };

                var valuesNew = new int[] { 8, 21, 13 };

                var stackedBar1 = Plotly.NET.CSharp.Chart.StackedBar<int, string, string>(
                    values,
                    keys,
                    Name: "old"
                );

                var stackedBar2 = Plotly.NET.CSharp.Chart.StackedBar<int, string, string>(
                    values,
                    keys,
                    Name: "new"
                );

                var surface = Chart.Combine(new[] { stackedBar1, stackedBar2 });
                // Save the chart to an HTML file
                var htmlFilePath = Path.Combine(Path.GetTempPath(), "StackedBar_chart.html");
                surface.SaveHtml(htmlFilePath);

                // 下载 Plotly.js 脚本
                //var plotlyScriptUrl = "https://cdn.plot.ly/plotly-2.27.1.min.js";
                //var plotlyScript = new WebClient().DownloadString(plotlyScriptUrl);
                var plotlyScript = File.ReadAllText(
                    Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        @"..\..\..\js",
                        "plotly-2.27.1.min.js"
                    )
                );

                // 读取 HTML 文件内容并插入本地脚本
                var htmlContent = File.ReadAllText(htmlFilePath)
                    .Replace(
                        "<script src=\"https://cdn.plot.ly/plotly-2.27.1.min.js\"></script>",
                        $"<script>{plotlyScript}</script>"
                    );

                // 插入 JavaScript 代码用于处理交互和与 C# 代码通信
                var customScript =
                    @"
                <script>
                      var div = document.getElementsByClassName('js-plotly-plot')[0];
console.log(div);
        div.addEventListener(""click"", function (ev) {
            console.log(""我是div plot"");
            
            const data = {
                name: ""John Doe"",
                age: 30,
                message: ""Hello from JavaScript!""
            };
            window.chrome.webview.postMessage(data);

            ev.stopPropagation();//阻止冒泡
        }, false);
        div.addEventListener(""mouseover"", function (ev) {
            console.log(""鼠标移动了。。。"");
            ev.stopPropagation();//阻止冒泡
        }, false);
        // div.addEventListener('onmouseover',function (data) {
        //     // var point = data.points[0];
        //     var message = `You clicked on ${point.data.name} at (${point.x}, ${point.y})`;
        //     console.log(message);
        // });
        // div.on('onclick', function (data) {
        //     var point = data.points[0];
        //     var message = `You clicked on ${point.data.name} at (${point.x}, ${point.y})`;
        //     console.log(message);
        // });

    </script>";
                htmlContent = htmlContent.Replace("</body>", customScript + "</body>");

                // 重新写入修改后的 HTML 文件
                File.WriteAllText(htmlFilePath, htmlContent);
                // 使用 WebView2 控件显示 HTML 文件
                var webView2 = CreateWebView2();
                panel4.Controls.Add(webView2);
                // 加载 HTML 文件到 WebView2 控件中
                webView2.Source = new Uri(htmlFilePath);

                //Task.Factory.StartNew(() =>
                //{
                //    while (true)
                //    {
                //        Thread.Sleep(500);
                //        UpdateStackedBarData(webView2);
                //    }
                //});
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void UpdateStackedBarData(WebView2 webView2)
        {
            try
            {
                var length = 5;
                var values = new int[length];
                var valuesNew = new int[length];
                var keys = new string[length];
                var random = new Random();
                for (var i = 0; i < length; i++)
                {
                    values[i] = random.Next(1, 50);
                    valuesNew[i] = random.Next(1, 50);

                    keys[i] = $"Product_{i + 1}";
                }

                var stackedBar1 = Plotly.NET.CSharp.Chart.StackedBar<int, string, string>(
                    values,
                    keys,
                    Name: "old"
                );

                var stackedBar2 = Plotly.NET.CSharp.Chart.StackedBar<int, string, string>(
                    values,
                    keys,
                    Name: "new"
                );

                var surface = Chart.Combine(new[] { stackedBar1, stackedBar2 });
                // Save the chart to an HTML file
                var htmlFilePath = Path.Combine(Path.GetTempPath(), "StackedBar_chart.html");
                surface.SaveHtml(htmlFilePath);

                // 下载 Plotly.js 脚本
                //var plotlyScriptUrl = "https://cdn.plot.ly/plotly-2.27.1.min.js";
                //var plotlyScript = new WebClient().DownloadString(plotlyScriptUrl);
                var plotlyScript = File.ReadAllText(
                    Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        @"..\..\..\js",
                        "plotly-2.27.1.min.js"
                    )
                );

                // 读取 HTML 文件内容并插入本地脚本
                var htmlContent = File.ReadAllText(htmlFilePath)
                    .Replace(
                        "<script src=\"https://cdn.plot.ly/plotly-2.27.1.min.js\"></script>",
                        $"<script>{plotlyScript}</script>"
                    );

                // 重新写入修改后的 HTML 文件
                File.WriteAllText(htmlFilePath, htmlContent);
                if (webView2.InvokeRequired)
                {
                    webView2.Invoke(
                        new Action(() =>
                        {
                            webView2.Source = new Uri(htmlFilePath);
                            webView2.Reload();
                        })
                    );
                }
                else
                {
                    webView2.Source = new Uri(htmlFilePath);
                    webView2.Reload();
                }
            }
            // 加载 HTML 文件到 WebView2 控件中
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnHeatmapBigData_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    var row = 100;
                    var column = 100;
                    int[,] zData = new int[row, column];
                    string[,] annotationText = new string[row, column];
                    var x = new string[row];
                    var y = new string[column];
                    var idx = 0;
                    for (var i = 0; i < row; i++)
                    {
                        x[i] = $"C{i + 1}";
                        for (var j = 0; j < column; j++)
                        {
                            zData[i, j] = ++idx;
                            annotationText[i, j] = $"{i + 1},{j + 1}";
                        }
                    }

                    for (var i = 0; i < column; i++)
                    {
                        y[i] = $"R{i + 1}";
                    }

                    // Create a surface chart
                    var dd = Enumerable
                        .Range(0, zData.GetLength(0))
                        .Select(row =>
                            Enumerable.Range(0, zData.GetLength(1)).Select(col => zData[row, col])
                        );

                    var aa = Enumerable
                        .Range(0, annotationText.GetLength(0))
                        .Select(row =>
                            Enumerable
                                .Range(0, annotationText.GetLength(1))
                                .Select(col => annotationText[row, col])
                        );

                    var surface = Plotly.NET.CSharp.Chart.AnnotatedHeatmap<
                        int,
                        string,
                        string,
                        string
                    >(zData: dd, annotationText: aa, Name: "wr", true, 1, X: x, 1, Y: y);

                    // Save the chart to an HTML file
                    var htmlFilePath = Path.Combine(
                        Path.GetTempPath(),
                        "AnnotatedHeatmap_Huge_chart.html"
                    );
                    surface.SaveHtml(htmlFilePath);

                    // 下载 Plotly.js 脚本
                    //var plotlyScriptUrl = "https://cdn.plot.ly/plotly-2.27.1.min.js";
                    //var plotlyScript = new WebClient().DownloadString(plotlyScriptUrl);
                    var plotlyScript = File.ReadAllText(
                        Path.Combine(
                            AppDomain.CurrentDomain.BaseDirectory,
                            @"..\..\..\js",
                            "plotly-2.27.1.min.js"
                        )
                    );

                    // 读取 HTML 文件内容并插入本地脚本
                    var htmlContent = File.ReadAllText(htmlFilePath)
                        .Replace(
                            "<script src=\"https://cdn.plot.ly/plotly-2.27.1.min.js\"></script>",
                            $"<script>{plotlyScript}</script>"
                        );

                    // 重新写入修改后的 HTML 文件
                    File.WriteAllText(htmlFilePath, htmlContent);

                    // 使用 WebView2 控件显示 HTML 文件
                    if (panel3.InvokeRequired)
                    {
                        panel3.Invoke(
                            new Action(() =>
                            {
                                ClearWebView2(panel3);
                                var webView2 = CreateWebView2();
                                panel3.Controls.Add(webView2);
                                // 加载 HTML 文件到 WebView2 控件中
                                webView2.Source = new Uri(htmlFilePath);
                            })
                        );
                    }
                    else
                    {
                        ClearWebView2(panel3);
                        var webView2 = CreateWebView2();
                        panel3.Controls.Add(webView2);
                        // 加载 HTML 文件到 WebView2 控件中
                        webView2.Source = new Uri(htmlFilePath);
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ClearWebView2(Panel panel)
        {
            var existedWebView = panel.Controls.OfType<WebView2>();

            foreach (var item in existedWebView)
            {
                panel.Controls.Remove(item);
            }
        }
    }
}
