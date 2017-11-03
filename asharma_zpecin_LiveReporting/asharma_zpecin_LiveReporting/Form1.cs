/*
* FILE : asharma_zpecin_LiveReporting
* PROJECT : Bussiness intelligence - Assignment #2
* PROGRAMMER : Arindm Sharma & Zivojin Pecin
* DESCRIPTION :
* The methods in this applications are used in order to display data from a yoyosimulator
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace asharma_zpecin_LiveReporting
{
    public partial class Form1 : Form
    {
        String queueName = "\\private$\\yoyo";
        MessageQueue msmq = new MessageQueue();
        DAL myDal = new DAL();
        Boolean bRead = true;

        public static int totalPartsModeled;
        public static int totalPartsSuccessfullyModeled;
        public static double YieldAtMold;
        public static int totalPartsSuccessfullyPainted;
        public static double YieldAtPaint;
        public static int totalPartsSuccessfullyAssembeled;
        public static double YieldAtAssembly;
        public static int totalPartsPackaged;
        public static double totalYield;

        //for defects (chart)
        public static int FinalCoatFlaw;
        public static int BrokenShell;
        public static int BrokenAxle;
        public static int TangledString;
        public static int PrimerDefect;
        public static int DripMark;
        public static int InconsistentThickness;
        public static int Warping;
        public static int Pitting;

        double sumPrevFreq = 0;
        double frequencySum = 0;

        int productID;

        double[] amountArray = {0,1,2,3,4,5,6,7,8,9};
        string[] seriesArray = { "FINAL_COAT_FLAW", "BROKEN_SHELL", "BROKEN_AXLE", "TANGLED_STRING", "PRIMER_DEFECT", "DRIP_MARK", "INCONSISTENT_THICKNESS", "WARPING", "PITTING" };
        public Form1()
        {
            InitializeComponent();
            msmq.Formatter = new ActiveXMessageFormatter();
            msmq.MessageReadPropertyFilter.LookupId = true;
            msmq.SynchronizingObject = this;
            msmq.ReceiveCompleted += new ReceiveCompletedEventHandler(msmq_ReceiveCompleted);

            productCombo.Items.Add("Original Sleeper");
            productCombo.Items.Add("Black Beauty");
            productCombo.Items.Add("Firecracker");
            productCombo.Items.Add("Lemon Yellow");
            productCombo.Items.Add("Midnight Blue");
            productCombo.Items.Add("Screaming Orange");
            productCombo.Items.Add("Gold Glitter");
            productCombo.Items.Add("White Lightening");

            string QueueServer = System.Windows.Forms.SystemInformation.ComputerName;
            msmq.Path = "Formatname:Direct=os:" + QueueServer + queueName;
            //bRead = true;
            msmq.BeginReceive();

        }


        /*
        * FUNCTION : checkBox1_CheckedChanged
        *
        * DESCRIPTION : This function is activated when the user check off the combobox
        * RETURNS : nothing
        */
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (productCombo.Enabled)
            {
                productCombo.Enabled = false;

            }
            else
            {
                productCombo.Enabled = true;
            }
        }
        /*
        * FUNCTION : productCombo_SelectedIndexChanged
        *
        * DESCRIPTION : This function is activated when the user modifies the combobox of the products
        * RETURNS : nothing
        */
        private void productCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteedYoyoName = productCombo.Text;

        }
        /*
        * FUNCTION : msmq_ReceiveCompleted
        *
        * DESCRIPTION : This function is activated when the user modifies the combobox of the products
        * RETURNS : nothing
        */
        void msmq_ReceiveCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            //get server name, check if string is empty 
            string QueueServer = System.Windows.Forms.SystemInformation.ComputerName;
            if (QueueServer == "")
            {
                MessageBox.Show("Message Queue Server required");
            }
            else
            {
                msmq.Path = "Formatname:Direct=os:" + QueueServer + queueName;
                try
                {
                    System.Messaging.Message msg = msmq.Receive(new TimeSpan(0));
                    if (msg != null)
                    {
                        string MSg = msg.Body.ToString();
                        string[] tempArray = new string[7];
                        tempArray = MSg.Split(',');
                        ////WorkArea,a67f804e-3071-402a-abcf-c04898054ce9,Line0,MOLD,,10/1/2017 4:11:23 PM, 3
                        myDal.writeToProductionTable(tempArray[0], tempArray[1], tempArray[2], tempArray[3], tempArray[4], tempArray[5], tempArray[6]);
                        if (bRead)
                        {
                            msmq.BeginReceive();
                        }
                    }
                }
                catch (Exception ex)
                {
                    string msg = ex.Message.ToString();
                   // MessageBox.Show("Cannot read - probably empty queue or queue non existent");
                }
            }

        }
        /*
        * FUNCTION : button1_Click
        *
        * DESCRIPTION : checks if combobox is checked in order to display all products or it display according to the chosen one
        * RETURNS : nothing
        */
        private void button1_Click(object sender, EventArgs e)
        {
            bRead = false;
            //if check sed id to 0, gett all products
            if (AllProducts_Checkbox.Checked)
            {
                productID = 0; //get all the products.
            }
            else
            {
                productID = productCombo.SelectedIndex + 1;
            }

            //else set product id by combobox selection and retrieve parts based on id 
            myDal.totalPartsMoldedDAL(productID);
            myDal.totalPartsSuccessfullyMoldedDAL(productID);
            myDal.yieldAtMoldDAL(productID);
            myDal.partsSuccessfullyPaintedDAL(productID);
            myDal.yieldAtPaintDAL(productID);
            myDal.partsSuccessfullyAssembledDAL(productID);
            myDal.yieldAtAssebmlyDAL(productID);
            myDal.partsPackagedDAL(productID);
            myDal.totalYieldDAL(productID);

            //display values
            TotalPartsModelLabel.Text = totalPartsModeled.ToString();
            TotalPartsSuccessfullyModeledLabel.Text = totalPartsSuccessfullyModeled.ToString();
            YieldAtMoldLabel.Text = YieldAtMold.ToString();
            TotalPartsSuccessfullyPaintedLabel.Text = totalPartsSuccessfullyPainted.ToString();
            YieldAtPaintLabel.Text = YieldAtPaint.ToString();
            TotalPartsSuccessfullyAssembeledLabel.Text = totalPartsSuccessfullyAssembeled.ToString();
            YieldAtAssemblyLabel.Text = YieldAtAssembly.ToString();
            TotalPartsPackagedLabel.Text = totalPartsPackaged.ToString();
            TotalYieldLabel.Text = totalYield.ToString();

            readIntoAmountArray();
            updatePareto();

            bRead = false;
            msmq.BeginReceive();

        }
        /*
        * FUNCTION : updatePareto
        *
        * DESCRIPTION : displays values into pareto graph
        * RETURNS : nothing
        */
        void updatePareto()
        {
            string dmp;
            //calculate the total of frequency
            calcFreq();
            //clear the chart series
            this.chart1.Series.Clear();

            //create new series
            Series series = this.chart1.Series.Add("Defects in the YoYos");
            Series series2 = this.chart1.Series.Add("%age of defect");
            //set specific chart types for specific series
            this.chart1.Series["Defects in the YoYos"].ChartType = SeriesChartType.Column;
            this.chart1.Series["%age of defect"].ChartType = SeriesChartType.Line;
            // add a Y2 axis 
            chart1.ChartAreas[0].AxisX.Title = "defect reason";
            chart1.ChartAreas[0].AxisY.Title = "Defect amount";
            chart1.ChartAreas[0].AxisY2.Title = "Cumulative %age of defects";
            chart1.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;

            //set the axis to specific series.
            chart1.Series[0].YAxisType = AxisType.Primary;
            chart1.Series[1].YAxisType = AxisType.Secondary;

            //set the chart area properties
            chart1.ChartAreas[0].AxisY2.LineColor = Color.Red;
            chart1.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            chart1.ChartAreas[0].AxisY2.IsStartedFromZero = chart1.ChartAreas[0].AxisY.IsStartedFromZero;


            double temp;

            //sort the array in descending order
            Array.Sort(amountArray);
            Array.Reverse(amountArray);

            Dictionary<string, string> dic = new Dictionary<string, string>(); //instantiate a new dictionary

            
            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add point.
                series.Points.Add(amountArray[i]);


                dmp = seriesArray[i];


                this.chart1.Series["Defects in the YoYos"].Points[i].AxisLabel = dmp;

                //calculate cumulative frequency percentage for this iteration

                temp = calcCumFreqPercentage(amountArray[i]);
                series2.Points.Add(temp);
                series2.Points[i].MarkerColor = Color.Blue;
                series2.Points[i].MarkerStyle = MarkerStyle.Circle;
                series2.Points[i].MarkerSize = 10;
            }


            sumPrevFreq = 0;
        }

        /*  -- METHOD Header Comment
        Name	:   calcFreq
        Purpose :   this method calculates the frequencysum i.e. sum of 
                    all the frequencies in the frequency array
        PARAMETERS	: NOTHING
        Returns	:	NOTHING
        */
        void calcFreq()
        {
            double retVal = 0;
            for (int i = 0; i < amountArray.Length; i++)
            {
                retVal += amountArray[i];
            }
            frequencySum = retVal;
        }


        /*  -- METHOD Header Comment
        Name	:   calcCumFreqPercentage
        Purpose :   this method calculates the cumulative frequency for 
                    the frequencies in the frequency array.
        PARAMETERS	: double currFreq - frequency that needs the cumulative frequency.
        Returns	:	NOTHING
        */
        double calcCumFreqPercentage(double currFreq)
        {
            double retVal = 0;
            sumPrevFreq += currFreq;
            retVal = (sumPrevFreq / frequencySum) * 100;
            return retVal;
        }
        void readIntoAmountArray()
        {

            amountArray[0] = myDal.howMany("howManyFinalCoatFlaw", productID);
            amountArray[1] = myDal.howMany("howManyBrokenShell", productID);
            amountArray[2] = myDal.howMany("howManyBrokenAxel", productID);
            amountArray[3] = myDal.howMany("howManyTangledString", productID);
            amountArray[4] = myDal.howMany("howManyPrimerDefect", productID);
            amountArray[5] = myDal.howMany("howManyDripMark", productID);
            amountArray[6] = myDal.howMany("howInconsistentThickness", productID);
            amountArray[7] = myDal.howMany("howManyWarping", productID);
            amountArray[8] = myDal.howMany("howManyPitting", productID);

        }
    }
}
