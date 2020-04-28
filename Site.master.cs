using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //TreeNode PNode = new TreeNode();
        //PNode.Text = "Root1";
        //PNode.Value = "2";
        //PNode.NavigateUrl = "~/About.aspx";


        //TreeNode c1 = new TreeNode();
        //c1.Text = "Tr1";
        //c1.Value = "1";
        //c1.NavigateUrl = "~/About.aspx";

        //TreeNode c2 = new TreeNode();
        //c2.Text = "Tr1";
        //c2.Value = "1";
        //c2.NavigateUrl="~/About.aspx";

        //c1.ChildNodes.Add(c2);
        //PNode.ChildNodes.Add(c1);
        //this.ApplicationObjects.Nodes.Add(PNode);


        //PNode = new TreeNode();
        //PNode.Text = "Root2";
        //PNode.Value = "2";

        //c1 = new TreeNode();
        //c1.Text = "Tr2";
        //c1.Value = "1";

        //c2 = new TreeNode();
        //c2.Text = "Tr2";
        //c2.Value = "1";
        //c2.NavigateUrl = "~/About1.aspx";

        //c1.ChildNodes.Add(c2);
        //PNode.ChildNodes.Add(c1);
        //this.ApplicationObjects.Nodes.Add(PNode);

        //ApplicationObjects.CollapseAll();


        //case 2
        for (int i = 0; i <= 5; i++)
        {
            TreeNode node =new TreeNode();
            node.Text = "Troot"+i;
            node.Value = "1";
            ApplicationObjects.Nodes.Add(node);

            for (int j = 0; j <=3; j++)
            {
                TreeNode node1 = new TreeNode();
                node1.Text = "Tchild"+j;
                node1.Value = "1";
                node1.NavigateUrl = "~/About.aspx";

                if (j == 2)
                {
                    TreeNode node2 = new TreeNode();
                    node2.Text = "Tchild_" + j;
                    node2.Value = "1";
                    node2.NavigateUrl = "~/Default.aspx";
                    node1.ChildNodes.Add(node2);
                }
                node.ChildNodes.Add(node1);
            }            
        }

        ApplicationObjects.CollapseAll();
    }
}
