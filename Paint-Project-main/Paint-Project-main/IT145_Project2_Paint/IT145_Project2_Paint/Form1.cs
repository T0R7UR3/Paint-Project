/*
 * Program: Paint Form
 * Purpose: User is able to create a shape and control size, color, position, and other variables.
 * Author: Thomas, Landen, Murdock
 * Date: 2/15/2026
 */

/*
 * Gen Comments from Thomas: 
 * When drawing shape, make sure it draws in Paint_Panel and not PaintForm
 * Paint_Panel contrainst is 500 by 500
 * Height, Length, and coords UpDowns have the min set to 1/0 and max set to 500
 * Dropdown shape selector can be changed through properties>items> then three dots
 */
// made a few fixes for x & y  mix ups, and triangle out of bounds. comments whre fixes. mjm

using System.Windows.Forms;

namespace IT145_Project2_Paint
{
    public partial class PaintForm : Form
    {
        public Color selectedColor = Color.Black;
        public string selectedShape;
        public int xCoord, yCoord;
        public const int panelConstraintX = 500;
        public const int panelConstraintY = 500;
        public Boolean isDrawing;
        Graphics g;
        Pen paintPen = new Pen(Color.Black, 5);
        Brush paintBrush = new SolidBrush(Color.Black);

        public PaintForm()
        {
            InitializeComponent();
            g = Paint_Panel.CreateGraphics();
            selectedShape = ShapeComboBox.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorPreviewPanel.BackColor = Color.Black; // sets a default color for color preview
        }

        private void GenShapeButton_Click(object sender, EventArgs e) // had issue where x & y  coords were getting out of bounds because things were backwards. Fixed MJM
        {
            if (CheckIfFieldsNULL())
            {
                MessageBox.Show("Error: A field is empty ");
                return;
            }

            if (OutOfBoundsCheck())
            {
                MessageBox.Show("Error: Values input extend out of bounds ");
                return;
            }

            float size = (float)HeightNumeric.Value;
            float width = (float)LengthNumeric.Value;
            float height = (float)HeightNumeric.Value;

            if (selectedShape == "Draw")
            {
                return;
            }
            else if (selectedShape == "Rectangle")
            {
                g.DrawRectangle(paintPen, xCoord, yCoord, width, height);
            }
            else if (selectedShape == "Square")
            {
                g.DrawRectangle(paintPen, xCoord, yCoord, size, size);
            }
            else if (selectedShape == "Circle")
            {
                g.DrawEllipse(paintPen, xCoord, yCoord, size, size);
            }
            else if (selectedShape == "Triangle")
            {
                int triWidth = (int)LengthNumeric.Value;
                int triHeight = (int)HeightNumeric.Value;

                Point[] trianglePoints =
                {
            new Point(xCoord, yCoord),
            new Point(xCoord - triWidth / 2, yCoord + triHeight),
            new Point(xCoord + triWidth / 2, yCoord + triHeight),
        };

                g.DrawPolygon(paintPen, trianglePoints);
            }
        }
        private void ColorButton_Click(object sender, EventArgs e) //Thomas: On button press opens a color picker box 
        {
            if (ColorDialogShape.ShowDialog() == DialogResult.OK)
            {
                //Thomas: Set the background color of the panel to the selected color
                ColorPreviewPanel.BackColor = ColorDialogShape.Color;

                //Thomas: assigns the color picked to a public variable that can be used in shape gen
                Color selectedColor = ColorDialogShape.Color;
                paintPen.Color = selectedColor;
                paintBrush.Dispose();
                paintBrush = new SolidBrush(selectedColor);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e) //Thomas: Clear all aplication fields and Paint_Panel
        {
            Paint_Panel.Controls.Clear(); //Thomas: Depending on how Logic Dev plans to implement drawing this may have to change
            ColorPreviewPanel.BackColor = Color.Black;
            Color selectedColor = Color.Empty;
            CoordXUpDown.Value = 0;
            CoordYUpDown.Value = 0;
            int xCoord = 0;
            int yCoord = 0;
            HeightNumeric.Value = 1;
            LengthNumeric.Value = 1;
            g.Clear(Paint_Panel.BackColor);
        }

        private void ExitButton_Click(object sender, EventArgs e) //Thomas: Exits application
        {
            Application.Exit();
        }

        private void Paint_Panel_MouseClick(object sender, MouseEventArgs e) //Thomas: Stores mouse cursor coords on mouse click to public variable (within the draw panel)
        {
            int xCoord = e.X;
            int yCoord = e.Y;

            CoordXUpDown.Value = xCoord;
            CoordYUpDown.Value = yCoord;
        }

        public Boolean CheckIfFieldsNULL() //Thomas: Function to check if fields are empty
        {
            if (ColorPreviewPanel.BackColor == Color.Empty)
            {
                return true;
            }
            else if ((float)HeightNumeric.Value == 0 || (float)LengthNumeric.Value == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void InstructionsButton_Click(object sender, EventArgs e) //Thomas: Instructions message box
        {
            MessageBox.Show
                ("Instructions:\n" +
                "- The shape is generated through the color, position, height, and length variables\n" +
                "- Color is chosen by clicking the pick color button which will open a color picker. The chosen color woll show in a prewiew next to the button\n" +
                "- The position of the shape can be set by clicking on the white area on the left of the screen. The shape will start at the clicked point. It can also be set by typing in the coordinates. The maximum is 500,500\n" +
                "- The length and height of the shape can be set through the labled number boxes. The minimum is 0 and the maximum is 500\n" +
                "- Once all variables are set, click genereate shape, and the shape will generate in the white area\n" +
                "- To reset back to the begining, click the reset button");
        }

        public Boolean OutOfBoundsCheck() // triangles could go out of bounds on the left, this should fix that. MJM
        {
            int panelW = Paint_Panel.ClientSize.Width;
            int panelH = Paint_Panel.ClientSize.Height;

            int width;
            int height;

            if (selectedShape == "Rectangle" || selectedShape == "Triangle")
            {
                width = (int)LengthNumeric.Value;
                height = (int)HeightNumeric.Value;
            }
            else
            {
                width = (int)HeightNumeric.Value;
                height = (int)HeightNumeric.Value;
            }

            if (selectedShape == "Triangle")
            {
                int leftX = xCoord - width / 2;
                int rightX = xCoord + width / 2;
                int bottomY = yCoord + height;

                if (leftX < 0 || rightX > panelW || bottomY > panelH) return true;
                return false;
            }

            if (xCoord + width > panelW || yCoord + height > panelH) return true;
            return false;
        }

        private void CoordXUpDown_ValueChanged(object sender, EventArgs e) //Thomas: Makes sure xCoord updates if UpDown is manually changed
        {
            xCoord = Convert.ToInt32(CoordXUpDown.Value);
        }

        private void CoordYUpDown_ValueChanged(object sender, EventArgs e) //Thomas: same as above
        {
            yCoord = Convert.ToInt32(CoordYUpDown.Value);
        }

        private void ShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedShape = ShapeComboBox.Text;
            if (ShapeComboBox.Text == "Rectangle" || ShapeComboBox.Text == "Triangle")
            {
                LengthNumeric.Visible = true;
                LengthLabel.Visible = true;
                HeightLabel.Text = "Height";
            }
            else
            {
                LengthNumeric.Visible = false;
                LengthLabel.Visible = false;
                HeightLabel.Text = "Size";
            }
        }

        private void Paint_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedShape == "Draw")
            {
                isDrawing = true;
            }
        }

        private void Paint_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void Paint_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                g.FillEllipse(paintBrush, e.X, e.Y, (float)HeightNumeric.Value, (float)HeightNumeric.Value);
            }
        }
    }
}
