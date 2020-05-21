using storeSystem.Data;
using storeSystem.Data.Models;
using storeSystem.Mappers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storeSystem
{
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
            //OrderTab_InventoryCheckBox.Enabled = true;
            OrderTab_InventoryCheckBox.ItemCheck += OrderTab_InventoryCheckBox_ItemCheck;
            OrderTab_CategorySelectionBox.SelectedIndexChanged += OrderTabCategorySelectionBox_SelectedIndexChanged;
            OrderTab_BasketBox.SelectedIndexChanged += BasketBox_SelectedIndexChanged;

            AddNewTab_SaveNewItemButton.Click += AddNewTab_SaveNewItemButton_Click;

            ShowUserBox.Text = SetUserNameDisplay.username;
        }

        public void SetCategoryList(IList<StoreInventoryCategory> storeInventoryCategory)
        {        
            foreach (var category in storeInventoryCategory)
            {
                OrderTab_CategorySelectionBox.Items.Add(category);
                AddNewItemTab_CategorySelectionBox.Items.Add(category);
            }
            OrderTab_CategorySelectionBox.SelectedIndex = 0;
        }

        public void SetInventoryList(IList<StoreInventory> inventoryList)
        {
            var selectedCategory = OrderTab_CategorySelectionBox.SelectedItem as StoreInventoryCategory;
            var filteredItems = inventoryList.Where(i => i.CategoryId == selectedCategory.Id);
            OrderTab_InventoryCheckBox.Items.Clear();
            foreach (var inventory in filteredItems)
            {
                var checkBoxState = inventory.Count == 0
                    ? CheckState.Indeterminate
                    : CheckState.Unchecked;
                OrderTab_InventoryCheckBox.Items.Add(inventory, checkBoxState);
            }
        }

        private void AddItemsToBasket(IList<BasketItem> newItems)
        {
            var existingItems = OrderTab_BasketBox.Items.Cast<BasketItem>().ToList();
            OrderTab_BasketBox.Items.Clear();

            foreach (var newItem in newItems)
            {
                var existing = existingItems.FirstOrDefault(e => e.InventoryId == newItem.InventoryId);
                if (existing != null)
                {
                    existing.TotalCount += 1;
                }
                else
                {
                    existingItems.Add(newItem);
                }
            }

            foreach (var item in existingItems)
            {
                OrderTab_BasketBox.Items.Add(item);
            }
        }

        private void UpdateItemCounts()
        {
            var inventoryItems = OrderTab_InventoryCheckBox.Items.OfType<StoreInventory>();
            foreach (var basketItem in OrderTab_BasketBox.Items.OfType<BasketItem>())
            {
                var inventoryItem = inventoryItems.FirstOrDefault(i => i.Id == basketItem.InventoryId);
                if (inventoryItem == null) continue;

                if (inventoryItem.Count > 0)
                {
                    inventoryItem.Count -= 1;
                }
            }

            SetInventoryList(inventoryItems.ToList());
        }

        private void ResetCheckBoxState()
        {
            for (int i = 0; i < OrderTab_InventoryCheckBox.Items.Count; i++)
            {
                OrderTab_InventoryCheckBox.SetItemChecked(i, false);
            }
        }

        private void CalculateTotalPrice()
        {
            double sum = 0;
            foreach (var item in OrderTab_BasketBox.Items)
            {
                var inventoryItem = item as BasketItem;
                sum += inventoryItem.TotalPrice * inventoryItem.TotalCount;
                OrderTab_SumTotalBox.Text = sum.ToString() + " EUR";
            }
        } 

        private async Task LoadData(bool loadCategories, bool loadInventories)
        {
            using (var dbContext = new StoreDatabaseContext())
            {
                if (loadCategories)
                {
                    var categories = dbContext.Categories.AsNoTracking().ToListAsync();
                    var storeCategories = StoreInventoryCategoryMapper.Map(await categories);
                    SetCategoryList(storeCategories);
                }

                if (loadInventories)
                {
                    var inventories = dbContext.Inventories.AsNoTracking().ToListAsync();
                    var storeInventories = StoreInventoryMapper.Map(await inventories);
                    SetInventoryList(storeInventories);
                }
            }
        }


        #region Order Tab Event handlers

        private void StoreForm_Load(object sender, EventArgs e)
        {
            LoadData(true, true);
        }

        private void AddToBasketButton_Click(object sender, EventArgs e)
        {
            var selectedItems = OrderTab_InventoryCheckBox.CheckedItems;
            var selectedCategory = OrderTab_CategorySelectionBox.SelectedItem;

            if (selectedCategory == null)
            {
                MessageBox.Show("Nepasirinkote kategorijos");
                return;
            }

            if (selectedItems.Count == 0)
            {
                MessageBox.Show("Nepasirinkote prekių");
                return;
            }

            var basketItem = BasketItemMapper.Map(selectedItems);
            ResetCheckBoxState();
            AddItemsToBasket(basketItem);
            UpdateItemCounts();
        }

        private async void OrderTabCategorySelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (var db = new StoreDatabaseContext())
            //{
            //    var currentItems = StoreInventoryMapper.Map(await db.Inventories.ToListAsync());
            //    SetInventoryList(currentItems);
            //}
            await LoadData(false, true);
            UpdateItemCounts();
        }

        private async void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (this.OrderTab_BasketBox.SelectedIndex >= 0)

            this.OrderTab_BasketBox.Items.RemoveAt(this.OrderTab_BasketBox.SelectedIndex);
            await LoadData(false, true);
        }

        private void ContinueOrderButton_Click(object sender, EventArgs e)
        {
            if(OrderTab_BasketBox.Items.Count != 0)
            {
                OrderTab_OrderConfirmationPanel.Visible = true;
                CalculateTotalPrice();
                OrderTab_BasketPanel.Enabled = false;
                OrderTab_OrderPanel.Enabled = false;
            }
            else
            {
                MessageBox.Show("Krepšelis tuščias, testi negalima");
                return;
            }
            
        }

        private void BasketBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            var selectedItem = OrderTab_BasketBox.SelectedItem as BasketItem;
            if (selectedItem != null)
            {
                OrderTab_SelectedBasketItemCountTextBox.Text = selectedItem.TotalCount.ToString();
            }
            else
            {
                OrderTab_SelectedBasketItemCountTextBox.Clear();
            }
        }

        private void OrderTab_DeclineOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ar tikrai norite atšaukti užsakymą?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                OrderTab_BasketBox.Items.Clear();
                OrderTab_SumTotalBox.Clear();
                OrderTab_OrderConfirmationPanel.Visible = false;
                OrderTab_OrderPanel.Enabled = true;
                OrderTab_BasketPanel.Enabled = true;
                LoadData(false, true);

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private async void OrderTab_CompleteOrder_Click(object sender, EventArgs e)
        {
            var basketItems = OrderTab_BasketBox.Items.OfType<BasketItem>();
            var inventoryIds = basketItems.Select(i => i.InventoryId);

            using (var dbContext = new StoreDatabaseContext())
            {
                var inventories = await dbContext.Inventories
                    .Where(i => inventoryIds.Contains(i.Id))
                    .ToListAsync();
                foreach (var inventory in inventories)
                {
                    var basketItem = basketItems.FirstOrDefault(b => b.InventoryId == inventory.Id);
                    inventory.Count -= basketItem.TotalCount;
                    dbContext.Inventories.AddOrUpdate(inventory);
                }

                await dbContext.SaveChangesAsync();
                LoadData(false, true);
                OrderTab_BasketPanel.Enabled = true;
                OrderTab_OrderPanel.Enabled = true;
                OrderTab_BasketBox.Items.Clear();
                MessageBox.Show("Užsakymas patvirtintas");
                OrderTab_OrderConfirmationPanel.Visible = false;
            }

        }

        private void OrderTab_InventoryCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Indeterminate) e.NewValue = CheckState.Indeterminate;
        }
        #endregion

        #region Add New Tab Item Event Handlers

        private async void AddNewTab_SaveNewItemButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(AddNewItemTab_Count.Text) || String.IsNullOrEmpty(AddNewItemTab_InventoryName.Text) 
                || String.IsNullOrEmpty(AddNewItemTab_Price.Text) || String.IsNullOrEmpty(AddNewItemTab_CategorySelectionBox.Text))
            {
                MessageBox.Show("Visos reikšmės turi būti įvestos", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int parsedValueForCount;
                if (!int.TryParse(AddNewItemTab_Count.Text, out parsedValueForCount))
                {
                    MessageBox.Show("Įvesti kiekį priima tik skaičių reikšmes, prašome pataisyti");
                    return;
                }
                double parsedValueForPrice;
                if (!double.TryParse(AddNewItemTab_Price.Text, out parsedValueForPrice))
                {
                    MessageBox.Show("Kaina priima tik skaičių reikšmes, prašome pataisyti");
                    return;
                }

                var selectedCategory = AddNewItemTab_CategorySelectionBox.SelectedItem as StoreInventoryCategory;
                var inventoryName = AddNewItemTab_InventoryName.Text;

                var newInventoryItem = new Inventory()
                {
                    CategoryId = selectedCategory.Id,
                    Count = parsedValueForCount,
                    InventoryName = inventoryName,
                    Price = parsedValueForPrice
                };

                using (var dbContext = new StoreDatabaseContext())
                {
                    dbContext.Inventories.Add(newInventoryItem);
                    await dbContext.SaveChangesAsync();
                }
                MessageBox.Show("Prekė išsaugota");

                AddNewItemTab_Count.Clear();
                AddNewItemTab_InventoryName.Clear();
                AddNewItemTab_Price.Clear();

                LoadData(false, true);
            }
        }

        #endregion

        #region Other Event Handlers

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ar tikrai norite atsijungti?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        #endregion

    }
}
