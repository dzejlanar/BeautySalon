using System.ComponentModel;
using System.Text.RegularExpressions;

namespace BeautySalon.WinUI
{
    public class Validator
    {
        public static void requiredFieldTxt(TextBox textBox, CancelEventArgs e, ErrorProvider err, string message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                err.SetError(textBox, message);
                e.Cancel = true;
            } else
            {
                err.SetError(textBox, null);
                e.Cancel = false;
            }
        }

        public static void requiredFieldTxtNumber(TextBox textBox, CancelEventArgs e, ErrorProvider err, string message)
        {
            Regex r = new Regex(@"^[1-9][\.\d]*(,\d+)?$");

            if (r.IsMatch(textBox.Text.ToString()))
            {
                err.SetError(textBox, null);
                e.Cancel = false;
            } else
            {
                err.SetError(textBox, message);
                e.Cancel = true;
            }
        }

        public static void validateRichTxt(RichTextBox txtBox, CancelEventArgs e, ErrorProvider err, string message)
        {
            if (txtBox.Text.Length > 500 || string.IsNullOrWhiteSpace(txtBox.Text))
            {
                err.SetError(txtBox, message);
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtBox, null);
                e.Cancel = false;
            }
        }

        public static void requiredComboBox(ComboBox cmb, CancelEventArgs e, ErrorProvider err, string message)
        {
            if (cmb.SelectedValue == null)
            {
                err.SetError(cmb, message);
                e.Cancel = true;
            } else
            {
                err.SetError(cmb, null);
                e.Cancel = false;
            }
        }

        public static void requiredCheckedListBox(CheckedListBox clb, CancelEventArgs e, ErrorProvider err, string message)
        {
            if (clb.CheckedItems.Count == 0)
            {
                err.SetError(clb, message);
                e.Cancel = true;
            }
            else
            {
                err.SetError(clb, null);
                e.Cancel = false;
            }
        }

        public static void passwordValidator(TextBox txtBox, CancelEventArgs e, ErrorProvider err, string message)
        {
            if (txtBox.Text.Length < 8 || string.IsNullOrWhiteSpace(txtBox.Text))
            {
                err.SetError(txtBox, message);
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtBox, null);
                e.Cancel = false;
            }
        }

        public static void passwordLengthValidator(TextBox txtBox, CancelEventArgs e, ErrorProvider err, string message)
        {
            if (txtBox.Text.Length < 8 && txtBox.Text.Length > 0)
            {
                err.SetError(txtBox, message);
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtBox, null);
                e.Cancel = false;
            }
        }
    }
}
