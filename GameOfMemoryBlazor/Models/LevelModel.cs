using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfMemoryBlazor.Models
{
    public class LevelModel
    {
        public int NumberOfImages { get; set; } //Número de imagens do level
        public int ColumnNumber { get; set; } //Números de Colunas a ser exibido
        public string ImageBaseUrl { get; set; } // Url da pasta da imagem       
        public string FileExtension { get; set; }
        public string ImageDefaultCardUrl { get; set; }  // imagem padrão do verso do card

        public int CardHeight { get; set; }
        public int CardWidth { get; set; }

        public LevelModel()
        {
        }
    }
}
