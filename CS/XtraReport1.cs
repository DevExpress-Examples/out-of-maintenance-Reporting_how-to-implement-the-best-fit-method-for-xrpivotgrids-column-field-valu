using System;
using System.ComponentModel;
using System.Data;
// ...

namespace RepPGVertHeadersHeight {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
            xrPivotGrid1.BestFit(fieldMyRow);
        }
    }

    public class ManualDataSet : DataSet {
        public ManualDataSet()
            : base() {
            DataTable table = new DataTable("table");

            DataSetName = "ManualDataSet";

            table.Columns.Add("ID", typeof(Int32));
            table.Columns.Add("MyDateTime", typeof(DateTime));
            table.Columns.Add("MyRow", typeof(string));
            table.Columns.Add("MyData", typeof(double));
            //table.Constraints.Add("IDPK", table.Columns["ID"], true);

            Tables.AddRange(new DataTable[] { table });

            CreateData();
        }

        public void CreateData() {
            DataTable table = Tables["table"];

            table.Rows.Add(new object[] { 0, DateTime.Today, "AA", 103 });
            table.Rows.Add(new object[] { 0, DateTime.Today, "BSD", 32 });
            table.Rows.Add(new object[] { 0, DateTime.Today, "FWEC", 341 });

            table.Rows.Add(new object[] { 1, DateTime.Today, "AA", 52 });
            table.Rows.Add(new object[] { 1, DateTime.Today, "BSD", 2 });
            table.Rows.Add(new object[] { 1, DateTime.Today, "FWEC", 12 });

            table.Rows.Add(new object[] { 2, DateTime.Today, "AA", 12 });
            table.Rows.Add(new object[] { 2, DateTime.Today, "BSD", 43 });
            table.Rows.Add(new object[] { 2, DateTime.Today, "FWEC", 12 });
        }

        #region Disable Serialization for Tables and Relations
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DataTableCollection Tables {
            get { return base.Tables; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DataRelationCollection Relations {
            get { return base.Relations; }
        }
        #endregion Disable Serialization for Tables and Relations
    }

}
