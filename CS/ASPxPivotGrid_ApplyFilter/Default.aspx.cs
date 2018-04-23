using System;
using DevExpress.Web.ASPxPivotGrid;

namespace ApplyFilter {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack && !IsCallback) {
                PivotGridField field = ASPxPivotGrid1.Fields["Country"];
                // Locks the control to prevent excessive updates when multiple properties are modified.
                ASPxPivotGrid1.BeginUpdate();
                try {
                    // Clears the filter value collection and add two items to it.
                    field.FilterValues.Clear();
                    field.FilterValues.Add("Brazil");
                    field.FilterValues.Add("USA");
                    // Specifies that the control should only display the records 
                    // which contain the specified values in the Country field.
                    field.FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included;
                }
                finally {
                    // Unlocks the control.
                    ASPxPivotGrid1.EndUpdate();
                }
            }
        }
    }
}
