namespace KGA_OOPConsoleProject.Scenes
{
    public abstract class Scene
    {
        public Game game;
        public Information info;

        public ConsoleKey input;
        public Scene(Game game)
        {
            this.game = game;
            //Map map = new Map();


        }
        public abstract void Enter();
        public abstract void Render();
        public abstract void Input();
        public abstract void Update();
        public abstract void Interaction();
        public abstract void Exit();

    }
}
