using System.Media;

namespace PacmanGame
{
    class Sound
    {
        static SoundPlayer player = new SoundPlayer();
        static SoundPlayer pelletPlayer = new SoundPlayer();



        /*
         * LoadPellet
         * 
         * Preloads the pellet sound to 
         * enabled the sound to be played
         * quickly over and over.
         * 
         */
        public static void LoadPellet()
        {
            pelletPlayer.SoundLocation = "Pellet.wav";
            pelletPlayer.Load();
        }



        /*
         * PlayPellet
         * 
         * Plays the pellet sound
         * 
         */

        public static void PlayPellet()
        {
            //pelletPlayer.Play();
            Console.Beep(1200, 30);
        }




        /*
         * PlayIntro
         * 
         * Plays the intro sound
         * 
         */
        public static void PlayIntro()
        {
            player.SoundLocation = "Intro.wav";
            player.Play();
        }



        /*
         * Hit
         * 
         * Plays the hit sound when Pacman 
         * has collided with a ghost.
         * 
         */
        public static void PlayHit()
        {
            player.SoundLocation = "Hit.wav";
            player.Play();
        }



        /*
         * PlayGameOver
         * 
         * Plays the game over sound
         * 
         */
        public static void PlayGameOver()
        {
            player.SoundLocation = "Gameover.wav";
            player.Play();
        }



        /*
         * LevelCompleted
         * 
         * Plays the level completed sound.
         * 
         */
        public static void LevelCompleted()
        {
            player.SoundLocation = "LevelCompleted.wav";
            player.Play();
        }
    }
}