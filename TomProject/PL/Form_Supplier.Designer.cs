namespace TomProject.PL
{
    partial class Form_Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Supplier));
            this.label2 = new System.Windows.Forms.Label();
            this.العنوان = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.Txtphone = new DevExpress.XtraEditors.TextEdit();
            this.Txtaddress = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Notes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.combType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtnotes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtphone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtaddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(51, 23);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم";
            // 
            // العنوان
            // 
            this.العنوان.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.العنوان.AutoSize = true;
            this.العنوان.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.العنوان.Location = new System.Drawing.Point(49, 83);
            this.العنوان.Name = "العنوان";
            this.العنوان.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.العنوان.Size = new System.Drawing.Size(49, 16);
            this.العنوان.TabIndex = 2;
            this.العنوان.Text = "العنوان";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 148);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم التليفون";
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.Location = new System.Drawing.Point(148, 19);
            this.TxtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(169, 20);
            this.TxtName.TabIndex = 6;
            // 
            // Txtphone
            // 
            this.Txtphone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txtphone.Location = new System.Drawing.Point(148, 146);
            this.Txtphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtphone.Name = "Txtphone";
            this.Txtphone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.Txtphone.Properties.MaskSettings.Set("mask", "d");
            this.Txtphone.Size = new System.Drawing.Size(169, 20);
            this.Txtphone.TabIndex = 7;
            // 
            // Txtaddress
            // 
            this.Txtaddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txtaddress.Location = new System.Drawing.Point(148, 78);
            this.Txtaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtaddress.Name = "Txtaddress";
            this.Txtaddress.Size = new System.Drawing.Size(169, 20);
            this.Txtaddress.TabIndex = 8;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.Silver;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(508, 219);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton3.Size = new System.Drawing.Size(146, 41);
            this.simpleButton3.TabIndex = 84;
            this.simpleButton3.Text = "طباعه الفواتير";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.Silver;
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.simpleButton5.Location = new System.Drawing.Point(309, 219);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton5.Size = new System.Drawing.Size(146, 41);
            this.simpleButton5.TabIndex = 83;
            this.simpleButton5.Text = "تعديل البيانات";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton7.Appearance.BackColor = System.Drawing.Color.Silver;
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton7.Appearance.Options.UseBackColor = true;
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton7.ImageOptions.SvgImage")));
            this.simpleButton7.Location = new System.Drawing.Point(117, 219);
            this.simpleButton7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton7.Size = new System.Drawing.Size(146, 41);
            this.simpleButton7.TabIndex = 81;
            this.simpleButton7.Text = "حفظ البيانات";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 275);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(801, 296);
            this.gridControl1.TabIndex = 85;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Phone,
            this.ID,
            this.Type,
            this.Notes,
            this.sName,
            this.Address});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick_1);
            // 
            // Phone
            // 
            this.Phone.Caption = "رقم الهاتف";
            this.Phone.FieldName = "Phone";
            this.Phone.MinWidth = 21;
            this.Phone.Name = "Phone";
            this.Phone.Visible = true;
            this.Phone.VisibleIndex = 3;
            this.Phone.Width = 81;
            // 
            // ID
            // 
            this.ID.Caption = "م";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 21;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 81;
            // 
            // Type
            // 
            this.Type.Caption = "النوع";
            this.Type.FieldName = "Type";
            this.Type.MinWidth = 21;
            this.Type.Name = "Type";
            this.Type.Visible = true;
            this.Type.VisibleIndex = 4;
            this.Type.Width = 81;
            // 
            // Notes
            // 
            this.Notes.Caption = "الملاحظات";
            this.Notes.FieldName = "Notes";
            this.Notes.MinWidth = 21;
            this.Notes.Name = "Notes";
            this.Notes.Visible = true;
            this.Notes.VisibleIndex = 5;
            this.Notes.Width = 81;
            // 
            // sName
            // 
            this.sName.Caption = "الاسم";
            this.sName.FieldName = "sName";
            this.sName.MinWidth = 21;
            this.sName.Name = "sName";
            this.sName.Visible = true;
            this.sName.VisibleIndex = 1;
            this.sName.Width = 81;
            // 
            // Address
            // 
            this.Address.Caption = "العنوان";
            this.Address.FieldName = "Address";
            this.Address.MinWidth = 21;
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 2;
            this.Address.Width = 81;
            // 
            // combType
            // 
            this.combType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.combType.Location = new System.Drawing.Point(508, 19);
            this.combType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combType.Name = "combType";
            this.combType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combType.Properties.Items.AddRange(new object[] {
            "تعبئة ",
            "عادى"});
            this.combType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.combType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combType.Size = new System.Drawing.Size(221, 20);
            this.combType.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(419, 24);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 88;
            this.label4.Text = "النوع";
            // 
            // Txtnotes
            // 
            this.Txtnotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txtnotes.Location = new System.Drawing.Point(508, 83);
            this.Txtnotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtnotes.Name = "Txtnotes";
            this.Txtnotes.Size = new System.Drawing.Size(221, 85);
            this.Txtnotes.TabIndex = 87;
            this.Txtnotes.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(419, 112);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 86;
            this.label3.Text = "الملاحظات";
            // 
            // Form_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 571);
            this.Controls.Add(this.combType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtnotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.Txtaddress);
            this.Controls.Add(this.Txtphone);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.العنوان);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Supplier";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الموردين";
            this.Load += new System.EventHandler(this.Form_Supplier_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtphone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtaddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label العنوان;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.TextEdit Txtphone;
        private DevExpress.XtraEditors.TextEdit Txtaddress;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Type;
        private DevExpress.XtraGrid.Columns.GridColumn Notes;
        private DevExpress.XtraGrid.Columns.GridColumn sName;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraEditors.ComboBoxEdit combType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Txtnotes;
        private System.Windows.Forms.Label label3;
    }
}