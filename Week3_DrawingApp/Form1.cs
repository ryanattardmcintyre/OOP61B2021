using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week3_Polymorphism.Shapes;

namespace Week3_DrawingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Week3_Polymorphism.Shapes.Point currentShape;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "Point":
                    currentShape = new Week3_Polymorphism.Shapes.Point();
                    break;

                case "Circle":
                    //        Circle currentShapeTemp = new Circle();
                    //                    currentShapeTemp.Radius = 10;
                    //                  currentShape = currentShapeTemp;
                    currentShape = new Circle();
                    //currentShape is of type Point but we can initialize a circle (look at the 2nd part of the line) because
                    //Circle inherits from Point

                    ((Circle)currentShape).Radius = 10;
                    break;

                case "Square":
                    currentShape = new Square();
                    ((Square)currentShape).Length = 100;
                    break;

                case "Rectangle":
                    currentShape = new Week3_Polymorphism.Shapes.Rectangle();
                    ((Week3_Polymorphism.Shapes.Rectangle)currentShape).Length = 100;
                    ((Week3_Polymorphism.Shapes.Rectangle)currentShape).Width = 200;
                    break;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
         
            
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            currentShape.X = e.X;
            currentShape.Y = e.Y;

            switch (comboBox1.Text)
            {
                case "Circle":
                    ((Circle)currentShape).Radius = Convert.ToDouble(txtRadius.Text);
                    break;

                case "Square":
                    ((Square)currentShape).Length = Convert.ToDouble(txtLength.Text);
                    break;

                case "Rectangle":
                   
                    ((Week3_Polymorphism.Shapes.Rectangle)currentShape).Length = Convert.ToDouble(txtLength.Text);
                    ((Week3_Polymorphism.Shapes.Rectangle)currentShape).Width = Convert.ToDouble(txtWidth.Text);
                    break;
            }

            currentShape.Draw(pnlCanvas.CreateGraphics(), chosenColour);
        }
        
        Color chosenColour = Color.Black;
        private void btnColour_Click(object sender, EventArgs e)
        {
          

            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                chosenColour = colorDialog1.Color;
            }



        }
    }
}
