using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARuleMaker
{
    public partial class FormRM : Form
    {
        public FormRM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void meta2Check_CheckedChanged(object sender, EventArgs e)
        {
            if (meta2Check.Checked == true)
            {
                rxInput2.Enabled = true;
                meta2Case.Enabled = true;
                rbCheck2.Enabled = true;
                headCheck2.Enabled = true;
                fromCheck2.Enabled = true;
                subCheck2.Enabled = true;
                rcCheck2.Enabled = true;
                meta3Check.Enabled = true;
                rbCheck2.Checked = true;
            }
            else if (meta2Check.Checked == false)
            {
                metaCheck.Checked = false;
                rxInput2.Enabled = false;
                meta2Case.Enabled = false;
                rbCheck2.Enabled = false;
                headCheck2.Enabled = false;
                fromCheck2.Enabled = false;
                subCheck2.Enabled = false;
                rcCheck2.Enabled = false;

                rbCheck2.Checked = false;
                headCheck2.Checked = false;
                fromCheck2.Checked = false;
                subCheck2.Checked = false;
                rcCheck2.Checked = false;


                meta3Check.Enabled = false;
                meta3Check.Checked = false;
            }
        }

        private void meta3Check_CheckedChanged(object sender, EventArgs e)
        {
            if (meta3Check.Checked == true)
            {
                rxInput3.Enabled = true;
                meta3Case.Enabled = true;
                rbCheck3.Enabled = true;
                headCheck3.Enabled = true;
                fromCheck3.Enabled = true;
                subCheck3.Enabled = true;
                rcCheck3.Enabled = true;
                meta4Check.Enabled = true;
                rbCheck3.Checked = true;
            }
            else if (meta3Check.Checked == false)
            {
                rxInput3.Enabled = false;
                meta3Case.Enabled = false;
                rbCheck3.Enabled = false;
                headCheck3.Enabled = false;
                fromCheck3.Enabled = false;
                subCheck3.Enabled = false;
                rcCheck3.Enabled = false;

                meta3Case.Checked = false;
                rbCheck3.Checked = false;
                headCheck3.Checked = false;
                fromCheck3.Checked = false;
                subCheck3.Checked = false;
                rcCheck3.Checked = false;

                meta4Check.Enabled = false;
                meta4Check.Checked = false;
            }
        }

        private void meta4Check_CheckedChanged(object sender, EventArgs e)
        {
            if (meta4Check.Checked == true)
            {
                rxInput4.Enabled = true;
                meta4Case.Enabled = true;
                rbCheck4.Enabled = true;
                headCheck4.Enabled = true;
                fromCheck4.Enabled = true;
                subCheck4.Enabled = true;
                rcCheck4.Enabled = true;
                rbCheck4.Checked = true;
            }
            else if (meta4Check.Checked == false)
            {
                rxInput4.Enabled = false;
                meta4Case.Enabled = false;
                rbCheck4.Enabled = false;
                headCheck4.Enabled = false;
                fromCheck4.Enabled = false;
                subCheck4.Enabled = false;
                rcCheck4.Enabled = false;

                meta4Case.Checked = false;
                rbCheck4.Checked = false;
                headCheck4.Checked = false;
                fromCheck4.Checked = false;
                subCheck4.Checked = false;
                rcCheck4.Checked = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (metaCheck.Checked == true)
            {
                meta2Check.Enabled = true;
                meta2Check.Checked = true;

            }
            else if (metaCheck.Checked == false)
            {
                meta2Check.Enabled = false;
                meta2Check.Checked = false;
            }
        }

        private void fromCheck1_CheckedChanged(object sender, EventArgs e)
        {
            if (fromCheck1.Checked == true)
            {
                subCheck1.Checked = false;
                rcCheck1.Checked = false;
            }
        }

        private void subCheck1_CheckedChanged(object sender, EventArgs e)
        {
            if (subCheck1.Checked == true)
            {
                fromCheck1.Checked = false;
                rcCheck1.Checked = false;
            }
        }

        private void rcCheck1_CheckedChanged(object sender, EventArgs e)
        {
            if (rcCheck1.Checked == true)
            {
                subCheck1.Checked = false;
                fromCheck1.Checked = false;
            }
        }

        private void fromCheck2_CheckedChanged(object sender, EventArgs e)
        {
            if (fromCheck2.Checked == true)
            {
                subCheck2.Checked = false;
                rcCheck2.Checked = false;
            }
        }

        private void subCheck2_CheckedChanged(object sender, EventArgs e)
        {
            if (subCheck2.Checked == true)
            {
                fromCheck2.Checked = false;
                rcCheck2.Checked = false;
            }
        }

        private void rcCheck2_CheckedChanged(object sender, EventArgs e)
        {
            if (rcCheck2.Checked == true)
            {
                subCheck2.Checked = false;
                fromCheck2.Checked = false;
            }
        }

        private void fromCheck3_CheckedChanged(object sender, EventArgs e)
        {
            if (fromCheck3.Checked == true)
            {
                subCheck3.Checked = false;
                rcCheck3.Checked = false;
            }
        }

        private void subCheck3_CheckedChanged(object sender, EventArgs e)
        {
            if (subCheck3.Checked == true)
            {
                fromCheck3.Checked = false;
                rcCheck3.Checked = false;
            }
        }

        private void rcCheck3_CheckedChanged(object sender, EventArgs e)
        {
            if (rcCheck3.Checked == true)
            {
                subCheck3.Checked = false;
                fromCheck3.Checked = false;
            }
        }

        private void fromCheck4_CheckedChanged(object sender, EventArgs e)
        {
            if (fromCheck4.Checked == true)
            {
                subCheck4.Checked = false;
                rcCheck4.Checked = false;
            }
        }

        private void subCheck4_CheckedChanged(object sender, EventArgs e)
        {
            if (subCheck4.Checked == true)
            {
                fromCheck4.Checked = false;
                rcCheck4.Checked = false;
            }
        }

        private void rcCheck4_CheckedChanged(object sender, EventArgs e)
        {
            if (rcCheck4.Checked == true)
            {
                subCheck4.Checked = false;
                fromCheck4.Checked = false;
            }
        }

        private void ruleOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buildBtn_Click(object sender, EventArgs e)
        {
            string holdTxt = "";
            string metaFull = "";
            string headerType = "";
            if (metaCheck.Checked == false)
            {
                if (rbCheck1.Checked == true)
                {
                    holdTxt = "rawbody LSS_RAWBODY_RULE" + ruleNumber.Text + " /" + rxInput1.Text + "/";
                    if (meta1Case.Checked == true) { holdTxt = holdTxt + "i"; }
                    holdTxt = holdTxt + "\r\nscore LSS_RAWBODY_RULE" + ruleNumber.Text + " " + scoreNum.Value;
                }
                else if (headCheck1.Checked == true)
                {
                    if (fromCheck1.Checked == true) { headerType = " From "; }
                    else if (subCheck1.Checked == true) { headerType = " Subject "; }
                    else if (rcCheck1.Checked == true) { headerType = " Received "; }
                    holdTxt = "header LSS_HEADER_RULE" + ruleNumber.Text + headerType + "=~/" + rxInput1.Text + "/";
                    if (meta1Case.Checked == true) { holdTxt = holdTxt + "i"; }
                    holdTxt = holdTxt + "\r\nscore LSS_HEADER_RULE" + ruleNumber.Text + " " + scoreNum.Value;
                }


            }
            else if (metaCheck.Checked == true)
            {
                string holdTxtMeta = "";
                string label = "";
                string label2 = "";
                if (rbCheck1.Checked == true)
                {
                    if (headCheck2.Checked == true && headCheck2.Enabled == true ||
                        headCheck3.Checked == true && headCheck3.Enabled == true ||
                        headCheck4.Checked == true && headCheck4.Enabled == true)
                    {
                        label = "body __LSS_HEADER_RULE"; label2 = "__LSS_HEADER_RULE";
                    }
                    else { label = "rawbody __LSS_RAWBODY_RULE"; label2 = "__LSS_RAWBODY_RULE"; }
                    holdTxtMeta = label + ruleNumber.Text + "_01 /" + rxInput1.Text + "/";
                    if (meta1Case.Checked == true) { holdTxtMeta = holdTxtMeta + "i"; }
                    metaFull = label2 + ruleNumber.Text + "_01";
                    holdTxtMeta = holdTxtMeta + "\r\n";
                }
                else if (headCheck1.Checked == true)
                {
                    if (fromCheck1.Checked == true) { headerType = " From "; }
                    else if (subCheck1.Checked == true) { headerType = " Subject "; }
                    else if (rcCheck1.Checked == true) { headerType = " Received "; }
                    holdTxtMeta = "header __LSS_HEADER_RULE" + ruleNumber.Text + "_01 " + headerType + " =~ /" + rxInput1.Text + "/";
                    if (meta1Case.Checked == true) { holdTxtMeta = holdTxtMeta + "i"; }
                    metaFull = "__LSS_HEADER_RULE" + ruleNumber.Text + "_01 ";
                    holdTxtMeta = holdTxtMeta + "\r\n";
                }

                if (rbCheck2.Checked == true && meta2Check.Checked == true)
                {
                    if (headCheck1.Checked == true || headCheck3.Checked == true || headCheck4.Checked == true) { label = "body __LSS_HEADER_RULE"; label2 = "__LSS_HEADER_RULE"; }
                    else { label = "rawbody __LSS_RAWBODY_RULE"; label2 = "__LSS_RAWBODY_RULE"; }
                    holdTxtMeta = holdTxtMeta + label + ruleNumber.Text + "_02 /" + rxInput2.Text + "/";
                    if (meta2Case.Checked == true) { holdTxtMeta = holdTxtMeta + "i"; }
                    metaFull = metaFull + " && " + label2 + ruleNumber.Text + "_02";
                    holdTxtMeta = holdTxtMeta + "\r\n";
                }
                else if (headCheck2.Checked == true && meta2Check.Checked == true)
                {
                    if (fromCheck2.Checked == true) { headerType = " From "; }
                    else if (subCheck2.Checked == true) { headerType = " Subject "; }
                    else if (rcCheck2.Checked == true) { headerType = " Received "; }
                    holdTxtMeta = holdTxtMeta + "header __LSS_HEADER_RULE" + ruleNumber.Text + "_02 " + headerType + " =~/" + rxInput2.Text + "/";
                    if (meta2Case.Checked == true) { holdTxtMeta = holdTxtMeta + "i"; }
                    holdTxtMeta = holdTxtMeta + "\r\n";
                    metaFull = metaFull + " && __LSS_HEADER_RULE" + ruleNumber.Text + "_02";
                }

                if (rbCheck3.Checked == true && meta3Check.Checked == true)
                {
                    if (headCheck1.Checked == true || headCheck2.Checked == true || headCheck4.Checked == true) { label = "body __LSS_HEADER_RULE"; label2 = "__LSS_HEADER_RULE"; }
                    else { label = "rawbody __LSS_RAWBODY_RULE"; label2 = "__LSS_RAWBODY_RULE"; }
                    holdTxtMeta = holdTxtMeta + label + ruleNumber.Text + "_03 /" + rxInput3.Text + "/";
                    if (meta3Case.Checked == true) { holdTxtMeta = holdTxtMeta + "i"; }
                    metaFull = metaFull + " && " + label2 + ruleNumber.Text + "_03";
                    holdTxtMeta = holdTxtMeta + "\r\n";
                }
                else if (headCheck3.Checked == true && meta3Check.Checked == true)
                {
                    if (fromCheck3.Checked == true) { headerType = " From "; }
                    else if (subCheck3.Checked == true) { headerType = " Subject "; }
                    else if (rcCheck3.Checked == true) { headerType = " Received "; }
                    holdTxtMeta = holdTxtMeta + "header __LSS_HEADER_RULE" + ruleNumber.Text + "_03 " + headerType + " =~/" + rxInput3.Text + "/";
                    if (meta3Case.Checked == true) { holdTxtMeta = holdTxtMeta + "i"; }
                    holdTxtMeta = holdTxtMeta + "\r\n";
                    metaFull = metaFull + " && __LSS_HEADER_RULE" + ruleNumber.Text + "_03";
                }

                if (rbCheck4.Checked == true && meta4Check.Checked == true)
                {
                    if (headCheck2.Checked == true || headCheck3.Checked == true || headCheck1.Checked == true) { label = "body __LSS_HEADER_RULE"; label2 = "__LSS_HEADER_RULE"; }
                    else { label = "rawbody __LSS_RAWBODY_RULE"; label2 = "__LSS_RAWBODY_RULE"; }
                    holdTxtMeta = holdTxtMeta + label + ruleNumber.Text + "_04 /" + rxInput4.Text + "/";
                    if (meta4Case.Checked == true) { holdTxtMeta = holdTxtMeta + "i"; }
                    metaFull = metaFull + " && " + label2 + ruleNumber.Text + "_04";
                    holdTxtMeta = holdTxtMeta + "\r\n";
                }
                else if (headCheck4.Checked == true && meta4Check.Checked == true)
                {
                    if (fromCheck4.Checked == true) { headerType = " From "; }
                    else if (subCheck4.Checked == true) { headerType = " Subject "; }
                    else if (rcCheck4.Checked == true) { headerType = " Received "; }
                    holdTxtMeta = holdTxtMeta + "header __LSS_HEADER_RULE" + ruleNumber.Text + "_04 " + headerType + " =~/" + rxInput4.Text + "/";
                    if (meta4Case.Checked == true) { holdTxtMeta = holdTxtMeta + "i"; }
                    holdTxtMeta = holdTxtMeta + "\r\n";
                    metaFull = metaFull + " && __LSS_HEADER_RULE" + ruleNumber.Text + "_04";
                }

                holdTxt = holdTxtMeta;
                if (headCheck1.Checked == true || headCheck2.Checked == true || headCheck3.Checked == true || headCheck4.Checked == true) { label = "LSS_HEADER_RULE"; label2 = "__LSS_HEADER_RULE"; }
                else { label = "LSS_RAWBODY_RULE"; }
                holdTxt = holdTxt + "meta " + label + ruleNumber.Text + " (" + metaFull + ")";
                holdTxt = holdTxt + "\r\n" + "score " + label + ruleNumber.Text + " " + scoreNum.Value;
            }




            ruleOutput.Text = holdTxt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_TopMost_Click(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }
        }

    }
}
