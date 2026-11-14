namespace medicord_v1.Screens.Patient;

public class EditDependentScreen : DepPage
{
    public event EventHandler? Saved;

    public EditDependentScreen(int id) : base("Edit details")
    {
        DependentInfo? d = null;
        try { d = DependentService.GetOne(id); }
        catch (SqlException ex) { Msg.Error("Could not load this dependent.\n" + ex.Message); }
        if (d == null) { OnBack(); return; }

        var name = AddField("Full name", d.Name);
        var gender = AddSegment("Gender", "Female", "Male");
        gender.SelectedIndex = d.Gender == "M" ? 1 : 0;
        var dob = AddDob(d.DateOfBirth ?? DateTime.Today.AddYears(-5));
        var phone = AddField("Phone", d.Phone);
        phone.PlaceholderText = "Phone number";

        SiticoneTextBox? oku = null; TextBox? notes = null;
        if (d.Type == "OKU")
        {
            oku = AddField("OKU card number (optional)", d.OkuCardNo);
            notes = AddNotes("Care notes (optional)", d.CareNotes);
        }

        AddButton("Save changes", true, 0).Click += (_, _) =>
        {
            string n = name.Text.Trim(), ph = phone.Text.Trim().Replace("-", "").Replace(" ", "");
            DateTime birth = (dob.Date ?? DateTime.Today).Date;
            if (n.Length < 2) { Msg.Warn("Enter the full name."); return; }
            if (birth > DateTime.Today) { Msg.Warn("The date of birth cannot be in the future."); return; }
            if (ph != "" && !Validators.IsPhone(ph)) { Msg.Warn("Enter a valid phone number (digits only)."); return; }
            try
            {
                DependentService.Update(id, n, birth, gender.SelectedIndex == 0 ? "F" : "M", ph,
                                        oku?.Text.Trim() ?? "", notes?.Text.Trim() ?? "");
            }
            catch (SqlException ex) { Msg.Error("Could not save.\n" + ex.Message); return; }
            AppEvents.RaiseProfileChanged();
            Saved?.Invoke(this, EventArgs.Empty);
        };
    }
}