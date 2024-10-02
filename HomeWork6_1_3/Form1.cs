using HomeWork6_1_3.DbModels;

namespace HomeWork6_1_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            using (var db = new Homework612Context()) {
                var products = db.Products.ToList();

                dgvProducts.DataSource = products;
            }
        }
    }
}
