using DevExpress.Data;

namespace Apteka.UtilsUI.GridFunctions
{
    public class GridColunmConfigItem
    {
        public SummaryItemType SumType { get; set; }
        public string ColunmName { get; set; }
        public bool IsGroups { get; set; }
        public bool IsAgrs { get; set; }
        public int Width { get; set; }
        public string DateType { get; set; }
    }
}
