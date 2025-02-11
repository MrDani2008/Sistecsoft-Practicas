using Datos;
using Entidad;
using System;
using System.Data;
using System.Windows.Forms;

namespace Agenda_de_Contactos_pa__Yerry
{
    public partial class Agenda_de_Contactos : Form
    {
        public Agenda_de_Contactos()
        {
            InitializeComponent();

        }

        private void Agenda_de_Contactos_Load(object sender, EventArgs e)
        {
            dgv_principal.RowHeadersVisible = false;
            
            Hablilitar_campos(true,false,false);
            Habilitar_botones(false, false, false, true,true);
            txt_nombre.Focus();
            
            LlenarGrid();
        }

        public void LlenarGrid()
        {
            DataTable dt = new DataTable();
            dt = new DAgendaDeContactos().SListaAgendaDeContactos();

            dgv_principal.DataSource = dt;
            dgv_principal.Refresh();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_numero.Text))
            {
                MessageBox.Show("Eso esta vacio maton, ponga algo", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EAgendaDeContactos eAgendaDeContactos = new EAgendaDeContactos();
            eAgendaDeContactos.id_agenda_de_contactos = IntParse(txt_id.Text);
            eAgendaDeContactos.nombre = txt_nombre.Text;
            eAgendaDeContactos.numero = txt_numero.Text;

            if (eAgendaDeContactos.id_agenda_de_contactos == 0)
            {
                eAgendaDeContactos.id_agenda_de_contactos = new DAgendaDeContactos().IAgendaDeContactos(eAgendaDeContactos);
                txt_id.Text = eAgendaDeContactos.id_agenda_de_contactos.ToString();
            }
            else
            {
                new DAgendaDeContactos().UAgendaDeContactos(eAgendaDeContactos);
            }
            Habilitar_botones(false, false, false, true,true);
            Hablilitar_campos(true, false, false);
            Limpiar();

            MessageBox.Show("Guardado con exito");
            LlenarGrid();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nombre = dgv_principal.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                string numero = dgv_principal.Rows[e.RowIndex].Cells["NUMERO"].Value.ToString();
                string id = dgv_principal.Rows[e.RowIndex].Cells["id_agenda_de_contactos"].Value.ToString();

                txt_id.Text = id;
                txt_nombre.Text = nombre;
                txt_numero.Text = numero;
            }
            Hablilitar_campos(false, false, false);
            Habilitar_botones(false, true, true, true,true);
        }

        private void btn_nuevecito_Click(object sender, EventArgs e)
        {
            Limpiar();
            Hablilitar_campos(false, true, true);
            Habilitar_botones(true, true, false, false,false);
            txt_nombre.Focus();
        }

        public void btn_Click(object sender, EventArgs e)
        {
            Limpiar();
            Hablilitar_campos(true,false,false);
            Habilitar_botones(false, false, false, true,true);

        }

        private void btn_Modificar(object sender, EventArgs e)
        {
            Habilitar_botones(true, true, false, false,true);
            Hablilitar_campos(false, true, true);
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            txt_Buscar.Enabled = true;
            string query = txt_Buscar.Text;
            DAgendaDeContactos dAgenda = new DAgendaDeContactos();
            DataTable dt = dAgenda.EjecutarBusqueda(query);


            dgv_principal.DataSource = dt;
            
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
 
            
        }

        public int IntParse(object numero)
        {
            int result = 0;
            string valor = StringParse(numero);
            int.TryParse(valor, out result);
            return result;
        }

        public string StringParse(object valor)
        {
            return valor != null ? valor.ToString() : "";
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            int idAgenda = IntParse(txt_id.Text);

            DataTable dtAgenda = new DAgendaDeContactos().SAgendaDeContactos(idAgenda);

            if (e.KeyCode == Keys.Enter) // Detectar si el usuario presionó "Enter"
            {

                if (dtAgenda.Rows.Count > 0) // Verificar si hay resultados
                {
                    txt_nombre.Text = dtAgenda.Rows[0]["nombre"].ToString();
                    txt_numero.Text = dtAgenda.Rows[0]["numero"].ToString();
                    Habilitar_botones(false, false, true, false, false);


                }
                else
                {
                    MessageBox.Show("Contacto no encontrado");
                }
            }

        }
        private void btn_buscar_id_Click(object sender, EventArgs e)
        {
            int idAgenda = IntParse(txt_id.Text);
            DataTable dtAgenda = new DAgendaDeContactos().SAgendaDeContactos(idAgenda);


            if (dtAgenda.Rows.Count > 0) // Verificar si hay resultados
            {
                txt_nombre.Text = dtAgenda.Rows[0]["nombre"].ToString();
                txt_numero.Text = dtAgenda.Rows[0]["numero"].ToString();
                Habilitar_botones(false, false, true, false, false);
            }
            else
            {
                MessageBox.Show("Contacto no encontrado");

            }
        }
        private void Habilitar_botones(bool guardar, bool cancelar, bool modificar, bool nuevo, bool id)
        {
            btn_guardar.Enabled = guardar;
            btn_Cancelar.Enabled = cancelar;
            btn_modificar.Enabled = modificar;
            btn_nuevecito.Enabled = nuevo;
            btn_buscar_id.Enabled = id;
        }
        private void Hablilitar_campos(bool id,bool nombre, bool numero)
        {
            txt_id.Enabled = id;
            txt_nombre.Enabled = nombre;
            txt_numero.Enabled = numero;
        }
        private void Limpiar()
        {
            txt_id.Clear();
            txt_nombre.Clear();
            txt_numero.Clear();
        }
        
    }
}

