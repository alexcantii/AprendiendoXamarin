//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Praticascreem.View.CambiarContraseña.xaml", "View/CambiarContraseña.xaml", typeof(global::Praticascreem.View.CambiarContraseña))]

namespace Praticascreem.View {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("View\\CambiarContraseña.xaml")]
    public partial class CambiarContraseña : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Entry EmailTxt;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Praticascreem.ShowPasswordTriggerAction ShowPasswordActualTrigger;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(CambiarContraseña));
            EmailTxt = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Entry>(this, "EmailTxt");
            ShowPasswordActualTrigger = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Praticascreem.ShowPasswordTriggerAction>(this, "ShowPasswordActualTrigger");
        }
    }
}
