using System;
namespace Udemy_dotNet
{
    class Box
    {
        // member variables
        private int lenght = 3;
        private int height;
        //public int width;
        private int volume;
        public int Width { get; set; }

        public int FrontSurface
        {
            get
            {
                return height + lenght;
            }
        }


        public int Volume
        {
            get
            {
                return this.lenght * this.height * this.Width;
            }
        }

        /*
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        */

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
                
            }
        }

        public Box(int lenght, int height, int width)
        {
            this.lenght = lenght;
            this.height = height;
            Width = width;


        }


        public void SetLenght(int lenght)
        {
            if (lenght < 0)
            {
                throw new Exception("Lenght sould be higher than 0");
            }
            else
            {
                this.lenght = lenght; 
            }

        }

        public int GetLenght()
        {
            return this.lenght;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Lenght is {0} and height is {1} and width is {2} so the volume is {3}",
                lenght, height, Width, volume = lenght * height * Width) ;
        }

    }
}
