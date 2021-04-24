using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace IWannaBeKolya
{
    public partial class Form1 : Form
    {
        private Thread thread;
        private bool stopApplication;
        private Panel pausePanel;
        private Button button1;
        private Button button2;

        public Form1()
        {
            //var panel = new Panel
            //{
            //    Location = new Point(ClientSize.Width / 2, ClientSize.Height / 2),
            //    Size = new Size(100, 100),
                
            //};


            //var playButton = new Button
            //{
            //    Location = new Point(Height / 2, Width / 2),
            //    Size = new Size(50, 30),
            //    Text = "Play"
            //};
            //playButton.Click += (send, args) => panel.Visible = false;
            //playButton.Parent = panel;


            //var exitButton = new Button
            //{
            //    Location = new Point(100, 100),
            //    Size = new Size(50, 30),
            //    Text = "Exit"
            //};
            //exitButton.Click += (sender, args) => Close();
            //exitButton.Parent = panel;


            //Controls.Add(exitButton);
            //Controls.Add(panel);
            //Controls.Add(playButton);

            //pausePanel = panel;
            //button1 = exitButton;
            //button2 = playButton;

            thread = new Thread(() =>
            {
                var timer = new Stopwatch();
                timer.Start();
                while (!stopApplication)
                {
                    if (timer.ElapsedMilliseconds >= 16)
                        Invalidate();
                }
            });
            thread.Start();


            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Game.Update();
            //pausePanel.Refresh();
            //button1.Refresh();
            //button2.Refresh();
            Renderer.Render(e.Graphics);
        }

        

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    Invalidate();
        //}

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            stopApplication = true;
            thread.Join();
        }

        
    }
}
