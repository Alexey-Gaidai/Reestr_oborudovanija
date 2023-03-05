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
                treeView1.Nodes.Add(rootNode);

                // Добавляем дочерние узлы для каждого объекта Equipment в соответствующем Storage_id
                var equipmentNodes = equipmentList.Where(e => e.Storage_id == storageNode.Storage_id).ToList();
                foreach (var equipmentNode in equipmentNodes)
                {
                    TreeNode equipmentTreeNode = new TreeNode(equipmentNode.NameInList);
                    equipmentTreeNode.Tag = equipmentNode.Id;
                    rootNode.Nodes.Add(equipmentTreeNode);
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
    }
}
