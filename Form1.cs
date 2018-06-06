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
        static readonly Shape empty = new Shape("Пусто", new byte[][] {
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }
        });
        #endregion Shapes

        List<Shape> result = new List<Shape>();
        int totalDistance = 0;
        Shape[] allShapes = new Shape[] { empty, stronghold, chess, mushroom, heart, botva, pig, dino, ram, hammer, strawHat, tooBigRobot, shanny, ushkanchik, hellpoker, booze, scratchy, fregate, soapStone, kryackchepechkasFriend, whale };
        CheckBox[] allCheckboxes;
        BackgroundWorker bw = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allCheckboxes = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20 };

            foreach (Shape shape in allShapes)
                comboBox1.Items.Add(shape.Name);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int createCost = int.Parse(textBox1.Text);
            int destroyCost = int.Parse(textBox2.Text);
            int min = 999999999;
            result = new List<Shape>();
            result.Add(empty);
            foreach (CheckBox checkBox in allCheckboxes)
                if (checkBox.Checked && checkBox.Text != comboBox1.Text)
                    result.Add(GetShapeByName(checkBox.Text));
            if (comboBox1.Text != empty.Name)
                result.Add(GetShapeByName(comboBox1.Text));
            int fixedShapeCount = result.Count;
            totalDistance = 0;
            for (int i = 1; i < fixedShapeCount; i++)
                totalDistance += result[i - 1].Distance(result[i], createCost, destroyCost);
            while (result.Count < 21)
            {
                int minDistance = 99999999;
                Shape nextShape = heart;
                foreach (Shape shape in allShapes)
                    if ((!result.Contains(shape)) && (result[result.Count - 1].Distance(shape, createCost, destroyCost) < minDistance))
                    {
                        nextShape = shape;
                        minDistance = result[result.Count - 1].Distance(shape, createCost, destroyCost);
                    }
                result.Add(nextShape);
                totalDistance += minDistance;
            }

            Random rnd = new Random();
            bool stop = false;
            while (!stop)
            {
                stop = true;
                for (int i = fixedShapeCount; i < 21; i++)
                    for (int j = i + 1; j < 21; j++)
                    {
                        Shape buf = result[i];
                        result[i] = result[j];
                        result[j] = buf;

                        int newDistance = 0;
                        for (int k = 1; k < 21; k++)
                            newDistance += result[k - 1].Distance(result[k], createCost, destroyCost);

                        if (newDistance < totalDistance)
                        {
                            totalDistance = newDistance;
                            stop = false;
                        }
                        else
                        {
                            buf = result[i];
                            result[i] = result[j];
                            result[j] = buf;
                        }
                    }
            }

            if (totalDistance < min)
                min = totalDistance;

            richTextBox1.AppendText(GetResultString(fixedShapeCount, createCost, destroyCost));
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private string GetResultString(int fixedShapeCount, int createCost, int destroyCost)
        {
            string resultString;
            resultString = "Лучшая последовательность:\n";
            int totalDistance = 0;
            for (int i = fixedShapeCount; i < 21; i++)
            {
                totalDistance += result[i - 1].Distance(result[i], createCost, destroyCost);
                resultString += (i - fixedShapeCount + 1).ToString() + ". " + result[i].Name + "\n";
            }
            resultString += "\n" + "Требуется энергии: " + totalDistance.ToString() + "\n\n\n";
            return resultString;
        }

        Shape GetShapeByName(string name)
        {
            foreach (Shape shape in allShapes)
                if (shape.Name == name)
                    return shape;
            return null;
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

            public int Distance(Shape to, int createCost, int destroyCost)
            {
                int result = 0;
                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                    {
                        if (Field[i][j] < to.Field[i][j])
                            result += createCost;
                        if (Field[i][j] > to.Field[i][j])
                            result += destroyCost;
                    }
                return result;
            }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}
