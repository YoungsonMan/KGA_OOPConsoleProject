using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Scenes;

namespace KGA_OOPConsoleProject
{
    public class Game
    {
        private bool isRunnning;

        private Scene[] scenes;
        private Scene currentScene;
        private Scene previousScene;

        private Map map;
        

        public void Run()
        {
            //Console.CursorVisible = false;
            Start();
            while (isRunnning)
            {
                Render();
                Input();
                Update();
            }
            End();
        }
        public void ChangeScene(SceneType sceneType)
        {
            currentScene.Exit();
            currentScene = scenes[(int)sceneType];
            currentScene.Enter();
        }
        public void ReturnScene()
        {
            currentScene.Exit();
            currentScene = previousScene;
            currentScene.Enter();
        }

        private void Start()
        {
            isRunnning = true;

            scenes = new Scene[(int)SceneType.Size];
            scenes[(int)SceneType.Title]= new TitleScene(this);

            currentScene = scenes[(int)SceneType.Title];
            currentScene.Enter();
            
            
        }
        private void Update()
        {
            currentScene.Update();
        }
        private void Render()
        {
            currentScene.Render();
        }
        private void Input()
        {
            currentScene.Input();
        }
        private void End()
        {
            currentScene.Exit();
        }
    }
}
