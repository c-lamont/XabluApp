using System;
using MvvmCross.Core.ViewModels;

namespace XabluApp.Core
{
    public class DrawerCellViewModel : BaseViewModel
    {
        public DrawerCellViewModel(DrawerCellType cellType)
        {
            this.CellType = cellType;
            SetCellProperties();
        }

        private void SetCellProperties()
        {
            switch (cellType)
            {
                case DrawerCellType.About:
                    MainText = "About";
                    break;
                case DrawerCellType.Employees:
                    MainText = "Employees";
                    break;
                case DrawerCellType.Blogs:
                    MainText = "Blogs";
                    break;
            }
        }

        public void LoadViewModel()
        {
            switch (cellType)
            {
                case DrawerCellType.About:
                    ShowViewModel<AboutViewModel>();
                    break;
                case DrawerCellType.Employees:
                    ShowViewModel<EmployeesViewModel>();
                    break;
                case DrawerCellType.Blogs:
                    ShowViewModel<BlogsViewModel>();
                    break;
            }
        }


        #region Properties
        private DrawerCellType cellType;
        public DrawerCellType CellType
        {
            get { return cellType; }
            set { SetProperty(ref cellType, value); }
        }

        private string mainText;
        public string MainText
        {
            get { return mainText; }
            set { SetProperty(ref mainText, value); }
        }

        private string detailText = "45";
        public string DetailText
        {
            get { return detailText; }
            set { SetProperty(ref detailText, value); }
        }
        #endregion

        public enum DrawerCellType
        {
            About,
            Employees,
            Blogs
        }
    }
}
