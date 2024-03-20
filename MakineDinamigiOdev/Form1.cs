using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Windows.Forms;

namespace MakineDinamigiOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics graphic;

        Pen whitePen = new Pen(Color.White, 10);
        Pen bluePen = new Pen(Color.Blue, 3);
        Pen yellowPen = new Pen(Color.Yellow, 3);
        Pen redPen = new Pen(Color.Red, 3);



        //Start Value
        double originX = 200;
        double originY = 300;

        double ax = 0;
        double ay = 0;

        double bx = 0;
        double by = 0;

        double cx = 0;
        double cy = 0;

        double dx = 171;
        double dy = 0;

        double angle1 = 180 , angle2 = 60.77 , angle3 = 0 , angle4 = 0;

        double angle2Radian = 0 , angle3Radian = 60 , angle4Radian = 0;


        
        double r1 = 171, r2 = 50, r3 = 80, r4 = 150;

        private void Form1_Load(object sender, EventArgs e)
        {
            graphic = screen.CreateGraphics();
        }
       
        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled= true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled= false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            calculateAnglesAndPositions(angle3);

            ShowMechanismDrawing();
            ShowVectorPositionTable();
            ShowJointLocationTable();
            ShowHingePointsbyDrawing();

            angle3++;
            angle3 = angle3 % 360;
            engineAngle.Text = angle3.ToString();
        }

        private void calculateAngelButton_Click(object sender, EventArgs e)
        {
            angle3 = Convert.ToDouble(engineAngle.Text);

            calculateAnglesAndPositions(angle3);

            ShowMechanismDrawing();
            ShowVectorPositionTable();
            ShowJointLocationTable();
            ShowHingePointsbyDrawing();

        }

        public void calculateAnglesAndPositions(double angle)
        {
            cx = bx + r3 * Math.Cos(Radian(angle));
            cy = by + r3 * Math.Sin(Radian(angle));

            angle3Radian = Angle3Calculate(Radian(angle));


            dx = cx + r4 * Math.Cos(angle4Radian);

            angle4Radian = Angle4Calculate();
        }

        public void ShowMechanismDrawing()
        {
            screen.Refresh();

            DrawLine(redPen, ax, ay, bx, by);
            DrawLine(yellowPen, bx, by, cx, cy);
            DrawLine(bluePen, cx, cy, dx, dy);

            engineAngle.Text = angle3.ToString();

            R1_L.Text = r1.ToString();
            R1_Q.Text = angle1.ToString();

            R2_L.Text = r2.ToString();
            R2_Q.Text = angle2.ToString();

            R3_L.Text = r3.ToString();
            R3_Q.Text = (Degree(angle3Radian) % 360).ToString();

            R4_L.Text = r4.ToString();
            R4_Q.Text = (Degree(angle4Radian) % 360).ToString();

        }

        public void ShowVectorPositionTable()
        {
            R1_L.Text = r1.ToString();
            R1_Q.Text = angle1.ToString();

            R2_L.Text = r2.ToString();
            R2_Q.Text = angle2.ToString();

            R3_L.Text = r3.ToString();
            R3_Q.Text = (Degree(angle3Radian) % 360).ToString();

            R4_L.Text = r4.ToString();
            R4_Q.Text = (Degree(angle4Radian) % 360).ToString();
        }

        public void ShowJointLocationTable()
        {
            A_X.Text = ax.ToString();
            A_Y.Text = ay.ToString();

            B_X.Text = bx.ToString();
            B_Y.Text = by.ToString();

            C_X.Text = cx.ToString();
            C_Y.Text = cy.ToString();

            D_X.Text= dx.ToString();
            D_Y.Text = dy.ToString();
        }

        public void ShowHingePointsbyDrawing()
        {
            DrawCircle(whitePen, ax, ay);
            DrawCircle(whitePen, bx, by);
            DrawCircle(whitePen, cx, cy);
            DrawCircle(whitePen, dx, dy);
        }

        public void DrawLine(Pen pen, double x1, double y1, double x2, double y2)
        {
            graphic.DrawLine(pen, (int)(x1 + originX), (int)(y1 * (-1) + originY), (int)(x2 + originX), (int)(y2 * (-1) + originY));
        }

        public void DrawCircle(Pen pen, double x, double y)
        {
            graphic.DrawEllipse(pen, (int)((x) + originX), (int)((y) * (-1) + originY),1, 1);
        }

        double m = 0;

        double angleAlphaRadian = 0;

        double angleBetaRadian = 0;

        public double Angle3Calculate(double angle2Radian)
        {
            double x = r2 * Math.Cos(angle2Radian);
            double y = r2 * Math.Sin(angle2Radian);
            double z = r1 - x;

            m = Math.Sqrt(y * y + z * z);

            angleAlphaRadian = Math.Atan(x / z);

            angleBetaRadian = Math.Acos((r3 * r3 + m * m - r4 * r4) / (2 * r3 * m));

            angle3Radian = angleBetaRadian - angleAlphaRadian;

            return angle3Radian;
        }

        public double Angle4Calculate()
        {
            double angleGammaRadian = Math.Acos((r4 * r4 + m * m - r3 * r3) / (2 * r4 * m));

            angle4Radian = 2 * Math.PI - (angleAlphaRadian + angleGammaRadian);

            return angle4Radian;
        }

        public double Radian(double angleDegree)
        {
            double angleRadian = angleDegree * 2 * Math.PI / 360.0;
            return angleRadian;
        }

        public double Degree(double angleRadian)
        {
            double angleDegree = (angleRadian * 360.0) / (2 * Math.PI);
            return angleDegree;
        }
    }
}