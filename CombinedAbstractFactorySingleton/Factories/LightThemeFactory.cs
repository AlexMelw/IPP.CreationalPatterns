namespace CombinedAbstractFactorySingleton.Factories
{
    class LightThemeFactory : IThemeFactory
    {
        public CheckBox CreateCheckBox() => new LightCheckBox();

        public RadioButton CreateRadioButton() => new LightRadioButton();
    }
}