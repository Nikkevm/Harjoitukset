using System.Data;

namespace Harjoitus18_NiklasVuorio
{
    public partial class KeypeopleForm : Form
    {
        DataTable location = new DataTable();
        DataTable people = new DataTable();
        DataTable connection = new DataTable();
        public KeypeopleForm()
        {
            InitializeComponent();
        }

        private void KeypeopleForm_Load(object sender, EventArgs e)
        {
            fillLocationTable();
            fillPeopleTable();
            LocationCB.DataSource = location;
            LocationCB.DisplayMember = "LName";
        }

        private void LocationCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reference = location.Rows[LocationCB.SelectedIndex]["LID"].ToString();
            AddressLB.Text = location.Rows[LocationCB.SelectedIndex]["LAddress"].ToString();
            PostalLB.Text = location.Rows[LocationCB.SelectedIndex]["LPostal"].ToString();
            CityLB.Text = location.Rows[LocationCB.SelectedIndex]["LCity"].ToString();
            PhoneLB.Text = location.Rows[LocationCB.SelectedIndex]["LPhone"].ToString();

            connection = people.Select("LID =" + reference).CopyToDataTable();
            PersonCB.DataSource = connection;
            PersonCB.DisplayMember = "PName";
        }

        private void PersonCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleLB.Text = connection.Rows[PersonCB.SelectedIndex]["PTitle"].ToString();
            SijaintiLB.Text = connection.Rows[PersonCB.SelectedIndex]["PSijainti"].ToString();
            EmailLB.Text = connection.Rows[PersonCB.SelectedIndex]["PEmail"].ToString();
            PersonphoneLB.Text = connection.Rows[PersonCB.SelectedIndex]["PPhone"].ToString();
        }

        private void fillLocationTable()
        {
            location.Columns.Add("LID", typeof(int));
            location.Columns.Add("LName");
            location.Columns.Add("LAddress");
            location.Columns.Add("LPostal");
            location.Columns.Add("LCity");
            location.Columns.Add("LPhone");

            location.Rows.Add(1, "StadinAO", "Hattulantie 2", "00550", "Helsinki", "09 310 8600");
            location.Rows.Add(2, "Omnia", "Armas Launiksen katu 9", "02650", "Espoo", "046 877 1371");
            location.Rows.Add(3, "Varia", "Rälssitie 13", "01530", "Vantaa", "040 182 4668");
            location.Rows.Add(4, "Keuda", "Sibeliuksenväylä 55 A", "04400", "Järvenpää", "09 27 381");
        }

        private void fillPeopleTable()
        {
            people.Columns.Add("LID", typeof(int));
            people.Columns.Add("PName");
            people.Columns.Add("PTitle");
            people.Columns.Add("PSijainti");
            people.Columns.Add("PEmail");
            people.Columns.Add("PPhone");

            people.Rows.Add(1, "Sirpa Lindroos", "Rehtori", "Kampus 1", "sirpa.lindroos@hel.fi", "050 540 4434");
            people.Rows.Add(1, "Hanna Laurila", "Rehtori", "Kaupus 2", "hanna.laurila@hel.fi", "040 676 5583");
            people.Rows.Add(1, "Annele Ranta", "Rehtori", "Kampus 3", "annele.ranta@hel.fi", "040 631 5667");
            people.Rows.Add(1, "Eeva Sahlman", "Rehtori", "Kampus 4", "eeva.sahlman@hel.fi", "040 336 1017");
            people.Rows.Add(1, "Marko Aaltonen", "Rehtori", "Kampus 5", "marko.aaltonen@hel.fi", "050 511 8115");
            people.Rows.Add(2, "Tuula Antola", "Koulutuskuntayhtymän johtaja", "Yleishallinto", "tuula.antola@omnia.fi", "");
            people.Rows.Add(2, "Tapio Siukonen", "Hallintojohtaja", "Yleishallinto", "tapio.siukonen@omnia.fi", "044 369 6600");
            people.Rows.Add(2, "Tuukko Soini", "Kehittämisjohtaja", "Yleishallinto", "tuukka.soini@omnia.fi", "046 877 2952");
            people.Rows.Add(2, "Riikka-Maria Yli-Suomu", "Liiketoimintajohtaja", "Elinvoima- ja työllisyyspalvelut", "riikka-maria.yli-suomu@omnia.fi", "050 348 6544");
            people.Rows.Add(2, "Maija Aaltola", "Rehtori", "Koulutus- ja opiskelijapalvelut", "maija-aaltola@omnia.fi", "050 384 9354");
            people.Rows.Add(2, "Kai Iivari", "Talousjohtaja", "Talous ja hankintapalvelut", "kai.iivari@omnia.fi", "0400 306 691");
            people.Rows.Add(2, "Päivi Korhonen", "Viestintäjohtaja", "Viestintä- ja markkinointipalvelut", "paivi.korhonen@omnia.fi", "040 126 7599");
            people.Rows.Add(3, "Pekka Tauriainen", "Rehtori", "", "pekka.tauriainen@vantaa.fi", "050 312 4514");
            people.Rows.Add(3, "Anne Heinonen", "Työelämäpalvelupäällikkö", "", "anne.heinonen@vantaa.fi", "040 524 1242");
            people.Rows.Add(3, "Tuula Kiistinen", "Yhteisten palveluiden päällikkö", "", "tuula.kiiskinen@vantaa.fi", "040 193 9048");
            people.Rows.Add(4, "Tiina Halmevuo", "Kuntayhtymän johtaja", "Hallinto- ja johtamispalvelut", "tiina.halmevuo@keuda.fi", "050 336 9709");
            people.Rows.Add(4, "Anna Mari Leinonen", "Rehtori", "Hallinto", "annamari.leinonen@keuda.fi", "040 174 4523");
            people.Rows.Add(4, "Anne Vuorinen", "Johtaja", "Yritys- ja elinvoimapalvelut", "anne.vuorinen@keuda.fi", "050 415 0974");
            people.Rows.Add(4, "Hanna Nyrönen", "Viestintä- ja markkinointipäällikkö", "Viestintäpalvelut", "hanna.nyronen@keuda.fi", "040 521 8428");
            people.Rows.Add(4, "Maarit Flinck", "Asianhallintapäällikkö", "Hallinto- ja johtamispalvelut", "maarit.flinck@keuda.fi", "0500 837 357");
        }
    }
}