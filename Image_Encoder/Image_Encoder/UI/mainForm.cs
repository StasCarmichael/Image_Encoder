using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Project.Info;
using Project.Logic;

using myType = System.Int16;


namespace Project
{
    public partial class mainForm : Form
    {
        private Bitmap selectedImage;

        private ImageEncoder imageEncoder;
        private ImageEncoder imageDecoder;


        public mainForm()
        {
            InitializeComponent();
        }



        private void buttonChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image |*.png; *.jpg; *.JPEG;",
                RestoreDirectory = true,
            };


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImage = new Bitmap(openFileDialog.FileName);

                buttonEncrypt.Visible = true;
                buttonDecoder.Visible = true;

                MessageBox.Show(Info.Message.DOWNLOAD_IMAGE);
            }
        }


        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string message = richTextBoxMessage.Text;
                byte key = (byte)int.Parse(textBoxKey.Text);

                myType startX = short.Parse(textBoxStartX.Text);
                myType startY = short.Parse(textBoxStartY.Text);

                myType shiftX = short.Parse(textBoxShiftX.Text);
                myType shiftY = short.Parse(textBoxShiftX.Text);

                imageEncoder = new ImageEncoder(new Bitmap(selectedImage), startX, startY, shiftX, shiftY);

                int lenght = 0;
                imageEncoder.EncryptImage(message, key, ref lenght);

                labelLenght.Text = lenght.ToString();
                buttonEncryptDownload.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonEncryptDownload_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            string downloadName = $"Encrypt_Image_{date.Year}_{date.Month}_{date.Day}_{date.Hour}_{date.Minute}_{date.Second}" + ".png";

            imageEncoder.GetEncryptImage().Save(downloadName);

            MessageBox.Show(Info.Message.DOWNLOAD_ENCODER_IMAGE);
        }


        private void buttonDecoder_Click(object sender, EventArgs e)
        {
            try
            {
                byte key = (byte)int.Parse(textBoxKey.Text);

                myType startX = short.Parse(textBoxStartX.Text);
                myType startY = short.Parse(textBoxStartY.Text);

                myType shiftX = short.Parse(textBoxShiftX.Text);
                myType shiftY = short.Parse(textBoxShiftX.Text);

                imageDecoder = new ImageEncoder(new Bitmap(selectedImage), startX, startY, shiftX, shiftY);

                imageDecoder.DecoderImage(key);

                richTextBoxDecoder.Text = imageDecoder.GetDecoderMessage();

                buttonMessageDownload.Visible = true;
                richTextBoxDecoder.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonMessageDownload_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            string path = $"Decoder_File_{date.Year}_{date.Month}_{date.Day}_{date.Hour}_{date.Minute}_{date.Second}" + ".txt";

            File.WriteAllText(path, imageDecoder.GetDecoderMessage(), Encoding.UTF8);

            MessageBox.Show(Info.Message.DOWNLOAD_DECODER_IMAGE);
        }

        private void buttonExit_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}
