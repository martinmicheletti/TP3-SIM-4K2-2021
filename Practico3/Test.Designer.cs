namespace Practico3
{
    partial class Test
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlPoisson = new System.Windows.Forms.Panel();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.lblLambda = new System.Windows.Forms.Label();
            this.pnlNormal = new System.Windows.Forms.Panel();
            this.txtDesviacion = new System.Windows.Forms.TextBox();
            this.txtMediaNormal = new System.Windows.Forms.TextBox();
            this.lblDesviacion = new System.Windows.Forms.Label();
            this.lblMediaNormal = new System.Windows.Forms.Label();
            this.pnlExponencial = new System.Windows.Forms.Panel();
            this.txtMediaExpo = new System.Windows.Forms.TextBox();
            this.lblMediaExpo = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.rbdPoisson = new System.Windows.Forms.RadioButton();
            this.rbdNormal = new System.Windows.Forms.RadioButton();
            this.rbdExponencial = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gvTest = new System.Windows.Forms.DataGridView();
            this.cbmIntervalos = new System.Windows.Forms.ComboBox();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.lblRdo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listValores = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblXiTabulado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGradosLibertad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlPoisson.SuspendLayout();
            this.pnlNormal.SuspendLayout();
            this.pnlExponencial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPoisson
            // 
            this.pnlPoisson.Controls.Add(this.txtLambda);
            this.pnlPoisson.Controls.Add(this.lblLambda);
            this.pnlPoisson.Location = new System.Drawing.Point(549, 26);
            this.pnlPoisson.Name = "pnlPoisson";
            this.pnlPoisson.Size = new System.Drawing.Size(398, 50);
            this.pnlPoisson.TabIndex = 20;
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(83, 17);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(100, 20);
            this.txtLambda.TabIndex = 1;
            // 
            // lblLambda
            // 
            this.lblLambda.AutoSize = true;
            this.lblLambda.Location = new System.Drawing.Point(14, 20);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(45, 13);
            this.lblLambda.TabIndex = 0;
            this.lblLambda.Text = "Lambda";
            // 
            // pnlNormal
            // 
            this.pnlNormal.Controls.Add(this.txtDesviacion);
            this.pnlNormal.Controls.Add(this.txtMediaNormal);
            this.pnlNormal.Controls.Add(this.lblDesviacion);
            this.pnlNormal.Controls.Add(this.lblMediaNormal);
            this.pnlNormal.Location = new System.Drawing.Point(549, 26);
            this.pnlNormal.Name = "pnlNormal";
            this.pnlNormal.Size = new System.Drawing.Size(410, 57);
            this.pnlNormal.TabIndex = 19;
            // 
            // txtDesviacion
            // 
            this.txtDesviacion.Location = new System.Drawing.Point(283, 13);
            this.txtDesviacion.Name = "txtDesviacion";
            this.txtDesviacion.Size = new System.Drawing.Size(100, 20);
            this.txtDesviacion.TabIndex = 3;
            // 
            // txtMediaNormal
            // 
            this.txtMediaNormal.Location = new System.Drawing.Point(84, 13);
            this.txtMediaNormal.Name = "txtMediaNormal";
            this.txtMediaNormal.Size = new System.Drawing.Size(100, 20);
            this.txtMediaNormal.TabIndex = 2;
            // 
            // lblDesviacion
            // 
            this.lblDesviacion.AutoSize = true;
            this.lblDesviacion.Location = new System.Drawing.Point(201, 16);
            this.lblDesviacion.Name = "lblDesviacion";
            this.lblDesviacion.Size = new System.Drawing.Size(60, 13);
            this.lblDesviacion.TabIndex = 1;
            this.lblDesviacion.Text = "Desviación";
            // 
            // lblMediaNormal
            // 
            this.lblMediaNormal.AutoSize = true;
            this.lblMediaNormal.Location = new System.Drawing.Point(15, 16);
            this.lblMediaNormal.Name = "lblMediaNormal";
            this.lblMediaNormal.Size = new System.Drawing.Size(36, 13);
            this.lblMediaNormal.TabIndex = 0;
            this.lblMediaNormal.Text = "Media";
            // 
            // pnlExponencial
            // 
            this.pnlExponencial.Controls.Add(this.txtMediaExpo);
            this.pnlExponencial.Controls.Add(this.lblMediaExpo);
            this.pnlExponencial.Location = new System.Drawing.Point(549, 23);
            this.pnlExponencial.Name = "pnlExponencial";
            this.pnlExponencial.Size = new System.Drawing.Size(196, 59);
            this.pnlExponencial.TabIndex = 18;
            // 
            // txtMediaExpo
            // 
            this.txtMediaExpo.Location = new System.Drawing.Point(85, 14);
            this.txtMediaExpo.Name = "txtMediaExpo";
            this.txtMediaExpo.Size = new System.Drawing.Size(100, 20);
            this.txtMediaExpo.TabIndex = 1;
            // 
            // lblMediaExpo
            // 
            this.lblMediaExpo.AutoSize = true;
            this.lblMediaExpo.Location = new System.Drawing.Point(16, 17);
            this.lblMediaExpo.Name = "lblMediaExpo";
            this.lblMediaExpo.Size = new System.Drawing.Size(36, 13);
            this.lblMediaExpo.TabIndex = 0;
            this.lblMediaExpo.Text = "Media";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(234, 25);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(115, 20);
            this.txtCantidad.TabIndex = 16;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(9, 26);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(219, 16);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad de valores a generar";
            // 
            // rbdPoisson
            // 
            this.rbdPoisson.AutoSize = true;
            this.rbdPoisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdPoisson.Location = new System.Drawing.Point(18, 33);
            this.rbdPoisson.Margin = new System.Windows.Forms.Padding(4);
            this.rbdPoisson.Name = "rbdPoisson";
            this.rbdPoisson.Size = new System.Drawing.Size(75, 20);
            this.rbdPoisson.TabIndex = 14;
            this.rbdPoisson.Text = "Poisson";
            this.rbdPoisson.UseVisualStyleBackColor = true;
            this.rbdPoisson.CheckedChanged += new System.EventHandler(this.Test_Load);
            // 
            // rbdNormal
            // 
            this.rbdNormal.AutoSize = true;
            this.rbdNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdNormal.Location = new System.Drawing.Point(18, 16);
            this.rbdNormal.Margin = new System.Windows.Forms.Padding(4);
            this.rbdNormal.Name = "rbdNormal";
            this.rbdNormal.Size = new System.Drawing.Size(70, 20);
            this.rbdNormal.TabIndex = 13;
            this.rbdNormal.Text = "Normal";
            this.rbdNormal.UseVisualStyleBackColor = true;
            this.rbdNormal.CheckedChanged += new System.EventHandler(this.Test_Load);
            // 
            // rbdExponencial
            // 
            this.rbdExponencial.AutoSize = true;
            this.rbdExponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdExponencial.Location = new System.Drawing.Point(18, 50);
            this.rbdExponencial.Margin = new System.Windows.Forms.Padding(4);
            this.rbdExponencial.Name = "rbdExponencial";
            this.rbdExponencial.Size = new System.Drawing.Size(100, 20);
            this.rbdExponencial.TabIndex = 12;
            this.rbdExponencial.Text = "Exponencial";
            this.rbdExponencial.UseVisualStyleBackColor = true;
            this.rbdExponencial.CheckedChanged += new System.EventHandler(this.Test_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "SIM - Práctico 3 - Variables Aleatorias ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(983, 60);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 23);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(983, 23);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(117, 23);
            this.btnTest.TabIndex = 23;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(0, 0);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "FO";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "FE";
            this.grafico.Series.Add(series1);
            this.grafico.Series.Add(series2);
            this.grafico.Size = new System.Drawing.Size(1100, 484);
            this.grafico.TabIndex = 3;
            this.grafico.Text = "chart1";
            // 
            // gvTest
            // 
            this.gvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTest.Location = new System.Drawing.Point(0, 107);
            this.gvTest.Name = "gvTest";
            this.gvTest.Size = new System.Drawing.Size(1110, 380);
            this.gvTest.TabIndex = 2;
            // 
            // cbmIntervalos
            // 
            this.cbmIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmIntervalos.FormattingEnabled = true;
            this.cbmIntervalos.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cbmIntervalos.Location = new System.Drawing.Point(234, 59);
            this.cbmIntervalos.Name = "cbmIntervalos";
            this.cbmIntervalos.Size = new System.Drawing.Size(115, 21);
            this.cbmIntervalos.TabIndex = 1;
            this.cbmIntervalos.SelectedIndexChanged += new System.EventHandler(this.cbmIntervalos_SelectedIndexChanged);
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalos.Location = new System.Drawing.Point(9, 60);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(164, 16);
            this.lblIntervalos.TabIndex = 0;
            this.lblIntervalos.Text = "Cantidad de Intervalos";
            // 
            // lblRdo
            // 
            this.lblRdo.AutoSize = true;
            this.lblRdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdo.ForeColor = System.Drawing.Color.Blue;
            this.lblRdo.Location = new System.Drawing.Point(985, 18);
            this.lblRdo.Name = "lblRdo";
            this.lblRdo.Size = new System.Drawing.Size(0, 31);
            this.lblRdo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(793, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chi Cuadrado Calculado";
            // 
            // listValores
            // 
            this.listValores.FormattingEnabled = true;
            this.listValores.Location = new System.Drawing.Point(0, 0);
            this.listValores.MultiColumn = true;
            this.listValores.Name = "listValores";
            this.listValores.Size = new System.Drawing.Size(1113, 485);
            this.listValores.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(413, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(796, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Chi Cuadrado Tabulado";
            // 
            // lblXiTabulado
            // 
            this.lblXiTabulado.AutoSize = true;
            this.lblXiTabulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXiTabulado.ForeColor = System.Drawing.Color.Blue;
            this.lblXiTabulado.Location = new System.Drawing.Point(985, 60);
            this.lblXiTabulado.Name = "lblXiTabulado";
            this.lblXiTabulado.Size = new System.Drawing.Size(0, 31);
            this.lblXiTabulado.TabIndex = 27;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Blue;
            this.lblResultado.Location = new System.Drawing.Point(127, 31);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 31);
            this.lblResultado.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "RESULTADO";
            // 
            // lblGradosLibertad
            // 
            this.lblGradosLibertad.AutoSize = true;
            this.lblGradosLibertad.Location = new System.Drawing.Point(9, 11);
            this.lblGradosLibertad.Name = "lblGradosLibertad";
            this.lblGradosLibertad.Size = new System.Drawing.Size(103, 13);
            this.lblGradosLibertad.TabIndex = 30;
            this.lblGradosLibertad.Text = "Grados de Libertad: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 650);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Constantin - Loza - Micheletti - Soaje";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 134);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1114, 513);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listValores);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1110, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Variables";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gvTest);
            this.tabPage2.Controls.Add(this.lblGradosLibertad);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lblResultado);
            this.tabPage2.Controls.Add(this.lblRdo);
            this.tabPage2.Controls.Add(this.lblXiTabulado);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1110, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test de Chi Cuadrado";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grafico);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1106, 487);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gráfico";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1018, 650);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "4K4 - 2020";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.pnlNormal);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.pnlExponencial);
            this.groupBox1.Controls.Add(this.pnlPoisson);
            this.groupBox1.Controls.Add(this.cbmIntervalos);
            this.groupBox1.Controls.Add(this.lblIntervalos);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 98);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbdNormal);
            this.groupBox2.Controls.Add(this.rbdExponencial);
            this.groupBox2.Controls.Add(this.rbdPoisson);
            this.groupBox2.Location = new System.Drawing.Point(381, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 79);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distribución";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Test";
            this.Text = "Simulación - TP3";
            this.Load += new System.EventHandler(this.Test_Load);
            this.pnlPoisson.ResumeLayout(false);
            this.pnlPoisson.PerformLayout();
            this.pnlNormal.ResumeLayout(false);
            this.pnlNormal.PerformLayout();
            this.pnlExponencial.ResumeLayout(false);
            this.pnlExponencial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPoisson;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Label lblLambda;
        private System.Windows.Forms.Panel pnlNormal;
        private System.Windows.Forms.TextBox txtDesviacion;
        private System.Windows.Forms.TextBox txtMediaNormal;
        private System.Windows.Forms.Label lblDesviacion;
        private System.Windows.Forms.Label lblMediaNormal;
        private System.Windows.Forms.Panel pnlExponencial;
        private System.Windows.Forms.TextBox txtMediaExpo;
        private System.Windows.Forms.Label lblMediaExpo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.RadioButton rbdPoisson;
        private System.Windows.Forms.RadioButton rbdNormal;
        private System.Windows.Forms.RadioButton rbdExponencial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRdo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.DataGridView gvTest;
        private System.Windows.Forms.ComboBox cbmIntervalos;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ListBox listValores;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblXiTabulado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGradosLibertad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}