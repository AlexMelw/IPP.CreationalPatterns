namespace CombinedAbstractFactorySingleton.GUIElements {
    abstract class CheckBox : Control
    {
        public bool Flag { get; protected set; }
        public abstract void Check();
        public abstract void Uncheck();
    }
}