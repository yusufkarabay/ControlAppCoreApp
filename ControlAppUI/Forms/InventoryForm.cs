using AutoMapper;
using ControlApp.Core.DTOs;
using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.Services;
using ControlApp.Core.UnitOfWorks;
using ControlApp.Repository;
using ControlApp.Repository.Repositories;
using ControlApp.Repository.UnitofWorks;
using ControlApp.Service.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlAppDesktop.Forms
{

    public partial class InventoryForm : Form
    {
        public Guid userId;

        private readonly IUnitOfWork unitOfWork;
        private readonly IInventoryRepository inventoryRepository;
        private readonly IInventoryService inventoryService;
        private readonly IUserService userService;
        private readonly IUserRepository userRepository;
        public InventoryForm()
        {
            var db = new ControlAppDbContext();
            unitOfWork = new UnitOfWork(db);
            inventoryRepository= new InventoryRepository(db, unitOfWork);
            inventoryService=new InventoryService(unitOfWork, inventoryRepository);
            userRepository= new UserRepoistory(db, unitOfWork);
            userService=new UserService(userRepository, unitOfWork);
            InitializeComponent();
        }
        public void FormGet(Form form)
        {
            form.MdiParent = this;

            form.Show();
        }
        async Task DataGridSettings(DataGridView dataGridView)
        {
            dataGridView.BorderStyle=BorderStyle.None;
            dataGridView.BackgroundColor=Color.LightGray;
            dataGridView.DefaultCellStyle.SelectionBackColor=Color.FromArgb(26, 110, 145);
            dataGridView.EnableHeadersVisualStyles=false;
        }
        async Task DataGridInventoryHeader()
        {
            dgvInventory.Columns["SerialNumber"].HeaderText="Seri No";
            dgvInventory.Columns["Name"].HeaderText="Envanter Adı";
            dgvInventory.Columns["Amount"].HeaderText ="Miktar";
            dgvInventory.Columns["Info"].HeaderText ="Açıklama";
            dgvInventory.Columns["CreatedBy"].HeaderText ="Oluşturan Personel";
            dgvInventory.Columns["CreatedDate"].HeaderText ="Oluşturma Zamanı";
            dgvInventory.Columns["Id"].Visible=false;
        }
        async Task AllInventoryList()
        {
            var userInfo = await userService.GetByIdAsync(userId);
            var departmentId = Guid.Parse(userInfo.Item1.DepartmentId.ToString());
            if (userInfo.Item1!=null)
            {
                var allInventories = inventoryService.GetAllInventory(departmentId).Result;
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Inventory, InventoryDto>()).CreateMapper();
                var returnAllInventory = mapper.Map<List<InventoryDto>>(allInventories);
                if (returnAllInventory.Count==0)
                {
                    MessageBox.Show("Envanter listesi boş",
                        "Kayıt Yok",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                dgvInventory.DataSource =returnAllInventory;
                await DataGridInventoryHeader();
            }
        }
        private async void btnList_Click(object sender, EventArgs e)
        {
            var userInfo = await userService.GetByIdAsync(userId);
            var departmentId = Guid.Parse(userInfo.Item1.DepartmentId.ToString());
            if (userInfo.Item1!=null)
            {
                var dateInventories = inventoryService.GetAddedDateInventory(departmentId, Convert.ToDateTime(dtpInventory.Value.ToString("yyyy-MM-dd"))).Result;
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Inventory, InventoryDto>()).CreateMapper();
                var returnDateInventory = mapper.Map<List<InventoryDto>>(dateInventories);
                if (returnDateInventory.Count==0)
                {
                    MessageBox.Show("Seçilen tarihte envanter eklenmedi",
                        "Kayıt Yok",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                dgvInventory.DataSource =returnDateInventory;
                await DataGridInventoryHeader();
            }
        }
        private async void btnAllList_Click(object sender, EventArgs e)
        {
            AllInventoryList();
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtbxInventorySeriNo.Text=="" || txtbxInventorySeriNo.Text==null)
            {
                MessageBox.Show("Seri No Boş Bırakılamaz",
                   "Envanter Hatası",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }
            if (txtbxInventoryName.Text=="" || txtbxInventoryName.Text==null)
            {
                MessageBox.Show("Envanter Adı Boş Bırakılamaz",
                   "Envanter Hatası",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }
            if (txtbxAmount.Text=="" || txtbxAmount.Text==null||txtbxAmount.Text=="0")
            {
                MessageBox.Show("Envanter Miktarı Boş Bırakılamaz",
                   "Envanter Hatası",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }
            var inventory = new Inventory();
            var userInfo = await userService.GetByIdAsync(userId);
            var departmentId = Guid.Parse(userInfo.Item1.DepartmentId.ToString());
            var inventoryControl = inventoryService.Where(x => x.DepartmentId==departmentId&&x.SerialNumber== txtbxInventorySeriNo.Text).FirstOrDefault();
            if (inventoryControl!=null)
            {
                MessageBox.Show("Eklenen seri numarasından daha önce envanter eklenmiştir",
                  "Envanter Hatası",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return;
            }
            if (userInfo.Item1!=null)
            {
                inventory.SerialNumber=txtbxInventorySeriNo.Text;
                inventory.Name=txtbxInventoryName.Text;
                inventory.DepartmentId=Guid.Parse(userInfo.Item1.DepartmentId.ToString());
                inventory.Amount=int.Parse(txtbxAmount.Text);
                inventory.Info=rtxbxInventoryInfo.Text;
                inventory.LastModifiedBy=userInfo.Item1.Name+" "+userInfo.Item1.Surname;
                inventory.CreatedBy=userInfo.Item1.Name+" "+userInfo.Item1.Surname;
                inventory.CreatedDate=dtpInventory.Value;
                var result = await inventoryService.AddAsync(inventory);
                if (result.Item2==null)
                {
                    txtbxAmount.Text=null;
                    txtbxInventoryName.Text=null;
                    txtbxInventorySeriNo.Text=null;
                    rtxbxInventoryInfo.Text=null;
                    MessageBox.Show("Envanter eklendi",
                       "Envanter Bilgisi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                if (result.Item2!=null)
                {
                    MessageBox.Show("Envanter eklemede hata oluştu lütfen sistem yöneticisine bilgi veriniz",
                       "Envanter Ekleme Hatası",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Giriş yapan personel bilgilerine ulaşılamadı.Lüfen sistem yöneticisine başvurunuz",
                     "Personel Bilgisi Hatası",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return;
            }
        }
        private async void deleteInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null)
            {
                MessageBox.Show("Silmek İçin Bir Kayıt Seçiniz");
                return;
            }
            var inventory = inventoryService.GetByIdAsync(Guid.Parse(dgvInventory.CurrentRow.Cells["Id"].Value.ToString())).Result;
            DialogResult dialogResult = MessageBox.Show("Seçili Envanteri Silmek İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (dgvInventory.Enabled==true)
                {
                    dgvInventory.Enabled=false;
                }
            }
            if (dialogResult==DialogResult.No)
            {
                if (dgvInventory.Enabled==false)
                {
                    dgvInventory.Enabled=true;
                }
                return;
            }
            inventoryRepository.Delete(inventory);
            if (dgvInventory.Enabled==false)
            {
                dgvInventory.Enabled=true;
            }
            await AllInventoryList();
        }
        private async void refreshInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllInventoryList();
        }
        private void updateInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows == null)
            {
                MessageBox.Show("Listeden Güncellenecek İş seçiniz");
                return;
            }
            var inventory = inventoryService.GetByIdAsync(Guid.Parse(dgvInventory.CurrentRow.Cells["Id"].Value.ToString())).Result;
            DialogResult dialogResult = MessageBox.Show("Seçili Envanteri Güncelleme Yapmak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (dgvInventory.Enabled==true)
                {
                    dgvInventory.Enabled=false;
                }
                txtbxInventoryName.Text=inventory.Name;
                txtbxAmount.Text=inventory.Amount.ToString();
                txtbxInventorySeriNo.Text=inventory.SerialNumber;
                rtxbxInventoryInfo.Text=inventory.Info;
            }
            if (dialogResult==DialogResult.No)
            {
                if (dgvInventory.Enabled==false)
                {
                    dgvInventory.Enabled=true;
                }
                return;
            }
            if (btnUpdate.Visible == false)
            {
                btnUpdate.Visible = true;
            }
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtbxInventorySeriNo == null)
            {
                MessageBox.Show("Seri Numarası Alanı Boş Bırakılamaz");
                return;
            }
            else if (txtbxInventoryName == null)
            {
                MessageBox.Show("Envanter Adı Alanı Boş Bırakılamaz");
                return;
            }
            else if (txtbxAmount == null)
            {
                MessageBox.Show("Envanter Miktarı Boş Bırakılamaz");
                return;
            }
            var userInfo = await userService.GetByIdAsync(userId);
            var inventory = inventoryService.GetByIdAsync(Guid.Parse(dgvInventory.CurrentRow.Cells["Id"].Value.ToString())).Result;
            DialogResult dialogResult = MessageBox.Show("Seçili Envanteri Güncellemek İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                inventory.SerialNumber = txtbxInventorySeriNo.Text;
                inventory.CreatedDate = Convert.ToDateTime(dtpInventory.Value.ToString("yyyy-MM-dd"));
                inventory.Amount = int.Parse(txtbxAmount.Text);
                inventory.Info = rtxbxInventoryInfo.Text;
                inventory.Name = txtbxInventoryName.Text;
                inventory.CreatedBy=userInfo.Item1.Name+" "+userInfo.Item1.Surname;
                inventoryRepository.Update(inventory);
                if (dgvInventory.Enabled==false)
                {
                    dgvInventory.Enabled=true;
                }
                else
                {
                    MessageBox.Show("İlk seçilen envanterden başkasını güncellemeye çalıştınız lütfen yeniden seçim yapınız",
                    "Envanter Güncelleme Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    txtbxAmount.Text = "";
                    txtbxInventoryName.Text = "";
                    txtbxInventorySeriNo.Text = "";
                    rtxbxInventoryInfo.Text = "";
                    return;
                }
            }
            if (dialogResult == DialogResult.No)
            {
                if (dgvInventory.Enabled==false)
                {
                    dgvInventory.Enabled=true;
                }
            }
            txtbxAmount.Text = "";
            txtbxInventoryName.Text = "";
            txtbxInventorySeriNo.Text = "";
            rtxbxInventoryInfo.Text = "";
            await AllInventoryList();
            if (btnUpdate.Visible == true)
            {
                btnUpdate.Visible = false;
            }
            btnUpdate.Visible = false;
        }
        private void txtbzxSearchInventory_MouseClick(object sender, MouseEventArgs e)
        {
            txtbxtSearchInventoryName.Clear();

        }
        public string Html_Out(DataGridView dg)
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine("<html><head><meta charset=utf-8><style>table{padding:10px;} th,td{padding:8px;}</style></head><body><center><table border='1' cellpadding='0' cellspacing='0'>");
            strB.AppendLine("<tr>");
            for (int i = 0; i < dg.Columns.Count; i++) { if (dg.Columns[i].Visible == true) { strB.AppendLine("<th align='center' valign='middle'>" + dg.Columns[i].HeaderText + "</th>"); } }
            strB.AppendLine("</tr>");
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                if (dg.Rows[i].Visible)
                {
                    strB.AppendLine("<tr>");
                    foreach (DataGridViewCell dgvc in dg.Rows[i].Cells)
                    {
                        if (dgvc.OwningColumn.Visible == true) { strB.AppendLine("<td align='center' valign='middle'>" + dgvc.Value.ToString() + "</td>"); }
                    }
                    strB.AppendLine("</tr>");
                }
            }
            strB.AppendLine("</table></center>");
            strB.AppendLine("</body></html>");
            return strB.ToString();
        }
        private void btnInventoryWeb_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Envanter Listesini HTML Ortamında Masaüstü'ne Kaydetmek İstiyor Musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {

                string content = Html_Out(dgvInventory);
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.WriteAllText(desktopPath + "\\ Envanter Listesi.html", content);
                MessageBox.Show("Envanter Listesi HTML Formatında Masaüstüne Kaydedildi...");
            }
        }
        private async void InventoryForm_Load(object sender, EventArgs e)
        {
            await DataGridSettings(dgvInventory);
        }
        private async void txtbxtSearchInventory_TextChanged(object sender, EventArgs e)
        {

            var userInfo = await userService.GetByIdAsync(userId);
            var departmentId = Guid.Parse(userInfo.Item1.DepartmentId.ToString());
            if (txtInventorySearchSeriNo.Text=="")
            {
                return;
            }

            var inventory = inventoryService.Where(x => x.DepartmentId==departmentId &&x.Name.Contains(txtbxtSearchInventoryName.Text)).ToList();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Inventory, InventoryDto>()).CreateMapper();
            var returnAllInventory = mapper.Map<List<InventoryDto>>(inventory);
            dgvInventory.DataSource=returnAllInventory;
            await DataGridInventoryHeader();
            if (dgvInventory.RowCount<1)
            {
                await DataGridInventoryHeader();
                MessageBox.Show("Ürün Bulunamadı",
                     "Envanter Bilgisi Hatası",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
            }
            await DataGridInventoryHeader();

        }
        private async void txtInventorySearchSeriNo_TextChanged(object sender, EventArgs e)
        {
            var userInfo = await userService.GetByIdAsync(userId);
            var departmentId = Guid.Parse(userInfo.Item1.DepartmentId.ToString());
            if (txtInventorySearchSeriNo.Text=="")
            {
                return;
            }

            var inventory = inventoryService.Where(x => x.DepartmentId==departmentId &&x.SerialNumber.Contains(txtInventorySearchSeriNo.Text)).ToList();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Inventory, InventoryDto>()).CreateMapper();
            var returnAllInventory = mapper.Map<List<InventoryDto>>(inventory);
            dgvInventory.DataSource=returnAllInventory;
            await DataGridInventoryHeader();
            if (dgvInventory.RowCount<1)
            {
                await DataGridInventoryHeader();
                MessageBox.Show("Ürün Bulunamadı",
                     "Envanter Bilgisi Hatası",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
            }
            await DataGridInventoryHeader();
        }
        private void txtInventorySearchSeriNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtInventorySearchSeriNo.Clear();

        }
        private void txtbxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
