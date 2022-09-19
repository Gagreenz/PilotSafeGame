using System;

namespace PilotSafeGame
{
    public partial class Form1 : Form
    {
        public List<Button> Field;
        int size;
        public Form1()
        {
            InitializeComponent();
            Field = new List<Button>();
        }

        private void StartClickHandler(object sender, EventArgs e)
        {
            if (Field.Count > 0)
                RemoveValves();
            size = (int)FieldSize.Value;
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    //  Начальное значение поля с венитлями
                    //  138 растояние по x  
                    //    7 растояние по у
                    Field.Add(CreateValve(138 + x * 64, 7 + y * 64));
                }
            }
            this.Controls.AddRange(Field.ToArray());

            
            while(IsGameOver())
            {
                Shake();
            }
        }

        private void Shake()
        {
            var rndValue = new List<int>(size*size / 2);
            Random rnd = new Random();
            for (int i = 0; i < size * size; i += rnd.Next(1, 4))
            {
                rndValue.Add(i);
            }

            rndValue.Shuffle();

            foreach(var value in rndValue)
            {
                RollValve(value);
            }
        }
        private void OnClickHandler(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            if (button == null)
                throw new Exception("Почему то функцию кнопки вызвала не кнопка...");
            var senderButtonIndex = Field.FindIndex(b => b.Name == button.Name);
            RollValve(senderButtonIndex);

            if (IsGameOver()) MessageBox.Show("Вы победили!");
        }
        public bool IsGameOver()
        {
            //Возьмем значение первого элемента в качестве проверки 
            var correctValue = Field[0].Text;
            for (int i = 0; i < Field.Count; i++)
            {
                if (Field[i].Text != correctValue) return false;
            }
            return true;
        }
        private void RollValve(int index)
        {
            int row = index / size;
            int col = index % size;
            for (int i = 0; i < size; i++)
            {
                SetValve(size * row + i);
            }
            for (int i = 0; i < size; i++)
            {
                if (col + i * size == index)
                    continue;
                SetValve(col + i * size);
            }
            
        }

        private void SetValve(int i)
        {
            if (Field[i].Text == "--")
                Field[i].Text = "I";
            else
                Field[i].Text = "--";
        }

        private Button CreateValve(int x,int y)
        {
            var button = new System.Windows.Forms.Button();

            button.Location = new System.Drawing.Point(x, y);
            button.Name = $"Valve X:{x}Y:{y}";
            button.Tag = "Valve";
            button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button.Size = new System.Drawing.Size(64, 64);
            button.Text = "I";
            button.UseVisualStyleBackColor = true;
            button.Click += new System.EventHandler(OnClickHandler);
            
            return button;
        }
        private void RemoveValves()
        {
            foreach(var button in Field)
            {
                this.Controls.RemoveByKey(button.Name);
            }
            Field.Clear();
        }
    }
}