using System;
using System.Media;

namespace Game
{
    /// <summary>
    /// Sound effects engine
    /// </summary>
    class SoundEngine
    {
        /// <summary>
        /// Plays the intro sound in loop
        /// </summary>
        public static void PlayIntroSound(bool play)
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            try
            {
                soundPlayer = new SoundPlayer("../../Sounds/beginning.wav");
            }
            catch (Exception e)
            {
                Logger.Log(e);
                PrintEngine.ClearScreen();
                Console.WriteLine("Failed to load media file!");
                Environment.Exit(0);
            }
            if (play == true)
            {
                soundPlayer.PlayLooping();
            }
            else
            {
                soundPlayer.Stop();
                soundPlayer.Dispose();
            }
        }
        /// <summary>
        /// Plays the sound for dying
        /// </summary>
        /// 
        public static void PlayDeathSound()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            try
            {
                soundPlayer = new SoundPlayer("../../Sounds/death.wav");
                soundPlayer.PlaySync();
                soundPlayer.Dispose();

            }
            catch (Exception e)
            {
                Logger.Log(e);
                PrintEngine.ClearScreen();
                Console.WriteLine("Failed to load media file!");
                Environment.Exit(0);
            }
            
        }
        /// <summary>
        /// Plays the sound for eating a dot
        /// 
        /// Quite possible that no sound is played when a dot is eaten
        /// </summary>
        public static void PlayEatDotSound()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            try
            {
                soundPlayer = new SoundPlayer("../../Sounds/chomp.wav");

                soundPlayer.Play();
                soundPlayer.Dispose();
            }
            catch (Exception e)
            {
                Logger.Log(e);
                PrintEngine.ClearScreen();
                Console.WriteLine("Failed to load media file!");
                Environment.Exit(0);
            }
        }

        /// <summary>
        ///  Plays the sound for eating a Power Pellet
        /// </summary>
        public static void PlayEatPowerPelletSound()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            try
            {
                soundPlayer = new SoundPlayer("../../Sounds/powerPellet.wav");

                soundPlayer.PlaySync();
                soundPlayer.Dispose();
                                
            }
            catch (Exception e)
            {
                Logger.Log(e);
                PrintEngine.ClearScreen();
                Console.WriteLine("Failed to load media file!");
                Environment.Exit(0);
            }
        }
    }
}
