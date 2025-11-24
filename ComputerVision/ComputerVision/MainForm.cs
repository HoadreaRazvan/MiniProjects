using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Net.NetworkInformation;

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
            this.TxtFTJ.Text = "1";
            this.TxtOutlier.Text = "1";
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

        private void BtnFTJ_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workImage.Lock();
            saveImage.Lock();
            Color color;
            int n = int.Parse(this.TxtFTJ.Text);
            byte R, G, B;
            int sr = 0, sg = 0, sb = 0;
            int[,] h = new int[3, 3];
            h[0, 0] = 1; h[0, 2] = 1; h[2, 0] = 1; ; h[2, 2] = 1;
            h[0, 1] = n; h[1, 0] = n; h[1, 2] = n; h[2, 1] = n;
            h[1, 1] = n * n;

            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {

                    sr = 0;
                    sg = 0;
                    sb = 0;
                    for (int row = i - 1; row <= i + 1; row++)
                        for (int col = j - 1; col <= j + 1; col++)
                        {
                            color = workImage.GetPixel(row, col);
                            sr += color.R * h[row - i + 1, col - j + 1];
                            sg += color.G * h[row - i + 1, col - j + 1];
                            sb += color.B * h[row - i + 1, col - j + 1];
                        }
                    sr = sr / ((n + 2) * (n + 2));
                    sg = sg / ((n + 2) * (n + 2));
                    sb = sb / ((n + 2) * (n + 2));


                    color = Color.FromArgb(sr, sg, sb);

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }

        private void BtnFM_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workImage.Lock();
            saveImage.Lock();
            Color color;
            byte R, G, B;

            for (int i = 2; i < workImage.Width - 2; i++)
            {
                for (int j = 2; j < workImage.Height - 2; j++)
                {
                    Color a, b, c, d, ee;
                    a = workImage.GetPixel(i, j - 2);
                    b = workImage.GetPixel(i, j - 1);
                    c = workImage.GetPixel(i, j);
                    d = workImage.GetPixel(i, j + 1);
                    ee = workImage.GetPixel(i, j + 2);


                    color = Color.FromArgb(Math.Max(Math.Max(Math.Max(Math.Min(a.R, Math.Min(c.R, ee.R)), Math.Min(a.R, Math.Min(d.R, ee.R))), Math.Max(Math.Min(b.R, Math.Min(c.R, d.R)), Math.Min(b.R, Math.Min(c.R, ee.R)))), Math.Max(Math.Max(Math.Min(b.R, Math.Min(d.R, ee.R)), Math.Min(c.R, Math.Min(d.R, ee.R))), Math.Max(Math.Max(Math.Min(a.R, Math.Min(b.R, c.R)), Math.Min(a.R, Math.Min(b.R, d.R))), Math.Max(Math.Min(a.R, Math.Min(b.R, ee.R)), Math.Min(a.R, Math.Min(c.R, d.R)))))),
                        Math.Max(Math.Max(Math.Max(Math.Min(a.G, Math.Min(c.G, ee.G)), Math.Min(a.G, Math.Min(d.G, ee.G))), Math.Max(Math.Min(b.G, Math.Min(c.G, d.G)), Math.Min(b.G, Math.Min(c.G, ee.G)))), Math.Max(Math.Max(Math.Min(b.G, Math.Min(d.G, ee.G)), Math.Min(c.G, Math.Min(d.G, ee.G))), Math.Max(Math.Max(Math.Min(a.G, Math.Min(b.G, c.G)), Math.Min(a.G, Math.Min(b.G, d.G))), Math.Max(Math.Min(a.G, Math.Min(b.G, ee.G)), Math.Min(a.G, Math.Min(c.G, d.G)))))),
                        Math.Max(Math.Max(Math.Max(Math.Min(a.B, Math.Min(c.B, ee.B)), Math.Min(a.B, Math.Min(d.B, ee.B))), Math.Max(Math.Min(b.B, Math.Min(c.B, d.B)), Math.Min(b.B, Math.Min(c.B, ee.B)))), Math.Max(Math.Max(Math.Min(b.B, Math.Min(d.B, ee.B)), Math.Min(c.B, Math.Min(d.B, ee.B))), Math.Max(Math.Max(Math.Min(a.B, Math.Min(b.B, c.B)), Math.Min(a.B, Math.Min(b.B, d.B))), Math.Max(Math.Min(a.B, Math.Min(b.B, ee.B)), Math.Min(a.B, Math.Min(c.B, d.B))))))
                    );

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }

        private void BtnOutlier_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workImage.Lock();
            saveImage.Lock();
            Color color;
            int n = int.Parse(this.TxtOutlier.Text);
            byte R, G, B;
            int sr = 0, sg = 0, sb = 0;


            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {

                    sr = 0;
                    sg = 0;
                    sb = 0;
                    for (int row = i - 1; row <= i + 1; row++)
                        for (int col = j - 1; col <= j + 1; col++)
                        {
                            if (row == i && col == j)
                                continue;
                            color = workImage.GetPixel(row, col);
                            sr += color.R;
                            sg += color.G;
                            sb += color.B;
                        }
                    sr = sr / 8;
                    sg = sg / 8;
                    sb = sb / 8;

                    if (Math.Abs(workImage.GetPixel(i, j).R - sr) > n && Math.Abs(workImage.GetPixel(i, j).G - sg) > n && Math.Abs(workImage.GetPixel(i, j).B - sb) > n)
                    {
                        color = Color.FromArgb(sr, sg, sb);

                    }
                    else
                        color = workImage.GetPixel(i, j);

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }

        private void BtnMarkov_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workImage.Lock();
            saveImage.Lock();

            Color color;

            int cs = 3, sr = 4, t = 500;


            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    color = saveImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    if (Salt_Pepper(color) == true)
                    {
                        workImage.SetPixel(i, j, CBP(i, j, cs, sr, t));
                    }

                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }

        public Color CBP(int x, int y, int cs, int sr, int t)
        {
            int[] q = new int[256];
            for (int i = x - sr; i <= x + sr; i++)
            {
                for (int j = y - sr; j <= y + sr; j++)
                {
                    if (i < 0 || i >= workImage.Width || j < 0 || j >= workImage.Height)
                        continue;
                    if (i == x || j == y)
                        continue;
                    if (SAD(x, y, i, j, cs) < t && !this.Salt_Pepper(workImage.GetPixel(i, j)))
                    {
                        q[workImage.GetPixel(i, j).R]++;
                    }

                }
            }
            int max = 0;
            for (int i = 1; i < 256; i++)
            {
                if (q[i] > q[max])
                    max = i;
            }
            return Color.FromArgb(max, max, max);
        }

        public int SAD(int x1, int y1, int x2, int y2, int cs)
        {
            int s = 0;
            for (int i = -cs / 2; i <= cs / 2; i++)
            {
                for (int j = -cs / 2; j <= cs / 2; j++)
                {
                    if (x1 + i < 0 || x1 + i >= workImage.Width || y1 + j < 0 || y1 + j >= workImage.Height)
                        continue;
                    if (x2 + i < 0 || x2 + i >= workImage.Width || y2 + j < 0 || y2 + j >= workImage.Height)
                        continue;
                    if (i == 0 && j == 0)
                        continue;

                    Color c1 = workImage.GetPixel(x1 + i, y1 + j);
                    Color c2 = workImage.GetPixel(x2 + i, y2 + j);
                    byte average1 = (byte)(c1.R * 0.299 + c1.G * 0.587 + 0.114 * c1.B);
                    byte average2 = (byte)(c2.R * 0.299 + c2.G * 0.587 + 0.114 * c2.B);
                    s += Math.Abs(average1 - average2);

                }
            }

            return s;
        }

        public bool Salt_Pepper(Color color)
        {
            byte average = (byte)(color.R * 0.299 + color.G * 0.587 + 0.114 * color.B);
            if (average == 0 || average == 255)
                return true;
            return false;
        }

        private void BtnFM2_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workImage.Lock();
            saveImage.Lock();
            Color color;
            byte R, G, B;

            int[] rv = new int[9];
            int[] gv = new int[9];
            int[] bv = new int[9];
            int index = 0;
            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    rv = new int[9];
                    gv = new int[9];
                    bv = new int[9];
                    index = 0;
                    for (int ii = i - 1; ii <= i + 1; ii++)
                    {
                        for (int jj = j - 1; jj <= j + 1; jj++)
                        {
                            color = workImage.GetPixel(ii, jj);
                            rv[index] = color.R;
                            gv[index] = color.G;
                            bv[index] = color.B;
                            index++;
                        }
                    }

                    Array.Sort(rv);
                    Array.Sort(gv);
                    Array.Sort(bv);
                    color = Color.FromArgb(rv[4], gv[4], bv[4]);

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }

        private void BtnFTS_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workImage.Lock();
            saveImage.Lock();
            Color color;
            byte R, G, B;
            int sr = 0, sg = 0, sb = 0;
            int[,] h = new int[3, 3];
            //h[0, 0] = 0; h[0, 2] = 0; h[2, 0] = 0; ; h[2, 2] = 0;
            //h[0, 1] = -1; h[1, 0] = -1; h[1, 2] = -1; h[2, 1] = -1;
            //h[1, 1] = 5;

            //h[0, 0] = -1; h[0, 2] = -1; h[2, 0] = -1; ; h[2, 2] = -1;
            //h[0, 1] = -1; h[1, 0] = -1; h[1, 2] = -1; h[2, 1] = -1;
            //h[1, 1] = 9;

            h[0, 0] = 1; h[0, 2] = 1; h[2, 0] = 1; ; h[2, 2] = 1;
            h[0, 1] = -2; h[1, 0] = -2; h[1, 2] = -2; h[2, 1] = -2;
            h[1, 1] = 5;

            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {

                    sr = 0;
                    sg = 0;
                    sb = 0;
                    for (int row = i - 1; row <= i + 1; row++)
                        for (int col = j - 1; col <= j + 1; col++)
                        {
                            color = saveImage.GetPixel(row, col);
                            sr += color.R * h[row - i + 1, col - j + 1];
                            sg += color.G * h[row - i + 1, col - j + 1];
                            sb += color.B * h[row - i + 1, col - j + 1];
                        }

                    if (sr < 0) sr = 0;
                    if (sr > 255) sr = 255;
                    if (sg < 0) sg = 0;
                    if (sg > 255) sg = 255;
                    if (sb < 0) sb = 0;
                    if (sb > 255) sb = 255;
                    color = Color.FromArgb(sr, sg, sb);

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }

        private void BtnUM_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workImage.Lock();
            saveImage.Lock();
            Color color;
            Color color1;
            int n = 1;
            double c = 0.6;
            byte R, G, B;
            int sr = 0, sg = 0, sb = 0;
            int ro = 0, go = 0, bo = 0;
            int[,] h = new int[3, 3];
            h[0, 0] = 1; h[0, 2] = 1; h[2, 0] = 1; ; h[2, 2] = 1;
            h[0, 1] = n; h[1, 0] = n; h[1, 2] = n; h[2, 1] = n;
            h[1, 1] = n * n;

            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {

                    sr = 0;
                    sg = 0;
                    sb = 0;
                    for (int row = i - 1; row <= i + 1; row++)
                        for (int col = j - 1; col <= j + 1; col++)
                        {
                            color = workImage.GetPixel(row, col);
                            sr += color.R * h[row - i + 1, col - j + 1];
                            sg += color.G * h[row - i + 1, col - j + 1];
                            sb += color.B * h[row - i + 1, col - j + 1];
                        }
                    sr = sr / ((n + 2) * (n + 2));
                    sg = sg / ((n + 2) * (n + 2));
                    sb = sb / ((n + 2) * (n + 2));


                    color1= saveImage.GetPixel(i, j);
                    ro = color1.R;
                    go = color1.G;
                    bo = color1.B;

                    sr = (int)(c / (2 * c - 1) * ro - (1 - c) / (2 * c - 1) * sr);
                    sg = (int)(c / (2 * c - 1) * go - (1 - c) / (2 * c - 1) * sg);
                    sb = (int)(c / (2 * c - 1) * bo - (1 - c) / (2 * c - 1) * sb);

                    if (sr < 0) sr = 0;
                    if (sr > 255) sr = 255;
                    if (sg < 0) sg = 0;
                    if (sg > 255) sg = 255;
                    if (sb < 0) sb = 0;
                    if (sb > 255) sb = 255;


                    color = Color.FromArgb(sr, sg, sb);

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }

        private void BtnKirsch_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workImage.Lock();
            saveImage.Lock();
            Color color;
            Color color1;

            int r1 = 0, g1 = 0, b1 = 0;
            int r2 = 0, g2 = 0, b2 = 0;
            int r3 = 0, g3 = 0, b3 = 0;
            int r4 = 0, g4 = 0, b4 = 0;
            int rm = 0, gm = 0, bm = 0;


            int[,] h1 = new int[3, 3];
            h1[0, 0] = -1; h1[0, 2] = 1; h1[2, 0] = -1; ; h1[2, 2] = 1;
            h1[0, 1] = 0; h1[1, 0] = -1; h1[1, 2] = 1; h1[2, 1] = 0;
            h1[1, 1] = 0;

            int[,] h2 = new int[3, 3];
            h2[0, 0] = 1; h2[0, 2] = 1; h2[2, 0] = -1; ; h2[2, 2] = -1;
            h2[0, 1] = 1; h2[1, 0] = 0; h2[1, 2] = 0; h2[2, 1] = -1;
            h2[1, 1] = 0;

            int[,] h3 = new int[3, 3];
            h3[0, 0] = 0; h3[0, 2] = 1; h3[2, 0] = -1; ; h3[2, 2] = 0;
            h3[0, 1] = 1; h3[1, 0] = -1; h3[1, 2] = 1; h3[2, 1] = -1;
            h3[1, 1] = 0;

            int[,] h4 = new int[3, 3];
            h4[0, 0] = 1; h4[0, 2] = 0; h4[2, 0] = 0; ; h4[2, 2] = -1;
            h4[0, 1] = 1; h4[1, 0] = 1; h4[1, 2] = -1; h4[2, 1] = -1;
            h4[1, 1] = 0;


            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    r1 = 0;r2 = 0;r3 = 0;r4 = 0;
                    g1 = 0;g2 = 0;g3 = 0;g4 = 0;
                    b1 = 0;b2 = 0;b3 = 0;b4 = 0;

                    for (int row = i - 1; row <= i + 1; row++)
                        for (int col = j - 1; col <= j + 1; col++)
                        {
                            color = saveImage.GetPixel(row, col);
                            r1 += color.R * h1[row - i + 1, col - j + 1];
                            g1 += color.G * h1[row - i + 1, col - j + 1];
                            b1 += color.B * h1[row - i + 1, col - j + 1];

                            r2 += color.R * h2[row - i + 1, col - j + 1];
                            g2 += color.G * h2[row - i + 1, col - j + 1];
                            b2 += color.B * h2[row - i + 1, col - j + 1];

                            r3 += color.R * h3[row - i + 1, col - j + 1];
                            g3 += color.G * h3[row - i + 1, col - j + 1];
                            b3 += color.B * h3[row - i + 1, col - j + 1];

                            r4 += color.R * h4[row - i + 1, col - j + 1];
                            g4 += color.G * h4[row - i + 1, col - j + 1];
                            b4 += color.B * h4[row - i + 1, col - j + 1];
                        }

                    rm = Math.Max(r1, Math.Min(r2, Math.Max(r3, r4)));
                    gm = Math.Max(g1, Math.Min(g2, Math.Max(g3, g4)));
                    bm = Math.Max(b1, Math.Min(b2, Math.Max(b3, b4)));

                    if (rm < 0) rm = 0;
                    if (gm < 0) gm = 0;
                    if (bm < 0) bm = 0;

                    if (rm > 255) rm = 255;
                    if (gm > 255) gm = 255;
                    if (bm > 255) bm = 255;



                    color = Color.FromArgb(rm, gm, bm);

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }

        private void BtnLaplace_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workImage.Lock();
            saveImage.Lock();
            Color color;
            Color color1;

            int r1 = 0, g1 = 0, b1 = 0;

            int rm = 0, gm = 0, bm = 0;


            int[,] h1 = new int[3, 3];
            h1[0, 0] = -1; h1[0, 2] = -1; h1[2, 0] = -1; ; h1[2, 2] = -1;
            h1[0, 1] = -1; h1[1, 0] = -1; h1[1, 2] = -1; h1[2, 1] = -1;
            h1[1, 1] = 8;



            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    r1 = 0;
                    g1 = 0;
                    b1 = 0; 

                    for (int row = i - 1; row <= i + 1; row++)
                        for (int col = j - 1; col <= j + 1; col++)
                        {
                            color = saveImage.GetPixel(row, col);
                            r1 += color.R * h1[row - i + 1, col - j + 1];
                            g1 += color.G * h1[row - i + 1, col - j + 1];
                            b1 += color.B * h1[row - i + 1, col - j + 1];

                        }


                    if (r1 < 0) r1 = 0;
                    if (g1 < 0) g1 = 0;
                    if (b1 < 0) b1 = 0;

                    if (r1 > 255) r1 = 255;
                    if (g1 > 255) g1 = 255;
                    if (b1 > 255) b1 = 255;



                    color = Color.FromArgb(r1, g1, b1);

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }

        private void BtnRoberts_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workImage.Lock();
            saveImage.Lock();
            Color color;
            Color color1;

            int r1 = 0, g1 = 0, b1 = 0;
            int r2 = 0, g2 = 0, b2 = 0;
            double rm = 0, gm = 0, bm = 0;


            int[,] h1 = new int[2, 2];
            h1[0, 0] = -1; h1[0, 1] = 0; h1[1, 0] = 0; ; h1[1, 1] = 1;


            int[,] h2 = new int[2, 2];
            h2[0, 0] = 0; h2[0, 1] = 1; h2[1, 0] = -1; ; h2[1, 1] = 0;


            int k = 7;

            for (int i = 0; i < workImage.Width - 1; i++)
            {
                for (int j = 0; j < workImage.Height - 1; j++)
                {
                    r1 = 0; r2 = 0;
                    g1 = 0; g2 = 0;
                    b1 = 0; b2 = 0;

                    for (int row = i; row <= i + 1; row++)
                        for (int col = j; col <= j + 1; col++)
                        {
                            color = saveImage.GetPixel(row, col);
                            r1 += color.R * h1[row - i, col - j];
                            g1 += color.G * h1[row - i , col - j ];
                            b1 += color.B * h1[row - i , col - j ];

                            r2 += color.R * h2[row - i , col - j ];
                            g2 += color.G * h2[row - i , col - j ];
                            b2 += color.B * h2[row - i , col - j ];

                        }

                    rm = k * Math.Sqrt(r1 * r1 + r2 * r2);

                    gm = k * Math.Sqrt(g1 * g1 + g2 * g2);
                    bm = k * Math.Sqrt(b1 * b1 + b2 * b2);

                    if (rm < 0) rm = 0;
                    if (gm < 0) gm = 0;
                    if (bm < 0) bm = 0;

                    if (rm > 255) rm = 255;
                    if (gm > 255) gm = 255;
                    if (bm > 255) bm = 255;



                    color = Color.FromArgb((int)rm, (int)gm, (int)bm);

                    workImage.SetPixel(i, j, color);
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            saveImage.Unlock();
        }

        private void BtnPrewitt_Click(object sender, EventArgs e)
        {
            if (workImage == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workImage.Lock();
            saveImage.Lock();
            Color color;
            Color color1;

            int r1 = 0, g1 = 0, b1 = 0;
            int r2 = 0, g2 = 0, b2 = 0;
            double rm = 0, gm = 0, bm = 0;


            int[,] h1 = new int[3, 3];
            h1[0, 0] = -1; h1[0, 2] = -1; h1[2, 0] = 1; ; h1[2, 2] = 1;
            h1[0, 1] = -1; h1[1, 0] = 0; h1[1, 2] = 0; h1[2, 1] = 1;
            h1[1, 1] = 0;

            int[,] h2 = new int[3, 3];
            h2[0, 0] = -1; h2[0, 2] = 1; h2[2, 0] = -1; ; h2[2, 2] = 1;
            h2[0, 1] = 0; h2[1, 0] = -1; h2[1, 2] = 1; h2[2, 1] = 0;
            h2[1, 1] = 0;


            for (int i = 1; i < workImage.Width - 1; i++)
            {
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    r1 = 0; r2 = 0;
                    g1 = 0; g2 = 0;
                    b1 = 0; b2 = 0;

                    for (int row = i-1; row <= i + 1; row++)
                        for (int col = j-1; col <= j + 1; col++)
                        {
                            color = saveImage.GetPixel(row, col);
                            r1 += color.R * h1[row - i+1, col - j + 1];
                            g1 += color.G * h1[row - i + 1, col - j + 1];
                            b1 += color.B * h1[row - i + 1, col - j + 1];

                            r2 += color.R * h2[row - i + 1, col - j + 1];
                            g2 += color.G * h2[row - i + 1, col - j + 1];
                            b2 += color.B * h2[row - i + 1, col - j + 1];

                        }

                    rm =  Math.Sqrt(r1 * r1 + r2 * r2);
                    gm = Math.Sqrt(g1 * g1 + g2 * g2);
                    bm = Math.Sqrt(b1 * b1 + b2 * b2);

                    if (rm < 0) rm = 0;
                    if (gm < 0) gm = 0;
                    if (bm < 0) bm = 0;

                    if (rm > 255) rm = 255;
                    if (gm > 255) gm = 255;
                    if (bm > 255) bm = 255;



                    color = Color.FromArgb((int)rm, (int)gm, (int)bm);

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