using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Recogniser
{
    internal class ImageLoader
    {
        private string imagesPath;
        private string filename;
        private bool loadedImage;
        private int[] imageVector;
        private int[][] image;

        private int[] size = {25, 25};
        private const int totalPixels = 25*25;

        public ImageLoader(string imagesPath, int[] size) { 
            this.imagesPath = imagesPath;
            /*this.size = size;

            this.totalPixels = this.size[0] * this.size[1];*/
        }
        public void loadImage(string filename) {
            this.loadedImage = false;
            this.filename = filename;
            this.imageVector = new int[2];

        }
        public void getImage() { }
        public void getImageVector() { }

    }
}
