namespace BeautySalon.WinUI
{
    public class FormMaker
    {
        public static void createForm(Form newForm, Form oldForm)
        {
            newForm.TopLevel = false;
            newForm.AutoScroll = true;
            newForm.Size = oldForm.ParentForm.Size;

            oldForm.ParentForm.Controls[0].Controls.Add(newForm);
            oldForm.Hide();
            newForm.Show();
        }

        public static void createFormFromParent(Form newForm, Form oldForm, Panel panel)
        {
            panel.Controls.Clear();

            newForm.MdiParent = oldForm;
            newForm.TopLevel = false;
            newForm.AutoScroll = true;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            newForm.Size = panel.Size;

            panel.Controls.Add(newForm);

            newForm.Show();
        }
    }
}
