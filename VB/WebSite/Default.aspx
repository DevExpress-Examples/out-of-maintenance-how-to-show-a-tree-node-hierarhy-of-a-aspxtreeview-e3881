<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.2, Version=11.2.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxTreeView" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>

	<script type="text/javascript">
		function treeView_NodeClick(s, e) {
			var nodePath = e.node.GetText();
			var currentNode = e.node.parent;
			while (currentNode != null) {
				nodePath = currentNode.GetText() + " -> " + nodePath;
				currentNode = currentNode.parent;
			}
			labelPath.SetText(nodePath);
		}
	</script>

</head>
<body>
	<form id="form1" runat="server">
	<div>
		<table>
			<tr>
				<td>
					<dx:ASPxLabel ID="labelPath" runat="server" Width="100%" BackColor="LightGray"
						ClientInstanceName="labelPath">
					</dx:ASPxLabel>
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxTreeView ID="treeView" runat="server" OnVirtualModeCreateChildren="treeView_VirtualModeCreateChildren"
						Width="100%">
						<ClientSideEvents NodeClick="treeView_NodeClick" />
					</dx:ASPxTreeView>
				</td>
			</tr>
		</table>
	</div>
	</form>
</body>
</html>