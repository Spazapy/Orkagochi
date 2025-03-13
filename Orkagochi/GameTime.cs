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
        }

        public void StartGameLoop()
        {
            isRunning = true;
            gameThread = new Thread(GameLoop);
            gameThread.Start();
        }

        private void GameLoop()
        {
            while (isRunning)
            {
                // Aktualisiere die Zeit
                elapsedTime += TimeSpan.FromMinutes(10 * timeScale); // 10 Minuten pro Tick
                currentTime = startTime + elapsedTime;

                // Tag-Nacht prüfen
                int currentHour = currentTime.Hour;
                isDaytime = currentHour >= 6 && currentHour < 18;
                
                orka.UpdateState();

                // Wartezeit für den nächsten Tick (z. B. 5 Sekunden)
                Thread.Sleep(2000);
                

                // Beende die Schleife, wenn der Orka stirbt
                
            }
        }

        public void StopGameLoop()
        {
            isRunning = false;
        }
        public string GetCurrentGameStatus()
        {
            return $"Aktuelle Zeit: {currentTime:HH:mm}\n" +
                   $"Tag: {isDaytime}\n" +
                   ($"Name: {orka.Name}, Gesundheit: {orka.Health}, Energie: {orka.Energy}, Hunger: {orka.Hunger}, Durst: {orka.Thirst}, Glück: {orka.Happiness}, Stress-Level: {orka.StressLevel}");
        }
    }
}
