namespace CombinedAbstractFactorySingleton.Factories
{
    using System;
    using GUIElements;
    using Interfaces;

    class LightThemeFactory : IThemeFactory
    {
        private static readonly Lazy<LightThemeFactory> LazyInstance =
            new Lazy<LightThemeFactory>(() => new LightThemeFactory(), true);

        public static LightThemeFactory Instance => LazyInstance.Value;

        #region CONSTRUCTORS

        private LightThemeFactory() { }

        #endregion

        public CheckBox CreateCheckBox() => new LightCheckBox();

        public RadioButton CreateRadioButton() => new LightRadioButton();
    }
}