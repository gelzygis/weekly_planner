#pragma checksum "C:\Users\zygim\source\repos\Weekly_Planner_App_Repo\Main\Current_Week.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "043D3ACC33E22AE398855F791DCE35B651490031EFBF981D4A2CBE8455874EB4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Main
{
    partial class Current_Week : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Current_Week.xaml line 84
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element2).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 3: // Current_Week.xaml line 92
                {
                    this.Monday_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Monday_Button).Click += this.Monday_Button_Click;
                }
                break;
            case 4: // Current_Week.xaml line 106
                {
                    this.Tuesday_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Tuesday_Button).Click += this.Tuesday_Button_Click;
                }
                break;
            case 5: // Current_Week.xaml line 120
                {
                    this.Wednesday_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Wednesday_Button).Click += this.Wednesday_Button_Click;
                }
                break;
            case 6: // Current_Week.xaml line 133
                {
                    this.Thursday_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Thursday_Button).Click += this.Thursday_Button_Click;
                }
                break;
            case 7: // Current_Week.xaml line 146
                {
                    this.Friday_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Friday_Button).Click += this.Friday_Button_Click;
                }
                break;
            case 8: // Current_Week.xaml line 159
                {
                    this.Saturday_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Saturday_Button).Click += this.Saturday_Button_Click;
                }
                break;
            case 9: // Current_Week.xaml line 172
                {
                    this.Sunday_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Sunday_Button).Click += this.Sunday_Button_Click;
                }
                break;
            case 10: // Current_Week.xaml line 63
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element10 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element10).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 11: // Current_Week.xaml line 73
                {
                    this.progressbar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

