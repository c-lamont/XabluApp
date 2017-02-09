using MvvmCross.Droid.Support.V7.RecyclerView.ItemTemplates;
using XabluApp.Core;

namespace XabluApp.Droid.Helpers
{
    public class CellTemplateSelector : MvxTemplateSelector<ListItemModel>
    {
        private const int _HeaderCell = 1;
        private const int _DrawerCellViewModel = 2;
        private const int _EmployeeCellViewModel = 3;
        private const int _BlogCellViewModel = 4;

        public override int GetItemLayoutId(int fromViewType)
        {
            if (fromViewType == _HeaderCell)
            {
                return Resource.Layout.cell_header_layout;
            }

            if (fromViewType == _DrawerCellViewModel)
            {
                return Resource.Layout.cell_drawer_menu_layout;
            }

            if (fromViewType == _EmployeeCellViewModel)
            {
                return Resource.Layout.cell_employee_layout;
            }

            if (fromViewType == _BlogCellViewModel)
            {
                return Resource.Layout.cell_blog_layout;
            }

            return Resource.Layout.empty_layout;
        }

        protected override int SelectItemViewType(ListItemModel forItemObject)
        {
            if (forItemObject == null)
            {
                return 0;
            }

            switch (forItemObject.ItemType)
            {
                case ListItemModelEnum.Header:
                    return _HeaderCell;
                case ListItemModelEnum.DrawerCellViewModel:
                    return _DrawerCellViewModel;
                case ListItemModelEnum.EmployeeCellViewModel:
                    return _EmployeeCellViewModel;
                case ListItemModelEnum.BlogCellViewModel:
                    return _BlogCellViewModel;
                default:
                    return 0;
            }
        }
    }
}
