using System.Collections.Generic;
using Bananasync.Core.Misc;

namespace Bananasync.Core.Models
{
    [Table("Games")]
    public class Game : BaseEntity
    {
        /// <summary>
        /// Title of the game e.g. "Minecraft"
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Path to the logo of the game
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Path to all savegame folders that should be synced
        /// </summary>
        public string DataPath { get; set; }
    }
}
