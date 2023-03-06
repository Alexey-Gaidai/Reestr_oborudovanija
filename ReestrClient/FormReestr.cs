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
        public FormReestr()
        {
            InitializeComponent();
        }

        public FormReestr(AuthInfo _authInfo)
        {
            authInfo = _authInfo;
            InitializeComponent();
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
                TreeNode rootNode = new TreeNode($"Storage {storageNode.Storage_id}");
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
                var (equip,error) = await data.GetEquipment(authInfo.access_token, "");
                if (equip != null)
                {
                    MessageBox.Show(error);
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

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
