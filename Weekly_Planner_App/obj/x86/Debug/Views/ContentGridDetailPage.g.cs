﻿#pragma checksum "C:\Users\zygim\source\repos\Weekly_Planner_App_Repo\Weekly_Planner_App\Views\ContentGridDetailPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CED20616355F730A96C725A71F486F7FDFEBE79093348A9A70CD1C4B56525972"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weekly_Planner_App.Views
{
    partial class ContentGridDetailPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(global::Windows.UI.Xaml.Controls.FontIcon obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Glyph = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ContentGridDetailPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IContentGridDetailPage_Bindings
        {
            private global::Weekly_Planner_App.Views.ContentGridDetailPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj11;
            private global::Windows.UI.Xaml.Controls.TextBlock obj12;
            private global::Windows.UI.Xaml.Controls.TextBlock obj15;
            private global::Windows.UI.Xaml.Controls.TextBlock obj16;
            private global::Windows.UI.Xaml.Controls.FontIcon obj17;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6TextDisabled = false;
            private static bool isobj11TextDisabled = false;
            private static bool isobj12TextDisabled = false;
            private static bool isobj15TextDisabled = false;
            private static bool isobj16TextDisabled = false;
            private static bool isobj17GlyphDisabled = false;

            private ContentGridDetailPage_obj1_BindingsTracking bindingsTracking;

            public ContentGridDetailPage_obj1_Bindings()
            {
                this.bindingsTracking = new ContentGridDetailPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 62 && columnNumber == 25)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 84 && columnNumber == 91)
                {
                    isobj11TextDisabled = true;
                }
                else if (lineNumber == 79 && columnNumber == 91)
                {
                    isobj12TextDisabled = true;
                }
                else if (lineNumber == 72 && columnNumber == 91)
                {
                    isobj15TextDisabled = true;
                }
                else if (lineNumber == 67 && columnNumber == 91)
                {
                    isobj16TextDisabled = true;
                }
                else if (lineNumber == 53 && columnNumber == 29)
                {
                    isobj17GlyphDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // Views\ContentGridDetailPage.xaml line 56
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 11: // Views\ContentGridDetailPage.xaml line 84
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 12: // Views\ContentGridDetailPage.xaml line 79
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 15: // Views\ContentGridDetailPage.xaml line 72
                        this.obj15 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 16: // Views\ContentGridDetailPage.xaml line 67
                        this.obj16 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 17: // Views\ContentGridDetailPage.xaml line 49
                        this.obj17 = (global::Windows.UI.Xaml.Controls.FontIcon)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IContentGridDetailPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Weekly_Planner_App.Views.ContentGridDetailPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Weekly_Planner_App.Views.ContentGridDetailPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::Weekly_Planner_App.ViewModels.ContentGridDetailViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Item(obj.Item, phase);
                    }
                }
            }
            private void Update_ViewModel_Item(global::Weekly_Planner_App.Core.Models.SampleOrder obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Item_Company(obj.Company, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Item_OrderTotal(obj.OrderTotal, phase);
                        this.Update_ViewModel_Item_ShipTo(obj.ShipTo, phase);
                        this.Update_ViewModel_Item_OrderDate(obj.OrderDate, phase);
                        this.Update_ViewModel_Item_Status(obj.Status, phase);
                        this.Update_ViewModel_Item_Symbol(obj.Symbol, phase);
                    }
                }
            }
            private void Update_ViewModel_Item_Company(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ContentGridDetailPage.xaml line 56
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                    }
                }
            }
            private void Update_ViewModel_Item_OrderTotal(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ContentGridDetailPage.xaml line 84
                    if (!isobj11TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj.ToString(), null);
                    }
                }
            }
            private void Update_ViewModel_Item_ShipTo(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ContentGridDetailPage.xaml line 79
                    if (!isobj12TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj, null);
                    }
                }
            }
            private void Update_ViewModel_Item_OrderDate(global::System.DateTime obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ContentGridDetailPage.xaml line 72
                    if (!isobj15TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj15, obj.ToString(), null);
                    }
                }
            }
            private void Update_ViewModel_Item_Status(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ContentGridDetailPage.xaml line 67
                    if (!isobj16TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj16, obj, null);
                    }
                }
            }
            private void Update_ViewModel_Item_Symbol(global::System.Char obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ContentGridDetailPage.xaml line 49
                    if (!isobj17GlyphDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(this.obj17, obj.ToString(), null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ContentGridDetailPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ContentGridDetailPage_obj1_Bindings> weakRefToBindingObj; 

                public ContentGridDetailPage_obj1_BindingsTracking(ContentGridDetailPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ContentGridDetailPage_obj1_Bindings>(obj);
                }

                public ContentGridDetailPage_obj1_Bindings TryGetBindingObject()
                {
                    ContentGridDetailPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    ContentGridDetailPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Weekly_Planner_App.ViewModels.ContentGridDetailViewModel obj = sender as global::Weekly_Planner_App.ViewModels.ContentGridDetailViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Item(obj.Item, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Item":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Item(obj.Item, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Weekly_Planner_App.ViewModels.ContentGridDetailViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::Weekly_Planner_App.ViewModels.ContentGridDetailViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\ContentGridDetailPage.xaml line 10
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\ContentGridDetailPage.xaml line 31
                {
                    this.contentScroll = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 4: // Views\ContentGridDetailPage.xaml line 34
                {
                    this.contentPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5: // Views\ContentGridDetailPage.xaml line 38
                {
                    this.itemHero = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6: // Views\ContentGridDetailPage.xaml line 56
                {
                    this.title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Views\ContentGridDetailPage.xaml line 64
                {
                    this.propertiesGroup1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 8: // Views\ContentGridDetailPage.xaml line 76
                {
                    this.propertiesGroup2 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 9: // Views\ContentGridDetailPage.xaml line 77
                {
                    this.shipToGroup = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 10: // Views\ContentGridDetailPage.xaml line 82
                {
                    this.orderTotalGroup = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 13: // Views\ContentGridDetailPage.xaml line 65
                {
                    this.statusGroup = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 14: // Views\ContentGridDetailPage.xaml line 70
                {
                    this.orderDateGroup = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
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
            switch(connectionId)
            {
            case 1: // Views\ContentGridDetailPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ContentGridDetailPage_obj1_Bindings bindings = new ContentGridDetailPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

