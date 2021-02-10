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

            ColumnNumber = 4;

            ImageBaseUrl = "/Images/Levels/Level1/";

            FileExtension = ".png";            

            ImageDefaultCardUrl = @"/Images/ImageDefaultCard/Question.png";

            CardHeight = 200;

            CardWidth = 150;

        }
    }
}
