using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameControl
{
    class Program
    {
        public static int state = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        private int GetState()
        {
            //check Game is open and if so:
            state = 0;
            //check SplashScreen is open and if so:
            state = 1;
            //check HighScores is open and if so:
            state = 2;
            //check Cameras are open and if so:
            state = 3;

            return state;
        }

        private void LaunchGame()
        {
            //Launch Game 
            state = 0;
        }


        private void SplasScreen()
        {
            //Launch SpashScreen 
            state = 1;
        }

        private void Camera()
        {
            //Open Camera VIEW
            state = 3;
            Form1.on = true;
        }
        
        void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            GetState();
            

            if (state == 2)
            {
                //Make highscore pop up
                //Sync scores
            }            
        }

    }
}
