using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypixelXPCalculator
{
    /**
     * Credit to: https://hypixel.net/members/nathanfranke.186753/ on his helpful forum post:
     *   https://hypixel.net/threads/guide-network-level-equations.3412241/
     *    | LEVEL to XP: f(x)=1250x²+8750x
     *    | XP to a LEVEL: sqrt(x/1250 + 12.25) - 3.5
     */

    /// <summary>
    /// The Hypixel Leveling System
    /// </summary>
    public class Level
    {
        public int CurrentLevel { get; private set; }

        /// <summary>
        /// Total EXP to Level
        /// </summary>
        public long EXP { get; private set; }

        public Level(int currentLevel, long exp)
        {
            this.CurrentLevel = currentLevel;
            this.EXP = exp;
        }

        public Level(long input, string type)
        {
            if (type == "level")
            {
                this.CurrentLevel = (int)input;
                this.EXP = (1250 * (input*input)) + (8750 * input);
            } else if (type == "exp")
            {
                this.EXP = input;
                this.CurrentLevel = (int) Math.Floor(Math.Sqrt((input / 1250) + 12.25) - 3.5);
            }
            else throw new ArgumentException("Invalid type", paramName:type);
        }
    }
}
