namespace CombinedAbstractFactorySingleton.GUIElements
{
    abstract class RadioButton : Control
    {
        public string Value { get; set; }
        public abstract void Select();
    }
}