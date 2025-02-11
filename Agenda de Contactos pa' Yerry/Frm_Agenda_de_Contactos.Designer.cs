
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(158, 111);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(173, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.WordWrap = false;
            // 
            // txt_numero
            // 
            this.txt_numero.Enabled = false;
            this.txt_numero.Location = new System.Drawing.Point(158, 147);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(173, 20);
            this.txt_numero.TabIndex = 1;
            this.txt_numero.WordWrap = false;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nombre.Location = new System.Drawing.Point(61, 114);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(91, 13);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "Nombre Completo";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.numero.Location = new System.Drawing.Point(78, 147);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(44, 13);
            this.numero.TabIndex = 3;
            this.numero.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Agenda de Contactos [Giovanni Goku Company]";
            // 
            // btn_guardar
            // 
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardar.Location = new System.Drawing.Point(61, 184);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(113, 27);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Visible = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancelar.Location = new System.Drawing.Point(180, 184);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(113, 27);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Visible = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Click);
            // 
            // dgv_principal
            // 
            this.dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_principal.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_principal.GridColor = System.Drawing.Color.Black;
            this.dgv_principal.Location = new System.Drawing.Point(415, 58);
            this.dgv_principal.Name = "dgv_principal";
            this.dgv_principal.Size = new System.Drawing.Size(363, 380);
            this.dgv_principal.TabIndex = 10;
            this.dgv_principal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(299, 184);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(110, 27);
            this.btn_modificar.TabIndex = 11;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Visible = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_Modificar);
            // 
            // btn_nuevecito
            // 
            this.btn_nuevecito.Location = new System.Drawing.Point(183, 217);
            this.btn_nuevecito.Name = "btn_nuevecito";
            this.btn_nuevecito.Size = new System.Drawing.Size(110, 27);
            this.btn_nuevecito.TabIndex = 12;
            this.btn_nuevecito.Text = "Nuevecito🔥";
            this.btn_nuevecito.UseVisualStyleBackColor = true;
            this.btn_nuevecito.Click += new System.EventHandler(this.btn_nuevecito_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.id.Location = new System.Drawing.Point(87, 77);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 13);
            this.id.TabIndex = 13;
            this.id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(158, 77);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(173, 20);
            this.txt_id.TabIndex = 14;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            this.txt_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyDown);
            // 
            // btn_buscar
            // 
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_buscar.Location = new System.Drawing.Point(745, 27);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(33, 20);
            this.btn_buscar.TabIndex = 17;
            this.btn_buscar.Text = "🔍";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Enabled = false;
            this.txt_Buscar.Location = new System.Drawing.Point(415, 28);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(324, 20);
            this.txt_Buscar.TabIndex = 18;
            this.txt_Buscar.WordWrap = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(337, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 20);
            this.button1.TabIndex = 19;
            this.button1.Text = "🔍";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_buscar_id);
            // 
            // Agenda_de_Contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_nombre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Agenda_de_Contactos";
            this.Text = "Agenda de Contactos";
            this.Load += new System.EventHandler(this.Agenda_de_Contactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_numero;
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
        private System.Windows.Forms.Button button1;
    }
}

