using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransManager
{
    class Sizer
    {
        public static float xscale = (float)1.0;
        public static float yscale = (float)1.0;
        public static float fscale = (float)1.0;

        Sizer() {

        }

        public static void ResizeForm(Form frm) {
            frm.Scale(new System.Drawing.SizeF(xscale, yscale));
            System.Drawing.Rectangle rect  = Screen.PrimaryScreen.Bounds;
            ModifyAllControls(frm);
            
        }

        private static void ModifyAllControls(Control container)
        {
            

            //container.Font = new System.Drawing.Font(container.Font.FontFamily, (float)((container.Font.Size * xscale) > 10 ? 10 : (container.Font.Size * xscale)));
            foreach (Control ctl in container.Controls)
            {
                if (ctl is CheckedListBox || ctl is DateTimePicker || ctl is CheckBox || ctl is ComboBox || ctl is RadioButton || ctl is TextBox || ctl is Label || ctl is RichTextBox || ctl is TreeView || ctl is Button)
                {
                    ctl.Font = new System.Drawing.Font(ctl.Font.FontFamily, (float)(ctl.Font.Size * fscale));
                }

                ModifyAllControls(ctl);
                
            }
        }

    }
}
