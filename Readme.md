<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to show a tree node hierarhy of a ASPxTreeView


<p>This example demonstrates how you can get a path to a ASPxTreeView node. By "path" we mean a full list of its parent nodes, similar to what Windows Explorer displays when you choose a folder: Parent1->Parent2->...->Node</p><br />
<p>This path is constructed recursively on the client when a certain node is clicked.</p><br />
<p>A virtual mode binding code was taken from a  <a href="https://www.devexpress.com/Support/Center/p/E2538">How to handle the VirtualModeCreateChildren event</a> example.</p>

<br/>


