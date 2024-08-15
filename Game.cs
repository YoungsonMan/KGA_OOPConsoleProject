using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Objects;
using KGA_OOPConsoleProject.Scenes;
using KGA_OOPConsoleProject.Printers;


namespace KGA_OOPConsoleProject
{
    public class Game
    {
        private bool isRunnning;

        private Scene[] scenes;
        private Scene currentScene;
        private Scene previousScene;


        // 불러오기
        public Map map;
        public Player player;
        public Obstacle obstacle;
        public Printer printer;
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
            scenes[(int)SceneType.Information] = new Information(this);
            scenes[(int)SceneType.Stage1] = new Stage1(this);
            scenes[(int)SceneType.Stage2] = new Stage2(this);
            scenes[(int)SceneType.Stage3] = new Stage3(this);
            scenes[(int)SceneType.Stage4] = new Stage4(this);

            map = new Map();
            player = new Player();
            obstacle = new Obstacle();
            printer = new Printer();

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
