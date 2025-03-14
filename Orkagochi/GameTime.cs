using System;
using System.Collections.Generic;
using System.Threading;

namespace Orkagochi
{
    public class GameTime
    {
        private DateTime currentTime;
        private DateTime startTime;
        private TimeSpan elapsedTime;
        private int dayCycle;

        // Time mechanics
        private float timeScale = 1.0f;
        private bool isDaytime;
        private int nightCycleDuration = 12;
        private int dayCycleDuration = 12;

        // Game loop Steuerung
        private bool isRunning;
        private bool isPaused;  
        private Orka orka;
        private Thread gameThread;

        public GameTime(Orka orka)
        {
            this.orka = orka;
            this.currentTime = DateTime.Now;
            this.startTime = DateTime.Now;
            this.elapsedTime = TimeSpan.Zero;
            this.dayCycle = 0;
            this.isRunning = false;
            this.isPaused = false; 
        }

        public void StartGameLoop()
        {
            isRunning = true;
            gameThread = new Thread(GameLoop);
            gameThread.Start();
            Thread inputThread = new Thread(CheckForPause);
            inputThread.Start();
        }

        private void GameLoop()
        {
            while (isRunning)
            {
                if (!isPaused) 
                {
                    elapsedTime += TimeSpan.FromMinutes(10 * timeScale); 
                    currentTime = startTime + elapsedTime;

                    // Tag-Nacht prüfen
                    int currentHour = currentTime.Hour;
                    isDaytime = currentHour >= 6 && currentHour < 18;
                    
                    orka.UpdateState();
                    
                }
                
                Thread.Sleep(2000); 
            }
        }

        public void StopGameLoop()
        {
            isRunning = false;
        }

        public void TogglePause()
        {
            isPaused = !isPaused;
        }

        private void CheckForPause()
        {
            while (isRunning)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.P)
                    {
                        TogglePause();
                    }
                }
                Thread.Sleep(100);
            }
        }
        
        public bool IsPaused()
        {
            return isPaused;
        }
        public bool IsRunning()
        {
            return isRunning;
        }


        public string GetCurrentGameStatus()
        {
            return $"Aktuelle Zeit: {currentTime:HH:mm}\n" +
                   $"Tag: {(isDaytime ? "Tag" : "Nacht")}\n" +
                   $"Name: {orka.Name}, Gesundheit: {orka.Health}, Energie: {orka.Energy}, Hunger: {orka.Hunger}, Durst: {orka.Thirst}, Glück: {orka.Happiness}, Stress-Level: {orka.StressLevel}\n";
            Thread.Sleep(10000);
            
        }
    }
}
