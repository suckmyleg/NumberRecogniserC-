using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Recogniser._02logic
{
    internal class ImageLoader
    {
        private string imagesPath;
        private string filename;
        private bool loadedImage;
        private int[] imageVector;
        private int[][] image;

        private const Vector size;
        private const int totalPixels;

        public ImageLoader(string imagesPath, Vector size) { 
            this.imagesPath = imagesPath;
            this.size = size;

            this.totalPixels = this.size[0] * this.size[1];
        }
        public void loadImage(string filename) {
            this.loadImage = false;
            this.filename = filename;
            this.imageVector = new int[];

        }
        public getImage() { }
        public getImageVector() { }

    }
}
