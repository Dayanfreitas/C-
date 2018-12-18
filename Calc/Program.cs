using System;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program:System.Windows.Forms.Form
    {
        private Button soma;
        private Button multiplica;
        private Button subtrai;
        private Button divide;
        private Label  total;
        private Label totalNumber;
        private TextBox textBox1;
        private TextBox textBox2;
        
        static void Main(string[] args)
        {
            Application.Run(new Program());
        }
        public Program()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            total = new Label();
            totalNumber = new Label();
            soma = new Button();
            subtrai = new Button();
            multiplica = new Button();
            divide = new Button();

            textBox1.Name = "textBox1";
            textBox1.Location = new System.Drawing.Point(20, 50);
            textBox1.Text = "0";
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox2.Name = "textBox2";
            textBox2.Location = new System.Drawing.Point(textBox1.Location.X + textBox1.Size.Width + 20, 50);
            textBox2.Text = "0";
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            soma.Name = "soma";
            soma.Location = new System.Drawing.Point(0, 100);
            soma.AutoSize = true;
            soma.TabIndex = 1;
            soma.Text = "+";
            soma.Click += new System.EventHandler(this.calcular);

            subtrai.Name = "subtrai";
            subtrai.AutoSize = true;
            subtrai.Location = new System.Drawing.Point(soma.Size.Width,soma.Location.Y);
            subtrai.Text = "-";
            subtrai.Click += new System.EventHandler(this.calcular);

            multiplica.Name = "multiplica";
            multiplica.Location = new System.Drawing.Point(soma.Size.Width + subtrai.Size.Width, soma.Location.Y);
            multiplica.Text = "*";
            multiplica.Click += new System.EventHandler(this.calcular);

            divide.Name = "divide";
            divide.Location = new System.Drawing.Point(soma.Size.Width + subtrai.Size.Width + soma.Size.Width,soma.Location.Y);
            divide.Text = "/";
            divide.Click += new System.EventHandler(this.calcular);

            total.Location = new System.Drawing.Point(40, 130);
            total.AutoSize = true;
            total.Text = "Resposta:";
            totalNumber.Location = new System.Drawing.Point(total.Size.Width, total.Location.Y );
            totalNumber.Text = "0";

            Controls.AddRange(new System.Windows.Forms.Control[] {soma,subtrai,multiplica,divide,total, totalNumber, textBox1, textBox2 });
            Size = new System.Drawing.Size(320 ,250);
            Text = "test";
        }
        public void calcular(object sender, System.EventArgs e)
        {
            if((VerEspacoBraco(textBox1) == false && 
                VerEspacoBraco(textBox2) == false)&&
               (VerTipoText(textBox1) == true && 
                VerTipoText(textBox2) == true))
            {
                Button btnClicado = (Button)sender;
                String op = btnClicado.Text;
                int result;
                switch (op)
                {
                    case "+":
                        result = Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text);
                        totalNumber.Text = result.ToString();
                        break;
                    case "-":
                        result = Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text);
                        totalNumber.Text = result.ToString();
                        break;
                    case "*":
                        result = Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text);
                        totalNumber.Text = result.ToString();
                        break;
                    case "/":
                        result = Int32.Parse(textBox1.Text) / Int32.Parse(textBox2.Text);
                        totalNumber.Text = result.ToString();
                        break;
                }
            }
        }
        public bool VerEspacoBraco(TextBox box)
        {
            bool espaco = false;
            if (String.IsNullOrWhiteSpace(box.Text))
            {
                totalNumber.Text = String.Format("Não tem nada no campo de texto"); 
                espaco = true;
            }
            return espaco;

        }
        public bool VerTipoText(TextBox box)
        {
            int n;
            bool isNumeral = int.TryParse(box.Text, out n);
            if (!isNumeral)
            {
                totalNumber.Text = String.Format("Digite números");
            }
            return isNumeral;
        }
    }
}
