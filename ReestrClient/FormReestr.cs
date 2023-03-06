﻿using MaterialSkin.Controls;
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

        private async void PopulateTreeView()
        {
            // Получаем список всех объектов Equipment, отсортированных по Storage_id и Name
            List<Equipment> equipmentList = await GetEquipmentList();
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
                    TreeNode equipmentTreeNode = new TreeNode(equipmentNode.NameInList);
                    equipmentTreeNode.Tag = equipmentNode.Id;
                    rootNode.Nodes.Add(equipmentTreeNode);

                    TreeNode idNode = new TreeNode($"Id: {equipmentNode.Id}");
                    equipmentTreeNode.Nodes.Add(idNode);

                    TreeNode nameInListNode = new TreeNode($"Название по ведомости: {equipmentNode.NameInList}");
                    equipmentTreeNode.Nodes.Add(nameInListNode);
                    // Добавляем дочерние узлы для дополнительной информации об оборудовании
                    TreeNode accountingNode = new TreeNode($"Учет/Не учет: {equipmentNode.Accounting}");
                    equipmentTreeNode.Nodes.Add(accountingNode);

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

                    TreeNode requiredNode = new TreeNode($"Требуется: {equipmentNode.Required}");
                    equipmentTreeNode.Nodes.Add(requiredNode);


                    /*
                    отображать следующую информацию:
                    - Название оборудования
                    - прибор/расходник
                    - если прибор, то на балансе / не на балансе
                    - если на балансе, то название по ведомости
                    - если на балансе, то инвентарный номер (это число многоразрядное, но может быть и прочерк)
                    - если на балансе, то Балансовая стоимость (в рублях)
                    - если на балансе, то Сумма амортизации (в рублях)
                    - если на балансе, то Остаточная стоимость (в рублях)
                    - если прибор, то работает/не работает/ремонтопригодно/требуются компоненты
                    - где хранится
                    - если прибор, то в какой работе используется
                    - если расходник, то к какому/каким приборам (список ссылок)
                    - статус: используется/может использоваться/требуется списание с баланса/списано с баланса, но используется/поставить на баланс/выбросить/требуется ремонт/требуется утилизация/утилизировано/требуется передать
                    - место передачи, если статус Требуется передать
                    - комментарий
                     */
                }
            }
        }

        private async Task<List<Equipment>> GetEquipmentList()
        {
            try
            {
                var (equip,error) = await data.Get<Equipment>(authInfo.access_token, "Equipments");
                if (equip != null)
                {
                    MessageBox.Show("equip: "+equip.Count.ToString());
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
                var (status, error) = await data.Get<Status>(authInfo.access_token, "Status");
                if (status != null)
                {
                    MessageBox.Show("status: " + status.Count.ToString());
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
                var (storages, error) = await data.Get<Storage>(authInfo.access_token, "Storages");
                if (storages != null)
                {
                    MessageBox.Show("storages: " + storages.Count.ToString());
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
                var (states, error) = await data.Get<State>(authInfo.access_token, "States");
                if (states != null)
                {
                    MessageBox.Show("states: " + states.Count.ToString());
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
                comboBoxAccounting.Text = equipment.Accounting.ToString();
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
                comboBoxUsages.Text = equipment.Usages.ToString();
                textBoxTransferTo.Text = equipment.TransferTo;
                textBoxFactCount.Text = equipment.CountFact.ToString();
                textBoxListCount.Text = equipment.CountInList.ToString();
            }
            else
            {
                textBoxName.Text = "";
                comboBoxAccounting.Text = "";
                textBoxInventoryNumber.Text = "";
                textBoxNameInList.Text = "";
                textBoxInventoryNumber.Text = "";
                textBoxBalanceValue.Text = "";
                textBoxDeprecation.Text = "";
                textBoxResidualValue.Text = "";
                comboBoxStatus.Text = "";
                richTextBoxRequired.Text = "";
                comboBoxStorage.Text = "";
                comboBoxUsages.Text = "";
                textBoxTransferTo.Text = "";
                textBoxFactCount.Text = "";
                textBoxListCount.Text = "";
            }
        }

        private async void materialButtonCreate_Click(object sender, EventArgs e)
        {
            // создание нового объекта
            Equipment equipment = new Equipment();
            equipment.Name = textBoxName.Text;
            if (comboBoxAccounting.Text == "Учет")
            {
                equipment.Accounting = true;
            }
            else
            {
                equipment.Accounting = false;
            }
            equipment.InventoryNumber = textBoxInventoryNumber.Text;
            equipment.NameInList = textBoxNameInList.Text;
            equipment.InventoryNumber = textBoxInventoryNumber.Text;
            equipment.BalanceValue = float.Parse(textBoxBalanceValue.Text);
            equipment.Depreciation = float.Parse(textBoxDeprecation.Text);
            equipment.ResidualValue = float.Parse(textBoxResidualValue.Text);
            equipment.Status_id = statuses.Find(s => s.Name == comboBoxStatus.Text).Id;
            equipment.State_id = states.Find(s => s.Name == comboBoxState.Text).Id;
            equipment.Required = richTextBoxRequired.Text;
            equipment.Storage_id = storages.Find(s => s.Name == comboBoxStorage.Text).Id;
            if (comboBoxUsages.Text == "Используется")
            {
                equipment.Usages = true;
            }
            else
            {
                equipment.Usages = false;
            }
            equipment.TransferTo = textBoxTransferTo.Text;
            equipment.CountFact = Convert.ToInt32(textBoxFactCount.Text);
            equipment.CountInList = Convert.ToInt32(textBoxListCount.Text);
            if (equip.Any(e => e.Id.ToString() == textBoxID.Text))
            {
                equipment.Id = Convert.ToInt32(textBoxID.Text);
            }
            else
            {
                equipment.Id = 0;
            }
            // отправка на сервер
            string message = "";
            try
            {
                message = await data.Post<Equipment>(authInfo.access_token, "Equipments", equipment);
                if (message == "Created")
                {
                    MessageBox.Show("Создано");
                }
                else
                    MessageBox.Show(message);
            } 
            catch
            {
                MessageBox.Show(message);
            }
            UpdateAll();
        }

        private void materialButtonUpdate_Click(object sender, EventArgs e)
        {


        }

        private async void materialButtonDelete_Click(object sender, EventArgs e)
        {
            // удаление
            string message = "";
            try
            {
                message = await data.Delete(authInfo.access_token, "Equipments", Convert.ToInt32(textBoxID.Text));
                if (message == "Created")
                {
                    MessageBox.Show("Удалено");
                }
                else
                    MessageBox.Show(message);
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
    }
}
