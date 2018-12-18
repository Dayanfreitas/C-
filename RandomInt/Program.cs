using System;
using System.Windows.Forms;
using System.Drawing;

namespace RandomInt
{
    class RandomInt:Form
    {
        private System.Windows.Forms.Button showOutputButton;
        private System.Windows.Forms.Label outputLabel;
        private int n;
        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new RandomInt());
        }
        public RandomInt()
        {
            showOutputButton = new Button();
            showOutputButton.Text = "Show Output";
            showOutputButton.Location = new System.Drawing.Point(Width/2 - showOutputButton.Size.Width / 2,20);
            showOutputButton.AutoSize = true;
            showOutputButton.Click += new System.EventHandler(showOutputButton_Click);
            outputLabel = new Label();
            outputLabel.Location = new System.Drawing.Point(20, 100);
            outputLabel.AutoSize = true;

            Controls.AddRange(new System.Windows.Forms.Control[] { showOutputButton,outputLabel});
            Text = "RandomInt";
        }
        private void showOutputButton_Click(object sender, System.EventArgs e)
        {
            outputLabel.Text = "";
            Random randomInterger = new Random();
            for (int counter = 1; counter <= 20; counter++)
            {
                //escolhe um inteiro aleatório entre 1 e 6
                int nextValue = randomInterger.Next(1, 7);
                outputLabel.Text += String.Format($"{nextValue}   ");
                if (counter % 5 == 0)
                    outputLabel.Text += "\n";
            }            
        }   
    }
}
