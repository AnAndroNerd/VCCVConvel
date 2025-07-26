using System;
using UtauPlugin;



namespace sample1
{
    class Program
    {

        static void Main(string[] args)
        {

            UtauPlugin.UtauPlugin utauPlugin = new UtauPlugin.UtauPlugin(args[0]);
            utauPlugin.Input();
            foreach (Note note in utauPlugin.note)
            {

                float baseConvel = 100 * (note.GetTempo() / 120);

                if (note.GetLength() >= 480)
                {
                    int Velocity = (int)(baseConvel + (50 - 100 * ((float)note.GetLength() / 960)));
                    note.SetVelocity(Velocity);
                }
                if (note.GetLength() < 480)
                {
                    int Velocity = (int)(baseConvel + (100 - (100 * ((float)note.GetLength() / 480))));
                    note.SetVelocity(Velocity);
                }
            }

                utauPlugin.Output();
            }
        }
    }
