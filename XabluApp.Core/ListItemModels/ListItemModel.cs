using System;
namespace XabluApp.Core
{
    public class ListItemModel : IHeaderCellViewModel
    {
        public ListItemModelEnum ItemType { get; }

        public ListItemModel()
        {
            this.ItemType = ListItemModelEnum.None;
        }

        #region Header
        public ListItemModel(string headerTitle, bool showTopBorderLine, bool showBottomBorderLine)
        {
            ItemType = ListItemModelEnum.Header;
            HeaderTitle = headerTitle;
            ShowHeaderTopBorder = showTopBorderLine;
            ShowHeaderBottomBorder = showBottomBorderLine;
        }

        public string HeaderTitle
        {
            get;
            set;
        }

        public bool ShowHeaderBottomBorder
        {
            get;
        }

        public bool ShowHeaderTopBorder
        {
            get;
        }
        #endregion

        public DrawerCellViewModel DrawerCellViewModel { get; }
        public ListItemModel(DrawerCellViewModel drawerCellItem)
        {
            this.ItemType = ListItemModelEnum.DrawerCellViewModel;
            this.DrawerCellViewModel = drawerCellItem;
        }

        public EmployeeCellViewModel EmployeeCellViewModel { get; }
        public ListItemModel(EmployeeCellViewModel employeeCellViewModel)
        {
            this.ItemType = ListItemModelEnum.EmployeeCellViewModel;
            this.EmployeeCellViewModel = employeeCellViewModel;
        }

        public BlogCellViewModel BlogCellViewModel { get; }
        public ListItemModel(BlogCellViewModel blogCellViewModel)
        {
            this.ItemType = ListItemModelEnum.BlogCellViewModel;
            this.BlogCellViewModel = blogCellViewModel;
        }
    }

    public enum ListItemModelEnum
    {
        None,
        Header,
        DrawerCellViewModel,
        EmployeeCellViewModel,
        BlogCellViewModel
    }
}
