using Guna;
using Microsoft.VisualBasic;
using WeatherApp.Forms;

namespace WeatherApp
{
    public partial class WeatherApp : Form
    {
        public WeatherApp()
        {
            InitializeComponent();
            FMain.BringToFront();
        }
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MimimizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            FMain.BringToFront();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FSearch.BringToFront();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            FSettings.BringToFront();
        }

    }
}
