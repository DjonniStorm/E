//Вариант 3
//№1
private void button1_Click(object sender, EventArgs e)
{
    string userText = textBoxMethod1.Text;
    //просто чтобы видеть значение которое ввёл пользователь
    listBoxUserData.Items.Insert(listBoxUserData.Items.Count, userText);
    var a = new Task1();
    //вставляем результат от метода1
    listBoxResult.Items.Insert(listBoxResult.Items.Count, a.method1(Convert.ToInt32(userText.Trim())));
    //посмотреть что там за массив то был
    listBoxRandomArray.Items.Insert(listBoxRandomArray.Items.Count, a.Text);
    //собираем в массив те два числа, ввёдённые пользователем методом посмотренным в интернете
    int[] result = Array.ConvertAll(textBoxMethod2.Text.Split(' '), Int32.Parse);
    //второй метод и результат от него
    listBoxResult.Items.Insert(listBoxResult.Items.Count, a.method2(result[0], result[1]));
    //также смотрим что там был за массив
    listBoxRandomArray.Items.Insert(listBoxRandomArray.Items.Count, a.Text);

}
class Task1
{
    Random random = new();
    private int[] array;
    private string text;
    // свойсто чтобы получить какой массив там был
    public string Text
    { 
        get => text;
    }
    /// <summary>
    /// сумма положительных элементов
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public string method1(int n)
    {
        array = new int[n];
        text = "";
        //заполняем рандомом
        for (int i = 0; i < n; i++) array[i] = random.Next(-10, 10);
        //просто чтобы понять, что за массив получился
        foreach (int i in array) text += $"{i}  ";
        //задание
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
    /// <param name="n">размер массива</param>
    /// <param name="userValue">пользовательское число</param>
    /// <returns></returns>
    public string method2(int n, int userValue)
    {
        array = new int[n];
        text = "";
        //заполняем рандомом
        for (int i = 0; i < n; i++) array[i] = random.Next(-10, 10);
        //просто чтобы понять, что за массив получился
        foreach (int i in array) text += $"{i}  ";
        //задание
        int counter = 0;
        foreach (int i in array)
        {
            if (i < userValue && i % 2 != 0) counter++;
        }
        return $"{counter}";
    }
}

//№2
private void button1_Click(object sender, EventArgs e)
{
    string userText = textBoxMethod1.Text;
    //просто чтобы видеть значение которое ввёл пользователь
    listBoxUserData.Items.Insert(listBoxUserData.Items.Count, userText);
    
    var a = new Task1(Convert.ToInt32(userText));
    
    //вставляем результат от метода1
    listBoxResult.Items.Insert(listBoxResult.Items.Count, a.method());
    
    //посмотреть что там за массив то был
    listBoxRandomArray.Items.Insert(listBoxRandomArray.Items.Count, a.Text);

    //второй метод и результат от него
    listBoxResult.Items.Insert(listBoxResult.Items.Count, a.method(Convert.ToInt32(textBoxMethod2.Text)));

    //второй раз массив вставлять уже не имеет смысла

}
class Task1
{
    Random random = new();
    private int[] array;
    private string text;
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
        return $"{counter}";
    }
}

//№3
private void button1_Click(object sender, EventArgs e)
{
    string userText = textBoxMethod1.Text;
    //просто чтобы видеть значение которое ввёл пользователь
    listBoxUserData.Items.Insert(listBoxUserData.Items.Count, userText);
    
    var a = new Task3List(Convert.ToInt32(userText));
    
    //вставляем результат от метода1
    listBoxResult.Items.Insert(listBoxResult.Items.Count, a.method());
    
    //посмотреть что там за массив то был
    listBoxRandomArray.Items.Insert(listBoxRandomArray.Items.Count, a.Text);

    //второй метод и результат от него
    listBoxResult.Items.Insert(listBoxResult.Items.Count, a.method(Convert.ToInt32(textBoxMethod2.Text)));

    //чек индексатора
    listBoxResult.Items.Insert(listBoxResult.Items.Count, a[5]);

}
class Task1 : ITask3
{
    Random random = new();
    private int[] array;
    private string text;
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
        return $"{counter}";
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
}
class Task3List : ITask3
{
    Random random = new();
    List<int> list;
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
        return $"{counter}";
    }
}

//№4

private void button1_Click(object sender, EventArgs e)
{
    Random random = new();
    for (int i = 0; i < random.Next(5, 10); i++)
    {
        ITask3 array = new Task1(random.Next(0, 15));
        listBoxResult.Items.Insert(listBoxResult.Items.Count, array.Name);
    }
    for (int i = 0; i < random.Next(5, 10); i++)
    {
        ITask3 list = new Task3List(random.Next(0, 15));
        listBoxResult.Items.Insert(listBoxResult.Items.Count, list.Name);
    }
}

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
            return $"{counter}";
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
            return $"{counter}";
        }
    }

}


//№5

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


//№6
private void buttonSave_Click(object sender, EventArgs e)
{
    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
    {
        string filename = saveFileDialog1.FileName;
        if (File.Exists(filename))
        {
            File.Delete(filename);
        }
        using (StreamWriter writer = new (filename))
        {
            StringBuilder builder = new ();
            foreach (var item in listBoxSave.Items)
            {
                builder.Append(item.ToString());
                builder.Append(Environment.NewLine); //из лаб 
            }
            writer.Write(builder);
        }
    }
}

№7