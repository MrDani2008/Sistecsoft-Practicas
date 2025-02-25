using Datos;
using Entidad;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

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
            try
            {
                dgv_principal.RowHeadersVisible = false;

                Hablilitar_campos(true, false, false);
                Habilitar_botones(false, false, false, true, true);
                txt_nombre.Focus();

                LlenarGrid();
            }
            catch (Exception ex) { CrearArchivoLog(ex); }
        }

        public void LlenarGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = new DAgendaDeContactos().SListaAgendaDeContactos();

                dgv_principal.DataSource = dt;
                dgv_principal.Refresh();
            }
            catch (Exception ex) { MessageBox.Show("Ocurrio un Error al ejecutar esta función"); CrearArchivoLog(ex); }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarGrid();
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

                MessageBox.Show("Guardado con exito");

                Habilitar_botones(false, false, false, true, true);
                Hablilitar_campos(true, false, false);
                Limpiar();
            }
            catch (Exception ex)
            {
                CrearArchivoLog(ex);
                MessageBox.Show("Error al guardar el registro.");
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string nombre = dgv_principal.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                    string numero = dgv_principal.Rows[e.RowIndex].Cells["NUMERO"].Value.ToString();
                    string id = dgv_principal.Rows[e.RowIndex].Cells["id_agenda_de_contactos"].Value.ToString();

                    txt_id.Text = id;
                    txt_nombre.Text = nombre;
                    txt_numero.Text = numero;
                    Hablilitar_campos(false, false, false);
                    Habilitar_botones(false, true, true, true, true);
                }

            }
            catch (Exception ex)
            {
                CrearArchivoLog(ex);
                MessageBox.Show("Error al seleccionar el registro.");
            }
        }

        private void btn_nuevecito_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                Hablilitar_campos(false, true, true);
                Habilitar_botones(true, true, false, false, false);
                txt_nombre.Focus();
            }
            catch (Exception ex) { MessageBox.Show("Ocurrio un Error al ejecutar esta función"); CrearArchivoLog(ex); }
        }

        public void btn_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                Hablilitar_campos(true, false, false);
                Habilitar_botones(false, false, false, true, true);
            }
            catch (Exception ex) { MessageBox.Show("Ocurrio un Error al ejecutar esta función"); CrearArchivoLog(ex); }
        }

        private void btn_Modificar(object sender, EventArgs e)
        {
            try
            {
                Habilitar_botones(true, true, false, false, true);
                Hablilitar_campos(false, true, true);
                txt_nombre.Focus();
            }
            catch (Exception ex) { MessageBox.Show("Ocurrio un Error al ejecutar esta función"); CrearArchivoLog(ex); }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Buscar.Enabled = true;
                string query = txt_Buscar.Text;
                DAgendaDeContactos dAgenda = new DAgendaDeContactos();
                DataTable dt = dAgenda.SListaAgenda_de_contactosBusqueda(query);


                dgv_principal.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Ocurrio un Error al ejecutar esta función"); CrearArchivoLog(ex); }
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

            try
            {
                int idAgendaContactos = IntParse(txt_id.Text);

                DataTable dtAgenda = new DAgendaDeContactos().SAgendaDeContactos(idAgendaContactos);

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
            catch (Exception ex) { MessageBox.Show("Ocurrio un Error al ejecutar esta función"); CrearArchivoLog(ex); }
        }
        private void btn_buscar_id_Click(object sender, EventArgs e)
        {

            try
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
            catch (Exception ex) { MessageBox.Show("Ocurrio un Error al ejecutar esta función");  CrearArchivoLog(ex); }
        }
        private void Habilitar_botones(bool guardar, bool cancelar, bool modificar, bool nuevo, bool id)
        {
            btn_guardar.Enabled = guardar;
            btn_Cancelar.Enabled = cancelar;
            btn_modificar.Enabled = modificar;
            btn_nuevecito.Enabled = nuevo;
            btn_buscar_id.Enabled = id;
        }
        private void Hablilitar_campos(bool id, bool nombre, bool numero)
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

        private void txt_keyDown_Search(object sender, KeyEventArgs e)
        {



            try
            {
                if (e.KeyCode == Keys.Enter) // Detectar si el usuario presionó "Enter"
                {
                    string query = txt_Buscar.Text.Trim(); // Obtener el texto de búsqueda

                    if (!string.IsNullOrEmpty(query)) // Verificar que la consulta no esté vacía
                    {
                        DAgendaDeContactos dAgenda = new DAgendaDeContactos();
                        DataTable dt = dAgenda.SListaAgenda_de_contactosBusqueda(query); // Pasar el texto de búsqueda al método

                        dgv_principal.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese un término de búsqueda.");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Ocurrio un Error al ejecutar esta función"); CrearArchivoLog(ex); }
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void refrequito_btn_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Buscar.Clear();
                LlenarGrid();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocurrio un Error al ejecutar esta función");
                CrearArchivoLog(ex); }
        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {
            txt_numero.MaxLength = 14;



        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')')
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocurrio un Error al ejecutar esta función");
                CrearArchivoLog(ex); }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }catch(Exception ex) 
            {   
                MessageBox.Show ("Ocurrio un Error al ejecutar esta función");
                CrearArchivoLog(ex); }
        }
        private void CrearArchivoLog(Exception exception)
        {
            try
            {
                // Obtener la fecha actual en el formato deseado
                string fechaActual = DateTime.Now.ToString("dd-MM-yyyy");

                // Definir la ruta donde se guardará el archivo de log
                string rutaDirectorio = Path.Combine(Application.StartupPath, "Temp", "Log");

                // Crear el directorio si no existe
                if (!Directory.Exists(rutaDirectorio))
                {
                    Directory.CreateDirectory(rutaDirectorio);
                }

                // Definir la ruta completa del archivo de log
                string rutaArchivo = Path.Combine(rutaDirectorio, $"{fechaActual}.txt");

                // Crear el archivo de log y escribir algo

                using (StreamWriter archivoLog = new StreamWriter(rutaArchivo, true))
                {
                    archivoLog.WriteLine("----- Error registrado -----");
                    archivoLog.WriteLine($"Fecha y hora: {DateTime.Now}");
                    archivoLog.WriteLine($"Mensaje de error: {exception.Message}");
                    archivoLog.WriteLine("---------------------------------------------------");
                    archivoLog.WriteLine($"Stack Trace: {exception.StackTrace}");
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}