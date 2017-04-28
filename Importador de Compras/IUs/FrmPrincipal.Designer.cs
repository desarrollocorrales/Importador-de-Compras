namespace Importador_de_Compras.IUs
{
    partial class FrmPrincipal
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
            this.gridConceptos = new DevExpress.XtraGrid.GridControl();
            this.comprobanteConceptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvConceptos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnoIdentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalorUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ofdXML = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteConceptoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConceptos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridConceptos
            // 
            this.gridConceptos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridConceptos.DataSource = this.comprobanteConceptoBindingSource;
            this.gridConceptos.Location = new System.Drawing.Point(12, 104);
            this.gridConceptos.MainView = this.gvConceptos;
            this.gridConceptos.Name = "gridConceptos";
            this.gridConceptos.Size = new System.Drawing.Size(960, 462);
            this.gridConceptos.TabIndex = 0;
            this.gridConceptos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConceptos});
            // 
            // comprobanteConceptoBindingSource
            // 
            this.comprobanteConceptoBindingSource.DataSource = typeof(ComprobanteConcepto);
            // 
            // gvConceptos
            // 
            this.gvConceptos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcantidad,
            this.colunidad,
            this.colnoIdentificacion,
            this.coldescripcion,
            this.colvalorUnitario,
            this.colimporte});
            this.gvConceptos.GridControl = this.gridConceptos;
            this.gvConceptos.Name = "gvConceptos";
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 0;
            // 
            // colunidad
            // 
            this.colunidad.Caption = "Unidad";
            this.colunidad.FieldName = "unidad";
            this.colunidad.Name = "colunidad";
            this.colunidad.OptionsColumn.AllowEdit = false;
            this.colunidad.Visible = true;
            this.colunidad.VisibleIndex = 1;
            // 
            // colnoIdentificacion
            // 
            this.colnoIdentificacion.Caption = "No Identificacion";
            this.colnoIdentificacion.FieldName = "noIdentificacion";
            this.colnoIdentificacion.Name = "colnoIdentificacion";
            this.colnoIdentificacion.Visible = true;
            this.colnoIdentificacion.VisibleIndex = 2;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 3;
            // 
            // colvalorUnitario
            // 
            this.colvalorUnitario.Caption = "Valor Unitario";
            this.colvalorUnitario.FieldName = "valorUnitario";
            this.colvalorUnitario.Name = "colvalorUnitario";
            this.colvalorUnitario.OptionsColumn.AllowEdit = false;
            this.colvalorUnitario.Visible = true;
            this.colvalorUnitario.VisibleIndex = 4;
            // 
            // colimporte
            // 
            this.colimporte.Caption = "Importe";
            this.colimporte.FieldName = "importe";
            this.colimporte.Name = "colimporte";
            this.colimporte.OptionsColumn.AllowEdit = false;
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "XML Factura:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(131, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(742, 26);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(879, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cargar XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ofdXML
            // 
            this.ofdXML.FileName = "*.xml";
            this.ofdXML.Filter = "Archivos XML | *.xml";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(407, 572);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Importar a Microsip";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(984, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Importar Compras a Microsip";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridConceptos);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.gridConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteConceptoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConceptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridConceptos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConceptos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog ofdXML;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource comprobanteConceptoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
        private DevExpress.XtraGrid.Columns.GridColumn colnoIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colvalorUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
    }
}