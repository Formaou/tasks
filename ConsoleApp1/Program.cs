using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int imagesInRow = 3;
            int imagesInAlbum = 52;

            int fullRowsWithImages = imagesInAlbum / imagesInRow;
            int overMeasure = imagesInAlbum % imagesInRow;

            Console.WriteLine("В вашем альбоме {0} рядов, {1} картинок сверх меры", fullRowsWithImages, overMeasure);
        }
    }
}
