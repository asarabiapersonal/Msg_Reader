using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Msg_Reader
{
    public class messageNodeInfo
    {
        public TreeNode tNode;
        public string bodyText;
        public string headerText;
        public string rulesText;
        public string filePath;
        public string fileName;
        public int pNodeIndex;


        public messageNodeInfo()
        {
            tNode = new TreeNode();
            bodyText = "";
            headerText = "";
            rulesText = "";
            fileName = "";
            filePath = "";
            pNodeIndex = 0;
        }

    }
}
