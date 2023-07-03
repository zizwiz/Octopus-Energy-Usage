
namespace EnergyUsage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_getinfo = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.rchtxtbx_data = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tab_data_input = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkbx_Gas_lineChart = new System.Windows.Forms.CheckBox();
            this.chkbx_Imported_Electric_lineChart = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_total_energy_cost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_total_gas_cost = new System.Windows.Forms.Label();
            this.lbl_gas_standing_charge = new System.Windows.Forms.Label();
            this.lbl_gas_cost = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_total_electricity_cost = new System.Windows.Forms.Label();
            this.lbl_electricity_standing_charge = new System.Windows.Forms.Label();
            this.lbl_electricity_cost = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_gas_usage = new System.Windows.Forms.Label();
            this.lbl_electricity_imported = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbobx_minute_to = new System.Windows.Forms.ComboBox();
            this.cmbobx_hour_to = new System.Windows.Forms.ComboBox();
            this.cmbobx_minute_from = new System.Windows.Forms.ComboBox();
            this.cmbobx_hour_from = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPicker_date_to = new System.Windows.Forms.DateTimePicker();
            this.dtPicker_date_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbx_gas_serial_num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_gas_mprn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_electric_serial_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_electric_import_mpan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_api_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdobtn_gas = new System.Windows.Forms.RadioButton();
            this.rdobtn_electricity_import = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab_electric_import = new System.Windows.Forms.TabPage();
            this.chart_electric_import = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tab_gas_import = new System.Windows.Forms.TabPage();
            this.chart_gas_import = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_fill_data = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rdobtn_electricity_export = new System.Windows.Forms.RadioButton();
            this.tab_electric_export = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.chart_electric_export = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtbx_electric_export_mpan = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_electricity_net = new System.Windows.Forms.Label();
            this.chkbx_Exported_Electric_lineChart = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tab_combined_electricity = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.chart_electric_combined = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chkbx_Combined_Electric_lineChart = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_electricity_exported = new System.Windows.Forms.Label();
            this.btn_print_chart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.tab_data_input.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab_electric_import.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_electric_import)).BeginInit();
            this.tab_gas_import.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_gas_import)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tab_electric_export.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_electric_export)).BeginInit();
            this.tab_combined_electricity.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_electric_combined)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_getinfo
            // 
            this.btn_getinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_getinfo.Location = new System.Drawing.Point(13, 9);
            this.btn_getinfo.Name = "btn_getinfo";
            this.btn_getinfo.Size = new System.Drawing.Size(165, 50);
            this.btn_getinfo.TabIndex = 0;
            this.btn_getinfo.Text = "Get Info";
            this.btn_getinfo.UseVisualStyleBackColor = true;
            this.btn_getinfo.Click += new System.EventHandler(this.btn_getinfo_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(13, 9);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(128, 50);
            this.btn_help.TabIndex = 1;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(16, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(163, 50);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // rchtxtbx_data
            // 
            this.rchtxtbx_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtbx_data.Location = new System.Drawing.Point(3, 3);
            this.rchtxtbx_data.Name = "rchtxtbx_data";
            this.rchtxtbx_data.Size = new System.Drawing.Size(1178, 638);
            this.rchtxtbx_data.TabIndex = 3;
            this.rchtxtbx_data.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1198, 763);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 677);
            this.panel1.TabIndex = 0;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tab_data_input);
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tab_electric_import);
            this.TabControl1.Controls.Add(this.tab_electric_export);
            this.TabControl1.Controls.Add(this.tab_combined_electricity);
            this.TabControl1.Controls.Add(this.tab_gas_import);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1192, 677);
            this.TabControl1.TabIndex = 0;
            // 
            // tab_data_input
            // 
            this.tab_data_input.Controls.Add(this.groupBox6);
            this.tab_data_input.Controls.Add(this.groupBox5);
            this.tab_data_input.Controls.Add(this.groupBox4);
            this.tab_data_input.Controls.Add(this.groupBox3);
            this.tab_data_input.Controls.Add(this.groupBox2);
            this.tab_data_input.Controls.Add(this.groupBox1);
            this.tab_data_input.Location = new System.Drawing.Point(4, 29);
            this.tab_data_input.Name = "tab_data_input";
            this.tab_data_input.Padding = new System.Windows.Forms.Padding(3);
            this.tab_data_input.Size = new System.Drawing.Size(1184, 644);
            this.tab_data_input.TabIndex = 2;
            this.tab_data_input.Text = "Data Input";
            this.tab_data_input.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkbx_Combined_Electric_lineChart);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.chkbx_Exported_Electric_lineChart);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.chkbx_Gas_lineChart);
            this.groupBox6.Controls.Add(this.chkbx_Imported_Electric_lineChart);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(15, 219);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(315, 176);
            this.groupBox6.TabIndex = 49;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chart Type";
            // 
            // chkbx_Gas_lineChart
            // 
            this.chkbx_Gas_lineChart.AutoSize = true;
            this.chkbx_Gas_lineChart.Location = new System.Drawing.Point(269, 140);
            this.chkbx_Gas_lineChart.Name = "chkbx_Gas_lineChart";
            this.chkbx_Gas_lineChart.Size = new System.Drawing.Size(22, 21);
            this.chkbx_Gas_lineChart.TabIndex = 50;
            this.chkbx_Gas_lineChart.UseVisualStyleBackColor = true;
            // 
            // chkbx_Imported_Electric_lineChart
            // 
            this.chkbx_Imported_Electric_lineChart.AutoSize = true;
            this.chkbx_Imported_Electric_lineChart.Location = new System.Drawing.Point(269, 59);
            this.chkbx_Imported_Electric_lineChart.Name = "chkbx_Imported_Electric_lineChart";
            this.chkbx_Imported_Electric_lineChart.Size = new System.Drawing.Size(22, 21);
            this.chkbx_Imported_Electric_lineChart.TabIndex = 49;
            this.chkbx_Imported_Electric_lineChart.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 20);
            this.label14.TabIndex = 46;
            this.label14.Text = "Gas as Line Chart";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Imported Electricity as Line Chart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Default is Bar Chart";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_total_energy_cost);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.lbl_total_gas_cost);
            this.groupBox5.Controls.Add(this.lbl_gas_standing_charge);
            this.groupBox5.Controls.Add(this.lbl_gas_cost);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lbl_total_electricity_cost);
            this.groupBox5.Controls.Add(this.lbl_electricity_standing_charge);
            this.groupBox5.Controls.Add(this.lbl_electricity_cost);
            this.groupBox5.Controls.Add(this.lbl3);
            this.groupBox5.Controls.Add(this.lbl2);
            this.groupBox5.Controls.Add(this.lbl1);
            this.groupBox5.Location = new System.Drawing.Point(766, 292);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(387, 298);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Energy Costs";
            // 
            // lbl_total_energy_cost
            // 
            this.lbl_total_energy_cost.AutoSize = true;
            this.lbl_total_energy_cost.Location = new System.Drawing.Point(233, 257);
            this.lbl_total_energy_cost.Name = "lbl_total_energy_cost";
            this.lbl_total_energy_cost.Size = new System.Drawing.Size(27, 20);
            this.lbl_total_energy_cost.TabIndex = 45;
            this.lbl_total_energy_cost.Text = "0p";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Total Change";
            // 
            // lbl_total_gas_cost
            // 
            this.lbl_total_gas_cost.AutoSize = true;
            this.lbl_total_gas_cost.Location = new System.Drawing.Point(233, 199);
            this.lbl_total_gas_cost.Name = "lbl_total_gas_cost";
            this.lbl_total_gas_cost.Size = new System.Drawing.Size(27, 20);
            this.lbl_total_gas_cost.TabIndex = 43;
            this.lbl_total_gas_cost.Text = "0p";
            // 
            // lbl_gas_standing_charge
            // 
            this.lbl_gas_standing_charge.AutoSize = true;
            this.lbl_gas_standing_charge.Location = new System.Drawing.Point(233, 168);
            this.lbl_gas_standing_charge.Name = "lbl_gas_standing_charge";
            this.lbl_gas_standing_charge.Size = new System.Drawing.Size(27, 20);
            this.lbl_gas_standing_charge.TabIndex = 42;
            this.lbl_gas_standing_charge.Text = "0p";
            // 
            // lbl_gas_cost
            // 
            this.lbl_gas_cost.AutoSize = true;
            this.lbl_gas_cost.Location = new System.Drawing.Point(233, 139);
            this.lbl_gas_cost.Name = "lbl_gas_cost";
            this.lbl_gas_cost.Size = new System.Drawing.Size(27, 20);
            this.lbl_gas_cost.TabIndex = 41;
            this.lbl_gas_cost.Text = "0p";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "Gas Total Change";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Gas standing charge";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Gas cost";
            // 
            // lbl_total_electricity_cost
            // 
            this.lbl_total_electricity_cost.AutoSize = true;
            this.lbl_total_electricity_cost.Location = new System.Drawing.Point(233, 88);
            this.lbl_total_electricity_cost.Name = "lbl_total_electricity_cost";
            this.lbl_total_electricity_cost.Size = new System.Drawing.Size(27, 20);
            this.lbl_total_electricity_cost.TabIndex = 37;
            this.lbl_total_electricity_cost.Text = "0p";
            // 
            // lbl_electricity_standing_charge
            // 
            this.lbl_electricity_standing_charge.AutoSize = true;
            this.lbl_electricity_standing_charge.Location = new System.Drawing.Point(233, 57);
            this.lbl_electricity_standing_charge.Name = "lbl_electricity_standing_charge";
            this.lbl_electricity_standing_charge.Size = new System.Drawing.Size(27, 20);
            this.lbl_electricity_standing_charge.TabIndex = 36;
            this.lbl_electricity_standing_charge.Text = "0p";
            // 
            // lbl_electricity_cost
            // 
            this.lbl_electricity_cost.AutoSize = true;
            this.lbl_electricity_cost.Location = new System.Drawing.Point(233, 28);
            this.lbl_electricity_cost.Name = "lbl_electricity_cost";
            this.lbl_electricity_cost.Size = new System.Drawing.Size(27, 20);
            this.lbl_electricity_cost.TabIndex = 35;
            this.lbl_electricity_cost.Text = "0p";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(16, 88);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(175, 20);
            this.lbl3.TabIndex = 34;
            this.lbl3.Text = "Electricity Total Change";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(16, 57);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(194, 20);
            this.lbl2.TabIndex = 33;
            this.lbl2.Text = "Electricity standing charge";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(16, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(110, 20);
            this.lbl1.TabIndex = 32;
            this.lbl1.Text = "Electricity cost";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.lbl_electricity_exported);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.lbl_electricity_net);
            this.groupBox4.Controls.Add(this.lbl_gas_usage);
            this.groupBox4.Controls.Add(this.lbl_electricity_imported);
            this.groupBox4.Location = new System.Drawing.Point(15, 401);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 237);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Energy Usage";
            // 
            // lbl_gas_usage
            // 
            this.lbl_gas_usage.AutoSize = true;
            this.lbl_gas_usage.Location = new System.Drawing.Point(13, 183);
            this.lbl_gas_usage.Name = "lbl_gas_usage";
            this.lbl_gas_usage.Size = new System.Drawing.Size(93, 20);
            this.lbl_gas_usage.TabIndex = 30;
            this.lbl_gas_usage.Text = "Gas = 0kwh";
            // 
            // lbl_electricity_imported
            // 
            this.lbl_electricity_imported.AutoSize = true;
            this.lbl_electricity_imported.Location = new System.Drawing.Point(193, 42);
            this.lbl_electricity_imported.Name = "lbl_electricity_imported";
            this.lbl_electricity_imported.Size = new System.Drawing.Size(18, 20);
            this.lbl_electricity_imported.TabIndex = 29;
            this.lbl_electricity_imported.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbobx_minute_to);
            this.groupBox3.Controls.Add(this.cmbobx_hour_to);
            this.groupBox3.Controls.Add(this.cmbobx_minute_from);
            this.groupBox3.Controls.Add(this.cmbobx_hour_from);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dtPicker_date_to);
            this.groupBox3.Controls.Add(this.dtPicker_date_from);
            this.groupBox3.Location = new System.Drawing.Point(217, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 185);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Span";
            // 
            // cmbobx_minute_to
            // 
            this.cmbobx_minute_to.FormattingEnabled = true;
            this.cmbobx_minute_to.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cmbobx_minute_to.Location = new System.Drawing.Point(231, 141);
            this.cmbobx_minute_to.Name = "cmbobx_minute_to";
            this.cmbobx_minute_to.Size = new System.Drawing.Size(61, 28);
            this.cmbobx_minute_to.TabIndex = 27;
            // 
            // cmbobx_hour_to
            // 
            this.cmbobx_hour_to.FormattingEnabled = true;
            this.cmbobx_hour_to.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbobx_hour_to.Location = new System.Drawing.Point(170, 141);
            this.cmbobx_hour_to.Name = "cmbobx_hour_to";
            this.cmbobx_hour_to.Size = new System.Drawing.Size(55, 28);
            this.cmbobx_hour_to.TabIndex = 26;
            // 
            // cmbobx_minute_from
            // 
            this.cmbobx_minute_from.FormattingEnabled = true;
            this.cmbobx_minute_from.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cmbobx_minute_from.Location = new System.Drawing.Point(231, 68);
            this.cmbobx_minute_from.Name = "cmbobx_minute_from";
            this.cmbobx_minute_from.Size = new System.Drawing.Size(61, 28);
            this.cmbobx_minute_from.TabIndex = 25;
            // 
            // cmbobx_hour_from
            // 
            this.cmbobx_hour_from.FormattingEnabled = true;
            this.cmbobx_hour_from.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbobx_hour_from.Location = new System.Drawing.Point(170, 68);
            this.cmbobx_hour_from.Name = "cmbobx_hour_from";
            this.cmbobx_hour_from.Size = new System.Drawing.Size(55, 28);
            this.cmbobx_hour_from.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Period To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Period From:";
            // 
            // dtPicker_date_to
            // 
            this.dtPicker_date_to.CustomFormat = "yyyy-MM-dd";
            this.dtPicker_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_date_to.Location = new System.Drawing.Point(18, 139);
            this.dtPicker_date_to.Name = "dtPicker_date_to";
            this.dtPicker_date_to.Size = new System.Drawing.Size(142, 26);
            this.dtPicker_date_to.TabIndex = 20;
            // 
            // dtPicker_date_from
            // 
            this.dtPicker_date_from.CustomFormat = "yyyy-MM-dd";
            this.dtPicker_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_date_from.Location = new System.Drawing.Point(18, 66);
            this.dtPicker_date_from.Name = "dtPicker_date_from";
            this.dtPicker_date_from.Size = new System.Drawing.Size(142, 26);
            this.dtPicker_date_from.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbx_electric_export_mpan);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtbx_gas_serial_num);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtbx_gas_mprn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbx_electric_serial_num);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbx_electric_import_mpan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbx_api_key);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(558, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 241);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // txtbx_gas_serial_num
            // 
            this.txtbx_gas_serial_num.Location = new System.Drawing.Point(322, 192);
            this.txtbx_gas_serial_num.Name = "txtbx_gas_serial_num";
            this.txtbx_gas_serial_num.Size = new System.Drawing.Size(242, 26);
            this.txtbx_gas_serial_num.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gas meter\'s serial number";
            // 
            // txtbx_gas_mprn
            // 
            this.txtbx_gas_mprn.Location = new System.Drawing.Point(322, 160);
            this.txtbx_gas_mprn.Name = "txtbx_gas_mprn";
            this.txtbx_gas_mprn.Size = new System.Drawing.Size(242, 26);
            this.txtbx_gas_mprn.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gas meterpoint\'s MPRN";
            // 
            // txtbx_electric_serial_num
            // 
            this.txtbx_electric_serial_num.Location = new System.Drawing.Point(322, 128);
            this.txtbx_electric_serial_num.Name = "txtbx_electric_serial_num";
            this.txtbx_electric_serial_num.Size = new System.Drawing.Size(242, 26);
            this.txtbx_electric_serial_num.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Electricty meter\'s serial number";
            // 
            // txtbx_electric_import_mpan
            // 
            this.txtbx_electric_import_mpan.Location = new System.Drawing.Point(322, 64);
            this.txtbx_electric_import_mpan.Name = "txtbx_electric_import_mpan";
            this.txtbx_electric_import_mpan.Size = new System.Drawing.Size(242, 26);
            this.txtbx_electric_import_mpan.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Electricty import meterpoint\'s MPAN";
            // 
            // txtbx_api_key
            // 
            this.txtbx_api_key.Location = new System.Drawing.Point(322, 32);
            this.txtbx_api_key.Name = "txtbx_api_key";
            this.txtbx_api_key.Size = new System.Drawing.Size(242, 26);
            this.txtbx_api_key.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "API Key";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobtn_electricity_export);
            this.groupBox1.Controls.Add(this.rdobtn_gas);
            this.groupBox1.Controls.Add(this.rdobtn_electricity_import);
            this.groupBox1.Location = new System.Drawing.Point(15, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Which Fuel?";
            // 
            // rdobtn_gas
            // 
            this.rdobtn_gas.AutoSize = true;
            this.rdobtn_gas.Location = new System.Drawing.Point(20, 99);
            this.rdobtn_gas.Name = "rdobtn_gas";
            this.rdobtn_gas.Size = new System.Drawing.Size(64, 24);
            this.rdobtn_gas.TabIndex = 2;
            this.rdobtn_gas.Text = "Gas";
            this.rdobtn_gas.UseVisualStyleBackColor = true;
            // 
            // rdobtn_electricity_import
            // 
            this.rdobtn_electricity_import.AutoSize = true;
            this.rdobtn_electricity_import.Checked = true;
            this.rdobtn_electricity_import.Location = new System.Drawing.Point(20, 38);
            this.rdobtn_electricity_import.Name = "rdobtn_electricity_import";
            this.rdobtn_electricity_import.Size = new System.Drawing.Size(159, 24);
            this.rdobtn_electricity_import.TabIndex = 1;
            this.rdobtn_electricity_import.Text = "Electricicty Import";
            this.rdobtn_electricity_import.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rchtxtbx_data);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1184, 644);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tab_electric_import
            // 
            this.tab_electric_import.Controls.Add(this.chart_electric_import);
            this.tab_electric_import.Location = new System.Drawing.Point(4, 29);
            this.tab_electric_import.Name = "tab_electric_import";
            this.tab_electric_import.Padding = new System.Windows.Forms.Padding(3);
            this.tab_electric_import.Size = new System.Drawing.Size(1184, 644);
            this.tab_electric_import.TabIndex = 1;
            this.tab_electric_import.Text = "Electricity Import";
            this.tab_electric_import.UseVisualStyleBackColor = true;
            // 
            // chart_electric_import
            // 
            chartArea1.Name = "importElectricChartArea";
            this.chart_electric_import.ChartAreas.Add(chartArea1);
            this.chart_electric_import.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_electric_import.Legends.Add(legend1);
            this.chart_electric_import.Location = new System.Drawing.Point(3, 3);
            this.chart_electric_import.Name = "chart_electric_import";
            series1.ChartArea = "importElectricChartArea";
            series1.Legend = "Legend1";
            series1.Name = "ImportElectricitySeries";
            this.chart_electric_import.Series.Add(series1);
            this.chart_electric_import.Size = new System.Drawing.Size(1178, 638);
            this.chart_electric_import.TabIndex = 0;
            this.chart_electric_import.Text = "chart1";
            this.chart_electric_import.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_electric_usage_MouseMove);
            // 
            // tab_gas_import
            // 
            this.tab_gas_import.Controls.Add(this.chart_gas_import);
            this.tab_gas_import.Location = new System.Drawing.Point(4, 29);
            this.tab_gas_import.Name = "tab_gas_import";
            this.tab_gas_import.Size = new System.Drawing.Size(1184, 644);
            this.tab_gas_import.TabIndex = 3;
            this.tab_gas_import.Text = "Gas Import";
            this.tab_gas_import.UseVisualStyleBackColor = true;
            // 
            // chart_gas_import
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_gas_import.ChartAreas.Add(chartArea4);
            this.chart_gas_import.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart_gas_import.Legends.Add(legend4);
            this.chart_gas_import.Location = new System.Drawing.Point(0, 0);
            this.chart_gas_import.Name = "chart_gas_import";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart_gas_import.Series.Add(series5);
            this.chart_gas_import.Size = new System.Drawing.Size(1184, 644);
            this.chart_gas_import.TabIndex = 0;
            this.chart_gas_import.Text = "chart1";
            this.chart_gas_import.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_gas_usage_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 686);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 74);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64995F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64995F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64995F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64995F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64995F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75025F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1192, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_help);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 68);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_fill_data);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(201, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 68);
            this.panel4.TabIndex = 1;
            // 
            // btn_fill_data
            // 
            this.btn_fill_data.Location = new System.Drawing.Point(28, 9);
            this.btn_fill_data.Name = "btn_fill_data";
            this.btn_fill_data.Size = new System.Drawing.Size(128, 50);
            this.btn_fill_data.TabIndex = 2;
            this.btn_fill_data.Text = "Fill Data";
            this.btn_fill_data.UseVisualStyleBackColor = true;
            this.btn_fill_data.Click += new System.EventHandler(this.btn_fill_data_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_print_chart);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(399, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 68);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_getinfo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(597, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(192, 68);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(795, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(192, 68);
            this.panel7.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_close);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(993, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(196, 68);
            this.panel8.TabIndex = 5;
            // 
            // rdobtn_electricity_export
            // 
            this.rdobtn_electricity_export.AutoSize = true;
            this.rdobtn_electricity_export.Location = new System.Drawing.Point(20, 69);
            this.rdobtn_electricity_export.Name = "rdobtn_electricity_export";
            this.rdobtn_electricity_export.Size = new System.Drawing.Size(159, 24);
            this.rdobtn_electricity_export.TabIndex = 3;
            this.rdobtn_electricity_export.Text = "Electricicty Export";
            this.rdobtn_electricity_export.UseVisualStyleBackColor = true;
            // 
            // tab_electric_export
            // 
            this.tab_electric_export.Controls.Add(this.panel9);
            this.tab_electric_export.Location = new System.Drawing.Point(4, 29);
            this.tab_electric_export.Name = "tab_electric_export";
            this.tab_electric_export.Size = new System.Drawing.Size(1184, 644);
            this.tab_electric_export.TabIndex = 4;
            this.tab_electric_export.Text = "Electricity Export";
            this.tab_electric_export.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.chart_electric_export);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1184, 644);
            this.panel9.TabIndex = 0;
            // 
            // chart_electric_export
            // 
            chartArea2.Name = "exportElectricChartArea";
            this.chart_electric_export.ChartAreas.Add(chartArea2);
            this.chart_electric_export.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_electric_export.Legends.Add(legend2);
            this.chart_electric_export.Location = new System.Drawing.Point(0, 0);
            this.chart_electric_export.Name = "chart_electric_export";
            series2.ChartArea = "exportElectricChartArea";
            series2.Legend = "Legend1";
            series2.Name = "ExportElectricitySeries";
            this.chart_electric_export.Series.Add(series2);
            this.chart_electric_export.Size = new System.Drawing.Size(1184, 644);
            this.chart_electric_export.TabIndex = 1;
            this.chart_electric_export.Text = "chart1";
            this.chart_electric_export.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_electric_export_MouseMove);
            // 
            // txtbx_electric_export_mpan
            // 
            this.txtbx_electric_export_mpan.Location = new System.Drawing.Point(322, 96);
            this.txtbx_electric_export_mpan.Name = "txtbx_electric_export_mpan";
            this.txtbx_electric_export_mpan.Size = new System.Drawing.Size(242, 26);
            this.txtbx_electric_export_mpan.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(261, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Electricty export meterpoint\'s MPAN";
            // 
            // lbl_electricity_net
            // 
            this.lbl_electricity_net.AutoSize = true;
            this.lbl_electricity_net.Location = new System.Drawing.Point(13, 152);
            this.lbl_electricity_net.Name = "lbl_electricity_net";
            this.lbl_electricity_net.Size = new System.Drawing.Size(166, 20);
            this.lbl_electricity_net.TabIndex = 32;
            this.lbl_electricity_net.Text = "Electricity Sold = 0kwh";
            // 
            // chkbx_Exported_Electric_lineChart
            // 
            this.chkbx_Exported_Electric_lineChart.AutoSize = true;
            this.chkbx_Exported_Electric_lineChart.Location = new System.Drawing.Point(269, 86);
            this.chkbx_Exported_Electric_lineChart.Name = "chkbx_Exported_Electric_lineChart";
            this.chkbx_Exported_Electric_lineChart.Size = new System.Drawing.Size(22, 21);
            this.chkbx_Exported_Electric_lineChart.TabIndex = 52;
            this.chkbx_Exported_Electric_lineChart.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(242, 20);
            this.label16.TabIndex = 51;
            this.label16.Text = "Exported Electricity as Line Chart";
            // 
            // tab_combined_electricity
            // 
            this.tab_combined_electricity.Controls.Add(this.panel10);
            this.tab_combined_electricity.Location = new System.Drawing.Point(4, 29);
            this.tab_combined_electricity.Name = "tab_combined_electricity";
            this.tab_combined_electricity.Size = new System.Drawing.Size(1184, 644);
            this.tab_combined_electricity.TabIndex = 5;
            this.tab_combined_electricity.Text = "Electricity Combined";
            this.tab_combined_electricity.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.chart_electric_combined);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1184, 644);
            this.panel10.TabIndex = 0;
            // 
            // chart_electric_combined
            // 
            chartArea3.Name = "combinedElectricChartArea";
            this.chart_electric_combined.ChartAreas.Add(chartArea3);
            this.chart_electric_combined.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart_electric_combined.Legends.Add(legend3);
            this.chart_electric_combined.Location = new System.Drawing.Point(0, 0);
            this.chart_electric_combined.Name = "chart_electric_combined";
            series3.ChartArea = "combinedElectricChartArea";
            series3.Legend = "Legend1";
            series3.Name = "ExportElectricitySeries";
            series4.ChartArea = "combinedElectricChartArea";
            series4.Legend = "Legend1";
            series4.Name = "ImportElectricitySeries";
            this.chart_electric_combined.Series.Add(series3);
            this.chart_electric_combined.Series.Add(series4);
            this.chart_electric_combined.Size = new System.Drawing.Size(1184, 644);
            this.chart_electric_combined.TabIndex = 2;
            this.chart_electric_combined.Text = "chart1";
            this.chart_electric_combined.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_electric_combined_MouseMove);
            // 
            // chkbx_Combined_Electric_lineChart
            // 
            this.chkbx_Combined_Electric_lineChart.AutoSize = true;
            this.chkbx_Combined_Electric_lineChart.Location = new System.Drawing.Point(269, 113);
            this.chkbx_Combined_Electric_lineChart.Name = "chkbx_Combined_Electric_lineChart";
            this.chkbx_Combined_Electric_lineChart.Size = new System.Drawing.Size(22, 21);
            this.chkbx_Combined_Electric_lineChart.TabIndex = 54;
            this.chkbx_Combined_Electric_lineChart.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(250, 20);
            this.label17.TabIndex = 53;
            this.label17.Text = "Combined Electricity as Line Chart";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(161, 20);
            this.label18.TabIndex = 33;
            this.label18.Text = "Electricity Imported = ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(247, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 20);
            this.label19.TabIndex = 34;
            this.label19.Text = "kwh";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(247, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 20);
            this.label20.TabIndex = 37;
            this.label20.Text = "kwh";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(161, 20);
            this.label21.TabIndex = 36;
            this.label21.Text = "Electricity Exported = ";
            // 
            // lbl_electricity_exported
            // 
            this.lbl_electricity_exported.AutoSize = true;
            this.lbl_electricity_exported.Location = new System.Drawing.Point(193, 70);
            this.lbl_electricity_exported.Name = "lbl_electricity_exported";
            this.lbl_electricity_exported.Size = new System.Drawing.Size(18, 20);
            this.lbl_electricity_exported.TabIndex = 35;
            this.lbl_electricity_exported.Text = "0";
            // 
            // btn_print_chart
            // 
            this.btn_print_chart.Location = new System.Drawing.Point(32, 9);
            this.btn_print_chart.Name = "btn_print_chart";
            this.btn_print_chart.Size = new System.Drawing.Size(128, 50);
            this.btn_print_chart.TabIndex = 3;
            this.btn_print_chart.Text = "Print Chart";
            this.btn_print_chart.UseVisualStyleBackColor = true;
            this.btn_print_chart.Click += new System.EventHandler(this.btn_print_chart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 763);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Energy Usage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.tab_data_input.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tab_electric_import.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_electric_import)).EndInit();
            this.tab_gas_import.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_gas_import)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tab_electric_export.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_electric_export)).EndInit();
            this.tab_combined_electricity.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_electric_combined)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_getinfo;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.RichTextBox rchtxtbx_data;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab_electric_import;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TabPage tab_data_input;
        private System.Windows.Forms.TabPage tab_gas_import;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_gas_import;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbx_gas_serial_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_gas_mprn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_electric_serial_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_electric_import_mpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_api_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdobtn_gas;
        private System.Windows.Forms.RadioButton rdobtn_electricity_import;
        private System.Windows.Forms.ComboBox cmbobx_minute_from;
        private System.Windows.Forms.ComboBox cmbobx_hour_from;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPicker_date_to;
        private System.Windows.Forms.DateTimePicker dtPicker_date_from;
        private System.Windows.Forms.ComboBox cmbobx_minute_to;
        private System.Windows.Forms.ComboBox cmbobx_hour_to;
        private System.Windows.Forms.Button btn_fill_data;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_gas_usage;
        private System.Windows.Forms.Label lbl_electricity_imported;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_total_energy_cost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_total_gas_cost;
        private System.Windows.Forms.Label lbl_gas_standing_charge;
        private System.Windows.Forms.Label lbl_gas_cost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_total_electricity_cost;
        private System.Windows.Forms.Label lbl_electricity_standing_charge;
        private System.Windows.Forms.Label lbl_electricity_cost;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkbx_Gas_lineChart;
        private System.Windows.Forms.CheckBox chkbx_Imported_Electric_lineChart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_electric_import;
        private System.Windows.Forms.RadioButton rdobtn_electricity_export;
        private System.Windows.Forms.TabPage tab_electric_export;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_electric_export;
        private System.Windows.Forms.TextBox txtbx_electric_export_mpan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkbx_Exported_Electric_lineChart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_electricity_net;
        private System.Windows.Forms.TabPage tab_combined_electricity;
        private System.Windows.Forms.Panel panel10;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_electric_combined;
        private System.Windows.Forms.CheckBox chkbx_Combined_Electric_lineChart;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_electricity_exported;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_print_chart;
    }
}

