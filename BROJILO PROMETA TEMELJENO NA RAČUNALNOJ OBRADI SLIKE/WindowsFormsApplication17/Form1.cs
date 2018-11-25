using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

using Emgu.CV;
using Emgu.CV.UI;
using Emgu.Util;
using Emgu.CV.Structure;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        private Capture _capture2 = null;
        private Image<Bgr, Byte> colImage2;
        private Image<Gray, byte> GrayImage;
        private Image<Gray, Byte> oldImage2;
        //private Image<Bgr, Byte> oldImage;
        private Image<Gray, Byte> resultImage2;
        private int brojac = 0;
        private float BrL = 0;
        private float BrR = 0;
        private int flag1 = 0, flag2 = 0,flag3=0;
        private int flag4 = 0, flag5 = 0, flag6 = 0;
        private int X;
        private int Y;
        public int middle_oneX = 0;
        public int left_oneX = 0;
        public int right_oneX = 0;
        public int middle_twoX = 0;
        public int left_twoX = 0;
        public int right_twoX = 0;

        public int middle_oneY = 0;
        public int left_oneY = 0;
        public int right_oneY = 0;
        public int middle_twoY = 0;
        public int left_twoY = 0;
        public int right_twoY = 0;
        
        
        
        public Form1()
        {
            InitializeComponent();
            _capture2 = new Capture("parking_example_1.avi");//dohvacanje slike iz file-a
            //_capture2 = new Capture(0); //za dohvacanje snimke sa default kamere
            _capture2.ImageGrabbed += _capture2_ImageGrabbed;
            _capture2.Start();
            int W = _capture2.Width;
            int H = _capture2.Height;
            label1.Text = W.ToString();
            label2.Text = H.ToString();
            
            
            
        }
        
        void _capture2_ImageGrabbed(object sender, EventArgs e)
        {

           
            colImage2 = _capture2.RetrieveBgrFrame(); //kontrolni video
            GrayImage = _capture2.RetrieveGrayFrame(); //tu se broji
            if (oldImage2 == null) oldImage2 = GrayImage;
           
            resultImage2 = GrayImage - oldImage2;
            

            

            resultImage2._ThresholdBinary(new Gray(20), new Gray(255));
            resultImage2.MorphologyEx(new StructuringElementEx(10, 10, 5, 5, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_ELLIPSE), Emgu.CV.CvEnum.CV_MORPH_OP.CV_MOP_OPEN, 20);
            ibVideo.Image = resultImage2;                      //5,5,2,2                                                                                                //15

            Point start1 = new Point(317,220);
            Point stop1 = new Point(323, 220);                      //plava linija lijevo-desno
            LineSegment2D line1 = new LineSegment2D(start1, stop1);
                                                                                                //zajedno pokazuju mjesta gdje su "senzori" od A do I
            Point start = new Point(320, 220);
            Point stop = new Point(320, 300);                       //plava linija gore-dolje
           
            
            KontrolniVideo.Image = colImage2;
            oldImage2 = GrayImage;


            Point startA = new Point(left_twoX, left_twoY);
            Point stopA = new Point(right_twoX, right_twoY);                     // gornja crvena
            LineSegment2D lin51 = new LineSegment2D(startA, stopA);
            colImage2.Draw(lin51, new Bgr(Color.Red), 1);

                byte A = resultImage2.Data[middle_twoY, middle_twoX, 0];         
                byte AL = resultImage2.Data[left_twoY, left_twoX, 0];         // sa desna na lijevo
                byte AR = resultImage2.Data[right_twoY, right_twoX, 0];
                

                Point startB = new Point(left_oneX, left_oneY);
                Point stopB = new Point(right_oneX, right_oneY);                      //donja crvena sa lijeva na desno
                LineSegment2D lin52 = new LineSegment2D(startB, stopB);
                colImage2.Draw(lin52, new Bgr(Color.Red), 1);
               
                byte B = resultImage2.Data[middle_oneY, middle_oneX, 0];
                byte BL = resultImage2.Data[left_oneY, left_oneX, 0];
                byte BR = resultImage2.Data[right_oneY, right_oneX, 0];
               




                                                     

                if (AR > 0 && flag1 == 0 && flag2 == 0 && flag3 == 0) flag1 = 1;
                if (A > 0 && flag1 == 1 && flag2 == 0 && flag3 == 0) flag2 = 1;
                if (AL > 0 && flag1 == 1 && flag2 == 1 && flag3 == 0) flag3 = 1;
                if (flag3 == 1 && flag2==1 && flag3==1)
                {
                    CounterL();
                    flag1 = 0;
                    flag2 = 0;
                    flag3 = 0;
                }

                if (BL > 0 && flag4==0 && flag5==0 && flag6==0) flag4 = 1;
                if (B > 0 && flag4 == 1 && flag5 == 0 && flag6 == 0) flag5 = 1;
                if (BR > 0 && flag4 == 1 && flag5 == 1 && flag6 == 0) flag6 = 1;
                if (flag6 == 1 && flag4==1 && flag5==1)
                {
                    CounterR();
                    flag4 = 0;
                    flag5 = 0;
                    flag6 = 0;

                }

                
               

                label5.Invoke(new Action(() =>
                {
                    label5.Text = BrL.ToString();

                }));
                label7.Invoke(new Action(() =>
                {
                    label7.Text = BrR.ToString();

                }));


               
                
            
            



            
        }

        private void Reset_counter_Click(object sender, EventArgs e)
        {
            BrL = 0;
            BrR = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void CounterL()
        {
            BrL++;
        }
        private void CounterR()
        {
            BrR++;
        }
        private void ibVideo_MouseClick(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
            brojac++;
            ispisxy.Text = X.ToString() +" "+ Y.ToString() +" "+brojac;
            
            switch(brojac)
            {
                case 1:
                    left_oneX = X;
                    left_oneY = Y;
                    break;
                case 2:
                    middle_oneX = X;
                    middle_oneY = Y;
                    break;
                case 3:
                    right_oneX = X;
                    right_oneY = Y;
                    break;
                case 4:
                    right_twoX = X;
                    right_twoY = Y;
                    break;
                case 5:
                    middle_twoX = X;
                    middle_twoY = Y;
                    break;
                case 6:
                    left_twoX = X;
                    left_twoY = Y;
                    break;
                default:
                    break;
            }
        }




        
    }
}
