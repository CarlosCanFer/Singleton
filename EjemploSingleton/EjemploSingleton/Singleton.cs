﻿namespace EjemploSingleton
{
    class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        private static readonly object _lock = new object();

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public static void someBusinessLogic()
        {
            // ...
        }
    }
}
