using Lab2_EF.Models;
using Microsoft.EntityFrameworkCore;
namespace Lab2_EF
{
    public partial class Form1 : Form
    {
        private HospitalContext _db = new HospitalContext();

        public Form1()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients()
        {
            // Загружаем пациентов из БД
            dgvPatients.DataSource = _db.Patients
                .Select(p => new
                {
                    p.Snils,
                    p.Fio,
                    p.Pol,
                    p.Birthdate,
                    Street = p.Street != null ? p.Street.Name : "",
                    p.Workplace,
                    p.Polis,
                    p.CardNum,
                    p.FlatNum,
                    p.HouseNum
                })
                .ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new PatientEditForm(new Patient(), _db.Streets.ToList(), isNew: true);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _db.Patients.Add(form.CurrentPatient);
                _db.SaveChanges();
                LoadPatients();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow == null) return;

            // Получаем СНИЛС выбранного пациента
            string snils = dgvPatients.CurrentRow.Cells["Snils"].Value.ToString()!;
            var patient = _db.Patients.Find(snils);

            if (patient != null)
            {
                var form = new PatientEditForm(patient, _db.Streets.ToList(), isNew: false);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _db.SaveChanges();
                    LoadPatients();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow == null) return;

            string snils = dgvPatients.CurrentRow.Cells["Snils"].Value.ToString()!;
            var patient = _db.Patients.Find(snils);

            if (patient != null && MessageBox.Show("Удалить пациента?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _db.Patients.Remove(patient);
                _db.SaveChanges();
                LoadPatients();
            }
        }

        private void btnSearchProc_Click(object sender, EventArgs e)
        {
            string query = txtSearchFio.Text;
            dgvProcResult.DataSource = _db.SearchResults
                .FromSqlInterpolated($"SELECT * FROM public.search_patients_by_fio({query})")
                .ToList();
        }

        private void btnFilterLinq_Click(object sender, EventArgs e)
        {
            string searchFio = txtFilter.Text.Trim().ToLower();

            var query = _db.Patients
                // 1. Фильтрация (Where): ищем по части ФИО (если поле не пустое)
                .Where(p => string.IsNullOrEmpty(searchFio) || p.Fio.ToLower().Contains(searchFio))
                // 2. Объединение (Join) с улицами и участками
                .Join(_db.Streets,
                      patient => patient.Streetid,
                      street => street.Id,
                      (patient, street) => new { patient, street })
                .Join(_db.Areas,
                      ps => ps.street.Areaid,
                      area => area.Id,
                      (ps, area) => new { ps.patient, ps.street, area })
                // 3. Сортировка
                .OrderBy(x => x.patient.Fio)
                // 4. Проекция (Select): выбираем только нужные столбцы для таблицы
                .Select(x => new
                {
                    СНИЛС = x.patient.Snils,
                    ФИО = x.patient.Fio,
                    Пол = x.patient.Pol,
                    ДатаРождения = x.patient.Birthdate,
                    Улица = x.street.Name,
                    Дом = x.patient.HouseNum,
                    Участок = x.area.Id
                })
                .ToList();

            dgvLinq.DataSource = query;
        }
    }
    public class PatientSearchDto
    {
        public string Snils { get; set; } = null!;
        public string Fio { get; set; } = null!;
        public DateOnly? Birthdate { get; set; }
    }

}