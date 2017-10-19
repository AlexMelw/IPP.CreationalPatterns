namespace CombinedAbstractFactorySingleton
{
    using System;
    using System.Reflection;
    using GUIElements;
    using Interfaces;

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
}