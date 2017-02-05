using MvvmCross.Droid.Support.V7.RecyclerView.ItemTemplates;
using XabluApp.Core;

namespace XabluApp.Droid.Helpers
{
    public class CellTemplateSelector : MvxTemplateSelector<ListItemModel>
    {
        public override int GetItemLayoutId(int fromViewType)
        {
            if (fromViewType == 1)
            {
                return Resource.Layout.cell_header_layout;
            }

            if (fromViewType == 2)
            {
                return Resource.Layout.cell_drawer_menu_layout;
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
                    return 1;
                case ListItemModelEnum.DrawerCellViewModel:
                    return 2;
                default:
                    return 0;
            }
        }
    }
}
