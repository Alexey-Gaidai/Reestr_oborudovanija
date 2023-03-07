using MaterialSkin.Controls;
using ReestrClient.Models;
using ReestrClient.Service;
using ReestrClient.ServiceUseCases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReestrClient
{
    public partial class FormReestr : MaterialForm
    {
        DataUseCases data = new DataImpl();
        AuthInfo authInfo = new AuthInfo();
        List<Equipment> equip = new List<Equipment>();
        List<Storage> storages = new List<Storage>();
        List<Status> statuses = new List<Status>();
        List<State> states = new List<State>();
        Equipment singleEquipment; 
        public FormReestr()
        {
            InitializeComponent();
        }

        public FormReestr(AuthInfo _authInfo)
        {
            authInfo = _authInfo;
            InitializeComponent();
            GetAllData();
        }

        private void InitBoxes()
        {
            comboBoxStorage.DataSource = storages;
            comboBoxStorage.DisplayMember = "Name";
            comboBoxStorage.ValueMember = "Id";

            comboBoxStatus.DataSource = statuses;
            comboBoxStatus.DisplayMember = "Name";
            comboBoxStatus.ValueMember = "Id";

            comboBoxState.DataSource = states;
            comboBoxState.DisplayMember = "Name";
            comboBoxState.ValueMember = "Id";

            comboBoxUsages.Items.Add("Используется");
            comboBoxUsages.Items.Add("Не используется");

            comboBoxAccounting.Items.Add("Учет");
            comboBoxAccounting.Items.Add("Не учет");

        }

        private async void GetAllData()
        {
            equip = await GetEquipmentList();
            storages = await GetStorageList();
            statuses = await GetStatusList();
            states = await GetStatesList();
            InitBoxes();
            PopulateTreeView();
        }

        private void PopulateTreeView()
        {
            // Получаем список всех объектов Equipment, отсортированных по Storage_id и Name
            List<Equipment> equipmentList = equip;
            equipmentList.OrderBy(e => e.Storage_id)
                         .ThenBy(e => e.Name)
                         .ToList();
            // Создаем корневые узлы TreeView для каждого уникального Storage_id
            var storageNodes = equipmentList.GroupBy(e => e.Storage_id)
                                            .Select(g => new { Storage_id = g.Key })
                                            .ToList();

            foreach (var storageNode in storageNodes)
            {
                // Создаем корневой узел для каждого Storage_id
                TreeNode rootNode = new TreeNode(storages.Find(s => s.Id == storageNode.Storage_id).Name);
                rootNode.Tag = storageNode.Storage_id;
                treeViewDeprecation.Nodes.Add(rootNode);

                // Добавляем дочерние узлы для каждого объекта Equipment в соответствующем Storage_id
                var equipmentNodes = equipmentList.Where(e => e.Storage_id == storageNode.Storage_id).ToList();
                foreach (var equipmentNode in equipmentNodes)
                {
                    TreeNode equipmentTreeNode = new TreeNode(equipmentNode.Name);
                    equipmentTreeNode.Tag = equipmentNode.Id;
                    rootNode.Nodes.Add(equipmentTreeNode);

                    TreeNode idNode = new TreeNode($"Id: {equipmentNode.Id}");
                    equipmentTreeNode.Nodes.Add(idNode);

                    TreeNode nameInListNode = new TreeNode($"Название по ведомости: {equipmentNode.NameInList}");
                    equipmentTreeNode.Nodes.Add(nameInListNode);
                    // Добавляем дочерние узлы для дополнительной информации об оборудовании
                    TreeNode accountingNode = new TreeNode($"Учет/Не учет: {equipmentNode.Accounting}");
                    equipmentTreeNode.Nodes.Add(accountingNode);

                    TreeNode usagesNode = new TreeNode($"Используется/Не исспользуется: {equipmentNode.Usages}");
                    equipmentTreeNode.Nodes.Add(usagesNode);

                    TreeNode inventoryNumberNode = new TreeNode($"Инвентарный номер: {equipmentNode.InventoryNumber}");
                    equipmentTreeNode.Nodes.Add(inventoryNumberNode);

                    TreeNode balanceValueNode = new TreeNode($"Балансовая стоимость: {equipmentNode.BalanceValue}");
                    equipmentTreeNode.Nodes.Add(balanceValueNode);

                    TreeNode depreciationNode = new TreeNode($"Сумма амортизации: {equipmentNode.Depreciation}");
                    equipmentTreeNode.Nodes.Add(depreciationNode);

                    TreeNode residualValueNode = new TreeNode($"Остаточная стоимость: {equipmentNode.ResidualValue}");
                    equipmentTreeNode.Nodes.Add(residualValueNode);

                    TreeNode statusNode = new TreeNode($"Статус: {equipmentNode.Status_id}");
                    equipmentTreeNode.Nodes.Add(statusNode);

                    if (statuses.Find(s => s.Id == equipmentNode.Status_id).Name == "Передача")
                    {
                        TreeNode transferToNode = new TreeNode($"Место передачи: {equipmentNode.TransferTo}");
                        equipmentTreeNode.Nodes.Add(transferToNode);
                    }
                    TreeNode requiredNode = new TreeNode($"Требуется: {equipmentNode.Required}");
                    equipmentTreeNode.Nodes.Add(requiredNode);
                }
            }
        }

        private async Task<List<Equipment>> GetEquipmentList()
        {
            try
            {
                var (equip,error) = await data.Get<Equipment>(authInfo, "Equipments");
                if (equip != null)
                {
                    return equip;
                }
                return equip;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            throw new NotImplementedException();
        }
        private async Task<List<Status>> GetStatusList()
        {
            try
            {
                var (status, error) = await data.Get<Status>(authInfo, "Status");
                if (status != null)
                {
                    return status;
                }
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            throw new NotImplementedException();
        }
        private async Task<List<Storage>> GetStorageList()
        {
            try
            {
                var (storages, error) = await data.Get<Storage>(authInfo, "Storages");
                if (storages != null)
                {
                    return storages;
                }
                return storages;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            throw new NotImplementedException();
        }
        private async Task<List<State>> GetStatesList()
        {
            try
            {
                var (states, error) = await data.Get<State>(authInfo, "States");
                if (states != null)
                {
                    return states;
                }
                return states;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            throw new NotImplementedException();
        }


        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            //подставление значений по существующему оборудованию
            if (equip.Any(e => e.Id.ToString() == textBoxID.Text))
            {
                var equipment = equip.Find(e => e.Id.ToString() == textBoxID.Text);
                textBoxName.Text = equipment.Name;
                if (equipment.Accounting == true)
                {
                    comboBoxAccounting.Text = "Учет";
                }
                else
                {
                    comboBoxAccounting.Text = "Не учет";
                }
                textBoxInventoryNumber.Text = equipment.InventoryNumber;
                textBoxNameInList.Text = equipment.NameInList;
                textBoxInventoryNumber.Text = equipment.InventoryNumber;
                textBoxBalanceValue.Text = equipment.BalanceValue.ToString();
                textBoxDeprecation.Text = equipment.Depreciation.ToString();
                textBoxResidualValue.Text = equipment.ResidualValue.ToString();
                comboBoxStatus.Text = statuses.Find(s => s.Id == equipment.State_id).Name;
                comboBoxState.Text = states.Find(s => s.Id == equipment.State_id).Name;
                richTextBoxRequired.Text = equipment.Required;
                comboBoxStorage.Text = storages.Find(s => s.Id == equipment.Storage_id).Name;
                if (equipment.Usages == true)
                {
                    comboBoxUsages.Text = "Используется";
                }
                else
                {
                    comboBoxUsages.Text = "Не используется";
                }
                textBoxTransferTo.Text = equipment.TransferTo;
                textBoxFactCount.Text = equipment.CountFact.ToString();
                textBoxListCount.Text = equipment.CountInList.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxInventoryNumber.Text = "";
                textBoxNameInList.Text = "";
                textBoxInventoryNumber.Text = "";
                textBoxBalanceValue.Text = "";
                textBoxDeprecation.Text = "";
                textBoxResidualValue.Text = "";
                richTextBoxRequired.Text = "";
                textBoxTransferTo.Text = "";
                textBoxFactCount.Text = "";
                textBoxListCount.Text = "";
            }
        }

        private async void materialButtonCreate_Click(object sender, EventArgs e)
        {
            bool isCreated = CreateEquipment();
            if (!isCreated)
                return;
            else
            {
                Equipment equipment = singleEquipment;
                string message = "";
                try
                {
                    message = await data.Post<Equipment>(authInfo, "Equipments", equipment);
                    MessageBox.Show("Создано");
                }
                catch
                {
                    MessageBox.Show(message);
                }
                UpdateAll();
            }
        }

        private async void materialButtonUpdate_Click(object sender, EventArgs e)
        {
            bool isCreated = CreateEquipment();
            if (!isCreated)
                return;
            else 
            {
                Equipment equipment = singleEquipment;
                string message = "";
                try
                {
                    message = await data.Put<Equipment>(authInfo, "Equipments", equipment.Id, equipment);
                    MessageBox.Show("Обновлено");
                }
                catch
                {
                    MessageBox.Show(message);
                }
            }
        }

        // метод который создает новый объект equipment из введенных данных
        private bool CreateEquipment()
        {
            singleEquipment = new Equipment();
            try
            {
                singleEquipment.Name = textBoxName.Text;
                if (comboBoxAccounting.Text == "Учет")
                {
                    singleEquipment.Accounting = true;
                }
                else
                {
                    singleEquipment.Accounting = false;
                }
                singleEquipment.InventoryNumber = textBoxInventoryNumber.Text;
                singleEquipment.NameInList = textBoxNameInList.Text;
                singleEquipment.InventoryNumber = textBoxInventoryNumber.Text;
                singleEquipment.BalanceValue = float.Parse(textBoxBalanceValue.Text);
                singleEquipment.Depreciation = float.Parse(textBoxDeprecation.Text);
                singleEquipment.ResidualValue = float.Parse(textBoxResidualValue.Text);
                singleEquipment.Status_id = statuses.Find(s => s.Name == comboBoxStatus.Text).Id;
                singleEquipment.State_id = states.Find(s => s.Name == comboBoxState.Text).Id;
                singleEquipment.Required = richTextBoxRequired.Text;
                singleEquipment.Storage_id = storages.Find(s => s.Name == comboBoxStorage.Text).Id;
                if (comboBoxUsages.Text == "Используется")
                {
                    singleEquipment.Usages = true;
                }
                else
                {
                    singleEquipment.Usages = false;
                }
                singleEquipment.TransferTo = textBoxTransferTo.Text;
                singleEquipment.CountFact = Convert.ToInt32(textBoxFactCount.Text);
                singleEquipment.CountInList = Convert.ToInt32(textBoxListCount.Text);
                if (equip.Any(e => e.Id.ToString() == textBoxID.Text))
                {
                    singleEquipment.Id = Convert.ToInt32(textBoxID.Text);
                }
                else
                {
                    singleEquipment.Id = 0;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Прверьте введенные данные");
                return false;
            }
        }

        private async void materialButtonDelete_Click(object sender, EventArgs e)
        {
            // удаление
            string message = "";
            try
            {
                message = await data.Delete(authInfo, "Equipments", Convert.ToInt32(textBoxID.Text));
                MessageBox.Show("Удалено");
            }
            catch
            {
                MessageBox.Show(message);
            }
            UpdateAll();
        }

        //метод обновления дерева и полей
        private void UpdateAll()
        {
            treeViewDeprecation.Nodes.Clear();
            equip.Clear();
            statuses.Clear();
            storages.Clear();
            states.Clear();
            textBoxID.Clear();
            textBoxName.Clear();
            comboBoxAccounting.Items.Clear();
            textBoxInventoryNumber.Clear();
            textBoxNameInList.Clear();
            textBoxBalanceValue.Clear();
            textBoxDeprecation.Clear();
            textBoxResidualValue.Clear();
            richTextBoxRequired.Clear();
            textBoxTransferTo.Clear();
            textBoxFactCount.Clear();
            textBoxListCount.Clear();
            GetAllData();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxStatus.Text == statuses.Find(s => s.Name == "Передача").Name)
            {
                textBoxTransferTo.Enabled = true;
            }
            else
            {
                textBoxTransferTo.Enabled = false;
                textBoxTransferTo.Text = "";
            }
        }
    }
}
