using System;
namespace XabluApp.Core
{
    public interface IHeaderCellViewModel
    {
        string HeaderTitle
        {
            get;
            set;
        }

        bool ShowHeaderTopBorder
        {
            get;
        }

        bool ShowHeaderBottomBorder
        {
            get;
        }
    }
}
