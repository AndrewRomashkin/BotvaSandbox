using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotvaSandbox
{
    public partial class Form1 : Form
    {

        #region Shapes
        static readonly Shape stronghold = new Shape("Крепость", new byte[][] {
            new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new byte[] { 1, 0, 0, 0, 0, 0, 0, 1 },
            new byte[] { 1, 0, 1, 1, 1, 1, 0, 1 },
            new byte[] { 1, 0, 1, 1, 1, 1, 0, 1 },
            new byte[] { 1, 0, 1, 1, 1, 1, 0, 1 },
            new byte[] { 1, 0, 1, 1, 1, 1, 0, 1 },
            new byte[] { 1, 0, 0, 0, 0, 0, 0, 1 },
            new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 }
            });
        static readonly Shape chess = new Shape("Шахматное поле", new byte[][] {
            new byte[] { 1, 0, 1, 0, 1, 0, 1, 0 },
            new byte[] { 0, 1, 0, 1, 0, 1, 0, 1 },
            new byte[] { 1, 0, 1, 0, 1, 0, 1, 0 },
            new byte[] { 0, 1, 0, 1, 0, 1, 0, 1 },
            new byte[] { 1, 0, 1, 0, 1, 0, 1, 0 },
            new byte[] { 0, 1, 0, 1, 0, 1, 0, 1 },
            new byte[] { 1, 0, 1, 0, 1, 0, 1, 0 },
            new byte[] { 0, 1, 0, 1, 0, 1, 0, 1 }
        });
        static readonly Shape mushroom = new Shape("Грибочек", new byte[][] {
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 0 },
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 }
        });
        static readonly Shape heart = new Shape("Сердце поэта", new byte[][] {
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 1, 1, 0, 0, 1, 1, 0 },
            new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 }
        });
        static readonly Shape botva = new Shape("Б - значит ботва", new byte[][] {
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 },
            new byte[] { 0, 0, 1, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 },
            new byte[] { 0, 0, 1, 0, 0, 1, 0, 0 },
            new byte[] { 0, 0, 1, 0, 0, 1, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 },
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }
        });


        static readonly Shape pig = new Shape("Свинтус", new byte[][] {
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 0 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 0 },
            new byte[] { 0, 1, 0, 1, 1, 0, 1, 0 },
            new byte[] { 0, 1, 0, 1, 1, 0, 1, 0 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 0 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 0 },
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }
        });
        static readonly Shape dino = new Shape("Динозаврик", new byte[][] {
            new byte[] { 0, 0, 0, 0, 1, 1, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 1, 1, 0 },
            new byte[] { 0, 0, 0, 1, 0, 0, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 1, 1, 0, 0, 0, 0 },
            new byte[] { 0, 0, 1, 1, 0, 0, 0, 0 },
            new byte[] { 0, 1, 1, 1, 1, 0, 0, 0 },
            new byte[] { 1, 0, 1, 1, 1, 1, 0, 0 }
        });
        static readonly Shape ram = new Shape("Барантус", new byte[][] {
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 1, 1, 0, 0, 1, 1, 0 },
            new byte[] { 0, 1, 0, 0, 0, 0, 1, 0 },
            new byte[] { 0, 1, 0, 0, 0, 0, 1, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 1, 0, 0, 1, 0, 0 }
        });
        static readonly Shape hammer = new Shape("Молот кузнеча", new byte[][] {
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 1, 0 },
            new byte[] { 0, 0, 0, 1, 1, 1, 1, 0 },
            new byte[] { 0, 0, 1, 0, 1, 1, 0, 0 },
            new byte[] { 0, 1, 0, 0, 0, 0, 0, 0 },
            new byte[] { 1, 0, 0, 0, 0, 0, 0, 0 }
        });
        static readonly Shape strawHat = new Shape("Соломня", new byte[][] {
            new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new byte[] { 1, 0, 0, 1, 1, 0, 0, 1 },
            new byte[] { 1, 0, 0, 1, 1, 0, 0, 1 },
            new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 0 },
            new byte[] { 0, 0, 1, 0, 0, 1, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 },
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }
        });


        static readonly Shape tooBigRobot = new Shape("Слишком большой робот", new byte[][] {
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 0 },
            new byte[] { 0, 1, 1, 0, 0, 1, 1, 0 },
            new byte[] { 0, 1, 1, 0, 0, 1, 1, 0 },
            new byte[] { 1, 1, 1, 0, 0, 1, 1, 1 }
        });
        static readonly Shape shanny = new Shape("Шанни, выглядывающий из-за угла", new byte[][] {
            new byte[] { 0, 0, 0, 0, 1, 0, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 1, 0, 0 },
            new byte[] { 0, 0, 1, 1, 0, 0, 0, 0 },
            new byte[] { 1, 1, 1, 0, 0, 0, 0, 0 },
            new byte[] { 1, 0, 1, 1, 0, 0, 0, 0 },
            new byte[] { 1, 0, 1, 1, 0, 0, 0, 0 },
            new byte[] { 1, 1, 1, 0, 0, 0, 0, 0 },
            new byte[] { 1, 1, 0, 0, 0, 0, 0, 0 }
        });
        static readonly Shape ushkanchik = new Shape("Реинкарнация ушканчика", new byte[][] {
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 1, 0, 0, 0, 0, 1, 0 },
            new byte[] { 0, 1, 0, 0, 0, 0, 1, 0 },
            new byte[] { 0, 1, 1, 0, 0, 1, 1, 0 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 0 },
            new byte[] { 0, 1, 0, 1, 1, 0, 1, 0 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 }
        });
        static readonly Shape hellpoker = new Shape("Двуручный Аццкатык", new byte[][] {
            new byte[] { 0, 0, 0, 1, 0, 0, 0, 0 },
            new byte[] { 0, 0, 1, 0, 0, 0, 0, 0 },
            new byte[] { 0, 1, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 1, 0, 1, 0, 0, 0 },
            new byte[] { 0, 0, 0, 1, 0, 0, 0, 1 },
            new byte[] { 0, 0, 1, 0, 1, 0, 1, 0 },
            new byte[] { 0, 1, 0, 0, 0, 1, 0, 0 },
            new byte[] { 1, 0, 0, 0, 0, 0, 0, 0 }
        });
        static readonly Shape booze = new Shape("Синька", new byte[][] {
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 0, 0 },
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }
        });


        static readonly Shape scratchy = new Shape("Царапка", new byte[][] {
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 1, 0, 1, 0, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 0, 0, 0 },
            new byte[] { 0, 0, 1, 1, 1, 0, 0, 1 },
            new byte[] { 0, 0, 0, 1, 0, 0, 1, 0 },
            new byte[] { 0, 0, 1, 1, 1, 0, 0, 1 },
            new byte[] { 0, 1, 1, 1, 1, 1, 0, 1 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 0 }
        });
        static readonly Shape fregate = new Shape("Фрегатус", new byte[][] {
            new byte[] { 0, 0, 0, 0, 1, 1, 0, 0 },
            new byte[] { 0, 0, 0, 1, 0, 1, 0, 0 },
            new byte[] { 0, 0, 0, 1, 0, 1, 0, 0 },
            new byte[] { 0, 0, 0, 1, 0, 1, 0, 0 },
            new byte[] { 1, 0, 0, 0, 1, 1, 0, 0 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 1 },
            new byte[] { 0, 0, 1, 1, 1, 1, 1, 1 },
            new byte[] { 0, 0, 0, 1, 1, 1, 1, 1 }
        });
        static readonly Shape soapStone = new Shape("Мыльный камень", new byte[][] {
            new byte[] { 0, 0, 0, 1, 1, 0, 0, 0 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 0 },
            new byte[] { 1, 0, 1, 0, 0, 1, 0, 1 },
            new byte[] { 1, 0, 0, 0, 0, 0, 0, 1 },
            new byte[] { 0, 1, 1, 1, 1, 1, 1, 0 },
            new byte[] { 1, 0, 1, 1, 1, 1, 0, 1 },
            new byte[] { 0, 0, 1, 0, 0, 1, 0, 0 },
            new byte[] { 0, 1, 0, 0, 0, 0, 1, 0 }
        });
        static readonly Shape kryackchepechkasFriend = new Shape("Друг крепечки", new byte[][] {
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new byte[] { 1, 1, 0, 0, 0, 0, 1, 1 },
            new byte[] { 1, 0, 1, 0, 0, 1, 0, 1 },
            new byte[] { 1, 0, 0, 1, 1, 0, 0, 1 },
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 1 },
            new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }
        });
        static readonly Shape whale = new Shape("Китуша", new byte[][] {
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 1, 1, 1, 0, 0, 0, 0 },
            new byte[] { 0, 0, 1, 0, 0, 0, 0, 0 },
            new byte[] { 0, 1, 1, 1, 0, 0, 1, 1 },
            new byte[] { 1, 0, 0, 0, 1, 1, 1, 1 },
            new byte[] { 1, 0, 1, 0, 0, 0, 1, 0 },
            new byte[] { 1, 0, 0, 0, 0, 1, 0, 0 },
            new byte[] { 0, 1, 1, 1, 1, 0, 0, 0 }
        });
        #endregion Shapes

        bool stop = false;
        bool running = false;
        List<Shape> result = new List<Shape>();
        int totalDistance = 0;
        Shape[] allShapes = new Shape[] { stronghold, chess, mushroom, heart, botva, pig, dino, ram, hammer, strawHat, tooBigRobot, shanny, ushkanchik, hellpoker, booze, scratchy, fregate, soapStone, kryackchepechkasFriend, whale };
        BackgroundWorker bw = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = new List<Shape>();
            totalDistance = 0;
            foreach (Shape shape in allShapes)
                if (shape.Name == comboBox1.Text)
                    result.Add(shape);
            while (result.Count < 20)
            {
                int minDistance = 99999999;
                Shape nextShape = heart;
                foreach (Shape shape in allShapes)
                    if ((!result.Contains(shape)) && (shape.Distance(result[result.Count - 1]) < minDistance))
                    {
                        nextShape = shape;
                        minDistance = shape.Distance(result[result.Count - 1]);
                    }
                result.Add(nextShape);
                totalDistance += minDistance;
            }
          
            richTextBox1.AppendText(GetResultString());
        }

        private string GetResultString()
        {
            string resultString;
            int distanceToDisplay;
            resultString = "Лучшая последовательность: ";
            for (int i = 0; i < 20; i++)
            {
                resultString += result[i].Name + ((i != 19) ? (", ") : (""));
            }
            distanceToDisplay = totalDistance;
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    if (result[0].Field[i][j] == 1)
                        distanceToDisplay++;
            resultString += "\n" + "Всего куличиков: " + distanceToDisplay.ToString() + "\n";
            return resultString;
        }

        class Shape
        {
            public byte[][] Field;
            public string Name;

            public Shape(string Name, byte[][] Field)
            {
                this.Name = Name;
                this.Field = Field;
            }

            public int Distance(Shape to)
            {
                int result = 0;
                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                        if (Field[i][j] != to.Field[i][j])
                            result++;
                return result;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (result.Count != 20)
                return;
            if (!running)
            {
                stop = false;
                running = true;
                bw.DoWork += Bw_DoWork;
                bw.RunWorkerAsync();
                button2.Text = "Стоп";
                button1.Enabled = false;
            }
            else
            {
                stop = true;
                running = false;
            }
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rnd = new Random();
            while (!stop)
            {
                int first = rnd.Next(19) + 1;
                int second = rnd.Next(19) + 1;
                while (first == second)
                    second = rnd.Next(19) + 1;
                Shape buf = result[first];
                result[first] = result[second];
                result[second] = buf;

                int newDistance = 0;
                for (int i = 1; i < 20; i++)
                    newDistance += result[i].Distance(result[i - 1]);

                if (newDistance < totalDistance)
                {
                    totalDistance = newDistance;
                    string resultString = GetResultString();
                    richTextBox1.BeginInvoke((Action)(() => {
                        richTextBox1.AppendText("\n\nНайдено новое решение: \n" + resultString);
                        richTextBox1.SelectionStart = richTextBox1.Text.Length;
                        richTextBox1.ScrollToCaret();
                    }));
                }
                else
                {
                    buf = result[first];
                    result[first] = result[second];
                    result[second] = buf;
                }
            }
            richTextBox1.BeginInvoke((Action)(() => {
                button2.Text = "Итеративное улучшение";
                button1.Enabled = true;
            }));
        }
    }
}
