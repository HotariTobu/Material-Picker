using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Material_Picker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Image image;

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                image = Image.FromFile(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
                box.Image = image;

                panel1.Enabled = true;
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (File.Exists(((string[])e.Data.GetData(DataFormats.FileDrop))[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private bool isPicking;

        private void colorPickButton_Click(object sender, EventArgs e)
        {
            if (isPicking)
            {
                isPicking = false;

                Cursor = Cursors.Default;
            }
            else
            {
                isPicking = true;

                Cursor = Cursors.Cross;
            }
        }

        private void colorPreview_Click(object sender, EventArgs e)
        {
            colorDialog.Color = colorPreview.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK) 
            {
                colorPreview.BackColor = colorDialog.Color;
            }
        }

        private void box_MouseClick(object sender, MouseEventArgs e)
        {
            if (isPicking)
            {
                Bitmap bitmap = new Bitmap(box.Image);
                int x = e.X * bitmap.Width / box.ClientSize.Width;
                int y = e.Y * bitmap.Height / box.ClientSize.Height;
                colorPreview.BackColor = bitmap.GetPixel(x, y);

                isPicking = false;

                Cursor = Cursors.Default;
            }
        }

        private void overwrite_Click(object sender, EventArgs e)
        {
            image = box.Image;
        }

        private void backColorPreview_Click(object sender, EventArgs e)
        {
            colorDialog.Color = backColorPreview.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                backColorPreview.BackColor = colorDialog.Color;
            }
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(new Bitmap(image));
            graphics.Clear(backColorPreview.BackColor);

            byte RMin = (byte)(colorPreview.BackColor.R - (int)R.Value);
            byte RMax = (byte)(colorPreview.BackColor.R + (int)R.Value);
            byte GMin = (byte)(colorPreview.BackColor.G - (int)G.Value);
            byte GMax = (byte)(colorPreview.BackColor.G + (int)G.Value);
            byte BMin = (byte)(colorPreview.BackColor.B - (int)B.Value);
            byte BMax = (byte)(colorPreview.BackColor.B + (int)B.Value);
            byte HMin = (byte)(colorPreview.BackColor.GetHue() - (int)H.Value);
            byte HMax = (byte)(colorPreview.BackColor.GetHue() + (int)H.Value);
            byte SMin = (byte)(colorPreview.BackColor.GetSaturation() - (int)S.Value);
            byte SMax = (byte)(colorPreview.BackColor.GetSaturation() + (int)S.Value);
            byte VMin = (byte)(colorPreview.BackColor.GetBrightness() - (int)V.Value);
            byte VMax = (byte)(colorPreview.BackColor.GetBrightness() + (int)V.Value);

            Pen pen = new Pen(colorPreview.BackColor);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    int count = 0;

                    if (isNot.Checked)
                    {
                        if (RMax < color.R || RMin > color.R)
                        {
                            count++;
                        }
                        if (GMax < color.G || GMin > color.G)
                        {
                            count++;
                        }
                        if (BMax < color.B || BMin > color.B)
                        {
                            count++;
                        }
                        if (HMax < color.GetHue() || HMin > color.GetHue())
                        {
                            count++;
                        }
                        if (SMax < color.GetSaturation() || SMin > color.GetSaturation())
                        {
                            count++;
                        }
                        if (VMax < color.GetBrightness() || VMin > color.GetBrightness())
                        {
                            count++;
                        }
                    }
                    else
                    {

                        if (RMin < color.R && RMax > color.R)
                        {
                            count++;
                        }
                        if (GMin < color.G && GMax > color.G)
                        {
                            count++;
                        }
                        if (BMin < color.B && BMax > color.B)
                        {
                            count++;
                        }
                        if (HMin < color.GetHue() && HMax > color.GetHue())
                        {
                            count++;
                        }
                        if (SMin < color.GetSaturation() && SMax > color.GetSaturation())
                        {
                            count++;
                        }
                        if (VMin < color.GetBrightness() && VMax > color.GetBrightness())
                        {
                            count++;
                        }
                    }

                    if (count > 3)
                    {
                        graphics.DrawRectangle(pen, new Rectangle(x, y, 1, 1));
                    }
                }
            }

            graphics.Dispose();

            box.Image = bitmap;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                box.Image.Save(saveFileDialog.FileName);
            }
        }
    }
}
