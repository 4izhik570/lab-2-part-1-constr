using Lab2_EF.Models;
namespace Lab2_EF
{
    public partial class PatientEditForm : Form
    {
        public Patient CurrentPatient { get; private set; }

        public PatientEditForm(Patient patient, List<Street> streets, bool isNew)
        {
            InitializeComponent();
            CurrentPatient = patient;

            // Настраиваем выпадающий список улиц
            cmbStreet.DataSource = streets;
            cmbStreet.DisplayMember = "Name";
            cmbStreet.ValueMember = "Id";

            // Первичный ключ (СНИЛС) можно менять только при создании новой записи
            txtSnils.Enabled = isNew;

            // Заполняем поля
            txtSnils.Text = patient.Snils;
            txtFio.Text = patient.Fio;
            txtPol.Text = patient.Pol;
            txtHouse.Text = patient.HouseNum;
            txtWorkplace.Text = patient.Workplace;
            txtCard.Text = patient.CardNum;
            txtFlat.Text = patient.FlatNum;
            txtPolis.Text = Convert.ToString(patient.Polis);

            if (patient.Birthdate.HasValue)
                dtpBirth.Value = patient.Birthdate.Value.ToDateTime(TimeOnly.MinValue);

            if (patient.Streetid.HasValue)
                cmbStreet.SelectedValue = patient.Streetid.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            CurrentPatient.Snils = txtSnils.Text.Trim();
            CurrentPatient.Fio = txtFio.Text.Trim();
            CurrentPatient.Pol = txtPol.Text.Trim();
            CurrentPatient.HouseNum = txtHouse.Text.Trim();
            CurrentPatient.Birthdate = DateOnly.FromDateTime(dtpBirth.Value);
            CurrentPatient.Streetid = (int?)cmbStreet.SelectedValue;
            CurrentPatient.FlatNum = txtFlat.Text.Trim();
            CurrentPatient.CardNum = txtCard.Text.Trim();
            CurrentPatient.Workplace = txtWorkplace.Text.Trim();
            CurrentPatient.Polis = Convert.ToInt64(txtPolis.Text.Trim());

            DialogResult = DialogResult.OK;
            Close();
        }

        private void PatientEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}