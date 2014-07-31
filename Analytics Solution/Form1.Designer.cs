namespace Analytics_Solution
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDbError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDatabaseName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBoxProjectObjs = new System.Windows.Forms.GroupBox();
            this.lblDashboardsVal = new System.Windows.Forms.Label();
            this.lblDatasetsVal = new System.Windows.Forms.Label();
            this.lblReportsVal = new System.Windows.Forms.Label();
            this.lblMetricsVal = new System.Windows.Forms.Label();
            this.lblPromptsVal = new System.Windows.Forms.Label();
            this.lblFiltersVal = new System.Windows.Forms.Label();
            this.lblHierVal = new System.Windows.Forms.Label();
            this.lblFactsVal = new System.Windows.Forms.Label();
            this.lblAttributesVal = new System.Windows.Forms.Label();
            this.lblDashboards = new System.Windows.Forms.Label();
            this.lblDatasets = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblMetrics = new System.Windows.Forms.Label();
            this.lblPrompts = new System.Windows.Forms.Label();
            this.lblFilters = new System.Windows.Forms.Label();
            this.lblHieracrhies = new System.Windows.Forms.Label();
            this.lblFacts = new System.Windows.Forms.Label();
            this.lblAttributes = new System.Windows.Forms.Label();
            this.btnExportCRD = new System.Windows.Forms.Button();
            this.btnExportDoc = new System.Windows.Forms.Button();
            this.btnImportTables = new System.Windows.Forms.Button();
            this.tabPageAttributes = new System.Windows.Forms.TabPage();
            this.btnNewAttr = new System.Windows.Forms.Button();
            this.dataGridViewAttributes = new System.Windows.Forms.DataGridView();
            this.colAttrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttrNumForms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttrNumChildren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttrNumParents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttrComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageFacts = new System.Windows.Forms.TabPage();
            this.tabPageHierarchies = new System.Windows.Forms.TabPage();
            this.tabPageFilters = new System.Windows.Forms.TabPage();
            this.tabPagePrompts = new System.Windows.Forms.TabPage();
            this.tabPageMetrics = new System.Windows.Forms.TabPage();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.tabPageDataSets = new System.Windows.Forms.TabPage();
            this.tabPageDashboards = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dlgDatabaseFile = new System.Windows.Forms.OpenFileDialog();
            this.BtnCreateDataBase = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            this.groupBoxProjectObjs.SuspendLayout();
            this.tabPageAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttributes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageSummary);
            this.tabControlMain.Controls.Add(this.tabPageAttributes);
            this.tabControlMain.Controls.Add(this.tabPageFacts);
            this.tabControlMain.Controls.Add(this.tabPageHierarchies);
            this.tabControlMain.Controls.Add(this.tabPageFilters);
            this.tabControlMain.Controls.Add(this.tabPagePrompts);
            this.tabControlMain.Controls.Add(this.tabPageMetrics);
            this.tabControlMain.Controls.Add(this.tabPageReports);
            this.tabControlMain.Controls.Add(this.tabPageDataSets);
            this.tabControlMain.Controls.Add(this.tabPageDashboards);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1093, 523);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.BtnCreateDataBase);
            this.tabPageSummary.Controls.Add(this.label2);
            this.tabPageSummary.Controls.Add(this.lblDbError);
            this.tabPageSummary.Controls.Add(this.label1);
            this.tabPageSummary.Controls.Add(this.tbxDatabaseName);
            this.tabPageSummary.Controls.Add(this.btnUpdate);
            this.tabPageSummary.Controls.Add(this.groupBoxProjectObjs);
            this.tabPageSummary.Controls.Add(this.btnExportCRD);
            this.tabPageSummary.Controls.Add(this.btnExportDoc);
            this.tabPageSummary.Controls.Add(this.btnImportTables);
            this.tabPageSummary.Location = new System.Drawing.Point(4, 25);
            this.tabPageSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSummary.Size = new System.Drawing.Size(1085, 494);
            this.tabPageSummary.TabIndex = 0;
            this.tabPageSummary.Text = "Summary";
            this.tabPageSummary.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 9;
            // 
            // lblDbError
            // 
            this.lblDbError.AutoSize = true;
            this.lblDbError.ForeColor = System.Drawing.Color.Red;
            this.lblDbError.Location = new System.Drawing.Point(688, 139);
            this.lblDbError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDbError.Name = "lblDbError";
            this.lblDbError.Size = new System.Drawing.Size(0, 16);
            this.lblDbError.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Database Name";
            // 
            // tbxDatabaseName
            // 
            this.tbxDatabaseName.Location = new System.Drawing.Point(501, 87);
            this.tbxDatabaseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDatabaseName.Name = "tbxDatabaseName";
            this.tbxDatabaseName.Size = new System.Drawing.Size(363, 22);
            this.tbxDatabaseName.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(501, 247);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 38);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Save";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBoxProjectObjs
            // 
            this.groupBoxProjectObjs.Controls.Add(this.lblDashboardsVal);
            this.groupBoxProjectObjs.Controls.Add(this.lblDatasetsVal);
            this.groupBoxProjectObjs.Controls.Add(this.lblReportsVal);
            this.groupBoxProjectObjs.Controls.Add(this.lblMetricsVal);
            this.groupBoxProjectObjs.Controls.Add(this.lblPromptsVal);
            this.groupBoxProjectObjs.Controls.Add(this.lblFiltersVal);
            this.groupBoxProjectObjs.Controls.Add(this.lblHierVal);
            this.groupBoxProjectObjs.Controls.Add(this.lblFactsVal);
            this.groupBoxProjectObjs.Controls.Add(this.lblAttributesVal);
            this.groupBoxProjectObjs.Controls.Add(this.lblDashboards);
            this.groupBoxProjectObjs.Controls.Add(this.lblDatasets);
            this.groupBoxProjectObjs.Controls.Add(this.lblReports);
            this.groupBoxProjectObjs.Controls.Add(this.lblMetrics);
            this.groupBoxProjectObjs.Controls.Add(this.lblPrompts);
            this.groupBoxProjectObjs.Controls.Add(this.lblFilters);
            this.groupBoxProjectObjs.Controls.Add(this.lblHieracrhies);
            this.groupBoxProjectObjs.Controls.Add(this.lblFacts);
            this.groupBoxProjectObjs.Controls.Add(this.lblAttributes);
            this.groupBoxProjectObjs.Location = new System.Drawing.Point(52, 43);
            this.groupBoxProjectObjs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProjectObjs.Name = "groupBoxProjectObjs";
            this.groupBoxProjectObjs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProjectObjs.Size = new System.Drawing.Size(317, 396);
            this.groupBoxProjectObjs.TabIndex = 4;
            this.groupBoxProjectObjs.TabStop = false;
            this.groupBoxProjectObjs.Text = "Project Objects";
            // 
            // lblDashboardsVal
            // 
            this.lblDashboardsVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDashboardsVal.AutoSize = true;
            this.lblDashboardsVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardsVal.Location = new System.Drawing.Point(288, 318);
            this.lblDashboardsVal.Name = "lblDashboardsVal";
            this.lblDashboardsVal.Size = new System.Drawing.Size(19, 20);
            this.lblDashboardsVal.TabIndex = 17;
            this.lblDashboardsVal.Text = "0";
            // 
            // lblDatasetsVal
            // 
            this.lblDatasetsVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatasetsVal.AutoSize = true;
            this.lblDatasetsVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatasetsVal.Location = new System.Drawing.Point(288, 292);
            this.lblDatasetsVal.Name = "lblDatasetsVal";
            this.lblDatasetsVal.Size = new System.Drawing.Size(19, 20);
            this.lblDatasetsVal.TabIndex = 16;
            this.lblDatasetsVal.Text = "0";
            // 
            // lblReportsVal
            // 
            this.lblReportsVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportsVal.AutoSize = true;
            this.lblReportsVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsVal.Location = new System.Drawing.Point(288, 267);
            this.lblReportsVal.Name = "lblReportsVal";
            this.lblReportsVal.Size = new System.Drawing.Size(19, 20);
            this.lblReportsVal.TabIndex = 15;
            this.lblReportsVal.Text = "0";
            // 
            // lblMetricsVal
            // 
            this.lblMetricsVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMetricsVal.AutoSize = true;
            this.lblMetricsVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetricsVal.Location = new System.Drawing.Point(288, 204);
            this.lblMetricsVal.Name = "lblMetricsVal";
            this.lblMetricsVal.Size = new System.Drawing.Size(19, 20);
            this.lblMetricsVal.TabIndex = 14;
            this.lblMetricsVal.Text = "0";
            // 
            // lblPromptsVal
            // 
            this.lblPromptsVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPromptsVal.AutoSize = true;
            this.lblPromptsVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromptsVal.Location = new System.Drawing.Point(288, 178);
            this.lblPromptsVal.Name = "lblPromptsVal";
            this.lblPromptsVal.Size = new System.Drawing.Size(19, 20);
            this.lblPromptsVal.TabIndex = 13;
            this.lblPromptsVal.Text = "0";
            // 
            // lblFiltersVal
            // 
            this.lblFiltersVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltersVal.AutoSize = true;
            this.lblFiltersVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltersVal.Location = new System.Drawing.Point(288, 154);
            this.lblFiltersVal.Name = "lblFiltersVal";
            this.lblFiltersVal.Size = new System.Drawing.Size(19, 20);
            this.lblFiltersVal.TabIndex = 12;
            this.lblFiltersVal.Text = "0";
            // 
            // lblHierVal
            // 
            this.lblHierVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHierVal.AutoSize = true;
            this.lblHierVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHierVal.Location = new System.Drawing.Point(288, 96);
            this.lblHierVal.Name = "lblHierVal";
            this.lblHierVal.Size = new System.Drawing.Size(19, 20);
            this.lblHierVal.TabIndex = 11;
            this.lblHierVal.Text = "0";
            // 
            // lblFactsVal
            // 
            this.lblFactsVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFactsVal.AutoSize = true;
            this.lblFactsVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactsVal.Location = new System.Drawing.Point(288, 71);
            this.lblFactsVal.Name = "lblFactsVal";
            this.lblFactsVal.Size = new System.Drawing.Size(19, 20);
            this.lblFactsVal.TabIndex = 10;
            this.lblFactsVal.Text = "0";
            // 
            // lblAttributesVal
            // 
            this.lblAttributesVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttributesVal.AutoSize = true;
            this.lblAttributesVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttributesVal.Location = new System.Drawing.Point(288, 46);
            this.lblAttributesVal.Name = "lblAttributesVal";
            this.lblAttributesVal.Size = new System.Drawing.Size(19, 20);
            this.lblAttributesVal.TabIndex = 9;
            this.lblAttributesVal.Text = "0";
            // 
            // lblDashboards
            // 
            this.lblDashboards.AutoSize = true;
            this.lblDashboards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboards.Location = new System.Drawing.Point(5, 318);
            this.lblDashboards.Name = "lblDashboards";
            this.lblDashboards.Size = new System.Drawing.Size(106, 20);
            this.lblDashboards.TabIndex = 8;
            this.lblDashboards.Text = "Dashboards";
            // 
            // lblDatasets
            // 
            this.lblDatasets.AutoSize = true;
            this.lblDatasets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatasets.Location = new System.Drawing.Point(5, 292);
            this.lblDatasets.Name = "lblDatasets";
            this.lblDatasets.Size = new System.Drawing.Size(82, 20);
            this.lblDatasets.TabIndex = 7;
            this.lblDatasets.Text = "Datasets";
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(5, 267);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(73, 20);
            this.lblReports.TabIndex = 6;
            this.lblReports.Text = "Reports";
            // 
            // lblMetrics
            // 
            this.lblMetrics.AutoSize = true;
            this.lblMetrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetrics.Location = new System.Drawing.Point(5, 204);
            this.lblMetrics.Name = "lblMetrics";
            this.lblMetrics.Size = new System.Drawing.Size(67, 20);
            this.lblMetrics.TabIndex = 5;
            this.lblMetrics.Text = "Metrics";
            // 
            // lblPrompts
            // 
            this.lblPrompts.AutoSize = true;
            this.lblPrompts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompts.Location = new System.Drawing.Point(5, 178);
            this.lblPrompts.Name = "lblPrompts";
            this.lblPrompts.Size = new System.Drawing.Size(75, 20);
            this.lblPrompts.TabIndex = 4;
            this.lblPrompts.Text = "Prompts";
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilters.Location = new System.Drawing.Point(5, 154);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(59, 20);
            this.lblFilters.TabIndex = 3;
            this.lblFilters.Text = "Filters";
            // 
            // lblHieracrhies
            // 
            this.lblHieracrhies.AutoSize = true;
            this.lblHieracrhies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHieracrhies.Location = new System.Drawing.Point(5, 96);
            this.lblHieracrhies.Name = "lblHieracrhies";
            this.lblHieracrhies.Size = new System.Drawing.Size(100, 20);
            this.lblHieracrhies.TabIndex = 2;
            this.lblHieracrhies.Text = "Hierarchies";
            // 
            // lblFacts
            // 
            this.lblFacts.AutoSize = true;
            this.lblFacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacts.Location = new System.Drawing.Point(5, 71);
            this.lblFacts.Name = "lblFacts";
            this.lblFacts.Size = new System.Drawing.Size(54, 20);
            this.lblFacts.TabIndex = 1;
            this.lblFacts.Text = "Facts";
            // 
            // lblAttributes
            // 
            this.lblAttributes.AutoSize = true;
            this.lblAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttributes.Location = new System.Drawing.Point(5, 46);
            this.lblAttributes.Name = "lblAttributes";
            this.lblAttributes.Size = new System.Drawing.Size(88, 20);
            this.lblAttributes.TabIndex = 0;
            this.lblAttributes.Text = "Attributes";
            // 
            // btnExportCRD
            // 
            this.btnExportCRD.Location = new System.Drawing.Point(501, 304);
            this.btnExportCRD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportCRD.Name = "btnExportCRD";
            this.btnExportCRD.Size = new System.Drawing.Size(179, 42);
            this.btnExportCRD.TabIndex = 3;
            this.btnExportCRD.Text = "Export CMD MGR Script";
            this.btnExportCRD.UseVisualStyleBackColor = true;
            // 
            // btnExportDoc
            // 
            this.btnExportDoc.Location = new System.Drawing.Point(501, 185);
            this.btnExportDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportDoc.Name = "btnExportDoc";
            this.btnExportDoc.Size = new System.Drawing.Size(179, 41);
            this.btnExportDoc.TabIndex = 2;
            this.btnExportDoc.Text = "Export Documentation";
            this.btnExportDoc.UseVisualStyleBackColor = true;
            // 
            // btnImportTables
            // 
            this.btnImportTables.Location = new System.Drawing.Point(501, 123);
            this.btnImportTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportTables.Name = "btnImportTables";
            this.btnImportTables.Size = new System.Drawing.Size(179, 44);
            this.btnImportTables.TabIndex = 1;
            this.btnImportTables.Text = "Import Tables";
            this.btnImportTables.UseVisualStyleBackColor = true;
            this.btnImportTables.Click += new System.EventHandler(this.btnImportTables_Click);
            // 
            // tabPageAttributes
            // 
            this.tabPageAttributes.Controls.Add(this.btnNewAttr);
            this.tabPageAttributes.Controls.Add(this.dataGridViewAttributes);
            this.tabPageAttributes.Location = new System.Drawing.Point(4, 25);
            this.tabPageAttributes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAttributes.Name = "tabPageAttributes";
            this.tabPageAttributes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAttributes.Size = new System.Drawing.Size(1085, 494);
            this.tabPageAttributes.TabIndex = 1;
            this.tabPageAttributes.Text = "Attributes";
            this.tabPageAttributes.UseVisualStyleBackColor = true;
            // 
            // btnNewAttr
            // 
            this.btnNewAttr.Location = new System.Drawing.Point(639, 2);
            this.btnNewAttr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewAttr.Name = "btnNewAttr";
            this.btnNewAttr.Size = new System.Drawing.Size(440, 42);
            this.btnNewAttr.TabIndex = 1;
            this.btnNewAttr.Text = "Create New Attribute";
            this.btnNewAttr.UseVisualStyleBackColor = true;
            this.btnNewAttr.Click += new System.EventHandler(this.btnNewAttr_Click);
            // 
            // dataGridViewAttributes
            // 
            this.dataGridViewAttributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAttrName,
            this.colAttrNumForms,
            this.colAttrNumChildren,
            this.colAttrNumParents,
            this.colAttrComments});
            this.dataGridViewAttributes.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAttributes.Location = new System.Drawing.Point(3, 50);
            this.dataGridViewAttributes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAttributes.Name = "dataGridViewAttributes";
            this.dataGridViewAttributes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewAttributes.RowHeadersVisible = false;
            this.dataGridViewAttributes.RowTemplate.Height = 24;
            this.dataGridViewAttributes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAttributes.Size = new System.Drawing.Size(1079, 1440);
            this.dataGridViewAttributes.TabIndex = 0;
            // 
            // colAttrName
            // 
            this.colAttrName.HeaderText = "Name";
            this.colAttrName.Name = "colAttrName";
            this.colAttrName.ReadOnly = true;
            // 
            // colAttrNumForms
            // 
            this.colAttrNumForms.HeaderText = "# Forms";
            this.colAttrNumForms.Name = "colAttrNumForms";
            this.colAttrNumForms.ReadOnly = true;
            // 
            // colAttrNumChildren
            // 
            this.colAttrNumChildren.HeaderText = "# Children";
            this.colAttrNumChildren.Name = "colAttrNumChildren";
            this.colAttrNumChildren.ReadOnly = true;
            // 
            // colAttrNumParents
            // 
            this.colAttrNumParents.HeaderText = "# Parents";
            this.colAttrNumParents.Name = "colAttrNumParents";
            this.colAttrNumParents.ReadOnly = true;
            // 
            // colAttrComments
            // 
            this.colAttrComments.HeaderText = "Comments";
            this.colAttrComments.Name = "colAttrComments";
            this.colAttrComments.ReadOnly = true;
            // 
            // tabPageFacts
            // 
            this.tabPageFacts.Location = new System.Drawing.Point(4, 25);
            this.tabPageFacts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFacts.Name = "tabPageFacts";
            this.tabPageFacts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFacts.Size = new System.Drawing.Size(1085, 494);
            this.tabPageFacts.TabIndex = 2;
            this.tabPageFacts.Text = "Facts";
            this.tabPageFacts.UseVisualStyleBackColor = true;
            // 
            // tabPageHierarchies
            // 
            this.tabPageHierarchies.Location = new System.Drawing.Point(4, 25);
            this.tabPageHierarchies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageHierarchies.Name = "tabPageHierarchies";
            this.tabPageHierarchies.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageHierarchies.Size = new System.Drawing.Size(1085, 494);
            this.tabPageHierarchies.TabIndex = 3;
            this.tabPageHierarchies.Text = "Hierarchies";
            this.tabPageHierarchies.UseVisualStyleBackColor = true;
            // 
            // tabPageFilters
            // 
            this.tabPageFilters.Location = new System.Drawing.Point(4, 25);
            this.tabPageFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFilters.Name = "tabPageFilters";
            this.tabPageFilters.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFilters.Size = new System.Drawing.Size(1085, 494);
            this.tabPageFilters.TabIndex = 4;
            this.tabPageFilters.Text = "Filters";
            this.tabPageFilters.UseVisualStyleBackColor = true;
            // 
            // tabPagePrompts
            // 
            this.tabPagePrompts.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrompts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePrompts.Name = "tabPagePrompts";
            this.tabPagePrompts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePrompts.Size = new System.Drawing.Size(1085, 494);
            this.tabPagePrompts.TabIndex = 5;
            this.tabPagePrompts.Text = "Prompts";
            this.tabPagePrompts.UseVisualStyleBackColor = true;
            // 
            // tabPageMetrics
            // 
            this.tabPageMetrics.Location = new System.Drawing.Point(4, 25);
            this.tabPageMetrics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMetrics.Name = "tabPageMetrics";
            this.tabPageMetrics.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMetrics.Size = new System.Drawing.Size(1085, 494);
            this.tabPageMetrics.TabIndex = 6;
            this.tabPageMetrics.Text = "Metrics";
            this.tabPageMetrics.UseVisualStyleBackColor = true;
            // 
            // tabPageReports
            // 
            this.tabPageReports.Location = new System.Drawing.Point(4, 25);
            this.tabPageReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageReports.Size = new System.Drawing.Size(1085, 494);
            this.tabPageReports.TabIndex = 7;
            this.tabPageReports.Text = "Reports";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // tabPageDataSets
            // 
            this.tabPageDataSets.Location = new System.Drawing.Point(4, 25);
            this.tabPageDataSets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDataSets.Name = "tabPageDataSets";
            this.tabPageDataSets.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDataSets.Size = new System.Drawing.Size(1085, 494);
            this.tabPageDataSets.TabIndex = 8;
            this.tabPageDataSets.Text = "Datasets";
            this.tabPageDataSets.UseVisualStyleBackColor = true;
            // 
            // tabPageDashboards
            // 
            this.tabPageDashboards.Location = new System.Drawing.Point(4, 25);
            this.tabPageDashboards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDashboards.Name = "tabPageDashboards";
            this.tabPageDashboards.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDashboards.Size = new System.Drawing.Size(1085, 494);
            this.tabPageDashboards.TabIndex = 9;
            this.tabPageDashboards.Text = "Dashboards";
            this.tabPageDashboards.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dlgDatabaseFile
            // 
            this.dlgDatabaseFile.FileName = "databaseFile";
            // 
            // BtnCreateDataBase
            // 
            this.BtnCreateDataBase.Location = new System.Drawing.Point(691, 185);
            this.BtnCreateDataBase.Name = "BtnCreateDataBase";
            this.BtnCreateDataBase.Size = new System.Drawing.Size(173, 41);
            this.BtnCreateDataBase.TabIndex = 10;
            this.BtnCreateDataBase.Text = "Connect To Database";
            this.BtnCreateDataBase.UseVisualStyleBackColor = true;
            this.BtnCreateDataBase.Click += new System.EventHandler(this.BtnCreateDataBase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 523);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Analytics Solutions";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSummary.ResumeLayout(false);
            this.tabPageSummary.PerformLayout();
            this.groupBoxProjectObjs.ResumeLayout(false);
            this.groupBoxProjectObjs.PerformLayout();
            this.tabPageAttributes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttributes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSummary;
        private System.Windows.Forms.TabPage tabPageAttributes;
        private System.Windows.Forms.TabPage tabPageFacts;
        private System.Windows.Forms.TabPage tabPageHierarchies;
        private System.Windows.Forms.TabPage tabPageFilters;
        private System.Windows.Forms.TabPage tabPagePrompts;
        private System.Windows.Forms.TabPage tabPageMetrics;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.TabPage tabPageDataSets;
        private System.Windows.Forms.TabPage tabPageDashboards;
        private System.Windows.Forms.GroupBox groupBoxProjectObjs;
        private System.Windows.Forms.Label lblAttributes;
        private System.Windows.Forms.Button btnExportCRD;
        private System.Windows.Forms.Button btnExportDoc;
        private System.Windows.Forms.Button btnImportTables;
        private System.Windows.Forms.Label lblDashboardsVal;
        private System.Windows.Forms.Label lblDatasetsVal;
        private System.Windows.Forms.Label lblReportsVal;
        private System.Windows.Forms.Label lblMetricsVal;
        private System.Windows.Forms.Label lblPromptsVal;
        private System.Windows.Forms.Label lblFiltersVal;
        private System.Windows.Forms.Label lblHierVal;
        private System.Windows.Forms.Label lblFactsVal;
        private System.Windows.Forms.Label lblAttributesVal;
        private System.Windows.Forms.Label lblDashboards;
        private System.Windows.Forms.Label lblDatasets;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Label lblMetrics;
        private System.Windows.Forms.Label lblPrompts;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.Label lblHieracrhies;
        private System.Windows.Forms.Label lblFacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridView dataGridViewAttributes;
        private System.Windows.Forms.Button btnNewAttr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttrNumForms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttrNumChildren;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttrNumParents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttrComments;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox tbxDatabaseName;
        private System.Windows.Forms.OpenFileDialog dlgDatabaseFile;
        private System.Windows.Forms.Label lblDbError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCreateDataBase;
    }
}

