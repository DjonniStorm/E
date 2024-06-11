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