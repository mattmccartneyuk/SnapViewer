using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Maths;
using System;

class Program
{
    private static IWindow window;
    private static GL Gl;

    static void Main()
    {
        var options = WindowOptions.Default;
        options.Size = new Vector2D<int>(800, 600); // initial size, doesn't really matter here
        options.Title = "Basic Silk.NET OpenGL Window";

        options.WindowState = WindowState.Maximized; 

        options.WindowBorder = WindowBorder.Resizable;

        window = Window.Create(options);

        window.Load += OnLoad;
        window.Render += OnRender;
        window.Update += OnUpdate;
        window.Closing += OnClose;

        window.Run();
    }

    private static void OnLoad()
    {
        Gl = GL.GetApi(window);
        Gl.ClearColor(0.39f, 0.58f, 0.93f, 1.0f);
    }

    private static void OnRender(double delta)
    {
        Gl.Clear(ClearBufferMask.ColorBufferBit);
    }

    private static void OnUpdate(double delta) { }
    private static void OnClose() { }
}