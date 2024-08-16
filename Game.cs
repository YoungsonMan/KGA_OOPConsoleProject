using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Objects;
using KGA_OOPConsoleProject.Scenes;
using KGA_OOPConsoleProject.Printers;
using KGA_OOPConsoleProject.Functions;


namespace KGA_OOPConsoleProject
{
    public class Game
    {
        private bool isRunnning;

        private Scene[] scenes;
        private Scene currentScene;
        private Scene previousScene;

        public ConsoleKey input;
        // 불러오기
        public Map map;
        public Player player;
        public Obstacle obstacle;
        public Printer printer;
        public Movement movement;
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
            previousScene = currentScene;
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

        // 방해물 부딪히면 리셋
        public void Reset(Obstacle obstacle)
        {
            previousScene = currentScene;
            currentScene.Exit();
            currentScene = scenes[(int)SceneType.Stage1];
            Stage1 stage1 = (Stage1)currentScene;
            currentScene.Enter();
        }

        // 문양 먹으면 다음단계
        public void NextStage(Shape shape)
        {
            previousScene = currentScene;
            currentScene.Exit();
            currentScene = scenes[(int)SceneType.Size+1];
            currentScene.Enter();


        }

        private void Start()
        {
            isRunnning = true;
            
            scenes = new Scene[(int)SceneType.Size];
            scenes[(int)SceneType.Title]= new TitleScene(this);           // 0
            scenes[(int)SceneType.Information] = new Information(this);   // 1
            scenes[(int)SceneType.Stage1] = new Stage1(this);             // 2
            scenes[(int)SceneType.Stage2] = new Stage2(this);             // 3
            scenes[(int)SceneType.Stage3] = new Stage3(this);             // 4
            scenes[(int)SceneType.Stage4] = new Stage4(this);             // 5


            map = new Map();
            player = new Player();
            obstacle = new Obstacle();
            printer = new Printer();
            movement = new Movement();


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
