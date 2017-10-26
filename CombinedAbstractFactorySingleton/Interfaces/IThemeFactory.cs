namespace CombinedAbstractFactorySingleton.Interfaces
{
    using GUIElements;

    interface IThemeFactory
    {
        CheckBox CreateCheckBox();
        RadioButton CreateRadioButton();
    }
}