using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

var screen = SystemInformation.VirtualScreen;

int x = screen.Left;
int y = screen.Top;
int w = screen.Width;
int h = screen.Height;

var image = new Bitmap(w, h);
using var graphics = Graphics.FromImage(image);
graphics.CopyFromScreen(x, y, 0, 0, new Size(w, h));

string picturesDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
string fileName = $"Screenshot {DateTime.Now:yyyy-MM-dd HHmmss}.png";
string filePath = Path.Combine(picturesDirectory, fileName);

image.Save(filePath, ImageFormat.Png);

Console.WriteLine("Screenshot saved to: " + filePath);