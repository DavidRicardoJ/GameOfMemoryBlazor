using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfMemoryBlazor.Models.LevelsConfiguration
{
    public class Level1Configuration : LevelModel
    {
        public Level1Configuration() : base()
        {
            NumberOfImages = 6;

            ColumnNumber = 3;

            ImageBaseUrl = "/Images/Levels/Level1/";

            DisplayTime = 5; // segundos

            ImageDefaultCardUrl = @"/Images/ImageDefaultCard/Question.png";
        }
    }
}
