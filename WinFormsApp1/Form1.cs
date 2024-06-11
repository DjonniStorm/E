using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        listBoxClass.Items.Insert(listBoxClass.Items.Count, "Массив");
        listBoxClass.Items.Insert(listBoxClass.Items.Count, "Список");
    }
    public event Func<string> func1;
    public event Func<int, string> func2;

    class Task1 : ITask3
    {
        Random random = new();
        private int[] array;
        private string text;

        private int size = 0;
        string ITask3.Name
        {
            get => $"Array {size}";
        }
        // свойсто чтобы получить какой массив там был
        public string Text
        {
            get => text;
        }
        public Task1(int n)
        {
            n =
                n > 10 ?
                n
                :
                random.Next(10, 20);
            size = n;
            array = new int[n];
            text = "";
            //заполняем рандомом
            for (int i = 0; i < n; i++) array[i] = random.Next(-10, 10);
            //просто чтобы понять, что за массив получился
            foreach (int i in array) text += $"{i}  ";
        }
        /// <summary>
        /// сумма положительных элементов
        /// </summary>
        /// <returns></returns>
        public string method()
        {
            int sum = 0;
            foreach (int i in array)
            {
                if (i > 0)
                {
                    sum += i;
                }
            }
            return $"{sum}";
        }
        /// <summary>
        /// Количество нечётных элементов, меньше пользовательского числа
        /// </summary>
        /// <param name="userValue">пользовательское число</param>
        /// <returns></returns>
        public string method(int userValue)
        {
            //задание
            int counter = 0;
            foreach (int i in array)
            {
                if (i < userValue && i % 2 != 0) counter++;
            }
            return $"{counter} ))";
        }
        public string this[int index]
        {
            get
            {
                if (index > 0 && index < array.Length)
                {
                    return array[index].ToString();
                }
                return "";
            }
        }
    }
    interface ITask3
    {
        string method();
        string method(int userValue);
        string this[int index]
        {
            get;
        }
        string Name { get; }
        string Text { get; }
    }
    class Task3List : ITask3
    {
        Random random = new();
        List<int> list;
        string ITask3.Name
        {
            get => $"List {size}";
        }
        private int size = 0;

        private string text;
        // свойсто чтобы получить какой массив там был
        public string Text
        {
            get => text;
        }
        public Task3List(int n)
        {
            n =
                n > 10 ?
                n
                :
                random.Next(10, 20);
            size = n;
            list = new(n);
            //заполняем рандомом
            for (int i = 0; i < n; i++) list.Add(random.Next(-10, 10));
            //просто чтобы понять, что за массив получился
            foreach (int i in list) text += $"{i}  ";
        }
        public string this[int index]
        {
            get
            {
                if (index > 0 && index < list.Count)
                {
                    return list[index].ToString();
                }
                return "";
            }
        }

        public string method()
        {
            int sum = 0;
            foreach (int i in list)
            {
                if (i > 0)
                {
                    sum += i;
                }
            }
            return $"{sum}";
        }

        public string method(int userValue)
        {
            //задание
            int counter = 0;
            foreach (int i in list)
            {
                if (i < userValue && i % 2 != 0) counter++;
            }
            return $"{counter} []";
        }
        public string met(int a)
        {
            return $"{a}";
        }
    }

    private void buttonEventMethod1_Click(object sender, EventArgs e)
    {
        ITask3 interf;
        switch (listBoxClass.SelectedIndex)
        {
            case 0:
                interf = new Task1(Convert.ToInt32(textBox1.Text));
                func1 += interf.method;
                //просто чтобы массив посмотреть
                listBoxResult.Items.Insert(listBoxResult.Items.Count, interf.Text);
                break;
            case 1:
                interf = new Task3List(Convert.ToInt32(textBox1.Text));
                func1 += interf.method;
                listBoxResult.Items.Insert(listBoxResult.Items.Count, interf.Text);
                break;
            default: break;
        }
    }

    private void buttonEventMethod2_Click(object sender, EventArgs e)
    {
        ITask3 interf;
        switch (listBoxClass.SelectedIndex)
        {
            case 0:
                interf = new Task1(Convert.ToInt32(textBox1.Text));
                // func2 += (x) => interf.method(x);
                func2 += interf.method;
                listBoxResult.Items.Insert(listBoxResult.Items.Count, interf.Text);
                break;
            case 1:
                interf = new Task3List(Convert.ToInt32(textBox1.Text));
                func2 += interf.method;
                listBoxResult.Items.Insert(listBoxResult.Items.Count, interf.Text);
                break;
            default: break;
        }
    }

    private void buttonEventCall1_Click(object sender, EventArgs e)
    {
        if (func1 != null)
        {
            listBoxResult.Items.Insert(listBoxResult.Items.Count, func1.Invoke());

        }
    }

    private void buttonEventCall2_Click(object sender, EventArgs e)
    {
        if (func2 != null)
        {
            listBoxResult.Items.Insert(listBoxResult.Items.Count, func2.Invoke(Convert.ToInt32(textBox1.Text))); //откуда брать значения
                                                                                                                 //для метода хз, поэтому так
        }
    }

    private void buttonEventUnSub1_Click(object sender, EventArgs e)
    {
        if (func1 == null) return;
        func1 -= func1; //вроде работает
    }
    private void buttonEventUnSub2_Click(object sender, EventArgs e)
    {
        if (func2 == null) return;
        func2 -= func2;
    }
}
