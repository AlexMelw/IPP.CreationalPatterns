namespace CombinedAbstractFactorySingleton.Factories
{
    using System;

    class DarkThemeFactory : IThemeFactory
    {
        private static readonly Lazy<DarkThemeFactory> LazyInstace =
            new Lazy<DarkThemeFactory>(() => new DarkThemeFactory(), true);

        public static DarkThemeFactory Instance => LazyInstace.Value;

        #region CONSTRUCTORS

        private DarkThemeFactory() { }

        #endregion

        public CheckBox CreateCheckBox() => new DarkCheckBox();

        public RadioButton CreateRadioButton() => new DarkRadioButton();
    }
}