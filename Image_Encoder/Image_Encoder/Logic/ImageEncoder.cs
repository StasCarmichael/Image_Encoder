using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;


using myType = System.Int16;


namespace Project.Logic
{
    class ImageEncoder
    {
        private readonly myType startX;
        private readonly myType startY;

        private readonly myType shiftX;
        private readonly myType shiftY;


        private Bitmap inputImage;
        private Bitmap encoderImage;
        private Bitmap decoderImage;


        private string decoderMessage;


        public ImageEncoder(Bitmap bitmap, myType X, myType Y, myType shiftX, myType shiftY)
        {
            inputImage = bitmap;

            startX = X;
            startY = Y;

            this.shiftX = shiftX;
            this.shiftY = shiftY;
        }

        public void UpdateImage(Bitmap bitmap)
        {
            try
            {
                inputImage = (Bitmap)bitmap.Clone();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool EncryptImage(string inputString, byte key, ref int lenght)
        {
            encoderImage = new Bitmap(inputImage);

            var byteArray = Encoding.UTF8.GetBytes(inputString);
            Color color;

            int counter = 0;
            for (int y = startY; y < encoderImage.Height; y += shiftY)
            {
                for (int x = startX; x < encoderImage.Width; x += shiftX)
                {
                    if (inputString.Length <= counter) { break; }

                    byte r = byteArray[counter];
                    byte coderR = (byte)(r ^ key);

                    counter++;
                    lenght++;
                    if (inputString.Length <= counter) { color = Color.FromArgb(alpha: byte.MaxValue, red: coderR, green: byte.MaxValue, blue: byte.MaxValue); break; }


                    byte g = byteArray[counter];
                    byte coderG = (byte)(g ^ key);

                    counter++;
                    lenght++;
                    if (inputString.Length <= counter) { color = Color.FromArgb(alpha: byte.MaxValue, red: coderR, green: coderG, blue: byte.MaxValue); break; }

                    byte b = byteArray[counter];
                    byte coderB = (byte)(b ^ key);

                    color = Color.FromArgb(alpha: byte.MaxValue, red: coderR, green: coderG, blue: coderB);

                    encoderImage.SetPixel(x, y, color);

                    counter++;
                    lenght++;
                }
            }

            if (counter < inputString.Length) { return false; }

            return true;
        }
        public Bitmap GetEncryptImage() { return encoderImage; }


        public bool DecoderImage(byte key)
        {
            decoderImage = new Bitmap(inputImage);

            Color color;

            List<byte> byteList = new List<byte>();

            int counter = 0;
            for (int y = startY; y < decoderImage.Height; y += shiftY)
            {
                for (int x = startX; x < decoderImage.Width; x += shiftX)
                {
                    color = decoderImage.GetPixel(x, y);

                    byte encryptR = color.R;
                    byte decoderR = (byte)(encryptR ^ key);
                    counter++;

                    byte encryptG = color.G;
                    byte decoderG = (byte)(encryptG ^ key);
                    counter++;

                    byte encryptB = color.B;
                    byte decoderB = (byte)(encryptB ^ key);
                    counter++;

                    byteList.Add(decoderR);
                    byteList.Add(decoderG);
                    byteList.Add(decoderB);
                }
            }

            decoderMessage = Encoding.UTF8.GetString(byteList.ToArray());

            return true;
        }
        public string GetDecoderMessage() { return decoderMessage; }
    }
}
