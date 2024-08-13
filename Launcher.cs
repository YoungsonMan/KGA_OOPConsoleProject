using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Scenes;

namespace KGA_OOPConsoleProject
{
    public class Launcher
    {
        private bool isRunnning;

        private Scene[] scenes;
        private Scene currentScene;
        private Scene previousScene;

        
        

        public void Run()
        {
            Console.CursorVisible = false;
            Start();
            while (isRunnning)
            {
                Render();
                Input();
                Update();
            }
            End();
        }
        private void Start()
        {
            
        }
        private void Update()
        {

        }
        private void Render()
        {

        }
        private void Input()
        {

        }
        private void End()
        {

        }
    }
}
