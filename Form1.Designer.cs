namespace WinFormsApp1
{
    partial class inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.direcciontxt = new System.Windows.Forms.TextBox();
            this.apellidotxt = new System.Windows.Forms.TextBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.btsalir = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.btcrear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Idlv = new System.Windows.Forms.ColumnHeader();
            this.Nombrelv = new System.Windows.Forms.ColumnHeader();
            this.Apellidolv = new System.Windows.Forms.ColumnHeader();
            this.Direccionlv = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.direcciontxt);
            this.groupBox1.Controls.Add(this.apellidotxt);
            this.groupBox1.Controls.Add(this.nombretxt);
            this.groupBox1.Controls.Add(this.idtxt);
            this.groupBox1.Controls.Add(this.bteliminar);
            this.groupBox1.Controls.Add(this.btcrear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            this.groupBox1.UseWaitCursor = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // direcciontxt
            // 
            this.direcciontxt.Location = new System.Drawing.Point(100, 153);
            this.direcciontxt.Name = "direcciontxt";
            this.direcciontxt.Size = new System.Drawing.Size(153, 23);
            this.direcciontxt.TabIndex = 10;
            this.direcciontxt.UseWaitCursor = true;
            // 
            // apellidotxt
            // 
            this.apellidotxt.Location = new System.Drawing.Point(100, 108);
            this.apellidotxt.Name = "apellidotxt";
            this.apellidotxt.Size = new System.Drawing.Size(153, 23);
            this.apellidotxt.TabIndex = 9;
            this.apellidotxt.UseWaitCursor = true;
            // 
            // nombretxt
            // 
            this.nombretxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombretxt.Location = new System.Drawing.Point(100, 70);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(153, 23);
            this.nombretxt.TabIndex = 8;
            this.nombretxt.UseWaitCursor = true;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(100, 28);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(153, 23);
            this.idtxt.TabIndex = 7;
            this.idtxt.UseWaitCursor = true;
            // 
            // btsalir
            // 
            this.btsalir.Location = new System.Drawing.Point(709, 389);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(83, 52);
            this.btsalir.TabIndex = 6;
            this.btsalir.Text = "Salir";
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.UseWaitCursor = true;
            this.btsalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(218, 210);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(75, 23);
            this.bteliminar.TabIndex = 5;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.UseWaitCursor = true;
            this.bteliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btcrear
            // 
            this.btcrear.Location = new System.Drawing.Point(92, 210);
            this.btcrear.Name = "btcrear";
            this.btcrear.Size = new System.Drawing.Size(75, 23);
            this.btcrear.TabIndex = 4;
            this.btcrear.Text = "Crear";
            this.btcrear.UseVisualStyleBackColor = true;
            this.btcrear.UseWaitCursor = true;
            this.btcrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion:";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.UseWaitCursor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Idlv,
            this.Nombrelv,
            this.Apellidolv,
            this.Direccionlv});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(50, 294);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(553, 134);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseWaitCursor = true;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Idlv
            // 
            this.Idlv.Text = "ID";
            // 
            // Nombrelv
            // 
            this.Nombrelv.Text = "Nombre";
            // 
            // Apellidolv
            // 
            this.Apellidolv.Text = "Apellido";
            // 
            // Direccionlv
            // 
            this.Direccionlv.Text = "Direccion";
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 462);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btsalir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox direcciontxt;
        private TextBox apellidotxt;
        private TextBox nombretxt;
        private TextBox idtxt;
        private Button btsalir;
        private Button bteliminar;
        private Button btcrear;
        private ListView listView1;
        private ColumnHeader Idlv;
        private ColumnHeader Nombrelv;
        private ColumnHeader Apellidolv;
        private ColumnHeader Direccionlv;
    }
}