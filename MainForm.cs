using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace xml_tree
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            URL_Box.ForeColor = Color.Gray;
        }

        private void LoadXml_Click(object sender, EventArgs e)
        {
            XML_tree.Nodes.Clear();
            this.LoadXml_from_URL(URL_Box.Text);
        }

        private void LoadXml_from_URL(string url)
        {
            try
            {
                XmlDocument xfile = new XmlDocument();
                xfile.Load(url);
                XML_tree.Nodes.Add(new TreeNode(xfile.DocumentElement.Name));

                TreeNode tNode = new TreeNode();
                tNode = XML_tree.Nodes[0];
                this.AddNode(xfile.DocumentElement, tNode);
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNode(XmlNode XNode, TreeNode TreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;
            if (XNode.HasChildNodes)
            {
                nodeList = XNode.ChildNodes;

                for (i = 0; i < nodeList.Count; i++)
                {
                    xNode = XNode.ChildNodes[i];
                    TreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = TreeNode.Nodes[i];
                    this.AddNode(xNode, tNode);
                }
            }
            else
            {
                TreeNode.Text = (XNode.OuterXml).Trim();
            }
        }

        private void URL_Box_Enter(object sender, EventArgs e)
        {
            if (URL_Box.Text == "Введите URL...")
            {
                URL_Box.Text = "";
                URL_Box.ForeColor = Color.Black;
            }
        }

        private void URL_Box_Leave(object sender, EventArgs e)
        {
            if (URL_Box.Text == "")
            {
                URL_Box.Text = "Введите URL...";
                URL_Box.ForeColor = Color.Gray;
            }
        }
    }
}

