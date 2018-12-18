using System;
using System.Windows.Forms;

namespace SquareInt2
{
    public class SquareInt2 : Form
    {
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label outPutLabel;

        static void Main()
        {
            Application.Run(new SquareInt2());
        }
        public SquareInt2() {
            calculateButton = new Button();
            outPutLabel = new Label();

            calculateButton.Text = "Calculate Square";
            calculateButton.Location = new System.Drawing.Point(50,0);
            calculateButton.AutoSize=true;
            outPutLabel.Location = new System.Drawing.Point(50,calculateButton.Size.Height+10);
            outPutLabel.AutoSize = true;            
            calculateButton.Click += new System.EventHandler(calculateButton_Click);
            
            Controls.AddRange(new System.Windows.Forms.Control[] {calculateButton,outPutLabel});
            AutoSize = true;

        }
        public int Square(int y)
        {
            return y * y;
        }
        private void calculateButton_Click(object sender, System.EventArgs e)
        {

            for (int counter = 1; counter <= 10; counter++)
                {
                    int result = Square(counter);
                    outPutLabel.Text += String.Format($"The square of {counter} is { result} \n");
                }
        }
    }
 }
    
