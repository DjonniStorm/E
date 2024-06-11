namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxClass = new ListBox();
            buttonEventMethod1 = new Button();
            buttonEventMethod2 = new Button();
            buttonEventCall1 = new Button();
            buttonEventCall2 = new Button();
            buttonEventUnSub1 = new Button();
            buttonEventUnSub2 = new Button();
            listBoxResult = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxClass
            // 
            listBoxClass.FormattingEnabled = true;
            listBoxClass.ItemHeight = 15;
            listBoxClass.Location = new Point(402, 46);
            listBoxClass.Name = "listBoxClass";
            listBoxClass.Size = new Size(120, 94);
            listBoxClass.TabIndex = 0;
            // 
            // buttonEventMethod1
            // 
            buttonEventMethod1.Location = new Point(39, 90);
            buttonEventMethod1.Name = "buttonEventMethod1";
            buttonEventMethod1.Size = new Size(127, 33);
            buttonEventMethod1.TabIndex = 1;
            buttonEventMethod1.Text = "Добавить событие 1";
            buttonEventMethod1.UseVisualStyleBackColor = true;
            buttonEventMethod1.Click += buttonEventMethod1_Click;
            // 
            // buttonEventMethod2
            // 
            buttonEventMethod2.Location = new Point(39, 129);
            buttonEventMethod2.Name = "buttonEventMethod2";
            buttonEventMethod2.Size = new Size(127, 34);
            buttonEventMethod2.TabIndex = 2;
            buttonEventMethod2.Text = "Добавить событие 2";
            buttonEventMethod2.UseVisualStyleBackColor = true;
            buttonEventMethod2.Click += buttonEventMethod2_Click;
            // 
            // buttonEventCall1
            // 
            buttonEventCall1.Location = new Point(39, 211);
            buttonEventCall1.Name = "buttonEventCall1";
            buttonEventCall1.Size = new Size(127, 34);
            buttonEventCall1.TabIndex = 3;
            buttonEventCall1.Text = "Вызвать 1";
            buttonEventCall1.UseVisualStyleBackColor = true;
            buttonEventCall1.Click += buttonEventCall1_Click;
            // 
            // buttonEventCall2
            // 
            buttonEventCall2.Location = new Point(39, 251);
            buttonEventCall2.Name = "buttonEventCall2";
            buttonEventCall2.Size = new Size(127, 34);
            buttonEventCall2.TabIndex = 4;
            buttonEventCall2.Text = "Вызвать 2";
            buttonEventCall2.UseVisualStyleBackColor = true;
            buttonEventCall2.Click += buttonEventCall2_Click;
            // 
            // buttonEventUnSub1
            // 
            buttonEventUnSub1.Location = new Point(231, 287);
            buttonEventUnSub1.Name = "buttonEventUnSub1";
            buttonEventUnSub1.Size = new Size(127, 34);
            buttonEventUnSub1.TabIndex = 5;
            buttonEventUnSub1.Text = "Отписаться 1";
            buttonEventUnSub1.UseVisualStyleBackColor = true;
            buttonEventUnSub1.Click += buttonEventUnSub1_Click;
            // 
            // buttonEventUnSub2
            // 
            buttonEventUnSub2.Location = new Point(231, 327);
            buttonEventUnSub2.Name = "buttonEventUnSub2";
            buttonEventUnSub2.Size = new Size(127, 34);
            buttonEventUnSub2.TabIndex = 6;
            buttonEventUnSub2.Text = "Отписаться 2";
            buttonEventUnSub2.UseVisualStyleBackColor = true;
            buttonEventUnSub2.Click += buttonEventUnSub2_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 15;
            listBoxResult.Location = new Point(448, 294);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(283, 94);
            listBoxResult.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 28);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 9;
            label1.Text = "Тут пользовательское";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBoxResult);
            Controls.Add(buttonEventUnSub2);
            Controls.Add(buttonEventUnSub1);
            Controls.Add(buttonEventCall2);
            Controls.Add(buttonEventCall1);
            Controls.Add(buttonEventMethod2);
            Controls.Add(buttonEventMethod1);
            Controls.Add(listBoxClass);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxClass;
        private Button buttonEventMethod1;
        private Button buttonEventMethod2;
        private Button buttonEventCall1;
        private Button buttonEventCall2;
        private Button buttonEventUnSub1;
        private Button buttonEventUnSub2;
        private ListBox listBoxResult;
        private TextBox textBox1;
        private Label label1;
    }
}
