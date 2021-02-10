using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfMemoryBlazor.Models.LevelsConfiguration
{
    public class Level2Configuration : LevelModel
    {
        public Level2Configuration() : base()
        {
            NumberOfImages = 8;

            ColumnNumber = 4;

            ImageBaseUrl = "/Images/Levels/Level2/";

            FileExtension = ".jpg";

            ImageDefaultCardUrl = @"/Images/ImageDefaultCard/Question1.png";

            CardHeight = 180;

            CardWidth = 150;
        }
    }
}
