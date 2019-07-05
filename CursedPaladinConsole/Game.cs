using System;

namespace CursedPaladinConsole
{
    class Game
    {
        //Members

        private bool m_IsGameRun;
        private Render m_Render;

        //Funcrions
        public Game(int _width, int _height, string _gameName)
        {
            Console.Title = _gameName;
            m_Render = new Render(_width, _height);
            m_IsGameRun = true;
        }

        public void Run()
        {
            Initialize();
            PostInitialize();
            GameLoop();
            PreShutDown();
            ShutDown();
        }

        private void Initialize()
        {

        }

        private void PostInitialize()
        {

        }

        private void GameLoop()
        {
            while(m_IsGameRun)
            {
                Update();
                Draw();
            }
        }

        private void PreShutDown()
        {

        }

        private void ShutDown()
        {

        }

        private void Update()
        {
            Console.ReadKey(true);
        }

        private void Draw()
        {
            m_Render.Flush();
        }
    }
}
