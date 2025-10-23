using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace ComputerVision
{
    public partial class MainForm : Form
    {
        private string sSourceFileName = "";
        private FastImage workImage;
        private FastImage saveImage;
        private Bitmap image = null;
        private Bitmap image1 = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (image != null)
                    {
                        image.Dispose();
                    }
                    if (image1 != null)
                    {
                        image1.Dispose();
                    }

                    sSourceFileName = openFileDialog.FileName;
                    image = new Bitmap(sSourceFileName);
                    image1 = new Bitmap(sSourceFileName);
                    workImage = new FastImage(image);
                    saveImage = new FastImage(image1);

                    panelSource.BackgroundImage = new Bitmap(sSourceFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonGrayscale_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Color color;

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    //byte average = (byte)((R + G + B) / 3);
                    byte average = (byte)(R * 0.299 + G * 0.587 + 0.114 * B);

                    color = Color.FromArgb(average, average, average);

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();

        }

        private void Btn_Negativare_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Color color;

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    color = Color.FromArgb(255 - R, 255 - G, 255 - B);

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }


        private void trackBar_Luminozitate_Scroll(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Color color;


            workImage.Lock();
            saveImage.Lock();


            int delta = this.trackBar_Luminozitate.Value;

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = saveImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;



                    if (R + delta > 255)
                        R = 255;
                    else
                        if (R + delta < 0)
                        R = 0;
                    else
                        R = (byte)(R + delta);


                    if (G + delta > 255)
                        G = 255;
                    else
                    if (G + delta < 0)
                        G = 0;
                    else
                        G = (byte)(G + delta);



                    if (B + delta > 255)
                        B = 255;
                    else
                    if (B + delta < 0)
                        B = 0;
                    else
                        B = (byte)(B + delta);


                    color = Color.FromArgb(R, G, B);

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }

        private void trackBar_Constrast_Scroll(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Color color;


            workImage.Lock();
            saveImage.Lock();

            int d = this.trackBar_Constrast.Value;


            int maxR = 0, minR = 255, maxG = 0, minG = 255, maxB = 0, minB = 255, rn, gn, bn;
            double ar, br, ag, bg, ab, bb;
            byte R = 0, G = 0, B = 0;

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = saveImage.GetPixel(i, j);
                    R = color.R;
                    G = color.G;
                    B = color.B;


                    if (R > maxR) maxR = R;
                    if (R < minR) minR = R;
                    if (G > maxG) maxG = G;
                    if (G < minG) minG = G;
                    if (B > maxB) maxB = B;
                    if (B < minB) minB = B;
                }
            }
            ar = minR - d;
            br = maxR + d;
            ag = minG - d;
            bg = maxG + d;
            ab = minB - d;
            bb = maxB + d;


            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = saveImage.GetPixel(i, j);
                    R = color.R;
                    G = color.G;
                    B = color.B;

                    rn = (int)((br - ar) / (maxR - minR) * (R - minR) + ar);
                    gn = (int)((bg - ag) / (maxG - minG) * (G - minG) + ag);
                    bn = (int)((bb - ab) / (maxB - minB) * (B - minB) + ab);



                    if (rn > 255)
                        rn = 255;
                    else
                        if (rn < 0)
                        rn = 0;
                    else
                        rn = (byte)(rn);


                    if (gn > 255)
                        gn = 255;
                    else
                    if (gn < 0)
                        gn = 0;
                    else
                        gn = (byte)(gn);



                    if (bn > 255)
                        bn = 255;
                    else
                    if (bn < 0)
                        bn = 0;
                    else
                        bn = (byte)(bn);


                    color = Color.FromArgb(rn, gn, bn);

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }

        private void BtnEgalizare_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Color color;


            workImage.Lock();
            saveImage.Lock();


            int[] hist = new int[256];
            int[] histc = new int[256];
            int[] transf = new int[256];
            int medie;

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = saveImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    medie = (R + G + B) / 3;
                    hist[medie] = hist[medie] + 1;

                }
            }

            histc[0] = hist[0];
            for (int i = 1; i < 256; i++)
                histc[i] = histc[i - 1] + hist[i];

            for (int i = 0; i < 256; i++)
                transf[i] = (histc[i] * 255) / (workImage.Width * workImage.Height);


            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = saveImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    medie = (R + G + B) / 3;
                    color = Color.FromArgb(transf[medie], transf[medie], transf[medie]);

                    workImage.SetPixel(i, j, color);
                }
            }



            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }

        private void TrackBar_Rotatie_Scroll(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workImage.Lock();
            saveImage.Lock();

            double unghi = this.TrackBar_Rotatie.Value * Math.PI / 180.0;
            int cx = workImage.Width / 2;
            int cy = workImage.Height / 2;

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    int x = (int)(Math.Cos(-unghi) * (i - cx) - Math.Sin(-unghi) * (j - cy) + cx);
                    int y = (int)(Math.Sin(-unghi) * (i - cx) + Math.Cos(-unghi) * (j - cy) + cy);

                    Color color;
                    if (x >= 0 && x < workImage.Width && y >= 0 && y < workImage.Height)
                    {
                        color = saveImage.GetPixel(x, y);
                    }
                    else
                    {
                        color = Color.FromArgb(0, 0, 0);
                    }
                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }
    }
}