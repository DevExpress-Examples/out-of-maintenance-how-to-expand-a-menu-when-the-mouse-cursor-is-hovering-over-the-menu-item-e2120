<!-- default file list -->
*Files to look at*:

* [BarHelper.cs](./CS/Q253018/BarHelper.cs) (VB: [BarHelper.vb](./VB/Q253018/BarHelper.vb))
* [Form1.cs](./CS/Q253018/Form1.cs) (VB: [Form1.vb](./VB/Q253018/Form1.vb))
* [Program.cs](./CS/Q253018/Program.cs) (VB: [Program.vb](./VB/Q253018/Program.vb))
<!-- default file list end -->
# How to expand a menu when the mouse cursor is hovering over the menu item


<p>This functionality can be implemented within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsBarManager_HighlightedLinkChangedtopic">BarManager.HoghlightedLinkChanged</a> event handler. The menu can be opened by calling the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsBarCustomContainerItemLink_OpenMenutopic">BarCustomContainerItemLink.OpenMenu</a> method of the link provided in the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsHighlightedLinkChangedEventArgs_Linktopic">HighlightedLinkChangedEventArgs.Link</a> property.</p>

<br/>


