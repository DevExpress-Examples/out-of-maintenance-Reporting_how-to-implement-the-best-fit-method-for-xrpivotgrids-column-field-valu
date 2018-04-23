namespace RepPGVertHeadersHeight {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.manualDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMyDateTime = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMyRow = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMyData = new DevExpress.XtraPivotGrid.PivotGridField();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataMember = "table";
            this.pivotGridControl1.DataSource = this.manualDataSetBindingSource;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldID,
            this.fieldMyDateTime,
            this.fieldMyRow,
            this.fieldMyData});
            this.pivotGridControl1.Location = new System.Drawing.Point(72, 57);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(592, 200);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // manualDataSetBindingSource
            // 
            this.manualDataSetBindingSource.DataSource = typeof(RepPGVertHeadersHeight.ManualDataSet);
            this.manualDataSetBindingSource.Position = 0;
            // 
            // fieldID
            // 
            this.fieldID.AreaIndex = 0;
            this.fieldID.Caption = "ID";
            this.fieldID.FieldName = "ID";
            this.fieldID.Name = "fieldID";
            // 
            // fieldMyDateTime
            // 
            this.fieldMyDateTime.AreaIndex = 1;
            this.fieldMyDateTime.Caption = "My Date Time";
            this.fieldMyDateTime.FieldName = "MyDateTime";
            this.fieldMyDateTime.Name = "fieldMyDateTime";
            // 
            // fieldMyRow
            // 
            this.fieldMyRow.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMyRow.AreaIndex = 0;
            this.fieldMyRow.Caption = "My Row";
            this.fieldMyRow.FieldName = "MyRow";
            this.fieldMyRow.Name = "fieldMyRow";
            // 
            // fieldMyData
            // 
            this.fieldMyData.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldMyData.AreaIndex = 0;
            this.fieldMyData.Caption = "My Data";
            this.fieldMyData.FieldName = "MyData";
            this.fieldMyData.Name = "fieldMyData";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "BestFit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Preview";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource manualDataSetBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMyDateTime;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMyRow;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMyData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

