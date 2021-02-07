using GameOfMemoryBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfMemoryBlazor.Services
{
    public class ImagesGetUrl
    {
        public ImagesGetUrl()
        {

        }

        public List<string> GetRandonUrl(LevelModel levelModel)
        {
            var ImagesUrl = new List<string>();
            ImagesUrl = GetUrl(levelModel);
            Random index = new Random();
            var listRandom = new List<string>();
            var indice = new List<int>();

            while (indice.Count < ImagesUrl.Count)
            {
                int x = index.Next(0, ImagesUrl.Count);
                if (!indice.Contains(x))
                {
                    indice.Add(x);
                }
            }
            for (int i = 0; i < ImagesUrl.Count; i++)
            {
                listRandom.Add(ImagesUrl[indice[i]]);
            }
            return listRandom;
        }

        public string ImageDefaultGetUrl(LevelModel level)
        {
            return level.ImageDefaultCardUrl;
        }

        private List<string> GetUrl(LevelModel levelModel)
        {
            var ImagesUrl = new List<string>();
            for (int i = 0; i < (levelModel.NumberOfImages); i++)
            {
                ImagesUrl.Add(levelModel.ImageBaseUrl + $"image{i + 1}.png");                
                ImagesUrl.Add(levelModel.ImageBaseUrl + $"image{i + 1}.png");                
            }

            return ImagesUrl;
        }
    }    
}
