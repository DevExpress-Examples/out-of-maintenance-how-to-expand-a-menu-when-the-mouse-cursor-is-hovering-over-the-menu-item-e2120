<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616873/11.1.12%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2120)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [BarHelper.cs](./CS/Q253018/BarHelper.cs) (VB: [BarHelper.vb](./VB/Q253018/BarHelper.vb))
* [Form1.cs](./CS/Q253018/Form1.cs) (VB: [Form1.vb](./VB/Q253018/Form1.vb))
* [Program.cs](./CS/Q253018/Program.cs) (VB: [Program.vb](./VB/Q253018/Program.vb))
<!-- default file list end -->
# How to expand a menu when the mouse cursor is hovering over the menu item


<p>This functionality can be implemented within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsBarManager_HighlightedLinkChangedtopic">BarManager.HoghlightedLinkChanged</a> event handler. The menu can be opened by calling the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsBarCustomContainerItemLink_OpenMenutopic">BarCustomContainerItemLink.OpenMenu</a> method of the link provided in the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsHighlightedLinkChangedEventArgs_Linktopic">HighlightedLinkChangedEventArgs.Link</a> property.</p>

<br/>


