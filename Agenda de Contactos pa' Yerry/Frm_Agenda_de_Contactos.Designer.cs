
namespace Agenda_de_Contactos_pa__Yerry
{
    partial class Agenda_de_Contactos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda_de_Contactos));
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dgv_principal = new System.Windows.Forms.DataGridView();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_nuevecito = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar_id = new System.Windows.Forms.Button();
            this.refrequito_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(172, 134);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(173, 20);
            this.txt_nombre.TabIndex = 3;
            this.txt_nombre.WordWrap = false;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nombre.Location = new System.Drawing.Point(75, 137);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(91, 13);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "Nombre Completo";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.numero.Location = new System.Drawing.Point(92, 170);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(44, 13);
            this.numero.TabIndex = 3;
            this.numero.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(168, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda de Contactos";
            // 
            // btn_guardar
            // 
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardar.Location = new System.Drawing.Point(75, 207);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(113, 27);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancelar.Location = new System.Drawing.Point(194, 207);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(113, 27);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Limpiar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Click);
            // 
            // dgv_principal
            // 
            this.dgv_principal.AllowUserToAddRows = false;
            this.dgv_principal.AllowUserToDeleteRows = false;
            this.dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_principal.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_principal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_principal.GridColor = System.Drawing.Color.Black;
            this.dgv_principal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_principal.Location = new System.Drawing.Point(429, 59);
            this.dgv_principal.Name = "dgv_principal";
            this.dgv_principal.Size = new System.Drawing.Size(363, 380);
            this.dgv_principal.TabIndex = 12;
            this.dgv_principal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(313, 207);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(110, 27);
            this.btn_modificar.TabIndex = 7;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_Modificar);
            // 
            // btn_nuevecito
            // 
            this.btn_nuevecito.Location = new System.Drawing.Point(197, 240);
            this.btn_nuevecito.Name = "btn_nuevecito";
            this.btn_nuevecito.Size = new System.Drawing.Size(110, 27);
            this.btn_nuevecito.TabIndex = 8;
            this.btn_nuevecito.Text = "Nuevecito🔥";
            this.btn_nuevecito.UseVisualStyleBackColor = true;
            this.btn_nuevecito.Click += new System.EventHandler(this.btn_nuevecito_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.id.Location = new System.Drawing.Point(101, 100);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 13);
            this.id.TabIndex = 13;
            this.id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(172, 100);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(173, 20);
            this.txt_id.TabIndex = 1;
            this.txt_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyDown);
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // btn_buscar
            // 
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_buscar.Location = new System.Drawing.Point(759, 28);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(33, 20);
            this.btn_buscar.TabIndex = 11;
            this.btn_buscar.Text = "🔍";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(429, 29);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(291, 20);
            this.txt_Buscar.TabIndex = 9;
            this.txt_Buscar.WordWrap = false;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_numero_TextChanged);
            this.txt_Buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_keyDown_Search);
            // 
            // btn_buscar_id
            // 
            this.btn_buscar_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_buscar_id.Location = new System.Drawing.Point(351, 100);
            this.btn_buscar_id.Name = "btn_buscar_id";
            this.btn_buscar_id.Size = new System.Drawing.Size(33, 20);
            this.btn_buscar_id.TabIndex = 2;
            this.btn_buscar_id.Text = "🔍";
            this.btn_buscar_id.UseVisualStyleBackColor = true;
            this.btn_buscar_id.Click += new System.EventHandler(this.btn_buscar_id_Click);
            // 
            // refrequito_btn
            // 
            this.refrequito_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.refrequito_btn.Location = new System.Drawing.Point(726, 28);
            this.refrequito_btn.Name = "refrequito_btn";
            this.refrequito_btn.Size = new System.Drawing.Size(33, 20);
            this.refrequito_btn.TabIndex = 10;
            this.refrequito_btn.Text = "🔄";
            this.refrequito_btn.UseVisualStyleBackColor = true;
            this.refrequito_btn.Click += new System.EventHandler(this.refrequito_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(289, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Giovanni Goku Company®";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(172, 167);
            this.txt_numero.Mask = "000-000-0000";
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(173, 20);
            this.txt_numero.TabIndex = 4;
            // 
            // Agenda_de_Contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(827, 497);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refrequito_btn);
            this.Controls.Add(this.btn_buscar_id);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.id);
            this.Controls.Add(this.btn_nuevecito);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgv_principal);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.txt_nombre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agenda_de_Contactos";
            this.Text = "Agenda de Contactos";
            this.Load += new System.EventHandler(this.Agenda_de_Contactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridView dgv_principal;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_nuevecito;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button btn_buscar_id;
        private System.Windows.Forms.Button refrequito_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_numero;
    }
}

