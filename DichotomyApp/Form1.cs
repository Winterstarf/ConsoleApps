using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnFindRoot_Click(object sender, EventArgs e) //method for the button that the guy clicks and it finds the root using the method FindRoot above
        {
            try
            {
                string equation = txtEquation.Text; //gets the equation itself from the user
                Func<double, double> func = x => EvaluateEquation(equation, x); //the 'f' func is delcared here and uses NCalc to calculate the equation with ease

                double a = double.Parse(txtIntervalA.Text); //two initial bounds the user is supposed to enter :P
                double b = double.Parse(txtIntervalB.Text);

                double tol = double.Parse(txtTolerance.Text); //tolerance from user

                double root = Dichotomy.FindRoot(func, a, b, tol); //passes Func 'f', initial bounds and tolerance to FindRoot

                MessageBox.Show("Approximate root: " + root);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private double EvaluateEquation(string equation, double x) //yeah somehow this shit evaluates the equation string with a given x
        {
            var expression = new NCalc.Expression(equation);
            expression.Parameters["x"] = x;
            return (double)expression.Evaluate();
        }
    }
}
