#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (c) 2007-2017 ShareX Team

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using ShareX.HelpersLib;
using ShareX.Properties;
using ShareX.ScreenCaptureLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;

namespace ShareX
{
    public partial class QRCodeForm : Form
    {
        private bool isReady;

        public QRCodeForm(string text = null)
        {
            InitializeComponent();
            Icon = ShareXResources.Icon;

            if (!string.IsNullOrEmpty(text))
            {
                txtQRCode.Text = text;
            }
            else
            {
                if (Clipboard.ContainsText())
                {
                    text = Clipboard.GetText();

                    if (URLHelpers.IsValidURL(text))
                    {
                        txtQRCode.Text = text;
                    }
                }
            }
        }

        private void QRCodeForm_Shown(object sender, EventArgs e)
        {
            isReady = true;

            txtQRCode.SetWatermark(Resources.QRCodeForm_InputTextToEncode);

            EncodeText(txtQRCode.Text);
        }

        private void ClearQRCode()
        {
            if (pbQRCode.Image != null)
            {
                Image temp = pbQRCode.Image;
                pbQRCode.Image = null;
                temp.Dispose();
            }
        }

        private void EncodeText(string text)
        {
            if (isReady)
            {
                ClearQRCode();

                if (!string.IsNullOrEmpty(text))
                {
                    try
                    {
                        BarcodeWriter writer = new BarcodeWriter
                        {
                            Format = BarcodeFormat.QR_CODE,
                            Options = new EncodingOptions
                            {
                                Width = pbQRCode.Width,
                                Height = pbQRCode.Height
                            },
                            Renderer = new BitmapRenderer()
                        };

                        pbQRCode.Image = writer.Write(text);
                    }
                    catch (Exception e)
                    {
                        e.ShowError();
                    }
                }
            }
        }

        private void DecodeImage(Bitmap bmp)
        {
            BarcodeReader barcodeReader = new BarcodeReader
            {
                AutoRotate = true,
                TryInverted = true,
                Options = new DecodingOptions
                {
                    TryHarder = true
                }
            };

            Result[] results = barcodeReader.DecodeMultiple(bmp);

            string output = "";

            if (results != null)
            {
                output = string.Join(Environment.NewLine + Environment.NewLine, results.Where(x => x != null && !string.IsNullOrEmpty(x.Text)).Select(x => x.Text));
            }

            txtDecodeResult.Text = output.Trim();
        }

        private void QRCodeForm_Resize(object sender, EventArgs e)
        {
            EncodeText(txtQRCode.Text);
        }

        private void txtQRCode_TextChanged(object sender, EventArgs e)
        {
            EncodeText(txtQRCode.Text);
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            if (pbQRCode.Image != null)
            {
                ClipboardHelpers.CopyImage(pbQRCode.Image);
            }
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQRCode.Text))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = @"PNG (*.png)|*.png|JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|SVG (*.svg)|*.svg";
                    saveFileDialog.FileName = txtQRCode.Text;
                    saveFileDialog.DefaultExt = "png";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        if (filePath.EndsWith("svg", StringComparison.InvariantCultureIgnoreCase))
                        {
                            BarcodeWriterSvg writer = new BarcodeWriterSvg
                            {
                                Format = BarcodeFormat.QR_CODE,
                                Options = new EncodingOptions
                                {
                                    Width = pbQRCode.Width,
                                    Height = pbQRCode.Height
                                }
                            };
                            SvgRenderer.SvgImage svgImage = writer.Write(txtQRCode.Text);
                            File.WriteAllText(filePath, svgImage.Content, Encoding.UTF8);
                        }
                        else
                        {
                            if (pbQRCode.Image != null)
                            {
                                ImageHelpers.SaveImage(pbQRCode.Image, filePath);
                            }
                        }
                    }
                }
            }
        }

        private void btnDecodeFromScreen_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Thread.Sleep(250);

                using (Image img = RegionCaptureTasks.GetRegionImage(null))
                {
                    if (img != null)
                    {
                        DecodeImage((Bitmap)img);
                    }
                }
            }
            finally
            {
                this.ForceActivate();
            }
        }

        private void btnDecodeFromFile_Click(object sender, EventArgs e)
        {
            string filePath = ImageHelpers.OpenImageFileDialog();

            if (!string.IsNullOrEmpty(filePath))
            {
                using (Image img = ImageHelpers.LoadImage(filePath))
                {
                    if (img != null)
                    {
                        DecodeImage((Bitmap)img);
                    }
                }
            }
        }

        private List<Image> qrImages;
        private int currentImageIndex = 0;

        private void btnGenQrcode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQRContentMulti.Text))
            {
                MessageBox.Show("Please Enter Encode Content!", "Warnning");
            }
            else
            {
                EncodeTextM(txtQRContentMulti.Text);
            }
        }
        private void ClearQrCodeM()
        {
            qrImages = new List<Image>();
            if (pbQrImage.Image != null)
            {
                Image temp = pbQrImage.Image;
                pbQrImage.Image = null;
                temp.Dispose();
            }
        }
        private void EncodeTextM(string text)
        {
            if (isReady)
            {
                ClearQrCodeM();
                if (!string.IsNullOrEmpty(text))
                {
                    try
                    {
                        string[] txtArr = text.Split('\r');
                        if (txtArr.Length > 0)
                        {
                            foreach (string txt in txtArr) {
                                string txt1 = txt.Replace("\n", "");
                                if (string.IsNullOrEmpty(txt1)) continue;
                                BarcodeWriter writer = new BarcodeWriter
                                {
                                    Format = BarcodeFormat.QR_CODE,
                                    Options = new EncodingOptions
                                    {
                                        Width = pbQrImage.Width,
                                        Height = pbQrImage.Height
                                    },
                                    Renderer = new BitmapRenderer()
                                };
                                Image Image = writer.Write(txt1);
                                qrImages.Add(Image);
                            }
                            NavigateQrImageFirst();
                        }
                    }
                    catch (Exception e)
                    {
                        e.ShowError();
                    }
                }
            }
        }

        private void btnNextQrImage_Click(object sender, EventArgs e)
        {
            NavigateQrImage(1);
        }

        private void btnPrevQrImage_Click(object sender, EventArgs e)
        {
            NavigateQrImage(-1);
        }

        private void NavigateQrImage(int imageIndex)
        {
            int showImgIndex = currentImageIndex + imageIndex;
            if (showImgIndex < 0)
            {
                showImgIndex = 0;
            }
            if (showImgIndex >= qrImages.Count)
            {
                showImgIndex = qrImages.Count - 1;
            }

            currentImageIndex = showImgIndex;
            pbQrImage.Image = qrImages[showImgIndex];
            lblTip.Text = (showImgIndex+1) + "/" + qrImages.Count;
        }

        private void NavigateQrImageFirst()
        {
            currentImageIndex = 0;
            NavigateQrImage(0);
        }
        private void NavigateQrImageEnd()
        {
            currentImageIndex = qrImages.Count - 1;
            NavigateQrImage(0);
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            var dirSel = new FolderBrowserDialog();
            if (dirSel.ShowDialog() == DialogResult.OK){
                string filePath = dirSel.SelectedPath;
                string timeStr = ToTimestamp(DateTime.Now).ToString();
                int i = 1;
                foreach (Image img in qrImages)
                {
                    img.Save(filePath + "\\qrImage_"+ timeStr+"_"+i.ToString()+".jpg");
                    i++;
                }
            }
        }

        static double ToTimestamp(DateTime value)
        {
            TimeSpan span = (value - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime());
            return (double)span.TotalSeconds;
        }
    }
}