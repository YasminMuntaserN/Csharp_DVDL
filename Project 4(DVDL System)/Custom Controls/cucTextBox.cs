using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace Project_4_DVDL_System_.Custom_Controls
{
    public partial class cucTextBox : TextBox
    {
        public cucTextBox()
        {
            InitializeComponent();
        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        public bool IsRequired { set; get; }

        public enum InputTypeEnum { TextInput, NumberInput };
        public InputTypeEnum InputType { get; set; } = InputTypeEnum.TextInput;

        public bool IsNumeric()
        {
            string s = this.Text.Trim();
            foreach (char c in s)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    return false;
                }
            }
            return true;
        }

        public Boolean IsValid(object sender)
        {
            Guna2TextBox Temp = ((Guna2TextBox)sender);
            if (IsRequired)
            {
                if (this.Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(Temp, "This field is required!");
                    return false;
                }
            }
            if (InputType == InputTypeEnum.NumberInput)
            {
                errorProvider1.SetError(Temp, "This field only accepts Numbers!");
                return IsNumeric();
            }
            return true;
        }
    }
}
