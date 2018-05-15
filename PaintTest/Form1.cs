using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PaintTest
{
    public partial class Form1 : Form
    {
        //private Graphics g;
        
        //private Point startPoint = new Point();
        //private Point endPoint = new Point();
        //private int pSize = 0;

        //private int x = 0;
        //private int y = 0;
        private int count = 0;
        private string cR, cG, cB, cRGB;
        private Color[] colorList = new Color[6];
        private PictureBox p;
        //private Bitmap emptyBitmap;
        private List<PictureBox> indexList = new List<PictureBox>();
        public List<Color> paletteA, paletteB, paletteC, paletteD, paletteE = new List<Color>();

        public Form1()
        {
            InitializeComponent();
            
            // RGB values must be length of 2

            textBox1.MaxLength = 2;
            textBox2.MaxLength = 2;
            textBox3.MaxLength = 2;
            // Shades length set to 2
            textBox4.MaxLength = 2;
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            p = pictureBox31;

            indexList.Add(pictureBox1);
            indexList.Add(pictureBox2);
            indexList.Add(pictureBox4);
            indexList.Add(pictureBox5);

            indexList.Add(pictureBox6);
            indexList.Add(pictureBox7);
            indexList.Add(pictureBox9);
            indexList.Add(pictureBox10);

            indexList.Add(pictureBox11);
            indexList.Add(pictureBox12);
            indexList.Add(pictureBox14);
            indexList.Add(pictureBox15);

            indexList.Add(pictureBox16);
            indexList.Add(pictureBox17);
            indexList.Add(pictureBox19);
            indexList.Add(pictureBox20);

            indexList.Add(pictureBox21);
            indexList.Add(pictureBox22);
            indexList.Add(pictureBox24);
            indexList.Add(pictureBox25);

            indexList.Add(pictureBox26);
            indexList.Add(pictureBox27);
            indexList.Add(pictureBox29);
            indexList.Add(pictureBox30);
            p.BackColor = panel1.DrawColor;
            panel1.targetDisplay = pictureBox32;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox1.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox2.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox3.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox4.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox5.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox6.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox7.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox8.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox9.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox10.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox11.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox12.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox13.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox14.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox15.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox16.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox17.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox18.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox19.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox20.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox21.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox22.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox23.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox24.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox25.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox26.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox27_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox27.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox28_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox28.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox29.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void pictureBox30_Click(object sender, EventArgs e)
        {
            p.BackColor = pictureBox30.BackColor;
            panel1.DrawColor = p.BackColor;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                cR = textBox1.Text;
            }
            if (textBox2.Text != null)
            {
                cG = textBox2.Text;
            }
            if (textBox3.Text != null)
            {
                cB = textBox3.Text;
            }
            cRGB = '#' + cR + cG + cB;
            Color colorRGB = ColorTranslator.FromHtml(cRGB);
            Console.WriteLine("RGB: {0}{1}{2}", cR, cG, cB);
            switch (count)
            {
                case 0:
                    pictureBox3.BackColor = colorRGB;
                    pictureBox3.Size = new Size(32, 32);
                    pictureBox8.Size = new Size(35, 35);
                    pictureBox8.BorderStyle = BorderStyle.Fixed3D;
                    colorList[0] = pictureBox3.BackColor;
                    count++;
                    break;
                case 1:
                    pictureBox8.BackColor = colorRGB;
                    pictureBox8.Size = new Size(32, 32);
                    pictureBox13.Size = new Size(35, 35);
                    pictureBox13.BorderStyle = BorderStyle.Fixed3D;
                    colorList[1] = pictureBox8.BackColor;
                    count++;
                    break;
                case 2:
                    pictureBox13.BackColor = colorRGB;
                    pictureBox13.Size = new Size(32, 32);
                    pictureBox18.Size = new Size(35, 35);
                    pictureBox18.BorderStyle = BorderStyle.Fixed3D;
                    colorList[2] = pictureBox13.BackColor;
                    count++;
                    break;
                case 3:
                    pictureBox18.BackColor = colorRGB;
                    pictureBox18.Size = new Size(32, 32);
                    pictureBox23.Size = new Size(35, 35);
                    pictureBox23.BorderStyle = BorderStyle.Fixed3D;
                    colorList[3] = pictureBox18.BackColor;
                    count++;
                    break;
                case 4:
                    pictureBox23.BackColor = colorRGB;
                    pictureBox23.Size = new Size(32, 32);
                    pictureBox28.Size = new Size(35, 35);
                    pictureBox28.BorderStyle = BorderStyle.Fixed3D;
                    colorList[4] = pictureBox23.BackColor;
                    count++;
                    break;
                case 5:
                    pictureBox28.BackColor = colorRGB;
                    pictureBox28.Size = new Size(32, 32);
                    pictureBox3.Size = new Size(35, 35);
                    pictureBox3.BorderStyle = BorderStyle.Fixed3D;
                    colorList[5] = pictureBox28.BackColor;
                    count = 0;

                    string hex = convertRGB(colorList[0]);
                    Console.WriteLine(hex);
                    Console.WriteLine(GetR(hex));
                    Console.WriteLine(GetG(hex));
                    Console.WriteLine(GetB(hex));
                    break;

            }
        }
        private static String convertRGB(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
        private static string GetR(string hexadecimal)
        {
            return hexadecimal.Substring(1, 2);
        }
        private static string GetG(string hexadecimal)
        {
            return hexadecimal.Substring(3, 2);
        }
        private static string GetB(string hexadecimal)
        {
            return hexadecimal.Substring(5, 2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int shades = Convert.ToInt32(textBox4.Text);
            transformShades(shades);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int pixelSize = Convert.ToInt32(textBox5.Text);
            panel1.PixelSize = pixelSize;
            panel1.drawingBitmap = new Bitmap(pixelSize, pixelSize);
            panel1.rectangles = new List<Tuple<Rectangle, Color>>();
            
            Invalidate();
        }
        private static int[] colorShades(int colorHex, int shades)
        {
            int[] modifiedR = new int[4];


            modifiedR[0] = colorHex - (shades * 2);
            if(modifiedR[0] < 0)
            {
                modifiedR[0] = 0;
            }
            modifiedR[1] = colorHex - shades;
            if(modifiedR[1] < 0)
            {
                modifiedR[1] = 0;
            }
            modifiedR[2] = colorHex + shades ;
            if(modifiedR[2] > 255)
            {
                modifiedR[2] = 255;
            }
            modifiedR[3] = colorHex + (shades * 2);
            if(modifiedR[3] > 255)
            {
                modifiedR[3] = 255;
            }

            return modifiedR;
        }
        private void transformShades(int shades)
        {
            Color hexValue;
            string hexadecimal;
            int counter = 0;
            List<Color> pList = new List<Color>();

            for (int indexColor = 0; indexColor < colorList.Length; indexColor++)
            {
                
                hexValue = colorList[indexColor];
                hexadecimal = convertRGB(hexValue);

                int colorR = int.Parse(GetR(hexadecimal), System.Globalization.NumberStyles.HexNumber);
                int colorG = int.Parse(GetG(hexadecimal), System.Globalization.NumberStyles.HexNumber);
                int colorB = int.Parse(GetB(hexadecimal), System.Globalization.NumberStyles.HexNumber);

                int[] colorRList, colorGList, colorBList = new int[4];
                Color[] ColorShadesList = new Color[4];

                Console.WriteLine("{0}{1}{2}", colorR, colorG, colorB);

                colorRList = colorShades(colorR, shades);
                colorGList = colorShades(colorG, shades);
                colorBList = colorShades(colorB, shades);
                ColorShadesList = compileColors(colorRList, colorGList, colorBList, ColorShadesList);
                //Console.WriteLine(ColorShadesList[3]);
                for(int j = 0; j < ColorShadesList.Length; j++)
                {
                    pList.Add(ColorShadesList[j]);
                }
            }
            foreach(var pBox in indexList)
            {
                pBox.BackColor = pList[counter];
                counter++;
            }
        }
        private static Color[] compileColors(int[] R, int[] G, int[] B, Color[] cList)
        {
            for(int i = 0; i < 4; i++)
            {
                cList[i] = Color.FromArgb(R[i], G[i], B[i]);
            }
            return cList;
        }
        void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c != '\b' && !((c <= 0x66 && c >= 61) || (c <= 0x46 && c >= 0x41) || (c >= 0x30 && c <= 0x39)))
            {
                e.Handled = true;
            }
        }
        void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c != '\b' && !((c <= 0x66 && c >= 61) || (c <= 0x46 && c >= 0x41) || (c >= 0x30 && c <= 0x39)))
            {
                e.Handled = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = folderBrowserDialog1;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = fbd.SelectedPath;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            String filepathName = textBox6.Text;
            String imageName = textBox7.Text;
            String newName = filepathName + "\\" + imageName;
            using (var newBitmap = new Bitmap(panel1.drawingBitmap))
                newBitmap.Save(newName, ImageFormat.Png);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            String filepathName = textBox6.Text + @"\";
            String offsetName = textBox8.Text;
            var fileList = Directory.GetFiles(filepathName, "*.txt", SearchOption.AllDirectories);
            foreach(var palette in fileList)
            {
                var paletteID = palette.Substring(offsetName.Length+filepathName.Length, 1);
                Console.WriteLine(paletteID);
                foreach(var i in paletteID)
                {
                    if(paletteID == "A")
                    {
                        paletteA = new List<Color>();
                        readFileToPalette(offsetName + "A");
                    }
                    if(paletteID == "B")
                    {
                        paletteB = new List<Color>();
                        readFileToPalette(offsetName + "B");
                    }
                    if (paletteID == "C")
                    {
                        paletteC = new List<Color>();
                        readFileToPalette(offsetName + "C");
                    }
                    if (paletteID == "D")
                    {
                        paletteD = new List<Color>();
                        readFileToPalette(offsetName + "D");
                    }
                    if (paletteID == "E")
                    {
                        paletteE = new List<Color>();
                        readFileToPalette(offsetName + "E");
                    }
                }
            }
        }
        public void readFileToPalette(string filename)
        {
            String filepathName = textBox6.Text+ @"\";
            filepathName += filename + ".txt";
            string fileEnd = filename.Substring(filename.Count() - 1, 1);
            try
            {
                using (StreamReader reader = new StreamReader(filepathName))
                {
                    //Console.WriteLine(filename.Substring(filename.Count()-1, 1));
                    foreach (var pBox in splitContainer1.Panel1.Controls.OfType<PictureBox>())
                    {
                        if (pBox.Tag != null)
                        {
                            if (pBox.Tag.ToString() == "palette")
                            {
                                pBox.BackColor = cStringToColor(reader.ReadLine());
                                if(fileEnd == "A")
                                    paletteA.Add(pBox.BackColor);
                                if (fileEnd == "B")
                                    paletteB.Add(pBox.BackColor);
                                if (fileEnd == "C")
                                    paletteC.Add(pBox.BackColor);
                                if (fileEnd == "D")
                                    paletteD.Add(pBox.BackColor);
                                if (fileEnd == "E")
                                    paletteE.Add(pBox.BackColor);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            } 
        }
        private static Color cStringToColor(string cString)
        {
            const string pattern = @"Color \[A=(?<alpha>\d+),\s*R=(?<red>\d+),\s*G=(?<green>\d+),\s*B=(?<blue>\d+)\]";
            var match = Regex.Match(cString, pattern);
            var alpha = int.Parse(match.Groups["alpha"].Value);
            var red = int.Parse(match.Groups["red"].Value);
            var green = int.Parse(match.Groups["green"].Value);
            var blue = int.Parse(match.Groups["blue"].Value);
            Color c = Color.FromArgb(red, green, blue);
            
            return c;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String filepathName = textBox6.Text;
            String offsetName = textBox8.Text;
            String newName = filepathName + "\\" + offsetName;
            String paletteChecked = string.Empty;

            List<List<Color>> colorList = new List<List<Color>>();

            foreach (var radio in splitContainer1.Panel1.Controls.OfType<RadioButton>())
            {
                if(radio.Checked == true)
                {
                    paletteChecked += radio.Name;
                    switch(radio.Name)
                    {
                        case "A":
                            colorList.Add(paletteA);
                            break;
                        case "B":
                            colorList.Add(paletteB);
                            break;
                        case "C":
                            colorList.Add(paletteC);
                            break;
                        case "D":
                            colorList.Add(paletteD);
                            break;
                        case "E":
                            colorList.Add(paletteE);
                            break;
                    }

                }
            }
            if(paletteChecked != string.Empty)
            {
                if (colorList[0] != null)
                {
                    newName += paletteChecked + ".txt";
                    using (StreamWriter file = new StreamWriter(newName, false))
                    {
                        foreach (var i in colorList)
                        {
                            foreach (var j in i)
                            {
                                file.WriteLine(j);
                            }
                        }
                    }
                }
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                paletteD = getAllColors();
            }
            else if (checkBox1.Checked != true)
            {
                loadAllColors(paletteD);
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                paletteE = getAllColors();
            }
            else if (checkBox1.Checked != true)
            {
                loadAllColors(paletteE);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                paletteC = getAllColors();
            }
            else if (checkBox1.Checked != true)
            {
                loadAllColors(paletteC);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            string red = (trackBar1.Value*5).ToString("X2");
            textBox1.Text = red;
            Color c = Color.FromArgb(trackBar1.Value * 5, trackBar2.Value * 5, trackBar3.Value * 5);
            pictureBox33.BackColor = c; 
            //Console.WriteLine(red);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            string green = (trackBar2.Value * 5).ToString("X2");
            textBox2.Text = green;
            Color c = Color.FromArgb(trackBar1.Value * 5, trackBar2.Value * 5, trackBar3.Value * 5);
            pictureBox33.BackColor = c;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            string blue = (trackBar3.Value * 5).ToString("X2");
            textBox3.Text = blue;
            Color c = Color.FromArgb(trackBar1.Value*5, trackBar2.Value*5, trackBar3.Value * 5);
            pictureBox33.BackColor = c;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                paletteA = getAllColors();
            }
            else if (checkBox1.Checked != true)
            {
                loadAllColors(paletteA);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                paletteB = getAllColors();
            }
            else if (checkBox1.Checked != true)
            {
                loadAllColors(paletteB);
            }
        }
        private void loadAllColors(List<Color> colors)
        {
            int index = 0;
            if (colors != null && colors.Count != 0)
            {
                foreach (var pBox in splitContainer1.Panel1.Controls.OfType<PictureBox>())
                {
                    if (pBox.Tag != null)
                    {
                        if (pBox.Tag.ToString() == "palette")
                        {
                            pBox.BackColor = colors[index];
                            index++;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Palette has no color!");
            }
        }

        void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c != '\b' && !((c <= 0x66 && c >= 61) || (c <= 0x46 && c >= 0x41) || (c >= 0x30 && c <= 0x39)))
            {
                e.Handled = true;
            }
        }
        void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != '\b' && !(c >= 0x30 && c <= 0x39))
            {
                e.Handled = true;
            }
        }
        void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != '\b' && !(c >= 0x30 && c <= 0x39))
            {
                e.Handled = true;
            }
        }
        
        private List<Color> getAllColors()
        {
            List<Color> colors = new List<Color>();
            foreach(var pBox in splitContainer1.Panel1.Controls.OfType<PictureBox>())

            {
                if (pBox.Tag != null)
                {
                    if (pBox.Tag.ToString() == "palette")
                    {
                        colors.Add(pBox.BackColor);

                    }
                    //Console.WriteLine(pBox.Name);
                }
            }
            if(colors.Count == 0)
            {
                for (int i = 0; i < 30; i++)
                {
                    colors.Add(Color.White);
                    
                }
            }
            //Console.WriteLine(colors[3]);
            return colors;
        }


    }
}
