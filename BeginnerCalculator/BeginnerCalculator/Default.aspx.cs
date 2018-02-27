using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeginnerCalculator
{
    public partial class _Default : Page
    {
        protected void page_load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            try
            {
                resultLBL.Text = "Result : " + (Convert.ToDouble(num1TF.Text) + Convert.ToDouble(num2TF.Text));

            }
            catch(Exception ex)
            {
                Console.Write(ex);
                resultLBL.Text = "Enter valid numbers";
                num1TF.Text = "";
                num2TF.Text = "";
            }
            }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                resultLBL.Text = "Result : " + Math.Abs(Convert.ToDouble(num1TF.Text) - Convert.ToDouble(num2TF.Text));
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                resultLBL.Text = "Enter valid numbers";
                num1TF.Text = "";
                num2TF.Text = "";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                resultLBL.Text = "Result : " + Math.Abs(Convert.ToDouble(num1TF.Text) % Convert.ToDouble(num2TF.Text));
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                resultLBL.Text = "Enter valid numbers";
                num1TF.Text = "";
                num2TF.Text = "";
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                resultLBL.Text = "Result : " + (Convert.ToDouble(num1TF.Text) * Convert.ToDouble(num2TF.Text));
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                resultLBL.Text = "Enter valid numbers";
                num1TF.Text = "";
                num2TF.Text = "";
            }

        }
    }
}