namespace KGA_OOPConsoleProject.Scenes
{
    public abstract class Scene
    {
        public Launcher launcher;
        public Scene(Launcher launcher)
        {
            this.launcher = launcher;
            Map map = new Map(18,15);


        }
        public abstract void Start();
        public abstract void Render();
        public abstract void Input();
        public abstract void Update();
        public abstract void Interaction();
        public abstract void End();

    }
}
