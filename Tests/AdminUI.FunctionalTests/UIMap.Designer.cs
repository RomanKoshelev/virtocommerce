﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace AdminUI.FunctionalTests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// OpenAdmin - Use 'OpenAdminParams' to pass parameters into this method.
        /// </summary>
        public void OpenAdmin()
        {
            #region Variable Declarations
            WpfTabList uIMainRegionTabList = this.UIWpfWindow.UIMainRegionTabList;
            WpfEdit uIItemEdit = this.UIWpfWindow.UIMainRegionTabList.UIVirtoCommerceManagemTabPage.UIAdminText.UIItemEdit;
            #endregion

            // Launch 'C:\Virto\VCF\src\CommerceFoundation.Presentation\Admin\Presentation.Application\bin\Debug\VirtoCommerce.exe'
            ApplicationUnderTest uIWpfWindow = ApplicationUnderTest.Launch(this.OpenAdminParams.UIWpfWindowExePath, this.OpenAdminParams.UIWpfWindowAlternateExePath);

            // Click 'MainRegion' tab list
            Mouse.Click(uIMainRegionTabList, new Point(121, 338));

            // Type 'http://localhost/store' in text box numbered 3 next to 'admin' label
            uIItemEdit.Text = this.OpenAdminParams.UIItemEditText;

            // Click 'MainRegion' tab list
            Mouse.Click(uIMainRegionTabList, new Point(631, 394));
        }
        
        /// <summary>
        /// OpenCatalog
        /// </summary>
        public void OpenCatalog()
        {
            #region Variable Declarations
            WpfButton uIShowmainmenuButton = this.UIWpfWindow.UIShowmainmenuButton;
            WpfCustom uIItemCustom = this.UIWpfWindow.UIMenuRegionList.UIVirtoCommerceManagemListItem.UIBtnButton.UIItemCustom;
            #endregion

            // Click 'Show main menu' button
            Mouse.Click(uIShowmainmenuButton, new Point(13, 14));

            // Click custom control
            Mouse.Click(uIItemCustom, new Point(55, 31));
        }
        
        /// <summary>
        /// CreateTestCatalog - Use 'CreateTestCatalogParams' to pass parameters into this method.
        /// </summary>
        public void CreateTestCatalog()
        {
            #region Variable Declarations
            WpfTabList uIMainRegionTabList1 = this.UIWpfWindow.UIMainRegionTabList1;
            WpfEdit uIItemEdit = this.UIWpfWindow.UIVirtoCommerceManagemPane.UICatalogidText.UIItemEdit;
            WpfEdit uIItemEdit1 = this.UIWpfWindow.UIVirtoCommerceManagemPane.UICatalognameText.UIItemEdit;
            WpfComboBox uIItemComboBox = this.UIWpfWindow.UIVirtoCommerceManagemPane.UIDefaultlanguageText.UIItemComboBox;
            WpfButton uIFinishButton = this.UIWpfWindow.UIFinishButton;
            #endregion

            // Click 'MainRegion' tab list
            Mouse.Click(uIMainRegionTabList1, new Point(1768, 152));

            // Type 'TestCatalog' in first text box next to '* Catalog id:' label
            uIItemEdit.Text = this.CreateTestCatalogParams.UIItemEditText;

            // Type 'Test catalog' in first text box next to '* Catalog name:' label
            uIItemEdit1.Text = this.CreateTestCatalogParams.UIItemEditText1;

            // Last action on list item was not recorded because the control does not have any good identification property.

            // Last action on list item was not recorded because the control does not have any good identification property.

            // Click first combo box next to '* Default language:' label
            Mouse.Click(uIItemComboBox, new Point(384, 14));

            // Last action on list item was not recorded because the control does not have any good identification property.

            // Click 'Finish' button
            Mouse.Click(uIFinishButton, new Point(50, 15));
        }
        
        #region Properties
        public virtual OpenAdminParams OpenAdminParams
        {
            get
            {
                if ((this.mOpenAdminParams == null))
                {
                    this.mOpenAdminParams = new OpenAdminParams();
                }
                return this.mOpenAdminParams;
            }
        }
        
        public virtual CreateTestCatalogParams CreateTestCatalogParams
        {
            get
            {
                if ((this.mCreateTestCatalogParams == null))
                {
                    this.mCreateTestCatalogParams = new CreateTestCatalogParams();
                }
                return this.mCreateTestCatalogParams;
            }
        }
        
        public UIWpfWindow UIWpfWindow
        {
            get
            {
                if ((this.mUIWpfWindow == null))
                {
                    this.mUIWpfWindow = new UIWpfWindow();
                }
                return this.mUIWpfWindow;
            }
        }
        #endregion
        
        #region Fields
        private OpenAdminParams mOpenAdminParams;
        
        private CreateTestCatalogParams mCreateTestCatalogParams;
        
        private UIWpfWindow mUIWpfWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'OpenAdmin'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class OpenAdminParams
    {
        
        #region Fields
        /// <summary>
        /// Launch 'C:\Virto\VCF\src\CommerceFoundation.Presentation\Admin\Presentation.Application\bin\Debug\VirtoCommerce.exe'
        /// </summary>
        public string UIWpfWindowExePath = "C:\\Virto\\VCF\\src\\CommerceFoundation.Presentation\\Admin\\Presentation.Application\\b" +
            "in\\Debug\\VirtoCommerce.exe";
        
        /// <summary>
        /// Launch 'C:\Virto\VCF\src\CommerceFoundation.Presentation\Admin\Presentation.Application\bin\Debug\VirtoCommerce.exe'
        /// </summary>
        public string UIWpfWindowAlternateExePath = "C:\\Virto\\VCF\\src\\CommerceFoundation.Presentation\\Admin\\Presentation.Application\\b" +
            "in\\Debug\\VirtoCommerce.exe";
        
        /// <summary>
        /// Type 'http://localhost/store' in text box numbered 3 next to 'admin' label
        /// </summary>
        public string UIItemEditText = "http://localhost/store";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'CreateTestCatalog'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class CreateTestCatalogParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'TestCatalog' in first text box next to '* Catalog id:' label
        /// </summary>
        public string UIItemEditText = "TestCatalog";
        
        /// <summary>
        /// Type 'Test catalog' in first text box next to '* Catalog name:' label
        /// </summary>
        public string UIItemEditText1 = "Test catalog";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIWpfWindow : WpfWindow
    {
        
        public UIWpfWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public UIMainRegionTabList UIMainRegionTabList
        {
            get
            {
                if ((this.mUIMainRegionTabList == null))
                {
                    this.mUIMainRegionTabList = new UIMainRegionTabList(this);
                }
                return this.mUIMainRegionTabList;
            }
        }
        
        public WpfButton UIShowmainmenuButton
        {
            get
            {
                if ((this.mUIShowmainmenuButton == null))
                {
                    this.mUIShowmainmenuButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIShowmainmenuButton.SearchProperties[WpfButton.PropertyNames.HelpText] = "Show main menu";
                    #endregion
                }
                return this.mUIShowmainmenuButton;
            }
        }
        
        public UIMenuRegionList UIMenuRegionList
        {
            get
            {
                if ((this.mUIMenuRegionList == null))
                {
                    this.mUIMenuRegionList = new UIMenuRegionList(this);
                }
                return this.mUIMenuRegionList;
            }
        }
        
        public WpfTabList UIMainRegionTabList1
        {
            get
            {
                if ((this.mUIMainRegionTabList1 == null))
                {
                    this.mUIMainRegionTabList1 = new WpfTabList(this);
                    #region Search Criteria
                    this.mUIMainRegionTabList1.SearchProperties[WpfTabList.PropertyNames.AutomationId] = "MainRegion";
                    #endregion
                }
                return this.mUIMainRegionTabList1;
            }
        }
        
        public UIVirtoCommerceManagemPane UIVirtoCommerceManagemPane
        {
            get
            {
                if ((this.mUIVirtoCommerceManagemPane == null))
                {
                    this.mUIVirtoCommerceManagemPane = new UIVirtoCommerceManagemPane(this);
                }
                return this.mUIVirtoCommerceManagemPane;
            }
        }
        
        public WpfButton UIFinishButton
        {
            get
            {
                if ((this.mUIFinishButton == null))
                {
                    this.mUIFinishButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIFinishButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "NextFinish";
                    #endregion
                }
                return this.mUIFinishButton;
            }
        }
        #endregion
        
        #region Fields
        private UIMainRegionTabList mUIMainRegionTabList;
        
        private WpfButton mUIShowmainmenuButton;
        
        private UIMenuRegionList mUIMenuRegionList;
        
        private WpfTabList mUIMainRegionTabList1;
        
        private UIVirtoCommerceManagemPane mUIVirtoCommerceManagemPane;
        
        private WpfButton mUIFinishButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIMainRegionTabList : WpfTabList
    {
        
        public UIMainRegionTabList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabList.PropertyNames.AutomationId] = "MainRegion";
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.SearchConfigurations.Add(SearchConfiguration.VisibleOnly);
            #endregion
        }
        
        #region Properties
        public UIVirtoCommerceManagemTabPage UIVirtoCommerceManagemTabPage
        {
            get
            {
                if ((this.mUIVirtoCommerceManagemTabPage == null))
                {
                    this.mUIVirtoCommerceManagemTabPage = new UIVirtoCommerceManagemTabPage(this);
                }
                return this.mUIVirtoCommerceManagemTabPage;
            }
        }
        #endregion
        
        #region Fields
        private UIVirtoCommerceManagemTabPage mUIVirtoCommerceManagemTabPage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVirtoCommerceManagemTabPage : WpfTabPage
    {
        
        public UIVirtoCommerceManagemTabPage(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabPage.PropertyNames.Name] = "VirtoCommerce.ManagementClient.Security.ViewModel.LoginViewModel";
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.SearchConfigurations.Add(SearchConfiguration.VisibleOnly);
            #endregion
        }
        
        #region Properties
        public UIAdminText UIAdminText
        {
            get
            {
                if ((this.mUIAdminText == null))
                {
                    this.mUIAdminText = new UIAdminText(this);
                }
                return this.mUIAdminText;
            }
        }
        #endregion
        
        #region Fields
        private UIAdminText mUIAdminText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAdminText : WpfText
    {
        
        public UIAdminText(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfText.PropertyNames.Name] = "admin";
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.SearchConfigurations.Add(SearchConfiguration.VisibleOnly);
            #endregion
        }
        
        #region Properties
        public WpfEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.SearchProperties[WpfEdit.PropertyNames.Instance] = "3";
                    this.mUIItemEdit.SearchConfigurations.Add(SearchConfiguration.NextSibling);
                    this.mUIItemEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
                    this.mUIItemEdit.SearchConfigurations.Add(SearchConfiguration.VisibleOnly);
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIMenuRegionList : WpfList
    {
        
        public UIMenuRegionList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfList.PropertyNames.AutomationId] = "MenuRegion";
            #endregion
        }
        
        #region Properties
        public UIVirtoCommerceManagemListItem UIVirtoCommerceManagemListItem
        {
            get
            {
                if ((this.mUIVirtoCommerceManagemListItem == null))
                {
                    this.mUIVirtoCommerceManagemListItem = new UIVirtoCommerceManagemListItem(this);
                }
                return this.mUIVirtoCommerceManagemListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIVirtoCommerceManagemListItem mUIVirtoCommerceManagemListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVirtoCommerceManagemListItem : WpfListItem
    {
        
        public UIVirtoCommerceManagemListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfListItem.PropertyNames.Name] = "VirtoCommerce.ManagementClient.Core.Infrastructure.Navigation.NavigationMenuItem";
            this.SearchProperties[WpfListItem.PropertyNames.Instance] = "4";
            #endregion
        }
        
        #region Properties
        public UIBtnButton UIBtnButton
        {
            get
            {
                if ((this.mUIBtnButton == null))
                {
                    this.mUIBtnButton = new UIBtnButton(this);
                }
                return this.mUIBtnButton;
            }
        }
        #endregion
        
        #region Fields
        private UIBtnButton mUIBtnButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBtnButton : WpfButton
    {
        
        public UIBtnButton(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btn";
            #endregion
        }
        
        #region Properties
        public WpfCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new WpfCustom(this);
                    #region Search Criteria
                    this.mUIItemCustom.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.VectorImage";
                    #endregion
                }
                return this.mUIItemCustom;
            }
        }
        #endregion
        
        #region Fields
        private WpfCustom mUIItemCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVirtoCommerceManagemPane : WpfPane
    {
        
        public UIVirtoCommerceManagemPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfPane.PropertyNames.ClassName] = "Uia.ScrollViewer";
            this.SearchProperties[WpfPane.PropertyNames.Name] = "VirtoCommerce.ManagementClient.Catalog.ViewModel.Wizard.CatalogOverviewStepViewMo" +
                "del";
            #endregion
        }
        
        #region Properties
        public UICatalogidText UICatalogidText
        {
            get
            {
                if ((this.mUICatalogidText == null))
                {
                    this.mUICatalogidText = new UICatalogidText(this);
                }
                return this.mUICatalogidText;
            }
        }
        
        public UICatalognameText UICatalognameText
        {
            get
            {
                if ((this.mUICatalognameText == null))
                {
                    this.mUICatalognameText = new UICatalognameText(this);
                }
                return this.mUICatalognameText;
            }
        }
        
        public UIDefaultlanguageText UIDefaultlanguageText
        {
            get
            {
                if ((this.mUIDefaultlanguageText == null))
                {
                    this.mUIDefaultlanguageText = new UIDefaultlanguageText(this);
                }
                return this.mUIDefaultlanguageText;
            }
        }
        #endregion
        
        #region Fields
        private UICatalogidText mUICatalogidText;
        
        private UICatalognameText mUICatalognameText;
        
        private UIDefaultlanguageText mUIDefaultlanguageText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICatalogidText : WpfText
    {
        
        public UICatalogidText(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfText.PropertyNames.Name] = "* Catalog id:";
            #endregion
        }
        
        #region Properties
        public WpfEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.SearchConfigurations.Add(SearchConfiguration.NextSibling);
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICatalognameText : WpfText
    {
        
        public UICatalognameText(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfText.PropertyNames.Name] = "* Catalog name:";
            #endregion
        }
        
        #region Properties
        public WpfEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.SearchConfigurations.Add(SearchConfiguration.NextSibling);
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDefaultlanguageText : WpfText
    {
        
        public UIDefaultlanguageText(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfText.PropertyNames.Name] = "* Default language:";
            #endregion
        }
        
        #region Properties
        public WpfComboBox UIItemComboBox
        {
            get
            {
                if ((this.mUIItemComboBox == null))
                {
                    this.mUIItemComboBox = new WpfComboBox(this);
                    #region Search Criteria
                    this.mUIItemComboBox.SearchConfigurations.Add(SearchConfiguration.NextSibling);
                    #endregion
                }
                return this.mUIItemComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WpfComboBox mUIItemComboBox;
        #endregion
    }
}