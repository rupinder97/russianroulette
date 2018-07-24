using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace russianroulette
{
    class Game
    {
        public int[] gunBarrel = { 0, 0, 0, 0, 0, 0 };
        int chances = 2;
        public void start()
        {
            Random rand = new Random();
            int val = rand.Next(0, 5);
            gunBarrel[val] = 1;
            Console.WriteLine("" + val);
            loadBarrel();
        }

        public void loadBarrel()
        {
            SoundPlayer player = new SoundPlayer("loading_and_spinning.wav");
            player.Play();
        }

        public string fire()
        {
            if (gunBarrel[0] == 1)
            {
                SoundPlayer player = new SoundPlayer("gun_shot.wav");
                player.Play();
                return "killed";
            }
            else
            {
                SoundPlayer player = new SoundPlayer("gun_cock.wav");
                player.Play();
                gunBarrel = gunBarrel.Skip(1).ToArray();
                return "safe";
            }
        }

        public string fireAway()
        {
            chances--;
            if (chances == 0)
            {
                if (gunBarrel[0] == 1)
                {
                    return "bullet gone";
                }
                else
                {
                    gunBarrel = gunBarrel.Skip(1).ToArray();
                    return "nothing";
                }
            }
            else
            {
                if (gunBarrel[0] == 1)
                {
                    return "You win";
                }
                else
                {
                    return "nothing";
                }
            }
        }
    }
}
