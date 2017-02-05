using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using XabluApp.Core.Helpers;

namespace XabluApp.Core
{
    public class DrawerViewModel : BaseViewModel
    {
        public DrawerViewModel()
        {
            Title = "About";
            SetDrawerListItems();
        }

        #region Drawer List
        public OptimizedObservableCollection<ListItemModel> DrawerListItems { get; set; } = new OptimizedObservableCollection<ListItemModel>();
        private List<ListItemModel> drawerListItems = new List<ListItemModel>();
        private void SetDrawerListItems()
        {
            AddDrawerListItem(DrawerCellViewModel.DrawerCellType.About);
            AddDrawerListItem(DrawerCellViewModel.DrawerCellType.Employees);
            AddDrawerListItem(DrawerCellViewModel.DrawerCellType.Blogs);

            DrawerListItems.ReplaceWith(drawerListItems);
        }

        private void AddDrawerListItem(DrawerCellViewModel.DrawerCellType type)
        {
            drawerListItems.Add(new ListItemModel(new DrawerCellViewModel(type)));
        }

        private void AddDrawerHeaderListItem(string headerTitle)
        {
            drawerListItems.Add(new ListItemModel(headerTitle, true, false));
        }

        private MvxCommand<ListItemModel> drawerItemClickedCommand;
        public MvxCommand<ListItemModel> DrawerItemClickedCommand
        {
            get
            {
                if (drawerItemClickedCommand == null)
                {
                    drawerItemClickedCommand = new MvxCommand<ListItemModel>(vm =>
                    {
                        if (vm.ItemType == ListItemModelEnum.DrawerCellViewModel)
                        {
                            vm.DrawerCellViewModel.LoadViewModel();
                        }
                    });
                }
                return drawerItemClickedCommand;
            }
        }
        #endregion
    }
}
