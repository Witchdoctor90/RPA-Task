using UiPath.CodedWorkflows.DescriptorIntegration;

namespace RPATask.ObjectRepository
{
    public static class Descriptors
    {
        public static class Chrome__UiBank_Welcome_app
        {
            static string _reference = "0Sm2su6WxUGN-80a4ejXBg/eaajTKFfwEmpVo-oPJH6vA";
            public static _Implementation._Chrome__UiBank_Welcome_app.__Chrome__UiBank_Welcome Chrome__UiBank_Welcome { get; private set; } = new _Implementation._Chrome__UiBank_Welcome_app.__Chrome__UiBank_Welcome();
        }

        public static class UiBankApp
        {
            static string _reference = "0Sm2su6WxUGN-80a4ejXBg/CbdctUZyKEuasaZaLIBwUg";
            public static _Implementation._UiBankApp.__LoginScreen LoginScreen { get; private set; } = new _Implementation._UiBankApp.__LoginScreen();
        }
    }
}

namespace RPATask._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _Chrome__UiBank_Welcome_app._Chrome__UiBank_Welcome
    {
        public class __ProductsLoansCredit_Car_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __ProductsLoansCredit_Car_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "0Sm2su6WxUGN-80a4ejXBg/iT8uEi2PBUKKB3L_hdeueA", DisplayName = "ProductsLoansCredit Car…", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiBank_Welcome_app
    {
        public class __Chrome__UiBank_Welcome : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Chrome__UiBank_Welcome()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "0Sm2su6WxUGN-80a4ejXBg/s5D_7zpXx0mbXsm48K-0dg", DisplayName = "Chrome: UiBank-Welcome", Screen = this};
                ProductsLoansCredit_Car_ = new _Implementation._Chrome__UiBank_Welcome_app._Chrome__UiBank_Welcome.__ProductsLoansCredit_Car_(this, null);
            }

            public _Implementation._Chrome__UiBank_Welcome_app._Chrome__UiBank_Welcome.__ProductsLoansCredit_Car_ ProductsLoansCredit_Car_ { get; private set; }
        }
    }

    namespace _UiBankApp
    {
        public class __LoginScreen : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __LoginScreen()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "0Sm2su6WxUGN-80a4ejXBg/X4eSvvNboEKd4ZAocEurNg", DisplayName = "LoginScreen", Screen = this};
            }
        }
    }
}