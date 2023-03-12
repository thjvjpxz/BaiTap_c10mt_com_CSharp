using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public class EnterNumber
    {
        public static DialogResult NhapSo(ref string value)
        {
            Form frm = new Form();
            Label label = new Label();
            TextBox texbox = new TextBox();
            Button buttonOK = new Button();
            Button buttonCancel = new Button();

            frm.Text = "Nhập số nguyên";
            frm.MinimizeBox = false;
            frm.MaximizeBox = false;
            label.Text = "Nhập số nguyên bất kỳ";
            //label.AutoSize = true;
            buttonOK.Text = "OK";
            buttonCancel.Text = "Cancel";

            buttonOK.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            texbox.SetBounds(12, 36, 372, 20);
            buttonOK.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            frm.ClientSize = new Size(396, 107);
            frm.Controls.AddRange(new Control[] { label, texbox, buttonOK, buttonCancel });
            frm.ClientSize = new Size(Math.Max(300, label.Right + 10), frm.ClientSize.Height);
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.StartPosition = FormStartPosition.CenterScreen;

            DialogResult dialogResult = frm.ShowDialog();
            value = texbox.Text;
            return dialogResult;
            //return ;
        }
    }
}
