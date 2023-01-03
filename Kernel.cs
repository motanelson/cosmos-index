using System;
using System.Drawing;
using Cosmos.System.Graphics;
using Sys = Cosmos.System;
using Cosmos.Debug.Kernel;
using Point = Cosmos.System.Graphics.Point;
using Cosmos.System.Graphics.Fonts;
using System.Threading;

namespace Cosmos_Graphic_Subsytem
{
    
    public class control {
        public int x = 0;
        public int y = 0;
        public int w = 0;
        public int h = 0;
        public Boolean raised = false;
        public Pen Colors = new Pen(Color.Green);
        public String texts = "";
        
        public control()
        {

        }
        public void draws(Canvas c) {
            Pen p = new Pen(Color.Black);
            Point pp = new Point(x,y);
           
            
            c.DrawFilledRectangle(new Pen(Color.Green), pp, w, h);
            c.DrawString(texts, PCScreenFont.Default, p, pp) ;
            
            c.Display();

        }    
    
    }
    public class Kernel : Sys.Kernel
    {

        public Debugger debugger = new Debugger("System", "CGS");
        int maxy=200;
        int maxx = 320;
        int xxxx = 0;
        int yyyy = 0;
        Boolean c1 = false;
        private Canvas canvas;
        private Bitmap bitmap;
        
        Boolean Mmouseini = false;
        int cursorSize = 10;
        Color colorCursor= Color.White;
        Color desktopColor=Color.Green;







        protected override void BeforeRun()
        {




            Console.WriteLine("Cosmos booted successfully. Let's go in Graphic Mode");

            Mode start = new Mode(maxx, maxy, ColorDepth.ColorDepth32);




            canvas = FullScreenCanvas.GetFullScreenCanvas(start);



            canvas.Clear(Color.Green);

        }
        protected override void Run()
        {
            Pen pen = new Pen(Color.DarkGreen);
            int n = 0;
            int x = 0;
            int y = 0;
            int xx = maxx - 1;
            int yy = maxy - 1;
            int nn = 0;
           
            Boolean c1 = false;
            int c = new Pen(Color.Black).ValueARGB;
            try
            {
                control rets = new control();
                rets.x = 10;
                rets.y = 10;
                rets.w = 170;
                rets.h = 30;
                
               


                while (1 == 1)
                {

                    DateTime dt = DateTime.Now;

                    Console.SetCursorPosition(1, 10);
                    rets.texts = dt.ToString() + "                         ";
                    rets.draws(canvas);
                    Thread.Sleep(1000);


                }
            }
            catch (Exception e)
            {

            }
        }
   }
}