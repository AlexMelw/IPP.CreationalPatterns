namespace CombinedAbstractFactorySingleton
{
    using System;
    using System.Reflection;

    class Program
    {
        static void Main(string[] args)
        {
            IThemeFactory factory = LoadThemeFactory();

            CheckBox checkBox = factory.CreateCheckBox();

            checkBox.Name = "Demo1";

            Console.Out.WriteLine($"checkBox [{checkBox.Name}]'s type is: {checkBox.GetType().Name}");
            checkBox.Check();
            Console.Out.WriteLine($"\ncheckBox's flag state = {(checkBox.Flag ? "Checked" : "Unchecked")}");

            checkBox.Uncheck();
            Console.Out.WriteLine($"\ncheckBox's flag state = {(checkBox.Flag ? "Checked" : "Unchecked")}");

            RadioButton radioButton = factory.CreateRadioButton();
            radioButton.Name = "Demo2";
            radioButton.Value = "777";

            Console.Out.WriteLine($"radio button [{radioButton.Name}]'s type is: {radioButton.GetType().Name}");
            Console.Out.WriteLine($"\nradioButton's [{radioButton.Name}] has value [{radioButton.Value}]");
            radioButton.Select();

            Console.ReadKey();
        }

        private static IThemeFactory LoadThemeFactory()
        {
            string factoryName = Settings.Default.IThemeFactory;
            //return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IThemeFactory;

            IThemeFactory factory = Type.GetType(factoryName)
                .GetProperty("Instance")
                .GetValue(null, null) as IThemeFactory;

            return factory;
        }

        static void PrintHeader(string title)
        {
            Console.WriteLine($"\n++++++++++++++++ {title} ++++++++++++++++++");
        }
    }

    interface IThemeFactory
    {
        CheckBox CreateCheckBox();
        RadioButton CreateRadioButton();
    }

    abstract class Control
    {
        public string Name { get; set; }
    }

    abstract class RadioButton : Control
    {
        public string Value { get; set; }
        public abstract void Select();
    }

    abstract class CheckBox : Control
    {
        public bool Flag { get; protected set; }
        public abstract void Check();
        public abstract void Uncheck();
    }

    class DarkRadioButton : RadioButton
    {
        public override void Select()
        {
            Console.Out.WriteLine($"Dark Radio Button [{Name}] is selected.");
        }
    }

    class LightRadioButton : RadioButton
    {
        public override void Select()
        {
            Console.Out.WriteLine($"Light Radio Button [{Name}] is selected.");
        }
    }

    class DarkCheckBox : CheckBox
    {
        public override void Check()
        {
            Flag = true;
            Console.Out.WriteLine($"Dark Check-box [{Name}] is checked.");
        }

        public override void Uncheck()
        {
            Flag = false;
            Console.Out.WriteLine($"Dark Check-box [{Name}] is unchecked.");
        }
    }

    class LightCheckBox : CheckBox
    {
        public override void Check()
        {
            Console.Out.WriteLine($"Light Check-box [{Name}] is checked.");
        }

        public override void Uncheck()
        {
            Flag = false;
            Console.Out.WriteLine($"Dark Check-box [{Name}] is unchecked.");
        }
    }
}